namespace LibCreator
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Button1 = new System.Windows.Forms.Button();
			this.dependenciesL = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.sourceL = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.homepageL = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.licenseL = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.detailedL = new System.Windows.Forms.TextBox();
			this.summaryL = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.versionL = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.nameL = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Button1
			// 
			this.Button1.Enabled = false;
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.Button1.Location = new System.Drawing.Point(185, 504);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(162, 32);
			this.Button1.TabIndex = 20;
			this.Button1.Text = "Build lib";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// dependenciesL
			// 
			this.dependenciesL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.dependenciesL.Location = new System.Drawing.Point(131, 468);
			this.dependenciesL.Name = "dependenciesL";
			this.dependenciesL.Size = new System.Drawing.Size(216, 23);
			this.dependenciesL.TabIndex = 19;
			this.dependenciesL.Text = "lua >= 5.1";
			// 
			// Label8
			// 
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.Label8.Location = new System.Drawing.Point(13, 468);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(106, 18);
			this.Label8.TabIndex = 18;
			this.Label8.Text = "Dependencies:";
			// 
			// sourceL
			// 
			this.sourceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.sourceL.Location = new System.Drawing.Point(131, 43);
			this.sourceL.Name = "sourceL";
			this.sourceL.Size = new System.Drawing.Size(216, 23);
			this.sourceL.TabIndex = 16;
			this.sourceL.Text = "git://github.com/";
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.homepageL);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.licenseL);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.detailedL);
			this.GroupBox1.Controls.Add(this.summaryL);
			this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.GroupBox1.Location = new System.Drawing.Point(13, 112);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(334, 344);
			this.GroupBox1.TabIndex = 15;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Description:";
			// 
			// homepageL
			// 
			this.homepageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.homepageL.Location = new System.Drawing.Point(9, 307);
			this.homepageL.Name = "homepageL";
			this.homepageL.Size = new System.Drawing.Size(319, 23);
			this.homepageL.TabIndex = 10;
			this.homepageL.Text = "http://";
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.Label6.Location = new System.Drawing.Point(6, 286);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(85, 18);
			this.Label6.TabIndex = 9;
			this.Label6.Text = "Homepage:";
			// 
			// licenseL
			// 
			this.licenseL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.licenseL.Location = new System.Drawing.Point(9, 250);
			this.licenseL.Name = "licenseL";
			this.licenseL.Size = new System.Drawing.Size(319, 23);
			this.licenseL.TabIndex = 8;
			this.licenseL.Text = "GNU";
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.Label5.Location = new System.Drawing.Point(6, 229);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(63, 18);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "License:";
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.Label4.Location = new System.Drawing.Point(6, 93);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(65, 18);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Detailed:";
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.Label3.Location = new System.Drawing.Point(6, 33);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(76, 18);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Summary:";
			// 
			// detailedL
			// 
			this.detailedL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.detailedL.Location = new System.Drawing.Point(9, 114);
			this.detailedL.Multiline = true;
			this.detailedL.Name = "detailedL";
			this.detailedL.Size = new System.Drawing.Size(319, 103);
			this.detailedL.TabIndex = 0;
			this.detailedL.Text = "This my Lua module written in C.";
			// 
			// summaryL
			// 
			this.summaryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.summaryL.Location = new System.Drawing.Point(9, 54);
			this.summaryL.Name = "summaryL";
			this.summaryL.Size = new System.Drawing.Size(319, 23);
			this.summaryL.TabIndex = 1;
			this.summaryL.Text = "A C module for Lua.";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.Label2.Location = new System.Drawing.Point(13, 43);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(84, 18);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "Source, url:";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.Label1.Location = new System.Drawing.Point(13, 12);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(112, 18);
			this.Label1.TabIndex = 13;
			this.Label1.Text = "Name package:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(13, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 18);
			this.label7.TabIndex = 21;
			this.label7.Text = "Version:";
			// 
			// versionL
			// 
			this.versionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.versionL.Location = new System.Drawing.Point(131, 77);
			this.versionL.Name = "versionL";
			this.versionL.Size = new System.Drawing.Size(216, 23);
			this.versionL.TabIndex = 22;
			this.versionL.Text = "scm-1";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(13, 504);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(162, 32);
			this.button2.TabIndex = 23;
			this.button2.Text = "Select DLL";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// openFile
			// 
			this.openFile.FileName = "openFileDialog1";
			// 
			// nameL
			// 
			this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.nameL.Location = new System.Drawing.Point(131, 12);
			this.nameL.Name = "nameL";
			this.nameL.Size = new System.Drawing.Size(216, 23);
			this.nameL.TabIndex = 24;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 549);
			this.Controls.Add(this.nameL);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.versionL);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.dependenciesL);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.sourceL);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "DLL lib creator";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox dependenciesL;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox sourceL;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox homepageL;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox licenseL;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox detailedL;
		internal System.Windows.Forms.TextBox summaryL;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label label7;
		internal System.Windows.Forms.TextBox versionL;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFile;
		internal System.Windows.Forms.TextBox nameL;
	}
}

