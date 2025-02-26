namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Button[,] _boxes = new Button[3, 3];
        private bool _isxTurn = true;
        public Form1()
        {
            GenerateBoxes();
            InitializeComponent();
        }
        private void GenerateBoxes()
        {
            for (int i = 0; i < _boxes.GetLength(0); i++)
            {
                for (int j = 0; j < _boxes.GetLength(1); j++)
                {
                    var box = new Button();
                    box.Height = 75;
                    box.Width = 75;
                    box.Top = 230 + i * 80;
                    box.Left = 280 + j * 80;
                    box.BackColor= Color.AntiqueWhite;

                    box.Click += Box_Click;

                    _boxes[i, j] = box;
                    Controls.Add(box);
                }
            }

        }

        private void Box_Click(object? sender, EventArgs e)
        {
            var Box = sender as Button;

            if (Box == null) return;
            if (Box.Text != "") return;
            Box.Text = _isxTurn ? "X" : "O";
            _isxTurn = !_isxTurn;

            CheckWin();

        }
        private void CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                
                bool isWin = _boxes[i, 0].Text == _boxes[i, 1].Text &&
                    _boxes[i, 1].Text == _boxes[i, 2].Text && _boxes[i, 0].Text != "";
                if (isWin)
                {
                    ChangeColour([_boxes[i, 0], _boxes[i, 1], _boxes[i, 2]]);
                 //  MessageBox.Show($"{_boxes[i, 0].Text} Win");
                    lblResMessage.Text = $"{_boxes[i, 0].Text} Win";



                    return;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                bool isWin = _boxes[0, i].Text == _boxes[1, i].Text &&
                    _boxes[1, i].Text == _boxes[2, i].Text && _boxes[0, i].Text != "";
                if (isWin)
                {
                    ChangeColour([_boxes[0, i], _boxes[1, i], _boxes[2, i]]);
                   // MessageBox.Show($"{_boxes[0, i].Text} Win");
                    lblResMessage.Text = $"{_boxes[0, i].Text} Win";
                    return;
                }
            }

            bool isDiagonalWin = _boxes[0, 0].Text == _boxes[1, 1].Text && _boxes[1, 1].Text == _boxes[2, 2].Text && _boxes[0, 0].Text != "";
            if (isDiagonalWin)
            {
                ChangeColour([_boxes[0, 0], _boxes[1, 1], _boxes[2, 2]]);
               // MessageBox.Show($"{_boxes[0, 0].Text} Win");
                lblResMessage.Text = $"{_boxes[0, 0].Text} Win";
                return;
            }


            isDiagonalWin = _boxes[2, 0].Text == _boxes[1, 1].Text && _boxes[1, 1].Text == _boxes[0, 2].Text && _boxes[2, 0].Text != "";

            if (isDiagonalWin)
            {


                //MessageBox.Show($"{_boxes[2, 0].Text} Win!!!");
                lblResMessage.Text = $"{_boxes[2, 0].Text} Win";


                return;
            }


        }
        private void ChangeColour(Button[] boxes)
        {
            foreach (var box in boxes)
            {
                box.BackColor = Color.Green;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblResultMessage.Text = "";
            for (int i = 0; i < _boxes.GetLength(0); i++)
            {
                for (int j = 0; j < _boxes.GetLength(1); j++)
                {
                    _boxes[i, j].Text = "";
                    _boxes[i, j].BackColor = Color.AntiqueWhite;
                }
            }
        }
    }
}
