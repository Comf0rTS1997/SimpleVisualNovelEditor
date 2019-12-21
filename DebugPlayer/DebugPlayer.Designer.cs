namespace GameLinesEditor
{
    partial class DebugPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugPlayer));
            this.UIPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loc1 = new System.Windows.Forms.PictureBox();
            this.loc2 = new System.Windows.Forms.PictureBox();
            this.loc3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc3)).BeginInit();
            this.SuspendLayout();
            // 
            // UIPanel
            // 
            this.UIPanel.BackColor = System.Drawing.Color.Silver;
            this.UIPanel.ColumnCount = 1;
            this.UIPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UIPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UIPanel.Location = new System.Drawing.Point(0, 333);
            this.UIPanel.Name = "UIPanel";
            this.UIPanel.RowCount = 2;
            this.UIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.37363F));
            this.UIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.62637F));
            this.UIPanel.Size = new System.Drawing.Size(800, 117);
            this.UIPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.loc1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loc2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.loc3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // loc1
            // 
            this.loc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loc1.Location = new System.Drawing.Point(3, 3);
            this.loc1.Name = "loc1";
            this.loc1.Size = new System.Drawing.Size(260, 444);
            this.loc1.TabIndex = 0;
            this.loc1.TabStop = false;
            // 
            // loc2
            // 
            this.loc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loc2.Location = new System.Drawing.Point(269, 3);
            this.loc2.Name = "loc2";
            this.loc2.Size = new System.Drawing.Size(260, 444);
            this.loc2.TabIndex = 1;
            this.loc2.TabStop = false;
            // 
            // loc3
            // 
            this.loc3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loc3.Location = new System.Drawing.Point(535, 3);
            this.loc3.Name = "loc3";
            this.loc3.Size = new System.Drawing.Size(262, 444);
            this.loc3.TabIndex = 2;
            this.loc3.TabStop = false;
            // 
            // DebugPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UIPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DebugPlayer";
            this.ShowIcon = false;
            this.Text = "DebugPlayer";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UIPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox loc1;
        private System.Windows.Forms.PictureBox loc2;
        private System.Windows.Forms.PictureBox loc3;
    }
}