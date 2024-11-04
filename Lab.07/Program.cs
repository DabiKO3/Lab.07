using lab._05;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Program
    {
        static List<Processor> processors;

        static void PrintProcessors()
        {
            foreach (Processor processor in processors)
            {
                Console.WriteLine(processor.Info().Replace('і', 'і'));
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            processors = new List<Processor>();
            string filePath = @"C:\Users\HP\source\repos\lab 7\lab 7\bin\Debug\processor.processor";
            FileStream fs = new FileStream(filePath, FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);
            try
            {
                Processor processor;
                Console.WriteLine(" Читаємо дані з файлу...\n");
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    processor = new Processor();
                    for (int i = 1; i <= 8; i++)
                    {
                        switch (i)
                        {
                            case 1:
                                processor.name = reader.ReadString(); break;
                            case 2:
                                processor.manufacturer = reader.ReadString(); break;
                            case 3:
                                processor.core = reader.ReadInt32(); break;
                            case 4:
                                processor.frequency = reader.ReadDouble(); break;
                            case 5:
                                processor.tdp = reader.ReadDouble(); break;
                            case 6:
                                processor.performancePerCore = reader.ReadDouble(); break;
                            case 7:
                                processor.multiPrecision = reader.ReadBoolean(); break;
                            case 8:
                                processor.energySaving = reader.ReadBoolean(); break;
                        }
                    }
                    processors.Add(processor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталась помилка: {0}", ex.Message);
            }
            finally
            {
                reader.Close();
            }
            Console.WriteLine("Несортований перелік процесорів: {0}", processors.Count);
            PrintProcessors();
            processors.Sort();
            Console.WriteLine("Сортований перлік процесорів: {0}", processors.Count);
            PrintProcessors();
            Console.WriteLine("Додаємо новий запис: Acer");
            Processor tabletAcer = new Processor("Inter Core  і5","Inter", 4, 3.0, 65, 250, true, true);
            processors.Add(tabletAcer);
            processors.Sort();
            Console.WriteLine("Перелік Ghjwtcjhsd: {0}", processors.Count());
            PrintProcessors();
            Console.WriteLine("Видаляємо останнє значення");
            processors.RemoveAt(processors.Count - 1);
            Console.WriteLine("Перелік планшетів: {0}", processors.Count);
            PrintProcessors();
            Console.ReadKey();
        }
    }
}
