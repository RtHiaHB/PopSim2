using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PopSim2
{
    public partial class Form1 : Form
    {
        private Population pop;
        private double myDate = 0.0;
        private bool filed=false;
        private string MyFileName;
        public Form1()
        {
            InitializeComponent();
            
        }
        public Form1(string vFileName)
        {
            InitializeComponent();
            filed = true;
            MyFileName = vFileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!filed)
            {
                pop = new Population();
            }
            else
            {
                OpenPopFile(MyFileName);
            }
            PopulateListBox();
            PopulationMessages.Text = pop.Messages;
            DateText.Text = myDate.ToString("F1");
            PopulationText.Text = pop.Size().ToString();
            MalePop.Text = pop.Size(Gender.Male).ToString();
            FemPop.Text = pop.Size(Gender.Female).ToString();
        }
        private void PopulationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PopulationList.SelectedIndex != -1)
            {
                ThoughtBubble.Text = pop[PopulationList.SelectedIndex].Thoughts;
            }
        }
        private void PopulateListBox()
        {
            if (PopulationList.Items.Count > 0)
            {
                int PopCount = PopulationList.Items.Count;
                for (int i = 0; i < PopCount; i++)
                {
                    PopulationList.Items.Remove(PopulationList.Items[0]);
                }
            }
            foreach (Person p in pop)
            {
                int temp;
                temp = PopulationList.Items.Add(p.ToString());
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            int NewHeight=(int)Math.Round((double)(this.Height/2),0);
            System.Drawing.Size NewSize=new System.Drawing.Size(this.Width,NewHeight);
            this.tableLayoutPanel1.Size=NewSize;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            myDate += 0.1;
            progressBar1.Maximum = pop.Size();
            DateText.Text = myDate.ToString("F1");
            pop.Next(myDate, progressBar1);
            PopulationMessages.Text = pop.Messages;
            PopulationText.Text = pop.Size().ToString();
            MalePop.Text = pop.Size(Gender.Male).ToString();
            FemPop.Text = pop.Size(Gender.Female).ToString();
            PopulateListBox();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Population Files (*.pop)|*.pop|All Files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.DefaultExt = "pop";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.CreatePrompt = true;
            sfd.OverwritePrompt = true;
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName,FileMode.OpenOrCreate);
                BinaryFormatter bf=new BinaryFormatter();
                bf.Serialize(fs, myDate);
                bf.Serialize(fs, pop);
                fs.Close();
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "pop";
            ofd.Filter = "Population Files (*.pop)|*.pop|All Files (*.*)|*.*";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.FilterIndex = 1;
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                OpenPopFile(ofd.FileName);
            }
        }
        private void OpenPopFile(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            myDate = (double)bf.Deserialize(fs);
            pop = (Population)bf.Deserialize(fs);
            fs.Close();
            DateText.Text = myDate.ToString("F1");
            PopulateListBox();
            PopulationText.Text = pop.Size().ToString();
            MalePop.Text = pop.Size(Gender.Male).ToString();
            FemPop.Text = pop.Size(Gender.Female).ToString();
            PopulationMessages.Text = pop.Messages;
        }
        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            if (PopulationList.SelectedIndex != -1)
            {
                PersonDetails pd = new PersonDetails(pop[PopulationList.SelectedIndex],this);
                pd.Show();
            }
        }
        public Population Population
        {
            get
            {
                return pop;
            }
        }

    }
}
