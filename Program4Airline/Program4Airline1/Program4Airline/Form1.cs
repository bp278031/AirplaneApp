using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Program4Airline
{
    public partial class frmFlights : Form
    {
        public frmFlights()
        {
            InitializeComponent();
        }

        //Flight lincAir = DB.lincAir;
        // Flight sccAir = DB.sccAir;

        Flight lincAir = null;
        Flight sccAir = null;

        List<Flight> flights = new List<Flight>();

        private void frmFlights_Load(object sender, EventArgs e)
        {


            flights = DB.RunDB();

            lincAir = flights[0];
            sccAir = flights[1];
            
            
             //lincAir = new Flight("Cessna Citation", "12p", "San Diego", 6, 2);

            lincAir.MakeReservaton("Bob", 3);

            lincAir.MakeReservaton("Suzy", 12);


            //sccAir = new Flight("Jumbo 747", "8am", "New York", 2, 7);

             sccAir.MakeReservaton("Doug", 8);
             sccAir.MakeReservaton("Sally", 14);


             lblFlights.Text = lincAir.GetDisplayText();

            
               // MessageBox.Show(test);


        }

       

        private void FlightsToday_Changed(object sender, System.EventArgs e)
        {

            lblFlights.Text = "";

          if (rdoSccAir.Checked)
          {
              //string test = sccAir.GetDisplayText();
              lblFlights.Text = sccAir.GetDisplayText();

          }
            else
          {
              //string test = lincAir.GetDisplayText();
              lblFlights.Text = lincAir.GetDisplayText();

          }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                
                string name = txtName.Text;
                int seatNum = Convert.ToInt32(txtSeatNumber.Text);

                if (!IsFull())
                {
                    if (!SeatTaken(seatNum))
                    {
                        lblFlights.Text = "";
                        if (rdoSccAir.Checked)
                        {
                            sccAir.MakeReservaton(name, seatNum);
                            lblFlights.Text = "";
                            lblFlights.Text = sccAir.GetDisplayText();
                            txtSeatNumber.Clear();
                            txtName.Clear();
                            txtName.Focus();
                        }
                        else
                        {
                            lincAir.MakeReservaton(name, seatNum);
                            lblFlights.Text = "";
                            lblFlights.Text = lincAir.GetDisplayText();
                            txtSeatNumber.Clear();
                            txtName.Clear();
                            txtName.Focus();
                        }
                    }
                }
            }
        }

        private bool IsFull()
        {
            if (rdoSccAir.Checked)
            {
                return sccAir.IsFull();
            }
            else
                return lincAir.IsFull();

        }

        private bool SeatTaken(int seat)
        {
            if (rdoSccAir.Checked)
            {
                if (sccAir.SeatReserved(seat))
                {
                    MessageBox.Show("Sorry That Seat is Occupied", "Seat Taken");

                    return true;
                }
            }
            else
            {
                if (lincAir.SeatReserved(seat))
                {
                    MessageBox.Show("Sorry That Seat is Occupied", "Seat Taken");

                    return true;
                }
            }

            return false;
        }

        private bool IsValid()
        {
            int index = 0;

            if (rdoSccAir.Checked)
            {
                 index = 1 + (sccAir.SeatChart.GetUpperBound(0));
            }
            else
                index = 1 + (lincAir.SeatChart.GetUpperBound(0));

           return Validator.IsPresent(txtName) &&
               Validator.IsPresent(txtSeatNumber) &&
               Validator.IsInt32(txtSeatNumber) &&
               Validator.IsWithinRange(txtSeatNumber, 0, index);
                
                
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

                int seatNum = Convert.ToInt32(txtSeatNumber.Text);
                if (rdoSccAir.Checked)
                {
                    sccAir.CancelReservaton(seatNum);
                    lblFlights.Text = "";
                    lblFlights.Text = sccAir.GetDisplayText();
                    txtSeatNumber.Clear();
                    txtName.Clear();
                    txtName.Focus();
                }
                else
                {
                    lincAir.CancelReservaton( seatNum);
                    lblFlights.Text = "";
                    lblFlights.Text = lincAir.GetDisplayText();
                    txtSeatNumber.Clear();
                    txtName.Clear();
                    txtName.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }




         

    }
}
