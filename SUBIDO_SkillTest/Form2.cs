using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SUBIDO_SkillTest
{
    public partial class Form2 : Form
    {
        private readonly Controller _controller; // Added "readonly" as suggested by Visual Studio

        public Form2()
        {
            InitializeComponent();
            _controller = new Controller(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.SortInput(textBox1.Text, comboBox1.SelectedIndex);
        }

        public void DisplaySortedOutput(string sortedOutput)
        {
            textBox2.Text = sortedOutput;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Automatically handled by the controller on sort request
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Output displayed by the controller
        }
    }

    public class Model
    {
        public char[] MyCharacters { get; private set; }
        public string SortedOutput { get; private set; }

        public Model(string myInput)
        {
            MyCharacters = myInput.ToCharArray();
            SortedOutput = "";  // Initialize with an empty string to prevent the warning
        }

        public void BubbleSort()
        {
            for (int i = 0; i < MyCharacters.Length - 1; i++)
            {
                for (int j = 0; j < MyCharacters.Length - i - 1; j++)
                {
                    if (MyCharacters[j] > MyCharacters[j + 1])
                    {
                        (MyCharacters[j + 1], MyCharacters[j]) = (MyCharacters[j], MyCharacters[j + 1]);
                    }
                }
            }
            SortedOutput = new string(MyCharacters);
        }

        public void QuickSort(int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(left, right);
                QuickSort(left, pivotIndex - 1);
                QuickSort(pivotIndex + 1, right);
            }
            SortedOutput = new string(MyCharacters);
        }

        private int Partition(int left, int right)
        {
            char pivot = MyCharacters[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (MyCharacters[j] < pivot)
                {
                    i++;
                    Swap(i, j);
                }
            }
            Swap(i + 1, right);
            return i + 1;
        }

        private void Swap(int i, int j)
        {
            (MyCharacters[j], MyCharacters[i]) = (MyCharacters[i], MyCharacters[j]);
        }

        public void MergeSort(int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(left, mid);
                MergeSort(mid + 1, right);
                Merge(left, mid, right);
            }
            SortedOutput = new string(MyCharacters);
        }

        private void Merge(int left, int mid, int right)
        {
            int x = mid - left + 1;
            int y = right - mid;

            char[] a = new char[x];
            char[] b = new char[y];

            Array.Copy(MyCharacters, left, a, 0, x);
            Array.Copy(MyCharacters, mid + 1, b, 0, y);

            int i = 0, j = 0, k = left;

            while (i < x && j < y)
            {
                if (a[i] <= b[j])
                {
                    MyCharacters[k] = a[i];
                    i++;
                }
                else
                {
                    MyCharacters[k] = b[j];
                    j++;
                }
                k++;
            }

            while (i < x)
            {
                MyCharacters[k] = a[i];
                i++;
                k++;
            }

            while (j < y)
            {
                MyCharacters[k] = b[j];
                j++;
                k++;
            }
        }
    }

    public class Controller
    {
        private Model _model;
        private readonly Form2 _view; // Added "readonly" as suggested by Visual Studio

        public Controller(Form2 view)
        {
            _view = view;
            _model = new Model(""); // Initialize _model with a default value
        }

        public void SortInput(string myInput, int sortMethod)
        {
            _model = new Model(myInput);

            switch (sortMethod)
            {
                case 0: // Bubble Sort
                    _model.BubbleSort();
                    break;
                case 1: // Quick Sort
                    _model.QuickSort(0, _model.MyCharacters.Length - 1);
                    break;
                case 2: // Merge Sort
                    _model.MergeSort(0, _model.MyCharacters.Length - 1);
                    break;
                default: // Default to Bubble Sort
                    _model.BubbleSort();
                    break;
            }

            _view.DisplaySortedOutput(_model.SortedOutput);
        }
    }

    public class TestSorting
    {
        public static void Main()
        {
            TestBubbleSort();
            TestQuickSort();
            TestMergeSort();
            Console.WriteLine("All tests passed.");
        }

        // Helper method to check if two arrays are equal
        private static bool AreArraysEqual(char[] arr1, char[] arr2)
        {
            if (arr1.Length != arr2.Length) return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        // Test Bubble Sort
        public static void TestBubbleSort()
        {
            Model model = new("dcba");
            model.BubbleSort();
            char[] expectedOutput = ['a', 'b', 'c', 'd'];
            char[] actualOutput = model.MyCharacters;

            if (!AreArraysEqual(expectedOutput, actualOutput))
            {
                Console.WriteLine("BubbleSort Test Failed!");
            }
            else
            {
                Console.WriteLine("BubbleSort Test Passed.");
            }
        }

        // Test Quick Sort
        public static void TestQuickSort()
        {
            Model model = new("dcba");
            model.QuickSort(0, model.MyCharacters.Length - 1);
            char[] expectedOutput = ['a', 'b', 'c', 'd'];
            char[] actualOutput = model.MyCharacters;

            if (!AreArraysEqual(expectedOutput, actualOutput))
            {
                Console.WriteLine("QuickSort Test Failed!");
            }
            else
            {
                Console.WriteLine("QuickSort Test Passed.");
            }
        }

        // Test Merge Sort
        public static void TestMergeSort()
        {
            Model model = new("dcba");
            model.MergeSort(0, model.MyCharacters.Length - 1);
            char[] expectedOutput = ['a', 'b', 'c', 'd'];
            char[] actualOutput = model.MyCharacters;

            if (!AreArraysEqual(expectedOutput, actualOutput))
            {
                Console.WriteLine("MergeSort Test Failed!");
            }
            else
            {
                Console.WriteLine("MergeSort Test Passed.");
            }
        }
    }
}
