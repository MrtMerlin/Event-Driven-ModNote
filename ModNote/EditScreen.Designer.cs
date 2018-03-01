namespace ModNote
{
    partial class EditScreen
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
            this.code = new System.Windows.Forms.TextBox();
            this.modCodeLab = new System.Windows.Forms.Label();
            this.modNameLab = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.synoLab = new System.Windows.Forms.Label();
            this.syno = new System.Windows.Forms.RichTextBox();
            this.lo = new System.Windows.Forms.RichTextBox();
            this.LOLab = new System.Windows.Forms.Label();
            this.assDDLab = new System.Windows.Forms.Label();
            this.addButtonComp = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.assign = new System.Windows.Forms.RichTextBox();
            this.notesLab = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.expDates = new System.Windows.Forms.RichTextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(12, 35);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(131, 20);
            this.code.TabIndex = 0;
            // 
            // modCodeLab
            // 
            this.modCodeLab.AutoSize = true;
            this.modCodeLab.Location = new System.Drawing.Point(12, 13);
            this.modCodeLab.Name = "modCodeLab";
            this.modCodeLab.Size = new System.Drawing.Size(70, 13);
            this.modCodeLab.TabIndex = 1;
            this.modCodeLab.Text = "Module Code";
            // 
            // modNameLab
            // 
            this.modNameLab.AutoSize = true;
            this.modNameLab.Location = new System.Drawing.Point(172, 13);
            this.modNameLab.Name = "modNameLab";
            this.modNameLab.Size = new System.Drawing.Size(73, 13);
            this.modNameLab.TabIndex = 2;
            this.modNameLab.Text = "Module Name";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(175, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(280, 20);
            this.title.TabIndex = 3;
            // 
            // synoLab
            // 
            this.synoLab.AutoSize = true;
            this.synoLab.Location = new System.Drawing.Point(12, 69);
            this.synoLab.Name = "synoLab";
            this.synoLab.Size = new System.Drawing.Size(49, 13);
            this.synoLab.TabIndex = 4;
            this.synoLab.Text = "Synopsis";
            // 
            // syno
            // 
            this.syno.Location = new System.Drawing.Point(12, 94);
            this.syno.Name = "syno";
            this.syno.Size = new System.Drawing.Size(443, 151);
            this.syno.TabIndex = 5;
            this.syno.Text = "";
            // 
            // lo
            // 
            this.lo.Location = new System.Drawing.Point(12, 293);
            this.lo.Name = "lo";
            this.lo.Size = new System.Drawing.Size(443, 81);
            this.lo.TabIndex = 6;
            this.lo.Text = "";
            // 
            // LOLab
            // 
            this.LOLab.AutoSize = true;
            this.LOLab.Location = new System.Drawing.Point(12, 263);
            this.LOLab.Name = "LOLab";
            this.LOLab.Size = new System.Drawing.Size(99, 13);
            this.LOLab.TabIndex = 7;
            this.LOLab.Text = "Learning Outcomes";
            // 
            // assDDLab
            // 
            this.assDDLab.AutoSize = true;
            this.assDDLab.Location = new System.Drawing.Point(12, 396);
            this.assDDLab.Name = "assDDLab";
            this.assDDLab.Size = new System.Drawing.Size(110, 13);
            this.assDDLab.TabIndex = 9;
            this.assDDLab.Text = "Assingment Due Date";
            // 
            // addButtonComp
            // 
            this.addButtonComp.Location = new System.Drawing.Point(401, 431);
            this.addButtonComp.Name = "addButtonComp";
            this.addButtonComp.Size = new System.Drawing.Size(66, 22);
            this.addButtonComp.TabIndex = 10;
            this.addButtonComp.Text = "Save";
            this.addButtonComp.UseVisualStyleBackColor = true;
            this.addButtonComp.Click += new System.EventHandler(this.addButtonComp_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(401, 459);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(66, 22);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // assign
            // 
            this.assign.Location = new System.Drawing.Point(15, 413);
            this.assign.Name = "assign";
            this.assign.Size = new System.Drawing.Size(357, 114);
            this.assign.TabIndex = 13;
            this.assign.Text = "";
            // 
            // notesLab
            // 
            this.notesLab.AutoSize = true;
            this.notesLab.Location = new System.Drawing.Point(483, 12);
            this.notesLab.Name = "notesLab";
            this.notesLab.Size = new System.Drawing.Size(118, 13);
            this.notesLab.TabIndex = 14;
            this.notesLab.Text = "Please enter your notes";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(486, 35);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(567, 381);
            this.notes.TabIndex = 15;
            this.notes.Text = "";
            // 
            // expDates
            // 
            this.expDates.ForeColor = System.Drawing.Color.Red;
            this.expDates.Location = new System.Drawing.Point(486, 431);
            this.expDates.Name = "expDates";
            this.expDates.Size = new System.Drawing.Size(567, 96);
            this.expDates.TabIndex = 16;
            this.expDates.Text = "";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(401, 487);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(66, 22);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EditScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 542);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.expDates);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.notesLab);
            this.Controls.Add(this.assign);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addButtonComp);
            this.Controls.Add(this.assDDLab);
            this.Controls.Add(this.LOLab);
            this.Controls.Add(this.lo);
            this.Controls.Add(this.syno);
            this.Controls.Add(this.synoLab);
            this.Controls.Add(this.title);
            this.Controls.Add(this.modNameLab);
            this.Controls.Add(this.modCodeLab);
            this.Controls.Add(this.code);
            this.Name = "EditScreen";
            this.Text = "Add Module";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label modCodeLab;
        private System.Windows.Forms.Label modNameLab;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label synoLab;
        private System.Windows.Forms.RichTextBox syno;
        private System.Windows.Forms.RichTextBox lo;
        private System.Windows.Forms.Label LOLab;
        private System.Windows.Forms.Label assDDLab;
        private System.Windows.Forms.Button addButtonComp;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RichTextBox assign;
        private System.Windows.Forms.Label notesLab;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.RichTextBox expDates;
        private System.Windows.Forms.Button closeButton;
    }
}