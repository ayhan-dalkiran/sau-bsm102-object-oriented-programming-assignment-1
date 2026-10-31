/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Ayhan Dalkıran
**				ÖĞRENCİ NUMARASI.......: G221210020
**				DERSİN ALINDIĞI GRUP...: II. Öğretim C
****************************************************************************/
using System;
using System.Windows.Forms;

namespace Project;

public partial class MainForm : Form {
	//Create File
	void e_newFile(object sender, EventArgs e) {
		if (!TryCloseFile())
			return;

		if (sender == newTxtFileButton) {
			richTextBox.Text = string.Empty;
			InitialFileExtension = ".txt";
		}
		else if (sender == newRtfFileButton) {
			richTextBox.Rtf = string.Empty;
			InitialFileExtension = ".rtf";
		}
		else if (sender == newCSourceFileButton) {
			richTextBox.Text = """
				#include <stdio.h>

				int main()
				{
				    printf("Hello World");

				    return 0;
				}
				""";
			InitialFileExtension = ".c";
		}
		else if (sender == newCppSourceFileButton) {
			richTextBox.Text = """
				#include <iostream>

				int main()
				{
				    std::cout << "Hello World";

				    return 0;
				}
				""";
			InitialFileExtension = ".cpp";
		}
		else if (sender == newCCppHeaderFileButton) {
			richTextBox.Text = """
				#ifndef HEADER_GUARD
				#define HEADER_GUARD
				
				#endif //HEADER_GUARD
				""";
			InitialFileExtension = ".h";
		}
		else if (sender == newCSharpSourceFileButton) {
			richTextBox.Text = """
				namespace CSharpFile;

				internal class Program {
				    static void Main(string[] args) {
				        Console.WriteLine("Hello, World!");
				    }
				}
				""";
			InitialFileExtension = ".cs";
		}

		ToggleUi(true);
		ToggleSaveState(false);
	}

	//File Action Events
	void e_openFile(object sender, EventArgs e) => TryOpenFile();
	void e_saveFile(object sender, EventArgs e) => TrySaveFile();
	void e_saveFileAs(object sender, EventArgs e) {
		saveFileDialog.FileName = string.Empty;
		if (saveFileDialog.ShowDialog() != DialogResult.OK)
			return;

		TrySaveFile(saveFileDialog.FileName);
	}
	void e_closeFile(object sender, EventArgs e) => TryCloseFile();

	//Text Action Events
	void e_cutText(object sender, EventArgs e) => richTextBox.Cut();
	void e_copyText(object sender, EventArgs e) => richTextBox.Copy();
	void e_pasteText(object sender, EventArgs e) => richTextBox.Paste();

	//Text Style Events
	void e_setTextColor(object sender, EventArgs e) {
		if (colorDialog.ShowDialog() != DialogResult.OK)
			return;

		richTextBox.SelectionColor = colorDialog.Color;
	}
	void e_setBackgroundColor(object sender, EventArgs e) {
		if (colorDialog.ShowDialog() != DialogResult.OK)
			return;

		richTextBox.SelectionBackColor = colorDialog.Color;
	}
	void e_setFont(object sender, EventArgs e) {
		if (fontDialog.ShowDialog() != DialogResult.OK)
			return;

		richTextBox.SelectionFont = fontDialog.Font;
	}

	void e_formClosing(object sender, FormClosingEventArgs e) {
		if (!TryCloseFile())
			e.Cancel = true;
	}

	void e_textChanged(object sender, EventArgs e) => ToggleSaveState(false);

	void e_KeyDown(object sender, KeyEventArgs e) {
		if (e.Modifiers == Keys.Control)
			if (e.KeyCode == Keys.S)
				TrySaveFile();
	}
}
