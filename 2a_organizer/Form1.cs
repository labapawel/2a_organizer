using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2a_organizer
{
    public partial class Form1 : Form
    {
        public DateTime WybranyCzas = DateTime.Now;
        private Organizer org = new Organizer();
        public Form1()
        {
            InitializeComponent();
            org.DodanieZadania += ZadanieDodania;
//            org.DodanieZadania += ZadanieDodania; // dodanie zd.
//            org.DodanieZadania -= ZadanieDodania; // odpięcie zd.
        }

        private void ZadanieDodania(DateTime czaszadania, Day dane)
        {

        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.dateTimePicker1_ValueChanged(null, null);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         WybranyCzas = new DateTime(
                                        monthCalendar1.SelectionStart.Year,
                                        monthCalendar1.SelectionStart.Month,
                                        monthCalendar1.SelectionStart.Day, 
                                        dateTimePicker1.Value.Hour, 
                                        dateTimePicker1.Value.Minute,
                                        dateTimePicker1.Value.Second);
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            org.dodaj(WybranyCzas, textBox1.Text);
        }
    }
}
