using System.Threading.Tasks;

namespace CsevegesGUI
{
    public partial class Form1 : Form
    {
        static List<Beszelgetes> beszelgetesek = new();
        static List<string> tagok = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HashSet<string> kezd = new();
            HashSet<string> foga = new();

            StreamReader sr = new("./../../../../src/csevegesek.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                beszelgetesek.Add(new(sr.ReadLine().Split(";")));
                kezd.Add(beszelgetesek.Last().Kezdemenyezo);
                foga.Add(beszelgetesek.Last().Fogado);
            }

            sr.Close();

            cbKezd.Items.AddRange(kezd.OrderBy(tag => tag).ToArray());
            cbKezd.SelectedIndex = 0;
            cbFoga.Items.AddRange(foga.OrderBy(tag => tag).ToArray());
            cbFoga.SelectedIndex = cbFoga.Items.Count - 1;
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKezd.SelectedItem is null || cbFoga.SelectedItem is null) return;
            string kezd = cbKezd.SelectedItem.ToString();
            string foga = cbFoga.SelectedItem.ToString();
            List<Beszelgetes> l = beszelgetesek.Where(b => b.Kezdemenyezo == kezd && b.Fogado == foga).ToList();

            if (l.Count > 0)
            {
                tbCsev.Text = "";
                for (int i = 0; i < l.Count; i++)
                {
                    tbCsev.Text += $"{i + 1}. {l[i].Kezdet} --> {l[i].Veg}\r\n";
                }
            } 
            else
            {
                tbCsev.Text = "Nem történt beszélgetés.";
            }


        }
    }
}