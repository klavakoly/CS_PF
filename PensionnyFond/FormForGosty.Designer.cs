namespace PensionnyFond
{
    partial class FormForGosty
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPency = new System.Windows.Forms.Button();
            this.buttonLgote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(377, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Пенсионый Фонд\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(214, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Просмотреть льготы, назначаемые с пенсиями.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(214, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(769, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Просмотреть пенсии. Список, необходимых для получения пенсии, документов.";
            // 
            // buttonPency
            // 
            this.buttonPency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPency.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPency.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPency.Location = new System.Drawing.Point(219, 155);
            this.buttonPency.MinimumSize = new System.Drawing.Size(225, 57);
            this.buttonPency.Name = "buttonPency";
            this.buttonPency.Size = new System.Drawing.Size(249, 57);
            this.buttonPency.TabIndex = 30;
            this.buttonPency.Text = "Виды пенсий";
            this.buttonPency.UseVisualStyleBackColor = false;
            this.buttonPency.Click += new System.EventHandler(this.buttonPency_Click);
            // 
            // buttonLgote
            // 
            this.buttonLgote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLgote.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLgote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLgote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLgote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLgote.Location = new System.Drawing.Point(219, 285);
            this.buttonLgote.MinimumSize = new System.Drawing.Size(225, 57);
            this.buttonLgote.Name = "buttonLgote";
            this.buttonLgote.Size = new System.Drawing.Size(249, 57);
            this.buttonLgote.TabIndex = 29;
            this.buttonLgote.Text = "Список льгот";
            this.buttonLgote.UseVisualStyleBackColor = false;
            this.buttonLgote.Click += new System.EventHandler(this.buttonLgote_Click);
            // 
            // FormForGosty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1071, 643);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPency);
            this.Controls.Add(this.buttonLgote);
            this.Controls.Add(this.label1);
            this.Name = "FormForGosty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.CalculationFormForGosty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPency;
        private System.Windows.Forms.Button buttonLgote;
    }
}