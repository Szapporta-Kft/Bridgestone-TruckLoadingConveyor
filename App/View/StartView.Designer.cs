namespace Bridgestone.Warehouse.Loading.Conveyor.App.View
{
    partial class StartView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelivery.Image = global::Bridgestone.Warehouse.Loading.Conveyor.App.Properties.Resources.truck_180;
            this.btnDelivery.Location = new System.Drawing.Point(150, 100);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(200, 200);
            this.btnDelivery.TabIndex = 0;
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new EventHandler(Handle_DeliveryButtonClick);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Bridgestone.Warehouse.Loading.Conveyor.App.Properties.Resources.logout_180;
            this.btnExit.Location = new System.Drawing.Point(450, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 200);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new EventHandler(Handle_ExitButtonClick);
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelivery);
            this.Name = "StartView";
            this.Size = new System.Drawing.Size(800, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDelivery;
        private Button btnExit;
    }
}
