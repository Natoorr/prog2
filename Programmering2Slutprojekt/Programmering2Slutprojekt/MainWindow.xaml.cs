using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Programmering2Slutprojekt
{ //TODO: sak som kollar om vit eller svart man som spelar, fixa checkmate?, fixa bilder maybe och fixa färger, promotion system
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyBoard_Loaded(object sender, RoutedEventArgs e) //Creates grid
        {
            for (int i = 0; i < 8; i++)
            {
                var row = new RowDefinition();
                row.Height = new GridLength(95);
                MyBoard.RowDefinitions.Add(row);
                var column = new ColumnDefinition();
                column.Width = new GridLength(95);
                MyBoard.ColumnDefinitions.Add(column);

                for (int j = 0; j < 8; j++)
                {
                    var Square = new Button();
                    Square.Name = "x" + i.ToString() + "y" + j.ToString();
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1)
                    {
                        Square.Background = Brushes.White;
                        Square.Foreground = Brushes.Black;
                    } 
                    else
                    {
                        Square.Background = Brushes.Black;
                        Square.Foreground = Brushes.White;
                    }
                    
                    if (i == 6) //Placed all pieces
                    {
                        Square.Content = "White Pawn";
                    }
                    else if (i == 1)
                    {
                        Square.Content = "Black Pawn";
                    }
                    else if (i == 0 && j == 4)
                    {
                        Square.Content = "Black King";
                    }
                    else if (i == 7 && j == 4)
                    {
                        Square.Content = "White King";
                    }
                    else if (i == 0 && j == 0 || i == 0 && j == 7)
                    {
                        Square.Content = "Black Rook";
                    }
                    else if (i == 7 && j == 0 || i == 7 && j == 7)
                    {
                        Square.Content = "White Rook";
                    }
                    else if (i == 0 && j == 3)
                    {
                        Square.Content = "Black Queen";
                    }
                    else if (i == 7 && j == 3)
                    {
                        Square.Content = "White Queen";
                    }
                    else if (i == 0 && j == 6|| i == 0 && j == 1)
                    {
                        Square.Content = "Black Knight";
                    }
                    else if (i == 7 && j == 6 || i == 7 && j == 1)
                    {
                        Square.Content = "White Knight";
                    }
                    else if (i == 0 && j == 5 || i == 0 && j == 2)
                    {
                        Square.Content = "Black Bishop";
                    }
                    else if (i == 7 && j == 5 || i == 7 && j == 2)
                    {
                        Square.Content = "White Bishop";
                    }
                    else
                    {
                        Square.Content = " ";
                    }

                    Square.Click += new RoutedEventHandler((x, y) =>
                    {   
                        if (Square.Content != " " && Square.Background == Brushes.Black || Square.Content != " " && Square.Background == Brushes.White)
                        {
                            ClearBoard(MyBoard);
                            Square.Background = Brushes.Blue;
                            var currentCol = Grid.GetColumn(Square);
                            var currentRow = Grid.GetRow(Square);
                            char color;
                            char enemy;
                            switch (Square.Content)
                            {  
                                case "Black Knight":
                                    color = 'B';
                                    enemy = 'W';
                                    KnightMovements(color, enemy, currentRow, currentCol, MyBoard);
                                    break;
                                case "White Knight":
                                    color = 'W';
                                    enemy = 'B';
                                    KnightMovements(color, enemy, currentRow, currentCol, MyBoard);
                                    break;

                                case "Black King":
                                    color = 'B';
                                    enemy = 'W';
                                    KingMovements(color, enemy, currentRow, currentCol, MyBoard);
                                    break;
                                case "White King":
                                    color = 'W';
                                    enemy = 'B';
                                    KingMovements(color, enemy, currentRow, currentCol, MyBoard);
                                    break;

                                case "Black Rook":
                                    color = 'B';
                                    enemy = 'W';
                                    RookMovements(color, enemy, currentRow, currentCol, MyBoard);
                                    break;
                                case "White Rook":
                                    color = 'W';
                                    enemy = 'B';
                                    RookMovements(color, enemy, currentRow, currentCol, MyBoard);
                                    break;

                                case "Black Bishop":
                                    color = 'B';
                                    enemy = 'W';
                                    BishopMovements(color, enemy, currentRow, currentCol, MyBoard);
                                    break;
                                case "White Bishop":
                                    color = 'W';
                                    enemy = 'B';
                                    BishopMovements(color, enemy, currentRow, currentCol, MyBoard);
                                    break;

                                case "Black Queen":
                                    color = 'B';
                                    enemy = 'W';
                                    QueenMovements(color, enemy, currentRow, currentCol, MyBoard);
                                    break;
                                case "White Queen":
                                    color = 'W';
                                    enemy = 'B';
                                    BishopMovements(color, enemy, currentRow, currentCol, MyBoard);
                                    break;

                                case "White Pawn":
                                    if (currentRow == 6)
                                    {
                                        for (int k = currentRow - 1; k > currentRow - 3; k--)
                                        {
                                            foreach (var box in MyBoard.Children)
                                            {
                                                if (box is Button button)
                                                {
                                                    if (button.Name == "x" + (k).ToString() + "y" + (currentCol).ToString())
                                                    {
                                                        if (button.Content != " ")
                                                        {
                                                            k = currentCol - 3;
                                                        }
                                                        else
                                                        {
                                                            button.Background = Brushes.Green;
                                                        }
                                                    } 
                                                    else if (button.Name == "x" + (currentRow - 1).ToString() + "y" + (currentCol - 1).ToString() && button.Content != " " && button.Content.ToString().IndexOf('B') == 0)
                                                    {
                                                        button.Background = Brushes.Red;
                                                    }
                                                    else if (button.Name == "x" + (currentRow - 1).ToString() + "y" + (currentCol + 1).ToString() && button.Content != " " && button.Content.ToString().IndexOf('B') == 0)
                                                    {
                                                        button.Background = Brushes.Red;
                                                    }
                                                }
                                            }
                                        }
                                    } else
                                    {
                                        foreach (var box in MyBoard.Children)
                                        {
                                            if (box is Button button)
                                            {
                                                if (button.Name == "x" + (currentRow - 1).ToString() + "y" + (currentCol).ToString())
                                                {
                                                    if (button.Content == " ")
                                                    {
                                                        button.Background = Brushes.Green;
                                                    }
                                                }
                                                else if (button.Name == "x" + (currentRow - 1).ToString() + "y" + (currentCol - 1).ToString() && button.Content != " " && button.Content != " " && button.Content.ToString().IndexOf('B') == 0)
                                                {
                                                    button.Background = Brushes.Red;
                                                }
                                                else if (button.Name == "x" + (currentRow - 1).ToString() + "y" + (currentCol + 1).ToString() && button.Content != " " && button.Content != " " && button.Content.ToString().IndexOf('B') == 0)
                                                {
                                                    button.Background = Brushes.Red;
                                                }
                                            }
                                        }  
                                    }
                                    break;
                                case "Black Pawn":
                                    if (currentRow == 1)
                                    {
                                        for (int k = currentRow + 1; k < currentRow + 3; k++)
                                        {
                                            foreach (var box in MyBoard.Children)
                                            {
                                                if (box is Button button)
                                                {
                                                    if (button.Name == "x" + (k).ToString() + "y" + (currentCol).ToString())
                                                    {
                                                        if (button.Content != " ")
                                                        {
                                                            k = currentCol + 3;
                                                        }
                                                        else
                                                        {
                                                            button.Background = Brushes.Green;
                                                        }
                                                    }
                                                    else if (button.Name == "x" + (currentRow + 1).ToString() + "y" + (currentCol - 1).ToString() && button.Content != " " && button.Content != " " && button.Content.ToString().IndexOf('W') == 0)
                                                    {
                                                        button.Background = Brushes.Red;
                                                    }
                                                    else if (button.Name == "x" + (currentRow + 1).ToString() + "y" + (currentCol + 1).ToString() && button.Content != " " && button.Content != " " && button.Content.ToString().IndexOf('W') == 0)
                                                    {
                                                        button.Background = Brushes.Red;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        foreach (var box in MyBoard.Children)
                                        {
                                            if (box is Button button)
                                            {
                                                if (button.Name == "x" + (currentRow + 1).ToString() + "y" + (currentCol).ToString())
                                                {
                                                    if (button.Content == " ")
                                                    {
                                                        button.Background = Brushes.Green;
                                                    }
                                                }
                                                else if (button.Name == "x" + (currentRow + 1).ToString() + "y" + (currentCol - 1).ToString() && button.Content != " " && button.Content != " " && button.Content.ToString().IndexOf('W') == 0)
                                                {
                                                    button.Background = Brushes.Red;
                                                }
                                                else if (button.Name == "x" + (currentRow + 1).ToString() + "y" + (currentCol + 1).ToString() && button.Content != " " && button.Content != " " && button.Content.ToString().IndexOf('W') == 0)
                                                {
                                                    button.Background = Brushes.Red;
                                                }
                                            }
                                        }
                                    }
                                    break;
                            }

                        } else if (Square.Background == Brushes.Blue) 
                        {
                            ClearBoard(MyBoard);
                            
                        }
                        else if (Square.Background == Brushes.Green || Square.Background == Brushes.Red)
                        {
                            foreach (var box in MyBoard.Children)
                            {
                                if (box is Button button && button.Background == Brushes.Blue)
                                {
                                    Square.Content = button.Content;
                                    button.Content = " ";
                                    ClearBoard(MyBoard);
                                    
                                }
                            }
                        } 
                        

                    });
            Grid.SetRow(Square, i);
            Grid.SetColumn(Square, j);
            MyBoard.Children.Add(Square);
                    
                    
                }
            }
        }
        public static void KnightMovements(char rookColor, char enemy, int currentRow, int currentCol, Grid MyBoard)
        {
            foreach (var box in MyBoard.Children)
            {
                if (box is Button button)
                {
                    if (button.Name == "x" + (currentRow + 2).ToString() + "y" + (currentCol + 1).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow + 2).ToString() + "y" + (currentCol - 1).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow - 2).ToString() + "y" + (currentCol + 1).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow - 2).ToString() + "y" + (currentCol - 1).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow + 1).ToString() + "y" + (currentCol + 2).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow + 1).ToString() + "y" + (currentCol - 2).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow - 1).ToString() + "y" + (currentCol + 2).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow - 1).ToString() + "y" + (currentCol - 2).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                }
            }
        }
        public static void RookMovements(char rookColor, char enemy, int currentRow, int currentCol, Grid MyBoard)
        {
            for (int k = currentRow + 1; k < 8; k++)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (k).ToString() + "y" + (currentCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                k = 8;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                k = 8;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                            }
                        }
                    }
                }
            }
            for (int k = currentRow - 1; k > -1; k--)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (k).ToString() + "y" + (currentCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                k = -1;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                k = -1;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                            }
                        }
                    }
                }
            }
            for (int k = currentCol + 1; k < 8; k++)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (currentRow).ToString() + "y" + (k).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                k = 8;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                k = 8;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                            }
                        }
                    }
                }
            }
            for (int k = currentCol - 1; k > -1; k--)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (currentRow).ToString() + "y" + (k).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                k = -1;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                k = -1;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                            }
                        }
                    }
                }
            }
        }
        public static void KingMovements(char rookColor, char enemy, int currentRow, int currentCol, Grid MyBoard)
        {
            foreach (var box in MyBoard.Children)
            {
                if (box is Button button)
                {
                    if (button.Name == "x" + (currentRow + 1).ToString() + "y" + (currentCol + 1).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow + 1).ToString() + "y" + (currentCol).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow + 1).ToString() + "y" + (currentCol - 1).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow).ToString() + "y" + (currentCol + 1).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow).ToString() + "y" + (currentCol - 1).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow - 1).ToString() + "y" + (currentCol + 1).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                    else if (button.Name == "x" + (currentRow - 1).ToString() + "y" + (currentCol).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        };
                    }
                    else if (button.Name == "x" + (currentRow - 1).ToString() + "y" + (currentCol - 1).ToString())
                    {
                        if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                        {
                            button.Background = Brushes.Red;
                        }
                        else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0) { }
                        else
                        {
                            button.Background = Brushes.Green;
                        }
                    }
                }
            }
        }
        public static void BishopMovements(char rookColor, char enemy, int currentRow, int currentCol, Grid MyBoard)
        {
            int TempCol;
            int TempRow;
            TempCol = currentCol + 1;
            TempRow = currentRow + 1;
            while (TempCol < 8 && TempRow < 8)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {

                        if (button.Name == "x" + (TempRow).ToString() + "y" + (TempCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                TempCol = 8;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                TempCol = 8;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                                TempCol++;
                                TempRow++;
                            }
                        }
                    }
                }
            }
            TempCol = currentCol + 1;
            TempRow = currentRow - 1;
            while (TempCol < 8 && TempRow > -1)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (TempRow).ToString() + "y" + (TempCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                TempCol = 8;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                TempCol = 8;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                                TempCol++;
                                TempRow--;
                            }
                        }
                    }
                }
            }
            TempCol = currentCol - 1;
            TempRow = currentRow + 1;
            while (TempCol > -1 && TempRow < 8)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (TempRow).ToString() + "y" + (TempCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                TempCol = -1;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                TempCol = -1;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                                TempCol--;
                                TempRow++;
                            }
                        }
                    }
                }
            }
            TempCol = currentCol - 1;
            TempRow = currentRow - 1;
            while (TempCol > -1 && TempRow > -1)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (TempRow).ToString() + "y" + (TempCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                TempCol = -1;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                TempCol = -1;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                                TempCol--;
                                TempRow--;

                            }
                        }
                    }
                }
            }
        }
        public static void QueenMovements(char rookColor, char enemy, int currentRow, int currentCol, Grid MyBoard)
        {
            int TempCol;
            int TempRow;
            TempCol = currentCol + 1;
            TempRow = currentRow + 1;
            while (TempCol < 8 && TempRow < 8)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {

                        if (button.Name == "x" + (TempRow).ToString() + "y" + (TempCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                TempCol = 8;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                TempCol = 8;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                                TempCol++;
                                TempRow++;
                            }
                        }
                    }
                }
            }
            TempCol = currentCol + 1;
            TempRow = currentRow - 1;
            while (TempCol < 8 && TempRow > -1)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (TempRow).ToString() + "y" + (TempCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                TempCol = 8;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                TempCol = 8;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                                TempCol++;
                                TempRow--;
                            }
                        }
                    }
                }
            }
            TempCol = currentCol - 1;
            TempRow = currentRow + 1;
            while (TempCol > -1 && TempRow < 8)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (TempRow).ToString() + "y" + (TempCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                TempCol = -1;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                TempCol = -1;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                                TempCol--;
                                TempRow++;
                            }
                        }
                    }
                }
            }
            TempCol = currentCol - 1;
            TempRow = currentRow - 1;
            while (TempCol > -1 && TempRow > -1)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (TempRow).ToString() + "y" + (TempCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                TempCol = -1;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                TempCol = -1;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                                TempCol--;
                                TempRow--;

                            }
                        }
                    }
                }
            }

            for (int k = currentRow + 1; k < 8; k++)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (k).ToString() + "y" + (currentCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                k = 8;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                k = 8;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                            }
                        }
                    }
                }
            }
            for (int k = currentRow - 1; k > -1; k--)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (k).ToString() + "y" + (currentCol).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                k = -1;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                k = -1;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                            }
                        }
                    }
                }
            }
            for (int k = currentCol + 1; k < 8; k++)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (currentRow).ToString() + "y" + (k).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                k = 8;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                k = 8;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                            }
                        }
                    }
                }
            }
            for (int k = currentCol - 1; k > -1; k--)
            {
                foreach (var box in MyBoard.Children)
                {
                    if (box is Button button)
                    {
                        if (button.Name == "x" + (currentRow).ToString() + "y" + (k).ToString())
                        {
                            if (button.Content != " " && button.Content.ToString().IndexOf(enemy) == 0)
                            {
                                button.Background = Brushes.Red;
                                k = -1;
                            }
                            else if (button.Content != " " && button.Content.ToString().IndexOf(rookColor) == 0)
                            {
                                k = -1;
                            }
                            else
                            {
                                button.Background = Brushes.Green;
                            }
                        }
                    }
                }
            }
        }
        public static void ClearBoard(Grid MyBoard)
        {
            foreach (var box in MyBoard.Children)
            {
                if (box is Button temporary)
                {
                    int tempRow = Grid.GetRow(temporary);
                    int tempCol = Grid.GetColumn(temporary);
                    if (tempRow % 2 == 0 && tempCol % 2 == 0 || tempRow % 2 == 1 && tempCol % 2 == 1)
                    {
                        temporary.Background = Brushes.White;
                    }
                    else
                    {
                        temporary.Background = Brushes.Black;
                    }
                }
            }
        }
    }
}
