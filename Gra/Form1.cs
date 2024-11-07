using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zgaduj_Zgadula;
using Newtonsoft.Json;

namespace Gra
{
    public partial class Form1 : Form
    {
        string path2= Path.Combine(Application.StartupPath, "genius.jpg");
        private const string UsersFilePath = "users.json";
        private const string SettingsFilePath = "settings.json";
        bool login = false;
        User user1;
        UserSettings us = new UserSettings(); 
        int liczbaPytan; 
        private List<Pytanie> pytania;
        int nr_poziomu;
        bool wpro = false;
        bool lab1 = false;
        bool lab2 = false;
        bool lab3 = false;
        bool lab4 = false;
        bool lab5 = false;
        bool lab6 = false;
        bool lab7 = false;
        bool lab10 = false;


        List<Pytanie> wszystkiePytania = new List<Pytanie>();
        Postać postac;
        int proby=3;
        int combo = 0;
        bool czy = true;
        string poziom;
        Wrok wrog;
        int nr = 0;
        SoundPlayer zadawanieObrazenPlayer = new SoundPlayer("dmg.wav");
        SoundPlayer otrzymywanieObrazenPlayer = new SoundPlayer("take_dmg.wav");
        SoundPlayer wygranaPlayer = new SoundPlayer("victory.wav");
        SoundPlayer przegranaPlayer = new SoundPlayer("lose.wav");
        public Form1()
        {

            InitializeComponent(); 
            comboBox1.Items.Add("tutorial");
            comboBox1.Items.Add("egzamin");
            comboBox1.Items.Add("LAB1");
            comboBox1.Items.Add("LAB2");
            comboBox1.Items.Add("LAB3");
            comboBox1.Items.Add("LAB4");
            comboBox1.Items.Add("LAB5");
            comboBox1.Items.Add("LAB6");
            comboBox1.Items.Add("LAB7");
            comboBox1.Items.Add("LAB8");
            comboBox1.Items.Add("LAB9");


            

            wszystkiePytania.AddRange(LAB1.Pytania);
            wszystkiePytania.AddRange(LAB2.Pytania);
            wszystkiePytania.AddRange(LAB3.Pytania);
            wszystkiePytania.AddRange(LAB4.Pytania);
            wszystkiePytania.AddRange(LAB5.Pytania);
            wszystkiePytania.AddRange(LAB6.Pytania);
            wszystkiePytania.AddRange(LAB7.Pytania);
            wszystkiePytania.AddRange(LAB8.Pytania);        
            postac = new Gracz("gracz");
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            
            string path = Path.Combine(Application.StartupPath, "bartyna1.jpg");
            pictureBox3.Image = Image.FromFile(path);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Witaj ponownie, dawno Cie tu nie było";
            login = true;
            if (lab10)
                label1.Text = "Widzę że masz już zdane wszystkie labolatoria, czas na ostateczny egzamin, walke ze mną. Buhahaha";
            tabControl1.SelectedIndex = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Witaj studencie, zapraszam na quiz oraz egzamin, zanim jednak zaczniemy zapraszam do samouczka. W samouczku nie będę mógł ci dawać podpowiedzi więc powiem Ci teraz. Twoim zadaniem jest pokonanie przeciwników. Będziesz im zadawać obrażenia poprawnie odpowiadając na pytania. Jeśli poprawnie odpowiesz na 3 pytania po kolei będzie kombo i zadasz więce. Niestety idzie to w drugą stronę, źle odpowiadając przeciwnik zada Ci obrażenia a odpowiadając 3 razy po kolei źle zada Ci więcej";
            login = false ;
            tabControl1.SelectedIndex = 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            wrog = new Genius();
            path2 = Path.Combine(Application.StartupPath, "genius.jpg");

            poziom = "tutorial";
            nr_poziomu = 0;
            nr = 0;
            przygotuj();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            wrog = new Scout();
            path2 = Path.Combine(Application.StartupPath, "scout.jpg");
            poziom = "LAB1";
            nr_poziomu = 1;
            nr = 0;
            przygotuj();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            wrog = new Monolith();
            path2 = Path.Combine(Application.StartupPath, "monolith.jpg");

            poziom = "LAB2";
            nr_poziomu = 2;
            nr = 0;
            przygotuj();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            wrog = new Helix();

            poziom = "LAB3";
            nr_poziomu = 3;
            nr = 0;
            przygotuj();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Show();
            
            wrog = new Helix();

            poziom = "LAB4";
            nr_poziomu = 4;
            nr = 0;
            przygotuj();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            wrog = new Helix();

            poziom = "LAB5";
            nr_poziomu = 5;
            nr = 0;
            przygotuj();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            wrog = new Helix();

            poziom = "LAB6";
            nr_poziomu = 6;
            nr = 0;
            przygotuj();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            wrog = new Helix();

            poziom = "LAB7";
            nr_poziomu = 7;
            nr = 0;
            przygotuj();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            wrog = new Towers();
            path2 = Path.Combine(Application.StartupPath, "towers.jpg");

            poziom = "LAB8";
            nr_poziomu = 10;
            nr = 0;
            przygotuj();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            wrog = new WaldemarBartyna();
            path2 = Path.Combine(Application.StartupPath, "bartyna2.jpg");
            poziom = "egzamin";
            nr_poziomu = 11;
            nr = 0;
            przygotuj();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            bicie(0);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bicie(1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bicie(2);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bicie(3);
        }

        void przygotuj()
        {
            // Załaduj obraz dla PictureBox
            pictureBox5.Image = Image.FromFile(path2);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;

            // Ustawienia dla progress barów
            progressBar1.Minimum = 0;
            progressBar1.Maximum = wrog.MaksymalnaLiczbaPunktówŻycia;
            progressBar1.Value = wrog.AktualnaLiczbaPunktówŻycia;
            progressBar2.Minimum = 0;
            postac.AktualnaLiczbaPunktówŻycia = postac.MaksymalnaLiczbaPunktówŻycia;
            progressBar2.Maximum = postac.MaksymalnaLiczbaPunktówŻycia;
            progressBar2.Value = postac.AktualnaLiczbaPunktówŻycia;

            // Ustawienia dla etykiet
            label3.Text = $"{wrog.MaksymalnaLiczbaPunktówŻycia} | {wrog.AktualnaLiczbaPunktówŻycia}";
            label4.Text = $"{postac.MaksymalnaLiczbaPunktówŻycia} | {postac.AktualnaLiczbaPunktówŻycia}";

            // Załaduj pytania na podstawie poziomu z pliku JSON
            string nazwaPliku = $"{poziom}.json";
            wszystkiePytania = WczytajPytania(nazwaPliku);

            // Filtruj pytania tylko dla wybranego poziomu
            pytania = wszystkiePytania.Where(p => p.Typ == poziom).ToList();
            liczbaPytan = pytania.Count;

            // Uruchom pierwsze pytanie
            nr = 0;
            walka();
        }

        void walka()
        {
            // Sprawdź, czy są jeszcze pytania
            if (pytania.Count > 0 && nr < pytania.Count)
            {
                // Wyświetl pytanie i przypisz odpowiedzi do przycisków
                label2.Text = pytania[nr].Tresc;
                button16.Text = pytania[nr].Odpowiedzi[0];
                button17.Text = pytania[nr].Odpowiedzi[1];
                button18.Text = pytania[nr].Odpowiedzi[2];
                button19.Text = pytania[nr].Odpowiedzi[3];
            }
        }

        void bicie(int n)
        {
            if (pytania[nr].CzyOdpowiedzPoprawna(n))
            {
                // Obrażenia dla wroga
                wrog.OtrzymajObrażenia(1);
                zadawanieObrazenPlayer.Play();
            }
            else
            {
                // Obrażenia dla postaci
                postac.OtrzymajObrażenia(1);
                otrzymywanieObrazenPlayer.Play();
            }

            zaktualizuj();
        }

        void zaktualizuj()
        {
            // Aktualizuj wartości progress barów i etykiet
            progressBar1.Value = wrog.AktualnaLiczbaPunktówŻycia;
            progressBar2.Value = postac.AktualnaLiczbaPunktówŻycia;

            label3.Text = $"{wrog.MaksymalnaLiczbaPunktówŻycia} | {wrog.AktualnaLiczbaPunktówŻycia}";
            label4.Text = $"{postac.MaksymalnaLiczbaPunktówŻycia} | {postac.AktualnaLiczbaPunktówŻycia}";

            // Przejdź do następnego pytania
            nr++;
            if (nr >= liczbaPytan) nr = 0;

            // Sprawdź, czy postać lub wróg nie żyją
            if (postac.CzyNieŻyje)
            {
                label1.Text = "Niestety, przegrałeś. Spróbuj jeszcze raz!";
                nr = 0;
                tabControl1.SelectedIndex = 2;
                przegranaPlayer.Play();
            }
            else if (wrog.CzyNieŻyje)
            {
                label1.Text = "Gratulacje! Zapraszam na kolejny poziom!";
                nr = 0;
                odblokuj();
                wygranaPlayer.Play();
                tabControl1.SelectedIndex = 2;
                if (nr_poziomu == 10)
                {
                    label1.Text = "Widzę że masz już zdane wszystkie labolatoria, czas na ostateczny egzamin, walke ze mną. Buhahaha";
                }
            }
            else
            {
                walka();
            }
        }


        void odblokuj()
        {
            switch (nr_poziomu)
            {
                case 0:
                    wpro = true;
                    us.Wpro = true;
                    break;
                case 1:
                    lab1 = true;
                    us.Lab1 = true;
                    break;
                case 2:
                    lab2 = true;
                    us.Lab2 = true;
                    break;
                case 3:
                    lab3 = true;
                    us.Lab3 = true;
                    break;
                case 4:
                    lab4 = true;
                    us.Lab4 = true;
                    break;
                case 5:
                    lab5 = true;
                    us.Lab5 = true;
                    break;
                case 6:
                    lab6 = true;
                    us.Lab6 = true;
                    break;
                case 7:
                    lab7 = true;
                    us.Lab7 = true;
                    break;
                case 10:
                    lab10 = true;
                    us.Lab10 = true;
                    break;
                default:
                    
                    break;
            }

            var userSettings = LoadUserSettings();

            
            userSettings[user1.Login] = us;

            SaveUserSettings(userSettings);
            show();
        }

        void show()
        {
            if (wpro)
            {
                button5.Show();
            }

            if (lab1)
            {
                button6.Show();
            }

            if (lab2)
            {
                button7.Show();
            }

            if (lab3)
            {
                button8.Show();
            }

            if (lab4)
            {
                button9.Show();
            }

            if (lab5)
            {
                button10.Show();
            }

            if (lab6)
            {
                button11.Show();
            }

            if (lab7)
            {
                button12.Show();
            }

            if (lab10)
            {
                button13.Show();
            }

        }

        // Funkcja do wczytywania danych z pliku JSON
        private static Dictionary<string, User> LoadUsers()
        {
            if (File.Exists(UsersFilePath))
            {
                string json = File.ReadAllText(UsersFilePath);
                return JsonConvert.DeserializeObject<Dictionary<string, User>>(json);
            }
            return new Dictionary<string, User>();
        }

        private static Dictionary<string, UserSettings> LoadUserSettings()
        {
            if (File.Exists(SettingsFilePath))
            {
                string json = File.ReadAllText(SettingsFilePath);
                return JsonConvert.DeserializeObject<Dictionary<string, UserSettings>>(json);
            }
            return new Dictionary<string, UserSettings>();
        }

        // Funkcja do zapisywania danych do pliku JSON
        private static void SaveUsers(Dictionary<string, User> users)
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(UsersFilePath, json);
        }

