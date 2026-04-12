namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BText = new System.Windows.Forms.TextBox();
            this.cipherText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.encodeButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.exportEnc = new System.Windows.Forms.Button();
            this.importEnc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plainText
            // 
            resources.ApplyResources(this.plainText, "plainText");
            this.plainText.ForeColor = System.Drawing.Color.Crimson;
            this.plainText.Name = "plainText";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Name = "label1";
            // 
            // PText
            // 
            resources.ApplyResources(this.PText, "PText");
            this.PText.ForeColor = System.Drawing.Color.Crimson;
            this.PText.Name = "PText";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Name = "label3";
            // 
            // QText
            // 
            resources.ApplyResources(this.QText, "QText");
            this.QText.ForeColor = System.Drawing.Color.Crimson;
            this.QText.Name = "QText";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Name = "label4";
            // 
            // BText
            // 
            resources.ApplyResources(this.BText, "BText");
            this.BText.ForeColor = System.Drawing.Color.Crimson;
            this.BText.Name = "BText";
            // 
            // cipherText
            // 
            resources.ApplyResources(this.cipherText, "cipherText");
            this.cipherText.ForeColor = System.Drawing.Color.Crimson;
            this.cipherText.Name = "cipherText";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Name = "label5";
            // 
            // encodeButton
            // 
            this.encodeButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.encodeButton.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.encodeButton, "encodeButton");
            this.encodeButton.ForeColor = System.Drawing.Color.Crimson;
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // importButton
            // 
            this.importButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.importButton.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.importButton, "importButton");
            this.importButton.ForeColor = System.Drawing.Color.Crimson;
            this.importButton.Name = "importButton";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exportButton
            // 
            this.exportButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.exportButton.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.exportButton, "exportButton");
            this.exportButton.ForeColor = System.Drawing.Color.Crimson;
            this.exportButton.Name = "exportButton";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.decodeButton.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.decodeButton, "decodeButton");
            this.decodeButton.ForeColor = System.Drawing.Color.Crimson;
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // exportEnc
            // 
            this.exportEnc.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.exportEnc.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.exportEnc, "exportEnc");
            this.exportEnc.ForeColor = System.Drawing.Color.Crimson;
            this.exportEnc.Name = "exportEnc";
            this.exportEnc.UseVisualStyleBackColor = true;
            this.exportEnc.Click += new System.EventHandler(this.exportEnc_Click);
            // 
            // importEnc
            // 
            this.importEnc.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.importEnc.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.importEnc, "importEnc");
            this.importEnc.ForeColor = System.Drawing.Color.Crimson;
            this.importEnc.Name = "importEnc";
            this.importEnc.UseVisualStyleBackColor = true;
            this.importEnc.Click += new System.EventHandler(this.importEnc_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.Controls.Add(this.exportEnc);
            this.Controls.Add(this.importEnc);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plainText);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BText;
        private System.Windows.Forms.TextBox cipherText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button exportEnc;
        private System.Windows.Forms.Button importEnc;
    }
}

