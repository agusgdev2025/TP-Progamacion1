namespace TPLaboratorioUAI
{
    partial class FormPrincipal
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
            btnForm2 = new Button();
            btnForm1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            PanelForm = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(11, 123);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(166, 57);
            btnForm2.TabIndex = 9;
            btnForm2.Text = "Form 2";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click_1;
            // 
            // btnForm1
            // 
            btnForm1.Location = new Point(11, 60);
            btnForm1.Name = "btnForm1";
            btnForm1.Size = new Size(166, 57);
            btnForm1.TabIndex = 8;
            btnForm1.Text = "Form 1";
            btnForm1.UseVisualStyleBackColor = true;
            btnForm1.Click += btnForm1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(11, 302);
            label3.Name = "label3";
            label3.Size = new Size(246, 40);
            label3.TabIndex = 7;
            label3.Text = "Profesor:\r\nBartolome Alejandro Fabian Frankel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(11, 192);
            label2.Name = "label2";
            label2.Size = new Size(139, 100);
            label2.TabIndex = 6;
            label2.Text = "Integrantes:\r\nPontino Lucia\r\nVaccari Andrés Juan\r\nLovera Gerardo \r\nGuerrera Agustin ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(175, 31);
            label1.TabIndex = 5;
            label1.Text = "Programacion 1";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnForm1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnForm2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 658);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // PanelForm
            // 
            PanelForm.Dock = DockStyle.Right;
            PanelForm.Location = new Point(278, 0);
            PanelForm.Name = "PanelForm";
            PanelForm.Size = new Size(872, 658);
            PanelForm.TabIndex = 11;
            PanelForm.Paint += PanelForm_Paint;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 658);
            Controls.Add(panel1);
            Controls.Add(PanelForm);
            Name = "FormPrincipal";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnForm2;
        private Button btnForm1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel PanelForm;
    }
}