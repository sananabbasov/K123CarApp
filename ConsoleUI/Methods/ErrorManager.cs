namespace ConsoleUI.Methods
{
    public static class ErrorManager
    {
        public static void ErrorHandler(string errorMessage)
        {
            File.AppendAllText("error.txt",$"{errorMessage} | {DateTime.Now}\n");
        }
    }
}