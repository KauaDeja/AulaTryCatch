using System;

namespace AulaTryCatch
{
    public class Permissao
    {
        public bool permitir { get; set; }

        public void Autorizar(){
            System.Console.WriteLine("|-------------------------------|");
            System.Console.WriteLine("Para autorizar o acesso digite:\n true ou false\n");
            /// <summary>
            /// /TryCatch é usado para retornar uma resposta adequada para o usuário
            /// </summary>
            /// <value>Erro no app</value>
             try
             {
                permitir = Boolean.Parse(Console.ReadLine());

             }
             catch (System.Exception)
             {
                 
                 System.Console.WriteLine("Erro na aplicação: dados inválidos");
             }
        }
    }
}