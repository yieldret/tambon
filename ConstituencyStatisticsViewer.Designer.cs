﻿namespace De.AHoerstemeier.Tambon
{
    partial class ConstituencyStatisticsViewer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mTreeviewData = new System.Windows.Forms.TreeView();
            this.txtStatistics = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mTreeviewData
            // 
            this.mTreeviewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mTreeviewData.Location = new System.Drawing.Point(1, 2);
            this.mTreeviewData.Name = "mTreeviewData";
            this.mTreeviewData.Size = new System.Drawing.Size(153, 268);
            this.mTreeviewData.TabIndex = 9;
            // 
            // txtStatistics
            // 
            this.txtStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatistics.Location = new System.Drawing.Point(160, -1);
            this.txtStatistics.Multiline = true;
            this.txtStatistics.Name = "txtStatistics";
            this.txtStatistics.ReadOnly = true;
            this.txtStatistics.Size = new System.Drawing.Size(265, 271);
            this.txtStatistics.TabIndex = 10;
            // 
            // ConstituencyStatisticsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 273);
            this.Controls.Add(this.txtStatistics);
            this.Controls.Add(this.mTreeviewData);
            this.Name = "ConstituencyStatisticsViewer";
            this.Text = "ConstituencyStatisticsViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView mTreeviewData;
        private System.Windows.Forms.TextBox txtStatistics;
    }
}