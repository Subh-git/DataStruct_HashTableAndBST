using System;

namespace HashTables_BST_Day15
{
    class Program
    {
        public static void CountingWordFrequency(string sentence)            //this static method counts thr frquency of the words.
        {
            MyMapNode<string, int> hashtable = new MyMapNode<string, int>(10);      //declaring the key and value data types of the Mymapnodde class.
            string[] words = sentence.Split();                //splitting the sentence otherwise it wont be possible to generate keys.
            foreach (string word in words)
            {
                if (hashtable.Exists(word))                    //word is the "key"
                {
                    hashtable.Add(word, hashtable.Get(word) + 1);           //if it exists. get the value of the linkedlist object and invrement its value.
                }
                else
                {
                    hashtable.Add(word, 1);
                }
            }
            Console.WriteLine("Displaying after add operation\n");
            hashtable.Display();
            hashtable.Remove("avoidable");                                     //display after removing the key value pair with key avoidable
            Console.WriteLine("Displaying after removing avoidable.\n");
            hashtable.Display();
            Console.WriteLine("----------------------------------------");
        }
        static void Main(string[] args)
        {
            //CountingWordFrequency("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");

            // The below program is for the Binary search tree implementation

            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>(56);         //here we are passing the predefined node data which acts as the rootnode
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(60);
            binaryTree.Insert(95);                        //we are inserting the values to match the given hierarchical tree given to us in assignment
            binaryTree.Insert(11);
            binaryTree.Insert(65);
            binaryTree.Insert(3);
            binaryTree.Insert(16);
            binaryTree.Insert(63);
            binaryTree.Insert(67);
            binaryTree.Display();
            binaryTree.GetSize();
            bool result = binaryTree.IfExists(63, binaryTree);               //this is searching for the element 63 and it displays the parent nodes respectively adn the path
            Console.WriteLine(result);

         

        }
    }
}
