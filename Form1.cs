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
            InitializeGame();
            
        }
        private void OnClick(object sender, EventArgs e)//click en botton
        {
            GameLogic(sender); //logica del juego.
        }//OnClick();
        private int ButtonSelected(object sender)//boton seleccionado.
        {
            Button button = (Button)sender;
            int buttonNumber = int.Parse(button.Name.Replace("button", ""));
            return buttonNumber;
        }//ButtonSelected();
        private bool CheckWin() // Comprobar si hay ganador.
        {
            bool win = false;
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                
                    if (cells[i, 0] != null && cells[i, 1] == cells[i, 0] && cells[i, 1] == cells[i, 2])  //horizontales
                    {
                        MessageBox.Show("3 EN RAYA!!! \n VICTORIA PARA EL JUGADOR " + turno.ToString());
                        win = true;
                        return win;
                    }

                    if (cells[0,i] != null && cells[1,i] == cells[0,i] && cells[1,i] == cells[2, i]) //verticales.
                    {
                    MessageBox.Show("3 EN RAYA!!! \n VICTORIA PARA EL JUGADOR " + turno.ToString());
                    win = true;
                        return win;
                        
                    }
                //diagonales
                    if(cells[0,0] != null && cells[1,1] == cells[0,0] &&  cells [0,0] == cells[2,2] 
                    || cells[2, 0] != null && cells[1, 1] == cells[2, 0] && cells[2, 0] == cells[0, 2])
                    {
                    win = true;
                    MessageBox.Show("3 EN RAYA!!! \n VICTORIA PARA EL JUGADOR " + turno.ToString());
                        return win;
                        
                    }
          
                
                
            }
            return win;
        }//CheckingWin();
        private void InitializeButtonText()//inicializa texto de cada boton.
        {
            foreach (Control control in this.Controls) //simbolo de interrogacion para cada boton;
            {
                if (control is Button boton && control.Name != "ResetButton")
                {
                    boton.Text = "";
                }
            }
        }//InitializingButtonText();
        private void InitializeGame() //inicializa el juego 
        {
            turno = Turn.X;
            InitializeButtonText();
            InitializeArray(3, 3);
        }//InitializingGame();
        private void InitializeArray(int x, int y)  //inicializando el array.
        {
            cells = new string[x, y];
        }//InitializingArray();
        private int[] ReturnIndex(int buttonNumber) //devuelve el indice x e y del boton clickado.
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
        }//ReturnIndex();
        private void ChangeTurn()//cambiar turno
        {
            if (turno == Turn.X)
            {
                turno = Turn.O;
            }
            else
            {
                turno = Turn.X;
            }
        }//ChangeTurn();
        private void IntroduceOX(int[] indexCell)//Introduciendo x o o en el array de cells.
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
        }//IntroducionOX();
        private void WinerNotFound()//Comprueba si no hay ganador y si todas las casliias completas entonces  reinicia el juego
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
                MessageBox.Show("DRAW");
                InitializeGame();
            }
        }//NotWinerFound();
        private void WinerFound(bool win)//si hay ganador reinicializa 
        {
            if (win)
            {
                InitializeGame();
            }
        }//juego();
        private void DrawTurn() //Dibuja el jugador que tiene el turno.
        {
            TurnLable.Text = turno.ToString();
        }//DrawTurn();
        private void ChangeButtonTextOX(Button button)//Cambia el texto de los botones a X o a O 
        {
            if (turno == Turn.X && button.Text == "")
            {
                button.Text = "X";
            }
            else if (turno == Turn.O && button.Text == "")
            {
                button.Text = "O";
            }
        }//ButtonTextOX();
        private void GameLogic(object sender)//Logica del Juego
        {
            Button button = (Button)sender; //boton clickado.
            int buttonNumber = ButtonSelected(sender); //numero del boton.
            int[] indexCell = ReturnIndex(buttonNumber); //indice de la celda que coincide con el boton.
            IntroduceOX(indexCell); //introduciendo x o o en el array de celdas.
            ChangeButtonTextOX(button); //cambia el texto del boton dependiendo del turno.
            bool win = CheckWin(); //comprueba si alguien ha ganado.
            WinerFound(win); //si hay ganador reinicializa todo.
            WinerNotFound();//si no hay ganador y todas las casillas estan llenas reinicia todo.
            ChangeTurn(); //cambiar turno.
            DrawTurn();//Dibujar Turno.
        }//GameLogic();
    }
}
