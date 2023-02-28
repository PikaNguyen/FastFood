using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void cbBunBo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBunBo.Checked == true)
            {
               tbBunBo.Enabled = true;
            }
            if (cbBunBo.Checked == false)
            {
                tbBunBo.Enabled = false;
                tbBunBo.Text = "0";
            }
        }
        private void cbSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSalad.Checked == true)
            {
                tbSalad.Enabled = true;
            }
            if (cbSalad.Checked == false)
            {
                tbSalad.Enabled = false;
                tbSalad.Text = "0";
            }
        }
        private void cbLauGa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLauGa.Checked == true)
            {
                tbLauGa.Enabled = true;
            }
            if (cbLauGa.Checked == false)
            {
                tbLauGa.Enabled = false;
                tbLauGa.Text = "0";
            }
        }

        private void cbLauCa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLauCa.Checked == true)
            {
                tbLauCa.Enabled = true;
            }
            if (cbLauCa.Checked == false)
            {
                tbLauCa.Enabled = false;
                tbLauCa.Text = "0";
            }
        }

        private void cbSuonHeo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSuonHeo.Checked == true)
            {
                tbSuonHeo.Enabled = true;
            }
            if (cbSuonHeo.Checked == false)
            {
                tbSuonHeo.Enabled = false;
                tbSuonHeo.Text = "0";
            }
        }

        //drinks
        private void cbPessi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPessi.Checked == true)
            {
                tbPessi.Enabled = true;
            }
            if (cbPessi.Checked == false)
            {
                tbPessi.Enabled = false;
                tbPessi.Text = "0";
            }
        }

        private void cbNuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNuoc.Checked == true)
            {
                tbNuoc.Enabled = true;
            }
            if (cbNuoc.Checked == false)
            {
                tbNuoc.Enabled = false;
                tbNuoc.Text = "0";
            }
        }

        private void cbBia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBia.Checked == true)
            {
                tbBia.Enabled = true;
            }
            if (cbBia.Checked == false)
            {
                tbBia.Enabled = false;
                tbBia.Text = "0";
            }
        }

        private void cbTra_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTra.Checked == true)
            {
                tbTra.Enabled = true;
            }
            if (cbTra.Checked == false)
            {
                tbTra.Enabled = false;
                tbTra.Text = "0";
            }
        }

        private void cbCoca_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCoca.Checked == true)
            {
                tbCoca.Enabled = true;
            }
            if (cbCoca.Checked == false)
            {
                tbCoca.Enabled = false;
                tbCoca.Text = "0";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        double bunBo = 30, salad = 50, suonHeo = 85, lauCa = 200, lauGa = 180;
        double coCa = 10, tra = 10, bia = 15, nuocKhoang = 5, pessi = 10;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbBienLai.Text + " Tổng tiền dự kiến" + lblTongDuKien.Text + " Thuế" +lblTax.Text + " Tổng thành tiền"+lblTotal.Text, new Font("Century Gothic",12,FontStyle.Regular),Brushes.Blue,new Point(130)) ;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbBunBo.Checked = false;
            cbBia.Checked = false;
            cbTra.Checked = false;
            cbCoca.Checked = false;
            cbNuoc.Checked = false;
            cbPessi.Checked = false;
            cbLauCa.Checked = false;
            cbLauGa.Checked = false;
            cbSalad.Checked = false;
            cbSuonHeo.Checked = false;
            rtbBienLai.Text = "";
        }

        double pbunBo, psalad, psuonHeo , plauCa, plauGa,pcoCa , ptra, pbia , pnuocKhoang, ppessi ;
        double Subtotal = 0,tax = 0,tongPrice=0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pbunBo = bunBo * Convert.ToDouble(tbBunBo.Text);
            psalad = salad * Convert.ToDouble(tbSalad.Text);
            psuonHeo = suonHeo * Convert.ToDouble(tbSuonHeo.Text);
            plauCa = lauCa * Convert.ToDouble(tbLauCa.Text);
            plauGa = lauGa * Convert.ToDouble(tbLauGa.Text);
            //Drinks
            pcoCa = coCa * Convert.ToDouble(tbCoca.Text);
            ptra = tra * Convert.ToDouble(tbTra.Text);
            pbia = bia * Convert.ToDouble(tbBia.Text);
            pnuocKhoang = nuocKhoang * Convert.ToDouble(tbNuoc.Text);
            ppessi = pessi * Convert.ToDouble(tbPessi.Text);
            rtbBienLai.Clear();
            Subtotal = 0;
            rtbBienLai.AppendText(Environment.NewLine);
            rtbBienLai.AppendText("\t\t\t\t\t     Restaurant\t\t"+lblTime.Text+Environment.NewLine) ;
            rtbBienLai.AppendText("\t\t==================================================================="+Environment.NewLine);

            if (cbBunBo.Checked == true)
            {
                rtbBienLai.AppendText("\tBún bò: \t" + pbunBo + "k VND" + Environment.NewLine);
                Subtotal = Subtotal + pbunBo;
                lblTongDuKien.Text = Subtotal + "k VND";
            }
            if (cbSalad.Checked == true)
            {
                rtbBienLai.AppendText("\tSalad: \t" + psalad + "k VND" + Environment.NewLine);
                Subtotal = Subtotal + psalad;
                lblTongDuKien.Text = Subtotal + "k VND";
            }
            if (cbSuonHeo.Checked == true)
            {
                rtbBienLai.AppendText("\tSườn heo: \t" + psuonHeo + "k VND" + Environment.NewLine);
                Subtotal = Subtotal + psuonHeo;
                lblTongDuKien.Text = Subtotal + "k VND";
            }
            if (cbLauCa.Checked == true)
            {
                rtbBienLai.AppendText("\tLẩu cá tằm: \t" + plauCa + "k VND" + Environment.NewLine);
                Subtotal = Subtotal + plauCa;
                lblTongDuKien.Text = Subtotal + "k VND";
            }
            if (cbLauGa.Checked == true)
            {
                rtbBienLai.AppendText("\tLẩu gà lá é: \t" + plauGa + "k VND" + Environment.NewLine);
                Subtotal = Subtotal + plauGa;
                lblTongDuKien.Text = Subtotal + "k VND";
            }
            //drinks
            if (cbCoca.Checked == true)
            {
                rtbBienLai.AppendText("\tCocacola: \t" + pcoCa + "k VND" + Environment.NewLine);
                Subtotal = Subtotal + pcoCa;
                lblTongDuKien.Text = Subtotal + "k VND";
            }
            if (cbTra.Checked == true)
            {
                rtbBienLai.AppendText("\tTrà xanh 0 độ: \t" + ptra + "k VND" + Environment.NewLine);
                Subtotal = Subtotal + ptra;
                lblTongDuKien.Text = Subtotal + "k VND";
            }
            if (cbBia.Checked == true)
            {
                rtbBienLai.AppendText("\tBia sài gòn: \t" + pbia + "k VND" + Environment.NewLine);
                Subtotal = Subtotal + pbia;
                lblTongDuKien.Text = Subtotal + "k VND";
            }
            if (cbNuoc.Checked == true)
            {
                rtbBienLai.AppendText("\tNước khoáng: \t" + pnuocKhoang + "k VND" + Environment.NewLine);
                Subtotal = Subtotal + pnuocKhoang;
                lblTongDuKien.Text = Subtotal + "k VND";
            }
            if (cbPessi.Checked == true)
            {
                rtbBienLai.AppendText("\tPessi: \t" + ppessi + "k VND" + Environment.NewLine);
                Subtotal = Subtotal + ppessi;
                lblTongDuKien.Text =Subtotal+ "k VND";
            }
            tax = Subtotal * 0;
            tongPrice = Subtotal + tax;
            lblTax.Text = tax + " VND";
            lblTotal.Text = tongPrice + "k VND";
        }
        private void rtbBienLai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
