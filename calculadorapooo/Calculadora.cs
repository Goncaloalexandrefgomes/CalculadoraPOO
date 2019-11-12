using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadorapooo
{

    class Calculadora
    {
        private string visor = "";

        public Calculadora()
        {
            this.visor = "";
        }

            public string input
        {
            set
            {
                if (visor == "") visor = "0";
                switch (value)
                {
                    case "OFF": visor = ""; break;
                    case "AC": visor = "0"; break;
                    case "C": visor = "0"; break;
                    case "MC":; break;
                    case "MR":; break;
                    case "M-":; break;
                    case "M+":; break;
                    case "v":; break;
                    case "%":; break;
                    case "+/-":; break;
                    case "/":
                    case "x":
                    case "-":
                    case "+":
                    case "=":; break;
                    case ",": if (!visor.Contains(",")) visor += ","; break;
                    default: visor += value; break;
                    

                }
            }
        }

        public string output
        {
            get
            {
                return (visor.Length > 9) ? visor.Substring(0, 9) : visor;
            }
        }
    }
}