        private static void SaveUserSettings(Dictionary<string, UserSettings> userSettings)
        {
            string json = JsonConvert.SerializeObject(userSettings, Formatting.Indented);
            File.WriteAllText(SettingsFilePath, json);
        }

        // Funkcja do rejestracji użytkownika
        public  bool Register(string login, string password)
        {
            var users = LoadUsers();

            if (users.ContainsKey(login))
            {
                label5.Text = "Taka osoba już isnieje";
                return false;
            }

            users[login] = new User { Login = login, Password = password };
            SaveUsers(users);
            user1 = users[login];

            var userSettings = LoadUserSettings();
            userSettings[login] = new UserSettings();
            us = userSettings[login];
            SaveUserSettings(userSettings);

            return true;
        }

        // Funkcja do logowania użytkownika
        public  bool Login(string login, string password)
        {
            var users = LoadUsers();

            if (!users.ContainsKey(login) || users[login].Password != password)
            {

                label5.Text = "Błędne dane logowania";
                return false;
            }

            var userSettings = LoadUserSettings();

            if (userSettings.ContainsKey(login))
            {
                user1 = users[login];
                us = userSettings[login];
                
               
            }

            return true;
        }

       
        public static void UpdateUserSettings(string login, UserSettings newSettings)
        {
            var userSettings = LoadUserSettings();

           
            userSettings[login] = newSettings;

            SaveUserSettings(userSettings);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (login)
            {
                if (Login(textBox1.Text, textBox2.Text))
                    {
                    if (user1.Login == "admin")
                        tabControl1.SelectedIndex = 4;
                    else
                        tabControl1.SelectedIndex = 2;
                }
                    
                
            }
            else
            {
                if(Register(textBox1.Text, textBox2.Text))
                    tabControl1.SelectedIndex = 2;
            }
            przypisz();
        }


