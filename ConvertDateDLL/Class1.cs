using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDateDLL
{
    public class Class1
    {
        //This method does the same as GetTodaysDateWith23_59Hour, just another name (implemented in production)
       public string ConvertDate()
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
            
       /// <summary>
       /// This method returns today's date in the format: DD-MMM-AAAA 23:59:00
       /// </summary>
       /// <returns>string</returns>
       public string GetTodaysDateWith23_59Hour()
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

        /// <summary>
        /// This method returns today's date in the format: DD-MMM-AAAA
        /// </summary>
        /// <returns>string</returns>
        public string GetTodaysDateWithoutHour()
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


    }
}
