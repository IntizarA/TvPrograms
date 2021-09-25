
namespace TvPrograms
{
    partial class ShowAllTabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllTabs));
            this.HostProgram = new System.Windows.Forms.TabPage();
            this.btnUptAdd = new TvPrograms.RJButton();
            this.btnDel = new TvPrograms.RJButton();
            this.gridHostProgram = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProgram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hostes = new System.Windows.Forms.TabPage();
            this.gridHostes = new System.Windows.Forms.DataGridView();
            this.HostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostPicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjButton3 = new TvPrograms.RJButton();
            this.rjButton2 = new TvPrograms.RJButton();
            this.tabTVController = new System.Windows.Forms.TabControl();
            this.Channels = new System.Windows.Forms.TabPage();
            this.buttonDelete = new TvPrograms.RJButton();
            this.buttonAddUpdate = new TvPrograms.RJButton();
            this.rjButton1 = new TvPrograms.RJButton();
            this.gridChannels = new System.Windows.Forms.DataGridView();
            this.ChannelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programs = new System.Windows.Forms.TabPage();
            this.btnDeletePr = new TvPrograms.RJButton();
            this.btnAddOrUpdate = new TvPrograms.RJButton();
            this.gridPrograms = new System.Windows.Forms.DataGridView();
            this.ProgramId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbChannels = new System.Windows.Forms.ComboBox();
            this.HostProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHostProgram)).BeginInit();
            this.Hostes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHostes)).BeginInit();
            this.tabTVController.SuspendLayout();
            this.Channels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChannels)).BeginInit();
            this.Programs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrograms)).BeginInit();
            this.SuspendLayout();
            // 
            // HostProgram
            // 
            this.HostProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.HostProgram.Controls.Add(this.btnUptAdd);
            this.HostProgram.Controls.Add(this.btnDel);
            this.HostProgram.Controls.Add(this.gridHostProgram);
            this.HostProgram.Location = new System.Drawing.Point(4, 34);
            this.HostProgram.Name = "HostProgram";
            this.HostProgram.Padding = new System.Windows.Forms.Padding(3);
            this.HostProgram.Size = new System.Drawing.Size(844, 485);
            this.HostProgram.TabIndex = 3;
            this.HostProgram.Text = "HostProgram";
            // 
            // btnUptAdd
            // 
            this.btnUptAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnUptAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnUptAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnUptAdd.BorderRadius = 20;
            this.btnUptAdd.BorderSize = 0;
            this.btnUptAdd.FlatAppearance.BorderSize = 0;
            this.btnUptAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUptAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btnUptAdd.Location = new System.Drawing.Point(544, 146);
            this.btnUptAdd.Name = "btnUptAdd";
            this.btnUptAdd.Size = new System.Drawing.Size(246, 75);
            this.btnUptAdd.TabIndex = 19;
            this.btnUptAdd.Text = "Add or Update";
            this.btnUptAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btnUptAdd.UseVisualStyleBackColor = false;
            this.btnUptAdd.Click += new System.EventHandler(this.btnUptAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnDel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnDel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnDel.BorderRadius = 20;
            this.btnDel.BorderSize = 0;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btnDel.Location = new System.Drawing.Point(544, 299);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(246, 73);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Delete";
            this.btnDel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // gridHostProgram
            // 
            this.gridHostProgram.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.gridHostProgram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHostProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHostProgram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PrId,
            this.NameHost,
            this.NameProgram});
            this.gridHostProgram.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridHostProgram.Location = new System.Drawing.Point(3, 3);
            this.gridHostProgram.Name = "gridHostProgram";
            this.gridHostProgram.RowHeadersWidth = 51;
            this.gridHostProgram.RowTemplate.Height = 24;
            this.gridHostProgram.Size = new System.Drawing.Size(535, 479);
            this.gridHostProgram.TabIndex = 14;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "HostId";
            this.Id.HeaderText = "HostId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // PrId
            // 
            this.PrId.DataPropertyName = "ProgramId";
            this.PrId.HeaderText = "ProgramId";
            this.PrId.MinimumWidth = 6;
            this.PrId.Name = "PrId";
            this.PrId.Visible = false;
            this.PrId.Width = 125;
            // 
            // NameHost
            // 
            this.NameHost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameHost.DataPropertyName = "HostName";
            this.NameHost.HeaderText = "HostName";
            this.NameHost.MinimumWidth = 6;
            this.NameHost.Name = "NameHost";
            // 
            // NameProgram
            // 
            this.NameProgram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameProgram.DataPropertyName = "ProgramName";
            this.NameProgram.HeaderText = "ProgramName";
            this.NameProgram.MinimumWidth = 6;
            this.NameProgram.Name = "NameProgram";
            // 
            // Hostes
            // 
            this.Hostes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(120)))));
            this.Hostes.Controls.Add(this.gridHostes);
            this.Hostes.Controls.Add(this.rjButton3);
            this.Hostes.Controls.Add(this.rjButton2);
            this.Hostes.Location = new System.Drawing.Point(4, 34);
            this.Hostes.Name = "Hostes";
            this.Hostes.Padding = new System.Windows.Forms.Padding(3);
            this.Hostes.Size = new System.Drawing.Size(844, 485);
            this.Hostes.TabIndex = 2;
            this.Hostes.Text = "Hostes";
            this.Hostes.Click += new System.EventHandler(this.Hostes_Click);
            // 
            // gridHostes
            // 
            this.gridHostes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(120)))));
            this.gridHostes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHostes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHostes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HostId,
            this.HostName,
            this.HostSurname,
            this.HostAge,
            this.HostPicture});
            this.gridHostes.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridHostes.GridColor = System.Drawing.SystemColors.Control;
            this.gridHostes.Location = new System.Drawing.Point(3, 3);
            this.gridHostes.Name = "gridHostes";
            this.gridHostes.RowHeadersWidth = 51;
            this.gridHostes.RowTemplate.Height = 24;
            this.gridHostes.Size = new System.Drawing.Size(505, 479);
            this.gridHostes.TabIndex = 7;
            this.gridHostes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHostes_CellContentClick);
            this.gridHostes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHostes_CellDoubleClick);
            // 
            // HostId
            // 
            this.HostId.DataPropertyName = "HostId";
            this.HostId.HeaderText = "HostId";
            this.HostId.MinimumWidth = 6;
            this.HostId.Name = "HostId";
            this.HostId.Visible = false;
            this.HostId.Width = 125;
            // 
            // HostName
            // 
            this.HostName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HostName.DataPropertyName = "HostName";
            this.HostName.HeaderText = "HostName";
            this.HostName.MinimumWidth = 6;
            this.HostName.Name = "HostName";
            // 
            // HostSurname
            // 
            this.HostSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HostSurname.DataPropertyName = "HostSurname";
            this.HostSurname.HeaderText = "HostSurname";
            this.HostSurname.MinimumWidth = 6;
            this.HostSurname.Name = "HostSurname";
            // 
            // HostAge
            // 
            this.HostAge.DataPropertyName = "HostAge";
            this.HostAge.HeaderText = "HostAge";
            this.HostAge.MinimumWidth = 6;
            this.HostAge.Name = "HostAge";
            this.HostAge.Visible = false;
            this.HostAge.Width = 125;
            // 
            // HostPicture
            // 
            this.HostPicture.DataPropertyName = "HostPicture";
            this.HostPicture.HeaderText = "HostPicture";
            this.HostPicture.MinimumWidth = 6;
            this.HostPicture.Name = "HostPicture";
            this.HostPicture.Visible = false;
            this.HostPicture.Width = 125;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(114)))), ((int)(((byte)(88)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(114)))), ((int)(((byte)(88)))));
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(114)))), ((int)(((byte)(88)))));
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(527, 259);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(246, 80);
            this.rjButton3.TabIndex = 12;
            this.rjButton3.Text = "Delete";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(114)))), ((int)(((byte)(88)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(114)))), ((int)(((byte)(88)))));
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(114)))), ((int)(((byte)(88)))));
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(527, 154);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(246, 80);
            this.rjButton2.TabIndex = 11;
            this.rjButton2.Text = "Add or Update";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // tabTVController
            // 
            this.tabTVController.Controls.Add(this.Channels);
            this.tabTVController.Controls.Add(this.Programs);
            this.tabTVController.Controls.Add(this.Hostes);
            this.tabTVController.Controls.Add(this.HostProgram);
            this.tabTVController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTVController.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabTVController.Location = new System.Drawing.Point(0, 0);
            this.tabTVController.Name = "tabTVController";
            this.tabTVController.SelectedIndex = 0;
            this.tabTVController.Size = new System.Drawing.Size(852, 523);
            this.tabTVController.TabIndex = 0;
            // 
            // Channels
            // 
            this.Channels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(130)))));
            this.Channels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Channels.Controls.Add(this.buttonDelete);
            this.Channels.Controls.Add(this.buttonAddUpdate);
            this.Channels.Controls.Add(this.rjButton1);
            this.Channels.Controls.Add(this.gridChannels);
            this.Channels.Location = new System.Drawing.Point(4, 34);
            this.Channels.Name = "Channels";
            this.Channels.Padding = new System.Windows.Forms.Padding(3);
            this.Channels.Size = new System.Drawing.Size(832, 485);
            this.Channels.TabIndex = 0;
            this.Channels.Text = "Channels";
            this.Channels.Click += new System.EventHandler(this.Channels_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDelete.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDelete.BorderColor = System.Drawing.Color.White;
            this.buttonDelete.BorderRadius = 20;
            this.buttonDelete.BorderSize = 0;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(524, 286);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(245, 81);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextColor = System.Drawing.Color.Black;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddUpdate
            // 
            this.buttonAddUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddUpdate.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddUpdate.BorderColor = System.Drawing.Color.White;
            this.buttonAddUpdate.BorderRadius = 20;
            this.buttonAddUpdate.BorderSize = 0;
            this.buttonAddUpdate.FlatAppearance.BorderSize = 0;
            this.buttonAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonAddUpdate.Location = new System.Drawing.Point(524, 155);
            this.buttonAddUpdate.Name = "buttonAddUpdate";
            this.buttonAddUpdate.Size = new System.Drawing.Size(245, 81);
            this.buttonAddUpdate.TabIndex = 11;
            this.buttonAddUpdate.Text = "Add or Update";
            this.buttonAddUpdate.TextColor = System.Drawing.Color.Black;
            this.buttonAddUpdate.UseVisualStyleBackColor = false;
            this.buttonAddUpdate.Click += new System.EventHandler(this.buttonAddUpdate_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(1177, 308);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(265, 82);
            this.rjButton1.TabIndex = 10;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // gridChannels
            // 
            this.gridChannels.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(14)))), ((int)(((byte)(130)))));
            this.gridChannels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridChannels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChannels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChannelId,
            this.ChannelName});
            this.gridChannels.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridChannels.Location = new System.Drawing.Point(3, 3);
            this.gridChannels.Name = "gridChannels";
            this.gridChannels.RowHeadersWidth = 51;
            this.gridChannels.RowTemplate.Height = 24;
            this.gridChannels.Size = new System.Drawing.Size(445, 479);
            this.gridChannels.TabIndex = 5;
            this.gridChannels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChannels_CellContentClick);
            this.gridChannels.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChannels_CellDoubleClick);
            // 
            // ChannelId
            // 
            this.ChannelId.DataPropertyName = "ChannelId";
            this.ChannelId.HeaderText = "ChannelId";
            this.ChannelId.MinimumWidth = 6;
            this.ChannelId.Name = "ChannelId";
            this.ChannelId.Visible = false;
            this.ChannelId.Width = 125;
            // 
            // ChannelName
            // 
            this.ChannelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChannelName.DataPropertyName = "ChannelName";
            this.ChannelName.HeaderText = "ChannelName";
            this.ChannelName.MinimumWidth = 6;
            this.ChannelName.Name = "ChannelName";
            // 
            // Programs
            // 
            this.Programs.BackColor = System.Drawing.Color.NavajoWhite;
            this.Programs.Controls.Add(this.btnDeletePr);
            this.Programs.Controls.Add(this.btnAddOrUpdate);
            this.Programs.Controls.Add(this.gridPrograms);
            this.Programs.Controls.Add(this.cmbChannels);
            this.Programs.Location = new System.Drawing.Point(4, 34);
            this.Programs.Name = "Programs";
            this.Programs.Padding = new System.Windows.Forms.Padding(3);
            this.Programs.Size = new System.Drawing.Size(844, 485);
            this.Programs.TabIndex = 1;
            this.Programs.Text = "Programs";
            this.Programs.Click += new System.EventHandler(this.Programs_Click);
            // 
            // btnDeletePr
            // 
            this.btnDeletePr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.btnDeletePr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.btnDeletePr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.btnDeletePr.BorderRadius = 20;
            this.btnDeletePr.BorderSize = 0;
            this.btnDeletePr.FlatAppearance.BorderSize = 0;
            this.btnDeletePr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePr.ForeColor = System.Drawing.Color.White;
            this.btnDeletePr.Location = new System.Drawing.Point(606, 280);
            this.btnDeletePr.Name = "btnDeletePr";
            this.btnDeletePr.Size = new System.Drawing.Size(221, 72);
            this.btnDeletePr.TabIndex = 18;
            this.btnDeletePr.Text = "Delete";
            this.btnDeletePr.TextColor = System.Drawing.Color.White;
            this.btnDeletePr.UseVisualStyleBackColor = false;
            this.btnDeletePr.Click += new System.EventHandler(this.btnDeletePr_Click);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.btnAddOrUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.btnAddOrUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.btnAddOrUpdate.BorderRadius = 20;
            this.btnAddOrUpdate.BorderSize = 0;
            this.btnAddOrUpdate.FlatAppearance.BorderSize = 0;
            this.btnAddOrUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrUpdate.ForeColor = System.Drawing.Color.White;
            this.btnAddOrUpdate.Location = new System.Drawing.Point(606, 173);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(221, 72);
            this.btnAddOrUpdate.TabIndex = 17;
            this.btnAddOrUpdate.Text = "Add or Update";
            this.btnAddOrUpdate.TextColor = System.Drawing.Color.White;
            this.btnAddOrUpdate.UseVisualStyleBackColor = false;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // gridPrograms
            // 
            this.gridPrograms.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.gridPrograms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrograms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgramId,
            this.ProgramName,
            this.StartedAt,
            this.FinishedAt,
            this.dataGridViewTextBoxColumn1});
            this.gridPrograms.Location = new System.Drawing.Point(0, 51);
            this.gridPrograms.Name = "gridPrograms";
            this.gridPrograms.RowHeadersWidth = 51;
            this.gridPrograms.RowTemplate.Height = 24;
            this.gridPrograms.Size = new System.Drawing.Size(590, 474);
            this.gridPrograms.TabIndex = 15;
            // 
            // ProgramId
            // 
            this.ProgramId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProgramId.DataPropertyName = "ProgramId";
            this.ProgramId.HeaderText = "ProgramId";
            this.ProgramId.MinimumWidth = 6;
            this.ProgramId.Name = "ProgramId";
            this.ProgramId.Visible = false;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProgramName.DataPropertyName = "ProgramName";
            this.ProgramName.HeaderText = "ProgramName";
            this.ProgramName.MinimumWidth = 6;
            this.ProgramName.Name = "ProgramName";
            // 
            // StartedAt
            // 
            this.StartedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartedAt.DataPropertyName = "StartedAt";
            this.StartedAt.HeaderText = "StartedAt";
            this.StartedAt.MinimumWidth = 6;
            this.StartedAt.Name = "StartedAt";
            // 
            // FinishedAt
            // 
            this.FinishedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FinishedAt.DataPropertyName = "FinishedAt";
            this.FinishedAt.HeaderText = "FinishedAt";
            this.FinishedAt.MinimumWidth = 6;
            this.FinishedAt.Name = "FinishedAt";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ChannelId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ChannelId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // cmbChannels
            // 
            this.cmbChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbChannels.FormattingEnabled = true;
            this.cmbChannels.Location = new System.Drawing.Point(21, 6);
            this.cmbChannels.Name = "cmbChannels";
            this.cmbChannels.Size = new System.Drawing.Size(375, 39);
            this.cmbChannels.TabIndex = 13;
            this.cmbChannels.SelectedIndexChanged += new System.EventHandler(this.cmbChannels_SelectedIndexChanged);
            this.cmbChannels.SelectionChangeCommitted += new System.EventHandler(this.cmbChannels_SelectionChangeCommitted);
            this.cmbChannels.SelectedValueChanged += new System.EventHandler(this.cmbChannels_SelectedValueChanged);
            this.cmbChannels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbChannels_KeyDown);
            // 
            // ShowAllTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 523);
            this.Controls.Add(this.tabTVController);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowAllTabs";
            this.Text = "ShowAllTabs";
            this.Load += new System.EventHandler(this.ShowAllTabs_Load);
            this.HostProgram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHostProgram)).EndInit();
            this.Hostes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHostes)).EndInit();
            this.tabTVController.ResumeLayout(false);
            this.Channels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChannels)).EndInit();
            this.Programs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrograms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage HostProgram;
        private System.Windows.Forms.TabPage Hostes;
        private System.Windows.Forms.TabPage Programs;
        private System.Windows.Forms.TabPage Channels;
        private System.Windows.Forms.TabControl tabTVController;
        private System.Windows.Forms.DataGridView gridChannels;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelName;
        private RJButton rjButton1;
        private System.Windows.Forms.DataGridView gridPrograms;
        private System.Windows.Forms.ComboBox cmbChannels;
        private RJButton btnDeletePr;
        private RJButton btnAddOrUpdate;
        private RJButton rjButton2;
        private System.Windows.Forms.DataGridView gridHostes;
        private RJButton rjButton3;
        private RJButton buttonAddUpdate;
        private RJButton buttonDelete;
        private RJButton btnDel;
        private System.Windows.Forms.DataGridView gridHostProgram;
        private RJButton btnUptAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}