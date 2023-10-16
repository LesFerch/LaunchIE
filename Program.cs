namespace LaunchIE
{
    class Program
    {
        static void Main(string[] args)
        {
            SHDocVw.InternetExplorer oIE = new SHDocVw.InternetExplorer();
            object oURL;
            oURL = "about:blank";
            if (args.Length > 0) { oURL = args[0]; }
            oIE.Visible = true;
            oIE.Navigate2(ref oURL);
        }
    }
}