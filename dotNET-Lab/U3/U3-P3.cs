// using System;
// using System.Windows.Forms;

// namespace MDIApp
// {
//     public class ParentForm : Form
//     {
//         private MenuStrip menuStrip;
//         private ToolStripMenuItem fileMenuItem;
//         private ToolStripMenuItem openMenuItem;
//         private ToolStripMenuItem closeAllMenuItem;
//         private ToolStripMenuItem exitMenuItem;

//         public ParentForm()
//         {
//             IsMdiContainer = true;
//             Size = new System.Drawing.Size(800, 600); // Set the initial form size

//             menuStrip = new MenuStrip();
//             fileMenuItem = new ToolStripMenuItem("File");
//             openMenuItem = new ToolStripMenuItem("Open");
//             closeAllMenuItem = new ToolStripMenuItem("Close All");
//             exitMenuItem = new ToolStripMenuItem("Exit");

//             fileMenuItem.DropDownItems.Add(openMenuItem);
//             fileMenuItem.DropDownItems.Add(closeAllMenuItem);
//             fileMenuItem.DropDownItems.Add(exitMenuItem);

//             menuStrip.Items.Add(fileMenuItem);

//             openMenuItem.Click += OpenMenuItem_Click;
//             closeAllMenuItem.Click += CloseAllMenuItem_Click;
//             exitMenuItem.Click += ExitMenuItem_Click;

//             Controls.Add(menuStrip);
//         }

//         private void OpenMenuItem_Click(object sender, EventArgs e)
//         {
//             ChildForm childForm = new ChildForm();
//             childForm.MdiParent = this;
//             childForm.Show();
//         }

//         private void CloseAllMenuItem_Click(object sender, EventArgs e)
//         {
//             foreach (Form form in MdiChildren)
//             {
//                 form.Close();
//             }
//         }

//         private void ExitMenuItem_Click(object sender, EventArgs e)
//         {
//             Application.Exit();
//         }

//         [STAThread]
//         public static void Main()
//         {
//             Application.Run(new ParentForm());
//         }
//     }

//     public class ChildForm : Form
//     {
//         private Button showDialogButton;

//         public ChildForm()
//         {
//             Size = new System.Drawing.Size(400, 300); // Set the initial child form size

//             showDialogButton = new Button();
//             showDialogButton.Text = "Show Dialog";
//             showDialogButton.Click += ShowDialogButton_Click;

//             Controls.Add(showDialogButton);
//         }

//         private void ShowDialogButton_Click(object sender, EventArgs e)
//         {
//             using (DialogForm dialog = new DialogForm())
//             {
//                 dialog.ShowDialog();
//             }
//         }
//     }

//     public class DialogForm : Form
//     {
//         private Button closeButton;

//         public DialogForm()
//         {
//             Text = "Dialog Form";
//             Size = new System.Drawing.Size(200, 100);

//             closeButton = new Button();
//             closeButton.Text = "Close";
//             closeButton.Click += CloseButton_Click;

//             Controls.Add(closeButton);
//         }

//         private void CloseButton_Click(object sender, EventArgs e)
//         {
//             Close();
//         }
//     }
// }

// /*When you run the application, you will see the parent form with an increased size and an empty client area. From the "File" menu, you can select the "Open" option to create and display a new child form within the parent form. The child form will have a button labeled "Show Dialog." When you click this button, a modal dialog box labeled "Dialog Form" will appear with a "Close" button. Clicking the "Close" button will close the dialog box.

// The MDI (Multiple Document Interface) design allows you to open multiple child forms within the parent form, and you can switch between them using the window management features provided by the operating system.
// */