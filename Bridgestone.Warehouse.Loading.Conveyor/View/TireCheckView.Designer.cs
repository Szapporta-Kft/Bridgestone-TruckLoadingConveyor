namespace Bridgestone.Warehouse.Loading.Conveyor.App.View
{
    partial class TireCheckView
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnColse = new System.Windows.Forms.Button();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblPlanOutput = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.lblActualOutput = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblDeliveryOutput = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(51, 86);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 65);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(301, 86);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(200, 65);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnColse
            // 
            this.btnColse.BackColor = System.Drawing.Color.Black;
            this.btnColse.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnColse.ForeColor = System.Drawing.Color.White;
            this.btnColse.Location = new System.Drawing.Point(551, 86);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(200, 65);
            this.btnColse.TabIndex = 2;
            this.btnColse.Text = "LEZÁR";
            this.btnColse.UseVisualStyleBackColor = false;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlan.Location = new System.Drawing.Point(51, 182);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(89, 37);
            this.lblPlan.TabIndex = 3;
            this.lblPlan.Text = "TERV:";
            // 
            // lblPlanOutput
            // 
            this.lblPlanOutput.AutoSize = true;
            this.lblPlanOutput.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlanOutput.Location = new System.Drawing.Point(146, 182);
            this.lblPlanOutput.Name = "lblPlanOutput";
            this.lblPlanOutput.Size = new System.Drawing.Size(0, 37);
            this.lblPlanOutput.TabIndex = 4;
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActual.Location = new System.Drawing.Point(51, 231);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(91, 37);
            this.lblActual.TabIndex = 5;
            this.lblActual.Text = "TÉNY:";
            // 
            // lblActualOutput
            // 
            this.lblActualOutput.AutoSize = true;
            this.lblActualOutput.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActualOutput.Location = new System.Drawing.Point(148, 231);
            this.lblActualOutput.Name = "lblActualOutput";
            this.lblActualOutput.Size = new System.Drawing.Size(0, 37);
            this.lblActualOutput.TabIndex = 6;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(301, 182);
            this.tbBarcode.Multiline = true;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(450, 86);
            this.tbBarcode.TabIndex = 7;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Black;
            this.pnlTitle.Controls.Add(this.lblDeliveryOutput);
            this.pnlTitle.Controls.Add(this.lblDelivery);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(800, 70);
            this.pnlTitle.TabIndex = 8;
            // 
            // lblDeliveryOutput
            // 
            this.lblDeliveryOutput.AutoSize = true;
            this.lblDeliveryOutput.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeliveryOutput.ForeColor = System.Drawing.Color.White;
            this.lblDeliveryOutput.Location = new System.Drawing.Point(177, 18);
            this.lblDeliveryOutput.Name = "lblDeliveryOutput";
            this.lblDeliveryOutput.Size = new System.Drawing.Size(0, 37);
            this.lblDeliveryOutput.TabIndex = 11;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDelivery.ForeColor = System.Drawing.Color.White;
            this.lblDelivery.Location = new System.Drawing.Point(19, 18);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(152, 37);
            this.lblDelivery.TabIndex = 10;
            this.lblDelivery.Text = "Kiszállítás:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(50, 302);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(700, 79);
            this.textBox1.TabIndex = 9;
            // 
            // TireCheckView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.lblActualOutput);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.lblPlanOutput);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.btnColse);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "TireCheckView";
            this.Size = new System.Drawing.Size(800, 400);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Button btnColse;
        private Label lblPlan;
        private Label lblPlanOutput;
        private Label lblActual;
        private Label lblActualOutput;
        private TextBox tbBarcode;
        private Panel pnlTitle;
        private Label lblDeliveryOutput;
        private Label lblDelivery;
        private TextBox textBox1;
    }
}
