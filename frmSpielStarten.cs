using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;         // für Delay

namespace Blackjack_Spiel
{
    public partial class frmSpielStarten : Form
    {
        Random randomNummer = new Random();

        // alle Karten
        string[] alleKarten = new string[]{ "herz-2", "herz-3", "herz-4", "herz-5", "herz-6", "herz-7",
                "herz-8", "herz-9", "herz-10", "herz-j", "herz-q", "herz-k" ,"herz-a", "karo-2", "karo-3", "karo-4",
                "karo-5", "karo-6", "karo-7", "karo-8", "karo-9", "karo-10", "karo-j", "karo-q", "karo-k", "karo-a",
                "pik-2", "pik-3", "pik-4", "pik-5", "pik-6", "pik-7", "pik-8", "pik-9", "pik-10", "pik-j", "pik-k", "pik-q",
                "pik-a", "kreuz-2", "kreuz-3", "kreuz-4", "kreuz-5", "kreuz-6", "kreuz-7",
                "kreuz-8", "kreuz-9", "kreuz-10", "kreuz-j", "kreuz-q", "kreuz-k" ,"kreuz-a"};

         
        

        List<string> meineHand = new List<string>();
        List<string> dealerHand = new List<string>();
        List<string> kartenDeck = new List<string>();
        //List<string> gegnerHand = new List<string>();

        // pfad
        string backsidePfad = "C:\\Users\\berka\\Desktop\\Blackjack Spiel\\Karten\\backside.png";
        string pfad = "C:\\Users\\berka\\Desktop\\Blackjack Spiel\\Karten\\";
        string zusatz = ".png";

        // Karten
        int cardWidth = 100;
        int cardHeight = 160;
        int kartenDeckGroesse = 0;

        // Spieler und Dealer
        int index_of_last_card_dealer_hand = 1;
        bool placed_bet_check = false;
        int bet_amount = 50;
        int spielerKonto = 200;
        int spielerKartenSumme = 0;
        int dealerKartenSumme = 0;
        //int amout_of_konto = 200;

        // string für Texte
        string text_box_anzeige = "Guthaben: ";
        string turn = "player";
        string kartenSummeText_player = "Kartensumme: ";

        // Zwischenspeicher - temporär
        int tmp_spielerKartenSumme = 0;
        int tmp_dealerKartenSumme = 0;

        // Gewinner/ Verlierer
        string winner = "";

        // wer dran ist, ob Spieler oder Dealer
        public void toggleTurn()
        {
            if(turn == "player")
            {
                turn = "pc";
            }
            else
            {
                turn = "player";
            }
        }

        // Guthaben
        public void guthabenAnzeige(int geld_auf_dem_spieler_konto)
        {
            int zahl1 = geld_auf_dem_spieler_konto;
            string neue_anzeige = text_box_anzeige + zahl1;
            txtWetteAbschliessen.Text = "";
            txtWetteAbschliessen.Text = neue_anzeige;
        }

        // Runden, mit verschiedenen Methoden
        public void initRound()
        {
            guthabenAnzeige(spielerKonto);
            kartenDeckKarteAnzeigenStart();
            mischAlleKartenArray();
            //mischAlleKartenArray(alleKarten);
            //gemischteKartenListe(alleKarten2);
            //kartenAusteilenStart();
        }

        // Methode aufrufen
        public void round()
        {
            initRound();

            

        }

        // Spiel neustarten
        public void restart_game()
        {
            //int card_indexes_player = meineHand.Count - 1;
            //int card_indexes_dealer = dealerHand.Count - 1;
            /*
            for(int i = 0; i < card_indexes_player; i++)
            {
                flowLayoutPanel3.Controls.RemoveAt(i);
            }

            for(int i = 0; i < card_indexes_dealer; i++)
            {
                flowLayoutPanel2.Controls.RemoveAt(i);
            }
            */
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();

            meineHand.Clear();
            dealerHand.Clear();
            kartenDeck.Clear();

            tmp_dealerKartenSumme = 0;
            tmp_spielerKartenSumme = 0;

            spielerKartenSumme = 0;
            dealerKartenSumme = 0;

            lblDealerKartenSumme.Text = "";
            lblSpielerKartenSumme.Text = "";

            if(spielerKonto  > 0)
            {
                placed_bet_check = false;
                winner = "";
                turn = "player";
                MessageBox.Show("Nächste Runde.");
            }
            else
            {
                MessageBox.Show("Du hast das Spiel verloren.");
            }
        }

