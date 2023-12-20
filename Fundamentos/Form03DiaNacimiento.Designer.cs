namespace Fundamentos
{
    partial class Form03DiaNacimiento
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
            label2 = new Label();
            label3 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnyo = new TextBox();
            btnCalcularDia = new Button();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 32);
            label1.TabIndex = 0;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 83);
            label2.Name = "label2";
            label2.Size = new Size(59, 32);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 142);
            label3.Name = "label3";
            label3.Size = new Size(57, 32);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(163, 19);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 39);
            txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(163, 76);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 39);
            txtMes.TabIndex = 4;
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(163, 135);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(100, 39);
            txtAnyo.TabIndex = 5;
            // 
            // btnCalcularDia
            // 
            btnCalcularDia.Location = new Point(294, 19);
            btnCalcularDia.Name = "btnCalcularDia";
            btnCalcularDia.Size = new Size(150, 155);
            btnCalcularDia.TabIndex = 6;
            btnCalcularDia.Text = "Calcular día nacimiento";
            btnCalcularDia.UseVisualStyleBackColor = true;
            btnCalcularDia.Click += btnCalcularDia_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(53, 212);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(160, 32);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "lblDiaSemana";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 263);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnCalcularDia);
            Controls.Add(txtAnyo);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnyo;
        private Button btnCalcularDia;
        private Label lblDiaSemana;
    }
}