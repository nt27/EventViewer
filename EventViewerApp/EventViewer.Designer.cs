namespace EventViewerApp
{
    partial class EventViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventViewer));
            this.btnReLoadSourceList = new System.Windows.Forms.Button();
            this.dgEventViewer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSourceList = new System.Windows.Forms.ListBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSystemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnApplication = new System.Windows.Forms.RadioButton();
            this.rbtnSeccurity = new System.Windows.Forms.RadioButton();
            this.rbtnSystem = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgEventViewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReLoadSourceList
            // 
            this.btnReLoadSourceList.BackColor = System.Drawing.Color.Gold;
            this.btnReLoadSourceList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoadSourceList.Location = new System.Drawing.Point(115, 282);
            this.btnReLoadSourceList.Name = "btnReLoadSourceList";
            this.btnReLoadSourceList.Size = new System.Drawing.Size(121, 23);
            this.btnReLoadSourceList.TabIndex = 0;
            this.btnReLoadSourceList.Text = "Re-Load Source List";
            this.btnReLoadSourceList.UseVisualStyleBackColor = false;
            this.btnReLoadSourceList.Click += new System.EventHandler(this.btnReLoadSourceList_Click);
            // 
            // dgEventViewer
            // 
            this.dgEventViewer.AllowUserToAddRows = false;
            this.dgEventViewer.AllowUserToDeleteRows = false;
            this.dgEventViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEventViewer.Location = new System.Drawing.Point(333, 24);
            this.dgEventViewer.MultiSelect = false;
            this.dgEventViewer.Name = "dgEventViewer";
            this.dgEventViewer.ReadOnly = true;
            this.dgEventViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEventViewer.Size = new System.Drawing.Size(733, 251);
            this.dgEventViewer.TabIndex = 1;
            this.dgEventViewer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEventViewer_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hours Back";
            // 
            // lstSourceList
            // 
            this.lstSourceList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSourceList.FormattingEnabled = true;
            this.lstSourceList.Location = new System.Drawing.Point(115, 92);
            this.lstSourceList.Name = "lstSourceList";
            this.lstSourceList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSourceList.Size = new System.Drawing.Size(212, 186);
            this.lstSourceList.TabIndex = 3;
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(115, 59);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(47, 21);
            this.txtHours.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Source List";
            // 
            // txtSystemName
            // 
            this.txtSystemName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSystemName.Location = new System.Drawing.Point(115, 27);
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.Size = new System.Drawing.Size(110, 21);
            this.txtSystemName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "System Name";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(333, 281);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(183, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Event Log";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 314);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1075, 23);
            this.progressBar.TabIndex = 21;
            this.progressBar.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblView);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.txtDateTime);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtEventID);
            this.panel1.Controls.Add(this.txtSource);
            this.panel1.Location = new System.Drawing.Point(13, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 313);
            this.panel1.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Date Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Event ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Source";
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(82, 152);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(550, 116);
            this.txtMessage.TabIndex = 23;
            // 
            // txtDateTime
            // 
            this.txtDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.Location = new System.Drawing.Point(82, 114);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.ReadOnly = true;
            this.txtDateTime.Size = new System.Drawing.Size(185, 21);
            this.txtDateTime.TabIndex = 24;
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(82, 80);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(185, 21);
            this.txtType.TabIndex = 25;
            // 
            // txtEventID
            // 
            this.txtEventID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID.Location = new System.Drawing.Point(82, 46);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(185, 21);
            this.txtEventID.TabIndex = 26;
            // 
            // txtSource
            // 
            this.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSource.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(82, 12);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(185, 21);
            this.txtSource.TabIndex = 27;
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(548, 286);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(35, 13);
            this.lblTotalRecords.TabIndex = 33;
            this.lblTotalRecords.Text = "Total";
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(472, 12);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(34, 13);
            this.lblView.TabIndex = 34;
            this.lblView.Text = "View";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(979, 276);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lstSourceList);
            this.panel2.Controls.Add(this.lblTotalRecords);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Controls.Add(this.btnReLoadSourceList);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgEventViewer);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.txtSystemName);
            this.panel2.Controls.Add(this.txtHours);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 339);
            this.panel2.TabIndex = 34;
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(82, 274);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(121, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy Message";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 701);
            this.panel3.TabIndex = 35;
            // 
            // rbtnApplication
            // 
            this.rbtnApplication.AutoSize = true;
            this.rbtnApplication.Checked = true;
            this.rbtnApplication.Location = new System.Drawing.Point(15, 8);
            this.rbtnApplication.Name = "rbtnApplication";
            this.rbtnApplication.Size = new System.Drawing.Size(77, 17);
            this.rbtnApplication.TabIndex = 34;
            this.rbtnApplication.TabStop = true;
            this.rbtnApplication.Text = "Application";
            this.rbtnApplication.UseVisualStyleBackColor = true;
            // 
            // rbtnSeccurity
            // 
            this.rbtnSeccurity.AutoSize = true;
            this.rbtnSeccurity.Location = new System.Drawing.Point(15, 30);
            this.rbtnSeccurity.Name = "rbtnSeccurity";
            this.rbtnSeccurity.Size = new System.Drawing.Size(63, 17);
            this.rbtnSeccurity.TabIndex = 34;
            this.rbtnSeccurity.Text = "Security";
            this.rbtnSeccurity.UseVisualStyleBackColor = true;
            // 
            // rbtnSystem
            // 
            this.rbtnSystem.AutoSize = true;
            this.rbtnSystem.Location = new System.Drawing.Point(15, 52);
            this.rbtnSystem.Name = "rbtnSystem";
            this.rbtnSystem.Size = new System.Drawing.Size(59, 17);
            this.rbtnSystem.TabIndex = 34;
            this.rbtnSystem.Text = "System";
            this.rbtnSystem.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rbtnApplication);
            this.panel4.Controls.Add(this.rbtnSystem);
            this.panel4.Controls.Add(this.rbtnSeccurity);
            this.panel4.Location = new System.Drawing.Point(9, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(94, 78);
            this.panel4.TabIndex = 35;
            // 
            // EventViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 718);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventViewer";
            this.Text = "Event Log Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EventViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEventViewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReLoadSourceList;
        private System.Windows.Forms.DataGridView dgEventViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSourceList;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSystemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnSystem;
        private System.Windows.Forms.RadioButton rbtnSeccurity;
        private System.Windows.Forms.RadioButton rbtnApplication;
        private System.Windows.Forms.Panel panel4;
    }
}

