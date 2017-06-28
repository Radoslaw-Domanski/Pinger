namespace Pinger
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
            this.pingButton = new System.Windows.Forms.Button();
            this.domainName = new System.Windows.Forms.TextBox();
            this.labelDomain = new System.Windows.Forms.Label();
            this.pingedIP = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.openDomainList = new System.Windows.Forms.OpenFileDialog();
            this.loadDomainListButton = new System.Windows.Forms.Button();
            this.saveDomainListDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveDomainList = new System.Windows.Forms.Button();
            this.labelLoadedDomainFile = new System.Windows.Forms.Label();
            this.pingDomainListButton = new System.Windows.Forms.Button();
            this.plikInfo = new System.Windows.Forms.Label();
            this.wczytanoInfo = new System.Windows.Forms.Label();
            this.spingowanoInfo = new System.Windows.Forms.Label();
            this.pingProgress = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.domainListPingInfo = new System.Windows.Forms.Label();
            this.zapisaneInfo = new System.Windows.Forms.Label();
            this.IPPingedHistory = new System.Windows.Forms.TextBox();
            this.labelHistoryIP = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.listPingedDomains = new System.Windows.Forms.ListBox();
            this.clearListButton = new System.Windows.Forms.Button();
            this.listDateDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadDatesList = new System.Windows.Forms.Button();
            this.labelDatesInfo = new System.Windows.Forms.Label();
            this.datesLoaded = new System.Windows.Forms.Label();
            this.loadedInfo = new System.Windows.Forms.Label();
            this.addDays = new System.Windows.Forms.Button();
            this.saveDates = new System.Windows.Forms.Button();
            this.saveAddedDates = new System.Windows.Forms.SaveFileDialog();
            this.savedTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pingButton
            // 
            this.pingButton.Location = new System.Drawing.Point(216, 17);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(75, 23);
            this.pingButton.TabIndex = 0;
            this.pingButton.Text = "Ping";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // domainName
            // 
            this.domainName.Location = new System.Drawing.Point(65, 19);
            this.domainName.Name = "domainName";
            this.domainName.Size = new System.Drawing.Size(131, 20);
            this.domainName.TabIndex = 1;
            this.domainName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.domainName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(12, 22);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(53, 13);
            this.labelDomain.TabIndex = 2;
            this.labelDomain.Text = "Domena :";
            // 
            // pingedIP
            // 
            this.pingedIP.Location = new System.Drawing.Point(65, 56);
            this.pingedIP.Name = "pingedIP";
            this.pingedIP.Size = new System.Drawing.Size(129, 20);
            this.pingedIP.TabIndex = 3;
            this.pingedIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 59);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(50, 13);
            this.labelIP.TabIndex = 4;
            this.labelIP.Text = "Adres IP:";
            // 
            // openDomainList
            // 
            this.openDomainList.FileName = "openFileDialog1";
            this.openDomainList.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // loadDomainListButton
            // 
            this.loadDomainListButton.Location = new System.Drawing.Point(15, 138);
            this.loadDomainListButton.Name = "loadDomainListButton";
            this.loadDomainListButton.Size = new System.Drawing.Size(75, 23);
            this.loadDomainListButton.TabIndex = 5;
            this.loadDomainListButton.Text = "Wczytaj";
            this.loadDomainListButton.UseVisualStyleBackColor = true;
            this.loadDomainListButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveDomainList
            // 
            this.saveDomainList.Location = new System.Drawing.Point(216, 138);
            this.saveDomainList.Name = "saveDomainList";
            this.saveDomainList.Size = new System.Drawing.Size(75, 23);
            this.saveDomainList.TabIndex = 6;
            this.saveDomainList.Text = "Zapisz";
            this.saveDomainList.UseVisualStyleBackColor = true;
            this.saveDomainList.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelLoadedDomainFile
            // 
            this.labelLoadedDomainFile.AutoSize = true;
            this.labelLoadedDomainFile.Location = new System.Drawing.Point(12, 109);
            this.labelLoadedDomainFile.Name = "labelLoadedDomainFile";
            this.labelLoadedDomainFile.Size = new System.Drawing.Size(92, 13);
            this.labelLoadedDomainFile.TabIndex = 7;
            this.labelLoadedDomainFile.Text = "Załadowany plik :";
            // 
            // pingDomainListButton
            // 
            this.pingDomainListButton.Location = new System.Drawing.Point(96, 138);
            this.pingDomainListButton.Name = "pingDomainListButton";
            this.pingDomainListButton.Size = new System.Drawing.Size(114, 23);
            this.pingDomainListButton.TabIndex = 8;
            this.pingDomainListButton.Text = "Pinguj Domeny";
            this.pingDomainListButton.UseVisualStyleBackColor = true;
            this.pingDomainListButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // plikInfo
            // 
            this.plikInfo.AutoSize = true;
            this.plikInfo.Location = new System.Drawing.Point(122, 109);
            this.plikInfo.Name = "plikInfo";
            this.plikInfo.Size = new System.Drawing.Size(29, 13);
            this.plikInfo.TabIndex = 9;
            this.plikInfo.Text = "Brak";
            // 
            // wczytanoInfo
            // 
            this.wczytanoInfo.AutoSize = true;
            this.wczytanoInfo.Location = new System.Drawing.Point(12, 164);
            this.wczytanoInfo.Name = "wczytanoInfo";
            this.wczytanoInfo.Size = new System.Drawing.Size(0, 13);
            this.wczytanoInfo.TabIndex = 10;
            // 
            // spingowanoInfo
            // 
            this.spingowanoInfo.AutoSize = true;
            this.spingowanoInfo.Location = new System.Drawing.Point(93, 164);
            this.spingowanoInfo.Name = "spingowanoInfo";
            this.spingowanoInfo.Size = new System.Drawing.Size(0, 13);
            this.spingowanoInfo.TabIndex = 11;
            // 
            // pingProgress
            // 
            this.pingProgress.Location = new System.Drawing.Point(15, 248);
            this.pingProgress.Name = "pingProgress";
            this.pingProgress.Size = new System.Drawing.Size(276, 23);
            this.pingProgress.Step = 1;
            this.pingProgress.TabIndex = 13;
            this.pingProgress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(93, 232);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(101, 13);
            this.labelProgress.TabIndex = 14;
            this.labelProgress.Text = "Progres Pingowania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 15;
            // 
            // domainListPingInfo
            // 
            this.domainListPingInfo.AutoSize = true;
            this.domainListPingInfo.Location = new System.Drawing.Point(12, 186);
            this.domainListPingInfo.Name = "domainListPingInfo";
            this.domainListPingInfo.Size = new System.Drawing.Size(109, 13);
            this.domainListPingInfo.TabIndex = 17;
            this.domainListPingInfo.Text = "Załadowano domen :";
            // 
            // zapisaneInfo
            // 
            this.zapisaneInfo.AutoSize = true;
            this.zapisaneInfo.Location = new System.Drawing.Point(12, 210);
            this.zapisaneInfo.Name = "zapisaneInfo";
            this.zapisaneInfo.Size = new System.Drawing.Size(0, 13);
            this.zapisaneInfo.TabIndex = 18;
            // 
            // IPPingedHistory
            // 
            this.IPPingedHistory.Location = new System.Drawing.Point(442, 44);
            this.IPPingedHistory.Name = "IPPingedHistory";
            this.IPPingedHistory.Size = new System.Drawing.Size(100, 20);
            this.IPPingedHistory.TabIndex = 19;
            this.IPPingedHistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // labelHistoryIP
            // 
            this.labelHistoryIP.AutoSize = true;
            this.labelHistoryIP.Location = new System.Drawing.Point(439, 17);
            this.labelHistoryIP.Name = "labelHistoryIP";
            this.labelHistoryIP.Size = new System.Drawing.Size(50, 13);
            this.labelHistoryIP.TabIndex = 20;
            this.labelHistoryIP.Text = "Adres IP:";
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(327, 17);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(106, 13);
            this.labelHistory.TabIndex = 21;
            this.labelHistory.Text = "Historia Pingowania :";
            // 
            // listPingedDomains
            // 
            this.listPingedDomains.FormattingEnabled = true;
            this.listPingedDomains.Location = new System.Drawing.Point(330, 44);
            this.listPingedDomains.Name = "listPingedDomains";
            this.listPingedDomains.Size = new System.Drawing.Size(103, 95);
            this.listPingedDomains.TabIndex = 22;
            this.listPingedDomains.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // clearListButton
            // 
            this.clearListButton.Location = new System.Drawing.Point(330, 146);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(103, 23);
            this.clearListButton.TabIndex = 23;
            this.clearListButton.Text = "Wyczyść listę";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // listDateDialog
            // 
            this.listDateDialog.FileName = "openFileDialog1";
            this.listDateDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // loadDatesList
            // 
            this.loadDatesList.Location = new System.Drawing.Point(330, 200);
            this.loadDatesList.Name = "loadDatesList";
            this.loadDatesList.Size = new System.Drawing.Size(75, 23);
            this.loadDatesList.TabIndex = 24;
            this.loadDatesList.Text = "Wczytaj";
            this.loadDatesList.UseVisualStyleBackColor = true;
            this.loadDatesList.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelDatesInfo
            // 
            this.labelDatesInfo.AutoSize = true;
            this.labelDatesInfo.Location = new System.Drawing.Point(330, 185);
            this.labelDatesInfo.Name = "labelDatesInfo";
            this.labelDatesInfo.Size = new System.Drawing.Size(153, 13);
            this.labelDatesInfo.TabIndex = 25;
            this.labelDatesInfo.Text = "Wczytaj listę dat i dodaj 2-3 dni";
            // 
            // datesLoaded
            // 
            this.datesLoaded.AutoSize = true;
            this.datesLoaded.Location = new System.Drawing.Point(330, 231);
            this.datesLoaded.Name = "datesLoaded";
            this.datesLoaded.Size = new System.Drawing.Size(92, 13);
            this.datesLoaded.TabIndex = 26;
            this.datesLoaded.Text = "Załadowano dat :";
            // 
            // loadedInfo
            // 
            this.loadedInfo.AutoSize = true;
            this.loadedInfo.Location = new System.Drawing.Point(429, 231);
            this.loadedInfo.Name = "loadedInfo";
            this.loadedInfo.Size = new System.Drawing.Size(0, 13);
            this.loadedInfo.TabIndex = 27;
            // 
            // addDays
            // 
            this.addDays.Location = new System.Drawing.Point(408, 200);
            this.addDays.Name = "addDays";
            this.addDays.Size = new System.Drawing.Size(75, 23);
            this.addDays.TabIndex = 28;
            this.addDays.Text = "Dodaj Dni";
            this.addDays.UseVisualStyleBackColor = true;
            this.addDays.Click += new System.EventHandler(this.addDays_Click);
            // 
            // saveDates
            // 
            this.saveDates.Location = new System.Drawing.Point(490, 200);
            this.saveDates.Name = "saveDates";
            this.saveDates.Size = new System.Drawing.Size(75, 23);
            this.saveDates.TabIndex = 29;
            this.saveDates.Text = "Zapisz";
            this.saveDates.UseVisualStyleBackColor = true;
            this.saveDates.Click += new System.EventHandler(this.saveDates_Click);
            // 
            // savedTo
            // 
            this.savedTo.AutoSize = true;
            this.savedTo.Location = new System.Drawing.Point(333, 248);
            this.savedTo.Name = "savedTo";
            this.savedTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.savedTo.Size = new System.Drawing.Size(0, 13);
            this.savedTo.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 277);
            this.Controls.Add(this.savedTo);
            this.Controls.Add(this.saveDates);
            this.Controls.Add(this.addDays);
            this.Controls.Add(this.loadedInfo);
            this.Controls.Add(this.datesLoaded);
            this.Controls.Add(this.labelDatesInfo);
            this.Controls.Add(this.loadDatesList);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.listPingedDomains);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.labelHistoryIP);
            this.Controls.Add(this.IPPingedHistory);
            this.Controls.Add(this.zapisaneInfo);
            this.Controls.Add(this.domainListPingInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.pingProgress);
            this.Controls.Add(this.spingowanoInfo);
            this.Controls.Add(this.wczytanoInfo);
            this.Controls.Add(this.plikInfo);
            this.Controls.Add(this.pingDomainListButton);
            this.Controls.Add(this.labelLoadedDomainFile);
            this.Controls.Add(this.saveDomainList);
            this.Controls.Add(this.loadDomainListButton);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.pingedIP);
            this.Controls.Add(this.labelDomain);
            this.Controls.Add(this.domainName);
            this.Controls.Add(this.pingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.TextBox domainName;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.TextBox pingedIP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.OpenFileDialog openDomainList;
        private System.Windows.Forms.Button loadDomainListButton;
        private System.Windows.Forms.SaveFileDialog saveDomainListDialog;
        private System.Windows.Forms.Button saveDomainList;
        private System.Windows.Forms.Label labelLoadedDomainFile;
        private System.Windows.Forms.Button pingDomainListButton;
        private System.Windows.Forms.Label plikInfo;
        private System.Windows.Forms.Label wczytanoInfo;
        private System.Windows.Forms.Label spingowanoInfo;
        private System.Windows.Forms.ProgressBar pingProgress;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label domainListPingInfo;
        private System.Windows.Forms.Label zapisaneInfo;
        private System.Windows.Forms.TextBox IPPingedHistory;
        private System.Windows.Forms.Label labelHistoryIP;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.ListBox listPingedDomains;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.OpenFileDialog listDateDialog;
        private System.Windows.Forms.Button loadDatesList;
        private System.Windows.Forms.Label labelDatesInfo;
        private System.Windows.Forms.Label datesLoaded;
        private System.Windows.Forms.Label loadedInfo;
        private System.Windows.Forms.Button addDays;
        private System.Windows.Forms.Button saveDates;
        private System.Windows.Forms.SaveFileDialog saveAddedDates;
        private System.Windows.Forms.Label savedTo;
    }
}

