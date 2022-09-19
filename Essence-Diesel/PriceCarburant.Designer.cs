
namespace Essence_Diesel
{
    partial class PriceCarburant
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
            this.dtgFuels = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actualiserLeTableauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuels)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgFuels
            // 
            this.dtgFuels.AllowUserToAddRows = false;
            this.dtgFuels.AllowUserToDeleteRows = false;
            this.dtgFuels.AllowUserToResizeColumns = false;
            this.dtgFuels.AllowUserToResizeRows = false;
            this.dtgFuels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgFuels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFuels.BackgroundColor = System.Drawing.Color.White;
            this.dtgFuels.ColumnHeadersHeight = 29;
            this.dtgFuels.Location = new System.Drawing.Point(0, 27);
            this.dtgFuels.MultiSelect = false;
            this.dtgFuels.Name = "dtgFuels";
            this.dtgFuels.ReadOnly = true;
            this.dtgFuels.RowHeadersWidth = 51;
            this.dtgFuels.RowTemplate.Height = 29;
            this.dtgFuels.ShowCellErrors = false;
            this.dtgFuels.ShowCellToolTips = false;
            this.dtgFuels.ShowEditingIcon = false;
            this.dtgFuels.Size = new System.Drawing.Size(720, 423);
            this.dtgFuels.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualiserLeTableauToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actualiserLeTableauToolStripMenuItem
            // 
            this.actualiserLeTableauToolStripMenuItem.Name = "actualiserLeTableauToolStripMenuItem";
            this.actualiserLeTableauToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.actualiserLeTableauToolStripMenuItem.Text = "Actualiser le tableau";
            this.actualiserLeTableauToolStripMenuItem.Click += new System.EventHandler(this.RefreshData);
            // 
            // PriceCarburant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.dtgFuels);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PriceCarburant";
            this.Text = "Prix Carburant - By Nasdy";
            this.Load += new System.EventHandler(this.PriceCarburant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuels)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgFuels;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualiserLeTableauToolStripMenuItem;
    }
}

