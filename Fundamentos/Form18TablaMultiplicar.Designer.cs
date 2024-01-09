namespace Fundamentos
{
    partial class Form18TablaMultiplicar
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
            txtNumero = new TextBox();
            btnMostrarTabla = new Button();
            panel1 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(36, 63);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(118, 39);
            txtNumero.TabIndex = 1;
            // 
            // btnMostrarTabla
            // 
            btnMostrarTabla.Location = new Point(36, 128);
            btnMostrarTabla.Name = "btnMostrarTabla";
            btnMostrarTabla.Size = new Size(174, 81);
            btnMostrarTabla.TabIndex = 2;
            btnMostrarTabla.Text = "Mostrar tabla";
            btnMostrarTabla.UseVisualStyleBackColor = true;
            btnMostrarTabla.Click += btnMostrarTabla_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(271, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 326);
            panel1.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(34, 202);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(34, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(34, 265);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 39);
            textBox5.TabIndex = 4;
            // 
            // Form18TablaMultiplicar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 352);
            Controls.Add(panel1);
            Controls.Add(btnMostrarTabla);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form18TablaMultiplicar";
            Text = "Form18TablaMultiplicar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnMostrarTabla;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}