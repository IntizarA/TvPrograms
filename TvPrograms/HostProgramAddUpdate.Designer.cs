
namespace TvPrograms
{
    partial class HostProgramAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostProgramAddUpdate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHostNames = new System.Windows.Forms.ComboBox();
            this.cmbProgramNames = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtHoatName = new System.Windows.Forms.TextBox();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program:";
            // 
            // cmbHostNames
            // 
            this.cmbHostNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbHostNames.FormattingEnabled = true;
            this.cmbHostNames.Location = new System.Drawing.Point(149, 17);
            this.cmbHostNames.Name = "cmbHostNames";
            this.cmbHostNames.Size = new System.Drawing.Size(195, 33);
            this.cmbHostNames.TabIndex = 2;
            this.cmbHostNames.SelectedIndexChanged += new System.EventHandler(this.cmbHostNames_SelectedIndexChanged);
            // 
            // cmbProgramNames
            // 
            this.cmbProgramNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbProgramNames.FormattingEnabled = true;
            this.cmbProgramNames.Location = new System.Drawing.Point(149, 91);
            this.cmbProgramNames.Name = "cmbProgramNames";
            this.cmbProgramNames.Size = new System.Drawing.Size(195, 33);
            this.cmbProgramNames.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btnSave.Location = new System.Drawing.Point(391, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHoatName
            // 
            this.txtHoatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHoatName.Location = new System.Drawing.Point(391, 20);
            this.txtHoatName.Name = "txtHoatName";
            this.txtHoatName.Size = new System.Drawing.Size(157, 30);
            this.txtHoatName.TabIndex = 5;
            // 
            // txtProgramName
            // 
            this.txtProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProgramName.Location = new System.Drawing.Point(391, 94);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(157, 30);
            this.txtProgramName.TabIndex = 6;
            // 
            // HostProgramAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(562, 237);
            this.Controls.Add(this.txtProgramName);
            this.Controls.Add(this.txtHoatName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbProgramNames);
            this.Controls.Add(this.cmbHostNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HostProgramAddUpdate";
            this.Text = "HostProgramAddUpdate";
            this.Load += new System.EventHandler(this.HostProgramAddUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHostNames;
        private System.Windows.Forms.ComboBox cmbProgramNames;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtHoatName;
        private System.Windows.Forms.TextBox txtProgramName;
    }
}