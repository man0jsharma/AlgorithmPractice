using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public TreeNode(int data)
        {
            val = data;
        }

        public enum NodePosition
        {
            left,
            right,
            center
        }

        public void Print()
        {
            PrintPretty("", NodePosition.center, true, false);
        }
        private void PrintValue(string value, NodePosition nodePostion)
        {
            switch (nodePostion)
            {
                case NodePosition.left:
                    PrintLeftValue(value);
                    break;
                case NodePosition.right:
                    PrintRightValue(value);
                    break;
                case NodePosition.center:
                    Console.WriteLine(value);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void PrintLeftValue(string value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("L:");
            Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void PrintRightValue(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("R:");
            Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void PrintPretty(string indent, NodePosition nodePosition, bool last, bool empty)
        {

            Console.Write(indent);
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }

            var stringValue = empty ? "-" : val.ToString();
            PrintValue(stringValue, nodePosition);

            if (!empty && (this.left != null || this.right != null))
            {
                if (this.left != null)
                    this.left.PrintPretty(indent, NodePosition.left, false, false);
                else
                    PrintPretty(indent, NodePosition.left, false, true);

                if (this.right != null)
                    this.right.PrintPretty(indent, NodePosition.right, true, false);
                else
                    PrintPretty(indent, NodePosition.right, true, true);
            }
        }
    }
}
