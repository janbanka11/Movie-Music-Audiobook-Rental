﻿namespace Rental
{
    partial class mainWin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.selectRented = new System.Windows.Forms.Button();
            this.selectBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selectAudiobook = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectMovie = new System.Windows.Forms.Button();
            this.selectMusic = new System.Windows.Forms.Button();
            this.selectSettings = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rentNow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentalDataSet = new Rental.RentalDataSet();
            this.mOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIETableAdapter = new Rental.RentalDataSetTableAdapters.MOVIETableAdapter();
            this.cDDISCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cD_DISCTableAdapter = new Rental.RentalDataSetTableAdapters.CD_DISCTableAdapter();
            this.aUDIOBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUDIOBOOKTableAdapter = new Rental.RentalDataSetTableAdapters.AUDIOBOOKTableAdapter();
            this.idmovieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtitleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDDISCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOBOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.selectRented);
            this.panel1.Controls.Add(this.selectBill);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.selectAudiobook);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.selectMovie);
            this.panel1.Controls.Add(this.selectMusic);
            this.panel1.Controls.Add(this.selectSettings);
            this.panel1.Controls.Add(this.helloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 532);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Rental.Properties.Resources.icons8_thick_vertical_line_50;
            this.pictureBox3.Location = new System.Drawing.Point(18, 395);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Rental.Properties.Resources.icons8_thick_vertical_line_50;
            this.pictureBox6.Location = new System.Drawing.Point(18, 358);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 51);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // selectRented
            // 
            this.selectRented.BackColor = System.Drawing.Color.Transparent;
            this.selectRented.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectRented.FlatAppearance.BorderSize = 0;
            this.selectRented.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectRented.Font = new System.Drawing.Font("Roboto", 15F);
            this.selectRented.ForeColor = System.Drawing.Color.White;
            this.selectRented.Location = new System.Drawing.Point(35, 368);
            this.selectRented.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectRented.Name = "selectRented";
            this.selectRented.Size = new System.Drawing.Size(109, 31);
            this.selectRented.TabIndex = 40;
            this.selectRented.Text = "Rented";
            this.selectRented.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectRented.UseVisualStyleBackColor = false;
            // 
            // selectBill
            // 
            this.selectBill.BackColor = System.Drawing.Color.Transparent;
            this.selectBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectBill.FlatAppearance.BorderSize = 0;
            this.selectBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBill.Font = new System.Drawing.Font("Roboto", 15F);
            this.selectBill.ForeColor = System.Drawing.Color.White;
            this.selectBill.Location = new System.Drawing.Point(35, 405);
            this.selectBill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectBill.Name = "selectBill";
            this.selectBill.Size = new System.Drawing.Size(109, 31);
            this.selectBill.TabIndex = 41;
            this.selectBill.Text = "Bill";
            this.selectBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectBill.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 33);
            this.label2.TabIndex = 39;
            this.label2.Text = "Account";
            // 
            // selectAudiobook
            // 
            this.selectAudiobook.BackColor = System.Drawing.Color.Transparent;
            this.selectAudiobook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectAudiobook.FlatAppearance.BorderSize = 0;
            this.selectAudiobook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAudiobook.Font = new System.Drawing.Font("Roboto", 15F);
            this.selectAudiobook.ForeColor = System.Drawing.Color.White;
            this.selectAudiobook.Location = new System.Drawing.Point(35, 248);
            this.selectAudiobook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectAudiobook.Name = "selectAudiobook";
            this.selectAudiobook.Size = new System.Drawing.Size(125, 31);
            this.selectAudiobook.TabIndex = 32;
            this.selectAudiobook.Text = "Audiobook";
            this.selectAudiobook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectAudiobook.UseVisualStyleBackColor = false;
            this.selectAudiobook.Click += new System.EventHandler(this.selectAudiobook_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Rental.Properties.Resources.icons8_thick_vertical_line_50;
            this.pictureBox5.Location = new System.Drawing.Point(18, 238);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Rental.Properties.Resources.icons8_thick_vertical_line_50;
            this.pictureBox4.Location = new System.Drawing.Point(18, 201);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rental.Properties.Resources.icons8_thick_vertical_line_50;
            this.pictureBox1.Location = new System.Drawing.Point(18, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose your";
            // 
            // selectMovie
            // 
            this.selectMovie.BackColor = System.Drawing.Color.Transparent;
            this.selectMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectMovie.FlatAppearance.BorderSize = 0;
            this.selectMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectMovie.Font = new System.Drawing.Font("Roboto", 15F);
            this.selectMovie.ForeColor = System.Drawing.Color.White;
            this.selectMovie.Location = new System.Drawing.Point(35, 174);
            this.selectMovie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectMovie.Name = "selectMovie";
            this.selectMovie.Size = new System.Drawing.Size(109, 31);
            this.selectMovie.TabIndex = 30;
            this.selectMovie.Text = "Movie";
            this.selectMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectMovie.UseVisualStyleBackColor = false;
            this.selectMovie.Click += new System.EventHandler(this.selectMovie_Click);
            // 
            // selectMusic
            // 
            this.selectMusic.BackColor = System.Drawing.Color.Transparent;
            this.selectMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectMusic.FlatAppearance.BorderSize = 0;
            this.selectMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectMusic.Font = new System.Drawing.Font("Roboto", 15F);
            this.selectMusic.ForeColor = System.Drawing.Color.White;
            this.selectMusic.Location = new System.Drawing.Point(35, 211);
            this.selectMusic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectMusic.Name = "selectMusic";
            this.selectMusic.Size = new System.Drawing.Size(109, 31);
            this.selectMusic.TabIndex = 31;
            this.selectMusic.Text = "Music";
            this.selectMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectMusic.UseVisualStyleBackColor = false;
            this.selectMusic.Click += new System.EventHandler(this.selectMusic_Click);
            // 
            // selectSettings
            // 
            this.selectSettings.BackColor = System.Drawing.Color.Transparent;
            this.selectSettings.BackgroundImage = global::Rental.Properties.Resources.icons8_settings_50;
            this.selectSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectSettings.FlatAppearance.BorderSize = 0;
            this.selectSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectSettings.Font = new System.Drawing.Font("Roboto", 17F);
            this.selectSettings.ForeColor = System.Drawing.Color.White;
            this.selectSettings.Location = new System.Drawing.Point(4, 500);
            this.selectSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectSettings.Name = "selectSettings";
            this.selectSettings.Size = new System.Drawing.Size(33, 29);
            this.selectSettings.TabIndex = 33;
            this.selectSettings.UseVisualStyleBackColor = false;
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Roboto", 20F);
            this.helloLabel.ForeColor = System.Drawing.Color.White;
            this.helloLabel.Location = new System.Drawing.Point(29, 36);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(0, 33);
            this.helloLabel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 100);
            this.panel2.TabIndex = 1;
            // 
            // rentNow
            // 
            this.rentNow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rentNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentNow.FlatAppearance.BorderSize = 0;
            this.rentNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentNow.Font = new System.Drawing.Font("Roboto", 18F);
            this.rentNow.ForeColor = System.Drawing.Color.White;
            this.rentNow.Location = new System.Drawing.Point(537, 482);
            this.rentNow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rentNow.Name = "rentNow";
            this.rentNow.Size = new System.Drawing.Size(154, 38);
            this.rentNow.TabIndex = 27;
            this.rentNow.Text = "Rent now";
            this.rentNow.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmovieDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.relasedateDataGridViewTextBoxColumn,
            this.subtitleDataGridViewCheckBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mOVIEBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(206, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(830, 370);
            this.dataGridView1.TabIndex = 28;
            // 
            // rentalDataSet
            // 
            this.rentalDataSet.DataSetName = "RentalDataSet";
            this.rentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVIEBindingSource
            // 
            this.mOVIEBindingSource.DataMember = "MOVIE";
            this.mOVIEBindingSource.DataSource = this.rentalDataSet;
            // 
            // mOVIETableAdapter
            // 
            this.mOVIETableAdapter.ClearBeforeFill = true;
            // 
            // cDDISCBindingSource
            // 
            this.cDDISCBindingSource.DataMember = "CD_DISC";
            this.cDDISCBindingSource.DataSource = this.rentalDataSet;
            // 
            // cD_DISCTableAdapter
            // 
            this.cD_DISCTableAdapter.ClearBeforeFill = true;
            // 
            // aUDIOBOOKBindingSource
            // 
            this.aUDIOBOOKBindingSource.DataMember = "AUDIOBOOK";
            this.aUDIOBOOKBindingSource.DataSource = this.rentalDataSet;
            // 
            // aUDIOBOOKTableAdapter
            // 
            this.aUDIOBOOKTableAdapter.ClearBeforeFill = true;
            // 
            // idmovieDataGridViewTextBoxColumn
            // 
            this.idmovieDataGridViewTextBoxColumn.DataPropertyName = "id_movie";
            this.idmovieDataGridViewTextBoxColumn.HeaderText = "id_movie";
            this.idmovieDataGridViewTextBoxColumn.Name = "idmovieDataGridViewTextBoxColumn";
            this.idmovieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmovieDataGridViewTextBoxColumn.Width = 97;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 68;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.Width = 73;
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            this.directorDataGridViewTextBoxColumn.ReadOnly = true;
            this.directorDataGridViewTextBoxColumn.Width = 87;
            // 
            // relasedateDataGridViewTextBoxColumn
            // 
            this.relasedateDataGridViewTextBoxColumn.DataPropertyName = "relase_date";
            this.relasedateDataGridViewTextBoxColumn.HeaderText = "relase_date";
            this.relasedateDataGridViewTextBoxColumn.Name = "relasedateDataGridViewTextBoxColumn";
            this.relasedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.relasedateDataGridViewTextBoxColumn.Width = 114;
            // 
            // subtitleDataGridViewCheckBoxColumn
            // 
            this.subtitleDataGridViewCheckBoxColumn.DataPropertyName = "subtitle";
            this.subtitleDataGridViewCheckBoxColumn.HeaderText = "subtitle";
            this.subtitleDataGridViewCheckBoxColumn.Name = "subtitleDataGridViewCheckBoxColumn";
            this.subtitleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.subtitleDataGridViewCheckBoxColumn.Width = 67;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 112;
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rentNow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainWin";
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.mainWin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDDISCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOBOOKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button selectAudiobook;
        private System.Windows.Forms.Button selectMusic;
        private System.Windows.Forms.Button selectMovie;
        private System.Windows.Forms.Button selectSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button selectRented;
        private System.Windows.Forms.Button selectBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rentNow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RentalDataSet rentalDataSet;
        private System.Windows.Forms.BindingSource mOVIEBindingSource;
        private RentalDataSetTableAdapters.MOVIETableAdapter mOVIETableAdapter;
        private System.Windows.Forms.BindingSource cDDISCBindingSource;
        private RentalDataSetTableAdapters.CD_DISCTableAdapter cD_DISCTableAdapter;
        private System.Windows.Forms.BindingSource aUDIOBOOKBindingSource;
        private RentalDataSetTableAdapters.AUDIOBOOKTableAdapter aUDIOBOOKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmovieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn subtitleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}