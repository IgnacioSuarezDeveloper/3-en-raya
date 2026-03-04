namespace _3enRaya
{
    public partial class Form1 : Form
    {
        enum Turn
        {
            X,
            O,
        };
        Turn turno;
        string[,] cells;
        public Form1()
        {
            InitializeComponent(); 
            InitializingGame();
            
        }

        private void OnClick(object sender, EventArgs e)//click en botton
        {

            Button button = (Button)sender; //boton clickado
            int buttonNumber = ButtonSelected(sender); //numero del boton.
            int[] indexCell = ReturnIndex(buttonNumber); //indice de la celda que coincide con el boton.
            IntroducionOX(indexCell); //introduciendo x o o en el array de celdas.
            ButtonTextOX(button); //cambia el texto del boton dependiendo del turno.
            bool win = CheckingWin(); //comprueba si alguien ha ganado.
            WinerFound(win); //si hay ganador reinicializa todo.
            NotWinerFound();
            ChangeTurn(); 
        }
        private int ButtonSelected(object sender)
        {
            Button button = (Button)sender;
            int buttonNumber = int.Parse(button.Name.Replace("button", ""));
            return buttonNumber;
        }
        private bool CheckingWin()
        {
            bool win = false;
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                
                    if (cells[i, 0] != null && cells[i, 1] == cells[i, 0] && cells[i, 1] == cells[i, 2])  //horizontales
                    {
                        MessageBox.Show("HAS GANADO");
                        win = true;
                        return win;
                    }

                    if (cells[0,i] != null && cells[1,i] == cells[0,i] && cells[1,i] == cells[2, i]) //verticales.
                    {
                        MessageBox.Show("HAS GANADO");
                        win = true;
                        return win;
                        
                    }
                //diagonales
                    if(cells[0,0] != null && cells[1,1] == cells[0,0] &&  cells [0,0] == cells[2,2] 
                    || cells[2, 0] != null && cells[1, 1] == cells[2, 0] && cells[2, 0] == cells[0, 2])
                    {
                        MessageBox.Show("HAS GANADO");
                        win = true;
                        return win;
                        
                    }
          
                
                
            }
            return win;
        }
        private void InitializingButtonText()//inicializa texto de cada boton.
        {
            foreach (Control control in this.Controls) //simbolo de interrogacion para cada boton;
            {
                if (control is Button boton && control.Name != "ResetButton")
                {
                    boton.Text = "";
                }
            }
        }
        private void InitializingGame()
        {
            turno = Turn.X;
            InitializingButtonText();
            InitializingArray(3, 3);
        }
        private void InitializingArray(int x, int y)
        {
            cells = new string[x, y];
        }
        private int[] ReturnIndex(int buttonNumber)
        {

            int buttonNumberFixed = buttonNumber - 1;
            int x = 0;
            int y = 0;

            if (buttonNumberFixed <= 2)
            {
                y = 0;
                x = buttonNumberFixed;

            }
            else if (buttonNumberFixed >= 3 && buttonNumberFixed <= 5)
            {
                x = buttonNumberFixed - 3;
                y = 1;

            }
            else
            {
                x = buttonNumberFixed - 6;
                y = 2;
            }
   
            return new int []{ y , x};
        }
        private void ChangeTurn()
        {
            if (turno == Turn.X)
            {
                turno = Turn.O;
            }
            else
            {
                turno = Turn.X;
            }
        }
        private void IntroducionOX(int[] indexCell)
        {
            if (cells[indexCell[0], indexCell[1]] == null)
            {
                if (turno == Turn.X)
                {
                    cells[indexCell[0], indexCell[1]] = "x";
                }
                else if (turno == Turn.O)
                {
                    cells[indexCell[0], indexCell[1]] = "o";
                }
            }
        }
        private void NotWinerFound()
        {
            bool restartGame = true;
            for(int i = 0;  i< cells.GetLength(0); i++)
            {
                for(int j = 0; j < cells.GetLength(1); j++)
                {
                    if(cells[i, j] == null)
                    {
                        restartGame = false;
                    }
                }
            }
            if (restartGame)
            {
                InitializingGame();
            }
        }
        private void WinerFound(bool win)
        {
            if (win)
            {
                InitializingGame();
            }
        }
        private void ButtonTextOX(Button button)
        {
            if (turno == Turn.X && button.Text == "")
            {
                button.Text = "X";
            }
            else if (turno == Turn.O && button.Text == "")
            {
                button.Text = "O";
            }
        }
    }
}
