using objExcel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Dto;

namespace Veterinaria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private async void GetAllProducts()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7097/api/Cliente"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var cliente = await response.Content.ReadAsStringAsync();
                        var displayData = JsonConvert.DeserializeObject<List<ClienteDto>>(cliente);
                        dgvVet.DataSource = displayData.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede Obtener la Lista de Productos: {response.StatusCode}");
                    }
                }
            }
        }

        

        private async void AddProduct()
        {
            ClienteCreateDto HCliente = new ClienteCreateDto();
            HCliente.Name = txtNombre.Text;
            HCliente.Medicamento = txtMedicamento.Text;
            HCliente.Empresa = txtEmpresa.Text;
            HCliente.RazaId = int.Parse(txtEspecie.Text);
            HCliente.Pesokg = double.Parse(txtPeso.Text);
            HCliente.Precio = double.Parse(txtPrecio.Text);
            HCliente.AñodeCaducidad = int.Parse(txtFechaCad.Text);

            using (var client = new HttpClient())
            {
                var seralizedClient = JsonConvert.SerializeObject(HCliente);
                var content = new StringContent(seralizedClient, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7097/api/Cliente", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Dato Agregado Correctamente");
                else
                    MessageBox.Show($"Error al guardar el Dato: {response.Content.ReadAsStringAsync().Result}");
            }
            Clear();
            GetAllProducts();
        }

        private static int id = 0;
        private void Clear()
        {
            txtID.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPeso.Text = String.Empty;
            txtMedicamento.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtEmpresa.Text = String.Empty;
            txtFechaCad.Text = String.Empty;
            txtEspecie.Text = String.Empty;
            id = 0;
        }

      
        private async void GetProductsById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7097/api/Cliente", id));
                if (response.IsSuccessStatusCode)
                {
                    var cliente = await response.Content.ReadAsStringAsync();
                    ClienteDto clienteDto = JsonConvert.DeserializeObject<ClienteDto>(cliente);
                    txtID.Text = clienteDto.idCliente.ToString();
                    txtNombre.Text = clienteDto.Name;
                    txtPeso.Text = clienteDto.Pesokg.ToString();
                    txtMedicamento.Text = clienteDto.Medicamento;
                    txtPrecio.Text = clienteDto.Precio.ToString();
                    txtEmpresa.Text = clienteDto.Empresa;
                    txtFechaCad.Text = clienteDto.AñodeCaducidad.ToString();
                    txtEspecie.Text = clienteDto.RazaId.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el dato: {response.StatusCode}");
                }
            }
        }

       

        private async void UpdateProduct()
        {
            ClienteUpdateDto ClientDto = new ClienteUpdateDto();
            ClientDto.idCliente = id;
            ClientDto.Name = txtNombre.Text;
            ClientDto.Pesokg = double.Parse(txtPeso.Text);
            ClientDto.Medicamento = txtMedicamento.Text;
            ClientDto.Precio = double.Parse(txtPrecio.Text);
            ClientDto.Empresa = txtEmpresa.Text;
            ClientDto.AñodeCaducidad = int.Parse(txtFechaCad.Text);
            ClientDto.RazaId = int.Parse(txtEspecie.Text);
            using (var client = new HttpClient())
            {
                var cliente = JsonConvert.SerializeObject(ClientDto);
                var content = new StringContent(cliente, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7097/api/Cliente", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Datos actualizados");
                else
                    MessageBox.Show($"Error al actualizar los Datos: {response.StatusCode}");
            }
            Clear();
            GetAllProducts();
        }

       

        private async void DeleteProduct()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7097/api/Cliente");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7097/api/Cliente", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Dato eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el Dato: {response.StatusCode}");
            }
            Clear();
            GetAllProducts();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void btnIsertar_Click_1(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteProduct();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateProduct();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void dgvVet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVet_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvVet.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetProductsById(id);
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            objExcel.Application objAplicacion = new objExcel.Application();
            Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

            objAplicacion.Visible = false;



            foreach (DataGridViewColumn columna in dgvVet.Columns)
            {
                objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach (DataGridViewRow fila in dgvVet.Rows)
                {
                    objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                }
            }

            objLibro.SaveAs(ruta + "\\RegistroVeterinaria.xlsx");
            objLibro.Close();
            MessageBox.Show("Se creo el archivo excel correctamente");
        }
    }
}