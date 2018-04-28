using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliceNicoleOtávio
{
    public partial class Vetor : Form
    {
        int[] vetorA = new int[5];
        int[] vetorB = new int[5];
        string vetorC = "";
        int i = 0;

        public Vetor()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {

            vetorC = string.Empty;

            if (mskA1.Text == string.Empty || mskA2.Text == string.Empty || mskA3.Text == string.Empty || mskA4.Text == string.Empty || mskA5.Text == string.Empty ||
                mskB1.Text == string.Empty || mskB2.Text == string.Empty || mskB3.Text == string.Empty || mskB4.Text == string.Empty || mskB5.Text == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Por favor preencha todo os números dos Vetores");
            }
            else if (mskNum.Text == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Por favor digite um número inteiro para verificar");
                mskNum.Focus();
            }
            else
            {
                vetorA[0] = int.Parse(mskA1.Text);
                vetorA[1] = int.Parse(mskA2.Text);
                vetorA[2] = int.Parse(mskA3.Text);
                vetorA[3] = int.Parse(mskA4.Text);
                vetorA[4] = int.Parse(mskA5.Text);
                vetorB[0] = int.Parse(mskB1.Text);
                vetorB[1] = int.Parse(mskB2.Text);
                vetorB[2] = int.Parse(mskB3.Text);
                vetorB[3] = int.Parse(mskB4.Text);
                vetorB[4] = int.Parse(mskB5.Text);

                if (vetorA.Contains(int.Parse(mskNum.Text)))
                {
                    for (i = 0; i < vetorB.Length; i++)
                    {
                        if (int.Parse(mskNum.Text) == vetorB[i])
                        {
                            vetorC += " " + vetorB[i].ToString();
                            tbxResultado.Text = vetorC;
                        }
                    }
                    if (!vetorB.Contains(int.Parse(mskNum.Text)))
                    {
                        System.Windows.Forms.MessageBox.Show("Vetor C vazio pois o número " + int.Parse(mskNum.Text) + " não se encontra no Vetor B");
                    }

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("O número " + int.Parse(mskNum.Text) + " não se encontra no Vetor A, por favor digite outro número");
                }
                
            } 
        }
    }
}
