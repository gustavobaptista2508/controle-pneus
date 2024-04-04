namespace Controle_de_Pneus
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPneusList = new System.Windows.Forms.Button();
            this.btnVeiculosList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 49);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPneusList);
            this.flowLayoutPanel1.Controls.Add(this.btnVeiculosList);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1067, 49);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnPneusList
            // 
            this.btnPneusList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPneusList.FlatAppearance.BorderSize = 0;
            this.btnPneusList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPneusList.Image = global::Controle_de_Pneus.Properties.Resources._1622833_checkmark_done_exam_list_pencil_icon1;
            this.btnPneusList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPneusList.Location = new System.Drawing.Point(4, 4);
            this.btnPneusList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPneusList.Name = "btnPneusList";
            this.btnPneusList.Size = new System.Drawing.Size(95, 42);
            this.btnPneusList.TabIndex = 0;
            this.btnPneusList.Text = "Pneus";
            this.btnPneusList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPneusList.UseVisualStyleBackColor = true;
            this.btnPneusList.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnVeiculosList
            // 
            this.btnVeiculosList.FlatAppearance.BorderSize = 0;
            this.btnVeiculosList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiculosList.Image = global::Controle_de_Pneus.Properties.Resources._1988878_front_lorry_truck_vehicle_icon;
            this.btnVeiculosList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeiculosList.Location = new System.Drawing.Point(107, 4);
            this.btnVeiculosList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVeiculosList.Name = "btnVeiculosList";
            this.btnVeiculosList.Size = new System.Drawing.Size(85, 42);
            this.btnVeiculosList.TabIndex = 1;
            this.btnVeiculosList.Text = "Frota";
            this.btnVeiculosList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVeiculosList.UseVisualStyleBackColor = true;
            this.btnVeiculosList.Click += new System.EventHandler(this.btnVeiculosList_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Pneus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPneusList;
        private System.Windows.Forms.Button btnVeiculosList;
    }
}