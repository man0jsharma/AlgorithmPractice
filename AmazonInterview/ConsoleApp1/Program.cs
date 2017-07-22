using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmzMain
{
    class Program
    {
        public static void Main(string[] args)
        {
            //CallingBinaryTreeTraversal();
            //CallingDFS();
            //CallingBFS();
            //CallingIsBalanced();

            //CallingFindingRoutes();

            //CallingCreateMiniBST();

            //CallingCallingBSTToString();

            //CallingFindingConsecutive();
            //FindingTheMinNumberByPattern();
            //SortingNumbers();

            //QuickSort();

            //MergeTwoArray();
            //StudyRecursive();
            //MatrixTraversal();
            //BFSOnAGridGraph();

            //MultiplyLinkedLists();

            //RemoveDuplicatesinLinkedList();

            //isPalindrome();

            //FindTheBiggestCross();
            //maxConsecutiveSequenceOfBTree();
            //MergeAndRemoveDuplicatesInLinkedLists();

            //ReverseLinkedList();
            //ReverseLinkedList1();
            //FindContradictionOfEquations();
            //MergeIntervals();
            //FindItsParent();
            //MaxTimeOfTask();
            //CheckRecursionReturnResult();
            //CheckPriorityQueue();

            //Dijkstra();
            //ShuffleArray();
            //findtheClosestManager();
            //BraketAnaltics();
            //BinarySearch();
            //FindtheNthElement();
            //MergeSortedArray();
            //FindMax();
            //Understanding2Recursion();
            //PopulateValues();

            //RemoveDuplicatesInString();
            //isUniqueChars();
            //FermatLast();
            //TrieCheck();
            //PowerOfSum();

            //StringConversion();

            ////RemoveDuplicatesInStringRecursion();

            //getMaxLen();
            //RecursionColumnWise();

            //LargestSumOfContiguousArray();
            //Adding2LinkedList();
            //Summation();
            //Permutation();
            // BiggestSquareInMatrix();
            //UnderstandingRecursion();
            //FormatArray();
            //CheckBST();
            //NonAdjacentSum();
            //MetaString();

            //ReverseASentence();

            //SumPath();
            //EquationEvaluation();
            //CrossWords();

            // LengthOfLongestSubstring2();
            //CombinationOfArray();
            //SwapPairsInLinkedList();
            //RemoveElementInArray();
            //FindTheDifference();
            //FindTheSingleNumber();
            //RecommendationSys();

            //MaxPrices();
            //MostFrequentWords();
            substrAnagram();
            Console.ReadLine();
        }

        private static void substrAnagram()
        {
            var obj = new CareerCupQnA();
            obj.substrAnagram("abdcghaabcbcdij", "bcda");
        }
        private static void MostFrequentWords()
        {
            var obj = new CareerCupQnA();
            obj.MostFrequentWords("this is test test again");
        }
        private static void MaxPrices()
        {
            var obj = new CareerCupQnA();

            Console.WriteLine(obj.MaxStockPrice(new int[] { 25, 30, 48, 15, 25, 45, 10, 25 }));
        }

        private static void RecommendationSys()
        {
            var obj = new CareerCupQnA.RecommendationAmazon();

            obj.LargestItemAssociation(new string[,] { { "it1", "it2" }, { "it3", "it4" } , { "it4", "it5" } });
        }

        private static void FindTheSingleNumber()
        {
            Console.WriteLine(new CareerCupQnA().FindTheSingleNumber(new int[] { 2, 2, 2, 3 }));
        }
        private static void FindTheDifference()
        {
            Console.WriteLine(new CareerCupQnA().FindTheDifference("abcd", "abcde"));
        }
        private static void RemoveElementInArray()
        {
            Console.WriteLine(new CareerCupQnA().RemoveElementInArray(new int[] { 2,2,3 }, 2));
            Console.WriteLine(new CareerCupQnA().RemoveElementInArray(new int[] {3, 2, 2, 3 }, 3));
        }
        private static void SwapPairsInLinkedList()
        {
            var linkedList = new myLinkedList<int>();
            var number1 = new myLinkedList<int>
            {
                data = 1,
                Next = new myLinkedList<int>
                {
                    data = 2,
                    Next = new myLinkedList<int>
                    {
                        data =3,
                        Next = new myLinkedList<int>
                        {
                            data = 4,
                            Next = new myLinkedList<int>
                            {
                                data = 5
                            }
                        }
                    }

                }
            };

            var number2 = new myLinkedList<int>
            {
                data = 1,
                
            };

            var output = new CareerCupQnA().SwapPairs(number2);
        }
        private static void CombinationOfArray()
        {
            new CareerCupQnA().CombinationOfArray(new int[] { -1, 2, -3, 4, 5 }, 0, 0, 3, 0);
        }
        private static void LengthOfLongestSubstring2()
        {
           // Console.WriteLine(new CareerCupQnA().LengthOfLongestSubstring2("dvdf"));
            Console.WriteLine(new CareerCupQnA().LengthOfLongestSubstring("dvdf"));
        }

        private static void UnderstandingRecursion()
        {
            var obj = new CareerCupQnA();

            obj.UnderStandingRecursion(5);
        }

        public static void CallingBinaryTreeTraversal()
        {

            var obj = new TreesNGraph();

            var binaryTree = obj.PopulateBinaryTree();
            Console.WriteLine("InOrder Starts");
            obj.InOrder(binaryTree);
            Console.WriteLine("InOrder Ends");
            Console.WriteLine("PreOrder Starts");
            obj.PreOrder(binaryTree);
            Console.WriteLine("PreOrder Starts");
            Console.WriteLine("PostOrder Starts");
            obj.PostOrder(binaryTree);
            Console.WriteLine("PostOrder Starts");
        }

        public static void CallingDFS()
        {
            var obj = new TreesNGraph();
            var graph = obj.PopulateGraph();
            Console.WriteLine("DFS Starts");
            obj.DFS(graph);
            Console.WriteLine("DFS Ends");
        }

        public static void CallingBFS()
        {
            var obj = new TreesNGraph();
            var graph = obj.PopulateGraph();
            Console.WriteLine("BFS Starts");
            obj.BFS(graph);
            Console.WriteLine("BFS Ends");
        }


        public static void CallingIsBalanced()
        {
            var obj = new TreesNGraph();
            var bt = obj.PopulateBinaryTree();
            Console.WriteLine("IsBalanced Starts");
            Console.WriteLine(obj.IsBalancedTree(bt));
            Console.WriteLine("IsBalanced Ends");
        }

        public static void CallingFindingRoutes()
        {
            var obj = new TreesNGraph();
            var gh = obj.PopulateGraph();
            Console.WriteLine("Finding the routes start");
            Console.WriteLine(obj.FindingTheRouteBTW2Nodes(gh, 1, 89));
            Console.WriteLine("Finding the routes ends");
        }


        public static void CallingCreateMiniBST()
        {
            var obj = new TreesNGraph();
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Craete Min BST Starts");
            var output = obj.CreateMinimalBinaryTree(arr, 0, arr.Length);
            Console.WriteLine("Craete Min BST Ends");

        }

        public static void CallingCallingBSTToString()
        {
            var obj = new TreesNGraph();
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("CallingCallingBSTToString Starts");
            var output = obj.PopulateBinaryTree();

            obj.ConvertBTtoString(output);
            Console.WriteLine(obj.output);
            Console.WriteLine("CallingCallingBSTToStringEnds");
        }

        /************************************************************************************************************/

        public static void CallingFindingConsecutive()
        {
            Console.WriteLine("CallingFindingConsecutive Starts");
            var obj = new CareerCupQnA();
            //obj.FindConsecutiveRepetitive("ffgggtvshjsdhjfffffffffhvjbjchaaaaaaaaaaaaaaaru");
            obj.FindConsecutiveRepetitiveWithNoDict("ffgggtvshjsdhjfffffffffhvjbjchaaaaaaaaaaaaaaaru");

            //obj.FindConsecutiveRepetitive("ffgggtvshjsdhjfffffffffhvjbjchru");
            obj.FindConsecutiveRepetitiveWithNoDict("ffgggtvshjsdhjfffffffffhvjbjchru");

            //obj.FindConsecutiveRepetitive("abcddddef");
            obj.FindConsecutiveRepetitiveWithNoDict("abcddddef");

            Console.WriteLine("CallingFindingConsecutive Ends");

        }

        public static void FindingTheMinNumberByPattern()
        {
            var obj = new CareerCupQnA();

            obj.FindtheMinNumber("D");
            obj.FindtheMinNumber("I");
            obj.FindtheMinNumber("DD");
            obj.FindtheMinNumber("II");
            obj.FindtheMinNumber("DIDI");
            obj.FindtheMinNumber("IIDDD");
            obj.FindtheMinNumber("DDIDDIID");
        }

        public static void SortingNumbers()
        {
            var obj = new Sorting();

            var output = obj.SimpleSorting(new List<int> { 8, 9, 2, 6, 3, 4 });
            foreach (var i in output)
            {
                Console.WriteLine(i);
            }
        }

        public static void QuickSort()
        {
            var obj = new Sorting();
            var input = new List<int>();
            var number = 100;
            var rand = new Random();
            for (var i = 0; i < number; i++)
            {
                input.Add(rand.Next(1, 99));
            }


            obj.QuickSort(input, 0, input.Count - 1);
            foreach (var i in input)
            {
                Console.WriteLine(i);
            }
        }

        public static void MergeTwoArray()
        {
            var obj = new Sorting();
            // var input = new List<int> { 1, 4, 7, 8, 9 };
            //obj.MergeTwoSortedArray(input, new List<int> { 5, 6 });


            var input = new List<int> { -6, -1, 0, 4, 7, 8, 9 };
            obj.MergeTwoSortedArray(input, new List<int> { -5, 6 });
            foreach (var i in input)
            {
                Console.WriteLine(i);
            }


        }


        public static void StudyRecursive()
        {
            var obj = new CareerCupQnA();
            var v = 10;
            obj.StudyRecursive(v);
            Console.WriteLine("Answer :" + v);
        }

        public static void MatrixTraversal()
        {
            var obj = new CareerCupQnA();
            int[,] array2D = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            obj.traversalOfMatrix(array2D, 2, 2);
        }

        public static void BFSOnAGridGraph()
        {
            var obj = new CareerCupQnA();
            int[,] array2D = new int[,] { { 0,0,0,0,0,0,0,1 },
                                          { 0,0,0,0,1,0,0,1 },
                                          { 0,0,0,1,0,0,0,0 },
                                          { 0,1,1,1,1,0,0,0 },
                                          { 0,0,0,0,1,0,0,0 },
                                                };
            var res = obj.BFSOnAGridGraph(array2D, 5, 8);

            foreach (var str in res)
            {
                Console.WriteLine(str);
            }
        }

        public static void MultiplyLinkedLists()
        {
            var obj = new CareerCupQnA();

            var number1 = new myLinkedList<int>
            {
                data = 2,
                Next = new myLinkedList<int>
                {
                    data = 5,
                    Next = new myLinkedList<int>
                    {
                        data = 6
                    }

                }
            };

            var number2 = new myLinkedList<int>
            {
                data = 1,
                Next = new myLinkedList<int>
                {
                    data = 3
                }
            };
            obj.Multiply2LinkedList(number1, number2);
        }


        public static void RemoveDuplicatesinLinkedList()
        {
            var number1 = new myLinkedList<int>
            {
                data = 2,
                Next = new myLinkedList<int>
                {
                    data = 5,
                    Next = new myLinkedList<int>
                    {
                        data = 6,
                        Next = new myLinkedList<int>
                        {
                            data = 5,
                            Next = new myLinkedList<int>
                            {
                                data = 9,
                                Next = new myLinkedList<int>
                                {
                                    data = 1
                                }
                            }
                        }
                    }

                }
            };

            var obj = new CareerCupQnA();

            obj.RemoveDuplicatesInLinkedList(number1);

        }


        public static void isPalindrome()
        {
            var number1 = new myLinkedList<int>
            {
                data = 1,
                Next = new myLinkedList<int>
                {
                    data = 2,
                    Next = new myLinkedList<int>
                    {
                        data = 3,
                        Next = new myLinkedList<int>
                        {
                            data = 2,
                            Next = new myLinkedList<int>
                            {
                                data = 1,

                            }
                        }
                    }

                }
            };
            var obj = new CareerCupQnA();
            Console.WriteLine(
            obj.CheckPalindromeInLinkedList(number1, new Dictionary<int, int>(), 0, 5));
        }



        public static void FindTheBiggestCross()
        {
            var obj = new CareerCupQnA();
            int[,] array2D = new int[,] { { 1,1,1,1,1},
                                          { 0,0,1,1,1 },
                                          { 1,1,1,1,1 },
                                          { 0,0,1,0,0 },
                                          { 1,1,1,1,1 },
                                                };
            Console.WriteLine(obj.FindTheBiggestCross(array2D, 5, 5));

            //foreach (var str in res)
            //{
            //    Console.WriteLine(str);
            //}
        }

        public static void SwapParkingLots()
        {
            var obj = new CareerCupQnA();
            var input = new List<EmployeeParkingInfo>
            {
                new EmployeeParkingInfo
                {
                    EmployeeName = "A",
                    FromBuildingName = "1",
                    ToBuildingName = "2",
                },
                new EmployeeParkingInfo
                {
                    EmployeeName = "B",
                    FromBuildingName = "3",
                    ToBuildingName = "2",
                },
                new EmployeeParkingInfo
                {
                    EmployeeName = "C",
                    FromBuildingName = "1",
                    ToBuildingName = "4",
                },
                new EmployeeParkingInfo
                {
                    EmployeeName = "D",
                    FromBuildingName = "2",
                    ToBuildingName = "1",
                },
                new EmployeeParkingInfo
                {
                    EmployeeName = "F",
                    FromBuildingName = "5",
                    ToBuildingName = "2",
                },
                new EmployeeParkingInfo
                {
                    EmployeeName = "G",
                    FromBuildingName = "9",
                    ToBuildingName = "2",
                }
            };
            var output = obj.SwapParkingLots(input);

            foreach (var s in output)
            {
                Console.WriteLine(s);
            }
        }

        public static void maxConsecutiveSequenceOfBTree()
        {
            var obj = new CareerCupQnA();
            var tree = new BinaryTree<int>
            {
                Node = 90,
                Left = new BinaryTree<int>
                {
                    Node = 1,
                    Left = new BinaryTree<int>
                    {
                        Node = 22,
                        Left = new BinaryTree<int>
                        {
                            Node = 5,
                            Left = new BinaryTree<int>
                            {
                                Node = 99,
                            },
                            Right = new BinaryTree<int>
                            {
                                Node = 100
                            }

                        },
                        Right = new BinaryTree<int>
                        {
                            Node = 4
                        }
                    },
                    Right = new BinaryTree<int>
                    {
                        Node = 67,
                        Left = new BinaryTree<int>
                        {
                            Node = 68
                        }
                    }

                },
                Right = new BinaryTree<int>
                {
                    Node = 66
                }

            };
            obj.maxConsecutiveSequenceOfBTree(tree);
            Console.WriteLine(obj.getMaxSize());
        }

        public static void MergeAndRemoveDuplicatesInLinkedLists()
        {
            var obj = new CareerCupQnA();
            var input = new List<List<int>>
            {
                new List<int>{1,2,3,4},
                new List<int>{2,5,6,7},
                new List<int>{6,9,10,11},
            };
            obj.MergeAndRemoveDuplicatesInLinkedLists(input);
        }

        public static void ReverseLinkedList()
        {
            var obj = new CareerCupQnA();

            var number1 = new LinkedList<int>();
            number1.AddFirst(1);
            number1.AddLast(2);
            number1.AddLast(3);
            number1.AddLast(4);
            number1.AddLast(5);
            number1.AddLast(6);


            //obj.ReverseALikedList(number1);

            //Console.WriteLine(obj.reversedLinkedList);

            //Console.WriteLine(obj.ReverseLinkedList(number1.First));
        }


        public static void FindContradictionOfEquations()
        {
            var obj = new CareerCupQnA();

            obj.FindContradictionOfEquations(new List<List<string>>
            {
                new List<string>
                {
                    "A=B",
                    "B=D",
                    "C=D",
                    "F=G",
                    "E=H",
                    "H=C",

                }
            });
        }


        public static void MergeIntervals()
        {
            var obj = new CareerCupQnA();
            var input = new List<Interval>
            {
                new Interval(1,100),
                new Interval(250,550),
                new Interval(1000,1200),
                new Interval(400,600),
                new Interval(800,900),
                new Interval(1100,1150),

            };
            obj.MergeIntervals(input);

            foreach (var v in obj.ListOfInterval)
            {
                Console.WriteLine("{0}, {1}", v.Start, v.End);
            }
        }

        public static void FindItsParent()
        {
            var obj = new CareerCupQnA();
            var obj1 = new TreesNGraph();


            obj.FindItsParent(obj1.PopulateBinaryTree(), 5, 0);
        }

        public static void MaxTimeOfTask()
        {
            var obj = new CareerCupQnA();

            obj.MaxTimeOfTask(new List<int> { 5, 1, 3, 2, 5 }, 0);
        }

        public static void CheckRecursionReturnResult()
        {
            var obj = new CareerCupQnA();
            Console.WriteLine(obj.CheckRecursionReturnResult(11));
        }


        public static void CheckPriorityQueue()
        {
            var pQueue = new PriorityQueue<int>();

            pQueue.Push(1, 3);
            pQueue.Push(2, 1);
            pQueue.Push(3, 5);
            pQueue.Push(4, 2);
            pQueue.Push(5, 4);

            Console.WriteLine(pQueue.Pop());
            Console.WriteLine(pQueue.Pop());
            Console.WriteLine(pQueue.Pop());
            Console.WriteLine(pQueue.Pop());
            Console.WriteLine(pQueue.Pop());
        }


        public static void Dijkstra()
        {
            var A = new Vertex<String>("A");
            var B = new Vertex<String>("B");
            var C = new Vertex<String>("C");
            var D = new Vertex<String>("D");
            var E = new Vertex<String>("E");

            A.Edges = new List<Edge<string>> { new Edge<string>(B, 8), new Edge<string>(D, 6) };
            B.Edges = new List<Edge<string>> { new Edge<string>(C, 11) };
            C.Edges = new List<Edge<string>> { new Edge<string>(E, 10) };
            D.Edges = new List<Edge<string>> { new Edge<string>(E, 32) };

            Console.WriteLine(
            A.FindTheShortestPath(E)
            );
        }

        public static void FindTheSubsetOfSum()
        {
            var obj = new CareerCupQnA();
            var res = obj.FindTheSubsetOfSum(new List<int> { 1, 2, 3, 4, 5 }, 7);

            foreach (var e in res)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("**************************");
            res = obj.FindTheSubsetOfSum(new List<int> { 1, 2, 3, 4, 5, 6, 7, 9 }, 8);

            foreach (var e in res)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("**************************");
            res = obj.FindTheSubsetOfSum(new List<int> { 1, 11, 22, 33, 44, 55, 66, 77, 88, 99 }, 100);

            foreach (var e in res)
            {
                Console.WriteLine(e);
            }


        }


        static void ShuffleArray()
        {
            var obj = new CareerCupQnA();
            var res = obj.ShuffleArray(new List<int> { 3, 2, 1, 4, 4, 1, 5 }, new List<int> { 2, 1, 6, 3, 2, 3, 5 });

            foreach (var c in res)
            {
                Console.WriteLine(c);
            }

        }

        static void findtheClosestManager()
        {
            var obj = new CareerCupQnA();
            var obj1 = new TreesNGraph();
            var tree = obj1.PopulateBinaryTree();
            obj.ClosestManager(tree, 5, 10);
            Console.WriteLine("=============> {0} ", obj.GetClosestCommonManagers());
        }

        public static void BraketAnaltics()
        {
            var obj = new CareerCupQnA.BracketAnalysis();

            obj.FindIndexOfEqualBrakets("(())");
            Console.WriteLine(obj.result);

            obj.FindIndexOfEqualBrakets("))))))))(");
            Console.WriteLine(obj.result);

            obj.FindIndexOfEqualBrakets("))");
            Console.WriteLine(obj.result);
        }


        public static void BinarySearch()
        {
            var obj = new CareerCupQnA();
            Console.WriteLine(obj.BinarySearch(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, 10, 3));
            Console.WriteLine("*************************************************************");
            Console.WriteLine(obj.BinarySearch(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, 10, 7));
            Console.WriteLine("*************************************************************");
            Console.WriteLine(obj.BinarySearch(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, 10, 5));
            Console.WriteLine("*************************************************************");
            Console.WriteLine(obj.BinarySearch(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, 10, 1));
            Console.WriteLine("*************************************************************");
            Console.WriteLine(obj.BinarySearch(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, 10, 10));
        }


        public static void FindtheNthElement()
        {
            var obj = new CareerCupQnA();
            var number1 = new myLinkedList<int>
            {
                data = 2,
                Next = new myLinkedList<int>
                {
                    data = 5,
                    Next = new myLinkedList<int>
                    {
                        data = 6
                    }

                }
            };
            var a = obj.FindnthElement(number1, 10);

            Console.WriteLine(a.data);
        }


        static void Understanding2Recursion()
        {
            var obj = new CareerCupQnA();
            obj.UnderStanding2recursion(5);
        }

        static void ReverseLinkedList1()
        {
            var obj = new CareerCupQnA();
            var number1 = new myLinkedList<int>
            {
                data = 2,
                Next = new myLinkedList<int>
                {
                    data = 5,
                    Next = new myLinkedList<int>
                    {
                        data = 6
                    }

                }
            };
            var res = obj.ReverseALinkedList(number1);

            while (res != null)
            {
                Console.WriteLine(res.data);
                res = res.Next;
            }
        }

        static void MergeSortedArray()
        {
            var number1 = new myLinkedList<int>
            {
                data = 2,
                Next = new myLinkedList<int>
                {
                    data = 5,
                    Next = new myLinkedList<int>
                    {
                        data = 6
                    }

                }
            };

            var number2 = new myLinkedList<int>
            {
                data = 1,
                Next = new myLinkedList<int>
                {
                    data = 3,
                    Next = new myLinkedList<int>
                    {
                        data = 99,
                        Next = new myLinkedList<int>
                        {
                            data = 100,
                            Next = new myLinkedList<int>
                            {
                                data = 1009,
                                Next = new myLinkedList<int>
                                {
                                    data = 1051,
                                }
                            }
                        }
                    }
                }
            };

            var obj = new CareerCupQnA();
            var res = obj.MergeSortedArray(number1, number2);

            while (res != null)
            {
                Console.WriteLine(res.data);
                res = res.Next;
            }
        }


        static void FindMax()
        {
            var obj = new TreesNGraph();
            var binaryTree = obj.PopulateBinaryTree();
            Console.WriteLine(obj.FindMax(binaryTree));

        }

        static void PopulateValues()
        {
            var obj = new TreesNGraph();
            var input = new List<string>
            {
                    "+-++++++++",
                    "+-++++++++",
                    "+-++++++++",
                    "+-----++++",
                    "+-+++-++++",
                    "+-+++-++++",
                    "+++++-++++",
                    "++------++",
                    "+++++-++++",
                    "+++++-++++"
            };

            var cities = new List<string>
            {
                "LONDON","DELHI","ICELAND","ANKARA"
            };
            obj.PopulateWords(input, cities);
            obj.DrawWords();
            // obj.ChooseWords();
        }


        static void RemoveDuplicatesInString()
        {
            var obj = new CareerCupQnA();

            Console.WriteLine(obj.RemoveDuplicatesInString("ABCCBCBA"));
        }

        static void isUniqueChars()
        {
            var obj = new CareerCupQnA();
            Console.WriteLine(obj.isUniqueChars("abcded"));
        }

        static void FermatLast()
        {
            var obj = new CareerCupQnA();
            obj.FermatLastTheorem(9999, 3);
        }

        static void TrieCheck()
        {
            var obj = new TrieNode();
            obj.Insert(null, "mini");
            obj.Insert("mini", "banana");
            obj.Insert("mini", "grapes");
            obj.Insert(null, "big");
            obj.Insert("big", "grapes");
            obj.Insert("big", "apple");
            obj.Insert("big", "pine");

            obj.Insert(null, "small");
            obj.Insert("small", "grapes");
            obj.Insert("small", "apple");
            obj.Insert("small", "pine");
            obj.Insert("pine", "juice");

            obj.PrintPretty("", true);

        }

        static void PowerOfSum()
        {
            var obj = new CareerCupQnA();
            var n = 81;
            var p = 2;

            obj.PowerOfSum((int)Math.Pow(n, 1.0 / p), p, 0, n);
            Console.WriteLine("-----------------------------------------------------------------------");
            n = 100;
            p = 3;

            //obj.PowerOfSum((int)Math.Pow(n, 1.0 / p), p, 0, n);
            //Console.WriteLine("-----------------------------------------------------------------------");

            //n = 1000;
            // p = 2;

            //obj.PowerOfSum((int)Math.Pow(n, 1.0 / p), p, 0, n);
            //Console.WriteLine("-----------------------------------------------------------------------");

            //n = 1000;
            //p = 5;

            //obj.PowerOfSum((int)Math.Pow(n, 1.0 / p), p, 0, n);
            //Console.WriteLine("-----------------------------------------------------------------------");
        }


        static void StringConversion()
        {
            var s = "ezfnjymgqtjnmstbadg";
            //s = "beabeefeab";
            var obj = new CareerCupQnA.StringConvert();
            obj.FindMax(s);
            Console.WriteLine(obj.Max);
        }

        static void RemoveDuplicatesInStringRecursion()
        {
            var s = "aaabbbbccccddef";

            var obj = new CareerCupQnA();

            var res = obj.RemoveDuplicatesInStringRecursion(s, 0);

            Console.WriteLine(res);

        }

        static void getMaxLen()
        {
            var obj = new CareerCupQnA();

            var res = obj.getMaxLen(new int[] { 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 }, 4);

            Console.WriteLine(res);
        }

        static void RecursionColumnWise()
        {
            var obj = new CareerCupQnA();

            //     [0 0 0 0 0 0 0 1 1 1 1 1]
            //[0 0 0 0 1 1 1 1 1 1 1 1]
            //[0 0 0 0 0 0 1 1 1 1 1 1]
            //[0 0 0 0 0 0 0 0 0 1 1 1]
            //[0 0 0 0 0 0 0 1 1 1 1 1]
            //[0 0 0 0 1 1 1 1 1 1 1 1]
            int[,] array2D = new int[,] { { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1},
                                          { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 },
                                          { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1},
                                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1 },
                                          { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 },
                                          { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 },
                                                };
            obj.RecursionColumnWise(array2D, array2D.GetUpperBound(0), array2D.GetUpperBound(1));
        }


        //        Ex : [-20, -5, -2, -9] :> -2(-2) 
        //Ex : [20, -19, 6, 9, 4] :-> 20(20) 
        //Ex : [20, -19, 6, 9, 4] -> 18 (10, -3, 4, -2, -1, 10) 
        static void LargestSumOfContiguousArray()
        {
            var obj = new CareerCupQnA();

            obj.LargestSumOfContiguousArray(new int[] { -20, -5, -2, -9 });
            obj.LargestSumOfContiguousArray(new int[] { 20, -19, 6, 9, 4 });
            obj.LargestSumOfContiguousArray(new int[] { 10, -3, 4, -2, -1, 10 });

        }

        static void Adding2LinkedList()
        {
            var obj = new CareerCupQnA();
            var one = new LinkedList<int>();
            one.AddLast(1);
            one.AddLast(2);
            one.AddLast(3);
            one.AddLast(7);

            var sec = new LinkedList<int>();

            sec.AddLast(2);
            sec.AddLast(9);
            obj.Adding2LinkedList(one.First, sec.First);
        }


        static void Summation()
        {
            var obj = new CareerCupQnA();

            obj.Summation("148148148");
        }


        //static void KAMI()
        //{
        //    var obj = new CareerCupQnA();

        //    int[,] array2D = new int[,] { { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1},
        //                                  { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1},
        //                                  { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1},
        //                                  { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1},
        //                                  { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1},
        //                                  { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1},
        //                               };
        //    obj.KAMI(array2D, array2D.GetUpperBound(0), array2D.GetUpperBound(1));
        //}


        static void Permutation()
        {
            var obj = new CareerCupQnA();

            obj.Permutation(new List<int> { 3, 39, 34, 5, 9 }, 0, 4);

            Console.WriteLine("Maximum number is {0}", obj.Max);
        }

        static void BiggestSquareInMatrix()
        {
            //int[,] array2D = new int[,] { { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1},
            //                              { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1},
            //                              { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1},
            //                              { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1},
            //                              { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1},
            //                              { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1},
            //                           };

            int[,] array2D = new int[,] { { 1,1,1,1,1},
                                          { 0,0,1,1,1 },
                                          { 1,1,1,1,1 },
                                          { 0,0,1,0,0 },
                                          { 1,1,1,1,1 },
                                                };
            var obj = new CareerCupQnA();

            obj.BiggestSquareInMatrix(array2D, 1);

            obj.PrintSquares();
        }

        static void FormatArray()
        {
            var obj = new CareerCupQnA();

            obj.FormatArray(new List<int> { 1, 1, 2, 2, 2, 3, 4, 4, 4, 4, 5 }, 1);
        }

        static void CheckBST()
        {
            var obj = new CareerCupQnA();
            var obj1 = new TreesNGraph();
            var binaryTree = obj1.PopulateBinarySTree();
            Console.WriteLine("InOrder Starts");
            Console.WriteLine(obj.CheckBST(binaryTree));
        }

        static void NonAdjacentSum()
        {
            var obj = new CareerCupQnA();

            Console.WriteLine(obj.NonAdjacentSum(new List<int> { 3, 2, 5, 10, 7 }));
        }

        static void MetaString()
        {
            var obj = new CareerCupQnA();

            Console.WriteLine(obj.IsMetaString("converse".ToArray(), "conserve".ToArray()));
            Console.WriteLine(obj.IsMetaString("converse".ToArray(), "conserse".ToArray()));
            Console.WriteLine(obj.IsMetaString("converse".ToArray(), "converse".ToArray()));
            Console.WriteLine(obj.IsMetaString("converse".ToArray(), "conseeee".ToArray()));
            Console.WriteLine(obj.IsMetaString("manoj".ToArray(), "conseeee".ToArray()));
            Console.WriteLine(obj.IsMetaString("manoj".ToArray(), "monaj".ToArray()));
        }

        static void ReverseASentence()
        {
            var obj = new CareerCupQnA();
            Console.WriteLine(obj.ReverseASentence("I have a book"));
        }

        static void SumPath()
        {
            var obj = new CareerCupQnA();
            var treeO = new TreesNGraph();
            obj.SumPath(treeO.PopulateBinarySTree(), 28);

        }

        static void EquationEvaluation()
        {
            var obj = new CareerCupQnA.EquationClass();
            var equationTree = new CareerCupQnA.EquationClass.EquationTree();
            obj.Insert(equationTree, 'A', 'B');
            obj.Insert(equationTree, 'B', 'D');
            obj.Insert(equationTree, 'C', 'D');
            obj.Insert(equationTree, 'H', 'C');
            obj.Insert(equationTree, 'E', 'H');
        }

        static void CrossWords()
        {


            char[,] array2D = new char[,] { { 'A', 'C', 'P','R','C'},
                                                { 'X', 'S', 'O','P','C'},
                                                { 'V', 'O', 'V','N','I'},
                                                { 'W', 'G', 'F','M','N'},
                                                { 'Q', 'A', 'T','I','T'},

                                                };

            var obj = new CareerCupQnA.CrossWords(array2D, 5, 5);
            obj.FindWord("MICROSOFT");
        }
    }

}
