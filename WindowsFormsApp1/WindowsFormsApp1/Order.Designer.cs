namespace WindowsFormsApp1
{
    partial class Order
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
            this.Menu = new System.Windows.Forms.Label();
            this.Object = new System.Windows.Forms.Label();
            this.quant = new System.Windows.Forms.TextBox();
            this.ko = new System.Windows.Forms.Label();
            this.Inc = new System.Windows.Forms.Button();
            this.Dec = new System.Windows.Forms.Button();
            this.Cer = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu.Location = new System.Drawing.Point(93, 44);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(91, 34);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // Object
            // 
            this.Object.AutoSize = true;
            this.Object.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Object.Location = new System.Drawing.Point(179, 206);
            this.Object.Name = "Object";
            this.Object.Size = new System.Drawing.Size(148, 30);
            this.Object.TabIndex = 1;
            this.Object.Text = "名前：値段";
            // 
            // quant
            // 
            this.quant.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.quant.Location = new System.Drawing.Point(425, 203);
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            this.quant.Size = new System.Drawing.Size(100, 37);
            this.quant.TabIndex = 2;
            this.quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ko
            // 
            this.ko.AutoSize = true;
            this.ko.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ko.Location = new System.Drawing.Point(531, 215);
            this.ko.Name = "ko";
            this.ko.Size = new System.Drawing.Size(23, 20);
            this.ko.TabIndex = 3;
            this.ko.Text = "コ";
            // 
            // Inc
            // 
            this.Inc.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Inc.Location = new System.Drawing.Point(450, 153);
            this.Inc.Name = "Inc";
            this.Inc.Size = new System.Drawing.Size(75, 44);
            this.Inc.TabIndex = 4;
            this.Inc.Text = "↑";
            this.Inc.UseVisualStyleBackColor = true;
            this.Inc.Click += new System.EventHandler(this.Inc_Click);
            // 
            // Dec
            // 
            this.Dec.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Dec.Location = new System.Drawing.Point(450, 246);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(75, 44);
            this.Dec.TabIndex = 5;
            this.Dec.Text = "↓";
            this.Dec.UseVisualStyleBackColor = true;
            this.Dec.Click += new System.EventHandler(this.Dec_Click);
            // 
            // Cer
            // 
            this.Cer.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Cer.Location = new System.Drawing.Point(572, 353);
            this.Cer.Name = "Cer";
            this.Cer.Size = new System.Drawing.Size(128, 71);
            this.Cer.TabIndex = 6;
            this.Cer.Text = "OK";
            this.Cer.UseVisualStyleBackColor = true;
            this.Cer.Click += new System.EventHandler(this.Cer_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back.Location = new System.Drawing.Point(58, 389);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 35);
            this.Back.TabIndex = 20;
            this.Back.Text = "戻る";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Cer);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.Inc);
            this.Controls.Add(this.ko);
            this.Controls.Add(this.quant);
            this.Controls.Add(this.Object);
            this.Controls.Add(this.Menu);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Label Object;
        private System.Windows.Forms.TextBox quant;
        private System.Windows.Forms.Label ko;
        private System.Windows.Forms.Button Inc;
        private System.Windows.Forms.Button Dec;
        private System.Windows.Forms.Button Cer;
        private System.Windows.Forms.Button Back;
    }
}