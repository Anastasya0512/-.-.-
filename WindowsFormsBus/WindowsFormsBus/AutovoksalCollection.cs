using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBus
{
    public class AutovoksalCollection
    {
        readonly Dictionary<string, Autovoksal<EasyBus>> autovoksalStages;

        public List<string> Keys => autovoksalStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';
        public AutovoksalCollection(int pictureWidth, int pictureHeight)
        {
            autovoksalStages = new Dictionary<string, Autovoksal<EasyBus>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddAutovoksal(string name)
        {
            if (autovoksalStages.ContainsKey(name))
            {
                return;
            }
            autovoksalStages.Add(name, new Autovoksal<EasyBus>(pictureWidth, pictureHeight));
        }

        public void DelAutovoksal(string name)
        {
            if (autovoksalStages.ContainsKey(name))
            {
                autovoksalStages.Remove(name);
            }
        }

        public Autovoksal<EasyBus> this[string index]
        {
            get
            {
                if (autovoksalStages.ContainsKey(index))
                {
                    return autovoksalStages[index];
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"AutovoksalCollection");
                foreach (var level in autovoksalStages)
                {
                    sw.WriteLine($"Autovoksal{separator}{level.Key}");
                    foreach (ITransport bus in level.Value)
                    {
                        if (bus.GetType().Name == "Bus")
                        {
                            sw.Write($"Bus{separator}");
                        }
                        if (bus.GetType().Name == "BusGarm")
                        {
                            sw.Write($"BusGarm{separator}");
                        }
                        sw.WriteLine(bus);
                    }
                }
            }
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                string key = string.Empty;
                EasyBus bus = null;
                if (line.Contains("AutovoksalCollection"))
                {
                    autovoksalStages.Clear();
                }
                else
                {
                    throw new ErrorFormatException();
                }
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line.Contains("Autovoksal"))
                    {
                        key = line.Split(separator)[1];
                        autovoksalStages.Add(key, new Autovoksal<EasyBus>(pictureWidth, pictureHeight));
                        line = sr.ReadLine();
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        line = sr.ReadLine();
                        continue;
                    }
                    if (line.Split(separator)[0] == "Bus")
                    {
                        bus = new Bus(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "BusGarm")
                    {
                        bus = new BusGarm(line.Split(separator)[1]);
                    }
                    var result = autovoksalStages[key] + bus;
                    if (!result)
                    {
                        throw new NullReferenceException();
                    }
                    line = sr.ReadLine();
                }
            }
        }
    }
}



