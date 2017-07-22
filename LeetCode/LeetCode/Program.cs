using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //MergeTwoBinaryTree();
            // HammingDistance();

            //FindComplement();

            //ReverseWords();
            FindWords();

            Console.ReadLine();
        }


        public static void MergeTwoBinaryTree()
        {
            //Input: 
            // Tree 1                     Tree 2                  
            //          1                         2                             
            //         / \                       / \                            
            //        3   2                     1   3                        
            //       /                           \   \                      
            //      5                             4   7                  
            //Output: 
            //Merged tree:
            //      3
            //     / \
            //    4   5
            //   / \   \ 
            //  5   4   7
            var first = new TreeNode(1)
            {
                left = new TreeNode(3),
                right = new TreeNode(2)
            };
            first.left.left = new TreeNode(5);

            var second = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(3)
            };
            second.left.right = new TreeNode(4);
            second.right.right = new TreeNode(7);

            var eOutput = new TreeNode(3)
            {
                left = new TreeNode(4),
                right = new TreeNode(5)
            };
            eOutput.left.left = new TreeNode(5);
            eOutput.left.right = new TreeNode(4);
            eOutput.right.right = new TreeNode(7);

            var aOutput = new Solutions().MergeTrees(first, second);
            aOutput.Print();
            eOutput.Print();

        }


        public static void HammingDistance()
        {
            var aOutput = new Solutions().HammingDistance(1, 4);

            Assert.AreEqual(aOutput, 2);
        }


        public static void FindComplement()
        {
            var output = new Solutions().FindComplement(5);
            Assert.AreEqual(output, 2);

            output = new Solutions().FindComplement(1);
            Assert.AreEqual(output, 0);
        }

        public static void ReverseWords()
        {
            var output = new Solutions().ReverseWords("Let's take LeetCode contest");

            Assert.AreEqual("s'teL ekat edoCteeL tsetnoc", output);

            output = new Solutions().ReverseWords("enuk$)g*)(mex%y*ocdafa)ev%konbr(ucvu*kjh$kyz*djrk)rniq##jbqtwhu*r&q#gsd#ivkni (xkpffov(frqu)!&sf&stbw)@s! eq&tj)vguf!y$sstm^! @mx%khlj$jpqs*uxwxvgu vjmlw^ubivqyyljta%q&$f@mcvc&(owvgyehq#qph*fak tqxtey kexylyiwh%!bxpcqo@zgg&tklpw%phs)cbo@(&^^wn w*xhpxa@d!!vwavwqchbfmpl&z@$kztz#nc%@!tv$htr!&d(wbj^tcfpu!z)!hyf^&sc!c)z%bgufbj#obhlykh ih$vxc*to#*wombce*eo)pqftfps^c(&kf%clklc f&$murkgdhnos$%ovvaqc&las%r%s*x^cpqvk&xlbmxejlsyt^(ck$ @)ks$i!dotdz)skwc&s^zk!ma!z@ymd%d)(flj^)va*tr^xnjgd!x b!al&bvewa#wtr^pov v$aie%x&&bx#@mnwrvu&^v$je(#se&y)x$wmgzmi!%eixawazf%*g$obyggoybw#ygjg**u(it@^b)@raa#ua(w*wxensgd u(a%qinf#wgoxt(q!&rz)ktpuqrjswqr^kispf*gzv#nkyg icd)xfhdpwwvm@i$%&ov(xkbe)igwajs@v)nepqtbjtk $dexm*bapttglgj$azwcaobdj&$ol#jnoq(f&twe@ulovnliefy%(%uncco%z#%%&w@xanjxdd");

            
        }

        public static void FindWords()
        {
            var output = new Solutions().FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });


        }

    }
}