        // Karten mischen
        public void mischAlleKartenArray()      //string[] inputArray
        {
            /*
            for (int i = inputArray.Length - 1; i > 0; i--)
            {
                int randomIndex = randomNummer.Next(0, i + 1);

                string temp = inputArray[i];
                inputArray[i] = inputArray[randomIndex];
                inputArray[randomIndex] = temp;
            }*/


            string[] alleKarten2 = new string[52];

            for (int i = 0;  i  < alleKarten.Length; i++)
            {
                alleKarten2[i] = alleKarten[i];
            }

            for (int i = alleKarten2.Length - 1; i > 0; i--)
            {
                int randomIndex = randomNummer.Next(0, i + 1);

                string temp = alleKarten2[i];
                alleKarten2[i] = alleKarten2[randomIndex];
                alleKarten2[randomIndex] = temp;
            }

            gemischteKartenListe(alleKarten2);
            kartenAusteilenStart();
        }

        // Liste der gemischten Karte
        public void gemischteKartenListe(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                kartenDeck.Add(inputArray[i]);
            }
            kartenDeckGroesse = (kartenDeck.Count - 1);
        }

        // Karten an Spieler und Dealer austeilen - Methode
        public void kartenAusteilenStart()
        {
            for(int i = 0; i < 2; i++)
            {
                string card_str = kartenDeck[i];
                kartenDeck.RemoveAt(i);
                dealerHand.Add(card_str);
                PictureBox card = new PictureBox();
                card.SizeMode = PictureBoxSizeMode.StretchImage;
                card.Name = card_str;
                card.Size = new Size(cardWidth, cardHeight);

                string vollerPfad = pfad + card_str + zusatz;
                if(i == index_of_last_card_dealer_hand)
                {
                    card.Image = new Bitmap(backsidePfad);
                }
                else
                {
                    card.Image = new Bitmap(vollerPfad);
                }
                flowLayoutPanel2.Controls.Add(card);
            }

            for(int i = 0; i < 2; i++)
            {
                string card_str = kartenDeck[i];
                kartenDeck.RemoveAt(i);
                meineHand.Add(card_str);
                PictureBox card = new PictureBox();
                card.SizeMode = PictureBoxSizeMode.StretchImage;
                card.Name = card_str;
                card.Size = new Size(cardWidth, cardHeight);
                string vollerPfad = pfad + card_str + zusatz;

                card.Image = new Bitmap(vollerPfad);
                flowLayoutPanel3.Controls.Add(card);
            }
        }

        public frmSpielStarten()
        {
            InitializeComponent();
            guthabenAnzeige(spielerKonto);

            // ComboBox Einsätze
            cbbWetteinsatz.Items.Add("");
            cbbWetteinsatz.Items.Add("50");
            cbbWetteinsatz.Items.Add("100");
            cbbWetteinsatz.Items.Add("150");
            cbbWetteinsatz.Items.Add("200");
            cbbWetteinsatz.Items.Add("500");
            cbbWetteinsatz.Items.Add("1000");
            cbbWetteinsatz.Items.Add("1500");
            cbbWetteinsatz.Items.Add("2000");
            cbbWetteinsatz.Items.Add("2500");
            cbbWetteinsatz.Items.Add("5000");
        }

        private void frmSpielStarten_Load(object sender, EventArgs e)
        {
            
        }

        // Karten anzeigen und KartenBreite und KartenHöhe
        public void kartenDeckKarteAnzeigenStart()
        {
            pbBacksideKarte.BackgroundImage = new Bitmap("C:\\Users\\berka\\Desktop\\Blackjack Spiel\\Karten\\backside.png");
            pbBacksideKarte.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBacksideKarte.Size = new Size(cardWidth, cardHeight);
        }

