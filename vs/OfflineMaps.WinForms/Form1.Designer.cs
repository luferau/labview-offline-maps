namespace OfflineMaps.WinForms
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.offlineMapControl = new OfflineMaps.Controls.OfflineMapControl();
            this.point2button = new System.Windows.Forms.Button();
            this.point1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.offlineMapControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.point2button);
            this.splitContainer1.Panel2.Controls.Add(this.point1Button);
            this.splitContainer1.Size = new System.Drawing.Size(1465, 1127);
            this.splitContainer1.SplitterDistance = 933;
            this.splitContainer1.TabIndex = 0;
            // 
            // offlineMapControl
            // 
            this.offlineMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offlineMapControl.Location = new System.Drawing.Point(0, 0);
            this.offlineMapControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.offlineMapControl.Name = "offlineMapControl";
            this.offlineMapControl.Size = new System.Drawing.Size(1465, 933);
            this.offlineMapControl.TabIndex = 0;
            // 
            // point2button
            // 
            this.point2button.Location = new System.Drawing.Point(256, 73);
            this.point2button.Name = "point2button";
            this.point2button.Size = new System.Drawing.Size(164, 62);
            this.point2button.TabIndex = 0;
            this.point2button.Text = "Add point #2";
            this.point2button.UseVisualStyleBackColor = true;
            this.point2button.Click += new System.EventHandler(this.point2button_Click);
            // 
            // point1Button
            // 
            this.point1Button.Location = new System.Drawing.Point(59, 73);
            this.point1Button.Name = "point1Button";
            this.point1Button.Size = new System.Drawing.Size(164, 62);
            this.point1Button.TabIndex = 0;
            this.point1Button.Text = "Add point #1";
            this.point1Button.UseVisualStyleBackColor = true;
            this.point1Button.Click += new System.EventHandler(this.point1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 1127);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.OfflineMapControl offlineMapControl;
        private System.Windows.Forms.Button point2button;
        private System.Windows.Forms.Button point1Button;
    }
}

