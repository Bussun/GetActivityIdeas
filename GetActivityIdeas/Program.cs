namespace GetActivityIdeas
{
    public static class Program
    { 
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static readonly HttpClient wrClient = new HttpClient();
    }
}