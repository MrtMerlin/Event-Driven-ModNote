namespace ModNote
{
    partial class ModNoteMain
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
            this.modInfoGrid = new System.Windows.Forms.DataGridView();
            this.delMod = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.importTextMod = new System.Windows.Forms.Button();
            this.saveModButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // modInfoGrid
            // 
            this.modInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modInfoGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.modInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modInfoGrid.Location = new System.Drawing.Point(13, 13);
            this.modInfoGrid.Name = "modInfoGrid";
            this.modInfoGrid.Size = new System.Drawing.Size(834, 327);
            this.modInfoGrid.TabIndex = 0;
            this.modInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modInfoGrid_CellContentDoubleClick);
            // 
            // delMod
            // 
            this.delMod.Location = new System.Drawing.Point(531, 366);
            this.delMod.Name = "delMod";
            this.delMod.Size = new System.Drawing.Size(75, 75);
            this.delMod.TabIndex = 2;
            this.delMod.Text = "Delete";
            this.delMod.UseVisualStyleBackColor = true;
            this.delMod.Click += new System.EventHandler(this.delMod_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(612, 366);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 75);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // importTextMod
            // 
            this.importTextMod.Location = new System.Drawing.Point(450, 366);
            this.importTextMod.Name = "importTextMod";
            this.importTextMod.Size = new System.Drawing.Size(75, 75);
            this.importTextMod.TabIndex = 5;
            this.importTextMod.Text = "Import";
            this.importTextMod.UseVisualStyleBackColor = true;
            this.importTextMod.Click += new System.EventHandler(this.importTextMod_Click);
            // 
            // saveModButton
            // 
            this.saveModButton.Location = new System.Drawing.Point(693, 366);
            this.saveModButton.Name = "saveModButton";
            this.saveModButton.Size = new System.Drawing.Size(75, 75);
            this.saveModButton.TabIndex = 6;
            this.saveModButton.Text = "Save";
            this.saveModButton.UseVisualStyleBackColor = true;
            this.saveModButton.Click += new System.EventHandler(this.saveModButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(774, 366);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 75);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ModNoteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 453);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveModButton);
            this.Controls.Add(this.importTextMod);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.delMod);
            this.Controls.Add(this.modInfoGrid);
            this.Name = "ModNoteMain";
            this.Text = "Module Note System";
            this.Load += new System.EventHandler(this.ModNoteMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modInfoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView modInfoGrid;
        private System.Windows.Forms.Button delMod;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button importTextMod;
        private System.Windows.Forms.Button saveModButton;
        private System.Windows.Forms.Button exitButton;
    }
}

