using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yash_chinese
{
    public partial class mainForm : Form
    {
       

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!pricetextbox1.Text.Equals("") && !quantitycombobox.Text.Equals(""))
            {
                decimal totalprice = Convert.ToInt32(pricetextbox1.Text) * Convert.ToInt32(quantitycombobox.Text);
                totalproductpricetextbox.Text = totalprice.ToString();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customernametextbox.Clear();
            customernumbertextbox.Clear();
            productnamecombobox.SelectedIndex = 0;
            quantitycombobox.SelectedIndex = 0;
            pricetextbox1.Clear();
            totalproductpricetextbox.Clear();           
            customernametextbox.Focus();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quantitycombobox_TextChanged(object sender, EventArgs e)
        {
            if (!quantitycombobox.Text.Equals("") && !pricetextbox1.Text.Equals(""))
            {
                decimal totalprice = Convert.ToInt32(pricetextbox1.Text) * Convert.ToInt32(quantitycombobox.Text);
                totalproductpricetextbox.Text = totalprice.ToString();

            }
        }

        private void savepdfbutton_Click(object sender, EventArgs e)
        {
            printPreviewDialogbill.Document = printDocumentbilldetail1;
            printPreviewDialogbill.Show();

            

        }

        private void printDocumentbilldetail1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string dashLine = "_______________________________________________________________________________________________________";
            Bitmap bitmap = Properties.Resources.android;
            Image image = new Bitmap(bitmap);
            e.Graphics.DrawImage(image, 320, 75, image.Width, image.Height);
            e.Graphics.DrawString("yash chinese", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(300, 30));
            e.Graphics.DrawString("Date:" + DateTime.Now, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, 300));
            e.Graphics.DrawString(""+dashLine, new Font("Arial", 10 , FontStyle.Regular), Brushes.Black, new Point(20, 350));
            
            e.Graphics.DrawString("Customer Name:" + customernametextbox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("Customer number:" + customernumbertextbox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 325));
            e.Graphics.DrawString("Item Description",new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 370));
            e.Graphics.DrawString(""+ productnamecombobox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 425));
            e.Graphics.DrawString("quantity", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(450, 375));
            e.Graphics.DrawString("price", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 375));
            e.Graphics.DrawString("" + quantitycombobox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(450, 425));
            e.Graphics.DrawString("" + pricetextbox1.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 425));

            e.Graphics.DrawString("" + dashLine, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(20, 400));
            e.Graphics.DrawString("" + dashLine, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(20, 550));

            e.Graphics.DrawString("Total Amount for payment: ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 600));
            e.Graphics.DrawString("" + totalproductpricetextbox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 600));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            printPreviewDialogbill.Document = printDocumentbilldetail1;
            printDocumentbilldetail1.Print();
        }
    }
}
