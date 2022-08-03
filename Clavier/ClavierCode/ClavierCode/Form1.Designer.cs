namespace ClavierCode
{
    partial class ClavierCode
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClavierCode));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Connecter = new System.Windows.Forms.Button();
            this.ComList = new System.Windows.Forms.ComboBox();
            this.Select1 = new System.Windows.Forms.RadioButton();
            this.Select2 = new System.Windows.Forms.RadioButton();
            this.status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Connecter
            // 
            this.Connecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.Connecter, "Connecter");
            this.Connecter.ForeColor = System.Drawing.Color.White;
            this.Connecter.Name = "Connecter";
            this.Connecter.UseVisualStyleBackColor = false;
            this.Connecter.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ComList
            // 
            this.ComList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.ComList, "ComList");
            this.ComList.ForeColor = System.Drawing.Color.White;
            this.ComList.FormattingEnabled = true;
            this.ComList.Name = "ComList";
            // 
            // Select1
            // 
            resources.ApplyResources(this.Select1, "Select1");
            this.Select1.Checked = true;
            this.Select1.Name = "Select1";
            this.Select1.TabStop = true;
            this.Select1.UseVisualStyleBackColor = true;
            this.Select1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Select2
            // 
            resources.ApplyResources(this.Select2, "Select2");
            this.Select2.Name = "Select2";
            this.Select2.TabStop = true;
            this.Select2.UseVisualStyleBackColor = true;
            this.Select2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // status
            // 
            resources.ApplyResources(this.status, "status");
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Name = "status";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.refresh, "refresh");
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Name = "refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ClavierCode
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Select2);
            this.Controls.Add(this.Select1);
            this.Controls.Add(this.ComList);
            this.Controls.Add(this.Connecter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ClavierCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Connecter;
        private System.Windows.Forms.ComboBox ComList;
        private System.Windows.Forms.RadioButton Select1;
        private System.Windows.Forms.RadioButton Select2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button refresh;
    }
}

