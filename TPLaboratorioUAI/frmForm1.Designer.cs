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
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(262, 25);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE VACUNACIÓN";
            // 
            // rdbHombre
            // 
            rdbHombre.AutoSize = true;
            rdbHombre.Font = new Font("Segoe UI", 11.25F);
            rdbHombre.Location = new Point(41, 29);
            rdbHombre.Margin = new Padding(3, 4, 3, 4);
            rdbHombre.Name = "rdbHombre";
            rdbHombre.Size = new Size(101, 29);
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
            rdbMujer.Location = new Point(162, 29);
            rdbMujer.Margin = new Padding(3, 4, 3, 4);
            rdbMujer.Name = "rdbMujer";
            rdbMujer.Size = new Size(83, 29);
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
            groupBox1.Location = new Point(10, 309);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(526, 69);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Género";
            // 
            // rdbOtro
            // 
            rdbOtro.AutoSize = true;
            rdbOtro.Font = new Font("Segoe UI", 11.25F);
            rdbOtro.Location = new Point(405, 29);
            rdbOtro.Margin = new Padding(3, 4, 3, 4);
            rdbOtro.Name = "rdbOtro";
            rdbOtro.Size = new Size(71, 29);
            rdbOtro.TabIndex = 25;
            rdbOtro.TabStop = true;
            rdbOtro.Text = "Otro";
            rdbOtro.UseVisualStyleBackColor = true;
            // 
            // rdbNoBinario
            // 
            rdbNoBinario.AutoSize = true;
            rdbNoBinario.Font = new Font("Segoe UI", 11.25F);
            rdbNoBinario.Location = new Point(265, 29);
            rdbNoBinario.Margin = new Padding(3, 4, 3, 4);
            rdbNoBinario.Name = "rdbNoBinario";
            rdbNoBinario.Size = new Size(123, 29);
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
            gbxVacunas.Location = new Point(10, 387);
            gbxVacunas.Margin = new Padding(3, 4, 3, 4);
            gbxVacunas.Name = "gbxVacunas";
            gbxVacunas.Padding = new Padding(3, 4, 3, 4);
            gbxVacunas.Size = new Size(526, 377);
            gbxVacunas.TabIndex = 26;
            gbxVacunas.TabStop = false;
            gbxVacunas.Text = "Vacunas administradas";
            // 
            // chkFiebreAmarilla
            // 
            chkFiebreAmarilla.AutoSize = true;
            chkFiebreAmarilla.Font = new Font("Segoe UI", 11.25F);
            chkFiebreAmarilla.Location = new Point(23, 288);
            chkFiebreAmarilla.Margin = new Padding(3, 4, 3, 4);
            chkFiebreAmarilla.Name = "chkFiebreAmarilla";
            chkFiebreAmarilla.Size = new Size(159, 29);
            chkFiebreAmarilla.TabIndex = 33;
            chkFiebreAmarilla.Text = "Fiebre amarilla";
            chkFiebreAmarilla.UseVisualStyleBackColor = true;
            // 
            // dtpDobleBacUltimaDosis
            // 
            dtpDobleBacUltimaDosis.Font = new Font("Segoe UI", 11.25F);
            dtpDobleBacUltimaDosis.Format = DateTimePickerFormat.Short;
            dtpDobleBacUltimaDosis.Location = new Point(149, 243);
            dtpDobleBacUltimaDosis.Margin = new Padding(3, 4, 3, 4);
            dtpDobleBacUltimaDosis.Name = "dtpDobleBacUltimaDosis";
            dtpDobleBacUltimaDosis.Size = new Size(142, 32);
            dtpDobleBacUltimaDosis.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(55, 160);
            label9.Name = "label9";
            label9.Size = new Size(107, 25);
            label9.TabIndex = 24;
            label9.Text = "Cant. dosis:";
            // 
            // cboCovidDosis
            // 
            cboCovidDosis.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCovidDosis.FormattingEnabled = true;
            cboCovidDosis.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboCovidDosis.Location = new Point(164, 156);
            cboCovidDosis.Margin = new Padding(3, 4, 3, 4);
            cboCovidDosis.Name = "cboCovidDosis";
            cboCovidDosis.Size = new Size(63, 33);
            cboCovidDosis.Sorted = true;
            cboCovidDosis.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(55, 247);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 23;
            label8.Text = "Ult. dosis:";
            // 
            // chkTripleBacteriana
            // 
            chkTripleBacteriana.AutoSize = true;
            chkTripleBacteriana.Font = new Font("Segoe UI", 11.25F);
            chkTripleBacteriana.Location = new Point(316, 207);
            chkTripleBacteriana.Margin = new Padding(3, 4, 3, 4);
            chkTripleBacteriana.Name = "chkTripleBacteriana";
            chkTripleBacteriana.Size = new Size(174, 29);
            chkTripleBacteriana.TabIndex = 39;
            chkTripleBacteriana.Text = "Triple Bacteriana";
            chkTripleBacteriana.UseVisualStyleBackColor = true;
            // 
            // chkHpv
            // 
            chkHpv.AutoSize = true;
            chkHpv.Font = new Font("Segoe UI", 11.25F);
            chkHpv.Location = new Point(316, 87);
            chkHpv.Margin = new Padding(3, 4, 3, 4);
            chkHpv.Name = "chkHpv";
            chkHpv.Size = new Size(70, 29);
            chkHpv.TabIndex = 36;
            chkHpv.Text = "HPV";
            chkHpv.UseVisualStyleBackColor = true;
            // 
            // chkDobreBacteriana
            // 
            chkDobreBacteriana.AutoSize = true;
            chkDobreBacteriana.Font = new Font("Segoe UI", 11.25F);
            chkDobreBacteriana.Location = new Point(23, 207);
            chkDobreBacteriana.Margin = new Padding(3, 4, 3, 4);
            chkDobreBacteriana.Name = "chkDobreBacteriana";
            chkDobreBacteriana.Size = new Size(178, 29);
            chkDobreBacteriana.TabIndex = 31;
            chkDobreBacteriana.Text = "Doble Bacteriana";
            chkDobreBacteriana.UseVisualStyleBackColor = true;
            chkDobreBacteriana.CheckedChanged += chkDobreBacteriana_CheckedChanged;
            // 
            // chkTripleViral
            // 
            chkTripleViral.AutoSize = true;
            chkTripleViral.Font = new Font("Segoe UI", 11.25F);
            chkTripleViral.Location = new Point(316, 247);
            chkTripleViral.Margin = new Padding(3, 4, 3, 4);
            chkTripleViral.Name = "chkTripleViral";
            chkTripleViral.Size = new Size(124, 29);
            chkTripleViral.TabIndex = 34;
            chkTripleViral.Text = "Triple Viral";
            chkTripleViral.UseVisualStyleBackColor = true;
            // 
            // chkHepatitisA
            // 
            chkHepatitisA.AutoSize = true;
            chkHepatitisA.Font = new Font("Segoe UI", 11.25F);
            chkHepatitisA.Location = new Point(23, 328);
            chkHepatitisA.Margin = new Padding(3, 4, 3, 4);
            chkHepatitisA.Name = "chkHepatitisA";
            chkHepatitisA.Size = new Size(125, 29);
            chkHepatitisA.TabIndex = 34;
            chkHepatitisA.Text = "Hepatitis A";
            chkHepatitisA.UseVisualStyleBackColor = true;
            // 
            // chkCovid
            // 
            chkCovid.AutoSize = true;
            chkCovid.Font = new Font("Segoe UI", 11.25F);
            chkCovid.Location = new Point(23, 127);
            chkCovid.Margin = new Padding(3, 4, 3, 4);
            chkCovid.Name = "chkCovid";
            chkCovid.Size = new Size(110, 29);
            chkCovid.TabIndex = 29;
            chkCovid.Text = "Covid-19";
            chkCovid.UseVisualStyleBackColor = true;
            chkCovid.CheckedChanged += chkCovid_CheckedChanged;
            // 
            // chkAntigripal
            // 
            chkAntigripal.AutoSize = true;
            chkAntigripal.Font = new Font("Segoe UI", 11.25F);
            chkAntigripal.Location = new Point(23, 47);
            chkAntigripal.Margin = new Padding(3, 4, 3, 4);
            chkAntigripal.Name = "chkAntigripal";
            chkAntigripal.Size = new Size(117, 29);
            chkAntigripal.TabIndex = 27;
            chkAntigripal.Text = "Antigripal";
            chkAntigripal.UseVisualStyleBackColor = true;
            // 
            // chkMeningococo
            // 
            chkMeningococo.AutoSize = true;
            chkMeningococo.Font = new Font("Segoe UI", 11.25F);
            chkMeningococo.Location = new Point(316, 127);
            chkMeningococo.Margin = new Padding(3, 4, 3, 4);
            chkMeningococo.Name = "chkMeningococo";
            chkMeningococo.Size = new Size(150, 29);
            chkMeningococo.TabIndex = 37;
            chkMeningococo.Text = "Meningococo";
            chkMeningococo.UseVisualStyleBackColor = true;
            // 
            // chkRotavirus
            // 
            chkRotavirus.AutoSize = true;
            chkRotavirus.Font = new Font("Segoe UI", 11.25F);
            chkRotavirus.Location = new Point(316, 167);
            chkRotavirus.Margin = new Padding(3, 4, 3, 4);
            chkRotavirus.Name = "chkRotavirus";
            chkRotavirus.Size = new Size(111, 29);
            chkRotavirus.TabIndex = 38;
            chkRotavirus.Text = "Rotavirus";
            chkRotavirus.UseVisualStyleBackColor = true;
            // 
            // chkTuberculosis
            // 
            chkTuberculosis.AutoSize = true;
            chkTuberculosis.Font = new Font("Segoe UI", 11.25F);
            chkTuberculosis.Location = new Point(316, 287);
            chkTuberculosis.Margin = new Padding(3, 4, 3, 4);
            chkTuberculosis.Name = "chkTuberculosis";
            chkTuberculosis.Size = new Size(140, 29);
            chkTuberculosis.TabIndex = 41;
            chkTuberculosis.Text = "Tuberculosis";
            chkTuberculosis.UseVisualStyleBackColor = true;
            // 
            // chkBcg
            // 
            chkBcg.AutoSize = true;
            chkBcg.Font = new Font("Segoe UI", 11.25F);
            chkBcg.Location = new Point(23, 87);
            chkBcg.Margin = new Padding(3, 4, 3, 4);
            chkBcg.Name = "chkBcg";
            chkBcg.Size = new Size(69, 29);
            chkBcg.TabIndex = 28;
            chkBcg.Text = "BCG";
            chkBcg.UseVisualStyleBackColor = true;
            // 
            // chkHepatitisB
            // 
            chkHepatitisB.AutoSize = true;
            chkHepatitisB.Font = new Font("Segoe UI", 11.25F);
            chkHepatitisB.Location = new Point(316, 47);
            chkHepatitisB.Margin = new Padding(3, 4, 3, 4);
            chkHepatitisB.Name = "chkHepatitisB";
            chkHepatitisB.Size = new Size(124, 29);
            chkHepatitisB.TabIndex = 35;
            chkHepatitisB.Text = "Hepatitis B";
            chkHepatitisB.UseVisualStyleBackColor = true;
            // 
            // chkVaricela
            // 
            chkVaricela.AutoSize = true;
            chkVaricela.Font = new Font("Segoe UI", 11.25F);
            chkVaricela.Location = new Point(316, 327);
            chkVaricela.Margin = new Padding(3, 4, 3, 4);
            chkVaricela.Name = "chkVaricela";
            chkVaricela.Size = new Size(101, 29);
            chkVaricela.TabIndex = 42;
            chkVaricela.Text = "Varicela";
            chkVaricela.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(7, 44);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 10;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F);
            txtNombre.Location = new Point(7, 72);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 32);
            txtNombre.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Dock = DockStyle.Bottom;
            btnRegistrar.Font = new Font("Segoe UI", 11.25F);
            btnRegistrar.Location = new Point(3, 772);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(539, 68);
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
            lstVacunacion.ItemHeight = 25;
            lstVacunacion.Location = new Point(562, 84);
            lstVacunacion.Margin = new Padding(3, 4, 3, 4);
            lstVacunacion.Name = "lstVacunacion";
            lstVacunacion.Size = new Size(569, 829);
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
            groupBox3.Location = new Point(10, 72);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(545, 844);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos personales";
            // 
            // txtNroDocumento
            // 
            txtNroDocumento.Font = new Font("Segoe UI", 11.25F);
            txtNroDocumento.Location = new Point(393, 160);
            txtNroDocumento.Margin = new Padding(3, 4, 3, 4);
            txtNroDocumento.Name = "txtNroDocumento";
            txtNroDocumento.Size = new Size(142, 32);
            txtNroDocumento.TabIndex = 18;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rdbPas);
            groupBox4.Controls.Add(rdbLc);
            groupBox4.Controls.Add(rdbLe);
            groupBox4.Controls.Add(rdbDni);
            groupBox4.Location = new Point(10, 131);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(337, 65);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tipo Documento";
            // 
            // rdbPas
            // 
            rdbPas.AutoSize = true;
            rdbPas.Location = new Point(235, 29);
            rdbPas.Margin = new Padding(3, 4, 3, 4);
            rdbPas.Name = "rdbPas";
            rdbPas.Size = new Size(65, 29);
            rdbPas.TabIndex = 17;
            rdbPas.TabStop = true;
            rdbPas.Text = "PAS";
            rdbPas.UseVisualStyleBackColor = true;
            // 
            // rdbLc
            // 
            rdbLc.AutoSize = true;
            rdbLc.Location = new Point(173, 29);
            rdbLc.Margin = new Padding(3, 4, 3, 4);
            rdbLc.Name = "rdbLc";
            rdbLc.Size = new Size(53, 29);
            rdbLc.TabIndex = 16;
            rdbLc.TabStop = true;
            rdbLc.Text = "LC";
            rdbLc.UseVisualStyleBackColor = true;
            // 
            // rdbLe
            // 
            rdbLe.AutoSize = true;
            rdbLe.Location = new Point(110, 29);
            rdbLe.Margin = new Padding(3, 4, 3, 4);
            rdbLe.Name = "rdbLe";
            rdbLe.Size = new Size(52, 29);
            rdbLe.TabIndex = 15;
            rdbLe.TabStop = true;
            rdbLe.Text = "LE";
            rdbLe.UseVisualStyleBackColor = true;
            // 
            // rdbDni
            // 
            rdbDni.AutoSize = true;
            rdbDni.Location = new Point(34, 29);
            rdbDni.Margin = new Padding(3, 4, 3, 4);
            rdbDni.Name = "rdbDni";
            rdbDni.Size = new Size(65, 29);
            rdbDni.TabIndex = 14;
            rdbDni.TabStop = true;
            rdbDni.Text = "DNI";
            rdbDni.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(229, 220);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 18;
            label7.Text = "Localidad";
            // 
            // cboLocalidad
            // 
            cboLocalidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Items.AddRange(new object[] { "25 de Mayo", "Catriló", "Ed. Castex", "General Acha", "General Pico", "Realicó", "Santa Rosa", "Telén", "Toay", "Victorica", "Winifreda" });
            cboLocalidad.Location = new Point(229, 249);
            cboLocalidad.Margin = new Padding(3, 4, 3, 4);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(281, 33);
            cboLocalidad.Sorted = true;
            cboLocalidad.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(10, 220);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 16;
            label6.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(393, 131);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 15;
            label5.Text = "Nro. Documento";
            // 
            // dtpFecNacimiento
            // 
            dtpFecNacimiento.Font = new Font("Segoe UI", 11.25F);
            dtpFecNacimiento.Format = DateTimePickerFormat.Short;
            dtpFecNacimiento.Location = new Point(10, 251);
            dtpFecNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFecNacimiento.Name = "dtpFecNacimiento";
            dtpFecNacimiento.Size = new Size(142, 32);
            dtpFecNacimiento.TabIndex = 19;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 11.25F);
            txtApellido.Location = new Point(278, 72);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(258, 32);
            txtApellido.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(278, 44);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 12;
            label4.Text = "Apellido";
            // 
            // frmForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 997);
            Controls.Add(groupBox3);
            Controls.Add(lstVacunacion);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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