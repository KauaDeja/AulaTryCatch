﻿using System;
using System.IO;

namespace AulaTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Permissao acesso = new Permissao();
            acesso.Autorizar();
                     try
            {
                using (StreamReader sr = File.OpenText("data.txt"))
                {
                    Console.WriteLine($"A primeira linha do arquivo é: \n {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"O arquivo não foi encontrado.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"O diretório não foi encontrado.");
            }
            catch (IOException)
            {
                Console.WriteLine($"O arquivo não pôde ser aberto.");
            }
        }
    }
}
