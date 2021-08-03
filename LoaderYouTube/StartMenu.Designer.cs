
namespace LoaderYouTube
{
    partial class StartMenu
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelWork = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelTegs = new System.Windows.Forms.Panel();
            this.panelDiscription = new System.Windows.Forms.Panel();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTegs = new System.Windows.Forms.TextBox();
            this.panelStarusLoader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBackground.SuspendLayout();
            this.panelWork.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelTegs.SuspendLayout();
            this.panelDiscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelBackground.Controls.Add(this.panelWork);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1184, 610);
            this.panelBackground.TabIndex = 0;
            // 
            // panelWork
            // 
            this.panelWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelWork.Controls.Add(this.panel1);
            this.panelWork.Controls.Add(this.panelStarusLoader);
            this.panelWork.Controls.Add(this.panelDiscription);
            this.panelWork.Controls.Add(this.panelTegs);
            this.panelWork.Controls.Add(this.panelTitle);
            this.panelWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.panelWork.Location = new System.Drawing.Point(372, 41);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(791, 500);
            this.panelWork.TabIndex = 0;
            this.panelWork.TabStop = true;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.textBoxTitle);
            this.panelTitle.Location = new System.Drawing.Point(25, 23);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(246, 124);
            this.panelTitle.TabIndex = 0;
            // 
            // panelTegs
            // 
            this.panelTegs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelTegs.Controls.Add(this.label3);
            this.panelTegs.Controls.Add(this.textBoxTegs);
            this.panelTegs.Location = new System.Drawing.Point(571, 23);
            this.panelTegs.Name = "panelTegs";
            this.panelTegs.Size = new System.Drawing.Size(211, 124);
            this.panelTegs.TabIndex = 1;
            // 
            // panelDiscription
            // 
            this.panelDiscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelDiscription.Controls.Add(this.label2);
            this.panelDiscription.Controls.Add(this.textBoxDescription);
            this.panelDiscription.Location = new System.Drawing.Point(295, 23);
            this.panelDiscription.Name = "panelDiscription";
            this.panelDiscription.Size = new System.Drawing.Size(211, 124);
            this.panelDiscription.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxTitle.Font = new System.Drawing.Font("Lucida Bright", 11F);
            this.textBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.textBoxTitle.Location = new System.Drawing.Point(0, 52);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(246, 72);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = "\r\nвпишите сюда название видео перед публикацией\r\n";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxDescription.Font = new System.Drawing.Font("Lucida Bright", 11F);
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.textBoxDescription.Location = new System.Drawing.Point(0, 52);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(211, 72);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.Text = "\r\nвпишите сюда описание видео перед публикацией\r\n\r\n";
            this.textBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTegs
            // 
            this.textBoxTegs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.textBoxTegs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTegs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxTegs.Font = new System.Drawing.Font("Lucida Bright", 11F);
            this.textBoxTegs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.textBoxTegs.Location = new System.Drawing.Point(0, 52);
            this.textBoxTegs.Multiline = true;
            this.textBoxTegs.Name = "textBoxTegs";
            this.textBoxTegs.Size = new System.Drawing.Size(211, 72);
            this.textBoxTegs.TabIndex = 3;
            this.textBoxTegs.Text = "\r\nвпишите сюда теги  видео перед публикацией\r\n\r\n";
            this.textBoxTegs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelStarusLoader
            // 
            this.panelStarusLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelStarusLoader.Location = new System.Drawing.Point(25, 171);
            this.panelStarusLoader.Name = "panelStarusLoader";
            this.panelStarusLoader.Size = new System.Drawing.Size(246, 326);
            this.panelStarusLoader.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(82, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 14);
            this.labelTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назвиние видео";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание видео";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Теги видео";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(285, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 610);
            this.Controls.Add(this.panelBackground);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelBackground.ResumeLayout(false);
            this.panelWork.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelTegs.ResumeLayout(false);
            this.panelTegs.PerformLayout();
            this.panelDiscription.ResumeLayout(false);
            this.panelDiscription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDiscription;
        private System.Windows.Forms.Panel panelTegs;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTegs;
        private System.Windows.Forms.Panel panelStarusLoader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
    }
}

