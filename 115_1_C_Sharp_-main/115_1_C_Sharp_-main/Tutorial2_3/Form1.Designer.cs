namespace Tutorial2_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.translateLabel = new System.Windows.Forms.Label();
            this.Italianbutton = new System.Windows.Forms.Button();
            this.Spanishbutton = new System.Windows.Forms.Button();
            this.Germanbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我告訴你怎麼說\"早安\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateLabel
            // 
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateLabel.Location = new System.Drawing.Point(202, 173);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(388, 90);
            this.translateLabel.TabIndex = 1;
            this.translateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Italianbutton
            // 
            this.Italianbutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Italianbutton.Location = new System.Drawing.Point(72, 311);
            this.Italianbutton.Name = "Italianbutton";
            this.Italianbutton.Size = new System.Drawing.Size(186, 68);
            this.Italianbutton.TabIndex = 2;
            this.Italianbutton.Text = "義大利";
            this.Italianbutton.UseVisualStyleBackColor = true;
            this.Italianbutton.Click += new System.EventHandler(this.Italianbutton_Click);
            // 
            // Spanishbutton
            // 
            this.Spanishbutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Spanishbutton.Location = new System.Drawing.Point(324, 311);
            this.Spanishbutton.Name = "Spanishbutton";
            this.Spanishbutton.Size = new System.Drawing.Size(180, 68);
            this.Spanishbutton.TabIndex = 3;
            this.Spanishbutton.Text = "西班牙";
            this.Spanishbutton.UseVisualStyleBackColor = true;
            this.Spanishbutton.Click += new System.EventHandler(this.Spanishbutton_Click);
            // 
            // Germanbutton
            // 
            this.Germanbutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Germanbutton.Location = new System.Drawing.Point(585, 311);
            this.Germanbutton.Name = "Germanbutton";
            this.Germanbutton.Size = new System.Drawing.Size(172, 68);
            this.Germanbutton.TabIndex = 4;
            this.Germanbutton.Text = "德國";
            this.Germanbutton.UseVisualStyleBackColor = true;
            this.Germanbutton.Click += new System.EventHandler(this.Germanbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Germanbutton);
            this.Controls.Add(this.Spanishbutton);
            this.Controls.Add(this.Italianbutton);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Forms1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.Button Italianbutton;
        private System.Windows.Forms.Button Spanishbutton;
        private System.Windows.Forms.Button Germanbutton;
    }
}

