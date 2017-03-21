using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiralBattı
{
    public partial class Form1 : Form
    {
        #region Values
        private int[][] ben = new int[10][];
        private int[][] dusman = new int[10][];
        private static bool dikeylik;
        private int sayac1x;
        private int sayac2x;
        private int sayac3x;
        private int sayac4x;
        private int benimGemi = 20;
        private int dusmanGemi = 20;
        public static int X, Y;
        #endregion

        #region Properties
        public static bool Vertical
        {
            get { return dikeylik; }
            set { dikeylik = value; }
        }

        public int Count1X
        {
            get { return sayac1x; }
            set { sayac1x = value; }
        }

        public int Count2X
        {
            get { return sayac2x; }
            set { sayac2x = value; }
        }

        public int Count3X
        {
            get { return sayac3x; }
            set { sayac3x = value; }
        }

        public int Count4X
        {
            get { return sayac4x; }
            set { sayac4x = value; }
        }

        public int MyShip
        {
            get { return benimGemi; }
            set { benimGemi = value; }
        }

        public int EnemyShip
        {
            get { return dusmanGemi; }
            set { dusmanGemi = value; }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();

            System.Reflection.PropertyInfo aProp =
                typeof(Control).GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance);

            aProp.SetValue(BenPanel, true, null);
            aProp.SetValue(DusmanPanel, true, null);

            for (int i = 0; i < ben.Count(); i++)
            {
                ben[i] = new int[10];
                dusman[i] = new int[10];
                for (int j = 0; j < ben[i].Count(); j++)
                {
                    ben[i][j] = 0;
                    dusman[i][j] = 0;
                }
            }
            dikeylik = true;
        }

        #region Methodlarım

        // Gemileri çiziyor
        // Parametreler
        // x,y: geminin konumu
        // w,h: en boy
        // size: geminin boyutu
        // panelBattle: oyun alanı
        private void WatchShip(int y, int x, int w, int h, int size, Panel panelBattle)
        {
            NullMas(); // Oyun Alanını temizle
            CreateShip(x, y, 1, size - 1, ben); // Gemileri oluştur
            for (int i = 0; i < ben.Count(); i++)
                for (int j = 0; j < ben[i].Count(); j++)
                    if (Rendering(x, y, i, j, size - 1)) panelBattle.Invalidate(new Rectangle(i * w, j * h, w, h)); // Gemilerin bulunduğu kutuları kullanım dışı bırak
        }
        // Alanı temizliyor
        private void NullMas()
        {
            for (int i = 0; i < ben.Count(); i++)  // Bütün kutuları gez
                for (int j = 0; j < ben[i].Count(); j++)
                    if (ben[i][j] != 2)    // kutunun içi 2 değilse
                        ben[i][j] = 0;     // zıfırla
        }

        // Parametreler
        // x,y : Geminin yerleşeceği koordinatlar
        // value : gemiyi temsil edecek rakam
        // size : geminin uzunluğu
        // mas : oyun alanı
        private void CreateShip(int x, int y, int value, int size, int[][] mas)
        {
            int dopPoint = mas.Count() - 1 - y - size;	// Geminin yerleşeceği başlangıç noktasını hesaplar (y ekseninde)
            if (dopPoint > 0) dopPoint = 0;	// Nokta alan içerisinde mi?
            int iMinLimitV = 0 + dopPoint;	// Başlangıç noktası (y ekseninde)
            int iMaxLimitV = 1 + size;		// Bitiş noktası (y ekseninde)
            if (dikeylik)			// Yatay düzlemde
                for (int i = iMinLimitV; i < iMaxLimitV; i++) // Başlangıç ve bitiş noktaları arasını tara
                    if (y + i >= 0 && y + i < 10 && x < 10) // Geminin herhangi bir noktası oyun alanının dışında kalmıyorsa
                        if (mas[y + i][x] != 2)	// Bu noktanın değeri 2 değilse (2 değeri düşman gemisinin bulunduğu noktaları temsil ediyor?)
                            mas[y + i][x] = value; // O noktaya value değerini yaz
            // Aşağıda aynı işlemler x ekseni için yapılıyor..
            dopPoint = mas.Count() - 1 - x - size;
            if (dopPoint > 0) dopPoint = 0;
            int jMinLimitH = 0 + dopPoint;
            int jMaxLimitH = 1 + size;
            if (!dikeylik)
                for (int j = jMinLimitH; j < jMaxLimitH; j++)
                    if (x + j >= 0 && x + j < 10 && y < 10)
                        if (x + j >= 0 && x + j < 10)
                            if (mas[y][x + j] != 2)
                                mas[y][x + j] = value;
        }

        private bool Rendering(int x, int y, int i, int j, int size)
        {
            int dopPoint = 9 - y - size;
            if (dopPoint > 0) dopPoint = 0;
            int uMinLimitV = -1 + dopPoint;
            int uMaxLimitV = 2 + size;
            if (dikeylik)
                for (int u = uMinLimitV; u < uMaxLimitV; u++)
                    for (int z = -1; z < 2; z++)
                        if (y + u >= 0 && y + u < 10 && x + z >= 0 && x + z < 10)
                            if (y + u == j && z + x == i)
                                return true;
            dopPoint = 9 - x - size;
            if (dopPoint > 0) dopPoint = 0;
            int zMinLimitH = -1 + dopPoint;
            int zMaxLimitH = 2 + size;
            if (!dikeylik)
                for (int u = -1; u < 2; u++)
                    for (int z = zMinLimitH; z < zMaxLimitH; z++)
                        if (y + u >= 0 && y + u < 10 && x + z >= 0 && x + z < 10)
                            if (y + u == j && z + x == i)
                                return true;
            return false;
        }

        // Gemilerin arasında boşluk olup olmadığını kontrol ediyor.
        // Yerleştirilmek istenen geminin çevresindeki 1 birimlik karelerin dolu olup olmadığına bakar.
        private bool CheckSq(int x, int y, int size, int[][] mas)
        {
            int dopPoint = mas.Count() - 1 - y - size;
            if (dopPoint > 0) dopPoint = 0;
            int iMinLimitV = -1 + dopPoint;
            int iMaxLimitV = 2 + size;
            if (dikeylik)
                for (int i = iMinLimitV; i < iMaxLimitV; i++)
                    for (int j = -1; j < 2; j++)
                        if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10)
                            if (mas[y + i][x + j] > 0)
                                return false;
            dopPoint = mas.Count() - 1 - x - size;
            if (dopPoint > 0) dopPoint = 0;
            int jMinLimitH = -1 + dopPoint;
            int jMaxLimitH = 2 + size;
            if (!dikeylik)
                for (int i = -1; i < 2; i++)
                    for (int j = jMinLimitH; j < jMaxLimitH; j++)
                        if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10)
                            if (mas[y + i][x + j] > 0)
                                return false;
            return true;
        }

        // Patlamayı kontrol eder
        public void Explosion(int x, int y, int[][] mas, bool stch = false)
        {

            int size = 0;
            bool flag = true; //vurdu vurmadı?
            int bufI = y, bufJ = x;
            if (!stch)
            {
                // seçilen kutunun üstü
                while (bufI > 0 && (GetEnemyValue(bufI - 1, bufJ) == 3 || GetEnemyValue(bufI - 1, bufJ) == 2))
                {
                    bufI--;
                    size++;
                    if (bufI >= 0 && GetEnemyValue(bufI, bufJ) == 2) flag = false;
                }
                bufI = y; bufJ = x;
                // altı
                while (bufI < 9 && (GetEnemyValue(bufI + 1, bufJ) == 3 || GetEnemyValue(bufI + 1, bufJ) == 2))
                {
                    bufI++;
                    size++;
                    if (bufI < 9 && GetEnemyValue(bufI, bufJ) == 2) flag = false;
                }
                bufI = y; bufJ = x;
                // sağı
                while (bufJ > 0 && (GetEnemyValue(bufI, bufJ - 1) == 3 || GetEnemyValue(bufI, bufJ - 1) == 2))
                {
                    bufJ--;
                    size++;
                    if (bufJ >= 0 && GetEnemyValue(bufI, bufJ) == 2) flag = false;
                }
                bufI = y; bufJ = x;
                // solu
                while (bufJ < 9 && (GetEnemyValue(bufI, bufJ + 1) == 3 || GetEnemyValue(bufI, bufJ + 1) == 2))
                {
                    bufJ++;
                    size++;
                    if (bufJ < 10 && GetEnemyValue(bufI, bufJ) == 2) flag = false;
                }
               
                if (flag)
                {
                    bool vert;
                  
                    while (y > 0 && dusman[y - 1][x] == 3) y--;
                    while (x > 0 && dusman[y][x - 1] == 3) x--;
              
                    if (y < 9 && dusman[y + 1][x] == 3) vert = true;
                    else vert = false;
                    
                    if (vert)
                        for (int i = -1; i < 2 + size; i++)
                            for (int j = -1; j < 2; j++)
                                if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10 && GetEnemyValue(y + i, x + j) != 3 && GetEnemyValue(y + i, x + j) != 2 && dusman[y + i][x + j] != 4 && dusman[y + i][x + j] != 1)
                                    dusman[y + i][x + j] = 4;
                    if (!vert)
                        for (int i = -1; i < 2; i++)
                            for (int j = -1; j < 2 + size; j++)
                                if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10 && GetEnemyValue(y + i, x + j) != 3 && GetEnemyValue(y + i, x + j) != 2 && dusman[y + i][x + j] != 4 && dusman[y + i][x + j] != 1)
                                    dusman[y + i][x + j] = 4;
                }
            }
            else
            {
                // seçilen kutunun üstü
                while (bufI > 0 && (ben[bufI - 1][bufJ] == 3 || ben[bufI - 1][bufJ] == 2))
                {
                    bufI--;
                    size++;
                    if (bufI >= 0 && ben[bufI][bufJ] == 2) flag = false;
                }
                bufI = y; bufJ = x;
                // altı
                while (bufI < 9 && (ben[bufI + 1][bufJ] == 3 || ben[bufI + 1][bufJ] == 2))
                {
                    bufI++;
                    size++;
                    if (bufI < 9 && ben[bufI][bufJ] == 2) flag = false;
                }
                bufI = y; bufJ = x;
                // sağı
                while (bufJ > 0 && (ben[bufI][bufJ - 1] == 3 || ben[bufI][bufJ - 1] == 2))
                {
                    bufJ--;
                    size++;
                    if (bufJ >= 0 && ben[bufI][bufJ] == 2) flag = false;
                }
                bufI = y; bufJ = x;
                // solu
                while (bufJ < 9 && (ben[bufI][bufJ + 1] == 3 || ben[bufI][bufJ + 1] == 2))
                {
                    bufJ++;
                    size++;
                    if (bufJ < 10 && ben[bufI][bufJ] == 2) flag = false;
                }
               
                if (flag)
                {
                    bool vert;
                   
                    while (y > 0 && ben[y - 1][x] == 3) y--;
                    while (x > 0 && ben[y][x - 1] == 3) x--;
                   
                    if (y < 9 && ben[y + 1][x] == 3) vert = true;
                    else vert = false;
                    
                    if (vert)
                        for (int i = -1; i <  size; i++)
                            for (int j = -1; j < 2; j++)
                                if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10 && ben[y + i][x + j] != 3 && ben[y + i][x + j] != 1 && ben[y + i][x + j] != 2 && ben[y + i][x + j] != 4)
                                    ben[y + i][x + j] = 4;
                    if (!vert)
                        for (int i = -1; i < 2; i++)
                            for (int j = -1; j <  size; j++)
                                if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10 && ben[y + i][x + j] != 3 && ben[y + i][x + j] != 2 && ben[y + i][x + j] != 4 && ben[y + i][x + j] != 1)
                                    ben[y + i][x + j] = 4;
                }
            }
        }

        public void EnemyTurn()
        {
            Random r = new Random();
            bool flag = true;
            while (flag)
            {


                X = r.Next(0, 10);
                Y = r.Next(0, 10);

                if (ben[X][Y] == 4 || ben[X][Y] == 3)
                {
                    flag = true;
                    continue;
                }

                if (ben[X][Y] == 0 || ben[X][Y] == 2 )
                    flag = false;

                if (ben[X][Y] == 0)
                {          
                    ben[X][Y] = 4;
                    BenPanel.Invalidate();                    
                }
                else if (ben[X][Y] != 4 && ben[X][Y] != 3)
                {
                    ben[X][Y] = 3;
                    MyShip--;
                    Explosion(X, Y, GetLink(), true);
                    if (MyShip == 0)
                        Victory("Üzgünüm Kaybettin...");
                }
            }

        }

        private int FindNextRb(RadioButton r1, RadioButton r2, RadioButton r3, RadioButton r4)
        {
            if (r1.Enabled)
            {
                r1.Checked = true;
                return 0;
            }
            if (r2.Enabled)
            {
                r2.Checked = true;
                return 0;
            }
            if (r3.Enabled)
            {
                r3.Checked = true;
                return 0;
            }
            if (r4.Enabled)
            {
                r4.Checked = true;
                return 0;
            }
            return 1;
        }

        public void Reset()
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    ben[i][j] = 0;
            sayac1x = 0;
            sayac2x = 0;
            sayac3x = 0;
            sayac4x = 0;
        }

        private void Victory(string str)
        {
            MessageBox.Show(str);
        }

        private void ChangeVerctical()
        {
            if (dikeylik) dikeylik = false;
            else dikeylik = true;
        }

        private int[][] GetLink()
        {
            return ben;
        }

        private int GetEnemyValue(int i, int j)
        {
            return dusman[i][j];
        }

        private int[][] GetEnemyLink()
        {
            return dusman;
        }

        private int ReturnMasSize()
        {
            return ben.Count();
        }

        private void SetEnemyValue(int i, int j, int value)
        {
            dusman[i][j] = value;
        }

        #endregion

        #region BenPanelEventleri

        private void BenPanel_Paint(object sender, PaintEventArgs e)
        {
            int w = BenPanel.Width / ReturnMasSize();
            int h = BenPanel.Height / ReturnMasSize();
            ControlPaint.DrawGrid(e.Graphics, new Rectangle(Point.Empty, BenPanel.Size), new Size(w, 1), Color.White);
            ControlPaint.DrawGrid(e.Graphics, new Rectangle(Point.Empty, BenPanel.Size), new Size(1, h), Color.White);
            for (int i = 0; i < ReturnMasSize(); i++)
                for (int j = 0; j < ReturnMasSize(); j++)
                {
                    if (ben[i][j] == 0)
                        e.Graphics.FillRectangle(Brushes.White, j * w + 1, i * h + 1, w - 1, h - 1);
                    if (ben[i][j] == 2 || ben[i][j] == 1)
                        e.Graphics.FillRectangle(Brushes.Navy, j * w + 1, i * h + 1, w - 1, h - 1);
                    if (ben[i][j] == 4)
                        e.Graphics.FillRectangle(Brushes.LightCoral, j * w + 1, i * h + 1, w - 1, h - 1);
                    if (ben[i][j] == 3)
                        e.Graphics.FillRectangle(Brushes.Red, j * w + 1, i * h + 1, w - 1, h - 1);

                }
        }

        private void BenPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(radioButton1.Enabled == false && radioButton2.Enabled == false && radioButton3.Enabled == false
                  && radioButton4.Enabled == false))
            {
                int w = BenPanel.Width / ReturnMasSize();
                int h = BenPanel.Height / ReturnMasSize();
                int x = e.X / w;
                int y = e.Y / h;
                int size;
                if (radioButton1.Checked) size = 1;
                else if (radioButton2.Checked) size = 2;
                else if (radioButton3.Checked) size = 3;
                else size = 4;
                WatchShip(y, x, w, h, size, BenPanel);
            }
        }

        private void BenPanel_MouseLeave(object sender, EventArgs e)
        {
            NullMas();
            BenPanel.Invalidate();
        }

        private void BenPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if ((radioButton1.Enabled == false && radioButton2.Enabled == false && radioButton3.Enabled == false
                  && radioButton4.Enabled == false))
            {
                MessageBox.Show("Tüm gemiler yerleştirildi.","Dikkat!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            } else {

            if (e.Button == MouseButtons.Right)
            {
                ChangeVerctical();
                NullMas();
                BenPanel.Invalidate();
            }
            else
            {
                int w = BenPanel.Width / ReturnMasSize();
                int h = BenPanel.Height / ReturnMasSize();                
                int size;
                if (radioButton1.Checked) size = 1;
                else if (radioButton2.Checked) size = 2;
                else if (radioButton3.Checked) size = 3;
                else size = 4;
                int x = e.X / w;
                int y = e.Y / h;
                if (x == 9 && size != 1 && !Vertical)
                    x -= size - 1;
                if (y == 9 && size != 1 && Vertical)
                    y -= size - 1;
                NullMas();

                if (CheckSq(x, y, size - 1, GetLink()))
                {
                    CreateShip(x, y, 2, size - 1, GetLink());
                    if (radioButton1.Checked) Count1X++;
                    else if (radioButton2.Checked) Count2X++;
                    else if (radioButton3.Checked) Count3X++;
                    else Count4X++;
                    if (Count1X > 3 && radioButton1.Enabled)
                    {
                        radioButton1.Enabled = false;
                        FindNextRb(radioButton1, radioButton2, radioButton3, radioButton4);
                    }
                    else if (Count2X > 2 && radioButton2.Enabled)
                    {
                        radioButton2.Enabled = false;
                        FindNextRb(radioButton1, radioButton2, radioButton3, radioButton4);
                    }
                    else if (Count3X > 1 && radioButton3.Enabled)
                    {
                        radioButton3.Enabled = false;
                        FindNextRb(radioButton1, radioButton2, radioButton3, radioButton4);
                    }
                    else if (Count4X > 0 && radioButton4.Enabled)
                    {
                        radioButton4.Enabled = false;
                        FindNextRb(radioButton1, radioButton2, radioButton3, radioButton4);
                    }
                    if (Count4X > 0 && Count3X > 1 && Count2X > 2 && Count1X > 3)
                    {
                        buttonHazir.Enabled = true;
                    }
                }
                BenPanel.Invalidate();
            } }
            
        }
        #endregion

        #region DusmanPanelEventleri

        private void DusmanPanel_Paint(object sender, PaintEventArgs e)
        {
            int w = BenPanel.Width / ReturnMasSize();
            int h = BenPanel.Height / ReturnMasSize();
            ControlPaint.DrawGrid(e.Graphics, new Rectangle(Point.Empty, BenPanel.Size), new Size(w, 1), Color.White);
            ControlPaint.DrawGrid(e.Graphics, new Rectangle(Point.Empty, BenPanel.Size), new Size(1, h), Color.White);
            for (int i = 0; i < ReturnMasSize(); i++)
                for (int j = 0; j < ReturnMasSize(); j++)
                {
                    if (GetEnemyValue(i, j) < 3)
                        e.Graphics.FillRectangle(Brushes.White, j * w + 1, i * h + 1, w - 1, h - 1);
                    /*if (objBattle.GetEnemyValue(i, j) == 2)
                       e.Graphics.FillRectangle(Brushes.Red, j * w + 1, i * h + 1, w - 1, h - 1);*/
                    if (GetEnemyValue(i, j) == 3)
                        e.Graphics.FillRectangle(Brushes.Red, j * w + 1, i * h + 1, w - 1, h - 1);
                    if (GetEnemyValue(i, j) == 4)
                        e.Graphics.FillRectangle(Brushes.LightCoral, j * w + 1, i * h + 1, w - 1, h - 1);
                }
        }

        private void DusmanPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !buttonRastgele.Enabled)
            {
                int w = BenPanel.Width / ReturnMasSize();
                int h = BenPanel.Height / ReturnMasSize();
                int x = e.X / w;
                int y = e.Y / h;

                if (GetEnemyValue(y, x) == 2)
                {
                    SetEnemyValue(y, x, 3);
                    EnemyShip--;
                    Explosion(x, y, GetEnemyLink());
                    DusmanPanel.Invalidate();
                    if (EnemyShip == 0)
                        Victory("Tebrikler Kazandiniz...:)");
                }
                else if (GetEnemyValue(y, x) == 0)
                {
                    EnemyTurn();
                    SetEnemyValue(y, x, 4);
                    DusmanPanel.Invalidate();
                }

            }
        }

        private void DusmanPanel_MouseMove(object sender, MouseEventArgs e)
        {
            DusmanPanel.Invalidate();
        }

        #endregion

        #region ButonEventleri

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Reset();
            radioButton1.Enabled = true;
            radioButton1.Checked = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            BenPanel.Invalidate();
            buttonHazir.Enabled = false;
        }        

        private void buttonRastgele_Click(object sender, EventArgs e)
        {
            var r = new Random();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    ben[i][j] = 0;
            int count = 10, size = 0;
            while (count >= 0)
            {
                if (count < 5) size = 1;
                else if (count < 7) size = 2;
                else if (count < 9) size = 3;
                else if (count == 9) size = 4;
                int y = r.Next(0, 10);
                int x = r.Next(0, 10);
                if (r.Next(0, 2) == 1)
                    ChangeVerctical();
                NullMas();

                if (CheckSq(x, y, size - 1, GetLink()))
                {
                    CreateShip(x, y, 2, size - 1, GetLink());
                    count--;
                }
            }
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            BenPanel.Invalidate();
            buttonHazir.Enabled = true;
        }        

        private void buttonHazir_Click(object sender, EventArgs e)
        {
            if (!(radioButton1.Enabled == false && radioButton2.Enabled == false && radioButton3.Enabled == false
                  && radioButton4.Enabled == false))
            {
                MessageBox.Show("Lütfen tüm gemileri yerleştirin.","Dikkat!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {               
                BenPanel.Enabled = false;
                buttonHazir.Enabled = false;
                buttonHazir.Visible = true;
                buttonTemizle.Enabled = false;
                buttonRastgele.Enabled = false;
                buttonRestart.Enabled = true;
                buttonRestart.Visible = true;
                buttonRestart.Location = new Point(319,317);


                Count1X = 0;
                Count2X = 0;
                Count3X = 0;
                Count4X = 0;
                int y, x, count = 10, size = 3;
                while (count > 0)
                {
                    Random r = new Random();
                    if (count < 10) size = 2;
                    if (count < 8) size = 1;
                    if (count < 5) size = 0;
                    y = r.Next(0, 10);
                    x = r.Next(0, 10);
                    if (r.Next(0, 2) == 1)
                        ChangeVerctical();
                    if (CheckSq(x, y, size, GetEnemyLink()))
                    {
                        CreateShip(x, y, 2, size, GetEnemyLink());
                        count--;
                    }
                }

                DusmanPanel.Invalidate();
            }
            
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 hak = new Form3();
            hak.Show();
        }

        private void nasılOynanırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 no = new Form2();
            no.Show();
        }

        #endregion

    }
}
