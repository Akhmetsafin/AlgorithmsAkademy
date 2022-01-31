using System;

namespace LinkedList
{
    public class Node
    {
        public Node head;
        public Node tail;

        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        public interface ILinkedList
        {
            int GetCount(); //Кол-во элементов в списке
            void AddNode(int value); // добавляет 
            void AddNodeAfter(Node node, int value); // добавляет  списка после текущего элемента
            void RemoveNode(int index); // удаляет по порядковому номеру
            void RemoveNode(Node node); // удаляет указанный элемент
            Node FindNode(int searchValue); // поиск элемента по его значению

        }
        /// <summary>
        /// Кол-во элементов в списке
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            int count = 0;
            var node = head;

            while (node != null)
            {
                node = node.NextNode;
                count++;
            }
            return count;
        }
        /// <summary>
        /// добавляем элемент
        /// </summary>
        /// <param name="value"></param>
        public void AddNode(int value)
        {
            var newNode = new Node { Value = value };

            if (tail == null)
            {
                newNode.NextNode = null;
                newNode.PrevNode = null;
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.NextNode = newNode;
                newNode.PrevNode = tail;
                tail = newNode;
            }
        }
        /// <summary>
        /// добавляет  списка после текущего элемента
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node { Value = value };

            if (node == null)
                return;

            if (node.NextNode == null)
            {
                node.NextNode = newNode;
                newNode.PrevNode = node;
                newNode.NextNode = null;
                tail = newNode;
            }
            else
            {
                var nextNode = node.NextNode;
                node.NextNode = newNode;
                newNode.NextNode = nextNode;

                node.NextNode.NextNode.PrevNode = newNode;
                newNode.PrevNode = node;
            }
        }

        /// <summary>
        /// удаляет по порядковому номеру
        /// </summary>
        /// <param name="node"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public Node RemoveNode(Node node, int index)
        {

            if (index == 0)
            {
                var newNode = node.NextNode;
                node.NextNode = null;
                return newNode;
            }

            int currentIndex = 0;
            var currentNode = node;
            while (currentNode != null)
            {
                if (currentIndex == index - 1)
                {
                    RemoveNextItem(currentNode);
                    return node;
                }

                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return node;
        }
        /// <summary>
        /// удаление следующего 
        /// </summary>
        /// <param name="node"></param>
        public void RemoveNextItem(Node node) //удаление следующего 
        {
            if (node.NextNode == null)
                return;

            var nextItem = node.NextNode.NextNode;
            node.NextNode = nextItem;
            var prevItem = node.PrevNode;
            node.PrevNode = prevItem;

        }
        /// <summary>
        ///  поиск элемента по его значению
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public Node FindNode(int searchValue)
        {
            var findNode = head;
            while (findNode != null)
            {
                if (findNode.Value == searchValue)
                {
                    return findNode;
                }
                findNode = findNode.NextNode;
            }
            return null;
        }
        /// <summary>
        /// Запуск проекта Двусвязного списка
        /// </summary>
        public void RunNode()
        {
            var node = new Node();
            // ввод данных на консоль
            Console.WriteLine("Содержимое списка");
            node.AddNode(1);
            node.AddNode(2);
            node.AddNode(777);
            node.AddNode(4);
            Console.WriteLine(node.head.Value);
            Console.WriteLine(node.head.NextNode.Value);
            Console.WriteLine(node.head.NextNode.NextNode.Value);
            Console.WriteLine(node.tail.Value);
            Console.WriteLine("Добавление в конец списка 999");
            // вывод данных после довавления

            node.AddNodeAfter(node.tail, 999);
            // ввод данных на консоль
            Console.WriteLine("Содержимое списка");
            Console.WriteLine(node.head.Value);
            Console.WriteLine(node.head.NextNode.Value);
            Console.WriteLine(node.head.NextNode.NextNode.Value);
            Console.WriteLine(node.head.NextNode.NextNode.NextNode.Value);
            Console.WriteLine(node.tail.Value);
            // кол-во элементов в списке
            Console.WriteLine("Количество элементов в списке");
            Console.WriteLine(node.GetCount());
            // удаление элемента
            Console.WriteLine("удаление элементов 2 и 3");
            node.RemoveNode(node.head, 1); //удаление указанного элемента 
            node.RemoveNextItem(node.head);//удаление с головы


            // кол-во элементов в списке
            Console.WriteLine("Количество элементов в списке");
            Console.WriteLine(node.GetCount());
            // ввод данных на консоль
            Console.WriteLine("Содержимое списка");
            Console.WriteLine(node.head.Value);
            Console.WriteLine(node.head.NextNode.Value);
            Console.WriteLine(node.head.NextNode.NextNode.Value);
            Console.WriteLine(node.head.tail);

            //поиск по значению
            Console.WriteLine(node.FindNode(777) != null ? "Значение 777 -  Найдено" : "Значение 777 - Не найдено");
            Console.WriteLine(node.FindNode(999) != null ? "Значение 999 -  Найдено" : "Значение 999 - Не найдено");
        }

    }
}
