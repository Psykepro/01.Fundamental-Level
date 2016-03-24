
    using System;
    using System.Text;

public class Matrix
{
    private readonly int N;

    private int col;

    private int currentNumber = 1;

    private int increasingStepX = 1;

    private int increasingStepY = 1;

    private int row;

    public Matrix(int n)
    {
        this.N = n;
        this.MatrixProperty = new int[n, n];
    }

    public int[,] MatrixProperty { get; private set; }

    public void Run()
    {
        while (true)
        {
            this.MatrixProperty[this.row, this.col] = this.currentNumber;

            if (!this.CheckForEmptyCell())
            {
                break;
            }

            this.CheckForGettingOutOfTheMatrix(
                this.MatrixProperty,
                this.row,
                this.col,
                ref this.increasingStepX,
                ref this.increasingStepY,
                this.N);

            this.row += this.increasingStepX;
            this.col += this.increasingStepY;
            this.currentNumber++;
        }

        if (this.N > 4)
        {
            this.MovingToDownLeftCornerOfTheMatrix();
        }

        this.PrintingTheMatrix();
    }

    public void PrintingTheMatrix()
    {
        for (int i = 0; i < this.N; i++)
        {
            for (int j = 0; j < this.N; j++)
            {
                Console.Write("{0,3}", this.MatrixProperty[i, j]);
            }

            Console.WriteLine();
        }
    }

    private void MovingToDownLeftCornerOfTheMatrix()
    {
        this.MoveToEmptyCell();
        if (row != 0 && col != 0)
        {
            while (true)
            {
                MatrixProperty[row, col] = currentNumber;
                if (!this.CheckForEmptyCell())
                {
                    break;
                }

                if (row + increasingStepX >= N || row + increasingStepX < 0 || col + increasingStepY >= N || col + increasingStepY < 0
                    || MatrixProperty[row + increasingStepX, col + increasingStepY] != 0)
                {
                    while (row + increasingStepX >= N || row + increasingStepX < 0 || col + increasingStepY >= N || col + increasingStepY < 0
                           || MatrixProperty[row + increasingStepX, col + increasingStepY] != 0)
                    {
                        this.ChangeDirection();
                    }
                }

                row += increasingStepX;
                col += increasingStepY;
                currentNumber++;
            }
        }
    }

    private void ChangeDirection()
    {
        int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };

        int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
        int currentNumber = 0;
        for (int clockCount = 0; clockCount < 8; clockCount++)
        {
            if (directionsX[clockCount] == this.increasingStepX && directionsY[clockCount] == this.increasingStepY)
            {
                currentNumber = clockCount;
                break;
            }
        }

        if (currentNumber == 7)
        {
            this.increasingStepX = directionsX[0];
            this.increasingStepY = directionsY[0];
            return;
        }

        this.increasingStepX = directionsX[currentNumber + 1];

        this.increasingStepY = directionsY[currentNumber + 1];
    }

    private bool CheckForEmptyCell()
    {
        int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
        for (int i = 0; i < 8; i++)
        {
            if (this.row + directionsX[i] >= this.MatrixProperty.GetLength(0) || this.row + directionsX[i] < 0)
            {
                directionsX[i] = 0;
            }

            if (this.col + directionsY[i] >= this.MatrixProperty.GetLength(0) || this.col + directionsY[i] < 0)
            {
                directionsY[i] = 0;
            }
        }

        for (int i = 0; i < 8; i++)
        {
            if (this.MatrixProperty[this.row + directionsX[i], this.col + directionsY[i]] == 0)
            {
                return true;
            }
        }

        return false;
    }

    private void MoveToEmptyCell()
    {
        for (int i = 0; i < this.MatrixProperty.GetLength(0); i++)
        {
            for (int j = 0; j < this.MatrixProperty.GetLength(0); j++)
            {
                if (this.MatrixProperty[i, j] == 0)
                {
                    this.row = i;
                    this.col = j;
                    return;
                }
            }
        }
    }

    

    private void CheckForGettingOutOfTheMatrix(
        int[,] matrix,
        int i,
        int j,
        ref int movingStepX,
        ref int movingStepY,
        int n)
    {
        if (i + movingStepX >= n || i + movingStepX < 0 || j + movingStepY >= n || j + movingStepY < 0
            || matrix[i + movingStepX, j + movingStepY] != 0)
        {
            while (i + movingStepX >= n || i + movingStepX < 0 || j + movingStepY >= n || j + movingStepY < 0
                   || matrix[i + movingStepX, j + movingStepY] != 0)
            {
                this.ChangeDirection();
            }
        }
    }

   
}