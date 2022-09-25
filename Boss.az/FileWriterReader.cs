using Newtonsoft.Json;

namespace Boss.az
{
    public class FrileWriterFileReadercs
    {
        public static void WriteFile(DataBase dataBase)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("JobADD.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, dataBase);
                }
            }

        }

        public static DataBase ReadFile()
        {
            DataBase? databaseResult = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("JobADD.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    databaseResult = serializer.Deserialize<DataBase>(jr);
                }
            }
            return databaseResult!;
        }

    }
}
