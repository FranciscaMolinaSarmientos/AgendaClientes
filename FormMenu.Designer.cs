namespace AgendaClientes
{
    partial class FormMenu
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
            labelTituloPropietario = new Label();
            labelPropietario = new Label();
            labelTituloTelefono = new Label();
            labelTelefono = new Label();
            buttonMostrar = new Button();
            buttonAgregar = new Button();
            buttonBuscar = new Button();
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
            labelSubtitulo.Text = "Operaciones";
            labelSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // labelTituloPropietario
            //
            labelTituloPropietario.AutoSize = true;
            labelTituloPropietario.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloPropietario.Location = new Point(60, 170);
            labelTituloPropietario.Name = "labelTituloPropietario";
            labelTituloPropietario.Size = new Size(131, 31);
            labelTituloPropietario.TabIndex = 3;
            labelTituloPropietario.Text = "Agenda de:";
            //
            // labelPropietario
            //
            labelPropietario.AutoSize = true;
            labelPropietario.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPropietario.ForeColor = Color.Black;
            labelPropietario.Location = new Point(200, 170);
            labelPropietario.Name = "labelPropietario";
            labelPropietario.Size = new Size(130, 31);
            labelPropietario.TabIndex = 4;
            labelPropietario.Text = "propietario";
            //
            // labelTituloTelefono
            //
            labelTituloTelefono.AutoSize = true;
            labelTituloTelefono.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloTelefono.Location = new Point(440, 170);
            labelTituloTelefono.Name = "labelTituloTelefono";
            labelTituloTelefono.Size = new Size(111, 31);
            labelTituloTelefono.TabIndex = 5;
            labelTituloTelefono.Text = "Teléfono:";
            //
            // labelTelefono
            //
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTelefono.ForeColor = Color.Black;
            labelTelefono.Location = new Point(560, 170);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(98, 31);
            labelTelefono.TabIndex = 6;
            labelTelefono.Text = "telefono";
            //
            // buttonMostrar
            //
            buttonMostrar.BackColor = Color.LightBlue;
            buttonMostrar.FlatAppearance.BorderColor = Color.Gray;
            buttonMostrar.FlatAppearance.BorderSize = 1;
            buttonMostrar.FlatStyle = FlatStyle.Flat;
            buttonMostrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMostrar.ForeColor = Color.Black;
            buttonMostrar.Location = new Point(60, 260);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(200, 60);
            buttonMostrar.TabIndex = 7;
            buttonMostrar.Text = "Mostrar clientes";
            buttonMostrar.UseVisualStyleBackColor = false;
            buttonMostrar.Click += buttonMostrar_Click;
            //
            // buttonAgregar
            //
            buttonAgregar.BackColor = Color.FromArgb(190, 230, 200);
            buttonAgregar.FlatAppearance.BorderColor = Color.Gray;
            buttonAgregar.FlatAppearance.BorderSize = 1;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregar.ForeColor = Color.Black;
            buttonAgregar.Location = new Point(300, 260);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(200, 60);
            buttonAgregar.TabIndex = 8;
            buttonAgregar.Text = "Agregar cliente";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            //
            // buttonBuscar
            //
            buttonBuscar.BackColor = Color.Pink;
            buttonBuscar.FlatAppearance.BorderColor = Color.Gray;
            buttonBuscar.FlatAppearance.BorderSize = 1;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.ForeColor = Color.Black;
            buttonBuscar.Location = new Point(540, 260);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(200, 60);
            buttonBuscar.TabIndex = 9;
            buttonBuscar.Text = "Buscar cliente";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
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
            buttonRegresar.TabIndex = 10;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            //
            // FormMenu
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonMostrar);
            Controls.Add(labelTelefono);
            Controls.Add(labelTituloTelefono);
            Controls.Add(labelPropietario);
            Controls.Add(labelTituloPropietario);
            Controls.Add(labelSubtitulo);
            Name = "FormMenu";
            Text = "Agenda de clientes";
            Load += FormMenu_Load;
            Controls.SetChildIndex(labelSubtitulo, 0);
            Controls.SetChildIndex(labelTituloPropietario, 0);
            Controls.SetChildIndex(labelPropietario, 0);
            Controls.SetChildIndex(labelTituloTelefono, 0);
            Controls.SetChildIndex(labelTelefono, 0);
            Controls.SetChildIndex(buttonMostrar, 0);
            Controls.SetChildIndex(buttonAgregar, 0);
            Controls.SetChildIndex(buttonBuscar, 0);
            Controls.SetChildIndex(buttonRegresar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSubtitulo;
        private Label labelTituloPropietario;
        private Label labelPropietario;
        private Label labelTituloTelefono;
        private Label labelTelefono;
        private Button buttonMostrar;
        private Button buttonAgregar;
        private Button buttonBuscar;
        private Button buttonRegresar;
    }
}
