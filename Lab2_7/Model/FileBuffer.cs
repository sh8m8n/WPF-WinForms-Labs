using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Model
{
    public class FileBuffer
    {
        private FileInfo file;

        /// <summary>
        ///
        /// </summary>
        /// <param name="filename">название файла для сохранения (безРасширения)</param>
        public FileBuffer(string filename)
        {
            file = new FileInfo(filename + ".json");
            if (!File.Exists(file.FullName))
            {
                file.Create();
            }
        }

        public async Task<string> LoadAsync()
        {
            string text;

            try
            {
                text = JsonSerializer.Deserialize<string>(File.ReadAllText(file.FullName));
            }
            catch
            {
                text = "Файл поврежден";
            }

            return text;
        }

        public void Save(string text)
        {
            File.WriteAllText(file.FullName, JsonSerializer.Serialize(text));
        }
    }
}
