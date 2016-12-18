namespace MIDICrossApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboMidiInDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMidiOutDevices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PozycjaKursora = new System.Windows.Forms.TextBox();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.NoteList = new System.Windows.Forms.ListView();
            this.NoteVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMidiInDevices
            // 
            this.comboMidiInDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboMidiInDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMidiInDevices.FormattingEnabled = true;
            this.comboMidiInDevices.Location = new System.Drawing.Point(185, 27);
            this.comboMidiInDevices.Name = "comboMidiInDevices";
            this.comboMidiInDevices.Size = new System.Drawing.Size(204, 21);
            this.comboMidiInDevices.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "MIDI IN";
            // 
            // comboMidiOutDevices
            // 
            this.comboMidiOutDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboMidiOutDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMidiOutDevices.FormattingEnabled = true;
            this.comboMidiOutDevices.Location = new System.Drawing.Point(185, 49);
            this.comboMidiOutDevices.Name = "comboMidiOutDevices";
            this.comboMidiOutDevices.Size = new System.Drawing.Size(204, 21);
            this.comboMidiOutDevices.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "MIDI OUT";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(34, 27);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 41;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.InitialImage")));
            this.PictureBox.Location = new System.Drawing.Point(34, 92);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(504, 563);
            this.PictureBox.TabIndex = 42;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // PozycjaKursora
            // 
            this.PozycjaKursora.Location = new System.Drawing.Point(617, 92);
            this.PozycjaKursora.Name = "PozycjaKursora";
            this.PozycjaKursora.Size = new System.Drawing.Size(100, 20);
            this.PozycjaKursora.TabIndex = 43;
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Location = new System.Drawing.Point(34, 56);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(75, 23);
            this.Refreshbutton.TabIndex = 44;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // NoteList
            // 
            this.NoteList.Location = new System.Drawing.Point(570, 134);
            this.NoteList.Name = "NoteList";
            this.NoteList.Size = new System.Drawing.Size(260, 481);
            this.NoteList.TabIndex = 45;
            this.NoteList.UseCompatibleStateImageBehavior = false;
            // 
            // NoteVal
            // 
            this.NoteVal.Location = new System.Drawing.Point(617, 23);
            this.NoteVal.Name = "NoteVal";
            this.NoteVal.Size = new System.Drawing.Size(100, 20);
            this.NoteVal.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 667);
            this.Controls.Add(this.NoteVal);
            this.Controls.Add(this.NoteList);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.PozycjaKursora);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.comboMidiInDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMidiOutDevices);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMidiInDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMidiOutDevices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox PozycjaKursora;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.ListView NoteList;
        private System.Windows.Forms.TextBox NoteVal;

    }
}

