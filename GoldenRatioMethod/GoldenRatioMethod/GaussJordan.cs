using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenRatioMethod
{
  class GaussJordanMethod
  {
    int N;
    double[,] Matrix;
    double[,] MatrixA;
    double[] MatrixB;

    public GaussJordanMethod(double[,] matrix, int N)
    {
      this.N = N;
      Matrix = matrix;
      MatrixA = new double[N, N];
      MatrixB = new double[N];
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

    private double[,] ToDiagonal(double[,] Matrix)
    {
      double[,] Result = Matrix;

      for (int LeadingElement = 0; LeadingElement < N; ++LeadingElement)
      {
        for (int RowIndex = 0; RowIndex < N; ++RowIndex)
        {
          if (RowIndex != LeadingElement)
          {
            for (int ClolumnIndex = 0; ClolumnIndex < N; ++ClolumnIndex)
            {
              if (ClolumnIndex != LeadingElement)
              {
                Result[RowIndex, ClolumnIndex] = (Result[RowIndex, ClolumnIndex] * Result[LeadingElement, LeadingElement]) - (Result[RowIndex, LeadingElement] * Result[LeadingElement, ClolumnIndex]);
              }
            }
          }
        }

        for (int RowIndex = 0; RowIndex < N; ++RowIndex)
        {
          if (RowIndex != LeadingElement)
          {
            Result[LeadingElement, RowIndex] = 0;
          }
        }
      }

      for (int DiagonalIndex = 0; DiagonalIndex < N; ++DiagonalIndex)
      {
        if (Result[DiagonalIndex, DiagonalIndex] == 0)
        {
          return Result;
        }
      }

      bool Key = true;
      for (int DiagonalIndex = 0; DiagonalIndex < N; ++DiagonalIndex)
      {
        if (Result[DiagonalIndex, DiagonalIndex] % Result[N - 1, N - 1] != 0)
        {
          Key = false;
        }
      }
      if (Key = true)
      {
        for (int DiagonalIndex = 0; DiagonalIndex < N; ++DiagonalIndex)
        {
          Result[DiagonalIndex, DiagonalIndex] = Result[DiagonalIndex, DiagonalIndex] / Result[N - 1, N - 1];
        }
      }
      return Result;
    }


    public double[] GaussJordan()
    {
      ToDiagonal(Matrix);
      ShareMatrix();
      double[] result = new double[N];

      for (int i = 0; i < N; ++i)
      {
        result[i] = MatrixB[i] / MatrixA[i, i];
      }

      return result;
    }
  }
}
