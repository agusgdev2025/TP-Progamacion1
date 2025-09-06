namespace TPLaboratorioUAI
{
    partial class frmPrincipal
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
            pnlLeft = new Panel();
            label1 = new Label();
            label3 = new Label();
            btnForm2 = new Button();
            btnForm1 = new Button();
            label2 = new Label();
            pnlRight = new Panel();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.LightGray;
            pnlLeft.Controls.Add(label1);
            pnlLeft.Controls.Add(label3);
            pnlLeft.Controls.Add(btnForm2);
            pnlLeft.Controls.Add(btnForm1);
            pnlLeft.Controls.Add(label2);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(3, 4, 3, 4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(321, 1055);
            pnlLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 775);
            label1.Name = "label1";
            label1.Size = new Size(321, 97);
            label1.TabIndex = 4;
            label1.Text = "     PROFESOR:\r\n          FABIAN FRANKEL Bartolome \r\n          Alejandro\r\n          ";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 872);
            label3.Name = "label3";
            label3.Size = new Size(321, 183);
            label3.TabIndex = 0;
            label3.Text = "     ALUMNOS:\r\n          GUERRERA Agustín\r\n          LOVERA Gerardo\r\n          PONTINO Lucia\r\n          SARMIENTO Agustín\r\n          VACCARI Andrés Juan";
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(10, 197);
            btnForm2.Margin = new Padding(3, 4, 3, 4);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(301, 68);
            btnForm2.TabIndex = 3;
            btnForm2.Text = "FORM 2";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // btnForm1
            // 
            btnForm1.Location = new Point(10, 121);
            btnForm1.Margin = new Padding(3, 4, 3, 4);
            btnForm1.Name = "btnForm1";
            btnForm1.Size = new Size(301, 68);
            btnForm1.TabIndex = 2;
            btnForm1.Text = "FORM 1";
            btnForm1.UseVisualStyleBackColor = true;
            btnForm1.Click += btnForm1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 27);
            label2.Name = "label2";
            label2.Size = new Size(292, 41);
            label2.TabIndex = 1;
            label2.Text = "PROGRAMACIÓN 1";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.Transparent;
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(321, 0);
            pnlRight.Margin = new Padding(3, 4, 3, 4);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1318, 1055);
            pnlRight.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 1055);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "TP GRUPAL LABORATORIO - FORMULARIO MDI";
            Load += frmPrincipal_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlRight;
        private Button btnForm2;
        private Button btnForm1;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}