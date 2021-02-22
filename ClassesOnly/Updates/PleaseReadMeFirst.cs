/*

**UPDATER**

Neste tipo de diretório eu costumo usar o sistema de atualização automática do atualizador da aplicação. Nela, eu apenas chamo um determinado método e toda a 
checagem de atualização e a atualização em sí, são feitas.

IMPORTANTE: Esta classe não é ultilizada pelo aplicativo atualizador da aplicação! E sim pela própria aplicação. Por exemplo: Eu tenho a aplicação MyApp que faz cadastros de cliente e a aplicação MyAppUpdater, eu chamo o método Updates.Updater.CheckForUpdates(). Visto que o código é executado na aplicação eu 
consigo subtituir os arquivos do atualizador automático.

Este mesmo sistema é ultilizado similarmente nas minhas aplicações, para atualizá-las automaticamente.
 
*/