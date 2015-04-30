using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;
using System.Runtime.InteropServices;
using System.IO;

namespace prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
           
 

 
//014
//namespace splitvideo

//{
//016
     public class SplitInput: Task  

     {

                 ITaskItem[] videoInput;

                 [Required]     

         public ITaskItem[] InputVideo     

                 {
                                 get           

                                 {

                                         return videoInput;

                                 }

                     set            

                     {             

                         videoInput = value;           

                     }     

                 }    

         int segmentSize;      

         [Required]   

         public int SegmentSize     

         {

             get { return segmentSize;

             }           set { segmentSize = value; }    

  }

         List<ITaskItem> splittedInputVideo;     

         [Output]       

         public ITaskItem[] SplittedInputVideo      

         {        

             get           

             {             

                 return splittedInputVideo.ToArray();            

             }          

             set            

             {             

                 splittedInputVideo.Clear();               

                 splittedInputVideo.AddRange(value);           

             }     

         }     

         public SplitInput()       

         {           splittedInputVideo = new List<ITaskItem>();

         }

         public override bool Execute()    

         {

             foreach (ITaskItem item in videoInput)        

             {             

                 MediaTaskItem mediaTaskItem = new MediaTaskItem(item);

                 if (mediaTaskItem.PlayTime > 0)

                 {                  

                     int segments = (int)(mediaTaskItem.PlayTime / (long)segmentSize);

                     int rest = (int)(mediaTaskItem.PlayTime % (long)segmentSize);

                     int i = 0;              

                     for (i = 0; i < segments; i++)

                     {

                         CreateSubItem(item, i, i * segmentSize, (i + 1) * segmentSize);

                     }

                     if (rest > 0)

                     {                      

                         CreateSubItem(item, i, i * segmentSize, (int)(mediaTaskItem.PlayTime));

                     }

                 }

             }

             return true;

         }

         private void CreateSubItem(ITaskItem item, int i,int start,int end)

         {

                         FileInfo fi = new FileInfo(item.ItemSpec);

             string itemSpec = item.ItemSpec + "." + i.ToString() + ".wmv";

             TaskItem subItem = new TaskItem(itemSpec, item.CloneCustomMetadata());

             subItem.SetMetadata("Start", start.ToString());

             subItem.SetMetadata("End", end.ToString());

             subItem.SetMetadata("Source", fi.FullName);

             subItem.SetMetadata("Segment", i.ToString());

             splittedInputVideo.Add(subItem);

         }

     }

  

   

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();
        }
 

        private void Form1_Load(object sender, EventArgs e)

        {

        }

    }
//103
}

        }

        private void previewFullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
