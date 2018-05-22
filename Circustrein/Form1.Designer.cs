namespace Circustrein
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbSoort = new System.Windows.Forms.GroupBox();
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.chFormaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEetSoort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lvWagon = new System.Windows.Forms.ListView();
            this.chPointsBenut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnimals = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblAantal = new System.Windows.Forms.Label();
            this.numAmountOfAnimals = new System.Windows.Forms.NumericUpDown();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.gbSize.SuspendLayout();
            this.gbSoort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountOfAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.cbSize);
            this.gbSize.Location = new System.Drawing.Point(12, 201);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(80, 108);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Formaat";
            // 
            // gbSoort
            // 
            this.gbSoort.Controls.Add(this.cbFood);
            this.gbSoort.Location = new System.Drawing.Point(122, 201);
            this.gbSoort.Name = "gbSoort";
            this.gbSoort.Size = new System.Drawing.Size(75, 108);
            this.gbSoort.TabIndex = 1;
            this.gbSoort.TabStop = false;
            this.gbSoort.Text = "Eetsoort";
            // 
            // lvAnimals
            // 
            this.lvAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFormaat,
            this.chEetSoort,
            this.chPoints});
            this.lvAnimals.Location = new System.Drawing.Point(12, 13);
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Size = new System.Drawing.Size(277, 182);
            this.lvAnimals.TabIndex = 2;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.View = System.Windows.Forms.View.Details;
            // 
            // chFormaat
            // 
            this.chFormaat.Text = "Formaat";
            this.chFormaat.Width = 121;
            // 
            // chEetSoort
            // 
            this.chEetSoort.Text = "EetSoort";
            this.chEetSoort.Width = 92;
            // 
            // chPoints
            // 
            this.chPoints.Text = "Punten";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(18, 329);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnimal.TabIndex = 3;
            this.btnAddAnimal.Text = "Toevoegen";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(214, 329);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Berekenen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lvWagon
            // 
            this.lvWagon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPointsBenut,
            this.chAnimals});
            this.lvWagon.Location = new System.Drawing.Point(13, 13);
            this.lvWagon.Name = "lvWagon";
            this.lvWagon.Size = new System.Drawing.Size(276, 182);
            this.lvWagon.TabIndex = 5;
            this.lvWagon.UseCompatibleStateImageBehavior = false;
            this.lvWagon.View = System.Windows.Forms.View.Details;
            // 
            // chPointsBenut
            // 
            this.chPointsBenut.Text = "Points";
            // 
            // chAnimals
            // 
            this.chAnimals.Text = "Animals";
            this.chAnimals.Width = 200;
            // 
            // LblAantal
            // 
            this.LblAantal.AutoSize = true;
            this.LblAantal.Location = new System.Drawing.Point(203, 235);
            this.LblAantal.Name = "LblAantal";
            this.LblAantal.Size = new System.Drawing.Size(37, 13);
            this.LblAantal.TabIndex = 7;
            this.LblAantal.Text = "Aantal";
            // 
            // numAmountOfAnimals
            // 
            this.numAmountOfAnimals.Location = new System.Drawing.Point(204, 252);
            this.numAmountOfAnimals.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAmountOfAnimals.Name = "numAmountOfAnimals";
            this.numAmountOfAnimals.Size = new System.Drawing.Size(85, 20);
            this.numAmountOfAnimals.TabIndex = 8;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(5, 34);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(69, 21);
            this.cbSize.TabIndex = 3;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(6, 34);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(63, 21);
            this.cbFood.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(304, 376);
            this.Controls.Add(this.numAmountOfAnimals);
            this.Controls.Add(this.LblAantal);
            this.Controls.Add(this.lvWagon);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.lvAnimals);
            this.Controls.Add(this.gbSoort);
            this.Controls.Add(this.gbSize);
            this.Name = "Form1";
            this.Text = "Circustrein";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSoort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAmountOfAnimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbSoort;
        private System.Windows.Forms.ListView lvAnimals;
        private System.Windows.Forms.ColumnHeader chFormaat;
        private System.Windows.Forms.ColumnHeader chEetSoort;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ColumnHeader chPoints;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListView lvWagon;
        private System.Windows.Forms.ColumnHeader chPointsBenut;
        private System.Windows.Forms.ColumnHeader chAnimals;
        private System.Windows.Forms.Label LblAantal;
        private System.Windows.Forms.NumericUpDown numAmountOfAnimals;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbFood;
    }
}

