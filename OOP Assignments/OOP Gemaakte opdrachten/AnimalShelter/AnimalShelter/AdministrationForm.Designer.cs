namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBadHabbits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownRegistrationNumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownBirthDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBirthMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBirthYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLastWalkDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLastWalkMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLastWalkYear = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDownShowChipNumber = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.buttonSetToReserved = new System.Windows.Forms.Button();
            this.buttonSetToUnreserved = new System.Windows.Forms.Button();
            this.sortChipIdButton = new System.Windows.Forms.Button();
            this.buttonShowAllBadHabbitsAndWalkDates = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastWalkDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastWalkMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastWalkYear)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShowChipNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalTypeComboBox.TabIndex = 0;
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(139, 10);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(466, 321);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(145, 210);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(153, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chip Registration Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // textBoxBadHabbits
            // 
            this.textBoxBadHabbits.Location = new System.Drawing.Point(398, 250);
            this.textBoxBadHabbits.Name = "textBoxBadHabbits";
            this.textBoxBadHabbits.Size = new System.Drawing.Size(153, 20);
            this.textBoxBadHabbits.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bad Habbits";
            // 
            // numericUpDownRegistrationNumber
            // 
            this.numericUpDownRegistrationNumber.Location = new System.Drawing.Point(145, 158);
            this.numericUpDownRegistrationNumber.Name = "numericUpDownRegistrationNumber";
            this.numericUpDownRegistrationNumber.Size = new System.Drawing.Size(153, 20);
            this.numericUpDownRegistrationNumber.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Last Walk Date";
            // 
            // numericUpDownBirthDay
            // 
            this.numericUpDownBirthDay.Location = new System.Drawing.Point(145, 184);
            this.numericUpDownBirthDay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownBirthDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBirthDay.Name = "numericUpDownBirthDay";
            this.numericUpDownBirthDay.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownBirthDay.TabIndex = 16;
            this.numericUpDownBirthDay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownBirthMonth
            // 
            this.numericUpDownBirthMonth.Location = new System.Drawing.Point(212, 184);
            this.numericUpDownBirthMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownBirthMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBirthMonth.Name = "numericUpDownBirthMonth";
            this.numericUpDownBirthMonth.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownBirthMonth.TabIndex = 17;
            this.numericUpDownBirthMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBirthYear
            // 
            this.numericUpDownBirthYear.Location = new System.Drawing.Point(279, 184);
            this.numericUpDownBirthYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericUpDownBirthYear.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numericUpDownBirthYear.Name = "numericUpDownBirthYear";
            this.numericUpDownBirthYear.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownBirthYear.TabIndex = 18;
            this.numericUpDownBirthYear.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // numericUpDownLastWalkDay
            // 
            this.numericUpDownLastWalkDay.Location = new System.Drawing.Point(110, 251);
            this.numericUpDownLastWalkDay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownLastWalkDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLastWalkDay.Name = "numericUpDownLastWalkDay";
            this.numericUpDownLastWalkDay.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownLastWalkDay.TabIndex = 19;
            this.numericUpDownLastWalkDay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownLastWalkMonth
            // 
            this.numericUpDownLastWalkMonth.Location = new System.Drawing.Point(177, 251);
            this.numericUpDownLastWalkMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownLastWalkMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLastWalkMonth.Name = "numericUpDownLastWalkMonth";
            this.numericUpDownLastWalkMonth.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownLastWalkMonth.TabIndex = 20;
            this.numericUpDownLastWalkMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownLastWalkYear
            // 
            this.numericUpDownLastWalkYear.Location = new System.Drawing.Point(244, 251);
            this.numericUpDownLastWalkYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericUpDownLastWalkYear.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numericUpDownLastWalkYear.Name = "numericUpDownLastWalkYear";
            this.numericUpDownLastWalkYear.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownLastWalkYear.TabIndex = 21;
            this.numericUpDownLastWalkYear.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(63, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 127);
            this.panel1.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(391, 121);
            this.listBox1.TabIndex = 0;
            // 
            // numericUpDownShowChipNumber
            // 
            this.numericUpDownShowChipNumber.Location = new System.Drawing.Point(463, 363);
            this.numericUpDownShowChipNumber.Name = "numericUpDownShowChipNumber";
            this.numericUpDownShowChipNumber.Size = new System.Drawing.Size(153, 20);
            this.numericUpDownShowChipNumber.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Chip Registration Number";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(63, 454);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(391, 121);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(466, 389);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(322, 108);
            this.listBox3.TabIndex = 25;
            // 
            // buttonSetToReserved
            // 
            this.buttonSetToReserved.Location = new System.Drawing.Point(63, 295);
            this.buttonSetToReserved.Name = "buttonSetToReserved";
            this.buttonSetToReserved.Size = new System.Drawing.Size(140, 23);
            this.buttonSetToReserved.TabIndex = 26;
            this.buttonSetToReserved.Text = "Set To Reserved";
            this.buttonSetToReserved.UseVisualStyleBackColor = true;
            this.buttonSetToReserved.Click += new System.EventHandler(this.buttonSetToReserved_Click);
            // 
            // buttonSetToUnreserved
            // 
            this.buttonSetToUnreserved.Location = new System.Drawing.Point(317, 295);
            this.buttonSetToUnreserved.Name = "buttonSetToUnreserved";
            this.buttonSetToUnreserved.Size = new System.Drawing.Size(140, 23);
            this.buttonSetToUnreserved.TabIndex = 27;
            this.buttonSetToUnreserved.Text = "Set To Not Reserved";
            this.buttonSetToUnreserved.UseVisualStyleBackColor = true;
            this.buttonSetToUnreserved.Click += new System.EventHandler(this.buttonSetToUnreserved_Click);
            // 
            // sortChipIdButton
            // 
            this.sortChipIdButton.Location = new System.Drawing.Point(466, 536);
            this.sortChipIdButton.Name = "sortChipIdButton";
            this.sortChipIdButton.Size = new System.Drawing.Size(119, 39);
            this.sortChipIdButton.TabIndex = 28;
            this.sortChipIdButton.Text = "Sort Chip Ids";
            this.sortChipIdButton.UseVisualStyleBackColor = true;
            this.sortChipIdButton.Click += new System.EventHandler(this.sortChipIdButton_Click);
            // 
            // buttonShowAllBadHabbitsAndWalkDates
            // 
            this.buttonShowAllBadHabbitsAndWalkDates.Location = new System.Drawing.Point(471, 41);
            this.buttonShowAllBadHabbitsAndWalkDates.Name = "buttonShowAllBadHabbitsAndWalkDates";
            this.buttonShowAllBadHabbitsAndWalkDates.Size = new System.Drawing.Size(119, 39);
            this.buttonShowAllBadHabbitsAndWalkDates.TabIndex = 29;
            this.buttonShowAllBadHabbitsAndWalkDates.Text = "Show all walkdates and badhabbits";
            this.buttonShowAllBadHabbitsAndWalkDates.UseVisualStyleBackColor = true;
            this.buttonShowAllBadHabbitsAndWalkDates.Click += new System.EventHandler(this.buttonShowAllBadHabbitsAndWalkDates_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(607, 41);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(197, 277);
            this.listBox4.TabIndex = 30;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(471, 86);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(119, 39);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(471, 131);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(119, 39);
            this.buttonLoad.TabIndex = 32;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(471, 176);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(119, 39);
            this.buttonExtract.TabIndex = 33;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 617);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.buttonShowAllBadHabbitsAndWalkDates);
            this.Controls.Add(this.sortChipIdButton);
            this.Controls.Add(this.buttonSetToUnreserved);
            this.Controls.Add(this.buttonSetToReserved);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownShowChipNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDownLastWalkYear);
            this.Controls.Add(this.numericUpDownLastWalkMonth);
            this.Controls.Add(this.numericUpDownLastWalkDay);
            this.Controls.Add(this.numericUpDownBirthYear);
            this.Controls.Add(this.numericUpDownBirthMonth);
            this.Controls.Add(this.numericUpDownBirthDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownRegistrationNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBadHabbits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastWalkDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastWalkMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLastWalkYear)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShowChipNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBadHabbits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownRegistrationNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownBirthDay;
        private System.Windows.Forms.NumericUpDown numericUpDownBirthMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownBirthYear;
        private System.Windows.Forms.NumericUpDown numericUpDownLastWalkDay;
        private System.Windows.Forms.NumericUpDown numericUpDownLastWalkMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownLastWalkYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownShowChipNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button buttonSetToReserved;
        private System.Windows.Forms.Button buttonSetToUnreserved;
        private System.Windows.Forms.Button sortChipIdButton;
        private System.Windows.Forms.Button buttonShowAllBadHabbitsAndWalkDates;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonExtract;
    }
}

