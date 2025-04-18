namespace CalculadoraSimple
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            cmbOperacion = new ComboBox();
            button1 = new Button();
            lblResultado = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(126, 27);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(197, 23);
            txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(126, 69);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(197, 23);
            txtNumero2.TabIndex = 1;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(386, 27);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(386, 69);
            button1.Name = "button1";
            button1.Size = new Size(119, 35);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Yellow;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(223, 120);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(100, 25);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            lblResultado.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(45, 27);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 5;
            label2.Text = "Digitó 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 69);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 6;
            label3.Text = "Digitó 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(597, 350);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Controls.Add(cmbOperacion);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private ComboBox cmbOperacion;
        private Button button1;
        private Label lblResultado;
        private Label label2;
        private Label label3;
    }
}
