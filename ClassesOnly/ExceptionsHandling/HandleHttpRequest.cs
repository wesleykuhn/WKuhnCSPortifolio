using ClassesOnly.HttpRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOnly.ExceptionsHandling
{
    public static class HandleHttpRequest
    {
        #region GET REQUEST    
        public static async Task<string> HandleGetAsync(HttpRequests.HttpGet httpGet)
        {
            string result = null;

            bool success = false;

            try
            {
                result = await httpGet.SendRequestAsync();                
            }
            catch (Exception ex)
            {
                ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(ex.Message + " - Status Code do Get foi: " + httpGet.StatusCode.ToString() + ".");

                //As linhas comentadas abaixo faz parte de um projeto base particular de Windown Forms, que tem alguns formulários genéricos. Nesse bloco, o usuário tinha opção de clicar em 'Cancelar', encerrar a tentativa de uma nova conexão e finalizar o programa.
                //KuhnperBase.Forms.Messages.FRM_CancelableLoading frmCancelableLoading = new KuhnperBase.Forms.Messages.FRM_CancelableLoading("Seu computador está sem conexão com a internet nesse momento! Aguarde enquanto o programa tenta conectar novamente...\n\n[Tentativa 1 de 10]", KuhnperBase.Library.Style.KuhnperColors.BootstrapRed, KuhnperBase.Forms.Messages.FRM_CancelableLoading.FormSounds.Error);
                //frmCancelableLoading.CancelButtonClicked += new EventHandler(KillProgram);
                //frmCancelableLoading.Show();
                //Application.DoEvents();

                //A linha a baixo é para subtituir o código acima que foi comentado:
                Console.WriteLine("Seu computador está sem conexão com a internet nesse momento! Aguarde enquanto o programa tenta conectar novamente...");

                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(10000);

                    //frmCancelableLoading.ChangeMessage("Seu computador está sem conexão com a internet nesse momento! Aguarde enquanto o programa tenta conectar novamente...\n\n[Tentativa " + (i + 1).ToString() + " de 10]");
                    
                    //A linha a baixo foi inserida para substituir o código acima que foi comentado:
                    Console.WriteLine("Seu computador está sem conexão com a internet nesse momento! Aguarde enquanto o programa tenta conectar novamente...\n\n[Tentativa " + (i + 1).ToString() + " de 10]");

                    try
                    {
                        if (await ConnectionTest.Test(false))
                        {
                            success = true;

                            break;
                        }
                    }
                    catch (Exception secondEx)
                    {
                        ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(secondEx.Message + " - Status Code do Get foi: " + httpGet.StatusCode.ToString() + ".");
                    }
                }

                //A linha abaixo foi retirada do mesmo projeto WinForms particular, onde tinha o objetivo de fechar o formulário assíncrono que foi aberto por do método Form.Show().
                //HandleForm.CloseAsyncForm(frmCancelableLoading);

                if (!success)
                {
                    //A linha abaixo também representa um fomulário informativo.
                    //FRM_Information.Show("Não foi possível recuperar sua conexão com a internet! Por favor, tente novamente mais tarde. Caso o erro persista, entre em contato com o suporte.", KuhnperBase.Library.Style.KuhnperColors.BootstrapRed);

                    //O bloco a baixo foi inserida para substituir o código acima que foi comentado:
                    Console.WriteLine("Não foi possível recuperar sua conexão com a internet! Por favor, tente novamente mais tarde. Caso o erro persista, entre em contato com o suporte. Precione qualquer tecla para continuar...");
                    Console.ReadKey();

                    Environment.Exit(0);
                }
                else
                {
                    try
                    {
                        result = await httpGet.SendRequestAsync();
                    }
                    catch (Exception thirdEx)
                    {
                        ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(thirdEx.Message + " - Status Code do Get foi: " + httpGet.StatusCode.ToString() + ".");

                        //A linha abaixo também representa um fomulário informativo.
                        //FRM_Information.Show("Não foi possível recuperar sua conexão com a internet! Por favor, tente novamente mais tarde. Caso o erro persista, entre em contato com o suporte.", KuhnperBase.Library.Style.KuhnperColors.BootstrapRed);

                        //O bloco a baixo foi inserida para substituir o código acima que foi comentado:
                        Console.WriteLine("Não foi possível recuperar sua conexão com a internet! Por favor, tente novamente mais tarde. Caso o erro persista, entre em contato com o suporte. Precione qualquer tecla para continuar...");
                        Console.ReadKey();

                        Environment.Exit(0);
                    }                    
                }                
            }

            return result;
        }
        #endregion

        #region POST REQUEST        
        public static async Task HandlePostAsync(HttpRequests.HttpPost httpPost)
        {
            bool success = false;

            try
            {
                await httpPost.SendRequestAsync();
            }
            catch (Exception ex)
            {
                ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(ex.Message + " - Status Code do Get foi: " + httpPost.StatusCode.ToString() + ".");

                //As linhas comentadas abaixo faz parte de um projeto base particular de Windown Forms, que tem alguns formulários genéricos. Nesse bloco, o usuário tinha opção de clicar em 'Cancelar', encerrar a tentativa de uma nova conexão e finalizar o programa.
                //KuhnperBase.Forms.Messages.FRM_CancelableLoading frmCancelableLoading = new KuhnperBase.Forms.Messages.FRM_CancelableLoading("Seu computador está sem conexão com a internet nesse momento! Aguarde enquanto o programa tenta conectar novamente...\n\n[Tentativa 1 de 10]", KuhnperBase.Library.Style.KuhnperColors.BootstrapRed, KuhnperBase.Forms.Messages.FRM_CancelableLoading.FormSounds.Error);
                //frmCancelableLoading.CancelButtonClicked += new EventHandler(KillProgram);
                //frmCancelableLoading.Show();
                //Application.DoEvents();

                //A linha a baixo é para subtituir o código acima que foi comentado:
                Console.WriteLine("Seu computador está sem conexão com a internet nesse momento! Aguarde enquanto o programa tenta conectar novamente...");

                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(10000);

                    //frmCancelableLoading.ChangeMessage("Seu computador está sem conexão com a internet nesse momento! Aguarde enquanto o programa tenta conectar novamente...\n\n[Tentativa " + (i + 1).ToString() + " de 10]");

                    //A linha a baixo foi inserida para substituir o código acima que foi comentado:
                    Console.WriteLine("Seu computador está sem conexão com a internet nesse momento! Aguarde enquanto o programa tenta conectar novamente...\n\n[Tentativa " + (i + 1).ToString() + " de 10]");

                    try
                    {
                        if (await ConnectionTest.Test(false))
                        {
                            success = true;

                            break;
                        }
                    }
                    catch (Exception secondEx)
                    {
                        ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(secondEx.Message + " - Status Code do Get foi: " + httpPost.StatusCode.ToString() + ".");
                    }
                }

                //A linha abaixo foi retirada do mesmo projeto WinForms particular, onde tinha o objetivo de fechar o formulário assíncrono que foi aberto por do método Form.Show().
                //HandleForm.CloseAsyncForm(frmCancelableLoading);

                if (!success)
                {
                    //A linha abaixo também representa um fomulário informativo.
                    //FRM_Information.Show("Não foi possível recuperar sua conexão com a internet! Por favor, tente novamente mais tarde. Caso o erro persista, entre em contato com o suporte.", KuhnperBase.Library.Style.KuhnperColors.BootstrapRed);

                    //O bloco a baixo foi inserida para substituir o código acima que foi comentado:
                    Console.WriteLine("Não foi possível recuperar sua conexão com a internet! Por favor, tente novamente mais tarde. Caso o erro persista, entre em contato com o suporte. Precione qualquer tecla para continuar...");
                    Console.ReadKey();

                    Environment.Exit(0);
                }
                else
                {
                    try
                    {
                        await httpPost.SendRequestAsync();
                    }
                    catch (Exception thirdEx)
                    {
                        ExceptionsHandling.ExceptionsLogs.AppendOnErrorLogFile(thirdEx.Message + " - Status Code do Get foi: " + httpPost.StatusCode.ToString() + ".");

                        //A linha abaixo também representa um fomulário informativo.
                        //FRM_Information.Show("Não foi possível recuperar sua conexão com a internet! Por favor, tente novamente mais tarde. Caso o erro persista, entre em contato com o suporte.", KuhnperBase.Library.Style.KuhnperColors.BootstrapRed);

                        //O bloco a baixo foi inserida para substituir o código acima que foi comentado:
                        Console.WriteLine("Não foi possível recuperar sua conexão com a internet! Por favor, tente novamente mais tarde. Caso o erro persista, entre em contato com o suporte. Precione qualquer tecla para continuar...");
                        Console.ReadKey();

                        Environment.Exit(0);
                    }
                }
            }
        }
        #endregion

        private static void KillProgram(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
