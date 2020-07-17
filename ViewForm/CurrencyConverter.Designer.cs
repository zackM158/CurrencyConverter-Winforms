namespace ViewForm
{
    partial class CurrencyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyConverter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ChartButton = new System.Windows.Forms.Button();
            this.MinMaxButton = new System.Windows.Forms.Button();
            this.AverageButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseAppButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.originalCurrencyCode = new System.Windows.Forms.TextBox();
            this.finalCurrencyCode = new System.Windows.Forms.TextBox();
            this.CurrenciesButton = new System.Windows.Forms.Button();
            this.OutputMessage = new System.Windows.Forms.TextBox();
            this.NumberOfDaysPanel = new System.Windows.Forms.Panel();
            this.numberOfDays = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.AmountPanel = new System.Windows.Forms.Panel();
            this.Amount = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ConvertNowButton = new System.Windows.Forms.Button();
            this.AverageNowButton = new System.Windows.Forms.Button();
            this.MinMaxNowButton = new System.Windows.Forms.Button();
            this.BarChartButton = new System.Windows.Forms.Button();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.SlineChartButton = new System.Windows.Forms.Button();
            this.LineChartButton = new System.Windows.Forms.Button();
            this.SwapButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.NumberOfDaysPanel.SuspendLayout();
            this.AmountPanel.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.MinMaxButton);
            this.panel1.Controls.Add(this.AverageButton);
            this.panel1.Controls.Add(this.ConvertButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 649);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 83);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 55);
            this.SidePanel.TabIndex = 4;
            // 
            // ChartButton
            // 
            this.ChartButton.FlatAppearance.BorderSize = 0;
            this.ChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChartButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartButton.ForeColor = System.Drawing.Color.White;
            this.ChartButton.Image = ((System.Drawing.Image)(resources.GetObject("ChartButton.Image")));
            this.ChartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChartButton.Location = new System.Drawing.Point(23, 386);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(233, 54);
            this.ChartButton.TabIndex = 6;
            this.ChartButton.TabStop = false;
            this.ChartButton.Text = "Chart";
            this.ChartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // MinMaxButton
            // 
            this.MinMaxButton.FlatAppearance.BorderSize = 0;
            this.MinMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinMaxButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinMaxButton.ForeColor = System.Drawing.Color.White;
            this.MinMaxButton.Image = ((System.Drawing.Image)(resources.GetObject("MinMaxButton.Image")));
            this.MinMaxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinMaxButton.Location = new System.Drawing.Point(23, 285);
            this.MinMaxButton.Name = "MinMaxButton";
            this.MinMaxButton.Size = new System.Drawing.Size(233, 54);
            this.MinMaxButton.TabIndex = 5;
            this.MinMaxButton.TabStop = false;
            this.MinMaxButton.Text = "Min/Max";
            this.MinMaxButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MinMaxButton.UseVisualStyleBackColor = true;
            this.MinMaxButton.Click += new System.EventHandler(this.MinMaxButton_Click);
            // 
            // AverageButton
            // 
            this.AverageButton.FlatAppearance.BorderSize = 0;
            this.AverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AverageButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageButton.ForeColor = System.Drawing.Color.White;
            this.AverageButton.Image = ((System.Drawing.Image)(resources.GetObject("AverageButton.Image")));
            this.AverageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AverageButton.Location = new System.Drawing.Point(23, 184);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Size = new System.Drawing.Size(233, 54);
            this.AverageButton.TabIndex = 4;
            this.AverageButton.TabStop = false;
            this.AverageButton.Text = "Average";
            this.AverageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AverageButton.UseVisualStyleBackColor = true;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.FlatAppearance.BorderSize = 0;
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.ForeColor = System.Drawing.Color.White;
            this.ConvertButton.Image = ((System.Drawing.Image)(resources.GetObject("ConvertButton.Image")));
            this.ConvertButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConvertButton.Location = new System.Drawing.Point(23, 83);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(236, 54);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.TabStop = false;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 20);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(331, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 194);
            this.panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(3, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(166, 54);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Bare Change\r\n2.0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.FlatAppearance.BorderSize = 0;
            this.CloseAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseAppButton.Image")));
            this.CloseAppButton.Location = new System.Drawing.Point(1130, 26);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(47, 46);
            this.CloseAppButton.TabIndex = 0;
            this.CloseAppButton.TabStop = false;
            this.CloseAppButton.UseVisualStyleBackColor = true;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.textBox2.Location = new System.Drawing.Point(556, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(302, 41);
            this.textBox2.TabIndex = 0;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Original Currency:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.textBox3.Location = new System.Drawing.Point(556, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(302, 41);
            this.textBox3.TabIndex = 0;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Final Currency:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // originalCurrencyCode
            // 
            this.originalCurrencyCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.originalCurrencyCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.originalCurrencyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.originalCurrencyCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.originalCurrencyCode.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.originalCurrencyCode.ForeColor = System.Drawing.SystemColors.Window;
            this.originalCurrencyCode.Location = new System.Drawing.Point(864, 132);
            this.originalCurrencyCode.MaxLength = 3;
            this.originalCurrencyCode.Name = "originalCurrencyCode";
            this.originalCurrencyCode.Size = new System.Drawing.Size(186, 41);
            this.originalCurrencyCode.TabIndex = 0;
            // 
            // finalCurrencyCode
            // 
            this.finalCurrencyCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.finalCurrencyCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finalCurrencyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.finalCurrencyCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.finalCurrencyCode.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.finalCurrencyCode.ForeColor = System.Drawing.SystemColors.Window;
            this.finalCurrencyCode.Location = new System.Drawing.Point(864, 196);
            this.finalCurrencyCode.MaxLength = 3;
            this.finalCurrencyCode.Name = "finalCurrencyCode";
            this.finalCurrencyCode.Size = new System.Drawing.Size(186, 41);
            this.finalCurrencyCode.TabIndex = 1;
            // 
            // CurrenciesButton
            // 
            this.CurrenciesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.CurrenciesButton.FlatAppearance.BorderSize = 0;
            this.CurrenciesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrenciesButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrenciesButton.ForeColor = System.Drawing.Color.White;
            this.CurrenciesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrenciesButton.Location = new System.Drawing.Point(669, 44);
            this.CurrenciesButton.Name = "CurrenciesButton";
            this.CurrenciesButton.Size = new System.Drawing.Size(289, 54);
            this.CurrenciesButton.TabIndex = 0;
            this.CurrenciesButton.TabStop = false;
            this.CurrenciesButton.Text = "Currency Codes";
            this.CurrenciesButton.UseVisualStyleBackColor = false;
            this.CurrenciesButton.Click += new System.EventHandler(this.CurrenciesButton_Click);
            // 
            // OutputMessage
            // 
            this.OutputMessage.BackColor = System.Drawing.SystemColors.Control;
            this.OutputMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputMessage.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.OutputMessage.Location = new System.Drawing.Point(331, 410);
            this.OutputMessage.Multiline = true;
            this.OutputMessage.Name = "OutputMessage";
            this.OutputMessage.ReadOnly = true;
            this.OutputMessage.Size = new System.Drawing.Size(812, 227);
            this.OutputMessage.TabIndex = 0;
            this.OutputMessage.TabStop = false;
            this.OutputMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberOfDaysPanel
            // 
            this.NumberOfDaysPanel.Controls.Add(this.numberOfDays);
            this.NumberOfDaysPanel.Controls.Add(this.textBox5);
            this.NumberOfDaysPanel.Location = new System.Drawing.Point(556, 259);
            this.NumberOfDaysPanel.Name = "NumberOfDaysPanel";
            this.NumberOfDaysPanel.Size = new System.Drawing.Size(507, 51);
            this.NumberOfDaysPanel.TabIndex = 0;
            this.NumberOfDaysPanel.Visible = false;
            // 
            // numberOfDays
            // 
            this.numberOfDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.numberOfDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberOfDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberOfDays.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.numberOfDays.ForeColor = System.Drawing.SystemColors.Window;
            this.numberOfDays.Location = new System.Drawing.Point(308, 3);
            this.numberOfDays.Name = "numberOfDays";
            this.numberOfDays.Size = new System.Drawing.Size(186, 41);
            this.numberOfDays.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.textBox5.Location = new System.Drawing.Point(0, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(302, 41);
            this.textBox5.TabIndex = 0;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Number Of Days:";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AmountPanel
            // 
            this.AmountPanel.Controls.Add(this.Amount);
            this.AmountPanel.Controls.Add(this.textBox6);
            this.AmountPanel.Location = new System.Drawing.Point(556, 260);
            this.AmountPanel.Name = "AmountPanel";
            this.AmountPanel.Size = new System.Drawing.Size(507, 51);
            this.AmountPanel.TabIndex = 0;
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Amount.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.Amount.ForeColor = System.Drawing.SystemColors.Window;
            this.Amount.Location = new System.Drawing.Point(308, 3);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(186, 41);
            this.Amount.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.textBox6.Location = new System.Drawing.Point(0, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(302, 41);
            this.textBox6.TabIndex = 0;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Amount:";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ConvertNowButton
            // 
            this.ConvertNowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ConvertNowButton.FlatAppearance.BorderSize = 0;
            this.ConvertNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertNowButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertNowButton.ForeColor = System.Drawing.Color.White;
            this.ConvertNowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConvertNowButton.Location = new System.Drawing.Point(669, 337);
            this.ConvertNowButton.Name = "ConvertNowButton";
            this.ConvertNowButton.Size = new System.Drawing.Size(289, 54);
            this.ConvertNowButton.TabIndex = 0;
            this.ConvertNowButton.TabStop = false;
            this.ConvertNowButton.Text = "Convert";
            this.ConvertNowButton.UseVisualStyleBackColor = false;
            this.ConvertNowButton.Click += new System.EventHandler(this.ConvertNowButton_Click);
            // 
            // AverageNowButton
            // 
            this.AverageNowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AverageNowButton.FlatAppearance.BorderSize = 0;
            this.AverageNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AverageNowButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageNowButton.ForeColor = System.Drawing.Color.White;
            this.AverageNowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AverageNowButton.Location = new System.Drawing.Point(669, 337);
            this.AverageNowButton.Name = "AverageNowButton";
            this.AverageNowButton.Size = new System.Drawing.Size(289, 54);
            this.AverageNowButton.TabIndex = 0;
            this.AverageNowButton.TabStop = false;
            this.AverageNowButton.Text = "Average";
            this.AverageNowButton.UseVisualStyleBackColor = false;
            this.AverageNowButton.Visible = false;
            this.AverageNowButton.Click += new System.EventHandler(this.AverageNowButton_Click);
            // 
            // MinMaxNowButton
            // 
            this.MinMaxNowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.MinMaxNowButton.FlatAppearance.BorderSize = 0;
            this.MinMaxNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinMaxNowButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinMaxNowButton.ForeColor = System.Drawing.Color.White;
            this.MinMaxNowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinMaxNowButton.Location = new System.Drawing.Point(669, 337);
            this.MinMaxNowButton.Name = "MinMaxNowButton";
            this.MinMaxNowButton.Size = new System.Drawing.Size(289, 54);
            this.MinMaxNowButton.TabIndex = 0;
            this.MinMaxNowButton.TabStop = false;
            this.MinMaxNowButton.Text = "Min/Max";
            this.MinMaxNowButton.UseVisualStyleBackColor = false;
            this.MinMaxNowButton.Visible = false;
            this.MinMaxNowButton.Click += new System.EventHandler(this.MinMaxNowButton_Click);
            // 
            // BarChartButton
            // 
            this.BarChartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BarChartButton.FlatAppearance.BorderSize = 0;
            this.BarChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarChartButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarChartButton.ForeColor = System.Drawing.Color.White;
            this.BarChartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BarChartButton.Location = new System.Drawing.Point(66, 13);
            this.BarChartButton.Name = "BarChartButton";
            this.BarChartButton.Size = new System.Drawing.Size(204, 54);
            this.BarChartButton.TabIndex = 0;
            this.BarChartButton.TabStop = false;
            this.BarChartButton.Text = "Bar Chart";
            this.BarChartButton.UseVisualStyleBackColor = false;
            this.BarChartButton.Click += new System.EventHandler(this.ChartNowButton_Click);
            // 
            // ChartPanel
            // 
            this.ChartPanel.Controls.Add(this.SlineChartButton);
            this.ChartPanel.Controls.Add(this.LineChartButton);
            this.ChartPanel.Controls.Add(this.BarChartButton);
            this.ChartPanel.Location = new System.Drawing.Point(278, 323);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(878, 81);
            this.ChartPanel.TabIndex = 3;
            this.ChartPanel.Visible = false;
            // 
            // SlineChartButton
            // 
            this.SlineChartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SlineChartButton.FlatAppearance.BorderSize = 0;
            this.SlineChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlineChartButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlineChartButton.ForeColor = System.Drawing.Color.White;
            this.SlineChartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlineChartButton.Location = new System.Drawing.Point(644, 13);
            this.SlineChartButton.Name = "SlineChartButton";
            this.SlineChartButton.Size = new System.Drawing.Size(204, 54);
            this.SlineChartButton.TabIndex = 2;
            this.SlineChartButton.TabStop = false;
            this.SlineChartButton.Text = "Sline Chart";
            this.SlineChartButton.UseVisualStyleBackColor = false;
            this.SlineChartButton.Click += new System.EventHandler(this.SlineChartButton_Click);
            // 
            // LineChartButton
            // 
            this.LineChartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.LineChartButton.FlatAppearance.BorderSize = 0;
            this.LineChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineChartButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineChartButton.ForeColor = System.Drawing.Color.White;
            this.LineChartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LineChartButton.Location = new System.Drawing.Point(355, 13);
            this.LineChartButton.Name = "LineChartButton";
            this.LineChartButton.Size = new System.Drawing.Size(204, 54);
            this.LineChartButton.TabIndex = 1;
            this.LineChartButton.TabStop = false;
            this.LineChartButton.Text = "Line Chart";
            this.LineChartButton.UseVisualStyleBackColor = false;
            this.LineChartButton.Click += new System.EventHandler(this.LineChartButton_Click);
            // 
            // SwapButton
            // 
            this.SwapButton.BackColor = System.Drawing.SystemColors.Control;
            this.SwapButton.FlatAppearance.BorderSize = 0;
            this.SwapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwapButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapButton.ForeColor = System.Drawing.Color.White;
            this.SwapButton.Image = ((System.Drawing.Image)(resources.GetObject("SwapButton.Image")));
            this.SwapButton.Location = new System.Drawing.Point(1088, 153);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(68, 69);
            this.SwapButton.TabIndex = 0;
            this.SwapButton.TabStop = false;
            this.SwapButton.UseVisualStyleBackColor = false;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 649);
            this.Controls.Add(this.SwapButton);
            this.Controls.Add(this.AmountPanel);
            this.Controls.Add(this.MinMaxNowButton);
            this.Controls.Add(this.AverageNowButton);
            this.Controls.Add(this.ConvertNowButton);
            this.Controls.Add(this.NumberOfDaysPanel);
            this.Controls.Add(this.OutputMessage);
            this.Controls.Add(this.CurrenciesButton);
            this.Controls.Add(this.finalCurrencyCode);
            this.Controls.Add(this.originalCurrencyCode);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CloseAppButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChartPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurrencyConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bare Change Currency Converter";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.NumberOfDaysPanel.ResumeLayout(false);
            this.NumberOfDaysPanel.PerformLayout();
            this.AmountPanel.ResumeLayout(false);
            this.AmountPanel.PerformLayout();
            this.ChartPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button MinMaxButton;
        private System.Windows.Forms.Button ChartButton;
        private System.Windows.Forms.Button CloseAppButton;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox originalCurrencyCode;
        private System.Windows.Forms.TextBox finalCurrencyCode;
        private System.Windows.Forms.Button CurrenciesButton;
        private System.Windows.Forms.TextBox OutputMessage;
        private System.Windows.Forms.Panel NumberOfDaysPanel;
        private System.Windows.Forms.TextBox numberOfDays;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button ConvertNowButton;
        private System.Windows.Forms.Button AverageNowButton;
        private System.Windows.Forms.Button MinMaxNowButton;
        private System.Windows.Forms.Button BarChartButton;
        private System.Windows.Forms.Panel AmountPanel;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.Button SlineChartButton;
        private System.Windows.Forms.Button LineChartButton;
        private System.Windows.Forms.Button SwapButton;
    }
}

