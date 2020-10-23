using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DiffMyData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_MyDataFolder.Text = @"C:\Users\my\Desktop\skyrim_mod\My_Data";
            textBox_SkyrimDataFolder.Text = @"D:\Steam\steamapps\common\Skyrim Special Edition\Data";
        }

        List<FileInfo> mydatalist = new List<FileInfo>();
        List<FileInfo> skyrimdatalist = new List<FileInfo>();
        List<string> totallist = new List<string>();
        string errmsg;

        private void button_diff_Click(object sender, EventArgs e)
        {
            
            if (BuildDataList(textBox_MyDataFolder.Text, mydatalist) == false)
            {
                MessageBox.Show(errmsg);
                return;
            }

            if (BuildDataList(textBox_SkyrimDataFolder.Text, skyrimdatalist) == false)
            {
                MessageBox.Show(errmsg);
                return;
            }

            CheckDiff();
        }

        private void CheckDiff()
        {
            AppendTotalList(mydatalist);
            AppendTotalList(skyrimdatalist);

            totallist.Sort();

            FillListBoxAll();
        }

        private void AppendTotalList(List<FileInfo> filelist)
        {
            foreach (var item in filelist)
            {
                string temp = item.FullName;
                if (temp.Contains(textBox_MyDataFolder.Text) == true)
                {
                    temp = temp.Replace(textBox_MyDataFolder.Text, "");
                }
                else if (temp.Contains(textBox_SkyrimDataFolder.Text) == true)
                {
                    temp = temp.Replace(textBox_SkyrimDataFolder.Text, "");
                }

                if (totallist.Contains(temp) == false)
                {
                    totallist.Add(temp);
                }

            }
        }

        private void FillListBoxAll()
        {
            // left list
            listBox_MyData.Items.Clear();
            foreach (var item in totallist)
            {
                string temp = textBox_MyDataFolder.Text + item;
                if (IsContainsDataList(temp, mydatalist) == true)
                {
                    listBox_MyData.Items.Add(temp);
                }
                else
                {
                    listBox_MyData.Items.Add("empty");
                }
            }
            DisplayListboxScroll(listBox_MyData);

            // right list
            listBox_SkyrimData.Items.Clear();
            foreach (var item in totallist)
            {
                string temp = textBox_SkyrimDataFolder.Text + item;
                if (IsContainsDataList(temp, skyrimdatalist) == true)
                {
                    listBox_SkyrimData.Items.Add(temp);
                }
                else
                {
                    listBox_SkyrimData.Items.Add("empty");
                }
            }
            DisplayListboxScroll(listBox_SkyrimData);
        }

        private bool IsContainsDataList(string checkfile, List<FileInfo> filelist)
        {
            foreach (var item in filelist)
            {
                if (item.FullName == checkfile)
                    return true;
            }
            return false;
        }

        private bool BuildDataList(string path, List<FileInfo> filelist)
        {
            filelist.Clear();

            try
            {
                if (Directory.Exists(path) == false)
                {
                    errmsg = path + " 폴더가 없습니다";
                    return false;
                }

                DirectoryInfo di;
                // 1. Meshes\actors\character\FaceGenData\FaceGeom\My.esp
                di = new DirectoryInfo(path + @"\Meshes\actors\character\FaceGenData\FaceGeom\My.esp");
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Extension.ToLower() == ".bak")
                        continue;

                    filelist.Add(fi);
                }

                // 2. Textures\actors\character\FaceGenData\FaceTint\My.esp
                di = new DirectoryInfo(path + @"\Textures\actors\character\FaceGenData\FaceTint\My.esp");
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Extension.ToLower() == ".bak" || fi.Extension.ToLower() == ".tga")
                        continue;

                    filelist.Add(fi);
                }

                // 3. Textures\My
                SubBuildDataList(path + @"\Textures\My", filelist);

                return true;

            }
            catch (Exception e)
            {
                errmsg = e.Message;
                return false;
            }
        }

        private void SubBuildDataList(string path, List<FileInfo> filelist)
        {
            if (Directory.Exists(path) == false)
                return;

            DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo fi in di.GetFiles())
            {
                if (fi.Extension.ToLower() == ".bak" || fi.Extension.ToLower() == ".tga")
                    continue;

                filelist.Add(fi);
            }

            foreach (var sub in di.GetDirectories())
            {
                SubBuildDataList(sub.FullName, filelist);
            }
            
        }

        private FileInfo GetContextFileInfo(ContextMenuStrip menu)
        {

            ListBox lb = menu.SourceControl as ListBox;
            int index = lb.SelectedIndex;
            if (index < 0)
                return null;
            if (lb.SelectedItem.ToString() == "empty")
                return null;

            return new FileInfo(lb.SelectedItem.ToString());
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //ContextMenuStrip menu = sender as ContextMenuStrip;
            //GetContextFileInfo(menu);
        }

        private void toolStripMenuItem_openinbrowser_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = ((ToolStripItem)sender).Owner as ContextMenuStrip;
            FileInfo fi = GetContextFileInfo(menu);
            if (fi != null)
            {
                System.Diagnostics.Process.Start(fi.DirectoryName);
            }

        }

        private void useThisFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = ((ToolStripItem)sender).Owner as ContextMenuStrip;
            ListBox lb = menu.SourceControl as ListBox;
            int index = lb.SelectedIndex;
            string src;
            string dst;
            string srcpath;
            string dstpath;
            
            if (lb == listBox_MyData)
            {
                src = listBox_MyData.Items[index].ToString();
                dst = listBox_SkyrimData.Items[index].ToString();

                srcpath = textBox_MyDataFolder.Text;
                dstpath = textBox_SkyrimDataFolder.Text;
            }
            else
            {
                src = listBox_SkyrimData.Items[index].ToString();
                dst = listBox_MyData.Items[index].ToString();

                srcpath = textBox_SkyrimDataFolder.Text;
                dstpath = textBox_MyDataFolder.Text;
            }

            if (src == "" || src == "empty")
                return;

            if (dst == "" || dst == "empty")
            {
                dst = dstpath + src.Replace(srcpath, "");
            }
            else
            {
                // backup dst
                System.IO.File.Move(dst, dst + ".bak");
            }

            // copy src -> dst
            // make dir
            string dir = System.IO.Path.GetDirectoryName(dst);
            if (Directory.Exists(dir) == false)
                System.IO.Directory.CreateDirectory(dir);
            System.IO.File.Copy(src, dst);
        }

        private void DisplayListboxScroll(ListBox lb)
        {
            int maxhzsize = 0;
            Graphics g = lb.CreateGraphics();

            foreach (var item in lb.Items)
            {
                int hzSize = (int)g.MeasureString(item.ToString(), lb.Font).Width;
                if (hzSize > maxhzsize)
                    maxhzsize = hzSize;
            }

            lb.HorizontalExtent = maxhzsize + 10;
        }

        private void listBox_MyData_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            e.DrawBackground();

            Brush myBrush = Brushes.Black;
            switch(CompareTotallistItem(e.Index))
            {
                case 1:
                    myBrush = Brushes.Orange;
                    break;
                case 2:
                    myBrush = Brushes.Red;
                    break;
                case 3:
                    myBrush = Brushes.Blue;
                    break;
            }

            ListBox lb = sender as ListBox;
            
            e.Graphics.DrawString(lb.Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();

        }

        private int CompareTotallistItem(int index)
        {
            try
            {
                string left = listBox_MyData.Items[index].ToString();
                if (left == "" || left == "empty")
                    return 3;

                string right = listBox_SkyrimData.Items[index].ToString();
                if (right == "" || right == "empty")
                    return 3;

                FileInfo fi_left = new FileInfo(left);
                FileInfo fi_right = new FileInfo(right);

                if (fi_left.LastWriteTime != fi_right.LastWriteTime)
                    return 1;


                return 0;
            }
            catch (Exception e)
            {
                errmsg = e.Message;
                return 0;
            }
        }

        private void listBox_SkyrimData_DrawItem(object sender, DrawItemEventArgs e)
        {
            listBox_MyData_DrawItem(sender, e);
        }

        private void listBox_MyData_DoubleClick(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb.SelectedItem == null)
                return;

            string temp = lb.SelectedItem.ToString();
            if (temp == "empty")
                return;

            string ext = temp.Substring(temp.Length - 3).ToLower();
            if (ext == "nif" || ext == "dds")
                System.Diagnostics.Process.Start(temp);
        }

        private void listBox_SkyrimData_DoubleClick(object sender, EventArgs e)
        {
            listBox_MyData_DoubleClick(sender, e);
        }

        private void listBox_SkyrimData_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_fileinfo.Text = "";
            ListBox lb = sender as ListBox;
            string filename = lb.SelectedItem.ToString();
            if (filename == "" || filename == "empty")
                return;

            FileInfo fi = new FileInfo(filename);
            label_fileinfo.Text = fi.ToString();
        }

        private void listBox_MyData_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_SkyrimData_SelectedIndexChanged(sender, e);
        }
    }
}
