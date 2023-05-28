using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Clases
{
    public class Mes
    {
        public String Abreviar(String X)
        {
            String Abr = "";
            switch (int.Parse(X.Split('/')[0]))
            {
                case 1:
                    Abr += "ENE";
                    break;
                case 2:
                    Abr += "FEB";
                    break;
                case 3:
                    Abr += "Mar";
                    break;
                case 4:
                    Abr += "ABR";
                    break;
                case 5:
                    Abr += "MAY";
                    break;
                case 6:
                    Abr += "JUN";
                    break;
                case 7:
                    Abr += "JUL";
                    break;
                case 8:
                    Abr += "AGO";
                    break;
                case 9:
                    Abr += "SEPT";
                    break;
                case 10:
                    Abr += "OCT";
                    break;
                case 11:
                    Abr += "NOV";
                    break;
                case 12:
                    Abr += "DIC";
                    break;
            }
            return $"{Abr}/{X.Split('/')[1]}";
        }
    }
}
