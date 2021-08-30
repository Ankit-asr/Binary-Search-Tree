﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree
    {
        private Node<int> _root;
        bool checkNumber = false;
        public BinaryTree()
        {
            _root = null;
        }
        public void Insert(int data)
        {
            if (_root == null)
            {
                _root = new Node<int>(data);
                return;
            }
            InsertRec(_root, new Node<int>(data));
        }
        private void InsertRec(Node<int> root, Node<int> newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Data.CompareTo(root.Data) < 0)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);
            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
        private void DisplayTree(Node<int> root)
        {
            if (root == null) return;
            DisplayTree(root.Left);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.Right);
        }
        private bool ShowTree(Node<int> root, int searchNumber)
        {
            if (root == null)
                return checkNumber;
            ShowTree(root.Left, searchNumber);
            if (root.Data == searchNumber)
            {
                return checkNumber = true;
            }
            ShowTree(root.Right, searchNumber);
            if (root.Data == searchNumber)
            {
                return checkNumber = true;
            }
            return checkNumber;
        }
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a Value Which you want to search");
            int searchNumber = Convert.ToInt16(Console.ReadLine());
            if (ShowTree(_root, searchNumber))
                Console.WriteLine(searchNumber + " : Number Found in tree");
            else
                Console.WriteLine(searchNumber + " : Number Not Found in tree");
        }
        public void DisplayTree()
        {
            DisplayTree(_root);
        }
    }
}
