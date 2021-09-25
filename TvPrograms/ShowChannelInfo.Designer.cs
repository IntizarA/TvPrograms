
namespace TvPrograms
{
    partial class ShowChannelInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowChannelInfo));
            this.gridChannelInfo = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridChannelInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gridChannelInfo
            // 
            this.gridChannelInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(11)))));
            this.gridChannelInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridChannelInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChannelInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ChannelName,
            this.ProgramName,
            this.StartedAt,
            this.FinishedAt,
            this.HostName,
            this.HostSurname});
            this.gridChannelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridChannelInfo.Location = new System.Drawing.Point(0, 0);
            this.gridChannelInfo.Name = "gridChannelInfo";
            this.gridChannelInfo.RowHeadersWidth = 51;
            this.gridChannelInfo.RowTemplate.Height = 24;
            this.gridChannelInfo.Size = new System.Drawing.Size(1070, 242);
            this.gridChannelInfo.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ChannelId";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 130;
            // 
            // ChannelName
            // 
            this.ChannelName.DataPropertyName = "ChannelName";
            this.ChannelName.HeaderText = "ChannelName";
            this.ChannelName.MinimumWidth = 6;
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.Width = 130;
            // 
            // ProgramName
            // 
            this.ProgramName.DataPropertyName = "ProgramName";
            this.ProgramName.HeaderText = "ProgramName";
            this.ProgramName.MinimumWidth = 6;
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Width = 130;
            // 
            // StartedAt
            // 
            this.StartedAt.DataPropertyName = "StartedAt";
            this.StartedAt.HeaderText = "StartedAt";
            this.StartedAt.MinimumWidth = 6;
            this.StartedAt.Name = "StartedAt";
            this.StartedAt.Width = 130;
            // 
            // FinishedAt
            // 
            this.FinishedAt.DataPropertyName = "FinishedAt";
            this.FinishedAt.HeaderText = "FinishedAt";
            this.FinishedAt.MinimumWidth = 6;
            this.FinishedAt.Name = "FinishedAt";
            this.FinishedAt.Width = 130;
            // 
            // HostName
            // 
            this.HostName.DataPropertyName = "HostName";
            this.HostName.HeaderText = "HostName";
            this.HostName.MinimumWidth = 6;
            this.HostName.Name = "HostName";
            this.HostName.Width = 130;
            // 
            // HostSurname
            // 
            this.HostSurname.DataPropertyName = "HostSurname";
            this.HostSurname.HeaderText = "HostSurname";
            this.HostSurname.MinimumWidth = 6;
            this.HostSurname.Name = "HostSurname";
            this.HostSurname.Width = 130;
            // 
            // ShowChannelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TvPrograms.Properties.Resources.fed70b1;
            this.ClientSize = new System.Drawing.Size(1070, 250);
            this.Controls.Add(this.gridChannelInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowChannelInfo";
            this.Text = "ShowChannelInfo";
            this.Load += new System.EventHandler(this.ShowChannelInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridChannelInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridChannelInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostSurname;
    }
}