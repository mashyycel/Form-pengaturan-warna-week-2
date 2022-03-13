using System;
using System.Drawing;
using System.Windows.Forms;

namespace Form_pengaturan_warna_week_2
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {

            string sentence = txtBoxInput.Text;
            string isi = "ISI:";
            txtBoxInput.Text = sentence.ToUpper();
            if (sentence.Contains(isi))
            {
                txtBoxInput.Text = sentence.Remove(0, 4);
                lblOutput.Text = txtBoxInput.Text;
            }
            else if (txtBoxInput.Text == "HIDE")
            {
                lblOutput.Hide();
            }
            else if (txtBoxInput.Text == "SHOWN")
            {
                lblOutput.Show();
            }
            else if (txtBoxInput.Text == "WARNA:DEFAULT")
            {
                lblOutput.ForeColor = Color.Black;
            }
            else if (txtBoxInput.Text == "WARNA:MERAH")
            {
                lblOutput.ForeColor = Color.Red;
            }
            else if (txtBoxInput.Text == "WARNA:HIJAU")
            {
                lblOutput.ForeColor = Color.Green;
            }
            else if (txtBoxInput.Text == "WARNA:BIRU")
            {
                lblOutput.ForeColor = Color.Blue;
            }
            else if (txtBoxInput.Text == "RESTART")
            {
                lblOutput.Text = "[EMPTY]";
                lblOutput.ForeColor = Color.Black;
            }
            else if (txtBoxInput.Text == "BESARKAN")
            {
                float ukuranSize;
                ukuranSize = lblOutput.Font.SizeInPoints;
                ukuranSize += 1;
                lblOutput.Font = new Font(lblOutput.Font.Name, ukuranSize, lblOutput.Font.Style);
            }

            else if (txtBoxInput.Text == "KECILKAN")
            {
                float ukuranSize;
                ukuranSize = lblOutput.Font.SizeInPoints;
                ukuranSize -= 1;
                lblOutput.Font = new Font(lblOutput.Font.Name, ukuranSize, lblOutput.Font.Style);
            }
            else
            {
                MessageBox.Show("Syntax tidak terdaftar!");
            }
        }
    }
}
