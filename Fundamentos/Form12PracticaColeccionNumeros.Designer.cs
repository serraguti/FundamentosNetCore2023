namespace Fundamentos
{
    partial class Form12PracticaColeccionNumeros
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
            label1 = new Label();
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            label3 = new Label();
            txtPares = new TextBox();
            label4 = new Label();
            txtImpares = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 32;
            lstNumeros.Location = new Point(42, 67);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(159, 228);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(268, 18);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(149, 41);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(258, 79);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(176, 46);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 174);
            label2.Name = "label2";
            label2.Size = new Size(74, 32);
            label2.TabIndex = 4;
            label2.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(334, 167);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 39);
            txtSuma.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 229);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 6;
            label3.Text = "Pares";
            // 
            // txtPares
            // 
            txtPares.Location = new Point(334, 222);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 39);
            txtPares.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 289);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 8;
            label4.Text = "Impares";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(334, 282);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 39);
            txtImpares.TabIndex = 9;
            // 
            // Form12PracticaColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 347);
            Controls.Add(txtImpares);
            Controls.Add(label4);
            Controls.Add(txtPares);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form12PracticaColeccionNumeros";
            Text = "Form12PracticaColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label label2;
        private TextBox txtSuma;
        private Label label3;
        private TextBox txtPares;
        private Label label4;
        private TextBox txtImpares;
    }
}