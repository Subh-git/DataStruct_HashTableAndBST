using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables_BST_Day15
{
    public class BinarySearchTree<T> where T: IComparable<T>               //creating a generic comaprable class named as binary seach tree
    {
        public T data { get; set; }              // its like creating the node data
        public BinarySearchTree<T> leftTree { get; set; }     //the left node
        public BinarySearchTree<T> rightTree { get; set; }    //the right node
        public BinarySearchTree(T data)                       // constructor
        {
            this.data = data;                                //assignment
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;
        /// <summary>
        /// Inserts the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Insert(T item)               
        {
            T currentValue = this.data;                                    //this take shte current root node value
            if ((currentValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)                                 //checks to see if the left nodwe of the tree is null
                {
                    this.leftTree = new BinarySearchTree<T>(item);
                }
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)                                 //checks to see if the right jde of the tree is null and then implenting or inserting data
                    this.rightTree = new BinarySearchTree<T>(item);

                else
                    this.rightTree.Insert(item);
            }
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()  
        {
            if(this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.data.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }

        public void GetSize()    //this method yoelds the size of the treee by counting the number of times the incrementation of left and right count
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
        /// <summary>
        /// Ifs the exists.
        /// this method returns true or false depeending upon whether it found the element in the tree or not
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public bool IfExists(T element, BinarySearchTree<T> node)    
        {
            if (node == null)
            {
                return false;
            }
            if (node.data.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.data);
                result = true;
            }
            else
                Console.WriteLine("Current element is {0} in BST", node.data);
            if (element.CompareTo(node.data)< 0)
            {
                IfExists(element, node.leftTree);
            }
            if (element.CompareTo(node.data) >0)
            {
                IfExists(element, node.rightTree);
            }
            return result;
        }


            

    }
}
