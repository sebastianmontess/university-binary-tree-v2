using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityBinaryTree_V2
{
    class UniversityTree
    {

        public PositionNode Root;
        private float LongestSal = 0;
        private int count = 0;

        public float getLongestSal()
        {
            return LongestSal;
        }

        public void setLongestSal(float LongestSal)
        {
            this.LongestSal = LongestSal;
        }

        public void CreatePosition(PositionNode parent,
            Position positionToCreate, string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;

            if (Root == null)
            {
                Root = newNode;
                return;
            }
            if (parent == null)
            {
                return;
            }

            if (parent.Position.Name == parentPositionName)
            {
                if (parent.Left == null)
                {
                    parent.Left = newNode;
                    return;
                }
                parent.Right = newNode;
                return;
            }

            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Right, positionToCreate, parentPositionName);
        }

        public void PrintTree(PositionNode from)
        {
            if (from == null)
            {
                return;
            }

            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");

            PrintTree(from.Left);
            PrintTree(from.Right);
        }

        public float AddSalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Right);


        }
        public void LongestSalary(PositionNode from)
        {
            if (from == null)
            {
                return;
            }
            if (from != Root)
            {

                if (from.Position.Salary > getLongestSal())
                {
                    setLongestSal(from.Position.Salary);
                }
            }

            LongestSalary(from.Left);
            LongestSalary(from.Right);
        }

        public int CountNodes(PositionNode from)
        {
            if (from == null)
            {
                return count;
            }
            count++;
            CountNodes(from.Left);
            CountNodes(from.Right);
            return count;
        }

        public float SalaryAverage()
        {
            return (AddSalaries(Root) / CountNodes(Root));
        }

        public float SalaryPosition(PositionNode from, String certainPosition)
        {
            if (from == null)
            {
                return 0;
            }
            if (from.Position.Name == certainPosition)
            {
                return from.Position.Salary;
            }
            return SalaryPosition(from.Right, certainPosition) + SalaryPosition(from.Left, certainPosition);
        }

        public double TotalTaxes(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return (from.Position.Salary * from.Position.tax) + TotalTaxes(from.Left) + TotalTaxes(from.Right);
        }
    }
}
