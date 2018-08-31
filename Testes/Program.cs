using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    class Program
    {

        private static void RedirecionandoSite()
        {
            for (var i = 0; i <20; i++)
            {
                Process.Start("https://shafou.com/");
            }

        }

        public static string TextoString()
        {
            var teste = "Salvando arquivo por método...";
            return teste;

        }

        public static int TextoInt()
        {
            var teste = 4;
            return teste;

        }

        public static string a = "Salvando arquivo por string...";

        static void Main(string[] args)
        {

            RedirecionandoSite();

            File.WriteAllText(@"c:\arquivos\textoo" + DateTime.Now.ToString("dd_MM_yyy") + ".txt", TextoString());

            //ou File.WriteAllText(@"c:\arquivos\textoo" + DateTime.Now.ToString("dd_MM_yyy") + ".txt", TextoInt().ToString());

            //ou File.WriteAllText(@"c:\arquivos\textoo" + DateTime.Now.ToString("dd_MM_yyy") + ".txt", a);


            /* criando vários arquivos na área de trabalho...
            for (var i = 0; i <= 30; i++)
            {
                File.WriteAllText(@"c:\Users\nicol\Desktop\" + (i) + ".txt", TextoString());
            }*/
        }
    }
}

