using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Hero_Database
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Superhero> superheroes;
        public Form1()
        {
            InitializeComponent();
            superheroes = new Dictionary<string, Superhero>
            {
                {"No Superhero", null},
                {"Yondu", new Superhero("Yondu Udonta", "Yondu Udonta", "Centaurian", "Yaka Arrow")},
                {"Thanos", new Superhero("Thanos", "Dione", "Titan", "Super strength, Invulnerability")},
                {"Knull", new Superhero("Knull", "Unknown", "Unknown", "Symbiote control")},
                {"Arnim Zola", new Superhero("Arnim Zola", "Arnim Zola", "Switzerland", "Genius-level intellect, Android body")},
                {"Mister Negative", new Superhero("Mister Negative", "Martin Li", "New York City", "Darkforce manipulation")}
            };
            foreach (var superheroName in superheroes.Keys)
            {
                comboBox1.Items.Add(superheroName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSuperheroName = comboBox1.SelectedItem.ToString();

            if (superheroes.ContainsKey(selectedSuperheroName))
            {
                Superhero selectedSuperhero = superheroes[selectedSuperheroName];
                DisplaySuperheroInfo(selectedSuperhero);
            }
            else
            {
                DisplayNoSuperheroInfo();
            }
        }
        private void DisplaySuperheroInfo(Superhero superhero)
        {
            lblName.Text = $"Name: {superhero.Name}";
            lblLikes.Text = $"Likes: {superhero.Likes}";
            lblDislikes.Text = $"Dislikes: {superhero.Dislikes}";
            lblPower.Text = $"Power: {superhero.Abilities}";
            lblBiography.Text = $"Biography: {superhero.Biography}";
        }
        private void DisplayNoSuperheroInfo()
        {
            lblName.Text = "No superhero selected.";
            lblLikes.Text = "";
            lblDislikes.Text = "";
            lblPower.Text = "";
            lblBiography.Text = "";
        }
        public class Superhero
        {
            public string Name { get; }
            public string AlterEgo { get; }
            public string City { get; }
            public string Abilities { get; }
            public string Biography { get; }
            public string Likes { get; }
            public string Dislikes { get; }

            public Superhero(string name, string alterEgo, string city, string abilities, string biography)
            {
                Name = name;
                AlterEgo = alterEgo;
                City = city;
                Abilities = abilities;
                Biography = biography;
            }

            public Superhero(string name, string alterEgo, string city, string abilities, string likes, string dislikes)
            {
                Name = name;
                AlterEgo = alterEgo;
                City = city;
                Abilities = abilities;
                Likes = likes;
                Dislikes = dislikes;
            }
        }
    }
}