        private void cbbWetteinsatz_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /*
        // Spiel neustarten Funktion
        public void restartGame()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            frmSpielStarten.ActiveForm.Refresh();
        }
        */

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtWetteAbschliessen_TextChanged(object sender, EventArgs e)
        {
            txtWetteAbschliessen.BackColor = System.Drawing.SystemColors.Window;
            txtWetteAbschliessen.ReadOnly = true;


        }

        // Spieler Karte ziehen
        public void player_karte_ziehen()
        {
            string card_str = kartenDeck[0];
            meineHand.Add(card_str);
            //MessageBox.Show(Convert.ToString(kartenDeck.Count));
            kartenDeck.RemoveAt(0);
            PictureBox card = new PictureBox();

            card.SizeMode = PictureBoxSizeMode.StretchImage;
            card.Name = card_str;
            card.Size = new Size(cardWidth, cardHeight);
            string vollerPfad = pfad + card_str + zusatz;
            try
            {
                card.Image = new Bitmap(vollerPfad);
            }
            catch(Exception)
            {
                MessageBox.Show(card_str);
            }
            //card.Image = new Bitmap(vollerPfad);
            flowLayoutPanel3.Controls.Add(card);
        }

        // Dealer Karte ziehen
        public void dealer_karte_ziehen()
        {
            string card_str = kartenDeck[0];
            dealerHand.Add(card_str);
            //MessageBox.Show(Convert.ToString(kartenDeck.Count));
            kartenDeck.RemoveAt(0);
            PictureBox card = new PictureBox();

            card.SizeMode = PictureBoxSizeMode.StretchImage;
            card.Name = card_str;
            card.Size = new Size(cardWidth, cardHeight);
            string vollerPfad = pfad + card_str + zusatz;
            try
            {
                card.Image = new Bitmap(vollerPfad);
            }
            catch (Exception)
            {
                MessageBox.Show(card_str);
            }
            //card.Image = new Bitmap(vollerPfad);
            flowLayoutPanel2.Controls.Add(card);
        }

        // Check, ob die Karte 'Herz' ist
        public bool herz_karte_check(string karten_zeichen)
        {
            bool check = false;
            string card = karten_zeichen;
            if (card == "herz")
            {
                check = true;
            }
            return check;
        }

        // Check, ob die Karte 'Karo' ist
        public bool karo_karte_check(string karten_zeichen)
        {
            bool check = false;
            string card = karten_zeichen;
            if(card == "karo")
            {
                check = true;
            }
            return check;
        }

        // Check, ob die Karte 'Kreuz' ist
        public bool kreuz_karte_check(string karten_zeichen)
        {
            bool check = false;
            string card = karten_zeichen;
            if (card == "kreuz")
            {
                check = true;
            }
            return check;
        }

        // Check, ob die Karte 'Pik' ist
        public bool pik_karte_check(string karten_zeichen)
        {
            bool check = false;
            string card = karten_zeichen;
            if (card == "pik")
            {
                check = true;
            }
            return check;
        }

        // Summe der Karten - Ausgabe
        public void karten_summe_anzeige(int summe, string which_player)
        {
            string player = which_player;
            if(player == "player")
            {
                lblSpielerKartenSumme.Text = "";
                spielerKartenSumme += summe;
                lblSpielerKartenSumme.Text = kartenSummeText_player + Convert.ToString(spielerKartenSumme);
            }
            else if (player == "pc")
            {
                dealerKartenSumme += summe;
            }
        }

        // KaroKarten Summe ermitteln
        public void karo_karte_sum(string card_name, string which_player)
        {
            int summe = 0;
            string card = card_name;
            string player = which_player;
            switch(card)
            {
                case "karo-2": summe += 2; break;
                case "karo-3": summe += 3; break;
                case "karo-4": summe += 4; break;
                case "karo-5": summe += 5; break;
                case "karo-6": summe += 6; break;
                case "karo-7": summe += 7; break;
                case "karo-8": summe += 8; break;
                case "karo-9": summe += 9; break;
                case "karo-10": summe += 10; break;
                case "karo-j": summe += 10; break;
                case "karo-q": summe += 10; break;
                case "karo-k": summe += 10; break;
                case "karo-a": summe += 11; break;
                default: break;
            }

            karten_summe_anzeige(summe, player);
        }

