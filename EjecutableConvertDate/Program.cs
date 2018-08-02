using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjecutableConvertDate
{
    class Program
    {
                   

        static void Main(string[] args)
        {
            string fecha = GetTodaysDateWithoutHour();

            Console.WriteLine(fecha);
            Console.ReadLine();


        }


        public static string GetTodaysDateWithoutHour()
        {

            string date = DateTime.Today.ToString();
            string day = "";
            string month = "";

            DateTime dateTimeValue;

            try
            {
                dateTimeValue = Convert.ToDateTime(date);

                //dateTimeValue = dateTimeValue.AddDays(-1);
                day = dateTimeValue.ToString("dd");


                month = dateTimeValue.ToString("MMM");
                month = month.ToUpper();
                month = month.Substring(0, 3);
                string year = dateTimeValue.ToString("yyyy");

                date = "" + day + "-" + month + "-" + year;

            }
            catch (Exception e)
            {

                date = "Formato Invalido";
            }


            return date;
        }



        public static string ConvertDate()
        {

            string date = DateTime.Today.ToString();
            string day = "";
            string month = "";

            DateTime dateTimeValue;

            try
            {
                dateTimeValue = Convert.ToDateTime(date);

                //dateTimeValue = dateTimeValue.AddDays(-1);
                day = dateTimeValue.ToString("dd");


                month = dateTimeValue.ToString("MMM");
                month = month.ToUpper();
                month = month.Substring(0, 3);
                string year = dateTimeValue.ToString("yyyy");

                date = "" + day + "-" + month + "-" + year;


                date += " 23:59:00";





            }
            catch (Exception e)
            {

                date = "Formato Invalido";
            }


            return date;
        }

    }
}