        void przypisz()
        {
            lab1 = us.Lab1;
            lab2 = us.Lab2;
            lab3 = us.Lab3;
            lab4 = us.Lab4;
            lab5 = us.Lab5;
            lab6 = us.Lab6;
            lab7 = us.Lab7;
            lab10 = us.Lab10;
            wpro = us.Wpro;
            odblokuj();
        }

        

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }



       
        public static void ZapiszPytania(string nazwaPliku, List<Pytanie> pytania)
        {

           
            if (File.Exists(nazwaPliku))
            {
                Console.WriteLine($"Plik '{nazwaPliku}' już istnieje. Nie utworzono nowego pliku.");
               
            }

            
            var json = JsonConvert.SerializeObject(pytania, Formatting.Indented);

            
            File.WriteAllText(nazwaPliku, json);
            Console.WriteLine($"Plik '{nazwaPliku}' został utworzony i zapisany.");
        }

            public static List<Pytanie> WczytajPytania(string nazwaPliku)
            {
                if (!File.Exists(nazwaPliku))
                    return new List<Pytanie>();

                var json = File.ReadAllText(nazwaPliku);
                var pytania = JsonConvert.DeserializeObject<List<Pytanie>>(json);

                // Sprawdzenie i przekształcenie odpowiedzi
                foreach (var pytanie in pytania)
                {
                    if (pytanie.Odpowiedzi.Count > 4)
                    {
                        // Upewniamy się, że lista zawiera tylko cztery pierwsze odpowiedzi
                        pytanie.Odpowiedzi = pytanie.Odpowiedzi.Take(4).ToList();
                    }
                }

                return pytania;
            }


