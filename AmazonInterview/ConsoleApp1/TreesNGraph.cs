using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmzMain
{
    public class TreesNGraph
    {


        public BinaryTree<int> PopulateBinarySTree()
        {
            return new BinaryTree<int>
            {
                Node = 10,
                Left = new BinaryTree<int>
                {
                    Node = 7,
                    Left = new BinaryTree<int>
                    {
                        Node = 6,
                    },
                    Right = new BinaryTree<int>
                    {
                        Node = 3
                    }
                },
                Right = new BinaryTree<int>
                {
                    Node =13,
                    Left = new BinaryTree<int>
                    {
                        Node = 11
                    },
                    Right = new BinaryTree<int>
                    {
                        Node = 15,
                        Left = new BinaryTree<int>
                        {
                            Node = 14
                            

                        }

                    }
                }
            };
        }

        public BinaryTree<int> PopulateBinaryTree()
        {
            return new BinaryTree<int>
            {
                Node = 1,
                Left = new BinaryTree<int>
                {
                    Node = 2,
                    Left = new BinaryTree<int>
                    {
                        Node = 3,
                    },
                    Right = new BinaryTree<int>
                    {
                        Node = 11
                    }
                },
                Right = new BinaryTree<int>
                {
                    Node = 6,
                    Left = new BinaryTree<int>
                    {
                        Node = 7
                    },
                    Right = new BinaryTree<int>
                    {
                        Node = 8,
                        Left = new BinaryTree<int>
                        {
                            Node = 9,
                            Left = new BinaryTree<int>
                            {
                                Node = 10
                            }


                        }

                    }
                }
            };
        }


        public void InOrder(BinaryTree<int> input)
        {
            if (input == null) return;

            InOrder(input.Left);

            Console.WriteLine(input.Node);

            InOrder(input.Right);
        }

        public void PreOrder(BinaryTree<int> input)
        {
            if (input == null) return;

            Console.WriteLine(input.Node);
            PreOrder(input.Left);
            PreOrder(input.Right);
        }

        public void PostOrder(BinaryTree<int> input)
        {
            if (input == null) return;

            Console.WriteLine(input.Node);
            PostOrder(input.Left);
            PostOrder(input.Right);
        }


        public class Graph<T>
        {
            public Graph()
            {
                Adjacent = new List<Graph<T>>();
            }
            public T Node { get; set; }

            public bool IsVisited { get; set; }
            public List<Graph<T>> Adjacent { get; set; }

        }

        public Graph<int> PopulateGraph()
        {
            return new Graph<int>
            {
                Node = 1,
                Adjacent = new List<Graph<int>>
            {
                new Graph<int>
                {
                    Node = 2,
                    Adjacent = new List<Graph<int>>
                    {
                        new Graph<int>
                        {
                            Node = 3,
                            Adjacent = new List<Graph<int>>
                            {
                                new Graph<int>
                                {
                                    Node = 4
                                },
                                new Graph<int>
                                {
                                    Node = 5
                                },
                                new Graph<int>
                                {
                                    Node = 6
                                },
                            }
                        },
                        new Graph<int>
                        {
                            Node = 7,
                            Adjacent = new List<Graph<int>>
                            {
                                new Graph<int>
                                {
                                    Node =8
                                },
                                new Graph<int>
                                {
                                    Node = 9
                                },
                                new Graph<int>
                                {
                                    Node = 10
                                },
                            }
                        }
                    }
                }
            }
            };
        }

        public void DFS(Graph<int> input)
        {
            if (input == null) return;
            Console.WriteLine(input.Node);
            input.IsVisited = true;
            foreach (var g in input.Adjacent)
            {
                if (!g.IsVisited)
                    DFS(g);
            }
        }

        public void BFS(Graph<int> input)
        {
            if (input == null) return;
            Console.WriteLine(input.Node);
            input.IsVisited = true;
            var queue = new Queue<Graph<int>>();
            queue.Enqueue(input);
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                foreach (var g in node.Adjacent)
                {
                    if (!g.IsVisited)
                    {
                        Console.WriteLine(g.Node);
                        g.IsVisited = true;
                        queue.Enqueue(g);
                    }
                }
            }

        }
        public bool IsBalancedTree(BinaryTree<int> binaryTree)
        {
            //Base case
            if (binaryTree == null) return true;
            var absHeight = GetHeights(binaryTree.Left) - GetHeights(binaryTree.Right);

            if (absHeight > 1)
            {
                return false;
            }
            else
            {
                return IsBalancedTree(binaryTree.Left) && IsBalancedTree(binaryTree.Right);
            }
        }

        private int GetHeights(BinaryTree<int> binaryTree)
        {
            //Base Case
            if (binaryTree == null) return 0;
            return Math.Max(GetHeights(binaryTree.Left), GetHeights(binaryTree.Right)) + 1;
        }


        public bool FindingTheRouteBTW2Nodes(Graph<int> graph, int start, int end)
        {
            //Basecase 
            if (start == end) return true;
            graph.IsVisited = true;
            var queue = new Queue<Graph<int>>();
            queue.Enqueue(graph);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                foreach (var g in node.Adjacent)
                {
                    if (!g.IsVisited)
                    {
                        g.IsVisited = true;
                        if (g.Node == end)
                            return true;
                        else
                            queue.Enqueue(g);
                    }
                }
            }
            return false;

        }

        public BinaryTree<int> CreateMinimalBinaryTree(int[] arr, int start, int end)
        {
            //BaseCase 
            if (end < start)
                return null;

            var mid = (start + end) / 2;

            if (mid >= arr.Length) return null;
            var n = new BinaryTree<int>()
            {
                Node = arr[mid],
                Left = CreateMinimalBinaryTree(arr, start, mid - 1),
                Right = CreateMinimalBinaryTree(arr, mid + 1, end)
            };
            return n;
        }


        public string output = string.Empty;
        public void ConvertBTtoString(BinaryTree<int> binaryTree)
        {
            if (binaryTree == null)
            {
                output += " 0 ";
                return;
            }
            ConvertBTtoString(binaryTree.Left);
            if (!binaryTree.IsVisited)
            {
                output += (binaryTree.Node.ToString());
                binaryTree.IsVisited = true;
            }
            ConvertBTtoString(binaryTree.Right);
        }


        public int FindMax(BinaryTree<int> tree)
        {
            var max = int.MinValue;
            if (tree == null) return max;
            if (tree.Left == null && tree.Right == null) return tree.Node;
            var leftMax = FindMax(tree.Left);
            var rightMax = FindMax(tree.Right);
            if (max < rightMax)
            {
                max = rightMax;
            }
            if (max < leftMax)
            {
                max = leftMax;
            }
            return max;
        }


        public List<string> PopulateWords(List<string> input, List<string> cities)
        {
            PopulateWords(input, 10, 10);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (input[i].ElementAt(j) == '-')
                    {
                        PopulateWords(input, i, j);
                        return null;
                    }
                }
            }
            return null;
        }

        private char[,] Path = new char[10, 10];
        private List<string> PathInString = new List<string>();
        private bool[,] Visited = new bool[10, 10];
        private int[,] adjacencies = new int[4, 2] { { 1, 0 }, { 0, 1 }, { 0, -1 }, { -1, 0 } };
        public void PopulateWords(List<string> input, int row, int col)
        {
            if (row > -1 && row < 10 && col > -1 && col < 10 && input[row].ElementAt(col) == '-')
            {
                Path[row, col] = input[row].ElementAt(col);
                PathInString.Add(string.Format("{0},{1}", row, col));
                Visited[row, col] = true;

                for (int i = 0; i <= adjacencies.GetUpperBound(0); i++)
                {
                    var x = row + adjacencies[i, 0];
                    var y = col + adjacencies[i, 1];
                    if (x > -1 && x < 10 && y > -1 && y < 10 && !Visited[x, y])
                        PopulateWords(input, x, y);
                }
            }
            foreach (var e in PathInString)
            {
                Console.WriteLine(e);
            }
            PathInString.Clear();
            Console.WriteLine("---------------------------------");
            return;
        }


        public void DrawWords()
        {
            for (int i = 0; i < 10; i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < 10; j++)
                {
                    if (Path[i, j] != '-') sb.Append("+");
                    else
                        sb.Append(Path[i, j]);
                }
                Console.WriteLine(sb.ToString());
            }
        }

        public void ChooseWords(List<int> Cities)
        {
            //foreach (var city in Cities)
            //{
            //    for (int i = 0; i < PathInString.Count; i++)
            //    {
                   

            //    }
            //}
        }


    }


}
