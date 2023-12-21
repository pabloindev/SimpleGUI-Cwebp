using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//https://developers.google.com/speed/webp/docs/using
//https://developers.google.com/speed/webp/docs/cwebp

namespace SimpleGUI_Cwebp
{
    public partial class FormMain : Form
    {
        List<string> ListPathFile = new List<string>();
        List<string> ListOptions = new List<string>();
        List<string> Commands = new List<string>();
        static string folder_name_cwebp = ConfigurationManager.AppSettings["folder_name_cwebp"].ToString();
        static string working_dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        static string path_cwebp = System.IO.Path.Combine(working_dir, folder_name_cwebp, "bin", "cwebp.exe");

        public FormMain()
        {
            InitializeComponent();
            lbOptions.Text = "CWebp Options: ";
            lbOptions.Text += "-m 6 "; //Specify the compression method to use
            lbOptions.Text += "-q 75 "; // Specify the compression factor for RGB channels between 0 and 100. The default is 75.
            lbOptions.Text += "-mt "; //Use multi-threading for encoding, if possible.
            lbOptions.Text += "-af "; // Turns auto-filter on. This algorithm will spend additional time optimizing the filtering strength to reach a well-balanced quality.
            lbOptions.Text += "-progress "; //Report encoding progress in percent.
        }

        private void textBoxResize_TextChanged(object sender, EventArgs e)
        {
            if( !string.IsNullOrEmpty(textBoxResize.Text) )
            {
                comboBoxWidthOrHeight.Enabled = true;
            }
            else
            {
                comboBoxWidthOrHeight.Enabled = false;
            }
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
            //    e.Effect = DragDropEffects.Copy;
            //e.Effect = DragDropEffects.Move;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null)
            {
                e.Effect = DragDropEffects.Copy;
            }
            
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if(files != null)
            {
                foreach (string file in files)
                {
                    textBoxFiles.Text += file + Environment.NewLine;
                }
            }
        }

        private void linkLabelOpenFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { 
                Multiselect = true, 
                Title = "Select Img", 
                Filter = "Images (*.PNG;*.JPG;)|*.PNG;*.JPG;" //+ "All files (*.*)|*.*"
                })
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    
                    foreach (string file in dialog.FileNames)
                    {
                        textBoxFiles.Text += file + Environment.NewLine;
                    }
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ListPathFile = new List<string>();
            Commands = new List<string>();
            ListOptions = new List<string>() { "-m 6", "-q 75", "-mt", "-af", "-progress" };


            
            int quality = Convert.ToInt32(numericQuality.Value);
            var px_resize_is_integer = int.TryParse(textBoxResize.Text.Trim(), out int px_resize);
            string width_or_height = (comboBoxWidthOrHeight.SelectedItem == null ? "" : comboBoxWidthOrHeight.SelectedItem.ToString());


            ListOptions[1] = "-q " + quality;


            if (!string.IsNullOrWhiteSpace(textBoxResize.Text))
            {
                if (!px_resize_is_integer)
                {
                    MessageBox.Show(textBoxResize.Text + " is not a valid value - please insert an integer value > 0");
                    return;
                }
                else
                {
                    if (width_or_height != "Width" && width_or_height != "Height")
                    {
                        MessageBox.Show("Please select base dimension to resize");
                        return;
                    }
                }

                ListOptions.Add("-resize " + (width_or_height == "Width" ? px_resize.ToString() : "0") + " " + (width_or_height == "Height" ? px_resize.ToString() : "0"));
            }


            foreach (string pathfile in Regex.Split(textBoxFiles.Text, "[\r\n]+"))
            {
                if (!System.IO.File.Exists(pathfile))
                    continue;
                else if(isImage(pathfile))
                    ListPathFile.Add(pathfile);
            }


            //build commands
            foreach (string s in ListPathFile)
            {
                string comando = "\"" + path_cwebp + "\" ";
                foreach(string o in ListOptions)
                {
                    comando += o + " ";
                }
                comando += "\"" + s + "\"" + " -o " + "\"" + (System.IO.Path.Combine(Directory.GetParent(s).FullName,Path.GetFileNameWithoutExtension(s))) + ".webp\"";
                Commands.Add(comando);
            }


            System.IO.File.WriteAllLines(System.IO.Path.Combine(working_dir, "commands.bat"), Commands);




            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C commands.bat";
            process.StartInfo.UseShellExecute = true;
            //process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            //StreamReader reader = process.StandardOutput;
            //string output = reader.ReadToEnd();
            process.WaitForExit();
            MessageBox.Show("Done");
            textBoxFiles.Text = "";
            return;








            //var process = new Process();
            //var startinfo = new ProcessStartInfo("cmd.exe", @"/C commands.bat");
            //startinfo.RedirectStandardOutput = true;
            //startinfo.WorkingDirectory = working_dir;
            //startinfo.UseShellExecute = false;
            //process.StartInfo = startinfo;
            //process.OutputDataReceived += (sender_x, args) => Console.WriteLine(args.Data); // do whatever processing you need to do in this handler
            //process.Start();
            //process.BeginOutputReadLine();
            //process.WaitForExit();
            //MessageBox.Show("Done");
            //return;





            //Process p = new Process();
            //// Redirect the output stream of the child process.
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.FileName = "cmd.exe";
            //p.StartInfo.Arguments = @"/C commands.bat";
            //p.StartInfo.WorkingDirectory = working_dir;
            //p.Start();
            //// Do not wait for the child process to exit before
            //// reading to the end of its redirected stream.
            //// p.WaitForExit();
            //// Read the output stream first and then wait.
            //string output = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();
            //MessageBox.Show("Done");
            //return;


            //var process = new Process();
            //var psi = new ProcessStartInfo();
            //psi.FileName = "cmd.exe";
            //psi.RedirectStandardInput = true;
            //psi.RedirectStandardOutput = true;
            //psi.RedirectStandardError = true;
            //psi.UseShellExecute = false;
            //psi.WorkingDirectory = working_dir;
            //process.StartInfo = psi;
            //process.Start();
            ////process.OutputDataReceived += (sender_x, e_x) => { AddText(e_x.Data); };
            ////process.ErrorDataReceived += (sender_x, e_x) => { AddText(e_x.Data); };
            //process.OutputDataReceived += (sender_x, e_x) => { Console.WriteLine(e_x.Data); };
            //process.ErrorDataReceived += (sender_x, e_x) => { Console.WriteLine(e_x.Data); };
            //process.BeginOutputReadLine();
            //process.BeginErrorReadLine();
            //using (StreamWriter sw = process.StandardInput)
            //{
            //    foreach (var cmd in Commands)
            //    {
            //        sw.WriteLine(cmd);
            //    }
            //}
            //process.WaitForExit();
            ////FormOutput f = new FormOutput(Commands);
            ////f.ShowDialog();
            //MessageBox.Show("Done");


        }


        private static bool isImage(string pathfile)
        {
            pathfile = pathfile.ToLower();
            if (pathfile.EndsWith(".png") || pathfile.EndsWith(".jpg"))
                return true;
            else
                return false;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }
    }
}
