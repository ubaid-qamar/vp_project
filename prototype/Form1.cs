using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Build.Utilities;
//using Microsoft.Build.Framework;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace prototype
{
    public partial class Form1 : Form
    {


        string argument;
        string splittime;
        string savePath;
        public Form1()
        {
            
            InitializeComponent();
            argument = "-i ";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void len_increase_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void rotateLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rotateLeftToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                
                
                //argument += openFileDialog1.FileName + " -ss 00:00:07 -t 00:00:17 output.avi";
                
               argument += openFileDialog1.FileName;
            }
        }

        private void addVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;

            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void splitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
 

 
////014
////namespace splitvideo

////{
////016
//     public class SplitInput: Task  

//     {

//                 ITaskItem[] videoInput;

//                 [Required]     

//         public ITaskItem[] InputVideo     

//                 {
//                                 get           

//                                 {

//                                         return videoInput;

//                                 }

//                     set            

//                     {             

//                         videoInput = value;           

//                     }     

//                 }    

//         int segmentSize;      

//         [Required]   

//         public int SegmentSize     

//         {

//             get { return segmentSize;

//             }           set { segmentSize = value; }    

//  }

//         List<ITaskItem> splittedInputVideo;     

//         [Output]       

//         public ITaskItem[] SplittedInputVideo      

//         {        

//             get           

//             {             

//                 return splittedInputVideo.ToArray();            

//             }          

//             set            

//             {             

//                 splittedInputVideo.Clear();               

//                 splittedInputVideo.AddRange(value);           

//             }     

//         }     

//         public SplitInput()       

//         {           splittedInputVideo = new List<ITaskItem>();

//         }

//         public override bool Execute()    

//         {

//             foreach (ITaskItem item in videoInput)        

//             {             

//                 MediaTaskItem mediaTaskItem = new MediaTaskItem(item);

//                 if (mediaTaskItem.PlayTime > 0)

//                 {                  

//                     int segments = (int)(mediaTaskItem.PlayTime / (long)segmentSize);

//                     int rest = (int)(mediaTaskItem.PlayTime % (long)segmentSize);

//                     int i = 0;              

//                     for (i = 0; i < segments; i++)

//                     {

//                         CreateSubItem(item, i, i * segmentSize, (i + 1) * segmentSize);

//                     }

//                     if (rest > 0)

//                     {                      

//                         CreateSubItem(item, i, i * segmentSize, (int)(mediaTaskItem.PlayTime));

//                     }

//                 }

//             }

//             return true;

//         }

//         private void CreateSubItem(ITaskItem item, int i,int start,int end)

//         {

//                         FileInfo fi = new FileInfo(item.ItemSpec);

//             string itemSpec = item.ItemSpec + "." + i.ToString() + ".wmv";

//             TaskItem subItem = new TaskItem(itemSpec, item.CloneCustomMetadata());

//             subItem.SetMetadata("Start", start.ToString());

//             subItem.SetMetadata("End", end.ToString());

//             subItem.SetMetadata("Source", fi.FullName);

//             subItem.SetMetadata("Segment", i.ToString());

//             splittedInputVideo.Add(subItem);






//     }

  

   

//    public partial class Form1 : Form

//    {

//        public Form1()

//        {

//            InitializeComponent();
//        }
 

//        private void Form1_Load(object sender, EventArgs e)

//        {

//        }

//    }
////103
        //    MediaHandler _mhandler = new MediaHandler();
        //    string RootPath = Server.MapPath(Request.ApplicationPath);
        //    // set required parameters
        //    _mhandler.FFMPEGPath = HttpContext.Current.Server.MapPath("~\\ffmpeg\\ffmpeg.exe");
        //    _mhandler.InputPath = RootPath + "\\contents\\videos";
        //    _mhandler.OutputPath = RootPath + "\\contents\\splitvideos";
        //    // set other parameters
        //    _mhandler.FileName = "FullVideo.avi";
        //    _mhandler.OutputFileName = "split_video"; // required
        //    _mhandler.OutputExtension = ".avi"; // required
        //    _mhandler.Width = 320;
        //    _mhandler.Height = 240;
        //    // set paremters related to output video type. it is different for 3gp video, mp4 video, avi video etc.
        //    _mhandler.TargetFileType = "pal-vcd";
        //    // split video parameters
        //    int length_of_video = 20; // in seconds;
        //    int total_clips = 10;
        //    //VideoInfo info = _mhandler.Split_Video(20);
        //    VideoInfo info = _mhandler.Split_Video(length_of_video, total_clips);
        //    if (info.ErrorCode > 0)
        //    {
        //        Response.Write("Error occured: Error Code: " + info.ErrorCode + "<br />Error Message: " + info.ErrorMessage);
        //        return;
        //    }

        }
    

        

        private void previewFullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string start;
            string end;
            start = textBox1.Text.ToString();
            end = textBox2.Text.ToString();
            splittime = " -ss ";
            splittime += start;
            splittime += " -t ";
            splittime += end;
            splittime += " "+savePath+".avi";
            argument += splittime;
            System.Diagnostics.Process.Start(@"C:\Users\Moon satti\Downloads\CODE\ffmpeg\ffmpeg.exe", argument);
            MessageBox.Show(argument);
            argument="";
            splittime="";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveSplit_Click(object sender, EventArgs e)
        {
            SaveFileDialog savesplit = new SaveFileDialog();

            if(savesplit.ShowDialog()==DialogResult.OK)
            {
                savePath = savesplit.FileName;
                textboxSave.Text = savePath;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}



    


