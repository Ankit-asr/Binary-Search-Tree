using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node<T> where T : IComparable
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node()
        {

        }
        public Node(T data)
        {
            this.Data = data;
        }
    }
}
