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

namespace ViewInvoices
{
    public partial class Form1 : Form
    {
        const char DELIM = ',';
        const string FILENAME = @"C:\Users\chris\OneDrive\Desktop\Week 10 Assignments\EnterInvoices\Invoices.txt";
        string recordIn;
        string[] fields;
        static FileStream file = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);


        public Form1()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            try
            {
                recordIn = reader.ReadLine();
                fields = recordIn.Split(DELIM);
                invoiceBox.Text = fields[0];
                nameBox.Text = fields[1];
                amountBox.Text = fields[2];
            }

            catch (NullReferenceException)
            {

                label1.Text = "You have viewed\n all of the records.";
                viewButton.Enabled = false;
            }


        }
    }
}
