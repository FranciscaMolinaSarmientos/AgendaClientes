namespace AgendaClientes
{
    partial class FormBuscar
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
            labelSubtitulo = new Label();
            labelBuscar = new Label();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            labelTelefono = new Label();
            textBoxTelefono = new TextBox();
            labelEmpresa = new Label();
            textBoxEmpresa = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            buttonBorrar = new Button();
            buttonActualizar = new Button();
            buttonRegresar = new Button();
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
            labelSubtitulo.Text = "Buscar cliente";
            labelSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBuscar.Location = new Point(130, 150);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(176, 31);
            labelBuscar.TabIndex = 3;
            labelBuscar.Text = "Ingresa nombre";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxBuscar.Location = new Point(330, 143);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(300, 38);
            textBoxBuscar.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.Pink;
            buttonBuscar.FlatAppearance.BorderColor = Color.Gray;
            buttonBuscar.FlatAppearance.BorderSize = 1;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.ForeColor = Color.Black;
            buttonBuscar.Location = new Point(645, 139);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(130, 47);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(200, 205);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(95, 31);
            labelNombre.TabIndex = 6;
            labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(330, 198);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(300, 38);
            textBoxNombre.TabIndex = 7;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefono.Location = new Point(200, 251);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(103, 31);
            labelTelefono.TabIndex = 8;
            labelTelefono.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTelefono.Location = new Point(330, 244);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(300, 38);
            textBoxTelefono.TabIndex = 9;
            // 
            // labelEmpresa
            // 
            labelEmpresa.AutoSize = true;
            labelEmpresa.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmpresa.Location = new Point(200, 297);
            labelEmpresa.Name = "labelEmpresa";
            labelEmpresa.Size = new Size(99, 31);
            labelEmpresa.TabIndex = 10;
            labelEmpresa.Text = "Empresa";
            // 
            // textBoxEmpresa
            // 
            textBoxEmpresa.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEmpresa.Location = new Point(330, 290);
            textBoxEmpresa.Name = "textBoxEmpresa";
            textBoxEmpresa.Size = new Size(300, 38);
            textBoxEmpresa.TabIndex = 11;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(200, 343);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(66, 31);
            labelEmail.TabIndex = 12;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(330, 336);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(300, 38);
            textBoxEmail.TabIndex = 13;
            // 
            // buttonBorrar
            // 
            buttonBorrar.BackColor = Color.FromArgb(255, 210, 165);
            buttonBorrar.FlatAppearance.BorderColor = Color.Gray;
            buttonBorrar.FlatAppearance.BorderSize = 1;
            buttonBorrar.FlatStyle = FlatStyle.Flat;
            buttonBorrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBorrar.ForeColor = Color.Black;
            buttonBorrar.Location = new Point(250, 391);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(150, 47);
            buttonBorrar.TabIndex = 14;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = false;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.FromArgb(190, 230, 200);
            buttonActualizar.FlatAppearance.BorderColor = Color.Gray;
            buttonActualizar.FlatAppearance.BorderSize = 1;
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonActualizar.ForeColor = Color.Black;
            buttonActualizar.Location = new Point(420, 391);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(150, 47);
            buttonActualizar.TabIndex = 15;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
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
            buttonRegresar.TabIndex = 16;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // FormBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonBorrar);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmpresa);
            Controls.Add(labelEmpresa);
            Controls.Add(textBoxTelefono);
            Controls.Add(labelTelefono);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(labelBuscar);
            Controls.Add(labelSubtitulo);
            Name = "FormBuscar";
            Text = "Agenda de clientes";
            Controls.SetChildIndex(labelSubtitulo, 0);
            Controls.SetChildIndex(labelBuscar, 0);
            Controls.SetChildIndex(textBoxBuscar, 0);
            Controls.SetChildIndex(buttonBuscar, 0);
            Controls.SetChildIndex(labelNombre, 0);
            Controls.SetChildIndex(textBoxNombre, 0);
            Controls.SetChildIndex(labelTelefono, 0);
            Controls.SetChildIndex(textBoxTelefono, 0);
            Controls.SetChildIndex(labelEmpresa, 0);
            Controls.SetChildIndex(textBoxEmpresa, 0);
            Controls.SetChildIndex(labelEmail, 0);
            Controls.SetChildIndex(textBoxEmail, 0);
            Controls.SetChildIndex(buttonBorrar, 0);
            Controls.SetChildIndex(buttonActualizar, 0);
            Controls.SetChildIndex(buttonRegresar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSubtitulo;
        private Label labelBuscar;
        private TextBox textBoxBuscar;
        private Button buttonBuscar;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Label labelEmpresa;
        private TextBox textBoxEmpresa;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Button buttonBorrar;
        private Button buttonActualizar;
        private Button buttonRegresar;
    }
}
