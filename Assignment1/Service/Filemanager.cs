namespace Assignment.Service
{

    internal interface IFilemanager //kontrakt på metoder som ska finnas
    {
        public void Save(string text);
        public string Read();
    }
    public class Filemanager : IFilemanager
    {
        private string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\CSAssignment1-master.json";
        public void Save(string text)
        {
            try
            {
                using var sw = new StreamWriter(filePath);
                sw.WriteLine(text);
            }
            catch
            {

            }

        }
        public string Read()
        {
            try
            {
                using var sr = new StreamReader(filePath);
                return sr.ReadToEnd();
            }
            catch
            {
                return "";
            }   
        }
         
    }
}