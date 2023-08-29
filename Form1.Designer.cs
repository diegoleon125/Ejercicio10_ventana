namespace Ejercicio10_ventana
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
            label1 = new Label();
            txtconsum = new TextBox();
            button1 = new Button();
            lblDesc = new Label();
            lblSubtotal = new Label();
            lblImpuesto = new Label();
            lblaPagar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 26);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese monto de consumo:";
            // 
            // txtconsum
            // 
            txtconsum.Location = new Point(258, 23);
            txtconsum.Name = "txtconsum";
            txtconsum.Size = new Size(100, 23);
            txtconsum.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(195, 62);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(104, 99);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(129, 15);
            lblDesc.TabIndex = 3;
            lblDesc.Text = "monto del descuento...";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(104, 122);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(59, 15);
            lblSubtotal.TabIndex = 4;
            lblSubtotal.Text = "subtotal...";
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(105, 141);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(124, 15);
            lblImpuesto.TabIndex = 5;
            lblImpuesto.Text = "monto del impuesto...";
            // 
            // lblaPagar
            // 
            lblaPagar.AutoSize = true;
            lblaPagar.Location = new Point(108, 160);
            lblaPagar.Name = "lblaPagar";
            lblaPagar.Size = new Size(126, 15);
            lblaPagar.TabIndex = 6;
            lblaPagar.Text = "importe final a pagar...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 244);
            Controls.Add(lblaPagar);
            Controls.Add(lblImpuesto);
            Controls.Add(lblSubtotal);
            Controls.Add(lblDesc);
            Controls.Add(button1);
            Controls.Add(txtconsum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtconsum;
        private Button button1;
        private Label lblDesc;
        private Label lblSubtotal;
        private Label lblImpuesto;
        private Label lblaPagar;
    }
}