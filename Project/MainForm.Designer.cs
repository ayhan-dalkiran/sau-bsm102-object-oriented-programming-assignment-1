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
using System.Drawing;
using System.Windows.Forms;

namespace Project;

partial class MainForm {
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
		this.menuStrip = new MenuStrip();
		this.fileMenu = new ToolStripMenuItem();
		this.newFileMenu = new ToolStripMenuItem();
		this.newTxtFileButton = new ToolStripMenuItem();
		this.newRtfFileButton = new ToolStripMenuItem();
		this.toolStripSeparator1 = new ToolStripSeparator();
		this.newCSourceFileButton = new ToolStripMenuItem();
		this.newCppSourceFileButton = new ToolStripMenuItem();
		this.newCCppHeaderFileButton = new ToolStripMenuItem();
		this.toolStripSeparator2 = new ToolStripSeparator();
		this.newCSharpSourceFileButton = new ToolStripMenuItem();
		this.toolStripSeparator3 = new ToolStripSeparator();
		this.openFileButton = new ToolStripMenuItem();
		this.saveFileButton = new ToolStripMenuItem();
		this.saveFileAsButton = new ToolStripMenuItem();
		this.closeFileButton = new ToolStripMenuItem();
		this.styleMenu = new ToolStripMenuItem();
		this.cutTextButton = new ToolStripMenuItem();
		this.copyTextButton = new ToolStripMenuItem();
		this.pasteTextButton = new ToolStripMenuItem();
		this.settingsMenu = new ToolStripMenuItem();
		this.setTextColorButton = new ToolStripMenuItem();
		this.setBackgroundColorButton = new ToolStripMenuItem();
		this.setFontMenuButton = new ToolStripMenuItem();
		this.toolStrip = new ToolStrip();
		this.saveFileTool = new ToolStripButton();
		this.saveFileAsTool = new ToolStripButton();
		this.toolStripSeparator4 = new ToolStripSeparator();
		this.cutTextTool = new ToolStripButton();
		this.copyTextTool = new ToolStripButton();
		this.pasteTextTool = new ToolStripButton();
		this.toolStripSeparator5 = new ToolStripSeparator();
		this.setTextColorTool = new ToolStripButton();
		this.setBackgroundColorTool = new ToolStripButton();
		this.setFontTool = new ToolStripButton();
		this.richTextBox = new RichTextBox();
		this.openFileDialog = new OpenFileDialog();
		this.saveFileDialog = new SaveFileDialog();
		this.colorDialog = new ColorDialog();
		this.fontDialog = new FontDialog();
		this.contextMenuStrip = new ContextMenuStrip(this.components);
		this.cutToolStrip = new ToolStripMenuItem();
		this.copyToolStrip = new ToolStripMenuItem();
		this.pasteToolStrip = new ToolStripMenuItem();
		this.toolStripSeparator6 = new ToolStripSeparator();
		this.setTextToolStrip = new ToolStripMenuItem();
		this.setBackgroundColorToolStrip = new ToolStripMenuItem();
		this.setFontToolStrip = new ToolStripMenuItem();
		this.menuStrip.SuspendLayout();
		this.toolStrip.SuspendLayout();
		this.contextMenuStrip.SuspendLayout();
		this.SuspendLayout();
		// 
		// menuStrip
		// 
		this.menuStrip.Items.AddRange(new ToolStripItem[] { this.fileMenu, this.styleMenu, this.settingsMenu });
		this.menuStrip.Location = new Point(0, 0);
		this.menuStrip.Name = "menuStrip";
		this.menuStrip.Size = new Size(784, 24);
		this.menuStrip.TabIndex = 0;
		this.menuStrip.Text = "menuStrip1";
		// 
		// fileMenu
		// 
		this.fileMenu.DropDownItems.AddRange(new ToolStripItem[] { this.newFileMenu, this.toolStripSeparator3, this.openFileButton, this.saveFileButton, this.saveFileAsButton, this.closeFileButton });
		this.fileMenu.Name = "fileMenu";
		this.fileMenu.Size = new Size(51, 20);
		this.fileMenu.Text = "Dosya";
		// 
		// newFileMenu
		// 
		this.newFileMenu.DropDownItems.AddRange(new ToolStripItem[] { this.newTxtFileButton, this.newRtfFileButton, this.toolStripSeparator1, this.newCSourceFileButton, this.newCppSourceFileButton, this.newCCppHeaderFileButton, this.toolStripSeparator2, this.newCSharpSourceFileButton });
		this.newFileMenu.Name = "newFileMenu";
		this.newFileMenu.Size = new Size(185, 22);
		this.newFileMenu.Text = "Yeni...";
		// 
		// newTxtFileButton
		// 
		this.newTxtFileButton.Name = "newTxtFileButton";
		this.newTxtFileButton.Size = new Size(216, 22);
		this.newTxtFileButton.Text = "Metin Dosyası (.txt)";
		this.newTxtFileButton.Click += this.e_newFile;
		// 
		// newRtfFileButton
		// 
		this.newRtfFileButton.Name = "newRtfFileButton";
		this.newRtfFileButton.Size = new Size(216, 22);
		this.newRtfFileButton.Text = "Zengin Metin Biçimi (.rtf)";
		this.newRtfFileButton.Click += this.e_newFile;
		// 
		// toolStripSeparator1
		// 
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new Size(213, 6);
		// 
		// newCSourceFileButton
		// 
		this.newCSourceFileButton.Name = "newCSourceFileButton";
		this.newCSourceFileButton.Size = new Size(216, 22);
		this.newCSourceFileButton.Text = "C Kaynak Dosyası (.c)";
		this.newCSourceFileButton.Click += this.e_newFile;
		// 
		// newCppSourceFileButton
		// 
		this.newCppSourceFileButton.Name = "newCppSourceFileButton";
		this.newCppSourceFileButton.Size = new Size(216, 22);
		this.newCppSourceFileButton.Text = "C++ Kaynak Dosyası (.cpp)";
		this.newCppSourceFileButton.Click += this.e_newFile;
		// 
		// newCCppHeaderFileButton
		// 
		this.newCCppHeaderFileButton.Name = "newCCppHeaderFileButton";
		this.newCCppHeaderFileButton.Size = new Size(216, 22);
		this.newCCppHeaderFileButton.Text = "C/C++ Başlık Dosyası (.h)";
		this.newCCppHeaderFileButton.Click += this.e_newFile;
		// 
		// toolStripSeparator2
		// 
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new Size(213, 6);
		// 
		// newCSharpSourceFileButton
		// 
		this.newCSharpSourceFileButton.Name = "newCSharpSourceFileButton";
		this.newCSharpSourceFileButton.Size = new Size(216, 22);
		this.newCSharpSourceFileButton.Text = "C# Kaynak Dosyası (.cs)";
		this.newCSharpSourceFileButton.Click += this.e_newFile;
		// 
		// toolStripSeparator3
		// 
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new Size(182, 6);
		// 
		// openFileButton
		// 
		this.openFileButton.Name = "openFileButton";
		this.openFileButton.Size = new Size(185, 22);
		this.openFileButton.Text = "Dosya Aç";
		this.openFileButton.Click += this.e_openFile;
		// 
		// saveFileButton
		// 
		this.saveFileButton.Enabled = false;
		this.saveFileButton.Name = "saveFileButton";
		this.saveFileButton.Size = new Size(185, 22);
		this.saveFileButton.Text = "Dosyayı Kaydet";
		this.saveFileButton.Click += this.e_saveFile;
		// 
		// saveFileAsButton
		// 
		this.saveFileAsButton.Enabled = false;
		this.saveFileAsButton.Name = "saveFileAsButton";
		this.saveFileAsButton.Size = new Size(185, 22);
		this.saveFileAsButton.Text = "Dosyayı Farklı Kaydet";
		this.saveFileAsButton.Click += this.e_saveFileAs;
		// 
		// closeFileButton
		// 
		this.closeFileButton.Enabled = false;
		this.closeFileButton.Name = "closeFileButton";
		this.closeFileButton.Size = new Size(185, 22);
		this.closeFileButton.Text = "Dosyayı Kapat";
		this.closeFileButton.Click += this.e_closeFile;
		// 
		// styleMenu
		// 
		this.styleMenu.DropDownItems.AddRange(new ToolStripItem[] { this.cutTextButton, this.copyTextButton, this.pasteTextButton });
		this.styleMenu.Name = "styleMenu";
		this.styleMenu.Size = new Size(49, 20);
		this.styleMenu.Text = "Biçim";
		// 
		// cutTextButton
		// 
		this.cutTextButton.Enabled = false;
		this.cutTextButton.Name = "cutTextButton";
		this.cutTextButton.Size = new Size(116, 22);
		this.cutTextButton.Text = "Kes";
		this.cutTextButton.Click += this.e_cutText;
		// 
		// copyTextButton
		// 
		this.copyTextButton.Enabled = false;
		this.copyTextButton.Name = "copyTextButton";
		this.copyTextButton.Size = new Size(116, 22);
		this.copyTextButton.Text = "Kopyala";
		this.copyTextButton.Click += this.e_copyText;
		// 
		// pasteTextButton
		// 
		this.pasteTextButton.Enabled = false;
		this.pasteTextButton.Name = "pasteTextButton";
		this.pasteTextButton.Size = new Size(116, 22);
		this.pasteTextButton.Text = "Yapıştır";
		this.pasteTextButton.Click += this.e_pasteText;
		// 
		// settingsMenu
		// 
		this.settingsMenu.DropDownItems.AddRange(new ToolStripItem[] { this.setTextColorButton, this.setBackgroundColorButton, this.setFontMenuButton });
		this.settingsMenu.Name = "settingsMenu";
		this.settingsMenu.Size = new Size(56, 20);
		this.settingsMenu.Text = "Ayarlar";
		// 
		// setTextColorButton
		// 
		this.setTextColorButton.Enabled = false;
		this.setTextColorButton.Name = "setTextColorButton";
		this.setTextColorButton.Size = new Size(219, 22);
		this.setTextColorButton.Text = "Yazı Rengini Değiştir...";
		this.setTextColorButton.Click += this.e_setTextColor;
		// 
		// setBackgroundColorButton
		// 
		this.setBackgroundColorButton.Enabled = false;
		this.setBackgroundColorButton.Name = "setBackgroundColorButton";
		this.setBackgroundColorButton.Size = new Size(219, 22);
		this.setBackgroundColorButton.Text = "Arka Plan Rengini Değiştir...";
		this.setBackgroundColorButton.Click += this.e_setBackgroundColor;
		// 
		// setFontMenuButton
		// 
		this.setFontMenuButton.Enabled = false;
		this.setFontMenuButton.Name = "setFontMenuButton";
		this.setFontMenuButton.Size = new Size(219, 22);
		this.setFontMenuButton.Text = "Fontu Değiştir...";
		this.setFontMenuButton.Click += this.e_setFont;
		// 
		// toolStrip
		// 
		this.toolStrip.Items.AddRange(new ToolStripItem[] { this.saveFileTool, this.saveFileAsTool, this.toolStripSeparator4, this.cutTextTool, this.copyTextTool, this.pasteTextTool, this.toolStripSeparator5, this.setTextColorTool, this.setBackgroundColorTool, this.setFontTool });
		this.toolStrip.Location = new Point(0, 24);
		this.toolStrip.Name = "toolStrip";
		this.toolStrip.Size = new Size(784, 25);
		this.toolStrip.TabIndex = 2;
		this.toolStrip.Text = "toolStrip1";
		// 
		// saveFileTool
		// 
		this.saveFileTool.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.saveFileTool.Enabled = false;
		this.saveFileTool.Image = (Image)resources.GetObject("saveFileTool.Image");
		this.saveFileTool.ImageTransparentColor = Color.Magenta;
		this.saveFileTool.Name = "saveFileTool";
		this.saveFileTool.Size = new Size(23, 22);
		this.saveFileTool.Text = "Kaydet";
		this.saveFileTool.Click += this.e_saveFile;
		// 
		// saveFileAsTool
		// 
		this.saveFileAsTool.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.saveFileAsTool.Enabled = false;
		this.saveFileAsTool.Image = (Image)resources.GetObject("saveFileAsTool.Image");
		this.saveFileAsTool.ImageTransparentColor = Color.Magenta;
		this.saveFileAsTool.Name = "saveFileAsTool";
		this.saveFileAsTool.Size = new Size(23, 22);
		this.saveFileAsTool.Text = "Farklı Kaydet";
		this.saveFileAsTool.Click += this.e_saveFileAs;
		// 
		// toolStripSeparator4
		// 
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new Size(6, 25);
		// 
		// cutTextTool
		// 
		this.cutTextTool.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.cutTextTool.Enabled = false;
		this.cutTextTool.Image = (Image)resources.GetObject("cutTextTool.Image");
		this.cutTextTool.ImageTransparentColor = Color.Magenta;
		this.cutTextTool.Name = "cutTextTool";
		this.cutTextTool.Size = new Size(23, 22);
		this.cutTextTool.Text = "Kes";
		this.cutTextTool.Click += this.e_cutText;
		// 
		// copyTextTool
		// 
		this.copyTextTool.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.copyTextTool.Enabled = false;
		this.copyTextTool.Image = (Image)resources.GetObject("copyTextTool.Image");
		this.copyTextTool.ImageTransparentColor = Color.Magenta;
		this.copyTextTool.Name = "copyTextTool";
		this.copyTextTool.Size = new Size(23, 22);
		this.copyTextTool.Text = "Kopyala";
		this.copyTextTool.Click += this.e_copyText;
		// 
		// pasteTextTool
		// 
		this.pasteTextTool.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.pasteTextTool.Enabled = false;
		this.pasteTextTool.Image = (Image)resources.GetObject("pasteTextTool.Image");
		this.pasteTextTool.ImageTransparentColor = Color.Magenta;
		this.pasteTextTool.Name = "pasteTextTool";
		this.pasteTextTool.Size = new Size(23, 22);
		this.pasteTextTool.Text = "Yapıştır";
		this.pasteTextTool.Click += this.e_pasteText;
		// 
		// toolStripSeparator5
		// 
		this.toolStripSeparator5.Name = "toolStripSeparator5";
		this.toolStripSeparator5.Size = new Size(6, 25);
		// 
		// setTextColorTool
		// 
		this.setTextColorTool.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.setTextColorTool.Enabled = false;
		this.setTextColorTool.Image = (Image)resources.GetObject("setTextColorTool.Image");
		this.setTextColorTool.ImageTransparentColor = Color.Magenta;
		this.setTextColorTool.Name = "setTextColorTool";
		this.setTextColorTool.Size = new Size(23, 22);
		this.setTextColorTool.Text = "Yazı Rengi";
		this.setTextColorTool.Click += this.e_setTextColor;
		// 
		// setBackgroundColorTool
		// 
		this.setBackgroundColorTool.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.setBackgroundColorTool.Enabled = false;
		this.setBackgroundColorTool.Image = (Image)resources.GetObject("setBackgroundColorTool.Image");
		this.setBackgroundColorTool.ImageTransparentColor = Color.Magenta;
		this.setBackgroundColorTool.Name = "setBackgroundColorTool";
		this.setBackgroundColorTool.Size = new Size(23, 22);
		this.setBackgroundColorTool.Text = "Arka Plan Rengi";
		this.setBackgroundColorTool.Click += this.e_setBackgroundColor;
		// 
		// setFontTool
		// 
		this.setFontTool.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.setFontTool.Enabled = false;
		this.setFontTool.Image = (Image)resources.GetObject("setFontTool.Image");
		this.setFontTool.ImageTransparentColor = Color.Magenta;
		this.setFontTool.Name = "setFontTool";
		this.setFontTool.Size = new Size(23, 22);
		this.setFontTool.Text = "Font";
		this.setFontTool.Click += this.e_setFont;
		// 
		// richTextBox
		// 
		this.richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.richTextBox.ContextMenuStrip = this.contextMenuStrip;
		this.richTextBox.Enabled = false;
		this.richTextBox.Location = new Point(12, 52);
		this.richTextBox.Name = "richTextBox";
		this.richTextBox.Size = new Size(760, 297);
		this.richTextBox.TabIndex = 1;
		this.richTextBox.Text = "";
		this.richTextBox.TextChanged += this.e_textChanged;
		// 
		// openFileDialog
		// 
		this.openFileDialog.Filter = "Tüm Dosyalar (*.*)|*.*";
		this.openFileDialog.RestoreDirectory = true;
		this.openFileDialog.Title = "Dosya Aç";
		// 
		// saveFileDialog
		// 
		this.saveFileDialog.Filter = "Metin Dosyası (*.txt)|*.txt|Zengin Metin Biçimi (*.rtf)|*.rtf|Kod Dosyası (*.c, *.cpp, *.h, *.cs)|*.c;*.cpp;*.h;*.cs|Tüm Dosyalar (*.*)|*.*";
		// 
		// contextMenuStrip
		// 
		this.contextMenuStrip.Items.AddRange(new ToolStripItem[] { this.cutToolStrip, this.copyToolStrip, this.pasteToolStrip, this.toolStripSeparator6, this.setTextToolStrip, this.setBackgroundColorToolStrip, this.setFontToolStrip });
		this.contextMenuStrip.Name = "contextMenuStrip";
		this.contextMenuStrip.Size = new Size(220, 142);
		// 
		// cutToolStrip
		// 
		this.cutToolStrip.Name = "cutToolStrip";
		this.cutToolStrip.Size = new Size(219, 22);
		this.cutToolStrip.Text = "Kes";
		this.cutToolStrip.Click += this.e_cutText;
		// 
		// copyToolStrip
		// 
		this.copyToolStrip.Name = "copyToolStrip";
		this.copyToolStrip.Size = new Size(219, 22);
		this.copyToolStrip.Text = "Kopyala";
		this.copyToolStrip.Click += this.e_copyText;
		// 
		// pasteToolStrip
		// 
		this.pasteToolStrip.Name = "pasteToolStrip";
		this.pasteToolStrip.Size = new Size(219, 22);
		this.pasteToolStrip.Text = "Yapıştır";
		this.pasteToolStrip.Click += this.e_pasteText;
		// 
		// toolStripSeparator6
		// 
		this.toolStripSeparator6.Name = "toolStripSeparator6";
		this.toolStripSeparator6.Size = new Size(216, 6);
		// 
		// setTextToolStrip
		// 
		this.setTextToolStrip.Name = "setTextToolStrip";
		this.setTextToolStrip.Size = new Size(219, 22);
		this.setTextToolStrip.Text = "Yazı Rengini Değiştir...";
		this.setTextToolStrip.Click += this.e_setTextColor;
		// 
		// setBackgroundColorToolStrip
		// 
		this.setBackgroundColorToolStrip.Name = "setBackgroundColorToolStrip";
		this.setBackgroundColorToolStrip.Size = new Size(219, 22);
		this.setBackgroundColorToolStrip.Text = "Arka Plan Rengini Değiştir...";
		this.setBackgroundColorToolStrip.Click += this.e_setBackgroundColor;
		// 
		// setFontToolStrip
		// 
		this.setFontToolStrip.Name = "setFontToolStrip";
		this.setFontToolStrip.Size = new Size(219, 22);
		this.setFontToolStrip.Text = "Fontu Değiştir...";
		this.setFontToolStrip.Click += this.e_setFont;
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new Size(784, 361);
		this.Controls.Add(this.toolStrip);
		this.Controls.Add(this.richTextBox);
		this.Controls.Add(this.menuStrip);
		this.KeyPreview = true;
		this.MainMenuStrip = this.menuStrip;
		this.MinimumSize = new Size(400, 300);
		this.Name = "MainForm";
		this.ShowIcon = false;
		this.Text = "Metin Düzenleyici";
		this.FormClosing += this.e_formClosing;
		this.KeyDown += this.e_KeyDown;
		this.menuStrip.ResumeLayout(false);
		this.menuStrip.PerformLayout();
		this.toolStrip.ResumeLayout(false);
		this.toolStrip.PerformLayout();
		this.contextMenuStrip.ResumeLayout(false);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private MenuStrip menuStrip;
	private ToolStripMenuItem fileMenu;
	private ToolStripMenuItem newFileMenu;
	private ToolStripMenuItem newTxtFileButton;
	private ToolStripSeparator toolStripSeparator1;
	private ToolStripMenuItem newCSourceFileButton;
	private ToolStripMenuItem newCppSourceFileButton;
	private ToolStripMenuItem newCCppHeaderFileButton;
	private ToolStripSeparator toolStripSeparator2;
	private ToolStripMenuItem newCSharpSourceFileButton;
	private ToolStripSeparator toolStripSeparator3;
	private ToolStripMenuItem openFileButton;
	private ToolStripMenuItem saveFileButton;
	private ToolStripMenuItem saveFileAsButton;
	private ToolStripMenuItem closeFileButton;
	private ToolStripMenuItem styleMenu;
	private ToolStripMenuItem cutTextButton;
	private ToolStripMenuItem copyTextButton;
	private ToolStripMenuItem pasteTextButton;
	private ToolStripMenuItem settingsMenu;
	private ToolStripMenuItem setTextColorButton;
	private ToolStripMenuItem setBackgroundColorButton;
	private ToolStrip toolStrip;
	private ToolStripButton saveFileTool;
	private ToolStripSeparator toolStripSeparator4;
	private ToolStripButton cutTextTool;
	private ToolStripButton copyTextTool;
	private ToolStripButton pasteTextTool;
	private ToolStripSeparator toolStripSeparator5;
	private ToolStripButton setTextColorTool;
	private ToolStripButton setBackgroundColorTool;
	private RichTextBox richTextBox;
	private OpenFileDialog openFileDialog;
	private SaveFileDialog saveFileDialog;
	private ColorDialog colorDialog;
	private FontDialog fontDialog;
	private ToolStripButton setFontTool;
	private ToolStripMenuItem setFontMenuButton;
	private ToolStripMenuItem newRtfFileButton;
	private ToolStripButton saveFileAsTool;
	private ContextMenuStrip contextMenuStrip;
	private ToolStripMenuItem cutToolStrip;
	private ToolStripMenuItem copyToolStrip;
	private ToolStripMenuItem pasteToolStrip;
	private ToolStripSeparator toolStripSeparator6;
	private ToolStripMenuItem setTextToolStrip;
	private ToolStripMenuItem setBackgroundColorToolStrip;
	private ToolStripMenuItem setFontToolStrip;
}
