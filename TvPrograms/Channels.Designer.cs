
namespace TvPrograms
{
    partial class Channels
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
            this.gridChannels = new System.Windows.Forms.DataGridView();
            this.ChannelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridChannels)).BeginInit();
            this.SuspendLayout();
            // 
            // gridChannels
            // 
            this.gridChannels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChannels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChannelId,
            this.ChannelName});
            this.gridChannels.Location = new System.Drawing.Point(29, 100);
            this.gridChannels.Name = "gridChannels";
            this.gridChannels.RowHeadersWidth = 51;
            this.gridChannels.RowTemplate.Height = 24;
            this.gridChannels.Size = new System.Drawing.Size(322, 237);
            this.gridChannels.TabIndex = 0;
            this.gridChannels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChannels_CellContentClick);
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
            this.ChannelName.DataPropertyName = "ChannelName";
            this.ChannelName.HeaderText = "ChannelName";
            this.ChannelName.MinimumWidth = 6;
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.Width = 125;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(29, 36);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(151, 40);
            this.btnAddUpdate.TabIndex = 1;
            this.btnAddUpdate.Text = "Add or Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(233, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(229, 356);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(29, 356);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(134, 39);
            this.Show.TabIndex = 4;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Channels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 407);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.gridChannels);
            this.Name = "Channels";
            this.Text = "Channels";
            this.Load += new System.EventHandler(this.Channels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridChannels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridChannels;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelName;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button Show;
    }
}