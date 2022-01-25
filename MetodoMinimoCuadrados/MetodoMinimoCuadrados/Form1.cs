using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MetodoMinimoCuadrados
{
    public partial class Form1 : Form
    {
        //Agregamos la variable n para btnborrar
        private int n = 0;



         
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Si los textbox estan vacios mostramos mensage
            if (string.IsNullOrEmpty(TxtNF.Text))
            {
                string message = "Tienes que ingresar un numero de filas";
                MessageBox.Show(message);
            } else if (string.IsNullOrEmpty(txtX.Text))
            {
                string message = "Tienes que ingresar un valor a X";
                MessageBox.Show(message);
            }
            else if (string.IsNullOrEmpty(txtY.Text))
            {
                string message = "Tienes que ingresar un valor a Y";
                MessageBox.Show(message);
            }
            //Si textbox tiene valores continuamos sin problemas
            else
            {
                //Adicionamos nuevo renglon 
                int x, y;
                int n = Tabla.Rows.Add();
                //Declaramos variables de XY y X^2
                int xy, x2;
                //Hacemos las operaciones
                xy = int.Parse(txtX.Text) * int.Parse(txtY.Text);
                x2 = int.Parse(txtX.Text) * int.Parse(txtX.Text);

                //Graficamos mediante se ingresan los datos
                x = int.Parse(txtX.Text);
                y = int.Parse(txtY.Text);
                grafica.Series[0].Points.AddXY(x, y);



                //Colocamos la informacion en la tabla
                Tabla.Rows[n].Cells[0].Value = txtX.Text;
                Tabla.Rows[n].Cells[1].Value = txtY.Text;
                Tabla.Rows[n].Cells[2].Value = xy;
                Tabla.Rows[n].Cells[3].Value = x2;



                //Limpiamos Los Txt
                txtX.Text = "";
                txtY.Text = "";
            }

            

            

            
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            
            //Si la tabla está sin valores en este caso tiene una columna mostramos
            if ((Tabla.RowCount) == 1)
            {
                string message = "La tabla está vacia";
                MessageBox.Show(message);
            }
            //Borramos renglon de la tabla
            else
            {
                Tabla.Rows.RemoveAt(n);
            }
        }

       private void Tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n!=-1)
            {
                lblInfo.Text = (String)Tabla.Rows[n].Cells[0].Value + ", " + Tabla.Rows[n].Cells[1].Value;
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if ((Tabla.RowCount) == 1)
            {
                string message = "La tabla está vacia";
                MessageBox.Show(message);
            }
            else
            {
                //Decalramos variables de la suma de la tabla
                int totalx = 0;
                int totaly = 0;
                int totalxy = 0;
                int totalx2 = 0;

                //buscamos todos los datos y se suman
                foreach (DataGridViewRow row in Tabla.Rows)
                {
                    totalx += Convert.ToInt32(row.Cells["X"].Value);
                    totaly += Convert.ToInt32(row.Cells["Y"].Value);
                    totalxy += Convert.ToInt32(row.Cells["XY"].Value);
                    totalx2 += Convert.ToInt32(row.Cells["X2"].Value);
                }
                //Escribimos el resultado en los label
                totalX.Text = Convert.ToString(totalx);
                totalY.Text = Convert.ToString(totaly);
                totalXY.Text = Convert.ToString(totalxy);
                totalX2.Text = Convert.ToString(totalx2);

                //Pasamos todos los datos a operacion m
                Double tx, ty, txy, tx2, tx2c, txt2f, txtrm, txtrb;
                Double m1, m2, resultadom, resultadob, resultadoPE;
                Double gpb, gpx;
                int sem;
                sem = int.Parse(TxtNF.Text);
                txtTotalFila.Text = sem.ToString();
                //Mandamos a llamar el txt
                tx = int.Parse(totalX.Text);
                //asignamos el txt a otro txt
                txtTotalx.Text = "(" + tx.ToString() + ")";
                ty = int.Parse(totalY.Text);
                txtTotaly.Text = "(" + ty.ToString() + ")";
                txy = int.Parse(totalXY.Text);
                txtTotalxy.Text = txy.ToString();
                tx2 = int.Parse(totalX2.Text);
                txtTotalx2.Text = tx2.ToString();
                tx2c = int.Parse(totalX.Text);
                txtTotalxCopia1.Text = "(" + tx.ToString() + ")^2";
                txt2f = int.Parse(TxtNF.Text);
                txtTotalFilaCopia.Text = txt2f.ToString();

                //Calculamos resultados de m
                m1 = (txy) - (tx) * (ty) / sem;
                m2 = (tx2) - (tx) * (tx) / sem;
                resultadom = m1 / m2;

                txtrm = Double.Parse(txtResultadoM.Text);
                txtResultadoM.Text = Math.Round(resultadom, 2, MidpointRounding.ToEven).ToString();

                //Resultados de b
                txtyb.Text = "(" + ty.ToString() + ")" + " - " + "(" + Math.Round(resultadom, 2, MidpointRounding.ToEven) + ")";
                txtxb.Text = "(" + tx.ToString() + ")";

                txtfilab.Text = sem.ToString();
                txtfilab2.Text = sem.ToString();

                resultadob = (ty) / sem - (resultadom) * (tx) / sem;

                txtrb = Double.Parse(txtRb.Text);
                txtRb.Text = Math.Round(resultadob, 2, MidpointRounding.ToEven).ToString();

                //Igualacion
                TxtIgualar.Text = Math.Round(resultadom, 2, MidpointRounding.ToEven).ToString()
                + " x " + Math.Round(resultadob, 2, MidpointRounding.ToEven).ToString();

                TxtIgualar2.Text = "0 = " + Math.Round(resultadom, 2, MidpointRounding.ToEven).ToString()
                + " x " + Math.Round(resultadob, 2, MidpointRounding.ToEven).ToString();

                if (resultadom < 0)
                {
                    resultadoPE = resultadob / resultadom * -1;

                    TxtPuntoE.Text = "X= " + Math.Round(resultadob, 2, MidpointRounding.ToEven).ToString()
                    + " / " + Math.Round(resultadom, 2, MidpointRounding.ToEven).ToString() + " = "
                    + Math.Round(resultadoPE, 2, MidpointRounding.ToEven).ToString();
                }
                else
                {
                    resultadoPE = resultadob / resultadom;
                    TxtPuntoE.Text = "X= " + Math.Round(resultadob, 2, MidpointRounding.ToEven).ToString()
                    + " / " + Math.Round(resultadom, 2, MidpointRounding.ToEven).ToString() + " = "
                    + Math.Round(resultadoPE, 2, MidpointRounding.ToEven).ToString();
                }
                //Graficamos mediante se ingresan los datos


                grafica.ChartAreas.Add("area1");

                grafica.Series.Add("Recta");
                grafica.Series["Recta"].ChartArea = "area1";
                grafica.Series["Recta"].ChartType = SeriesChartType.Spline;
                grafica.Series["Recta"].Color = Color.Red;

                grafica.Series["Recta"].Points.AddXY(0, Math.Round(resultadob, 2, MidpointRounding.ToEven).ToString());

                grafica.Series["Recta"].Points.AddXY(Math.Round(resultadoPE, 2, MidpointRounding.ToEven).ToString(), 0);
            }
            
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void GraficaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Grafica_Click(object sender, EventArgs e)
        {

        }

        private void TxtNF_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            string message = "Creado Por Aldo Alejandro";
            MessageBox.Show(message);
        }
    }
}
