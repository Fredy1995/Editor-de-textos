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

namespace EditorTextos
{
    public partial class Form1 : Form
    {
        private Font fuentePr;
        public Form1()
        {
            InitializeComponent();
        }

        private void ArchivoSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EdicionCortar_Click(object sender, EventArgs e)
        {
            ctEditor.Cut();
        }

        private void EdicionCopiar_Click(object sender, EventArgs e)
        {
            ctEditor.Copy();
        }

        private void EdicionPegar_Click(object sender, EventArgs e)
        {
            ctEditor.Paste();
        }

        private void OpFuCouriernew_Click(object sender, EventArgs e)
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font("Courier New", f.Size, f.Style);
            OpFuCouriernew.Checked = true;
            OpFuArial.Checked = false;
            OpFuPredeterminada.Checked = false;
        }

        private void OpFuArial_Click(object sender, EventArgs e)
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font("Arial", f.Size, f.Style);
            OpFuCouriernew.Checked = false;
            OpFuArial.Checked = true;
            OpFuPredeterminada.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fuentePr = ctEditor.Font;
            OpFuPredeterminada.Checked = true;
            OpTamPredeterminado.Checked = true;
        }

        private void OpFuPredeterminada_Click(object sender, EventArgs e)
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font(fuentePr.SystemFontName, f.Size, f.Style);
        }


        private void OpTam16_Click(object sender, EventArgs e)
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font(fuentePr.SystemFontName, 16.0F, f.Style);
            OpTam16.Checked = true;
            OpTam24.Checked = false;
            OpTamPredeterminado.Checked = false;
            
        }

        private void OpTam24_Click(object sender, EventArgs e)
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font(fuentePr.SystemFontName, 24.0F, f.Style);
            OpTam16.Checked = false;
            OpTam24.Checked = true;
            OpTamPredeterminado.Checked = false;
            
        }

        private void OpTamPredeterminado_Click(object sender, EventArgs e)
        {
            Font f = ctEditor.Font;
            ctEditor.Font = new Font(fuentePr.SystemFontName, 10.0F, f.Style);
            
        }

        private void menuEdicion_DropDownOpening(object sender, EventArgs e)
        {
            bool textoSeleccionado = (ctEditor.SelectedText.Length != 0);
            EdicionCopiar.Enabled = textoSeleccionado;
            EdicionCortar.Enabled = textoSeleccionado;
        }

        private void BtbarCortar_Click(object sender, EventArgs e)
        {
            ctEditor.Cut();
        }

        private void BtbarCopiar_Click(object sender, EventArgs e)
        {
            ctEditor.Copy();
        }

        private void BtbarPegar_Click(object sender, EventArgs e)
        {
            ctEditor.Paste();
        }

        private void EdicionDeshacer_Click(object sender, EventArgs e)
        {
            if (ctEditor.CanUndo) ctEditor.Undo();
          
        }

        private void EdicionRehacer_Click(object sender, EventArgs e)
        {
            
        }

        private void ArchivoAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlabrir = new OpenFileDialog();
            String cadena ="";
            Dlabrir.ShowReadOnly = true;
            Dlabrir.InitialDirectory = "C:\\Users\\Fredy Garate\\Documents>";
            Dlabrir.Filter = "ficheros txt (*.txt)|*.txt|Todos (*.*)|*.*";
            Dlabrir.FilterIndex = 2;
            Dlabrir.RestoreDirectory = true;
            //Mostar el dialogo abrir
            if(Dlabrir.ShowDialog() == DialogResult.OK)
            {
              
            
                String ruta = Dlabrir.FileName;
                byte[] infoArchivo = new byte[1000000000];
                FileStream fs = new FileStream(ruta, FileMode.Open);
                fs.Read(infoArchivo, 0, (int)fs.Length);
                ctEditor.Text = ASCIIEncoding.ASCII.GetString(infoArchivo);
                fs.Close();
                MessageBox.Show(Dlabrir.FileName);
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream fs;
            String cadena = ctEditor.Text;
            SaveFileDialog DlgGuardar = new SaveFileDialog();
            DlgGuardar.Filter = "ficheros txt (*.txt)|*.txt|Todos (*.*)|*.*";
            DlgGuardar.FilterIndex = 2;
            DlgGuardar.RestoreDirectory = true;

            if(DlgGuardar.ShowDialog() == DialogResult.OK)
            {
                fs = DlgGuardar.OpenFile();
                if(fs != null)
                {
                    fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
                    fs.Close();
                }
                MessageBox.Show("¡Archivo Guardado exitosamente!");
            }
        }

        private void ArchivoSalir_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Cierra la aplicación...";
        }

        private void ArchivoSalir_MouseLeave(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Listo";
        }

        private void Guardar_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Guarda archivo...";
        }

        private void Guardar_MouseLeave(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Listo";
        }

        private void Abrir_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Abrir archivo....";
        }

        private void Abrir_MouseLeave(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Listo";
        }

        private void Cortar_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Cortar contenido...";
        }

        private void Cortar_MouseLeave(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Listo";
        }

        private void Copiar_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Copiar contenido...";
        }

        private void Copiar_MouseLeave(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Listo";
        }

        private void Pegar_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Pegar contenido...";
        }

        private void Pegar_MouseLeave(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Listo";
        }
    }
}
