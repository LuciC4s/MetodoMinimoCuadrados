namespace MetodoMinimoCuadrados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalX = new System.Windows.Forms.Label();
            this.totalY = new System.Windows.Forms.Label();
            this.totalXY = new System.Windows.Forms.Label();
            this.totalX2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalxy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalx = new System.Windows.Forms.Label();
            this.txtTotaly = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalx2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalFila = new System.Windows.Forms.Label();
            this.txtTotalxCopia1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalFilaCopia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResultadoM = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtfilab = new System.Windows.Forms.Label();
            this.txtyb = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtxb = new System.Windows.Forms.Label();
            this.txtfilab2 = new System.Windows.Forms.Label();
            this.txtRb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtIgualar = new System.Windows.Forms.Label();
            this.TxtIgualar2 = new System.Windows.Forms.Label();
            this.TxtPuntoE = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.XY,
            this.X2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabla.DefaultCellStyle = dataGridViewCellStyle8;
            this.Tabla.Location = new System.Drawing.Point(351, 39);
            this.Tabla.Margin = new System.Windows.Forms.Padding(4);
            this.Tabla.Name = "Tabla";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Tabla.Size = new System.Drawing.Size(453, 234);
            this.Tabla.TabIndex = 1;
            this.Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellClick);
            this.Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // XY
            // 
            this.XY.HeaderText = "XY";
            this.XY.Name = "XY";
            // 
            // X2
            // 
            this.X2.HeaderText = "X^2";
            this.X2.Name = "X2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa X:";
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(150, 102);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(150, 26);
            this.txtX.TabIndex = 4;
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(150, 140);
            this.txtY.Margin = new System.Windows.Forms.Padding(4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(150, 26);
            this.txtY.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(23, 190);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 34);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(167, 190);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(134, 34);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingresa Y:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.lblInfo.Location = new System.Drawing.Point(21, 148);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(347, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "E=";
            // 
            // totalX
            // 
            this.totalX.AutoSize = true;
            this.totalX.BackColor = System.Drawing.Color.Transparent;
            this.totalX.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalX.ForeColor = System.Drawing.Color.Black;
            this.totalX.Location = new System.Drawing.Point(391, 293);
            this.totalX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalX.Name = "totalX";
            this.totalX.Size = new System.Drawing.Size(17, 20);
            this.totalX.TabIndex = 11;
            this.totalX.Text = "0";
            // 
            // totalY
            // 
            this.totalY.AutoSize = true;
            this.totalY.BackColor = System.Drawing.Color.Transparent;
            this.totalY.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalY.ForeColor = System.Drawing.Color.Black;
            this.totalY.Location = new System.Drawing.Point(478, 293);
            this.totalY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalY.Name = "totalY";
            this.totalY.Size = new System.Drawing.Size(17, 20);
            this.totalY.TabIndex = 12;
            this.totalY.Text = "0";
            this.totalY.Click += new System.EventHandler(this.totalY_Click);
            // 
            // totalXY
            // 
            this.totalXY.AutoSize = true;
            this.totalXY.BackColor = System.Drawing.Color.Transparent;
            this.totalXY.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalXY.ForeColor = System.Drawing.Color.Black;
            this.totalXY.Location = new System.Drawing.Point(578, 293);
            this.totalXY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalXY.Name = "totalXY";
            this.totalXY.Size = new System.Drawing.Size(17, 20);
            this.totalXY.TabIndex = 13;
            this.totalXY.Text = "0";
            // 
            // totalX2
            // 
            this.totalX2.AutoSize = true;
            this.totalX2.BackColor = System.Drawing.Color.Transparent;
            this.totalX2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalX2.ForeColor = System.Drawing.Color.Black;
            this.totalX2.Location = new System.Drawing.Point(670, 293);
            this.totalX2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalX2.Name = "totalX2";
            this.totalX2.Size = new System.Drawing.Size(17, 20);
            this.totalX2.TabIndex = 14;
            this.totalX2.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(23, 240);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 34);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label5.Location = new System.Drawing.Point(69, -162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Numero de filas:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // TxtNF
            // 
            this.TxtNF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNF.Location = new System.Drawing.Point(150, 62);
            this.TxtNF.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNF.Name = "TxtNF";
            this.TxtNF.Size = new System.Drawing.Size(150, 26);
            this.TxtNF.TabIndex = 17;
            this.TxtNF.TextChanged += new System.EventHandler(this.TxtNF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "m=";
            // 
            // txtTotalxy
            // 
            this.txtTotalxy.AutoSize = true;
            this.txtTotalxy.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalxy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalxy.ForeColor = System.Drawing.Color.Black;
            this.txtTotalxy.Location = new System.Drawing.Point(74, 44);
            this.txtTotalxy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotalxy.Name = "txtTotalxy";
            this.txtTotalxy.Size = new System.Drawing.Size(16, 17);
            this.txtTotalxy.TabIndex = 19;
            this.txtTotalxy.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(102, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "-";
            // 
            // txtTotalx
            // 
            this.txtTotalx.AutoSize = true;
            this.txtTotalx.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalx.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalx.ForeColor = System.Drawing.Color.Black;
            this.txtTotalx.Location = new System.Drawing.Point(133, 17);
            this.txtTotalx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotalx.Name = "txtTotalx";
            this.txtTotalx.Size = new System.Drawing.Size(16, 17);
            this.txtTotalx.TabIndex = 21;
            this.txtTotalx.Text = "0";
            // 
            // txtTotaly
            // 
            this.txtTotaly.AutoSize = true;
            this.txtTotaly.BackColor = System.Drawing.Color.Transparent;
            this.txtTotaly.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotaly.ForeColor = System.Drawing.Color.Black;
            this.txtTotaly.Location = new System.Drawing.Point(162, 17);
            this.txtTotaly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotaly.Name = "txtTotaly";
            this.txtTotaly.Size = new System.Drawing.Size(16, 17);
            this.txtTotaly.TabIndex = 22;
            this.txtTotaly.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(133, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "_____";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(74, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "_______________________";
            // 
            // txtTotalx2
            // 
            this.txtTotalx2.AutoSize = true;
            this.txtTotalx2.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalx2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalx2.ForeColor = System.Drawing.Color.Black;
            this.txtTotalx2.Location = new System.Drawing.Point(74, 106);
            this.txtTotalx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotalx2.Name = "txtTotalx2";
            this.txtTotalx2.Size = new System.Drawing.Size(16, 17);
            this.txtTotalx2.TabIndex = 25;
            this.txtTotalx2.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(102, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "-";
            // 
            // txtTotalFila
            // 
            this.txtTotalFila.AutoSize = true;
            this.txtTotalFila.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalFila.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFila.ForeColor = System.Drawing.Color.Black;
            this.txtTotalFila.Location = new System.Drawing.Point(147, 55);
            this.txtTotalFila.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotalFila.Name = "txtTotalFila";
            this.txtTotalFila.Size = new System.Drawing.Size(16, 17);
            this.txtTotalFila.TabIndex = 27;
            this.txtTotalFila.Text = "0";
            // 
            // txtTotalxCopia1
            // 
            this.txtTotalxCopia1.AutoSize = true;
            this.txtTotalxCopia1.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalxCopia1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalxCopia1.ForeColor = System.Drawing.Color.Black;
            this.txtTotalxCopia1.Location = new System.Drawing.Point(147, 81);
            this.txtTotalxCopia1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotalxCopia1.Name = "txtTotalxCopia1";
            this.txtTotalxCopia1.Size = new System.Drawing.Size(16, 17);
            this.txtTotalxCopia1.TabIndex = 28;
            this.txtTotalxCopia1.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(133, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "_____";
            // 
            // txtTotalFilaCopia
            // 
            this.txtTotalFilaCopia.AutoSize = true;
            this.txtTotalFilaCopia.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalFilaCopia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFilaCopia.ForeColor = System.Drawing.Color.Black;
            this.txtTotalFilaCopia.Location = new System.Drawing.Point(147, 118);
            this.txtTotalFilaCopia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotalFilaCopia.Name = "txtTotalFilaCopia";
            this.txtTotalFilaCopia.Size = new System.Drawing.Size(16, 17);
            this.txtTotalFilaCopia.TabIndex = 30;
            this.txtTotalFilaCopia.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(258, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "=";
            // 
            // txtResultadoM
            // 
            this.txtResultadoM.AutoSize = true;
            this.txtResultadoM.BackColor = System.Drawing.Color.Transparent;
            this.txtResultadoM.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoM.ForeColor = System.Drawing.Color.Black;
            this.txtResultadoM.Location = new System.Drawing.Point(280, 64);
            this.txtResultadoM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtResultadoM.Name = "txtResultadoM";
            this.txtResultadoM.Size = new System.Drawing.Size(16, 17);
            this.txtResultadoM.TabIndex = 32;
            this.txtResultadoM.Text = "0";
            this.txtResultadoM.Click += new System.EventHandler(this.txtResultadoM_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(22, 175);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "b=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(72, 172);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "_____";
            // 
            // txtfilab
            // 
            this.txtfilab.AutoSize = true;
            this.txtfilab.BackColor = System.Drawing.Color.Transparent;
            this.txtfilab.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilab.ForeColor = System.Drawing.Color.Black;
            this.txtfilab.Location = new System.Drawing.Point(85, 190);
            this.txtfilab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtfilab.Name = "txtfilab";
            this.txtfilab.Size = new System.Drawing.Size(16, 17);
            this.txtfilab.TabIndex = 36;
            this.txtfilab.Text = "0";
            // 
            // txtyb
            // 
            this.txtyb.AutoSize = true;
            this.txtyb.BackColor = System.Drawing.Color.Transparent;
            this.txtyb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyb.ForeColor = System.Drawing.Color.Black;
            this.txtyb.Location = new System.Drawing.Point(85, 170);
            this.txtyb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtyb.Name = "txtyb";
            this.txtyb.Size = new System.Drawing.Size(16, 17);
            this.txtyb.TabIndex = 38;
            this.txtyb.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(151, 172);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = "_____";
            // 
            // txtxb
            // 
            this.txtxb.AutoSize = true;
            this.txtxb.BackColor = System.Drawing.Color.Transparent;
            this.txtxb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxb.ForeColor = System.Drawing.Color.Black;
            this.txtxb.Location = new System.Drawing.Point(167, 170);
            this.txtxb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtxb.Name = "txtxb";
            this.txtxb.Size = new System.Drawing.Size(16, 17);
            this.txtxb.TabIndex = 42;
            this.txtxb.Text = "0";
            // 
            // txtfilab2
            // 
            this.txtfilab2.AutoSize = true;
            this.txtfilab2.BackColor = System.Drawing.Color.Transparent;
            this.txtfilab2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilab2.ForeColor = System.Drawing.Color.Black;
            this.txtfilab2.Location = new System.Drawing.Point(167, 190);
            this.txtfilab2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtfilab2.Name = "txtfilab2";
            this.txtfilab2.Size = new System.Drawing.Size(16, 17);
            this.txtfilab2.TabIndex = 43;
            this.txtfilab2.Text = "0";
            // 
            // txtRb
            // 
            this.txtRb.AutoSize = true;
            this.txtRb.BackColor = System.Drawing.Color.Transparent;
            this.txtRb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRb.ForeColor = System.Drawing.Color.Black;
            this.txtRb.Location = new System.Drawing.Point(220, 175);
            this.txtRb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRb.Name = "txtRb";
            this.txtRb.Size = new System.Drawing.Size(16, 17);
            this.txtRb.TabIndex = 44;
            this.txtRb.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(202, 175);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(61, 274);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 17);
            this.label15.TabIndex = 46;
            this.label15.Text = "y=";
            // 
            // TxtIgualar
            // 
            this.TxtIgualar.AutoSize = true;
            this.TxtIgualar.BackColor = System.Drawing.Color.Transparent;
            this.TxtIgualar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIgualar.ForeColor = System.Drawing.Color.Black;
            this.TxtIgualar.Location = new System.Drawing.Point(89, 274);
            this.TxtIgualar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtIgualar.Name = "TxtIgualar";
            this.TxtIgualar.Size = new System.Drawing.Size(16, 17);
            this.TxtIgualar.TabIndex = 47;
            this.TxtIgualar.Text = "0";
            // 
            // TxtIgualar2
            // 
            this.TxtIgualar2.AutoSize = true;
            this.TxtIgualar2.BackColor = System.Drawing.Color.Transparent;
            this.TxtIgualar2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIgualar2.ForeColor = System.Drawing.Color.Black;
            this.TxtIgualar2.Location = new System.Drawing.Point(61, 311);
            this.TxtIgualar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtIgualar2.Name = "TxtIgualar2";
            this.TxtIgualar2.Size = new System.Drawing.Size(16, 17);
            this.TxtIgualar2.TabIndex = 48;
            this.TxtIgualar2.Text = "0";
            // 
            // TxtPuntoE
            // 
            this.TxtPuntoE.AutoSize = true;
            this.TxtPuntoE.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtPuntoE.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntoE.ForeColor = System.Drawing.Color.PowderBlue;
            this.TxtPuntoE.Location = new System.Drawing.Point(777, 293);
            this.TxtPuntoE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtPuntoE.Name = "TxtPuntoE";
            this.TxtPuntoE.Size = new System.Drawing.Size(17, 20);
            this.TxtPuntoE.TabIndex = 49;
            this.TxtPuntoE.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(18, 68);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 20);
            this.label16.TabIndex = 51;
            this.label16.Text = "Número de filas:";
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(98, 282);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(134, 34);
            this.btnInfo.TabIndex = 52;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 342);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 356);
            this.tabControl1.TabIndex = 53;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.grafica);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(771, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gráfica";
            // 
            // grafica
            // 
            this.grafica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafica.Legends.Add(legend3);
            this.grafica.Location = new System.Drawing.Point(35, 35);
            this.grafica.Margin = new System.Windows.Forms.Padding(4);
            this.grafica.Name = "grafica";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Tabla";
            this.grafica.Series.Add(series3);
            this.grafica.Size = new System.Drawing.Size(705, 280);
            this.grafica.TabIndex = 51;
            this.grafica.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.txtTotalFila);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtyb);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtxb);
            this.tabPage2.Controls.Add(this.txtTotalxy);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.TxtIgualar2);
            this.tabPage2.Controls.Add(this.txtTotalx);
            this.tabPage2.Controls.Add(this.TxtIgualar);
            this.tabPage2.Controls.Add(this.txtTotaly);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtTotalx2);
            this.tabPage2.Controls.Add(this.txtRb);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtfilab2);
            this.tabPage2.Controls.Add(this.txtTotalxCopia1);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txtTotalFilaCopia);
            this.tabPage2.Controls.Add(this.txtfilab);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtResultadoM);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(771, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Formula";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.Tabla);
            this.panel1.Controls.Add(this.TxtPuntoE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.totalX2);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.totalXY);
            this.panel1.Controls.Add(this.txtX);
            this.panel1.Controls.Add(this.totalY);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.totalX);
            this.panel1.Controls.Add(this.txtY);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtNF);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 331);
            this.panel1.TabIndex = 54;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(167, 239);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(134, 34);
            this.btnLimpiar.TabIndex = 53;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mínimos Cuadrados";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn XY;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalX;
        private System.Windows.Forms.Label totalY;
        private System.Windows.Forms.Label totalXY;
        private System.Windows.Forms.Label totalX2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTotalxy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTotalx;
        private System.Windows.Forms.Label txtTotaly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtTotalx2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtTotalFila;
        private System.Windows.Forms.Label txtTotalxCopia1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtTotalFilaCopia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtResultadoM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtfilab;
        private System.Windows.Forms.Label txtyb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label txtxb;
        private System.Windows.Forms.Label txtfilab2;
        private System.Windows.Forms.Label txtRb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label TxtIgualar;
        private System.Windows.Forms.Label TxtIgualar2;
        private System.Windows.Forms.Label TxtPuntoE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

