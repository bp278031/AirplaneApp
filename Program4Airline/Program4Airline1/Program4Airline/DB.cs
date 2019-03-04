using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program4Airline
{
    public static  class DB
    {

        //public static Flight sccAir = null;
        //public static Flight lincAir = null;
        
       
        public static List<Flight> RunDB()
        {
            
            

            string dir = @"N:\";
            string path = dir + "AirLines.txt";

            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the array list for customers
            List<Flight> flights = new List<Flight>();


            // read the data from the file and store it in the ArrayList
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                
                Flight flight = new Flight(columns[0], columns[1], columns[2], Convert.ToInt32(columns[3]), Convert.ToInt32(columns[4]));
                
                flights.Add(flight);

            }

            

            textIn.Close();
            return flights;
            
        }
    }
}
