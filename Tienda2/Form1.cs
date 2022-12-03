using System.Configuration;
using Tienda2.Inventario;

namespace Tienda2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Botón en la barra superior para cerrar la aplicación.
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Boton en la barra superior para minimizar la ventana.
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Boton en la barra superior para maximizar o restaurar la ventana.
        private void restoreButton_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }
        //Función para arrastrar la ventana al mantener presionado el mouse en la barra superior.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //Botón para mostrar pestaña de nueva compra
        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            panelNewClient.Visible = true;
            panelInventario.Visible = false;
            panelReporte.Visible = false;
            panelAgregarInventario.Visible = false;
        }
        //Botón para mostrar pestaña de inventario
        private void buttonInventario_Click(object sender, EventArgs e)
        {
            //Mostrar la ventada de inventario
            panelNewClient.Visible = false;
            panelInventario.Visible = true;
            panelReporte.Visible = false;
            panelAgregarInventario.Visible = false;


            StreamReader existencia = new StreamReader($@"..\..\..\Inventario\Existencia.txt");
            int num = Int32.Parse(existencia.ReadLine());
            existencia.Close();
            listViewInventario.Items.Clear();
            for (int i = 0; i < num; i++)
            {
                StreamReader producto = new StreamReader($@"..\..\..\Inventario\Productos\producto{i}.txt");
                string aux = producto.ReadLine();
                producto.Close();
                string[] info = aux.Split(',');
                Console.WriteLine(aux);
                Console.WriteLine(info);
                string[] arr = { info[0], info[1], info[3] };
                ListViewItem prod = new ListViewItem(arr);
                listViewInventario.Items.Add(prod);
            }

        }
        //Botón para mostrar pestaña de agregar productos
        private void buttonAgregarInventario_Click(object sender, EventArgs e)
        {
            panelNewClient.Visible = false;
            panelInventario.Visible = false;
            panelReporte.Visible = false;
            panelAgregarInventario.Visible = true;
        }
        //Botón para mostrar pestaña de reporte
        private void button1_Click(object sender, EventArgs e)
        {
            panelNewClient.Visible = false;
            panelInventario.Visible = false;
            panelReporte.Visible = true;
            panelAgregarInventario.Visible = false;
        }

        private void textBoxRecibido_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptarCompra_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void panelNewClient_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddInv_Click(object sender, EventArgs e)
        {
            string nombre = textBoxAgregarNombre.Text;
            string barCode = textBoxAgregarCodigo.Text;
            int cantidad = (int)numericUpDownAgregarPiezas.Value;
            float precioP = float.Parse(textBoxAgregarPrecio.Text);
            float precioU = Int32.Parse(textBoxAgregarPrecioUnitario.Text);
            if(radioButtonNuevo.Checked == true)
            {
                Producto nuevo = new Producto(nombre, barCode, cantidad, precioP, precioU);
                nuevo.AgregarInventario();
            } else
            {
                MessageBox.Show("Producto Ya existe OMG!");
            }
            
        }
    }
}