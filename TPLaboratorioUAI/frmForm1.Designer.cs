namespace TPLaboratorioUAI
{
    partial class frmForm1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            rdbHombre = new RadioButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            rdbMujer = new RadioButton();
            groupBox1 = new GroupBox();
            rdbOtro = new RadioButton();
            rdbNoBinario = new RadioButton();
            gbxVacunas = new GroupBox();
            chkFiebreAmarilla = new CheckBox();
            dtpDobleBacUltimaDosis = new DateTimePicker();
            label9 = new Label();
            cboCovidDosis = new ComboBox();
            label8 = new Label();
            chkTripleBacteriana = new CheckBox();
            chkHpv = new CheckBox();
            chkDobreBacteriana = new CheckBox();
            chkTripleViral = new CheckBox();
            chkHepatitisA = new CheckBox();
            chkCovid = new CheckBox();
            chkAntigripal = new CheckBox();
            chkMeningococo = new CheckBox();
            chkRotavirus = new CheckBox();
            chkTuberculosis = new CheckBox();
            chkBcg = new CheckBox();
            chkHepatitisB = new CheckBox();
            chkVaricela = new CheckBox();
            label3 = new Label();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            lstVacunacion = new ListBox();
            groupBox3 = new GroupBox();
            txtNroDocumento = new TextBox();
            groupBox4 = new GroupBox();
            rdbPas = new RadioButton();
            rdbLc = new RadioButton();
            rdbLe = new RadioButton();
            rdbDni = new RadioButton();
            label7 = new Label();
            cboLocalidad = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            dtpFecNacimiento = new DateTimePicker();
            txtApellido = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            gbxVacunas.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE VACUNACIÓN";
            // 
            // rdbHombre
            // 
            rdbHombre.AutoSize = true;
            rdbHombre.Font = new Font("Segoe UI", 11.25F);
            rdbHombre.Location = new Point(36, 22);
            rdbHombre.Name = "rdbHombre";
            rdbHombre.Size = new Size(82, 24);
            rdbHombre.TabIndex = 22;
            rdbHombre.TabStop = true;
            rdbHombre.Text = "Hombre";
            rdbHombre.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // rdbMujer
            // 
            rdbMujer.AutoSize = true;
            rdbMujer.Font = new Font("Segoe UI", 11.25F);
            rdbMujer.Location = new Point(142, 22);
            rdbMujer.Name = "rdbMujer";
            rdbMujer.Size = new Size(65, 24);
            rdbMujer.TabIndex = 23;
            rdbMujer.TabStop = true;
            rdbMujer.Text = "Mujer";
            rdbMujer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbOtro);
            groupBox1.Controls.Add(rdbNoBinario);
            groupBox1.Controls.Add(rdbHombre);
            groupBox1.Controls.Add(rdbMujer);
            groupBox1.Font = new Font("Segoe UI", 11.25F);
            groupBox1.Location = new Point(9, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 52);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Género";
            // 
            // rdbOtro
            // 
            rdbOtro.AutoSize = true;
            rdbOtro.Font = new Font("Segoe UI", 11.25F);
            rdbOtro.Location = new Point(354, 22);
            rdbOtro.Name = "rdbOtro";
            rdbOtro.Size = new Size(57, 24);
            rdbOtro.TabIndex = 25;
            rdbOtro.TabStop = true;
            rdbOtro.Text = "Otro";
            rdbOtro.UseVisualStyleBackColor = true;
            // 
            // rdbNoBinario
            // 
            rdbNoBinario.AutoSize = true;
            rdbNoBinario.Font = new Font("Segoe UI", 11.25F);
            rdbNoBinario.Location = new Point(232, 22);
            rdbNoBinario.Name = "rdbNoBinario";
            rdbNoBinario.Size = new Size(98, 24);
            rdbNoBinario.TabIndex = 24;
            rdbNoBinario.TabStop = true;
            rdbNoBinario.Text = "No binario";
            rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // gbxVacunas
            // 
            gbxVacunas.Controls.Add(chkFiebreAmarilla);
            gbxVacunas.Controls.Add(dtpDobleBacUltimaDosis);
            gbxVacunas.Controls.Add(label9);
            gbxVacunas.Controls.Add(cboCovidDosis);
            gbxVacunas.Controls.Add(label8);
            gbxVacunas.Controls.Add(chkTripleBacteriana);
            gbxVacunas.Controls.Add(chkHpv);
            gbxVacunas.Controls.Add(chkDobreBacteriana);
            gbxVacunas.Controls.Add(chkTripleViral);
            gbxVacunas.Controls.Add(chkHepatitisA);
            gbxVacunas.Controls.Add(chkCovid);
            gbxVacunas.Controls.Add(chkAntigripal);
            gbxVacunas.Controls.Add(chkMeningococo);
            gbxVacunas.Controls.Add(chkRotavirus);
            gbxVacunas.Controls.Add(chkTuberculosis);
            gbxVacunas.Controls.Add(chkBcg);
            gbxVacunas.Controls.Add(chkHepatitisB);
            gbxVacunas.Controls.Add(chkVaricela);
            gbxVacunas.Font = new Font("Segoe UI", 11.25F);
            gbxVacunas.Location = new Point(9, 290);
            gbxVacunas.Name = "gbxVacunas";
            gbxVacunas.Size = new Size(460, 283);
            gbxVacunas.TabIndex = 26;
            gbxVacunas.TabStop = false;
            gbxVacunas.Text = "Vacunas administradas";
            // 
            // chkFiebreAmarilla
            // 
            chkFiebreAmarilla.AutoSize = true;
            chkFiebreAmarilla.Font = new Font("Segoe UI", 11.25F);
            chkFiebreAmarilla.Location = new Point(20, 216);
            chkFiebreAmarilla.Name = "chkFiebreAmarilla";
            chkFiebreAmarilla.Size = new Size(127, 24);
            chkFiebreAmarilla.TabIndex = 33;
            chkFiebreAmarilla.Text = "Fiebre amarilla";
            chkFiebreAmarilla.UseVisualStyleBackColor = true;
            // 
            // dtpDobleBacUltimaDosis
            // 
            dtpDobleBacUltimaDosis.Font = new Font("Segoe UI", 11.25F);
            dtpDobleBacUltimaDosis.Format = DateTimePickerFormat.Short;
            dtpDobleBacUltimaDosis.Location = new Point(130, 182);
            dtpDobleBacUltimaDosis.Name = "dtpDobleBacUltimaDosis";
            dtpDobleBacUltimaDosis.Size = new Size(125, 27);
            dtpDobleBacUltimaDosis.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(48, 120);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 24;
            label9.Text = "Cant. dosis:";
            // 
            // cboCovidDosis
            // 
            cboCovidDosis.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCovidDosis.FormattingEnabled = true;
            cboCovidDosis.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboCovidDosis.Location = new Point(144, 117);
            cboCovidDosis.Name = "cboCovidDosis";
            cboCovidDosis.Size = new Size(56, 28);
            cboCovidDosis.Sorted = true;
            cboCovidDosis.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(48, 185);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 23;
            label8.Text = "Ult. dosis:";
            // 
            // chkTripleBacteriana
            // 
            chkTripleBacteriana.AutoSize = true;
            chkTripleBacteriana.Font = new Font("Segoe UI", 11.25F);
            chkTripleBacteriana.Location = new Point(276, 155);
            chkTripleBacteriana.Name = "chkTripleBacteriana";
            chkTripleBacteriana.Size = new Size(139, 24);
            chkTripleBacteriana.TabIndex = 39;
            chkTripleBacteriana.Text = "Triple Bacteriana";
            chkTripleBacteriana.UseVisualStyleBackColor = true;
            // 
            // chkHpv
            // 
            chkHpv.AutoSize = true;
            chkHpv.Font = new Font("Segoe UI", 11.25F);
            chkHpv.Location = new Point(276, 65);
            chkHpv.Name = "chkHpv";
            chkHpv.Size = new Size(56, 24);
            chkHpv.TabIndex = 36;
            chkHpv.Text = "HPV";
            chkHpv.UseVisualStyleBackColor = true;
            // 
            // chkDobreBacteriana
            // 
            chkDobreBacteriana.AutoSize = true;
            chkDobreBacteriana.Font = new Font("Segoe UI", 11.25F);
            chkDobreBacteriana.Location = new Point(20, 155);
            chkDobreBacteriana.Name = "chkDobreBacteriana";
            chkDobreBacteriana.Size = new Size(143, 24);
            chkDobreBacteriana.TabIndex = 31;
            chkDobreBacteriana.Text = "Doble Bacteriana";
            chkDobreBacteriana.UseVisualStyleBackColor = true;
            chkDobreBacteriana.CheckedChanged += chkDobreBacteriana_CheckedChanged;
            // 
            // chkTripleViral
            // 
            chkTripleViral.AutoSize = true;
            chkTripleViral.Font = new Font("Segoe UI", 11.25F);
            chkTripleViral.Location = new Point(276, 185);
            chkTripleViral.Name = "chkTripleViral";
            chkTripleViral.Size = new Size(99, 24);
            chkTripleViral.TabIndex = 34;
            chkTripleViral.Text = "Triple Viral";
            chkTripleViral.UseVisualStyleBackColor = true;
            // 
            // chkHepatitisA
            // 
            chkHepatitisA.AutoSize = true;
            chkHepatitisA.Font = new Font("Segoe UI", 11.25F);
            chkHepatitisA.Location = new Point(20, 246);
            chkHepatitisA.Name = "chkHepatitisA";
            chkHepatitisA.Size = new Size(102, 24);
            chkHepatitisA.TabIndex = 34;
            chkHepatitisA.Text = "Hepatitis A";
            chkHepatitisA.UseVisualStyleBackColor = true;
            // 
            // chkCovid
            // 
            chkCovid.AutoSize = true;
            chkCovid.Font = new Font("Segoe UI", 11.25F);
            chkCovid.Location = new Point(20, 95);
            chkCovid.Name = "chkCovid";
            chkCovid.Size = new Size(88, 24);
            chkCovid.TabIndex = 29;
            chkCovid.Text = "Covid-19";
            chkCovid.UseVisualStyleBackColor = true;
            chkCovid.CheckedChanged += chkCovid_CheckedChanged;
            // 
            // chkAntigripal
            // 
            chkAntigripal.AutoSize = true;
            chkAntigripal.Font = new Font("Segoe UI", 11.25F);
            chkAntigripal.Location = new Point(20, 35);
            chkAntigripal.Name = "chkAntigripal";
            chkAntigripal.Size = new Size(94, 24);
            chkAntigripal.TabIndex = 27;
            chkAntigripal.Text = "Antigripal";
            chkAntigripal.UseVisualStyleBackColor = true;
            // 
            // chkMeningococo
            // 
            chkMeningococo.AutoSize = true;
            chkMeningococo.Font = new Font("Segoe UI", 11.25F);
            chkMeningococo.Location = new Point(276, 95);
            chkMeningococo.Name = "chkMeningococo";
            chkMeningococo.Size = new Size(119, 24);
            chkMeningococo.TabIndex = 37;
            chkMeningococo.Text = "Meningococo";
            chkMeningococo.UseVisualStyleBackColor = true;
            // 
            // chkRotavirus
            // 
            chkRotavirus.AutoSize = true;
            chkRotavirus.Font = new Font("Segoe UI", 11.25F);
            chkRotavirus.Location = new Point(276, 125);
            chkRotavirus.Name = "chkRotavirus";
            chkRotavirus.Size = new Size(89, 24);
            chkRotavirus.TabIndex = 38;
            chkRotavirus.Text = "Rotavirus";
            chkRotavirus.UseVisualStyleBackColor = true;
            // 
            // chkTuberculosis
            // 
            chkTuberculosis.AutoSize = true;
            chkTuberculosis.Font = new Font("Segoe UI", 11.25F);
            chkTuberculosis.Location = new Point(276, 215);
            chkTuberculosis.Name = "chkTuberculosis";
            chkTuberculosis.Size = new Size(110, 24);
            chkTuberculosis.TabIndex = 41;
            chkTuberculosis.Text = "Tuberculosis";
            chkTuberculosis.UseVisualStyleBackColor = true;
            // 
            // chkBcg
            // 
            chkBcg.AutoSize = true;
            chkBcg.Font = new Font("Segoe UI", 11.25F);
            chkBcg.Location = new Point(20, 65);
            chkBcg.Name = "chkBcg";
            chkBcg.Size = new Size(56, 24);
            chkBcg.TabIndex = 28;
            chkBcg.Text = "BCG";
            chkBcg.UseVisualStyleBackColor = true;
            // 
            // chkHepatitisB
            // 
            chkHepatitisB.AutoSize = true;
            chkHepatitisB.Font = new Font("Segoe UI", 11.25F);
            chkHepatitisB.Location = new Point(276, 35);
            chkHepatitisB.Name = "chkHepatitisB";
            chkHepatitisB.Size = new Size(101, 24);
            chkHepatitisB.TabIndex = 35;
            chkHepatitisB.Text = "Hepatitis B";
            chkHepatitisB.UseVisualStyleBackColor = true;
            // 
            // chkVaricela
            // 
            chkVaricela.AutoSize = true;
            chkVaricela.Font = new Font("Segoe UI", 11.25F);
            chkVaricela.Location = new Point(276, 245);
            chkVaricela.Name = "chkVaricela";
            chkVaricela.Size = new Size(80, 24);
            chkVaricela.TabIndex = 42;
            chkVaricela.Text = "Varicela";
            chkVaricela.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 10;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F);
            txtNombre.Location = new Point(6, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 27);
            txtNombre.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Dock = DockStyle.Bottom;
            btnRegistrar.Font = new Font("Segoe UI", 11.25F);
            btnRegistrar.Location = new Point(3, 579);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(471, 51);
            btnRegistrar.TabIndex = 43;
            btnRegistrar.Text = "REGISTRAR VACUNACIÓN";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // lstVacunacion
            // 
            lstVacunacion.Font = new Font("Segoe UI", 11.25F);
            lstVacunacion.FormattingEnabled = true;
            lstVacunacion.ItemHeight = 20;
            lstVacunacion.Location = new Point(492, 63);
            lstVacunacion.Name = "lstVacunacion";
            lstVacunacion.Size = new Size(498, 624);
            lstVacunacion.TabIndex = 44;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtNroDocumento);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(cboLocalidad);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnRegistrar);
            groupBox3.Controls.Add(dtpFecNacimiento);
            groupBox3.Controls.Add(txtApellido);
            groupBox3.Controls.Add(gbxVacunas);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtNombre);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(9, 54);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(477, 633);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos personales";
            // 
            // txtNroDocumento
            // 
            txtNroDocumento.Font = new Font("Segoe UI", 11.25F);
            txtNroDocumento.Location = new Point(344, 120);
            txtNroDocumento.Name = "txtNroDocumento";
            txtNroDocumento.Size = new Size(125, 27);
            txtNroDocumento.TabIndex = 18;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rdbPas);
            groupBox4.Controls.Add(rdbLc);
            groupBox4.Controls.Add(rdbLe);
            groupBox4.Controls.Add(rdbDni);
            groupBox4.Location = new Point(9, 98);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(295, 49);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tipo Documento";
            // 
            // rdbPas
            // 
            rdbPas.AutoSize = true;
            rdbPas.Location = new Point(206, 22);
            rdbPas.Name = "rdbPas";
            rdbPas.Size = new Size(52, 24);
            rdbPas.TabIndex = 17;
            rdbPas.TabStop = true;
            rdbPas.Text = "PAS";
            rdbPas.UseVisualStyleBackColor = true;
            // 
            // rdbLc
            // 
            rdbLc.AutoSize = true;
            rdbLc.Location = new Point(151, 22);
            rdbLc.Name = "rdbLc";
            rdbLc.Size = new Size(42, 24);
            rdbLc.TabIndex = 16;
            rdbLc.TabStop = true;
            rdbLc.Text = "LC";
            rdbLc.UseVisualStyleBackColor = true;
            // 
            // rdbLe
            // 
            rdbLe.AutoSize = true;
            rdbLe.Location = new Point(96, 22);
            rdbLe.Name = "rdbLe";
            rdbLe.Size = new Size(42, 24);
            rdbLe.TabIndex = 15;
            rdbLe.TabStop = true;
            rdbLe.Text = "LE";
            rdbLe.UseVisualStyleBackColor = true;
            // 
            // rdbDni
            // 
            rdbDni.AutoSize = true;
            rdbDni.Location = new Point(30, 22);
            rdbDni.Name = "rdbDni";
            rdbDni.Size = new Size(53, 24);
            rdbDni.TabIndex = 14;
            rdbDni.TabStop = true;
            rdbDni.Text = "DNI";
            rdbDni.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(200, 165);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 18;
            label7.Text = "Localidad";
            // 
            // cboLocalidad
            // 
            cboLocalidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Items.AddRange(new object[] { "25 de Mayo", "Catriló", "Ed. Castex", "General Acha", "General Pico", "Realicó", "Santa Rosa", "Telén", "Toay", "Victorica", "Winifreda" });
            cboLocalidad.Location = new Point(200, 187);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(246, 28);
            cboLocalidad.Sorted = true;
            cboLocalidad.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(9, 165);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 16;
            label6.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(344, 98);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 15;
            label5.Text = "Nro. Documento";
            // 
            // dtpFecNacimiento
            // 
            dtpFecNacimiento.Font = new Font("Segoe UI", 11.25F);
            dtpFecNacimiento.Format = DateTimePickerFormat.Short;
            dtpFecNacimiento.Location = new Point(9, 188);
            dtpFecNacimiento.Name = "dtpFecNacimiento";
            dtpFecNacimiento.Size = new Size(125, 27);
            dtpFecNacimiento.TabIndex = 19;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 11.25F);
            txtApellido.Location = new Point(243, 54);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(226, 27);
            txtApellido.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(243, 33);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 12;
            label4.Text = "Apellido";
            // 
            // frmForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 696);
            Controls.Add(groupBox3);
            Controls.Add(lstVacunacion);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmForm1";
            Text = "FORMULARIO 1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxVacunas.ResumeLayout(false);
            gbxVacunas.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdbHombre;
        private ContextMenuStrip contextMenuStrip1;
        private RadioButton rdbMujer;
        private GroupBox groupBox1;
        private GroupBox gbxVacunas;
        private CheckBox chkTuberculosis;
        private CheckBox chkHepatitisB;
        private CheckBox chkVaricela;
        private Label label3;
        private TextBox txtNombre;
        private Button btnRegistrar;
        private ContextMenuStrip contextMenuStrip2;
        private ListBox lstVacunacion;
        private RadioButton rdbNoBinario;
        private GroupBox groupBox3;
        private Label label5;
        private DateTimePicker dtpFecNacimiento;
        private TextBox txtApellido;
        private Label label4;
        private ComboBox cboLocalidad;
        private Label label6;
        private Label label7;
        private GroupBox groupBox4;
        private RadioButton rdbLc;
        private RadioButton rdbLe;
        private RadioButton rdbDni;
        private RadioButton rdbOtro;
        private TextBox txtNroDocumento;
        private RadioButton rdbPas;
        private CheckBox chkHpv;
        private CheckBox chkTripleViral;
        private CheckBox chkHepatitisA;
        private CheckBox chkCovid;
        private CheckBox chkAntigripal;
        private CheckBox chkMeningococo;
        private CheckBox chkRotavirus;
        private CheckBox chkBcg;
        private CheckBox chkTripleBacteriana;
        private CheckBox chkDobreBacteriana;
        private DateTimePicker dtpDobleBacUltimaDosis;
        private Label label9;
        private ComboBox cboCovidDosis;
        private Label label8;
        private CheckBox chkFiebreAmarilla;
    }
}