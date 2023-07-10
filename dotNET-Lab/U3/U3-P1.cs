// // Design a C# code to create Form Base Windows Application 
// using System;
// using System.Windows.Forms;

// namespace WindowsFormsApp
// {
//     public class Program : Form
//     {
//         private Button clickMeButton;

//         public Program()
//         {
//             clickMeButton = new Button();
//             clickMeButton.Text = "Click Me";
//             clickMeButton.Click += ClickMeButton_Click;

//             Controls.Add(clickMeButton);
//         }

//         private void ClickMeButton_Click(object sender, EventArgs e)
//         {
//             MessageBox.Show("Button Clicked!");
//         }

//         [STAThread]
//         public static void Main()
//         {
//             Application.Run(new Program());
//         }
//     }
// }