        // HerzKarten Summe ermitteln
        public void herz_karte_sum(string card_name, string which_player)
        {
            int summe = 0;
            string card = card_name;
            string player = which_player;
            switch (card)
            {
                case "herz-2": summe += 2; break;
                case "herz-3": summe += 3; break;
                case "herz-4": summe += 4; break;
                case "herz-5": summe += 5; break;
                case "herz-6": summe += 6; break;
                case "herz-7": summe += 7; break;
                case "herz-8": summe += 8; break;
                case "herz-9": summe += 9; break;
                case "herz-10": summe += 10; break;
                case "herz-j": summe += 10; break;
                case "herz-q": summe += 10; break;
                case "herz-k": summe += 10; break;
                case "herz-a": summe += 11; break;
                default: break;
            }

            karten_summe_anzeige(summe, player);
        }

        // KreuzKarten Summe ermitteln
        public void kreuz_karte_sum(string card_name, string which_player)
        {
            int summe = 0;
            string card = card_name;
            string player = which_player;
            switch (card)
            {
                case "kreuz-2": summe += 2; break;
                case "kreuz-3": summe += 3; break;
                case "kreuz-4": summe += 4; break;
                case "kreuz-5": summe += 5; break;
                case "kreuz-6": summe += 6; break;
                case "kreuz-7": summe += 7; break;
                case "kreuz-8": summe += 8; break;
                case "kreuz-9": summe += 9; break;
                case "kreuz-10": summe += 10; break;
                case "kreuz-j": summe += 10; break;
                case "kreuz-q": summe += 10; break;
                case "kreuz-k": summe += 10; break;
                case "kreuz-a": summe += 11; break;
                default: break;
            }

            karten_summe_anzeige(summe, player);
        }

        // PikKarten Summe ermitteln
        public void pik_karte_sum(string card_name, string which_player)
        {
            int summe = 0;
            string card = card_name;
            string player = which_player;
            switch (card)
            {
                case "pik-2": summe += 2; break;
                case "pik-3": summe += 3; break;
                case "pik-4": summe += 4; break;
                case "pik-5": summe += 5; break;
                case "pik-6": summe += 6; break;
                case "pik-7": summe += 7; break;
                case "pik-8": summe += 8; break;
                case "pik-9": summe += 9; break;
                case "pik-10": summe += 10; break;
                case "pik-j": summe += 10; break;
                case "pik-q": summe += 10; break;
                case "pik-k": summe += 10; break;
                case "pik-a": summe += 11; break;
                default: break;
            }

            karten_summe_anzeige(summe, player);
        }

        // ermitteln, welche Karte ausgeteilt wurde
        public void which_card_suit_check(string card_name, string which_player)
        {
            string card = card_name;
            int minus_char_index = card.IndexOf("-");
            string card_suit = card.Substring(0, minus_char_index);
            string player = which_player;

            if(herz_karte_check(card_suit))
            {
                herz_karte_sum(card, player);
            }
            else if(karo_karte_check(card_suit))
            {
                karo_karte_sum(card, player);
            }
            else if(kreuz_karte_check(card_suit))
            {
                kreuz_karte_sum(card, player);
            }
           else if(pik_karte_check(card_suit))
            {
                pik_karte_sum(card, player);
            }
        }

        // Kartensumme ermitteln
        public void count_card_points()
        {
            int meineHandLaenge = meineHand.Count();
            int dealerHandLaenge = dealerHand.Count();

            for(int i = 0; i < meineHandLaenge; i++)
            {
                string card = meineHand[i];
                which_card_suit_check(card, "player");
            }

            tmp_spielerKartenSumme = spielerKartenSumme;
            spielerKartenSumme = 0;


            for(int i = 0; i < dealerHandLaenge; i++)
            {
                string card = dealerHand[i];
                which_card_suit_check(card, "pc");
            }

            tmp_dealerKartenSumme = dealerKartenSumme;
            dealerKartenSumme = 0;

        }

