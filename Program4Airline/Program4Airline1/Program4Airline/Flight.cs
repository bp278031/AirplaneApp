using System;


namespace Program4Airline
{
     public  class Flight
    {
        public string planeType;
        public string departureTime;
        public string destination;
        public int rows;
        public int seats;
        public string[] seatChart;

        public Flight() { }

        public Flight(string thePlaneType, string theDepartureTime, string theDestination,
                        int theRows, int theSeats)
        {
            this.PlaneType = thePlaneType;
            this.DepartureTime = theDepartureTime;
            this.Destination = theDestination;
            this.Rows = theRows;
            this.Seats = theSeats;

            seatChart = new string[Rows * Seats];

            for (int x = 0; x <= seatChart.GetUpperBound(0); x++)
            {
                seatChart[x] = "Open";
            }

        }

        public string [] SeatChart
        {
            get { return seatChart; }
            set { seatChart = value; }
        }

        public string DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }

        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }

        }

        public int Rows
        {
            get { return rows; }
            set { rows = value; }

        }

        public int Seats
        {
            get { return seats; }
            set { seats = value; }

        }

        public string PlaneType
        {
            get { return planeType; }
            set { planeType = value; }
        }

        

        public string GetDisplayText()
        {
            string test = "";
            int x = 1;
            foreach (string n in seatChart)
            {
                test += "\t" + "Seat " + x +" " + n + "\n" ;
                x++;
            }
            return " Plane Type: " + planeType + " departure time: " + departureTime
                + " Destination:  " + destination +"\n" + test;
        }

        public void MakeReservaton (string thePassenger, int seat)
        {
            seat = seat - 1;

            if (seat >= 0 && seat <= seatChart.GetUpperBound(0))
            {
                if (seatChart[seat] == "Open")
                {
                    seatChart[seat] = thePassenger;
                }
            }
        }

        public void CancelReservaton( int seat)
        {
            seat = seat - 1;

            if (seat >= 0 && seat <= seatChart.GetUpperBound(0))
            {
                if (seatChart[seat] != "Open")
                {
                    seatChart[seat] = "Open";
                }
            }
        }

        public bool IsFull()
        {
            bool full = true;

            

            for( int x = 0; x <= seatChart.GetUpperBound(0); x++)
            {
                if(seatChart[x] == "Open")
                {
                    full = false;
                    x = seatChart.GetUpperBound(0);
                }
            }

            return full;
        }

        public bool SeatReserved(int seat)
        {
            
            seat = seat -1;

            if (seatChart[seat] != "Open")
            {
                return true;
            }

            else
                return false;
        }


    }
}
