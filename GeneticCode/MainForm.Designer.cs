using System.Windows.Forms;

namespace GeneticCode
{
    partial class MainForm
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
            this._btnGenerate = new System.Windows.Forms.Button();
            this._gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnGenerate
            // 
            this._btnGenerate.Location = new System.Drawing.Point(84, 547);
            this._btnGenerate.Name = "_btnGenerate";
            this._btnGenerate.Size = new System.Drawing.Size(75, 23);
            this._btnGenerate.TabIndex = 0;
            this._btnGenerate.Text = "Generate";
            this._btnGenerate.UseVisualStyleBackColor = true;
            this._btnGenerate.Click += new System.EventHandler(this._btnGenerate_Click_1);
            // 
            // _gridView
            // 
            this._gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridView.Location = new System.Drawing.Point(220, 0);
            this._gridView.Name = "_gridView";
            this._gridView.RowHeadersVisible = false;
            this._gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this._gridView.Size = new System.Drawing.Size(322, 709);
            this._gridView.TabIndex = 1;
            this._gridView.ColumnCount = 4;
            this._gridView.Columns[0].HeaderText = "Количество особей";
            this._gridView.Columns[1].HeaderText = "A";
            this._gridView.Columns[2].HeaderText = "B";
            this._gridView.Columns[3].HeaderText = "C";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 715);
            this.Controls.Add(this._gridView);
            this.Controls.Add(this._btnGenerate);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this._gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnGenerate;
        private System.Windows.Forms.DataGridView _gridView;
    }
}

