using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PopSim2
{
    [Serializable()]
    public class Population:System.Collections.IEnumerable
    {
        private List<Person> itsList = new List<Person>(24);
        private List<Person> itsMales = new List<Person>();
        private List<Person> itsFemales = new List<Person>();
        private string itsMessage;
        private static Random r = new Random((int)DateTime.Now.Ticks);
        public Population()
        {
            Person p;
            itsMessage = "Initializing...";
            for (int i = 0; i < 24; i++)
            {
                p = new Person();
                itsList.Add(p);
                if (p.GetGender == Gender.Male)
                {
                    itsMales.Add(p);
                }
                else
                {
                    itsFemales.Add(p);
                }
                itsMessage += "\nNew Person: " + itsList[i].ToString();

            }
            itsMessage += "\nPopulation: " + this.Size().ToString() + " (Males: " + this.Size(Gender.Male) +
                ", Females: " + this.Size(Gender.Female).ToString() + ")";
        }
        public int Size()
        {
            return itsList.Count;
        }
        public int Size(Gender Gen)
        {
            if (Gen == Gender.Male)
            {
                int k;
                try
                {
                    k = itsMales.Count;
                }
                catch (NullReferenceException exc)
                {
                    for (int i = 0; i < this.Size(); i++)
                    {
                        itsMales = new List<Person>();
                        itsFemales = new List<Person>();
                        if (itsList[i].GetGender == Gender.Male)
                        {
                            itsMales.Add(itsList[i]);
                        }
                        else
                        {
                            itsFemales.Add(itsList[i]);
                        }
                    }
                    k = itsMales.Count;

                }
                return k;
            }
            else
            {
                int k;
                try
                {
                    k = itsFemales.Count;
                }
                catch (NullReferenceException exc)
                {
                    itsMales = new List<Person>();
                    itsFemales = new List<Person>();
                    for (int i = 0; i < this.Size(); i++)
                    {
                        if (itsList[i].GetGender == Gender.Male)
                        {
                            itsMales.Add(itsList[i]);
                        }
                        else
                        {
                            itsFemales.Add(itsList[i]);
                        }
                    }
                    k = itsFemales.Count;
                }
                return k;
            }
        }
        public void Add(Person newPerson)
        {
            itsList.Add(newPerson);
        }
        public void Kill(Person vPerson)
        {
            itsList.Remove(vPerson);
        }
        public void Next(double vDate, ProgressBar pb)
        {
            List<bool> tracker = new List<bool>(this.Size());
            int t;
            pb.Maximum = this.Size();
            for (int i = 0; i < this.Size(); i++)
            {
                itsList[i].Next(vDate);
                pb.Value = i+1;
            }
            for (int i = 0; i < tracker.Capacity; i++)
            {
                tracker.Add(new bool());
            }
            itsMessage += "\n================" + "\nDate: " + vDate.ToString("N1");
            pb.Maximum = this.Size(Gender.Male);
            for (int i = 0; i < this.Size(Gender.Male); i++)
            {
                //pb.Value = i;
                do
                {
                    t = r.Next(0, this.Size(Gender.Male));
                } while (tracker[t]);
                tracker[t] = true;
                for (int j = 0; j < this.Size(Gender.Female); j++)
                {
                    itsMales[t].Meet(itsFemales[j]);

                }
                if (itsList[i].HadABaby)
                {
                    Person dad = itsList[i].BabyDaddy;
                    Person baby = new Person(itsList[i], dad);
                    itsList.Add(baby);
                    if (baby.GetGender == Gender.Male)
                    {
                        itsMales.Add(baby);
                    }
                    else
                    {
                        itsFemales.Add(baby);
                    }
                    itsMessage += "\n" + itsList[i].Name.ToString() + " & " + dad.Name.ToString() + " had a baby!\nWelcome: " +
                        baby.ToString();
                }
                if ((i+1) > pb.Maximum)
                {
                    pb.Value = pb.Maximum;
                }
                else
                {
                    pb.Value = i+1;
                }
            }
            pb.Maximum = this.Size();
            for (int i = 0; i < this.Size(); i++)
            {
                if (i < this.Size())
                {
                    if (itsList[i].Dead)
                    {
                        itsMessage += "\n" + itsList[i].ToString() + " has died.";
                        if (itsList[i].GetGender == Gender.Male)
                        {
                            itsMales.Remove(itsList[i]);
                        }
                        else
                        {
                            itsFemales.Remove(itsList[i]);
                        }
                        itsList.Remove(itsList[i]);
                        i--;
                    }
                }
                if ((i+1) > pb.Maximum)
                {
                    pb.Value = pb.Maximum;
                }
                else
                {
                    pb.Value = i+1;
                }
            }
            itsMessage += "\nPopulation: " + this.Size().ToString() + " (Males: " + this.Size(Gender.Male).ToString() +
                ", Females: " + this.Size(Gender.Female).ToString() + ")";
        }
        public string Messages
        {
            get
            {
                return itsMessage;
            }
        }
        public Person Male(int key)
        {
            return itsMales[key];
        }
        public Person Female(int key)
        {
            return itsFemales[key];
        }
        public Person this[int key]
        {
            get
            {
                return itsList[key];
            }
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            for (int i = 0; i < itsList.Count; i++)
            {
                yield return itsList[i];
            }
        }
    }
}
