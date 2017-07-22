using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmzMain
{
    class Trie
    {
    }

    public class TrieNode
    {
        public string Word { get; set; }
        public List<TrieNode> Children { get; set; }

        public bool IsSentence { get; set; }
        public TrieNode()
        {
            Children = new List<TrieNode>();
        }
        public TrieNode(string str)
        {
            Word = str;
            Children = new List<TrieNode>();
        }
        private bool isParentFound = false;
        public void Insert(string parent, string str)
        {
           
            if (this.Children.Count == 0 && this.Word == parent)
            {
                this.Children.Add(new TrieNode(str));
                return;
            }

            if (parent == null)
            {
                this.Children.Add(new TrieNode(str));
                return;
            }

            foreach (var child in this.Children)
            {
                if (child.Word == parent)
                {
                    isParentFound = true;
                    child.Children.Add(new TrieNode(str));
                }
                else
                    child.Insert(parent, str);
            }

            //if (this.Word == null && !isParentFound )
            //{
            //    isParentFound = !isParentFound;
            //    this.Children.Add(new TrieNode(parent));
            //}
        }

        public void PrintPretty(string indent, bool last)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("\\-");
                indent += "  ";
            }
            else
            {
                Console.Write("|-");
                indent += "| ";
            }
            Console.WriteLine(Word);

            for (int i = 0; i < Children.Count; i++)
                Children[i].PrintPretty(indent, i == Children.Count - 1);
        }
    }
}
