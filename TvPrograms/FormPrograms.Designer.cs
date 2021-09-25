
namespace TvPrograms
{
    partial class FormPrograms
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbChannels = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gridPrograms = new System.Windows.Forms.DataGridView();
            this.ProgramId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrograms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel";
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(394, 21);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(155, 40);
            this.btnAddUpdate.TabIndex = 3;
            this.btnAddUpdate.Text = "Add or Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(649, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbChannels
            // 
            this.cmbChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbChannels.FormattingEnabled = true;
            this.cmbChannels.Location = new System.Drawing.Point(12, 74);
            this.cmbChannels.Name = "cmbChannels";
            this.cmbChannels.Size = new System.Drawing.Size(184, 30);
            this.cmbChannels.TabIndex = 5;
            this.cmbChannels.SelectedIndexChanged += new System.EventHandler(this.cmbChannels_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(217, 74);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 30);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gridPrograms
            // 
            this.gridPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrograms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgramId,
            this.ProgramName,
            this.StartedAt,
            this.FinishedAt,
            this.ChannelId});
            this.gridPrograms.Location = new System.Drawing.Point(342, 100);
            this.gridPrograms.Name = "gridPrograms";
            this.gridPrograms.RowHeadersWidth = 51;
            this.gridPrograms.RowTemplate.Height = 24;
            this.gridPrograms.Size = new System.Drawing.Size(594, 251);
            this.gridPrograms.TabIndex = 8;
            this.gridPrograms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPrograms_CellContentClick);
            // 
            // ProgramId
            // 
            this.ProgramId.DataPropertyName = "ProgramId";
            this.ProgramId.HeaderText = "ProgramId";
            this.ProgramId.MinimumWidth = 6;
            this.ProgramId.Name = "ProgramId";
            this.ProgramId.Visible = false;
            this.ProgramId.Width = 125;
            // 
            // ProgramName
            // 
            this.ProgramName.DataPropertyName = "ProgramName";
            this.ProgramName.HeaderText = "ProgramName";
            this.ProgramName.MinimumWidth = 6;
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Width = 125;
            // 
            // StartedAt
            // 
            this.StartedAt.DataPropertyName = "StartedAt";
            this.StartedAt.HeaderText = "StartedAt";
            this.StartedAt.MinimumWidth = 6;
            this.StartedAt.Name = "StartedAt";
            this.StartedAt.Width = 125;
            // 
            // FinishedAt
            // 
            this.FinishedAt.DataPropertyName = "FinishedAt";
            this.FinishedAt.HeaderText = "FinishedAt";
            this.FinishedAt.MinimumWidth = 6;
            this.FinishedAt.Name = "FinishedAt";
            this.FinishedAt.Width = 125;
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(840, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 36);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 427);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gridPrograms);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbChannels);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.label1);
            this.Name = "FormPrograms";
            this.Text = "Programs";
            this.Load += new System.EventHandler(this.Programs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrograms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbChannels;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView gridPrograms;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelId;
        private System.Windows.Forms.Button btnBack;
    }
}