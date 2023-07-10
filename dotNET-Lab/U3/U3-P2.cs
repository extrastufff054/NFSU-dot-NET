// // Design a windows application to implement Notepad Application using C#.
// using System;
// using System.IO;
// using System.Windows.Forms;

// namespace NotepadApp
// {
//     public class Program : Form
//     {
//         private MenuStrip menuStrip;
//         private ToolStripMenuItem fileMenuItem;
//         private ToolStripMenuItem newMenuItem;
//         private ToolStripMenuItem openMenuItem;
//         private ToolStripMenuItem saveMenuItem;
//         private ToolStripMenuItem exitMenuItem;
//         private ToolStripMenuItem viewMenuItem;
//         private ToolStripMenuItem wordWrapMenuItem;
//         private TableLayoutPanel tableLayoutPanel;
//         private RichTextBox richTextBox;

//         private string currentFilePath;

//         public Program()
//         {
//             menuStrip = new MenuStrip();
//             fileMenuItem = new ToolStripMenuItem("File");
//             newMenuItem = new ToolStripMenuItem("New");
//             openMenuItem = new ToolStripMenuItem("Open");
//             saveMenuItem = new ToolStripMenuItem("Save");
//             exitMenuItem = new ToolStripMenuItem("Exit");
//             viewMenuItem = new ToolStripMenuItem("View");
//             wordWrapMenuItem = new ToolStripMenuItem("Word Wrap");
//             tableLayoutPanel = new TableLayoutPanel();
//             richTextBox = new RichTextBox();

//             fileMenuItem.DropDownItems.Add(newMenuItem);
//             fileMenuItem.DropDownItems.Add(openMenuItem);
//             fileMenuItem.DropDownItems.Add(saveMenuItem);
//             fileMenuItem.DropDownItems.Add(exitMenuItem);

//             viewMenuItem.DropDownItems.Add(wordWrapMenuItem);

//             menuStrip.Items.Add(fileMenuItem);
//             menuStrip.Items.Add(viewMenuItem);

//             newMenuItem.Click += NewMenuItem_Click;
//             openMenuItem.Click += OpenMenuItem_Click;
//             saveMenuItem.Click += SaveMenuItem_Click;
//             exitMenuItem.Click += ExitMenuItem_Click;
//             wordWrapMenuItem.Click += WordWrapMenuItem_Click;

//             tableLayoutPanel.Dock = DockStyle.Fill;
//             tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
//             tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
//             tableLayoutPanel.Controls.Add(richTextBox, 0, 0);

//             Controls.Add(tableLayoutPanel);
//             Controls.Add(menuStrip);
//             Load += Program_Load;
//         }

//         private void Program_Load(object sender, EventArgs e)
//         {
//             Size = new System.Drawing.Size(800, 600); // Set the initial form size
//         }

//         private void NewMenuItem_Click(object sender, EventArgs e)
//         {
//             richTextBox.Clear();
//             currentFilePath = null;
//         }

//         private void OpenMenuItem_Click(object sender, EventArgs e)
//         {
//             OpenFileDialog openFileDialog = new OpenFileDialog();
//             openFileDialog.Filter = "Text Files|*.txt";
//             openFileDialog.Title = "Open File";

//             if (openFileDialog.ShowDialog() == DialogResult.OK)
//             {
//                 currentFilePath = openFileDialog.FileName;
//                 richTextBox.Text = File.ReadAllText(currentFilePath);
//             }
//         }

//         private void SaveMenuItem_Click(object sender, EventArgs e)
//         {
//             if (string.IsNullOrEmpty(currentFilePath))
//             {
//                 SaveFileDialog saveFileDialog = new SaveFileDialog();
//                 saveFileDialog.Filter = "Text Files|*.txt";
//                 saveFileDialog.Title = "Save File";

//                 if (saveFileDialog.ShowDialog() == DialogResult.OK)
//                 {
//                     currentFilePath = saveFileDialog.FileName;
//                 }
//                 else
//                 {
//                     return;
//                 }
//             }

//             File.WriteAllText(currentFilePath, richTextBox.Text);
//         }

//         private void ExitMenuItem_Click(object sender, EventArgs e)
//         {
//             Application.Exit();
//         }

//         private void WordWrapMenuItem_Click(object sender, EventArgs e)
//         {
//             richTextBox.WordWrap = !richTextBox.WordWrap;
//             wordWrapMenuItem.Checked = richTextBox.WordWrap;
//         }

//         [STAThread]
//         public static void Main()
//         {
//             Application.Run(new Program());
//         }
//     }
// }
