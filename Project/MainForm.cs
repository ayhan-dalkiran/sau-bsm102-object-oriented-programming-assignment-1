/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2023-2024 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖÐRENCÝ ADI............: Ayhan Dalkýran
**				ÖÐRENCÝ NUMARASI.......: G221210020
**				DERSÝN ALINDIÐI GRUP...: II. Öðretim C
****************************************************************************/
using System.IO;
using System.Windows.Forms;

namespace Project;

public partial class MainForm : Form {
	public MainForm() {
		InitializeComponent();
	}

	string? OpenFilePath { get; set; } = null;
	//This is not a very ideal way to do this, but it'll have to do for now.
	string? InitialFileExtension { get; set; } = null;
	bool IsFileSaved { get; set; } = true;

	void ReadFileToRtb(string path) {
		if (Path.GetExtension(path) == ".rtf")
			richTextBox.Rtf = File.ReadAllText(path);
		else
			richTextBox.Text = File.ReadAllText(path);
	}
	void WriteFileFromRtb(string path) {
		if (Path.GetExtension(path) == ".rtf")
			File.WriteAllText(path, richTextBox.Rtf!);
		else
			File.WriteAllText(path, richTextBox.Text);
	}

	bool TrySaveFile(string? path = null) {
		//This should only run when the user
		//is trying to use "save file as..."
		if (path != null) {
			WriteFileFromRtb(path);
			ToggleSaveState(true);
			return true;
		}

		if (IsFileSaved)
			return true;

		if (OpenFilePath != null) {
			WriteFileFromRtb(OpenFilePath);
			ToggleSaveState(true);
			return true;
		}

		if (InitialFileExtension is ".txt")
			saveFileDialog.FilterIndex = 1;
		else if (InitialFileExtension is ".rtf")
			saveFileDialog.FilterIndex = 2;
		else if (InitialFileExtension is ".c" or ".cpp" or ".h" or ".cs")
			saveFileDialog.FilterIndex = 3;
		else
			saveFileDialog.FilterIndex = 4;

		saveFileDialog.FileName = $"new{InitialFileExtension}";
		if (saveFileDialog.ShowDialog() == DialogResult.OK) {
			OpenFilePath = saveFileDialog.FileName;
			WriteFileFromRtb(OpenFilePath);
			ToggleSaveState(true);
			return true;
		}

		return false;
	}
	bool TryCloseFile() {
		if (!IsFileSaved) {
			var result = MessageBox.Show("Kaydedilemeyen tüm deðiþiklikler silinecek.",
				"Dosyayý kaydet?",
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Information,
				MessageBoxDefaultButton.Button3);

			if (result == DialogResult.Yes && !TrySaveFile())
				return false;
			else if (result == DialogResult.Cancel)
				return false;
		}

		ToggleUi(false);
		OpenFilePath = null;
		InitialFileExtension = string.Empty;
		return true;
	}
	bool TryOpenFile() {
		if (openFileDialog.ShowDialog() != DialogResult.OK)
			return false;

		if (!TryCloseFile())
			return false;

		OpenFilePath = openFileDialog.FileName;
		ToggleUi(true);
		ReadFileToRtb(OpenFilePath);
		//The line above modifies the save state.
		ToggleSaveState(true);
		return true;
	}

	void ToggleUi(bool toggle) {
		if (toggle == false) {
			richTextBox.Rtf = string.Empty;
			//The line above modifies the save state.
			ToggleSaveState(true);
		}

		saveFileButton.Enabled = toggle;
		saveFileAsButton.Enabled = toggle;
		closeFileButton.Enabled = toggle;

		cutTextButton.Enabled = toggle;
		copyTextButton.Enabled = toggle;
		pasteTextButton.Enabled = toggle;

		setTextColorButton.Enabled = toggle;
		setBackgroundColorButton.Enabled = toggle;
		setFontMenuButton.Enabled = toggle;

		saveFileTool.Enabled = toggle;
		saveFileAsTool.Enabled = toggle;

		cutTextTool.Enabled = toggle;
		copyTextTool.Enabled = toggle;
		pasteTextTool.Enabled = toggle;

		setTextColorTool.Enabled = toggle;
		setBackgroundColorTool.Enabled = toggle;
		setFontTool.Enabled = toggle;

		richTextBox.Enabled = toggle;
	}
	void ToggleSaveState(bool toggle) {
		IsFileSaved = toggle;
		//I could probably get away with checking Rtb's enabled property but whatever.
		if (OpenFilePath == null && InitialFileExtension == null) {
			this.Text = "Metin Düzenleyici";
			return;
		}

		string filePath = OpenFilePath ?? $"new{InitialFileExtension}";
		if (IsFileSaved)
			this.Text = $"Metin Düzenleyici ({filePath})";
		else
			this.Text = $"* Metin Düzenleyici ({filePath})";
	}
}
