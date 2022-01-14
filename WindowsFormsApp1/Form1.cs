using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private CLehrer L1 = new CLehrer();
        private CKlasse K1 = new CKlasse();
        private CSchuler S1 = new CSchuler();
        private CSchuler S2 = new CSchuler();
        private CSchuler S3 = new CSchuler();
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = " ";
            S1.set_Name("SchulerN1");S1.set_Vorname("SchulerV1");
            S2.set_Name("SchulerN2"); S2.set_Vorname("SchulerV2");
            S3.set_Name("SchulerN3"); S3.set_Vorname("SchulerV3");
            L1.set_Name("LehrerN1"); L1.set_Vorname("LehrerV1");
            K1.set_Name("I92VF");
            L1.set_Klasse(K1);
            K1.set_Klassenlehrer(L1);
            K1.add_Schuler(S1);
            S1.set_Status(true);
            K1.add_Schuler(S2);
            S2.set_Status(true);
            K1.add_Schuler(S3);
            S3.set_Status(true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = L1.get_Klasse().get_Name();
            textBox2.Text = L1.get_Name() + " " + L1.get_Vorname();
            richTextBox1.Text = L1.get_Klasse().get_Schulerliste();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = K1.get_Name();
            textBox2.Text = K1.get_Lehrer().get_Name()+" "+ K1.get_Lehrer().get_Vorname();
            richTextBox1.Text = K1.get_Schulerliste();
        }
    }
}