        public static void DodajPytanie(string nazwaPliku, Pytanie nowePytanie)
        {
            var pytania = WczytajPytania(nazwaPliku);
            pytania.Add(nowePytanie);
            ZapiszPytania(nazwaPliku, pytania);
        }

        public static void AktualizujPytanie(string nazwaPliku, int indeks, Pytanie zaktualizowanePytanie)
        {
            var pytania = WczytajPytania(nazwaPliku);
            if (indeks >= 0 && indeks < pytania.Count)
            {
                pytania[indeks] = zaktualizowanePytanie;
                ZapiszPytania(nazwaPliku, pytania);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Indeks pytania jest poza zakresem.");
            }
        }

        public void wyswietl()
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybranyPlik = comboBox1.SelectedItem.ToString() + ".json";
            var pytania = WczytajPytania(wybranyPlik);

            dataGridView1.DataSource = null;

            // Tworzenie DataTable, aby łatwo zamienić listę odpowiedzi na kolumny
            var table = new DataTable();
            table.Columns.Add("Tresc");
            table.Columns.Add("Typ");
            table.Columns.Add("Odpowiedź A");
            table.Columns.Add("Odpowiedź B");
            table.Columns.Add("Odpowiedź C");
            table.Columns.Add("Odpowiedź D");
            table.Columns.Add("Prawidłowa Odpowiedź (Indeks)");

