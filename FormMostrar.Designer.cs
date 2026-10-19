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
            labelSubtitulo = new Label();
            listBoxClientes = new ListBox();
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
            labelSubtitulo.Text = "Mostrar clientes";
            labelSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // listBoxClientes
            //
            listBoxClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.HorizontalScrollbar = true;
            listBoxClientes.Location = new Point(25, 145);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(750, 229);
            listBoxClientes.TabIndex = 3;
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
            Controls.Add(listBoxClientes);
            Controls.Add(labelSubtitulo);
            Name = "FormMostrar";
            Text = "Agenda de clientes";
            Load += FormMostrar_Load;
            Controls.SetChildIndex(labelSubtitulo, 0);
            Controls.SetChildIndex(listBoxClientes, 0);
            Controls.SetChildIndex(buttonRegresar, 0);
            ResumeLayout(false);
        }

        #endregion

        private Label labelSubtitulo;
        private ListBox listBoxClientes;
        private Button buttonRegresar;
    }
}
