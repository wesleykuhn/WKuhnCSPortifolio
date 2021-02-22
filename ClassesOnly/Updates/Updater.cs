using ClassesOnly.HttpRequests;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;

namespace ClassesOnly.Updates
{
    public static class Updater
    {
        //Este é o diretório de onde fica o atualizador da aplicação (Ele deve ser compilado junto com a aplicação quando for gerar o instalador MSI da mesma, afim 
        // de ser instalado junto com a aplicação):
        private static readonly string UpdaterDirectory = Environment.CurrentDirectory + "MyUpdater.exe";

        /// <summary>
        /// Check if there's updates avaliable for the updater.
        /// </summary>
        /// <param name="updaterVersionUri">The Uri of the API, from where the check will be done.</param>
        /// <returns>A task when the method is completed.</returns>
        public async static Task CheckForUpdates()
        {
            if (!File.Exists(UpdaterDirectory))
            {
                Exception ex = new Exception("The application's updater file wasn't found!");

                ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(ex.Message);

                throw ex;
            }

            await Check(new HttpGet(Informations.ApiUris.UpdaterVersionCheckerUri, null));
        }

        //Este método vai pesquisar se a versão atual de uma aplicação é diferente da local. Então, caso seja, faz a atualização automaticamente.
        private static async Task Check(HttpGet httpGet)
        {
            string currentVersion = await ExceptionsHandling.HandleHttpRequest.HandleGetAsync(httpGet);

            try
            {
                if (httpGet.StatusCode != 200)
                {
                    Exception statusCodeEx = new Exception("Update Updater Status Code diferent of 200!");

                    ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(statusCodeEx.Message);

                    throw statusCodeEx;
                }

                FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(UpdaterDirectory);
                string thisVersion = versionInfo.FileVersion;

                if (currentVersion != thisVersion)
                {
                    //O código comentado a baixo fazia parte de um projeto pessoal onde haviam formulários genéricos. No de baixo era apenas um formulário informátivo, sem retorno:
                    //FRM_Information.Show("O atualizador vai ser atualizado. Clique em 'Entendi' para continuar...", Style.KuhnperColors.BootstrapRed, FRM_Information.FormSounds.Exclamation);

                    //A linha a abaixo foi inserida para substituir o código comentado a cima:
                    Console.WriteLine("O atualizador está sendo atualizado.");

                    //O manuseio das classes WebRequest e WebClient foram tirados de um tópico do site StackOverflow.
                    WebRequest.DefaultWebProxy = null;

                    string fomattedVersion = currentVersion.Replace('.', '_');
                    //The download
                    string zipFileName = "kpup_" + fomattedVersion + ".zip";
                    using (WebClient wc = new WebClient())
                    {
                        Uri uri = new Uri("http://www.kuhnper.com.br/updaterversions/" + zipFileName);

                        wc.Headers.Add("User-Agent: Other");
                        wc.Proxy = null;
                        wc.DownloadFile(uri, "temp.zip");
                    }

                    //The extraction and Overwrite
                    string zipDir = @".\temp.zip";
                    string targetDir = @".\";

                    DirectoryInfo di = Directory.CreateDirectory(targetDir);
                    string targetPath = di.FullName;

                    using (FileStream fs = new FileStream(zipDir, FileMode.Open))
                    {
                        using (ZipArchive za = new ZipArchive(fs))
                        {
                            int eachOneValue = 50 / za.Entries.Count;

                            foreach (ZipArchiveEntry file in za.Entries)
                            {
                                string completeFileName = Path.GetFullPath(Path.Combine(targetPath, file.FullName));

                                if (!completeFileName.StartsWith(targetPath, StringComparison.OrdinalIgnoreCase))
                                {
                                    //O código a baixo também fazia parte do projeto pessoal. Nele era mostrado apenas um informativo:
                                    //FRM_Information.Show("Ocorreu um erro fatal ao tentar atualizar o atualizador! Por favor, abra o programa e tente novamente. Se o erro persistir entre em contato com o suporte.", Style.KuhnperColors.BootstrapRed, FRM_Information.FormSounds.Error);

                                    //Substituição do código comentado de cima:
                                    Console.WriteLine("Ocorreu um erro fatal ao tentar atualizar o atualizador! Por favor, abra o programa e tente novamente. Se o erro persistir entre em contato com o suporte. Pressione qualquer tecla para continuar...");
                                    Console.ReadKey();

                                    Environment.Exit(0);
                                }

                                if (file.Name == "")
                                {
                                    // Assuming Empty for Directory
                                    Directory.CreateDirectory(Path.GetDirectoryName(completeFileName));
                                    continue;
                                }

                                file.ExtractToFile(completeFileName, true);
                            }
                        }
                    }

                    File.Delete(@".\temp.zip");

                    //Código de projeto pessoal a baixo:
                    //FRM_Information.Show("O atualizador foi atualizado com sucesso! Clique em 'OK' para continuar.", Style.KuhnperColors.BootstrapRed, FRM_Information.FormSounds.Exclamation);

                    //Substituição do que foi comentado:
                    Console.WriteLine("O atualizador foi atualizado com sucesso! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(ex.Message);

                //Código de projeto pessoal a baixo:
                //FRM_Information.Show("Ocorreu um erro fatal ao tentar atualizar o atualizador! Por favor, abra o programa e tente novamente. Se o erro persistir entre em contato com o suporte.", KuhnperBase.Library.Style.KuhnperColors.BootstrapRed);

                //Substituição:
                Console.WriteLine("Ocorreu um erro fatal ao tentar atualizar o atualizador! Por favor, abra o programa e tente novamente. Se o erro persistir entre em contato com o suporte. Pressione qualquer tecla para continuar...");
                Console.ReadKey();

                Environment.Exit(0);
            }
        }
    }
}
