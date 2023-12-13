
namespace WindowsFormsApp1
{
    partial class informationRoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informationRoomsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            this.roomInformation = new System.Windows.Forms.DataGridView();
            this.Kod_Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBuyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceSaleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // backPictureBox
            // 
            this.backPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(132)))));
            this.backPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backPictureBox.Image")));
            this.backPictureBox.Location = new System.Drawing.Point(815, 1);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(33, 29);
            this.backPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backPictureBox.TabIndex = 0;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.backPictureBox_Click);
            // 
            // roomInformation
            // 
            this.roomInformation.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.roomInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod_Goods,
            this.nameProductColumn,
            this.UnitColumn,
            this.PriceBuyColumn,
            this.PriceSaleColumn});
            this.roomInformation.EnableHeadersVisualStyles = false;
            this.roomInformation.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roomInformation.Location = new System.Drawing.Point(166, 30);
            this.roomInformation.MultiSelect = false;
            this.roomInformation.Name = "roomInformation";
            this.roomInformation.ReadOnly = true;
            this.roomInformation.RowHeadersVisible = false;
            this.roomInformation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.roomInformation.Size = new System.Drawing.Size(460, 485);
            this.roomInformation.TabIndex = 1;
            this.roomInformation.TabStop = false;
            this.roomInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomInformation_CellContentClick);
            // 
            // Kod_Goods
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Kod_Goods.DefaultCellStyle = dataGridViewCellStyle1;
            this.Kod_Goods.HeaderText = "ID";
            this.Kod_Goods.Name = "Kod_Goods";
            this.Kod_Goods.ReadOnly = true;
            this.Kod_Goods.Width = 35;
            // 
            // nameProductColumn
            // 
            this.nameProductColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nameProductColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameProductColumn.HeaderText = "Название продукта";
            this.nameProductColumn.Name = "nameProductColumn";
            this.nameProductColumn.ReadOnly = true;
            this.nameProductColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameProductColumn.Width = 120;
            // 
            // UnitColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.UnitColumn.HeaderText = "Единица";
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.ReadOnly = true;
            this.UnitColumn.Width = 50;
            // 
            // PriceBuyColumn
            // 
            this.PriceBuyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceBuyColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.PriceBuyColumn.HeaderText = "Цена закупки";
            this.PriceBuyColumn.Name = "PriceBuyColumn";
            this.PriceBuyColumn.ReadOnly = true;
            // 
            // PriceSaleColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PriceSaleColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.PriceSaleColumn.HeaderText = "Цена продажи";
            this.PriceSaleColumn.Name = "PriceSaleColumn";
            this.PriceSaleColumn.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(132)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(851, 33);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(132)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(381, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Учёт товаров";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(690, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 26);
            this.textBox1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(687, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Название продукта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(687, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Единица";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.Location = new System.Drawing.Point(687, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Цена покупки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(673, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 22);
            this.label10.TabIndex = 48;
            this.label10.Text = "Добавление товаров";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(636, 45);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 47;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(645, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(644, 155);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(645, 204);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(788, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 60;
            this.label11.Text = "Очистка";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(796, 317);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(25, 25);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 59;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(792, 466);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(35, 35);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 58;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(792, 411);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 35);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 57;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(792, 359);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 35);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 56;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.updateButton.Location = new System.Drawing.Point(17, 457);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(133, 42);
            this.updateButton.TabIndex = 55;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.deleteButton.Location = new System.Drawing.Point(650, 464);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(133, 37);
            this.deleteButton.TabIndex = 54;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.addButton.Location = new System.Drawing.Point(650, 357);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(133, 37);
            this.addButton.TabIndex = 53;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(-120, 467);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 26);
            this.textBox4.TabIndex = 61;
            this.textBox4.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.saveButton.Location = new System.Drawing.Point(650, 411);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 37);
            this.saveButton.TabIndex = 64;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.exportButton.Location = new System.Drawing.Point(17, 407);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(133, 44);
            this.exportButton.TabIndex = 65;
            this.exportButton.Text = "Экспорт данных ";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(690, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 26);
            this.textBox3.TabIndex = 68;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox5.Location = new System.Drawing.Point(690, 264);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 26);
            this.textBox5.TabIndex = 71;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(645, 258);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 70;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(687, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "Цена продажи";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(132)))));
            this.pictureBox7.Location = new System.Drawing.Point(0, 387);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(169, 14);
            this.pictureBox7.TabIndex = 72;
            this.pictureBox7.TabStop = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxID.Location = new System.Drawing.Point(184, 475);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(137, 26);
            this.textBoxID.TabIndex = 73;
            this.textBoxID.Visible = false;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "шт",
            "литр"});
            this.comboBoxUnit.Location = new System.Drawing.Point(690, 160);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(121, 28);
            this.comboBoxUnit.TabIndex = 74;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.button1.Location = new System.Drawing.Point(19, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 38);
            this.button1.TabIndex = 75;
            this.button1.Text = "2 Запрос";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.button2.Location = new System.Drawing.Point(19, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 39);
            this.button2.TabIndex = 77;
            this.button2.Text = "7 Запрос";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.button3.Location = new System.Drawing.Point(19, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 39);
            this.button3.TabIndex = 78;
            this.button3.Text = "9 Запрос";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.button4.Location = new System.Drawing.Point(19, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 39);
            this.button4.TabIndex = 79;
            this.button4.Text = "10 Запрос";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.button5.Location = new System.Drawing.Point(19, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 39);
            this.button5.TabIndex = 80;
            this.button5.Text = "11 Запрос";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.button6.Location = new System.Drawing.Point(19, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 38);
            this.button6.TabIndex = 81;
            this.button6.Text = "4 Запрос";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTextBox.Location = new System.Drawing.Point(19, 136);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(133, 26);
            this.searchTextBox.TabIndex = 82;
            // 
            // informationRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(851, 515);
            this.ControlBox = false;
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomInformation);
            this.Controls.Add(this.backPictureBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "informationRoomsForm";
            this.Text = "Информация о комнате";
            this.Load += new System.EventHandler(this.informationRoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backPictureBox;
        private System.Windows.Forms.DataGridView roomInformation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod_Goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBuyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceSaleColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}