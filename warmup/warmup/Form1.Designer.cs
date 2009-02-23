namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Close = new System.Windows.Forms.Button();
            this.viewBox = new System.Windows.Forms.PictureBox();
            this.Render = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(184, 219);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.close_Click);
            // 
            // viewBox
            // 
            this.viewBox.Location = new System.Drawing.Point(23, 28);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(236, 167);
            this.viewBox.TabIndex = 1;
            this.viewBox.TabStop = false;
            // 
            // Render
            // 
            this.Render.Location = new System.Drawing.Point(103, 219);
            this.Render.Name = "Render";
            this.Render.Size = new System.Drawing.Size(75, 23);
            this.Render.TabIndex = 2;
            this.Render.Text = "Render";
            this.Render.UseVisualStyleBackColor = true;
            this.Render.Click += new System.EventHandler(this.render_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.Render);
            this.Controls.Add(this.viewBox);
            this.Controls.Add(this.Close);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.viewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox viewBox;
        private System.Windows.Forms.Button Render;
    }
}

