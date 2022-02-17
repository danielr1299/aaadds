using Logic.InnerDataTypes;
using System;

namespace DataStuctures
{
    //delegate void SingleItemAction<T>(T item);
    //delegate void SingleItemAction<T1, T2>(T1 item1, T2 item2);

    public class BST<T> where T : IComparable<T>
    {
        Node root;
        int count = 0;
        public DataY D { get; set; }

        
        
        

        public void Add(T value) //O(logN) -> O(n)
        {
            if (root == null) // empty tree
            {
                root = new Node(value);
                return;
            }

            Node tmp = root;
            while (true)
            {
                if (value.CompareTo(tmp.dataX) >= 0) // value >= tmp.data ->go right
                {
                    if (tmp.right == null)
                    {
                        tmp.right = new Node(value);
                        break;
                    }
                    tmp = tmp.right;
                }
                else // go left (value < tmp.data)
                {
                    if (tmp.left == null)
                    {
                        tmp.left = new Node(value);
                        break;
                    }
                    tmp = tmp.left;
                }
            }

        }


        public void AddY(T value) //O(logN) -> O(n)
        {
            if (root == null) // empty tree
            {
                root = new Node(value);
                return;
            }

            Node tmp = root;
            while (true)
            {

                if (value.CompareTo(tmp.dataY) >= 0) // value >= tmp.data ->go right
                {
                    if (tmp.right == null)
                    {
                        tmp.right = new Node(value);
                        break;
                    }
                    tmp = tmp.right;
                }
                else if (value.CompareTo(tmp.dataY) < 0)// go left (value < tmp.data)
                {
                    if (tmp.left == null)
                    {
                        tmp.left = new Node(value);
                        break;
                    }
                    tmp = tmp.left;
                }
                else if (value.CompareTo(tmp.dataY) == 0)
                {

                    D.Count++;
                   //if (tmp.dataY != null)
                   //{
                   //    count++;
                   //}
                   //else
                   //{
                   //    AddY(value);
                   //    count = 1;
                   //}
                }
            
            }
        }



        public void Add(T valueX,T valueY) //O(logN) -> O(n)
        {
            if(root == null) // empty tree
            {
                //root = new Node(valueX,valueY);
                return;
            }
            
            Node tmp = root;
            while (true)
            {

                if (valueX.CompareTo(tmp.dataX) > 0) // value >= tmp.data ->go right
                {
                    if (tmp.right == null)
                    {
                       // tmp.right = new Node(valueX, valueY);
                        break;
                    }
                    tmp = tmp.right;
                }
                else if (valueX.CompareTo(tmp.dataX) < 0)// go left (value < tmp.data)
                {
                    if (tmp.left == null)
                    {
                      //  tmp.left = new Node(valueX, valueY);
                        break;
                    }
                    tmp = tmp.left;
                }
                else if (valueX.CompareTo(tmp.dataX) == 0)
                {
                   
                }
            }  
        }

        public bool Search(T item, out T foundItem)
        {
            Node tmp = root;

            while (tmp != null)
            {
                if (item.CompareTo(tmp.dataX) == 0)
                {
                    foundItem = tmp.dataX;
                    return true;
                }
                if (item.CompareTo(tmp.dataX) < 0)
                {
                    tmp = tmp.left;
                }
                else tmp = tmp.right;
            }

            foundItem = default;
            return false;
        }

        public void ScanInOrder(Action<T> itemAction) => ScanInOrder(root, itemAction);


        private void ScanInOrder(Node currentNode, Action<T> itemAction)
        {
            if (currentNode == null) return;

            ScanInOrder(currentNode.left, itemAction);
            itemAction(currentNode.dataX);
            ScanInOrder(currentNode.right, itemAction);
        }

        public int GetDepth() => GetDepth(root);
       

        private int GetDepth(Node currentNode)
        {
            if (currentNode == null) return 0;
            
            return Math.Max(GetDepth(currentNode.left), GetDepth(currentNode.right)) + 1;
        }

        class Node
        {
            public T dataX;
            public T dataY;
            public Node left;
            public Node right;

            public Node(T dataX)
            {
                this.dataX = dataX;
                //this.dataY = dataY;
            }
        }
    }
}
