namespace AgendaClientes
{
    partial class FormMostrar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            labelSubtitulo = new Label();
            dataGridViewClientes = new DataGridView();
            columnNombre = new DataGridViewTextBoxColumn();
            columnTelefono = new DataGridViewTextBoxColumn();
            columnEmpresa = new DataGridViewTextBoxColumn();
            columnEmail = new DataGridViewTextBoxColumn();
            buttonRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            //
            // labelSubtitulo
            //
            labelSubtitulo.BackColor = Color.LightGray;
            labelSubtitulo.Dock = DockStyle.Top;
            labelSubtitulo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSubtitulo.ForeColor = Color.Black;
            labelSubtitulo.Location = new Point(0, 75);
            labelSubtitulo.Name = "labelSubtitulo";
            labelSubtitulo.Size = new Size(800, 55);
            labelSubtitulo.TabIndex = 2;
            labelSubtitulo.Text = "Mostrar clientes";
            labelSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // dataGridViewClientes
            //
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { columnNombre, columnTelefono, columnEmpresa, columnEmail });
            dataGridViewClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewClientes.Location = new Point(25, 145);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.RowHeadersVisible = false;
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.Size = new Size(750, 230);
            dataGridViewClientes.TabIndex = 3;
            //
            // columnNombre
            //
            columnNombre.HeaderText = "Nombre";
            columnNombre.MinimumWidth = 6;
            columnNombre.Name = "columnNombre";
            columnNombre.ReadOnly = true;
            //
            // columnTelefono
            //
            columnTelefono.HeaderText = "Teléfono";
            columnTelefono.MinimumWidth = 6;
            columnTelefono.Name = "columnTelefono";
            columnTelefono.ReadOnly = true;
            //
            // columnEmpresa
            //
            columnEmpresa.HeaderText = "Empresa";
            columnEmpresa.MinimumWidth = 6;
            columnEmpresa.Name = "columnEmpresa";
            columnEmpresa.ReadOnly = true;
            //
            // columnEmail
            //
            columnEmail.HeaderText = "Email";
            columnEmail.MinimumWidth = 6;
            columnEmail.Name = "columnEmail";
            columnEmail.ReadOnly = true;
            //
            // buttonRegresar
            //
            buttonRegresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRegresar.BackColor = Color.Gainsboro;
            buttonRegresar.FlatAppearance.BorderColor = Color.Gray;
            buttonRegresar.FlatAppearance.BorderSize = 1;
            buttonRegresar.FlatStyle = FlatStyle.Flat;
            buttonRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.ForeColor = Color.Black;
            buttonRegresar.Location = new Point(12, 391);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(130, 47);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            //
            // FormMostrar
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegresar);
            Controls.Add(dataGridViewClientes);
            Controls.Add(labelSubtitulo);
            Name = "FormMostrar";
            Text = "Agenda de clientes";
            Load += FormMostrar_Load;
            Controls.SetChildIndex(labelSubtitulo, 0);
            Controls.SetChildIndex(dataGridViewClientes, 0);
            Controls.SetChildIndex(buttonRegresar, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelSubtitulo;
        private DataGridView dataGridViewClientes;
        private DataGridViewTextBoxColumn columnNombre;
        private DataGridViewTextBoxColumn columnTelefono;
        private DataGridViewTextBoxColumn columnEmpresa;
        private DataGridViewTextBoxColumn columnEmail;
        private Button buttonRegresar;
    }
}
