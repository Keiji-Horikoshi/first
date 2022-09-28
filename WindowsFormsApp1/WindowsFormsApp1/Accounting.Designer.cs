namespace WindowsFormsApp1
{
    partial class Accounting
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
            this.会計 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Receipt = new System.Windows.Forms.DataGridView();
            this.Next = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Receipt)).BeginInit();
            this.SuspendLayout();
            // 
            // 会計
            // 
            this.会計.AutoSize = true;
            this.会計.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.会計.Location = new System.Drawing.Point(133, 65);
            this.会計.Name = "会計";
            this.会計.Size = new System.Drawing.Size(81, 33);
            this.会計.TabIndex = 0;
            this.会計.Text = "会計";
            this.会計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(1, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 1);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timer.Location = new System.Drawing.Point(494, 30);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(49, 20);
            this.timer.TabIndex = 2;
            this.timer.Text = "時刻";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(29, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "戻る";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Receipt
            // 
            this.Receipt.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Receipt.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Receipt.Location = new System.Drawing.Point(81, 203);
            this.Receipt.Name = "Receipt";
            this.Receipt.ReadOnly = true;
            this.Receipt.RowTemplate.Height = 24;
            this.Receipt.Size = new System.Drawing.Size(629, 275);
            this.Receipt.TabIndex = 21;
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Next.Location = new System.Drawing.Point(597, 666);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(171, 38);
            this.Next.TabIndex = 22;
            this.Next.Text = "確定して次へ";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Payment.Location = new System.Drawing.Point(280, 526);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(89, 24);
            this.Payment.TabIndex = 23;
            this.Payment.Text = "お預かり";
            this.Payment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxP
            // 
            this.textBoxP.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxP.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxP.Location = new System.Drawing.Point(396, 523);
            this.textBoxP.MaxLength = 16;
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.ShortcutsEnabled = false;
            this.textBoxP.Size = new System.Drawing.Size(147, 30);
            this.textBoxP.TabIndex = 24;
            this.textBoxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxP_KeyDown);
            this.textBoxP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxP_KeyPress);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back.Location = new System.Drawing.Point(280, 608);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(69, 24);
            this.Back.TabIndex = 25;
            this.Back.Text = "お釣り";
            this.Back.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxB.Location = new System.Drawing.Point(396, 605);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(147, 30);
            this.textBoxB.TabIndex = 26;
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 753);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Receipt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.会計);
            this.Name = "Accounting";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Accounting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Receipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 会計;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Receipt;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.TextBox textBoxB;
    }
}