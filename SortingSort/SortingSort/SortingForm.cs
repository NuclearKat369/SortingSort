using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingSort
{
    public partial class SortingForm : Form
    {
        public SortingForm()
        {
            InitializeComponent();
            if (ArraySize.Text == "" || RandRange.Text == "") CreateArray.Enabled = false;
            
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            //Если массив не создан или состоит из 0 элементов, появляется сообщение 
            //об ошибке и необходимости создания массива, который можно отсортировать
            if (InputTextBox.Text == "" || ArraySize.Text == "0")
            {
                ErrorCat.Image = Properties.Resources.Error;
                ErrorCatText.Text = "I see no array here!";
                ErrorCat.Visible = true;
                CatSpeech.Visible = true;
                ErrorCatText.Visible = true;
                OutputTextBox.Text = "";
            }
            else
            {               
                if (InsertionSort.Checked ^ BubbleSort.Checked ^ ShellSort.Checked ^ MergeSort.Checked ^ QuickSort.Checked)
                {
                    if (InsertionSort.Checked)
                    {
                        ErrorCat.Visible = false;
                        CatSpeech.Visible = false;
                        ErrorCatText.Visible = false;
                        OutputTextBox.Text = string.Join(" ", Arr.InsertSort());
                    }

                    if (BubbleSort.Checked)
                    {
                        ErrorCat.Visible = false;
                        CatSpeech.Visible = false;
                        ErrorCatText.Visible = false;
                        OutputTextBox.Text = string.Join(" ", Arr.BubbleSort());
                    }

                    if (ShellSort.Checked)
                    {
                        ErrorCat.Visible = false;
                        CatSpeech.Visible = false;
                        ErrorCatText.Visible = false;
                        OutputTextBox.Text = string.Join(" ", Arr.ShellSort());
                    }

                    if (MergeSort.Checked)
                    {
                        ErrorCat.Visible = false;
                        CatSpeech.Visible = false;
                        ErrorCatText.Visible = false;
                        OutputTextBox.Text = string.Join(" ", Arr.MergeSort());
                    }

                    if (QuickSort.Checked)
                    {
                        ErrorCat.Visible = false;
                        CatSpeech.Visible = false;
                        ErrorCatText.Visible = false;
                        OutputTextBox.Text = string.Join(" ", Arr.Quicksort());
                    }
                }

                //Если выбран не выбран ни один из методов сортировки, программа попросит выбрать 
                //один из предложенных алгоритмов сортировки
                else if ((InsertionSort.Checked == false) & (BubbleSort.Checked == false) & (ShellSort.Checked == false) & (MergeSort.Checked == false) & (QuickSort.Checked == false))
                {
                    ErrorCat.Image = Properties.Resources.Error;
                    ErrorCatText.Text = "Choose a sorting type!";
                    ErrorCat.Visible = true;
                    CatSpeech.Visible = true;
                    ErrorCatText.Visible = true;
                    OutputTextBox.Text = "";
                }

                //При выборе нескольких алгоритмов сразу программа попросит выбрать 
                //один из предложенных
                else
                {
                    ErrorCat.Image = Properties.Resources.Error;
                    ErrorCatText.Text = "Choose ONE sorting type!";
                    ErrorCat.Visible = true;
                    CatSpeech.Visible = true;
                    ErrorCatText.Visible = true;
                    OutputTextBox.Text = "";
                }
            }
            

        }

        private void ArraySize_TextChanged(object sender, EventArgs e)
        {
            if (ArraySize.Text != "" && RandRange.Text != "") CreateArray.Enabled = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RandRange_TextChanged(object sender, EventArgs e)
        {
            if (ArraySize.Text != "" && RandRange.Text != "") CreateArray.Enabled = true;
        }

        
        private void CreateArray_Click(object sender, EventArgs e)
        {
            //Если стоит галка NoDownload, то массив просто выводится в окне Input 
            if (NoDownload.Checked)
            {
                //Если параметры массива не заданы, то выводится требование об их заполнении
                if (ArraySize.Text == "" || RandRange.Text == "")
                {
                    ErrorCat.Image = Properties.Resources.Error;
                    ErrorCatText.Text = "Set array properties!";
                    ErrorCat.Visible = true;
                    CatSpeech.Visible = true;
                    ErrorCatText.Visible = true;
                    CreateArray.Enabled = false;
                }

                
                else
                {
                    ErrorCat.Visible = false;
                    CatSpeech.Visible = false;
                    ErrorCatText.Visible = false;
                    int s = Int32.Parse(ArraySize.Text);
                    int r = Int32.Parse(RandRange.Text);
                    Arr.setArray(s, r);
                    InputTextBox.Text = string.Join(" ", Arr.getArray());

                }

                
            }

            //Если галка NoDownload не стоит, то массив записывается
            //в файл input.txt и выводится в окне Input 
            else
            {
                //Если параметры массива не заданы, то выводится требование об их заполнении
                if (ArraySize.Text == "" || RandRange.Text == "")
                {
                    ErrorCat.Image = Properties.Resources.Error;
                    ErrorCatText.Text = "Set array properties!";
                    ErrorCat.Visible = true;
                    CatSpeech.Visible = true;
                    ErrorCatText.Visible = true;
                    CreateArray.Enabled = false;
                }
                else
                {
                    ErrorCat.Visible = false;
                    CatSpeech.Visible = false;
                    ErrorCatText.Visible = false;
                    int s = Int32.Parse(ArraySize.Text);
                    int r = Int32.Parse(RandRange.Text);
                    Arr.setArray(s, r);
                    Arr.CreateUnsortedArrayInTxtFile();
                    InputTextBox.Text = Arr.ReadArrayInTxtFile();
                }
                
            }

        }

        private void UploadArray_Click(object sender, EventArgs e)
        {
            Arr.CreateSortedArrayInTxtFile();
        }

        private void NoDownload_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