            foreach (var pytanie in pytania)
            {
                table.Rows.Add(
                    pytanie.Tresc,
                    pytanie.Typ,
                    pytanie.Odpowiedzi[0],
                    pytanie.Odpowiedzi[1],
                    pytanie.Odpowiedzi[2],
                    pytanie.Odpowiedzi[3],
                    pytanie.IndeksPrawidlowejOdpowiedzi
                );

                
            }

            dataGridView1.DataSource = table;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string typPliku = textBoxTyp.Text + ".json";
            var nowePytanie = new Pytanie(
                textBoxTresc.Text,
                textBoxOdpA.Text,
                textBoxOdpB.Text,
                textBoxOdpC.Text,
                textBoxOdpD.Text,
                int.Parse(textBoxIndeksPrawidlowej.Text),
                textBoxTyp.Text
            );

            DodajPytanie(typPliku, nowePytanie);

            MessageBox.Show("Dodano nowe pytanie.");
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                string typPliku = textBoxTyp.Text + ".json";
                var zaktualizowanePytanie = new Pytanie(
                    textBoxTresc.Text,
                    textBoxOdpA.Text,
                    textBoxOdpB.Text,
                    textBoxOdpC.Text,
                    textBoxOdpD.Text,
                    int.Parse(textBoxIndeksPrawidlowej.Text),
                    textBoxTyp.Text
                );

                AktualizujPytanie(typPliku, rowIndex, zaktualizowanePytanie);

                MessageBox.Show("Pytanie zostało zaktualizowane.");
                comboBox1_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("Wybierz pytanie do aktualizacji.");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                string typPliku = textBoxTyp.Text + ".json";

                var pytania = WczytajPytania(typPliku);
                pytania.RemoveAt(rowIndex);

                ZapiszPytania(typPliku, pytania);

                MessageBox.Show("Pytanie zostało usunięte.");
                comboBox1_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("Wybierz pytanie do usunięcia.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBoxTresc.Text = row.Cells["Tresc"].Value.ToString();
                textBoxTyp.Text = row.Cells["Typ"].Value.ToString();
                textBoxOdpA.Text = row.Cells["Odpowiedź A"].Value.ToString();
                textBoxOdpB.Text = row.Cells["Odpowiedź B"].Value.ToString();
                textBoxOdpC.Text = row.Cells["Odpowiedź C"].Value.ToString();
                textBoxOdpD.Text = row.Cells["Odpowiedź D"].Value.ToString();
                textBoxIndeksPrawidlowej.Text = row.Cells["Prawidłowa Odpowiedź (Indeks)"].Value.ToString();
            }
        }

        private void Powrót_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
    }
}
