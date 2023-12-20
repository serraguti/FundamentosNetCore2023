namespace Fundamentos
{
    partial class Form05Char
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
            txtLetras = new TextBox();
            txtDigitos = new TextBox();
            label2 = new Label();
            txtSimbolos = new TextBox();
            label3 = new Label();
            txtPuntuacion = new TextBox();
            label4 = new Label();
            btnRecorrerAscii = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(29, 58);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(264, 133);
            txtLetras.TabIndex = 1;
            // 
            // txtDigitos
            // 
            txtDigitos.Location = new Point(392, 58);
            txtDigitos.Multiline = true;
            txtDigitos.Name = "txtDigitos";
            txtDigitos.Size = new Size(264, 133);
            txtDigitos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 23);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 2;
            label2.Text = "Dígitos";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(29, 253);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(264, 133);
            txtSimbolos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 218);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 4;
            label3.Text = "Símbolos";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(392, 253);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(264, 133);
            txtPuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 218);
            label4.Name = "label4";
            label4.Size = new Size(134, 32);
            label4.TabIndex = 6;
            label4.Text = "Puntuación";
            // 
            // btnRecorrerAscii
            // 
            btnRecorrerAscii.Location = new Point(242, 410);
            btnRecorrerAscii.Name = "btnRecorrerAscii";
            btnRecorrerAscii.Size = new Size(214, 67);
            btnRecorrerAscii.TabIndex = 8;
            btnRecorrerAscii.Text = "Recorrer ASCII";
            btnRecorrerAscii.UseVisualStyleBackColor = true;
            btnRecorrerAscii.Click += btnRecorrerAscii_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 489);
            Controls.Add(btnRecorrerAscii);
            Controls.Add(txtPuntuacion);
            Controls.Add(label4);
            Controls.Add(txtSimbolos);
            Controls.Add(label3);
            Controls.Add(txtDigitos);
            Controls.Add(label2);
            Controls.Add(txtLetras);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLetras;
        private TextBox txtDigitos;
        private Label label2;
        private TextBox txtSimbolos;
        private Label label3;
        private TextBox txtPuntuacion;
        private Label label4;
        private Button btnRecorrerAscii;
    }
}