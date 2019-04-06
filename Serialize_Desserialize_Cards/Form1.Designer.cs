namespace Serialize_Deserialize_Cards
{
    partial class Form1
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
            this.button_SerCard1 = new System.Windows.Forms.Button();
            this.button_SerCard2 = new System.Windows.Forms.Button();
            this.button_CompareCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SerCard1
            // 
            this.button_SerCard1.Location = new System.Drawing.Point(71, 52);
            this.button_SerCard1.Name = "button_SerCard1";
            this.button_SerCard1.Size = new System.Drawing.Size(163, 23);
            this.button_SerCard1.TabIndex = 4;
            this.button_SerCard1.Text = "Serialize card - тройка крести";
            this.button_SerCard1.UseVisualStyleBackColor = true;
            this.button_SerCard1.Click += new System.EventHandler(this.button_SerCard1_Click);
            // 
            // button_SerCard2
            // 
            this.button_SerCard2.Location = new System.Drawing.Point(264, 52);
            this.button_SerCard2.Name = "button_SerCard2";
            this.button_SerCard2.Size = new System.Drawing.Size(219, 23);
            this.button_SerCard2.TabIndex = 5;
            this.button_SerCard2.Text = "Serialize card - шестерку червей";
            this.button_SerCard2.UseVisualStyleBackColor = true;
            this.button_SerCard2.Click += new System.EventHandler(this.button_SerCard2_Click);
            // 
            // button_CompareCard
            // 
            this.button_CompareCard.Location = new System.Drawing.Point(188, 133);
            this.button_CompareCard.Name = "button_CompareCard";
            this.button_CompareCard.Size = new System.Drawing.Size(168, 23);
            this.button_CompareCard.TabIndex = 6;
            this.button_CompareCard.Text = "Compare Card";
            this.button_CompareCard.UseVisualStyleBackColor = true;
            this.button_CompareCard.Click += new System.EventHandler(this.button_CompareCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 192);
            this.Controls.Add(this.button_CompareCard);
            this.Controls.Add(this.button_SerCard2);
            this.Controls.Add(this.button_SerCard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_SerCard1;
        private System.Windows.Forms.Button button_SerCard2;
        private System.Windows.Forms.Button button_CompareCard;
    }
}

