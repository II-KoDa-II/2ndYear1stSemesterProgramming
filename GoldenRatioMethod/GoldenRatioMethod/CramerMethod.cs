using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenRatioMethod
{
  class CramerMethod
  {
    int N;
    double[,] Matrix;
    double[,] MatrixA;
    double[] MatrixB;

    public CramerMethod(double[,] matrix, int N)
    {
      this.N = N;
      Matrix = matrix;
      MatrixA = new double[N, N];
      MatrixB = new double[N];
    }

    static double determinant(double[,] m)
    {
      int numRows = m.GetLength(0);
      int numCols = m.GetLength(1);
      int n = numCols;
      double[,] matrix = new double[n, n];
      matrix = m;

      for (int k = 1; k < n; k++)
      {
        for (int i = k; i < n; i++)
        {
          double C = matrix[i, k - 1] / matrix[k - 1, k - 1];
          for (int j = 0; j < numCols; j++)
          {
            matrix[i, j] -= C * matrix[k - 1, j];
          }
        }
      };
      double result = 1;
      for (int i = 0; i < n; i++)
      {
        result *= matrix[i, i];
      };
      return result;
    }

    private void ShareMatrix()
    {
      for (int i = 0; i < N; ++i)
      {
        for (int j = 0; j < N; ++j)
        {
          MatrixA[i, j] = Matrix[i, j];
        }
      }

      for (int i = 0; i < N; ++i)
      {
        MatrixB[i] = Matrix[i, N];
      }
    }

    public double[] Cramer()
    {
      ShareMatrix();
      double[,] MatrixForDet = MatrixA.Clone() as double[,];
      double detMatrix = determinant(MatrixForDet);
      double[] result = new double[N];

      for (int c = 0; c < N; ++c)
      {
        double[,] NewMatriX = new double[N, N];
        for (int i = 0; i < N; ++i)
        {
          for(int j = 0; j < N; ++j)
          {
            if(j == c)
            {
              NewMatriX[i, j] = MatrixB[i];
            }
            else
            {
              NewMatriX[i, j] = MatrixA[i, j];
            }
          }
        }
        result[c] = determinant(NewMatriX) / detMatrix;
      }
      return result;
    }
  }
}