        // eine weitere Karte ziehen - Button
        private void btnKarteZiehen_Click(object sender, EventArgs e)
        {
            if(placed_bet_check)
            {
                if(turn == "player")
                {
                    if(winner == "")
                    {
                        player_karte_ziehen();
                        count_card_points();
                        check_winner();
                    }
                }
            }
        }


        public void dealer_karte_aufdecken()
        {
            /*
            string card = dealerHand[1];
            flowLayoutPanel2.Controls.RemoveAt(1);
            PictureBox card_pic = new PictureBox();
            card_pic.SizeMode = PictureBoxSizeMode.StretchImage;

            card_pic.Name = card;
            card_pic.Size = new Size(cardWidth, cardHeight);

            string voller_pfad = pfad + card + zusatz;
            card_pic.Image = new Bitmap(voller_pfad);

            flowLayoutPanel2.Controls.Add(card_pic);
            */

            string card = dealerHand[1];
            string vollerpfad = pfad + card + zusatz;
            var pictureBox = (PictureBox)flowLayoutPanel2.Controls.Find(card, true)[0];
            pictureBox.Image = new Bitmap(vollerpfad);
        }

        public void dealer_zieht_karte()
        {
            dealer_karte_aufdecken();
            string card = kartenDeck[0];
            kartenDeck.RemoveAt(0);

        }

        public void final_stand(int num, int num2)
        {
            if(num > num2)
            {
                winner = "player";
                MessageBox.Show("Du hast gewonnen.");
                spielerKonto += bet_amount;
                guthabenAnzeige(spielerKonto);
                restart_game();
            }
            else if(num == num2)
            {
                winner = "";
                MessageBox.Show("Unentschieden");
                restart_game();
            }
            else
            {
                winner = "pc";
                MessageBox.Show("Dealer hat gewonnen");
                spielerKonto -= bet_amount;
                guthabenAnzeige(spielerKonto);
                restart_game();
            }
        }

        public void dealer_card_points_anzeige()
        {
            lblDealerKartenSumme.Text = "";
            lblDealerKartenSumme.Text = kartenSummeText_player + Convert.ToString(tmp_dealerKartenSumme);
        }

        public async void dealer_move()
        {
            await Task.Delay(1000);
            //MessageBox.Show(Convert.ToString(tmp_dealerKartenSumme));
            Random random_ai_choice = new Random();
            string[] yes_no_array = new string[] { "yes", "no" };
            int random_index = random_ai_choice.Next(yes_no_array.Length);
            
            string choice_dealer = "";
            string yes_or_no = yes_no_array[random_index];

            //MessageBox.Show(Convert.ToString(random_index), yes_or_no);

            if(tmp_dealerKartenSumme <= 10)
            {
                dealer_karte_aufdecken();
                dealer_zieht_karte();
                //MessageBox.Show("erste if Abfrage");
            }
            else if(tmp_dealerKartenSumme >= 11 && tmp_dealerKartenSumme <= 14)
            {
                if (yes_or_no == "yes")
                {
                    //MessageBox.Show("zweite if Abfrage");
                    dealer_karte_aufdecken();
                    dealer_karte_ziehen();
                }
                else
                {
                    if (winner == "")
                    {
                        //MessageBox.Show("dritte if Abfrage");
                        dealer_karte_aufdecken();
                    }
                }
            }
            else if(tmp_dealerKartenSumme >= 20)
            {
                if(winner == "")
                {
                    dealer_karte_aufdecken();
                    //MessageBox.Show("vierte if Abfrage");
                    //choice_dealer = "stand";
                }
            }
            else if(tmp_dealerKartenSumme >= 15 && tmp_spielerKartenSumme < 20)
            {
                if(yes_or_no == "yes")
                {
                    //MessageBox.Show("fünfte if Abfrage");
                    dealer_karte_aufdecken();
                    dealer_karte_ziehen();
                }
                else
                {
                    if(winner == "")
                    {
                        //MessageBox.Show("sechste if Abfrage");
                        dealer_karte_aufdecken();
                    }
                }
            }
            count_card_points();
            check_winner();
            dealer_card_points_anzeige();
            if(winner == "")
            {
                final_stand(tmp_spielerKartenSumme, tmp_dealerKartenSumme);
            }
            
        }

