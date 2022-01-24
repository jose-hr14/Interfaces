using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa07_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblFechaComienzo.Text = "";
            lblFechaFin.Text = "";
            lblRange.Text = "";

            monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            monthCalendar1.MonthlyBoldedDates = new DateTime[] { new DateTime(2022,01,7), new DateTime(2022, 01, 17), new DateTime(2022, 01, 31) };
            monthCalendar1.MinDate = new DateTime(2001, 01, 01);
            monthCalendar1.MaxDate = new DateTime(2030, 12, 31);
            monthCalendar1.MaxSelectionCount = 30;
            monthCalendar1.BoldedDates = new DateTime[] { new DateTime(2021, 11, 24), DateTime.Today.AddDays(3) };
            //monthCalendar1.MonthlyBoldedDates = new DateTime[] { new DateTime(2021, 11, 07), DateTime.Today.AddDays(7) };
        }

        private void btnSeleccionarFecha_Click(object sender, EventArgs e)
        {
            //lblFechaComienzo.Text = monthCalendar1.SelectionStart.ToString();
            //lblFechaFin.Text = monthCalendar1.SelectionEnd.ToString();
            lblFechaComienzo.Text = monthCalendar1.SelectionRange.Start + "\r\n" + monthCalendar1.SelectionRange.Start.ToString("dd MMM yyy");
            lblFechaFin.Text = monthCalendar1.SelectionRange.End + "\r\n" + monthCalendar1.SelectionRange.End.ToString("dd MMM yyy");
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblRange.Text = monthCalendar1.SelectionRange.ToString();
        }
    }
}
