using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PopSim2
{
    public partial class PersonDetails : Form
    {
        private Person myPerson;
        private Form1 myParent;
        public PersonDetails(Person p, Form1 f)
        {
            InitializeComponent();
            myPerson = p;
            myParent = f;
        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            NameTxt.Text = myPerson.Name.ToString();
            GenderTxt.Text = myPerson.GetGender.ToString("F");
            AgeTxt.Text = myPerson.Age.ToString("F1");
            HairTxt.Text = myPerson.Hair.ToString("F");
            EyesTxt.Text = myPerson.Eyes.ToString("F");
            SizeTxt.Text = myPerson.Size.ToString("F");
            BlondeHairPrefTxt.Text = myPerson.Prefs.Hair(HairColor.Blonde).ToString("+0;-0;+0");
            BlackHairPrefTxt.Text = myPerson.Prefs.Hair(HairColor.Black).ToString("+0;-0;+0");
            BrownHairPrefTxt.Text = myPerson.Prefs.Hair(HairColor.Brown).ToString("+0;-0;+0");
            RedHairPrefTxt.Text = myPerson.Prefs.Hair(HairColor.Red).ToString("+0;-0;+0");
            BlueEyesPrefTxt.Text = myPerson.Prefs.Eyes(EyeColor.Blue).ToString("+0;-0;+0");
            BrownEyesPrefTxt.Text = myPerson.Prefs.Eyes(EyeColor.Brown).ToString("+0;-0;+0");
            HazelEyesPrefTxt.Text = myPerson.Prefs.Eyes(EyeColor.Hazel).ToString("+0;-0;+0");
            SmallPrefTxt.Text = myPerson.Prefs.Size(PopSim2.Size.Small).ToString("+0;-0;+0");
            MedPrefTxt.Text = myPerson.Prefs.Size(PopSim2.Size.Medium).ToString("+0;-0;+0");
            LargePrefTxt.Text = myPerson.Prefs.Size(PopSim2.Size.Large).ToString("+0;-0;+0");
            MotherTxt.Text = myPerson.MotherName.ToString();
            FatherTxt.Text = myPerson.FatherName.ToString();
            foreach (Name child in myPerson.Children)
            {
                ChildrenList.Items.Add(child.ToString());
            }
            //Parent = (Form1)sender;
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            if (ChildrenList.SelectedIndex != -1)
            {
                DrillDownDetails(ChildrenList.SelectedItem.ToString());
            }
        }

        private void MotherDetailsBtn_Click(object sender, EventArgs e)
        {
            DrillDownDetails(MotherTxt.Text);
        }

        private void FatherDetailsBtn_Click(object sender, EventArgs e)
        {
            
            DrillDownDetails(FatherTxt.Text);
            
        }
        private void DrillDownDetails(string WorkingName)
        {
            
            Person p = new Person();
            string n = p.Name.ToString();
            //string WorkingName = ChildrenList.SelectedItem.ToString();
            for (int i = 0; i < myParent.Population.Size(); i++)
            {
                if (WorkingName == myParent.Population[i].Name.ToString())
                {
                    p = myParent.Population[i];
                }
            }
            if (p.Name.ToString() != n)
            {
                PersonDetails pd = new PersonDetails(p, myParent);
                pd.Show();
            }
            else
            {
                MessageBoxButtons mbb = MessageBoxButtons.OK;
                string message = "Person not found. :(";
                string caption = "Uh oh...";
                DialogResult dr = MessageBox.Show(this, message, caption, mbb);

            }
        }
    }
}
