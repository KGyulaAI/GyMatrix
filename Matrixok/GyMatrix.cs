using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDataModels.AbstractClass;
using WpfDataModels.Interface;

namespace Matrixok
{
    public class GyMatrix : AbsMatrix, IMatrixOperations
    {
        public void Add(AbsMatrix addMatrix)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    this[i, j] += addMatrix[i, j];
                }
            }
        }

        public bool Equals(AbsMatrix other)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    if (this[i, j] != other[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void Fill(double value)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    this[i, j] = value;
                }
            }
        }

        public void FillRandomFloat(double start, double end)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    this[i, j] = (float)(new Random().NextDouble() * (end - start) + start);
                }
            }
        }

        public void FillRandomInt(int start, int end)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    this[i, j] = new Random().Next(start, end);
                }
            }
        }

        public void RotateToDown()
        {
            for (int i = 0; i < ColumnCount; i++)
            {
                double temp = this[0, i];
                for (int j = 0; j < RowCount; j++)
                {
                    this[j, i - 1] = this[j, i];
                }
                this[RowCount - 1, i] = temp;
            }
        }

        public void RotateToLeft()
        {
            for (int i = 0; i < RowCount; i++)
            {
                double temp = this[i, 0];
                for (int j = 0; j < ColumnCount; j++)
                {
                    this[i, j - 1] = this[i, j];
                }
                this[i, ColumnCount - 1] = temp;
            }
        }

        public void RotateToTop()
        {
            for (int i = 0; i < ColumnCount; i++)
            {
                double temp = this[0, i];
                for (int j = 0; j < RowCount; j++)
                {
                    this[j, i + 1] = this[j, i];
                }
                this[RowCount + 1, i] = temp;
            }
        }

        public void RotatetToRight()
        {
            for (int i = 0; i < RowCount; i++)
            {
                double temp = this[i, 0];
                for (int j = 0; j < ColumnCount; j++)
                {
                    this[i, j + 1] = this[i, j];
                }
                this[i, ColumnCount + 1] = temp;
            }
        }

        public void Sub(AbsMatrix subMatrix)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    this[i, j] -= subMatrix[i, j];
                }
            }
        }
    }
}
