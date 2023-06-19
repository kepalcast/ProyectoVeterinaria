namespace Veterinaria
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelDatos = new Panel();
            label11 = new Label();
            label10 = new Label();
            txtID = new TextBox();
            label6 = new Label();
            txtEspecie = new TextBox();
            label7 = new Label();
            txtFechaCad = new TextBox();
            label8 = new Label();
            txtEmpresa = new TextBox();
            label9 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtMedicamento = new TextBox();
            label4 = new Label();
            txtPeso = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            panelNombre = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            btnLimpiar = new Button();
            btnIsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvVet = new DataGridView();
            panelDatos.SuspendLayout();
            panelNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVet).BeginInit();
            SuspendLayout();
            // 
            // panelDatos
            // 
            panelDatos.BackColor = Color.FromArgb(192, 255, 192);
            panelDatos.Controls.Add(label11);
            panelDatos.Controls.Add(label10);
            panelDatos.Controls.Add(txtID);
            panelDatos.Controls.Add(label6);
            panelDatos.Controls.Add(txtEspecie);
            panelDatos.Controls.Add(label7);
            panelDatos.Controls.Add(txtFechaCad);
            panelDatos.Controls.Add(label8);
            panelDatos.Controls.Add(txtEmpresa);
            panelDatos.Controls.Add(label9);
            panelDatos.Controls.Add(txtPrecio);
            panelDatos.Controls.Add(label5);
            panelDatos.Controls.Add(txtMedicamento);
            panelDatos.Controls.Add(label4);
            panelDatos.Controls.Add(txtPeso);
            panelDatos.Controls.Add(label3);
            panelDatos.Controls.Add(txtNombre);
            panelDatos.Controls.Add(label1);
            panelDatos.Location = new Point(1, -7);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(207, 465);
            panelDatos.TabIndex = 104;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(0, 370);
            label11.Name = "label11";
            label11.Size = new Size(101, 20);
            label11.TabIndex = 74;
            label11.Text = "Si es Gato = 2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(0, 337);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 73;
            label10.Text = "Si es Perro = 1";
            // 
            // txtID
            // 
            txtID.BackColor = Color.DarkSeaGreen;
            txtID.Enabled = false;
            txtID.Location = new Point(107, 32);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 71;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(3, 35);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 72;
            label6.Text = "ID";
            // 
            // txtEspecie
            // 
            txtEspecie.BackColor = Color.DarkSeaGreen;
            txtEspecie.Location = new Point(104, 348);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(100, 23);
            txtEspecie.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(35, 307);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 70;
            label7.Text = "Especie ( 1 o 2)";
            // 
            // txtFechaCad
            // 
            txtFechaCad.BackColor = Color.DarkSeaGreen;
            txtFechaCad.Location = new Point(107, 261);
            txtFechaCad.Name = "txtFechaCad";
            txtFechaCad.Size = new Size(100, 23);
            txtFechaCad.TabIndex = 67;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(3, 264);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 68;
            label8.Text = "Fecha Cad";
            // 
            // txtEmpresa
            // 
            txtEmpresa.BackColor = Color.DarkSeaGreen;
            txtEmpresa.Location = new Point(107, 222);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(100, 23);
            txtEmpresa.TabIndex = 65;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(3, 225);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 66;
            label9.Text = "Empresa";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.DarkSeaGreen;
            txtPrecio.Location = new Point(107, 183);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(3, 186);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 64;
            label5.Text = "Precio";
            // 
            // txtMedicamento
            // 
            txtMedicamento.BackColor = Color.DarkSeaGreen;
            txtMedicamento.Location = new Point(107, 144);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(100, 23);
            txtMedicamento.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(3, 147);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 62;
            label4.Text = "Medicamento";
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.DarkSeaGreen;
            txtPeso.Location = new Point(107, 105);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(3, 108);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 60;
            label3.Text = "Peso (KG)";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.DarkSeaGreen;
            txtNombre.Location = new Point(107, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(3, 72);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 58;
            label1.Text = "Nombre";
            // 
            // panelNombre
            // 
            panelNombre.BackColor = Color.FromArgb(128, 255, 128);
            panelNombre.Controls.Add(dateTimePicker1);
            panelNombre.Controls.Add(label2);
            panelNombre.Location = new Point(203, -5);
            panelNombre.Name = "panelNombre";
            panelNombre.Size = new Size(592, 98);
            panelNombre.TabIndex = 103;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(376, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(192, 23);
            dateTimePicker1.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.BottomLeft;
            label2.Location = new Point(43, 14);
            label2.Name = "label2";
            label2.Size = new Size(348, 39);
            label2.TabIndex = 74;
            label2.Text = "Veterinaria Aguilera";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Control;
            btnLimpiar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(597, 152);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(163, 36);
            btnLimpiar.TabIndex = 102;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIsertar
            // 
            btnIsertar.BackColor = SystemColors.Control;
            btnIsertar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnIsertar.ForeColor = SystemColors.ActiveCaptionText;
            btnIsertar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIsertar.Location = new Point(414, 99);
            btnIsertar.Name = "btnIsertar";
            btnIsertar.Size = new Size(176, 36);
            btnIsertar.TabIndex = 101;
            btnIsertar.Text = "Insertar";
            btnIsertar.UseVisualStyleBackColor = false;
            btnIsertar.Click += btnIsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Control;
            btnActualizar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnActualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(414, 152);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(176, 36);
            btnActualizar.TabIndex = 100;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(597, 99);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(163, 36);
            btnEliminar.TabIndex = 99;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvVet
            // 
            dgvVet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVet.BackgroundColor = SystemColors.ControlDarkDark;
            dgvVet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVet.Location = new Point(203, 195);
            dgvVet.Name = "dgvVet";
            dgvVet.RowTemplate.Height = 25;
            dgvVet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVet.Size = new Size(596, 263);
            dgvVet.TabIndex = 98;
            dgvVet.CellClick += dgvVet_CellClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(panelDatos);
            Controls.Add(panelNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIsertar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvVet);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            panelNombre.ResumeLayout(false);
            panelNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDatos;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtMedicamento;
        private Label label4;
        private TextBox txtPeso;
        private Label label3;
        private TextBox txtNombre;
        private Label label1;
        private Panel panelNombre;
        private Label label2;
        private Button btnLimpiar;
        public Button btnIsertar;
        public Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvVet;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private Label label10;
        private TextBox txtID;
        private Label label6;
        private TextBox txtEspecie;
        private Label label7;
        private TextBox txtFechaCad;
        private Label label8;
        private TextBox txtEmpresa;
        private Label label9;
    }
}