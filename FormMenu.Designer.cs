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
            labelAgendaDe = new Label();
            labelPropietario = new Label();
            labelTel = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            labelSubtitulo.Size = new Size(800, 54);
            labelSubtitulo.TabIndex = 2;
            labelSubtitulo.Text = "Operaciones";
            labelSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAgendaDe
            // 
            labelAgendaDe.AutoSize = true;
            labelAgendaDe.Location = new Point(39, 141);
            labelAgendaDe.Name = "labelAgendaDe";
            labelAgendaDe.Size = new Size(85, 20);
            labelAgendaDe.TabIndex = 3;
            labelAgendaDe.Text = "Agenda de:";
            // 
            // labelPropietario
            // 
            labelPropietario.AutoSize = true;
            labelPropietario.Location = new Point(39, 206);
            labelPropietario.Name = "labelPropietario";
            labelPropietario.Size = new Size(83, 20);
            labelPropietario.TabIndex = 4;
            labelPropietario.Text = "Propietario";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(39, 269);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(67, 20);
            labelTel.TabIndex = 5;
            labelTel.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 322);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(131, 144);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(131, 206);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(131, 265);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(147, 322);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(labelTel);
            Controls.Add(labelPropietario);
            Controls.Add(labelAgendaDe);
            Controls.Add(labelSubtitulo);
            Name = "FormMenu";
            Text = "Agenda de clientes";
            Load += FormMenu_Load;
            Controls.SetChildIndex(labelSubtitulo, 0);
            Controls.SetChildIndex(labelAgendaDe, 0);
            Controls.SetChildIndex(labelPropietario, 0);
            Controls.SetChildIndex(labelTel, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSubtitulo;
        private Label labelAgendaDe;
        private Label labelPropietario;
        private Label labelTel;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}