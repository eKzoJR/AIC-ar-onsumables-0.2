namespace WindowsFormsApp1
{
    partial class salesInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salesInformationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exportButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.salesInformation = new System.Windows.Forms.DataGridView();
            this.Kod_Sellers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exportButton
            // 
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.exportButton.Location = new System.Drawing.Point(14, 308);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(149, 41);
            this.exportButton.TabIndex = 96;
            this.exportButton.Text = "Экспорт данных ";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(14, 356);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(149, 41);
            this.updateButton.TabIndex = 94;
            this.updateButton.Text = "Обновить данные";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(132)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(308, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 69;
            this.label3.Text = "Продажи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(132)))));
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(598, 2);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(30, 30);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 63;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // salesInformation
            // 
            this.salesInformation.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod_Sellers,
            this.SurnameColumns,
            this.NameColumns,
            this.PatronymicColumns,
            this.GroupColumns});
            this.salesInformation.EnableHeadersVisualStyles = false;
            this.salesInformation.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesInformation.Location = new System.Drawing.Point(179, 36);
            this.salesInformation.MultiSelect = false;
            this.salesInformation.Name = "salesInformation";
            this.salesInformation.ReadOnly = true;
            this.salesInformation.RowHeadersVisible = false;
            this.salesInformation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.salesInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesInformation.Size = new System.Drawing.Size(450, 566);
            this.salesInformation.TabIndex = 59;
            this.salesInformation.TabStop = false;
            // 
            // Kod_Sellers
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.Kod_Sellers.DefaultCellStyle = dataGridViewCellStyle6;
            this.Kod_Sellers.Frozen = true;
            this.Kod_Sellers.HeaderText = "Код продажи";
            this.Kod_Sellers.Name = "Kod_Sellers";
            this.Kod_Sellers.ReadOnly = true;
            this.Kod_Sellers.Width = 50;
            // 
            // SurnameColumns
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SurnameColumns.DefaultCellStyle = dataGridViewCellStyle7;
            this.SurnameColumns.Frozen = true;
            this.SurnameColumns.HeaderText = "Код продавца";
            this.SurnameColumns.Name = "SurnameColumns";
            this.SurnameColumns.ReadOnly = true;
            this.SurnameColumns.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SurnameColumns.Width = 120;
            // 
            // NameColumns
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NameColumns.DefaultCellStyle = dataGridViewCellStyle8;
            this.NameColumns.Frozen = true;
            this.NameColumns.HeaderText = "Код товара";
            this.NameColumns.Name = "NameColumns";
            this.NameColumns.ReadOnly = true;
            this.NameColumns.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameColumns.Width = 90;
            // 
            // PatronymicColumns
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatronymicColumns.DefaultCellStyle = dataGridViewCellStyle9;
            this.PatronymicColumns.Frozen = true;
            this.PatronymicColumns.HeaderText = "Дата продажи";
            this.PatronymicColumns.Name = "PatronymicColumns";
            this.PatronymicColumns.ReadOnly = true;
            this.PatronymicColumns.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PatronymicColumns.Width = 110;
            // 
            // GroupColumns
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupColumns.DefaultCellStyle = dataGridViewCellStyle10;
            this.GroupColumns.Frozen = true;
            this.GroupColumns.HeaderText = "Количество продаж";
            this.GroupColumns.Name = "GroupColumns";
            this.GroupColumns.ReadOnly = true;
            this.GroupColumns.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GroupColumns.Width = 75;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(132)))));
            this.pictureBox2.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(634, 37);
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.button1.Location = new System.Drawing.Point(25, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 38);
            this.button1.TabIndex = 97;
            this.button1.Text = "8 Запрос";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salesInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(121)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(629, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.salesInformation);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "salesInformationForm";
            this.Text = "salesInformationForm";
            this.Load += new System.EventHandler(this.salesInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.DataGridView salesInformation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod_Sellers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupColumns;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}