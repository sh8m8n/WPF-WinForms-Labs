using System.Threading.Tasks;

namespace Model
{
    public static class ProgramBuffer
    {
        public async static Task<string> GenerateTextAsync(int stringsCount)
        {
            string saveText = string.Empty;
            for (int i = 0; i < stringsCount; i++)
            {
                await Task.Delay(1);
                saveText += "[" + i + "] Тестовая строка\n";
            }
            return saveText;
        }

    }
}
