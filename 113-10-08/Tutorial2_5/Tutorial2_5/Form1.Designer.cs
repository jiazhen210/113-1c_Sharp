namespace Tutorial2_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ptxback = new PictureBox();
            ptxfront = new PictureBox();
            btnback = new Button();
            btnfront = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            SuspendLayout();
            // 
            // ptxback
            // 
            ptxback.Image = (Image)resources.GetObject("ptxback.Image");
            ptxback.Location = new Point(28, 25);
            ptxback.Name = "ptxback";
            ptxback.Size = new Size(175, 308);
            ptxback.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxback.TabIndex = 0;
            ptxback.TabStop = false;
            ptxback.Visible = false;
            // 
            // ptxfront
            // 
            ptxfront.Image = (Image)resources.GetObject("ptxfront.Image");
            ptxfront.Location = new Point(267, 25);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(186, 308);
            ptxfront.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxfront.TabIndex = 1;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            // 
            // btnback
            // 
            btnback.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnback.Location = new Point(48, 361);
            btnback.Name = "btnback";
            btnback.Size = new Size(129, 72);
            btnback.TabIndex = 2;
            btnback.Text = "背面";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnfront
            // 
            btnfront.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnfront.Location = new Point(290, 361);
            btnfront.Name = "btnfront";
            btnfront.Size = new Size(129, 72);
            btnfront.TabIndex = 3;
            btnfront.Text = "正面";
            btnfront.UseVisualStyleBackColor = true;
            btnfront.Click += btnfront_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 508);
            Controls.Add(btnfront);
            Controls.Add(btnback);
            Controls.Add(ptxfront);
            Controls.Add(ptxback);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxback).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxback;
        private PictureBox ptxfront;
        private Button btnback;
        private Button btnfront;
    }
}
