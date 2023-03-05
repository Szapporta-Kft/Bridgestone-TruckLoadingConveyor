namespace Bridgestone.Warehouse.Loading.Conveyor.App
{
    partial class MainWindow
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
            this._PanelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _PanelMain
            // 
            this._PanelMain.BackColor = System.Drawing.Color.White;
            this._PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._PanelMain.Location = new System.Drawing.Point(0, 0);
            this._PanelMain.Name = "_PanelMain";
            this._PanelMain.Size = new System.Drawing.Size(800, 400);
            this._PanelMain.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this._PanelMain);
            this.Name = "MainWindow";
            this.Text = "Bridgestone";
            this.ResumeLayout(false);

        }

        private Panel _PanelMain;

        #endregion
    }
}