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
    public partial class Matriz : Form
    {
        int[,] matriz = new int[4,4];
        int i = 0;
        int j = 0;


        public Matriz()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (mskL0C0.Text == string.Empty || mskL0C1.Text == string.Empty || mskL0C2.Text == string.Empty || mskL0C3.Text == string.Empty ||
                mskL1C0.Text == string.Empty || mskL1C1.Text == string.Empty || mskL1C2.Text == string.Empty || mskL1C3.Text == string.Empty ||
                mskL2C0.Text == string.Empty || mskL2C1.Text == string.Empty || mskL2C2.Text == string.Empty || mskL2C3.Text == string.Empty ||
                mskL3C0.Text == string.Empty || mskL3C1.Text == string.Empty || mskL3C2.Text == string.Empty || mskL3C3.Text == string.Empty )
            {
                System.Windows.Forms.MessageBox.Show("Por favor, preencha todos os números da matriz");
            }
            else
            {
                bool simetrica = true;

                matriz[0, 0] = int.Parse(mskL0C0.Text);
                matriz[0, 1] = int.Parse(mskL0C1.Text);
                matriz[0, 2] = int.Parse(mskL0C2.Text);
                matriz[0, 3] = int.Parse(mskL0C3.Text);
                matriz[1, 0] = int.Parse(mskL1C0.Text);
                matriz[1, 1] = int.Parse(mskL1C1.Text);
                matriz[1, 2] = int.Parse(mskL1C2.Text);
                matriz[1, 3] = int.Parse(mskL1C3.Text);
                matriz[2, 0] = int.Parse(mskL2C0.Text);
                matriz[2, 1] = int.Parse(mskL2C1.Text);
                matriz[2, 2] = int.Parse(mskL2C2.Text);
                matriz[2, 3] = int.Parse(mskL2C3.Text);
                matriz[3, 0] = int.Parse(mskL3C0.Text);
                matriz[3, 1] = int.Parse(mskL3C1.Text);
                matriz[3, 2] = int.Parse(mskL3C2.Text);
                matriz[3, 3] = int.Parse(mskL3C3.Text);

                 for (i = 0; i < 4; i++){
                    if (matriz[i, 0] != matriz[0,i]){
                        simetrica = false;
                     }
                 }

                
                if (simetrica)
                {
                    System.Windows.Forms.MessageBox.Show("Simétrica");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Não Simétrica");
                }
            }
            
        }
    }
}
