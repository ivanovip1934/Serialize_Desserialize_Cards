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
            this.button_WriteDeck = new System.Windows.Forms.Button();
            this.button_ReadeDeck = new System.Windows.Forms.Button();
            this.button_writeSevRandDeck = new System.Windows.Forms.Button();
            this.button_readeSavRanDeck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_WriteDeck
            // 
            this.button_WriteDeck.Location = new System.Drawing.Point(104, 107);
            this.button_WriteDeck.Name = "button_WriteDeck";
            this.button_WriteDeck.Size = new System.Drawing.Size(163, 23);
            this.button_WriteDeck.TabIndex = 0;
            this.button_WriteDeck.Text = "Write  Random Deck to File";
            this.button_WriteDeck.UseVisualStyleBackColor = true;
            this.button_WriteDeck.Click += new System.EventHandler(this.button_WriteDeck_Click);
            // 
            // button_ReadeDeck
            // 
            this.button_ReadeDeck.Location = new System.Drawing.Point(104, 206);
            this.button_ReadeDeck.Name = "button_ReadeDeck";
            this.button_ReadeDeck.Size = new System.Drawing.Size(159, 23);
            this.button_ReadeDeck.TabIndex = 1;
            this.button_ReadeDeck.Text = "Read Deck from file";
            this.button_ReadeDeck.UseVisualStyleBackColor = true;
            this.button_ReadeDeck.Click += new System.EventHandler(this.button_ReadeDeck_Click);
            // 
            // button_writeSevRandDeck
            // 
            this.button_writeSevRandDeck.Location = new System.Drawing.Point(415, 106);
            this.button_writeSevRandDeck.Name = "button_writeSevRandDeck";
            this.button_writeSevRandDeck.Size = new System.Drawing.Size(219, 23);
            this.button_writeSevRandDeck.TabIndex = 2;
            this.button_writeSevRandDeck.Text = "Write Savarel Random Deck to file";
            this.button_writeSevRandDeck.UseVisualStyleBackColor = true;
            this.button_writeSevRandDeck.Click += new System.EventHandler(this.button_writeSevRandDeck_Click);
            // 
            // button_readeSavRanDeck
            // 
            this.button_readeSavRanDeck.Location = new System.Drawing.Point(415, 206);
            this.button_readeSavRanDeck.Name = "button_readeSavRanDeck";
            this.button_readeSavRanDeck.Size = new System.Drawing.Size(219, 23);
            this.button_readeSavRanDeck.TabIndex = 3;
            this.button_readeSavRanDeck.Text = "Read savarel deck from file";
            this.button_readeSavRanDeck.UseVisualStyleBackColor = true;
            this.button_readeSavRanDeck.Click += new System.EventHandler(this.button_readeSavRanDeck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 365);
            this.Controls.Add(this.button_readeSavRanDeck);
            this.Controls.Add(this.button_writeSevRandDeck);
            this.Controls.Add(this.button_ReadeDeck);
            this.Controls.Add(this.button_WriteDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_WriteDeck;
        private System.Windows.Forms.Button button_ReadeDeck;
        private System.Windows.Forms.Button button_writeSevRandDeck;
        private System.Windows.Forms.Button button_readeSavRanDeck;
    }
}

