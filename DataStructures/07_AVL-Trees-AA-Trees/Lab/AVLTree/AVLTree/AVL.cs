﻿using System;

public class AVL<T>
    where T : IComparable<T>
{
    private Node<T> root;

    public Node<T> Root
    {
        get
        {
            return this.root;
        }
    }

    public bool Contains(T item)
    {
        var node = this.Search(this.root, item);
        return node != null;
    }

    public void Insert(T item)
    {
        this.root = this.Insert(this.root, item);
    }

    public void EachInOrder(Action<T> action)
    {
        this.EachInOrder(this.root, action);
    }

    private Node<T> Insert(Node<T> node, T item)
    {
        if (node == null)
        {
            return new Node<T>(item);
        }

        int cmp = item.CompareTo(node.Value);
        if (cmp < 0)
        {
            node.Left = this.Insert(node.Left, item);
        }
        else if (cmp > 0)
        {
            node.Right = this.Insert(node.Right, item);
        }

        node = this.Balance(node);
        this.UpdateHeight(node);
        return node;
    }

    private Node<T> Balance(Node<T> node)
    {
        int balance = this.Height(node.Left) - this.Height(node.Right);
        if (balance < -1)
        {
            balance = this.Height(node.Right.Left) - this.Height(node.Right.Right);
            if (balance <= 0)
            {
                return this.RotateLeft(node);
            }
            else
            {
                node.Right = this.RotateRight(node.Right);
                return this.RotateLeft(node);
            }
        }
        if (balance > 1)
        {
            balance = this.Height(node.Left.Left) - this.Height(node.Left.Right);
            if (balance >= 0)
            {
                return this.RotateRight(node);
            }
            else
            {
                node.Left = this.RotateLeft(node.Left);
                return this.RotateRight(node);
            }
        }

        return node;
    }

    private Node<T> RotateRight(Node<T> node)
    {
        var left = node.Left;
        node.Left = left.Right;
        left.Right = node;

        this.UpdateHeight(node);
        return left;
    }

    private Node<T> RotateLeft(Node<T> node)
    {
        var right = node.Right;
        node.Right = right.Left;
        right.Left = node;

        this.UpdateHeight(node);
        return right;
    }

    private void UpdateHeight(Node<T> node)
    {
        node.Height = Math.Max(this.Height(node.Left), this.Height(node.Right)) + 1;
    }

    private int Height(Node<T> node)
    {
        if (node == null)
        {
            return 0;
        }

        return node.Height;
    }

    private Node<T> Search(Node<T> node, T item)
    {
        if (node == null)
        {
            return null;
        }

        int cmp = item.CompareTo(node.Value);
        if (cmp < 0)
        {
            return Search(node.Left, item);
        }
        else if (cmp > 0)
        {
            return Search(node.Right, item);
        }

        return node;
    }

    private void EachInOrder(Node<T> node, Action<T> action)
    {
        if (node == null)
        {
            return;
        }

        this.EachInOrder(node.Left, action);
        action(node.Value);
        this.EachInOrder(node.Right, action);
    }
}