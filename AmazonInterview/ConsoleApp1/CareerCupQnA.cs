using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmzMain
{
    public class CareerCupQnA
    {


        public void FindConsecutiveRepetitiveWithNoDict(string input)
        {
            var previous = '-';
            int sum = 0;
            var output = 0;
            var caught = '*';
            foreach (char a in input)
            {
                if (previous == a)
                {
                    if (sum < ++output)
                    {
                        sum = output;
                        caught = a;
                    }
                }
                else
                {
                    output = 1;
                }
                previous = a;
            }
            Console.WriteLine("{0} -> {1}", caught, sum);
        }


        private string reverseAString(string str, int startIndex, int length)
        {
            var repStr = string.Empty;
            var subStr = str.Substring(startIndex, length);
            foreach (var c in subStr)
                repStr = c + repStr;

            return str.Replace(subStr, repStr);
        }

        public string FindtheMinNumber(string pattern)
        {
            var output = string.Empty;
            var startIndex = 0;
            var length = 0;
            var previous = '@';
            for (var i = 0; i < pattern.Length + 1; i++)
            {
                output = output + (i + 1);
            }
            for (var c = 0; c < pattern.Length; c++)
            {
                if (previous == pattern[c])
                {
                    if (pattern[c] == 'D')
                        length++;
                }
                else
                {
                    if (length > 1 && previous == 'D')
                        output = reverseAString(output, startIndex, length + 1);
                    else if (length > 0 && previous == 'D')
                        output = reverseAString(output, startIndex, length + 1);
                    previous = pattern[c];
                    length = 1;
                    startIndex = c;
                }

            }
            if (length > 0 && previous == 'D')
                output = reverseAString(output, startIndex, length + 1);
            Console.WriteLine(output);
            return output;
        }

        internal int UnderStandingRecursion(int v)
        {
            if (v == 0) return v;
            var list = new List<string>();
            var count = 0;
            var ans = UnderStandingRecursion(v - 1);
            count++;
            list.Add(string.Format("{0} -> {1}", count, ans));
            return ans;
        }

        internal void StudyRecursive(int v)
        {
            if (v == 0) return;
            Console.WriteLine("Above 1: " + v);
            StudyRecursive(v - 1);
            Console.WriteLine("Below 1: " + v);
        }



        internal void traversalOfMatrix(int[,] matrix, int x, int y)
        {
            if (x >= 0 && y >= 0)
            {
                if (matrix[x, y] % 2 == 0)
                    traversalOfMatrix(matrix, x - 1, y);
                if (matrix[x, y] % 2 != 0)
                    traversalOfMatrix(matrix, x, y - 1);
                Console.WriteLine(matrix[x, y]);
            }
        }


        internal List<string> BFSOnAGridGraph(int[,] matrix, int sizeX, int sizeY)
        {
            var result = new List<string>();
            for (var a = 0; a < sizeX; a++)
            {
                for (var b = 0; b < sizeY; b++)
                {
                    var tempResult = string.Empty;
                    if (matrix[a, b] == 1)
                    {
                        var queue = new Queue<int[]>();
                        queue.Enqueue(new int[] { a, b });
                        matrix[a, b] = 9;
                        tempResult = string.Format("({0}, {1}) ", a + 1, b + 1);

                        while (queue.Count != 0)
                        {
                            var elem = queue.Dequeue();
                            for (var i = -1; i <= 1; i++)
                            {
                                for (var j = -1; j <= 1; j++)
                                {
                                    if (elem[0] + i >= 0 && elem[1] + j >= 0 && elem[0] + i < sizeX && elem[1] + j < sizeY)
                                    {
                                        if (matrix[elem[0] + i, elem[1] + j] != 9 && matrix[elem[0] + i, elem[1] + j] == 1)
                                        {
                                            queue.Enqueue(new int[] { elem[0] + i, elem[1] + j });
                                            Console.WriteLine("{0} , {1} ", elem[0] + i + 1, elem[1] + j + 1);
                                            tempResult += string.Format("({0}, {1}) ", elem[0] + i + 1, elem[1] + j + 1);
                                            matrix[elem[0] + i, elem[1] + j] = 9;
                                        }
                                    }
                                }
                            }
                        }
                        result.Add(tempResult);
                    }
                }
            }
            return result;
        }



        //Multiple 2 LinkedList<Int>
        private static int result { get; set; }
        private static int reminder { get; set; }

        private static int xAxis = -1;
        private static int yAxis = -1;
        internal int Multiply2LinkedList(myLinkedList<int> firstNumber, myLinkedList<int> secondNumber)
        {
            var length1 = FindLengthOfLinkedList(firstNumber);
            var length2 = FindLengthOfLinkedList(secondNumber);

            var x = ConvertLinkedListToNumber(firstNumber, 0, length1);
            result = 0;
            var y = ConvertLinkedListToNumber(secondNumber, 0, length2);
            return x * y;
            //Multiply2LinkedList(firstNumber, secondNumber, new bool[length1, length2], length1, length2);
        }

        //internal void Multiply2LinkedList(myLinkedList<int> firstNumber, myLinkedList<int> secondNumber, bool[,] flags, int xLength, int yLength)
        //{
        //    if (firstNumber != null)
        //    {
        //        Multiply2LinkedList(firstNumber.Next, secondNumber, flags, xLength, yLength);
        //    }

        //    if (secondNumber != null)
        //    {
        //        Multiply2LinkedList(firstNumber, secondNumber.Next, flags, xLength, yLength);
        //    }
        //    if (firstNumber != null && secondNumber != null)
        //    {
        //        if (!flags[xAxis, yAxis])
        //        {
        //            flags[xAxis, yAxis] = true;
        //            Console.WriteLine("{0} , {1}", firstNumber.data, secondNumber.data);
        //        }
        //        Console.WriteLine("{0} , {1}", firstNumber.data, secondNumber.data
        //    }

        //}

        internal int FindLengthOfLinkedList(myLinkedList<int> number)
        {
            var count = 0;
            while (number != null)
            {
                count++;
                number = number.Next;
            }

            return count;
        }

        internal int ConvertLinkedListToNumber(myLinkedList<int> number, int count, int Length)
        {
            if (number == null) return 1;
            ConvertLinkedListToNumber(number.Next, ++count, Length);
            result += (int)Math.Pow(10, Length - count) * number.data;
            Console.WriteLine("Count : {0} and Data : {1}", count, number.data);
            Console.WriteLine("Result " + result);
            return result;
        }



        internal myLinkedList<int> RemoveDuplicatesInLinkedList(myLinkedList<int> number)
        {
            var current = number;
            myLinkedList<int> previous = new myLinkedList<int>();
            while (current != null)
            {
                var next = current.Next;
                previous = current;
                while (next != null)
                {
                    if (current.data == next.data)
                    {
                        previous.Next = next.Next;
                    }
                    previous = next;
                    next = next.Next;
                }
                current = current.Next;
            }
            return number;
        }



        internal bool CheckPalindromeInLinkedList(myLinkedList<int> Number, Dictionary<int, int> buffer, int count, int Length)
        {
            if (Number == null) return false;
            buffer.Add(count, Number.data);
            Console.WriteLine("{0}, {1}", count, Number.data);
            CheckPalindromeInLinkedList(Number.Next, buffer, ++count, Length);
            Console.WriteLine("{0}, {1}", count, Number.data);
            if (buffer[count - 1] != buffer[Length - count])
            {
                //Console.WriteLine("Not Equal {0} at {2}, {1} at {3}", buffer[count-1], buffer[Length - count], count-1, Length - count);
                return false;
            }
            return true;
        }

        internal int FindTheBiggestCross(int[,] matrix, int xLength, int yLength)
        {
            int total = 0;
            for (int i = 0; i < xLength; i++)
            {
                for (int j = 0; j < yLength; j++)
                {
                    if (matrix[i, j] == 1 && i - 1 >= 0 && j - 1 >= 0 && i + 1 < xLength && j + 1 < yLength
                        && matrix[i - 1, j] == 1
                        && matrix[i + 1, j] == 1
                        && matrix[i, j - 1] == 1
                        && matrix[i, j + 1] == 1
                        )
                    {

                        var listofAnswer = new List<int>();

                        listofAnswer.Add(SizeOfCross1(matrix, i, j, xLength, yLength));
                        listofAnswer.Add(SizeOfCross2(matrix, i, j, xLength, yLength));
                        listofAnswer.Add(SizeOfCross3(matrix, i, j, xLength, yLength));
                        listofAnswer.Add(SizeOfCross4(matrix, i, j, xLength, yLength));

                        if (listofAnswer.Distinct().Count() == 1)
                        {
                            if (total < listofAnswer[0])
                            {
                                total = listofAnswer[0];
                            }
                        }

                    }
                }
            }
            return total;

        }

        private int SizeOfCross1(int[,] matrix, int xIndex, int yIndex, int xLength, int yLength)
        {
            if (xIndex >= 0 && xIndex < xLength && yIndex >= 0 && yIndex < yLength)
            {
                if (matrix[xIndex, yIndex] == 0) return 0;
                return 1 + SizeOfCross1(matrix, xIndex, --yIndex, xLength, yLength);
            }
            return 0;
        }

        private int SizeOfCross2(int[,] matrix, int xIndex, int yIndex, int xLength, int yLength)
        {
            if (xIndex >= 0 && xIndex < xLength && yIndex >= 0 && yIndex < yLength)
            {
                if (matrix[xIndex, yIndex] == 0) return 0;
                return 1 + SizeOfCross2(matrix, ++xIndex, yIndex, xLength, yLength);
            }
            return 0;
        }

        private int SizeOfCross3(int[,] matrix, int xIndex, int yIndex, int xLength, int yLength)
        {
            if (xIndex >= 0 && xIndex < xLength && yIndex >= 0 && yIndex < yLength)
            {
                if (matrix[xIndex, yIndex] == 0) return 0;
                return 1 + SizeOfCross3(matrix, xIndex, ++yIndex, xLength, yLength);
            }
            return 0;
        }

        private int SizeOfCross4(int[,] matrix, int xIndex, int yIndex, int xLength, int yLength)
        {
            if (xIndex >= 0 && xIndex < xLength && yIndex >= 0 && yIndex < yLength)
            {
                if (matrix[xIndex, yIndex] == 0) return 0;
                return 1 + SizeOfCross4(matrix, --xIndex, yIndex, xLength, yLength);
            }
            return 0;
        }




        internal List<string> SwapParkingLots(List<EmployeeParkingInfo> ListOfEmpParkingInfo)
        {
            List<string> resultNames = new List<string>();
            foreach (var employeeInfo in ListOfEmpParkingInfo)
            {
                foreach (var nextEmployeeInfo in ListOfEmpParkingInfo.Where(e => e.EmployeeName != employeeInfo.EmployeeName))
                {
                    if (employeeInfo.FromBuildingName == nextEmployeeInfo.ToBuildingName
                        && employeeInfo.ToBuildingName == nextEmployeeInfo.FromBuildingName)
                    {
                        if (!resultNames.Contains(employeeInfo.EmployeeName))
                        {
                            resultNames.Add(employeeInfo.EmployeeName);
                            break;
                        }
                    }
                }
            }
            return resultNames;
        }



        public void maxConsecutiveSequenceOfBTree(BinaryTree<int> tree)
        {
            if (tree == null) return;
            if (!tree.IsVisited)
            {
                Console.WriteLine(tree.Node);
                CollectionMethod(tree.Node);
                tree.IsVisited = true;
                maxConsecutiveSequenceOfBTree(tree.Left);
                maxConsecutiveSequenceOfBTree(tree.Right);
            }
        }

        private List<List<int>> buffer = new List<List<int>>();


        private void CollectionMethod(int num)
        {
            if (buffer.Count == 0)
            {
                buffer.Add(new List<int>(num));
                return;
            }
            else
            {
                foreach (var n in buffer.ToList())
                {
                    if (n.Contains(num - 1) || n.Contains(num + 1))
                    {
                        n.Add(num);
                        return;
                    }

                }
            }
            buffer.Add(new List<int> { num });
        }

        public int getMaxSize()
        {
            int sum = 0;
            foreach (var n in buffer)
            {
                if (sum < n.Count)
                {
                    sum = n.Count;
                }
            }
            return sum;
        }




        public void MergeAndRemoveDuplicatesInLinkedLists(List<List<int>> listsOfLinkedList)
        {
            var parentList = listsOfLinkedList[0];
            for (var i = 1; i < listsOfLinkedList.Count; i++)
            {
                foreach (var n in listsOfLinkedList[i])
                {
                    foreach (var p in parentList.ToList())
                    {
                        if (n < p)
                        {
                            if (!parentList.Contains(n))
                                parentList.Insert(parentList.IndexOf(p) - 1, n);
                        }
                        else if (n == p)
                        {
                            parentList.Remove(p);
                        }
                        else
                        {
                            if (!parentList.Contains(n))
                                parentList.Add(n);
                        }


                    }
                }
            }

        }


        public void ReverseALikedList(myLinkedList<int> number)
        {
            if (number == null) return;
            ReverseALikedList(number.Next);
            CreateReverseLinkedList(number.data);
        }

        public LinkedList reversedLinkedList = new LinkedList();


        private void CreateReverseLinkedList(int data)
        {
            reversedLinkedList.AddLast(data);
        }



        /***********************************************************/

        public void FindContradictionOfEquations(List<List<string>> ListOfLists)
        {
            var output = string.Empty;
            var extra = string.Empty;
            foreach (var list in ListOfLists)
            {
                foreach (var str in list)
                {
                    var splits = str.Split(',');

                    foreach (var split in splits)
                    {
                        var againSplit = split.Split('=');
                        var o = InsertInTree(new Equation
                        {
                            LHS = againSplit[0],
                            RHS = againSplit[1]
                        }, output, extra);
                        output = o.Item1;
                        extra = o.Item2;
                    }
                }
            }

            Console.WriteLine(output);
        }

        private Tuple<string, string> InsertInTree(Equation v, string output, string Extra)
        {
            if (output == string.Empty)
            {
                output = (v.RHS + v.LHS);
                return new Tuple<string, string>(output, Extra);
            }


            if (output.Contains(v.LHS) || output.Contains(v.RHS))
            {
                if (!output.Contains(v.LHS))
                {
                    output += v.LHS;
                }
                if (!output.Contains(v.RHS))
                {
                    output += v.RHS;
                }
            }
            else
            if (Extra.Length == 0)
            {
                Extra = (v.RHS + v.LHS);
            }
            else
                if (Extra.Contains(v.LHS) || Extra.Contains(v.RHS))
            {
                if (!Extra.Contains(v.LHS))
                {
                    Extra += v.LHS;
                }
                if (!Extra.Contains(v.RHS))
                {
                    Extra += v.RHS;
                }
            }

            int count = -1;
            foreach (char c in Extra)
            {
                count++;
                if (output.Contains(c))
                {
                    if (!output.Contains(Extra.Remove(count, 1)))
                        output += Extra.Remove(count, 1);
                }
            }
            return new Tuple<string, string>(output, Extra);
        }


        public List<Interval> ListOfInterval { get; set; }
        public void MergeIntervals(List<Interval> Intervals)
        {
            foreach (var interval in Intervals.ToList())
            {

                if (ListOfInterval == null)
                {
                    ListOfInterval = new List<Interval>
                    {
                        new Interval(interval.Start, interval.End)
                    };
                }
                else
                {
                    foreach (var existingInterval in ListOfInterval.ToList())
                    {
                        if (interval.Start > existingInterval.Start && interval.End < existingInterval.End)
                        {
                            interval.IsDealt = true;
                            continue; // Within a existing range
                        }
                        else
                        if (interval.Start < existingInterval.Start && interval.End > existingInterval.End)
                        {
                            ListOfInterval.Remove(existingInterval);
                            ListOfInterval.Add(new Interval(interval.Start, interval.End));
                            interval.IsDealt = true;
                            break;
                        }
                        else
                        if (interval.Start > existingInterval.Start && interval.Start < existingInterval.End
                            ||
                            interval.End > existingInterval.Start && interval.End < existingInterval.End)
                        {
                            ListOfInterval.Remove(existingInterval);
                            ListOfInterval.Add(new Interval(
                                Math.Min(interval.Start, existingInterval.Start),
                                Math.Max(interval.End, existingInterval.End)
                                ));
                            interval.IsDealt = true;
                            break;
                        }


                    }
                    if (!interval.IsDealt)
                        ListOfInterval.Add(new Interval(interval.Start, interval.End));
                }

            }
        }

        private int SearchResult { get; set; }
        public void FindItsParent(BinaryTree<int> tree, int elementToBeFound, int Parent)
        {
            if (tree == null) return;

            FindItsParent(tree.Left, elementToBeFound, tree.Node);
            FindItsParent(tree.Right, elementToBeFound, tree.Node);
            if (tree.Node == elementToBeFound)
            {
                SearchResult = Parent;
            }
        }

        public int MaxTimeOfTask(List<int> numbers, int workers)
        {
            var maxValue = MaxTimeTaken(numbers);
            var sumOfAll = numbers.Sum();
            int sum = 0;
            if (maxValue >= sumOfAll - maxValue)
            {
                return maxValue;
            }
            else
                foreach (var n in numbers)
                {
                    if (maxValue != n)
                    {
                        if (maxValue + n == sumOfAll - n - maxValue)
                            return sumOfAll - n - maxValue;
                        if (sum < sumOfAll - n - maxValue)
                            sum = sumOfAll - n - maxValue;
                    }
                }

            return Math.Max(maxValue, sum);
        }


        private int MaxTimeTaken(List<int> numbers)
        {
            int largest = 0;

            foreach (var n in numbers)
            {
                if (largest < n)
                    largest = n;
            }
            return largest;
        }

        public int CheckRecursionReturnResult(int val)
        {
            if (val == 0) return 0;

            int Count = 0;
            Count++;
            var sum = CheckRecursionReturnResult(val - 1);
            return Count;
        }

        public List<int> FindTheSubsetOfSum(List<int> list, int sum)
        {
            var result = new List<int>();
            var internalSum = 0;
            for (var i = 0; i < list.Count; i++)
            {
                internalSum = list[i];
                result.Clear();
                result.Add(list[i]);
                for (var j = 0; j < list.Count && j != i; j++)
                {
                    internalSum += list[j];
                    result.Add(list[j]);
                    if (internalSum == sum)
                    {
                        return result;
                    }

                }
            }
            return new List<int> { -1 };
        }

        public List<int> ShuffleArray(List<int> A, List<int> B)
        {
            int outerLoop = 0;
            int innerLoop = 0;
            var s = new Sorting();
            var min = int.MaxValue;
            var result = new List<int>();
            var sortedArray = s.SimpleSorting(A);
            for (var i = 0; i < B.Count; i++)
            {
                //Console.WriteLine("Outer Loop : {0}", ++outerLoop);
                outerLoop++;
                for (var j = 0; j < sortedArray.Count; j++)
                {
                    //Console.WriteLine("Inner Loop : {0}", ++innerLoop);
                    innerLoop++;
                    if (sortedArray[j] > B[i])
                    {
                        result.Add(sortedArray[j]);
                        sortedArray.Remove(sortedArray[j]);
                        break;
                    }
                    else if (min > sortedArray[j])
                        min = sortedArray[j];
                    if (j == sortedArray.Count - 1)
                    {
                        result.Add(min);
                        sortedArray.Remove(min);
                        min = int.MaxValue;
                    }
                }
            }
            Console.WriteLine("Outer Loop : {0} Inner Loop : {1}", outerLoop, innerLoop);
            return result;
        }


        private Stack<int> commonManagers = new Stack<int>();

        public int GetClosestCommonManagers()
        {
            return commonManagers.Pop();
        }
        public void ClosestManager(BinaryTree<int> tree, int firstEmp, int secEmp)
        {
            if (tree == null) return;
            if (HasChild(tree, firstEmp) && HasChild(tree, secEmp))
                commonManagers.Push(tree.Node);
            ClosestManager(tree.Right, firstEmp, secEmp);
            ClosestManager(tree.Left, firstEmp, secEmp);
        }

        private bool HasChild(BinaryTree<int> tree, int employee)
        {
            if (tree == null) return false;
            if (tree.Node == employee) return true;
            return HasChild(tree.Left, employee) || HasChild(tree.Right, employee);
        }

        public class BracketAnalysis
        {

            public class Brakets
            {
                public int NumberOfOpen { get; set; }

                public int NumberOfClose { get; set; }

            }

            public int result { get; set; }
            public void FindIndexOfEqualBrakets(string input)
            {
                for (var i = 1; i < input.Length; i++)
                {
                    var obj = ReadString(input, 0, i);
                    var obj1 = ReadString(input, i, input.Length - 1);
                    if (obj.NumberOfOpen == obj1.NumberOfClose || obj.NumberOfClose == obj1.NumberOfOpen) { result = i; }
                }
            }

            private Brakets ReadString(string input, int startIndex, int endIndex)
            {
                var obj = new Brakets();
                for (var i = startIndex; i < endIndex; i++)
                {
                    if (input[i] == '(')
                    {
                        obj.NumberOfOpen++;
                    }
                    else if (input[i] == ')')
                        obj.NumberOfClose++;
                }
                return obj;
            }
        }


        public int BinarySearch(List<int> list, int startIndex, int endIndex, int searchTerm)
        {
            if (startIndex < endIndex)
            {
                var mid = (startIndex + endIndex) / 2;
                Console.WriteLine("{0} , {1} ==> {2}", startIndex, endIndex, list[mid]);
                if (list[mid] == searchTerm) return mid;
                if (list[mid] > searchTerm)
                    return BinarySearch(list, startIndex, mid, searchTerm);
                else
                    return BinarySearch(list, mid, endIndex, searchTerm);
            }
            return -1;
        }

        private int count = 0;
        public myLinkedList<int> FindnthElement(myLinkedList<int> list, int k)
        {
            if (list == null) return list;
            else
            {
                var n = FindnthElement(list.Next, k);
                if (count++ == k)
                    return list;
                return n;
            }

        }

        private int[] ArrayOfInt = new int[5];
        private int CountOfElement = 0;
        public int UnderStanding2recursion(int n)
        {
            if (n <= 0)
            {
                var sb = new StringBuilder();
                foreach (var e in ArrayOfInt)
                {
                    sb.Append("-" + e);
                }
                Console.WriteLine(CountOfElement++ + sb.ToString());
                return n;
            }
            else
            {
                ArrayOfInt[n - 1] = 0;

                var x = UnderStanding2recursion(n - 1);
                ArrayOfInt[n - 1] = 1;

                var y = UnderStanding2recursion(n - 1);
                //Console.WriteLine("{0} + {1} = {2}",x,y,x+y);
                return x + y;
            }

        }

        //public LinkedList<int> newList = new LinkedList<int>();
        public myLinkedList<int> ReverseALinkedList(myLinkedList<int> node)
        {
            if (node == null || node.Next == null) return node;
            var rest = ReverseALinkedList(node.Next);
            node.Next.Next = node;
            node.Next = null;
            return rest;
        }

        public myLinkedList<int> MergeSortedArray(myLinkedList<int> AList, myLinkedList<int> BList)
        {
            if (AList == null) return BList;
            if (BList == null) return AList;

            myLinkedList<int> result = null;

            if (AList.data <= BList.data)
            {
                result = AList;
                result.Next = MergeSortedArray(AList.Next, BList);
            }
            else
            {
                result = BList;
                result.Next = MergeSortedArray(BList.Next, AList);
            }

            return result;
        }

        public string RemoveDuplicatesInString(string Input)
        {
            //if (Input.Length <= 1) return Input;
            //else if (Input.Substring(0, 1) == Input.Substring(1, 1) && Input.Substring(2).Contains(Input.Substring(0, 1)))
            //    return RemoveDuplicatesInString(RemoveDuplicatesInString(Input.Substring(2)));
            //else if (Input.Substring(0, 1) == Input.Substring(1, 1))
            //    return RemoveDuplicatesInString(Input.Substring(1));
            ////else if (Input.Substring(1).Contains(Input.Substring(0,1))) return RemoveDuplicatesInString(Input.Substring(1));
            //return Input.Substring(0, 1) + RemoveDuplicatesInString(Input.Substring(1));
            var copy = Input;
            for (int i = 0; i < copy.Length - 1; i++)
            {
                if (copy[i] == copy[i + 1])
                {
                    if (copy.Substring(i + 1).Contains(copy[i]))
                    {
                        copy = copy.Substring(0, i) + copy.Substring(i + 2);
                        i--;
                    }
                    else
                        copy = copy.Substring(0, i) + copy.Substring(i + 1);
                    i--;
                }

            }

            return copy;
        }

        public bool isUniqueChars(String str)
        {
            // short circuit - supposed to imply that
            // there are no more than 256 different characters.
            // this is broken, because in Java, char's are Unicode,
            // and 2-byte values so there are 32768 values
            // (or so - technically not all 32768 are valid chars)
            if (str.Length > 256)
            {
                return false;
            }
            // checker is used as a bitmap to indicate which characters
            // have been seen already
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                // set val to be the difference between the char at i and 'a'
                // unicode 'a' is 97
                // if you have an upper-case letter e.g. 'A' you will get a
                // negative 'val' which is illegal
                int val = str.ElementAt(i) - 'a';
                // if this lowercase letter has been seen before, then
                // the corresponding bit in checker will have been set and
                // we can exit immediately.
                if ((checker & (1 << val)) > 0) return false;
                // set the bit to indicate we have now seen the letter.
                checker |= (1 << val);
            }
            // none of the characters has been seen more than once.
            return true;
        }



        public void FermatLastTheorem(long limit, int power)
        {
            Console.WriteLine("Limit is {0}", limit);
            for (long i = 1; i < limit; i++)
            {
                Console.WriteLine("Checking {0}", i);
                for (long j = 1; j < limit; j++)
                {
                    for (long k = 1; k < limit; k++)
                    {
                        if (Math.Pow(i, power) + Math.Pow(j, power) == Math.Pow(k, power))
                        {
                            Console.WriteLine("{0}^{3} + {1}^{3} == {2}^{3}", i, j, k, power);
                        }
                    }
                }
            }
        }



        private Stack<int> Stac = new Stack<int>();
        private List<int> equation = new List<int>();
        private int val { get; set; }



        public void PowerOfSum(int n, int p, int sum, int powerValue)
        {
            if (n == 0)//|| sum > powerValue)
            {
                var sb = new StringBuilder();
                if (equation.Count > 0)
                {
                    foreach (var e in equation) sb.Append(e + "+");
                    Console.WriteLine("{1}) Trying to match as {0}", sb.ToString().Substring(0, sb.ToString().Length - 1) + " ?? " + sum, ++count);
                }
                return;
            }
            sum += (int)Math.Pow(n, p);
            equation.Add(n);
            if (sum == powerValue)
            {
                var sb = new StringBuilder();
                foreach (var e in equation) sb.Append(e + "^" + p + "+");
                Console.WriteLine("=================> Matched as {0}", sb.ToString().Substring(0, sb.ToString().Length - 1) + " = " + sum);
                count++;
                equation.Clear();
            }
            PowerOfSum(n - 1, p, sum, powerValue);
            sum -= (int)Math.Pow(n, p);
            equation.Remove(n);
            PowerOfSum(n - 1, p, sum, powerValue);
        }


        public class StringConvert
        {
            public int Max = int.MinValue;
            public List<string> sts = new List<string>();
            public int FindMax(string s)
            {
                Console.WriteLine("Checking String :{0}", s);
                if (s.Length < 2) return Max;
                var goUni = GoDistinct(s);
                for (int i = 0; i < goUni.Length && s.Length > 1 && goUni != s; i++)
                {
                    if (s == goUni) return Max;
                    var newS = s.Replace(goUni[i].ToString(), "");
                    if (newS.Length > Max && GoDistinct(newS).Length == 2 && IsAlternatingString(newS))
                    {
                        Max = newS.Length;
                        Console.WriteLine("New Max Value is {0} because of {1}", Max, newS);
                    }
                    if (newS.Length > Max)
                    {
                        if (!sts.Contains(newS))
                        {
                            sts.Add(newS);
                            FindMax(newS);
                        }
                    }
                }
                return Max;
            }

            public string GoDistinct(string s)
            {
                var unique = s.ToCharArray().Distinct();
                //Console.WriteLine("string.Join(string.Empty, unique) : " + string.Join(string.Empty, unique));
                return string.Join(string.Empty, unique);
            }

            public bool IsAlternatingString(string s)
            {
                //Console.WriteLine("======================>" + s);
                if (s.Length > 2)
                {
                    for (int i = 1; i <= s.Length - 2; i++)
                    {
                        //Console.WriteLine(s[i - 1].ToString() + s[i + 1].ToString());
                        if (s[i - 1] != s[i + 1])
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return false;
            }
        }



        public string RemoveDuplicatesInStringRecursion(string str, int ptr)
        {
            if (str.Length > 0 && ptr < str.Length - 1)
            {
                if (str[ptr] == str[ptr + 1])
                {
                    str = str.Substring(0, ptr + 1) + str.Substring(ptr + 2);
                    ptr--;
                }

                str = RemoveDuplicatesInStringRecursion(str, ++ptr);
            }
            return str;
        }

        public int getMaxLen(int[] arr, int k)
        {
            int wL = 0, wR = 0;
            int n = 0;
            int maxLen = 0;
            if (arr[wR] == 0) n = 1;
            while (wR < arr.Length - 1)
            {
                if (n <= k)
                {
                    wR++;
                    if (arr[wR] == 0) n++;
                }
                if (n > k)
                {
                    if (arr[wL] == 0) n--;
                    wL++;
                }

                if ((wR - wL) > maxLen)
                {
                    maxLen = wR - wL;
                }
            }
            return maxLen;
        }

        /*
         * You are given a binary matrix whose each row is sorted. that means each row will have zeros at front and ones at the back. 
         * You need to find out the row which contains a maximum number of ones. 
            Ex :

            [0 0 0 0 0 0 0 1 1 1 1 1]
            [0 0 0 0 1 1 1 1 1 1 1 1]
            [0 0 0 0 0 0 1 1 1 1 1 1]
            [0 0 0 0 0 0 0 0 0 1 1 1]
            [0 0 0 0 0 0 0 1 1 1 1 1]
            [0 0 0 0 1 1 1 1 1 1 1 1]
            Ans : second row and sixth with 8 ones. you will print [2,8] and [6,8]; 
            */


        /// <summary>
        /// 04/15/2017 Preparing for amazon 2nd Interview
        /// I am going to try every column in the matrix by using recursion
        /// </summary>
        public void RecursionColumnWise(int[,] matrix, int rowSize, int colSize, int row = 0, int col = 0)
        {
            if (col > colSize) return;

            if (matrix[row, col] == 1)
            {
                Console.WriteLine("{0}, {1}", row + 1, colSize - col + 1); //Adding 1 to prime the index
                if (row >= rowSize)
                    return;
            }
            if (row >= rowSize && col < colSize)
                // Only when it scanned all of the rows and still columns left to scan - jump to next column from the beginning. 
                // Beginning means row = 0 and next column
                RecursionColumnWise(matrix, rowSize, colSize, 0, col + 1);
            else
                // else scan across all the element in the row
                RecursionColumnWise(matrix, rowSize, colSize, row + 1, col);
        }

        /// <summary>
        /// You are given an array of integers both negative and positive. 
        //        Print the maximum continuous sum of the array and if all the elements are negative, print the smallest of them.
        //        Ex : [-20, -5, -2, -9] :> -2(-2) 
        //Ex : [20, -19, 6, 9, 4] :-> 20(20) 
        //Ex : [10, -3, 4, -2, -1, 10] -> 18 (10, -3, 4, -2, -1, 10) 

        //Thanks velu007 for pointing out the mistake

        //- sonesh April 07, 2017 in United States | Report Duplicate | Flag
        /// </summary>
        /// <param name="array"></param>
        public void LargestSumOfContiguousArray(int[] array)
        {
            var ans = 0;
            var maxAtElement = 0;
            var isAllNegative = true;
            var minNumberOfArray = int.MinValue;
            for (var i = 0; i < array.Length; i++)
            {
                isAllNegative &= array[i] < 0;
                minNumberOfArray = Math.Max(minNumberOfArray, array[i]);
                maxAtElement = Math.Max(maxAtElement + array[i], array[i]);
                ans = Math.Max(maxAtElement, ans);
            }
            if (isAllNegative)
                Console.WriteLine(minNumberOfArray);
            else
                Console.WriteLine(ans);
        }

        public void Adding2LinkedList(LinkedListNode<int> one = null, LinkedListNode<int> sec = null)
        {
            int sum = 0;
            int carry = 0;
            var wholeSize = Math.Max(LengthOfLinkedList(one), LengthOfLinkedList(sec));
            var result = new LinkedList<int>();
            for (int i = 0; i < wholeSize; i++)
            {
                count = 0;
                var elemOne = FindTheKthLastElement(one, i);
                count = 0;
                var elemSec = FindTheKthLastElement(sec, i);
                sum = (elemOne + elemSec + carry) % 10;
                carry = (elemOne + elemSec + carry) / 10;
                result.AddFirst(sum);
            }


        }

        public int FindTheKthLastElement(LinkedListNode<int> list, int k)
        {
            int num = 0;
            if (list == null) return num;

            num = FindTheKthLastElement(list.Next, k);
            if (count++ == k)
                return list.Value;
            return num;
        }

        public int LengthOfLinkedList(LinkedListNode<int> list)
        {
            if (list == null) return 0;
            return 1 + LengthOfLinkedList(list.Next);
        }

        public int Summation(string str)
        {
            var res = 0;
            var sum = 0;
            if (str.Length == 1)
                return Convert.ToInt32(str);
            foreach (var e in str)
                sum += Convert.ToInt32(e.ToString());
            res = Summation(sum.ToString());
            return res;
        }

        public int Max = int.MinValue;


        /// <summary>
        /// Given a list of non negative integers, arrange them such that they form the largest number.

        //        For example:

        //Given[3, 30, 34, 5, 9], the largest formed number is 9534330.

        //Note: The result may be very large, so you need to return a string instead of an integer.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Permutation(List<int> list, int k, int m)
        {
            if (k == m)
            {
                var sb = new StringBuilder();
                foreach (var e in list)
                {
                    sb.Append(e);
                    //sb.Append(" ");
                }
                Console.WriteLine(++count + " ) " + sb.ToString());
                Max = Math.Max(Max, Convert.ToInt32(sb.ToString()));
            }
            else
                for (int i = k; i <= m; i++)
                {
                    var temp = list[k];
                    list[k] = list[i];
                    list[i] = temp;

                    Permutation(list, k + 1, m);
                    var temp2 = list[k];
                    list[k] = list[i];
                    list[i] = temp2;
                }
        }


        internal void BiggestSquareInMatrix(int[,] array2D, int v)
        {
            var colSize = array2D.GetUpperBound(1) + 1;
            var rowSize = array2D.GetUpperBound(0) + 1;
            SquareSizes = new SquareSize[rowSize, colSize];
            for (var row = 0; row < rowSize; row++)
                for (var col = 0; col < colSize; col++)
                {
                    SquareSizes[row, col] = new SquareSize(0, 0);
                }
            //for (var row = 0; row < rowSize; row++)
            //    for (var col = 0; col < colSize; col++)
            //    {
            //        if (array2D[row, col] == v)
            //        {
            //            FindBiggestArray(array2D, row, col, rowSize, colSize, v);
            //            return;
            //        }
            //    }
            FindBiggestArray(array2D, rowSize - 1, colSize - 1, rowSize, colSize, v);
        }

        internal class SquareSize
        {
            internal int rowLength { get; set; }
            internal int colLength { get; set; }


            public SquareSize(int a, int b)
            {
                rowLength = a;
                colLength = b;
            }
        }

        internal int[,] limitation = new int[,] { { -1, 0 }, { 0, -1 }, { -1, -1 } };
        internal SquareSize[,] SquareSizes { get; set; }


        private void FindBiggestArray(int[,] array2D, int row, int col, int rowSize, int colSize, int prey)
        {
            var queue = new Queue<int[]>();
            queue.Enqueue(new int[] { row, col });
            while (queue.Count != 0)
            {
                var square = queue.Dequeue();
                row = square[0];
                col = square[1];
                if (array2D[row, col] == prey && SquareSizes[row, col].rowLength == 0 && SquareSizes[row, col].colLength == 0)
                {
                    var colLength = 1;
                    var rowLength = 1;

                    if (row < rowSize - 1 && array2D[row + 1, col] == prey)
                        rowLength += SquareSizes[row + 1, col].rowLength;
                    if (col < colSize - 1 && array2D[row, col + 1] == prey)
                        colLength += SquareSizes[row, col + 1].colLength;
                    if (row < rowSize - 1 && col < colSize - 1 && array2D[row + 1, col + 1] != prey)
                    {
                        rowLength = 1; colLength = 1;
                    }
                    SquareSizes[row, col] = new SquareSize(rowLength, colLength);
                }

                for (int i = 0; i <= limitation.GetUpperBound(0); i++)
                {
                    if (row > 0 && col > 0)
                        queue.Enqueue(new int[] { row + limitation[i, 0], col + limitation[i, 1] });
                }
            }
        }

        internal void PrintSquares()
        {
            for (var row = 0; row < SquareSizes.GetUpperBound(0) + 1; row++)
            {
                var sb = new StringBuilder();
                for (var col = 0; col < SquareSizes.GetUpperBound(1) + 1; col++)
                {
                    sb.Append(string.Format("{0},{1}", SquareSizes[row, col].rowLength, SquareSizes[row, col].colLength));
                    sb.Append(" ");
                }
                Console.WriteLine(sb.ToString());
            }
        }

        internal void FormatArray(List<int> array, int k)
        {
            var previous = array[0];
            var temp = k;
            k = Math.Min(2, k);
            int count = 0;
            int b = 0;
            array[b] = array[0];
            for (int i = 0; i < array.Count; i++)
            {
                if (array[b] != array[i])
                {
                    b++;
                    array[b + count] = array[i];
                    count = 0;
                }
                else
                    count++;
            }

            for (int i = 0; i <= b; i++)
                Console.WriteLine(array[i]);

        }



        // Check if the BT is BST

        // Left Node < Node < Right Node
        // In order Traversal
        public bool CheckBST(BinaryTree<int> root)
        {
            //Base case
            if (root == null) return true;

            if (root.Left != null && root.Right != null)
                if (root.Node < root.Left.Node || root.Node > root.Right.Node)
                    return false;

            return CheckBST(root.Left) && CheckBST(root.Right);

        }

        /// <summary>
        /// 
        //Maximum sum such that no two elements are adjacent
        //Given an array of positive numbers, find the maximum sum of a subsequence with the constraint that no 2 numbers in the sequence should be adjacent in the array.
        //So 3 2 7 10 should return 13 (sum of 3 and 10) or 3 2 5 10 7 should return 15 (sum of 3, 5 and 7).
        //Answer the question in most efficient way
        /// </summary>
        public int NonAdjacentSum(List<int> array)
        {
            int sum = 0;
            for (int i = 0; i < array.Count; i++)
                for (int j = 2; j < array.Count; j++)
                {
                    for (int k = i + j; k < array.Count && k != i; k += j)
                        sum = Math.Max(sum, array[i] + array[k]);
                }

            return sum;
        }

        public bool IsMetaString(char[] A, char[] B)
        {
            count = 0;
            var bitsA = 0;
            var bitsB = 0;

            for (int i = 0; i < A.Length; i++)
            {
                var valA = A[i] - 'a';
                var valB = B[i] - 'a';
                bitsA |= (1 << valA);
                bitsB |= (1 << valB);
                var xOr = (1 << valA) ^ (1 << valB);
                if (xOr > 0)
                    count++;
            }

            return (bitsA ^ bitsB) == 0 && count == 2;
        }


        public string ReverseASentence(string input)
        {
            if (input.Split(' ').Count() == 1)
                return input;

            var firstWord = input.Split(' ')[0];
            var remaining = input.Substring(firstWord.Length + 1);
            var output = ReverseASentence(remaining) + " " + firstWord;
            return output;
        }

        public Queue<int> queue = new Queue<int>();
        public void SumPath(BinaryTree<int> tree, int k, int sum = 0)
        {
            if (tree == null) { return; }

            if (sum == k)
            {
                var sb = new StringBuilder();
                foreach (var e in Stac)
                    sb.Append(e + " ");
                Console.WriteLine(sb.ToString());
            }
            sum += tree.Node;
            queue.Enqueue(tree.Node);

            SumPath(tree.Left, k, sum);
            SumPath(tree.Right, k, sum);

            sum -= tree.Node;

            queue.Dequeue();
            //Stac.Pop();

        }

        /// <summary>
        /// Q: If you were given a series of equations e.g. [A = B, B = D, C = D, F = G, E = H, H = C] 
        //        and then another series[A != C, D != H, ..., F != A]
        //Check whether the equations combined is valid.
        //For the example given, your program should return 'invalid', 
        //because the first series implies that A = C, 
        //  which contradicts the statement A != C in the second series.
        /// </summary>

        public class EquationClass
        {
            public class EquationTree
            {
                public EquationTree()
                {

                }
                public EquationTree(char val)
                {
                    LHS = val;
                }
                public char LHS { get; set; }
                public List<EquationTree> RHSs { get; set; }
            }

            public List<EquationTree> Equations = new List<EquationTree>();


            public void Insert(EquationTree eq, char LHS, char RHS)
            {
                if (eq == null) return;

                if (eq.LHS == default(char) && eq.RHSs == null)
                {
                    eq.LHS = LHS;
                    eq.RHSs = new List<EquationTree> { new EquationTree(RHS) };
                    return;
                }
                if (eq.LHS == LHS)
                {
                    if (eq.RHSs == null)
                    {
                        eq.RHSs = new List<EquationTree> { new EquationTree(RHS) };
                        return;
                    }
                    else
                        eq.RHSs.Add(new EquationTree(RHS));
                }
                else if (eq.LHS == RHS)
                {
                    if (eq.RHSs == null)
                    {
                        eq.RHSs = new List<EquationTree> { new EquationTree(LHS) };
                        return;
                    }
                    else
                        eq.RHSs.Add(new EquationTree(LHS));
                }


                foreach (var rhs in eq.RHSs)
                {
                    Insert(rhs, LHS, RHS);
                }
            }
        }



        public class CrossWords
        {
            public int[,] Neighbours = { { -1, -1 }, { -1, 0 }, { 0, -1 }, { 1, 0 }, { 0, 1 }, { 1, -1 }, { -1, 1 }, { 1, 1 } };

            private static int Row_Size { get; set; }

            private static int Col_Size { get; set; }

            private Char[,] Input { get; set; }
            public CrossWords(Char[,] matrix, int RowSize, int ColSize)
            {
                Row_Size = RowSize;
                Col_Size = ColSize;
                Input = matrix;
                Visited = new bool[Row_Size, Col_Size];
            }

            private int[,] GetValue(int row, int col)
            {
                if (row > -1 && col > -1 && row < Row_Size && col < Col_Size)//&& !Visited[row, col])
                {
                    //Visited[row, col] = true;
                    return new int[,] { { row, col } };
                }
                return null;
            }

            public bool[,] Visited { get; set; }

            public void FindWord(string Word)
            {
                var queue = new Queue<int[,]>();
                queue.Enqueue(new int[,] { { 0, 0 } });
                int pointer = 0;
                while (queue.Count != 0 && pointer < Word.Length)
                {
                    var elem = queue.Dequeue();
                    var row = elem[0, 0];
                    var col = elem[0, 1];

                    if (Input[row, col] == Word[pointer])
                    {
                        Console.WriteLine("{0} , {1} => {2}", row, col, Input[row, col]);
                        pointer++;
                    }

                    for (int i = 0; i < Neighbours.GetUpperBound(0) + 1; i++)
                    {
                        var v = GetValue(row + Neighbours[i, 0], col + Neighbours[i, 1]);
                        if (v != null)
                            queue.Enqueue(v);
                    }
                }
            }
        }


        public int LengthOfLongestSubstring(String s)
        {
            int n = s.Length, ans = 0;
            int[] index = new int[128]; // current index of character
                                        // try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                i = Math.Max(index[s.ElementAt(j)], i);
                ans = Math.Max(ans, j - i + 1);
                index[s.ElementAt(j)] = j + 1;
            }
            return ans;
        }



        public void CombinationOfArray(int[] array, int startIndex, int sum, int targetSum, int counting)
        {
            if (startIndex >= array.Length) return;
            Console.WriteLine("Count = {0}", counting);
            if (sum == targetSum)
            {
                foreach (var a in Stac)
                    Console.WriteLine(a);
                Console.WriteLine("Matched");
            }

            CombinationOfArray(array, startIndex + 1, sum, targetSum, ++counting);
            Stac.Push(array[startIndex]);
            sum += array[startIndex];
            CombinationOfArray(array, startIndex + 1, sum, targetSum, ++counting);
            Stac.Pop();
            sum -= array[startIndex];
        }

        public myLinkedList<int> SwapPairs(myLinkedList<int> node)
        {
            var newNode = new myLinkedList<int>(0);
            var temp = newNode;
            while (node != null)
            {
                if (node.Next != null)
                {
                    newNode.Next = new myLinkedList<int>(node.Next.data);
                    var nextNode = new myLinkedList<int>(node.data);
                    nextNode.Next = node.Next.Next;
                    newNode.Next.Next = nextNode;
                    newNode = newNode.Next.Next;
                    node = node.Next.Next;
                }
                else
                {
                    newNode.Next = new myLinkedList<int>(node.data);
                    node = node.Next;
                }
            }
            return temp.Next;
        }

        public int RemoveElementInArray(int[] nums, int val)
        {
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    // reduce array size by one
                    n--;
                }
                else
                {
                    i++;
                }
            }
            return n;
        }

        public char FindTheDifference(string s, string t)
        {
            if (s.Length == 0)
                return t[0];
            var array = new int[26];
            for (var i = 0; i < t.Length; i++)
            {
                if (i < s.Length)
                    array[(int)s.ElementAt(i) - 'a']++;
                array[(int)t.ElementAt(i) - 'a']--;
            }

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine(array[i]);
                    return Convert.ToChar(i + 'a');
                }
            }
            return ' ';
        }


        public int FindTheSingleNumber(int[] nums)
        {

            int ones = 0, twos = 0;
            foreach (int i in nums)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("ones ^ i => {0}", ones ^ i);
                Console.WriteLine("twos ^ i => {0}", twos ^ i);
                Console.WriteLine("twos => {0} ; ~twos => {1} ; ones => {2} ; ~ones => {3}", twos, ~twos, ones, ~ones);
                ones = ones ^ i & ~twos;
                twos = twos ^ i & ~ones;

                Console.WriteLine("{0} = {1} ; a = {2} ; b = {3}", i, Convert.ToString(i, 2), Convert.ToString(ones, 2), Convert.ToString(twos, 2));
            }
            return ones;

        }



        public class RecommendationAmazon
        {
            public class GraphNode
            {
                public GraphNode(string value)
                {
                    Name = value;
                    Neighbours = new List<GraphNode>();
                }
                public string Name { get; set; }
                public List<GraphNode> Neighbours { get; set; }
                

                public bool Insert(string key, string value)
                {
                    if (Name == key)
                    {
                        Neighbours.Add(new GraphNode(value));
                        return true;
                    }
                    else
                    {
                        foreach (var graph in Neighbours)
                        {
                            return graph.Insert(key, value);
                        }
                    }
                    return false;
                }
            }



            public string[] LargestItemAssociation(string[,] itemAssociation)
            {
                var count = itemAssociation.GetUpperBound(0) + 1;
                var newGraph = new GraphNode(itemAssociation[0, 0]);
                newGraph.Insert(itemAssociation[0, 0], itemAssociation[0, 1]);
                var listOfGraph = new List<GraphNode>();
                listOfGraph.Add(newGraph);
                var visited = new bool[count];
                visited[0] = true;
                int maxIndex = -1;
                int maxValue = int.MinValue;
                var resultString = new List<List<string>>();
                for (var i = 1; i < count; i++)
                {
                    foreach (var eachGraph in listOfGraph.ToList())
                    {
                        if (!visited[i])
                            visited[i] = eachGraph.Insert(itemAssociation[i, 0], itemAssociation[i, 1]);
                    }
                    if(!visited[i])
                    {
                        var tempGraph = new GraphNode(itemAssociation[i, 0]);
                        visited[i] = tempGraph.Insert(itemAssociation[i, 0], itemAssociation[i, 1]);
                        listOfGraph.Add(tempGraph);
                    }
                }

                for(var i = 0; i < listOfGraph.Count; i ++)
                {
                    var res = CountTheNodes(listOfGraph[i]);
                    resultString.Add(res);
                    if(maxValue < res.Count)
                    {
                        maxValue = res.Count;
                        maxIndex = i;
                    }
                }
                return resultString[maxIndex].ToArray();

            }


            public List<string> CountTheNodes(GraphNode parent)
            {
                var count = 0;
                Queue<GraphNode> q = new Queue<GraphNode>();
                List<string> result = new List<string>();
                q.Enqueue(parent);
                while (q.Count > 0)
                {
                    count++;
                    var current = q.Dequeue();
                    result.Add(current.Name);
                    foreach (var child in current.Neighbours)
                        q.Enqueue(child);
                }
                return result;
            }





        }
        /// <summary>
        /// Q. Given predicted stock prices for next n days for a stock e.g 25, 30, 48, 15, 25, 45, 10, 25 
        /// write a function that returns the next max profit that can be made with a single buy-sell transaction. 
        /// If no profit can be made, return 0.
        /// //You can only sell after you buy. cannot short sell
        //sorting will not work


        /// </summary>
        public int MaxStockPrice(int[] stockPrices)
        {
            var minPrice = int.MaxValue;
            var maxDiff = 0;
            for (int i = 0; i < stockPrices.Length; i++)
            {
                minPrice = Math.Min(minPrice, stockPrices[i]);
                maxDiff = Math.Max(maxDiff, stockPrices[i] - minPrice);
            }
            return maxDiff;
        }


        public string MostFrequentWords(string str)
        {
            var array = str.Split(' ');
            var dict = new Dictionary<string, int>();
            var maxValue = int.MinValue;
            var freqWord = "";
            var value = 0;
            foreach (var word in array)
            {
                if (!dict.TryGetValue(word, out value))
                {
                    dict[word] = 1;
                }
                else
                {
                    dict[word]++;
                }
            }

            foreach (var wordDict in dict.Keys)
            {
                if (maxValue < dict[wordDict])
                {
                    maxValue = dict[wordDict];
                    freqWord = wordDict;
                }

            }

            return freqWord;
        }

        public List<int> substrAnagram(String haystack, String needle)
        {
            var result = new List<int>();
            for(var i = 0; i < haystack.Length - needle.Length + 1; i ++)
            {
                Console.WriteLine(haystack.Substring(i, needle.Length));
                if (Sort(haystack.Substring(i, needle.Length)).Equals(Sort(needle)))
                    result.Add(i);
            }

            return result;
        }

        private static string Sort(string input)
        {
            var chars = input.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }

    }
}



