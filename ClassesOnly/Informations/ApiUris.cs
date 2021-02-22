namespace ClassesOnly.Informations
{
    public static class ApiUris
    {
        //Main
        public static readonly string MainApiUri = "https://mywebsite/api/";

        //ConnectionTest
        public static readonly string ConnectionTestUri = MainApiUri + "TestMyConnection";

        //Updater URIs
        public static readonly string UpdaterVersionCheckerUri = MainApiUri + "ApplicationUpdater/CheckVersion";
    }
}
