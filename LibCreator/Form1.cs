using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibCreator {
	public partial class Form1 : Form {
		string path;
		string name;
		string source;
		string savePath;

		public Form1() {
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e) {
			string template = $@"package = ""{nameL.Text}""
version = ""{versionL.Text}""
source = {{
	url = ""{sourceL.Text}""
}}
description = {{
	summary = ""{summaryL.Text}"",
	detailed = [[
		{detailedL.Text}
	]],
	license = ""{licenseL.Text}"",
	homepage = ""{homepageL.Text}""
}}
dependencies = {{
	""{dependenciesL.Text}""
}}
build = {{
	type = ""builtin"",
	modules = {{
		{nameL.Text} = {{
			sources = {{
				""{source}""
			}}
		}}
	}}
}}";

			if(savePath != null) {
				System.IO.File.WriteAllText(savePath, template);

				string cmd = $@"{Directory.GetDirectoryRoot(savePath).Remove(2)} && cd {path} && luarocks make {nameL.Text}-{versionL.Text}.rockspec";

				var proc = new ProcessStartInfo() {
					UseShellExecute = true,
					WorkingDirectory = @"C:\Windows\System32",
					FileName = @"C:\Windows\System32\cmd.exe",
					Arguments = "/c" + cmd,
					//WindowStyle = ProcessWindowStyle.Hidden // TODOFIX: cath error Luarocks or minGW
				};
				Process.Start(proc);
				MessageBox.Show("Build");
			}
			else {
				MessageBox.Show("Select DLL file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			if (openFile.ShowDialog() == DialogResult.Cancel) return;

			string filename = openFile.FileName;

			string extension = Path.GetExtension(filename);

			if (String.Equals(extension, ".c") || String.Equals(extension, ".C")) {
				source = openFile.SafeFileName;
				name = Path.GetFileNameWithoutExtension(openFile.FileName);
				path = openFile.FileName.Remove((openFile.FileName.IndexOf(openFile.SafeFileName)));
				savePath = $"{path}{name}-{versionL.Text}.rockspec";
				nameL.Text = name;
				MessageBox.Show("File opened");
				Button1.Enabled = true;
			}
			else {
				MessageBox.Show("Only C", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
		}
	}
}
