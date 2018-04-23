namespace GridCommander
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
            this.commanderTab2 = new GridCommander.CommanderTab();
            this.commanderTab1 = new GridCommander.CommanderTab();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // commanderTab2
            // 
            this.commanderTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commanderTab2.Location = new System.Drawing.Point(0, 0);
            this.commanderTab2.Name = "commanderTab2";
            this.commanderTab2.Size = new System.Drawing.Size(671, 594);
            this.commanderTab2.TabIndex = 5;
            // 
            // commanderTab1
            // 
            this.commanderTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commanderTab1.Location = new System.Drawing.Point(0, 0);
            this.commanderTab1.Name = "commanderTab1";
            this.commanderTab1.Size = new System.Drawing.Size(796, 594);
            this.commanderTab1.TabIndex = 4;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.commanderTab2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.commanderTab1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1472, 594);
            this.splitContainerControl1.SplitterPosition = 671;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 594);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "GridCommander";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CommanderTab commanderTab2;
        private CommanderTab commanderTab1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}

