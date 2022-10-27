namespace winforms_dateisumme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                //Extrahiert aus dem Dateipfad den Dateinamen
                string path = openFileDialog1.FileName;
                cboFile.Text = Path.GetFileName(path);
            }
            openFileDialog1.InitialDirectory = Application.StartupPath;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void CmdCalculateSum_Click(object sender, EventArgs e)
        {
            ///Ein Programm, dass die Umsätze einer Datei (hier: umsatz1.txt --> befindet sich im Projektordner)
            ///zeilenweise ausliest, addiert. Der Gesamtumsatz wird ebenfalls ausgegeben.
            using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {
                string line;
                int found;
                int count = 0;
                double sum = 0;
                //Extrahiert aus dem Dateipfad den Dateinamen
                string path = openFileDialog1.FileName;
                LblDisplay.Text = "Datei: " + Path.GetFileName(path) + "\n\n";
                while (sr.Peek() != -1)
                {
                    //Zeilentzähler
                    count++;
                    line = sr.ReadLine()!;
                    found = line.IndexOf(";");
                    //Extrahiert den Preis aus der Zeile
                    sum += Convert.ToDouble(line.Substring(found + 1));
                    LblDisplay.Text += " " + count + "Umsatz:".PadLeft(12,' ') + line.Substring(found + 1).PadLeft(25,' ') + "Summe:".PadLeft(12,' ') + sum.ToString().PadLeft(25,' ') + "\n";


                }
                //Terminiert das StreamReader-Objekt
                sr.Close();
                txtSum.Text = sum.ToString();
            }
        }

        private void CmdDeletePostings_Click(object sender, EventArgs e)
        {
            //Überschreibt die Anzeige in LblDisplay
            LblDisplay.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}