        // keine weitere Karte ziehen - Button
        private void btnStand_Click(object sender, EventArgs e)
        {
            if(placed_bet_check)
            {
                if(winner == "")
                {
                    if (turn == "player")
                    {
                        toggleTurn();
                        dealer_move();
                    }
                    else if (turn == "pc")
                    {
                        MessageBox.Show("Der Dealer ist an der Reihe.");
                    }
                    
                }
                
            }
        }

        // Einsatz veroppeln und eine einzige Karte ziehen
        private void btnVerdoppeln_Click(object sender, EventArgs e)
        {
            
            if (placed_bet_check)
            {
                if(turn == "player")
                {
                    if(winner == "")
                    {
                        player_karte_ziehen();
                        count_card_points();
                        check_winner();   
                        bet_amount *= 2;
                    }
                }
            }
        }

        // Gewinner ermitteln
        public void check_winner()
        {

            if(tmp_dealerKartenSumme == 21)
            {
                winner = "pc";
                MessageBox.Show("Du hast die Runde verloren.");
                dealer_karte_aufdecken();
                spielerKonto -= bet_amount;
                guthabenAnzeige(spielerKonto);
                dealer_card_points_anzeige();
                restart_game();
            }
            else if(tmp_dealerKartenSumme > 21)
            {
                winner = "player";
                MessageBox.Show("Du hast die Runde gewonnen.");
                dealer_karte_aufdecken();
                spielerKonto += bet_amount;
                guthabenAnzeige(spielerKonto);
                dealer_card_points_anzeige();
                restart_game();
            }
            
            else if(tmp_spielerKartenSumme == 21)
            {
                winner = "player";
                MessageBox.Show("Du hast die Runde gewonnen.");
                dealer_karte_aufdecken();
                spielerKonto += bet_amount;
                guthabenAnzeige(spielerKonto);
                dealer_card_points_anzeige();
                restart_game();
            }
            else if(tmp_spielerKartenSumme > 21)
            {
                winner = "pc";
                MessageBox.Show("Du hast die Runde verloren.");
                dealer_karte_aufdecken();
                spielerKonto -= bet_amount;
                guthabenAnzeige(spielerKonto);
                dealer_card_points_anzeige();
                restart_game();
            }
        }

        // Wette abschließen und setzen
        private void btnWetteAbschliessen_Click(object sender, EventArgs e)
        {
            if(!placed_bet_check)
            {
                string bet_str = cbbWetteinsatz.Text;
                if(bet_str == "")
                {
                    MessageBox.Show("Bitte eine Wettsumme setzen.");
                }
                else if(bet_str == "ALL-IN")
                {
                    bet_amount = spielerKonto;
                    placed_bet_check = true;
                    round();
                    count_card_points();
                }
                else
                {
                    int wett_zahl = Convert.ToInt32(bet_str);
                    if(wett_zahl > spielerKonto)
                    {
                        MessageBox.Show("Du hast nicht genügend Geld auf deinem Konto!");
                    }
                    else
                    {
                        bet_amount = wett_zahl;
                        placed_bet_check = true;
                        round();
                        count_card_points();
                    }
                }
               
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Spiel beenden - Button
        private void btnSpielBeenden_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public async void spiel_neustarten()
        {
            frmSpielStarten form1 = new frmSpielStarten();
            form1.Close();
            await Task.Delay(1000);
            frmSpielStarten form2 = new frmSpielStarten();
            form2.Show();
            form1.Close();
            
        }

        // Spiel neustarten Button
        private void btnSpielNeustarten_Click(object sender, EventArgs e)
        {
            spiel_neustarten();
        }
    }
}
