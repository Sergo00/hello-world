using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace course_work
{
    public class Func
    {
        public List<imgOBJECT> allPic;

        public List<imgOBJECT> selectedPic;

        public JSON j;

        MainWindow window;
        public Func(MainWindow w)
        {
            allPic = new List<imgOBJECT>();
            selectedPic = new List<imgOBJECT>();
            j = new JSON();
            window = w;
        }

        public void Add()
        {
            string category;

            AddDialog parametr = new AddDialog();
            if (parametr.ShowDialog() == true)
            {
                List<string> tags = parametr.listtags.Items.Cast<string>().ToList();
                category = parametr.categorycombo.Text;

                imgOBJECT a = new imgOBJECT(parametr.fn.Text, parametr.fileName.Text, parametr.fileURL.Text, category, tags);

                string tagi = "";
                foreach (string tag in tags)
                {
                    tagi += tag + "; ";
                }


                allPic.Add(a);
                selectedPic.Add(a);
                window.list.Items.Add(a.name + ": " + tagi);
            }
        }
        public void ComboBox()
        {
            window.list.Items.Clear();
            selectedPic.Clear();

            ComboBoxItem comboBox = (ComboBoxItem)window.kategoria.SelectedItem;
            string category = comboBox.Content.ToString();

            if (category == "All")
            {
                foreach (imgOBJECT a in allPic)
                {
                    string tagi = "";
                    foreach (string tag in a.tags)
                    {
                        tagi += tag + "; ";
                    }

                    window.list.Items.Add(a.name + ": " + tagi);
                    selectedPic.Add(a);
                }
            }
            else
            {
                foreach (imgOBJECT a in allPic)
                {
                    if (a.category == category)
                    {
                        string tagi = "";
                        foreach (string tag in a.tags)
                        {
                            tagi += tag + "; ";
                        }

                        window.list.Items.Add(a.name + ": " + tagi);
                        selectedPic.Add(a);
                    }
                }
            }
        }

        public void listn()
        {
            if (window.list.SelectedIndex > -1)
            {
                imgOBJECT p;

                p = selectedPic[window.list.SelectedIndex];

                if (p.url == "")
                    window.img.Source = new BitmapImage(new Uri(p.path));
                else
                {
                    var fullFilePath = p.url;
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
                    bitmap.EndInit();

                    window.img.Source = bitmap;
                }
            }
        }

        public void FindName()
        {
            window.list.Items.Clear();
            selectedPic.Clear();

            string name = window.findbyname.Text;

            foreach (imgOBJECT el in allPic)
            {
                string tagi = "";
                foreach (string tag in el.tags)
                {
                    tagi += tag + "; ";
                }

                string name1 = el.name;
                if (name1.Contains(name) == true)
                {
                    window.list.Items.Add(name1 + ": " + tagi);
                    selectedPic.Add(el);
                }


                foreach (string tag in el.tags)
                {
                    string name2 = tag;
                    string name3;
                    if (name2.Contains(name) == true)
                    {
                        name3 = el.name;
                        window.list.Items.Add(name3 + ": " + tagi);
                        selectedPic.Add(el);
                    }

                }
            }
        }
        public void Delete()
        {
            if (window.list.SelectedIndex > -1)
            {
                selectedPic.Remove(selectedPic[window.list.SelectedIndex]);
                allPic.Remove(allPic[window.list.SelectedIndex]);
                window.list.Items.Remove(window.list.SelectedValue);
                window.img.Source = null;
            }
        }

        public void Save()
        {
            j.SaveFile(allPic);
        }

        public void Load()
        {
            window.list.Items.Clear();
            allPic = j.LoadFile();


            foreach (imgOBJECT a in allPic)
            {
                selectedPic.Add(a);
                string tagi = "";

                List<string> tagis = a.tags;
                if (tagis != null)
                {
                    foreach (string tag in tagis)
                    {
                        tagi += tag + "; ";
                    }
                }
                window.list.Items.Add(a.name + ": " + tagi);
            }
        }

    }
}

