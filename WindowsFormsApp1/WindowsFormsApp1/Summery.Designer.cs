namespace WindowsFormsApp1
{
    partial class Summery
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
            this.label2 = new System.Windows.Forms.Label();
            this.Master = new System.Windows.Forms.DataGridView();
            this.certifize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Master)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(106, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "集計";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(0, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 1);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Master
            // 
            this.Master.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.Master.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Master.GridColor = System.Drawing.Color.SpringGreen;
            this.Master.Location = new System.Drawing.Point(12, 152);
            this.Master.Name = "Master";
            this.Master.ReadOnly = true;
            this.Master.RowTemplate.Height = 24;
            this.Master.Size = new System.Drawing.Size(776, 310);
            this.Master.TabIndex = 2;
            // 
            // certifize
            // 
            this.certifize.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.certifize.Location = new System.Drawing.Point(310, 484);
            this.certifize.Name = "certifize";
            this.certifize.Size = new System.Drawing.Size(144, 44);
            this.certifize.TabIndex = 3;
            this.certifize.Text = "確認";
            this.certifize.UseVisualStyleBackColor = true;
            this.certifize.Click += new System.EventHandler(this.certifize_Click);
            // 
            // Summery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.ControlBox = false;
            this.Controls.Add(this.certifize);
            this.Controls.Add(this.Master);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Summery";
            this.Text = "Summery";
            this.Load += new System.EventHandler(this.Summery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Master)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Master;
        private System.Windows.Forms.Button certifize;
    }
}