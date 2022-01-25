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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label16 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.XY,
            this.X2});
            this.Tabla.Location = new System.Drawing.Point(15, 169);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(440, 274);
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
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa X:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(102, 72);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(75, 20);
            this.txtX.TabIndex = 4;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(102, 105);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(75, 20);
            this.txtY.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(102, 135);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(207, 135);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingresa Y:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.lblInfo.Location = new System.Drawing.Point(22, 150);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label4.Location = new System.Drawing.Point(15, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "E=";
            // 
            // totalX
            // 
            this.totalX.AutoSize = true;
            this.totalX.BackColor = System.Drawing.Color.Transparent;
            this.totalX.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.totalX.Location = new System.Drawing.Point(65, 446);
            this.totalX.Name = "totalX";
            this.totalX.Size = new System.Drawing.Size(16, 17);
            this.totalX.TabIndex = 11;
            this.totalX.Text = "0";
            // 
            // totalY
            // 
            this.totalY.AutoSize = true;
            this.totalY.BackColor = System.Drawing.Color.Transparent;
            this.totalY.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.totalY.Location = new System.Drawing.Point(169, 446);
            this.totalY.Name = "totalY";
            this.totalY.Size = new System.Drawing.Size(16, 17);
            this.totalY.TabIndex = 12;
            this.totalY.Text = "0";
            // 
            // totalXY
            // 
            this.totalXY.AutoSize = true;
            this.totalXY.BackColor = System.Drawing.Color.Transparent;
            this.totalXY.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalXY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.totalXY.Location = new System.Drawing.Point(259, 446);
            this.totalXY.Name = "totalXY";
            this.totalXY.Size = new System.Drawing.Size(16, 17);
            this.totalXY.TabIndex = 13;
            this.totalXY.Text = "0";
            // 
            // totalX2
            // 
            this.totalX2.AutoSize = true;
            this.totalX2.BackColor = System.Drawing.Color.Transparent;
            this.totalX2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.totalX2.Location = new System.Drawing.Point(363, 446);
            this.totalX2.Name = "totalX2";
            this.totalX2.Size = new System.Drawing.Size(16, 17);
            this.totalX2.TabIndex = 14;
            this.totalX2.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(311, 135);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
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
            this.label5.Location = new System.Drawing.Point(74, -165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Numero de filas:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // TxtNF
            // 
            this.TxtNF.Location = new System.Drawing.Point(102, 40);
            this.TxtNF.Name = "TxtNF";
            this.TxtNF.Size = new System.Drawing.Size(75, 20);
            this.TxtNF.TabIndex = 17;
            this.TxtNF.TextChanged += new System.EventHandler(this.TxtNF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(475, 162);
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
            this.txtTotalxy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtTotalxy.Location = new System.Drawing.Point(513, 162);
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
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label6.Location = new System.Drawing.Point(544, 161);
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
            this.txtTotalx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtTotalx.Location = new System.Drawing.Point(575, 143);
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
            this.txtTotaly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtTotaly.Location = new System.Drawing.Point(610, 143);
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
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label7.Location = new System.Drawing.Point(576, 151);
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
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label8.Location = new System.Drawing.Point(513, 179);
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
            this.txtTotalx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtTotalx2.Location = new System.Drawing.Point(514, 225);
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
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label10.Location = new System.Drawing.Point(544, 223);
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
            this.txtTotalFila.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtTotalFila.Location = new System.Drawing.Point(592, 173);
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
            this.txtTotalxCopia1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtTotalxCopia1.Location = new System.Drawing.Point(592, 212);
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
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label9.Location = new System.Drawing.Point(576, 216);
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
            this.txtTotalFilaCopia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtTotalFilaCopia.Location = new System.Drawing.Point(592, 237);
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
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label11.Location = new System.Drawing.Point(711, 182);
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
            this.txtResultadoM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtResultadoM.Location = new System.Drawing.Point(734, 179);
            this.txtResultadoM.Name = "txtResultadoM";
            this.txtResultadoM.Size = new System.Drawing.Size(16, 17);
            this.txtResultadoM.TabIndex = 32;
            this.txtResultadoM.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label12.Location = new System.Drawing.Point(475, 307);
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
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label14.Location = new System.Drawing.Point(506, 304);
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
            this.txtfilab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtfilab.Location = new System.Drawing.Point(520, 322);
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
            this.txtyb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtyb.Location = new System.Drawing.Point(520, 302);
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
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label19.Location = new System.Drawing.Point(591, 304);
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
            this.txtxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtxb.Location = new System.Drawing.Point(608, 302);
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
            this.txtfilab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtfilab2.Location = new System.Drawing.Point(608, 322);
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
            this.txtRb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtRb.Location = new System.Drawing.Point(665, 307);
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
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label13.Location = new System.Drawing.Point(645, 307);
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
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label15.Location = new System.Drawing.Point(475, 368);
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
            this.TxtIgualar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.TxtIgualar.Location = new System.Drawing.Point(505, 368);
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
            this.TxtIgualar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.TxtIgualar2.Location = new System.Drawing.Point(475, 405);
            this.TxtIgualar2.Name = "TxtIgualar2";
            this.TxtIgualar2.Size = new System.Drawing.Size(16, 17);
            this.TxtIgualar2.TabIndex = 48;
            this.TxtIgualar2.Text = "0";
            // 
            // TxtPuntoE
            // 
            this.TxtPuntoE.AutoSize = true;
            this.TxtPuntoE.BackColor = System.Drawing.Color.Transparent;
            this.TxtPuntoE.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntoE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.TxtPuntoE.Location = new System.Drawing.Point(475, 440);
            this.TxtPuntoE.Name = "TxtPuntoE";
            this.TxtPuntoE.Size = new System.Drawing.Size(16, 17);
            this.TxtPuntoE.TabIndex = 49;
            this.TxtPuntoE.Text = "0";
            // 
            // grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(15, 539);
            this.grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Tabla";
            this.grafica.Series.Add(series1);
            this.grafica.Size = new System.Drawing.Size(742, 284);
            this.grafica.TabIndex = 50;
            this.grafica.Text = "chart1";
            this.grafica.Click += new System.EventHandler(this.Grafica_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label16.Location = new System.Drawing.Point(65, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "Ingresa numero de filas:";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(714, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 52;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(816, 637);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtyb);
            this.Controls.Add(this.txtxb);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.TxtPuntoE);
            this.Controls.Add(this.TxtIgualar2);
            this.Controls.Add(this.TxtIgualar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRb);
            this.Controls.Add(this.txtfilab2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtfilab);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtResultadoM);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalFilaCopia);
            this.Controls.Add(this.txtTotalxCopia1);
            this.Controls.Add(this.txtTotalFila);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotalx2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotaly);
            this.Controls.Add(this.txtTotalx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalxy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.totalX2);
            this.Controls.Add(this.totalXY);
            this.Controls.Add(this.totalY);
            this.Controls.Add(this.totalX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método Mínimos Cuadrados";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnInfo;
    }
}

