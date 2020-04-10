namespace SortingSort
{
    partial class SortingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortingForm));
            this.InsertionSort = new System.Windows.Forms.CheckBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.CreateArray = new System.Windows.Forms.Button();
            this.ArraySize = new System.Windows.Forms.TextBox();
            this.RandRange = new System.Windows.Forms.TextBox();
            this.sizelbl = new System.Windows.Forms.Label();
            this.rangelbl = new System.Windows.Forms.Label();
            this.UploadArray = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorCatText = new System.Windows.Forms.Label();
            this.CatSpeech = new System.Windows.Forms.PictureBox();
            this.ErrorCat = new System.Windows.Forms.PictureBox();
            this.BubbleSort = new System.Windows.Forms.CheckBox();
            this.ShellSort = new System.Windows.Forms.CheckBox();
            this.MergeSort = new System.Windows.Forms.CheckBox();
            this.NoDownload = new System.Windows.Forms.CheckBox();
            this.QuickSort = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CatSpeech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCat)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertionSort
            // 
            this.InsertionSort.AutoSize = true;
            this.InsertionSort.Font = new System.Drawing.Font("Ink Free", 17F);
            this.InsertionSort.Location = new System.Drawing.Point(1067, 106);
            this.InsertionSort.Margin = new System.Windows.Forms.Padding(4);
            this.InsertionSort.Name = "InsertionSort";
            this.InsertionSort.Size = new System.Drawing.Size(338, 40);
            this.InsertionSort.TabIndex = 0;
            this.InsertionSort.Text = "Insertion Sort (O(n^2))";
            this.InsertionSort.UseVisualStyleBackColor = true;
            this.InsertionSort.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Ink Free", 12F);
            this.InputTextBox.Location = new System.Drawing.Point(43, 71);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(511, 381);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Ink Free", 12F);
            this.OutputTextBox.Location = new System.Drawing.Point(43, 501);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(511, 381);
            this.OutputTextBox.TabIndex = 3;
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SortButton.Font = new System.Drawing.Font("Ink Free", 25F, System.Drawing.FontStyle.Bold);
            this.SortButton.Location = new System.Drawing.Point(725, 650);
            this.SortButton.Margin = new System.Windows.Forms.Padding(4);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(136, 68);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // CreateArray
            // 
            this.CreateArray.AccessibleName = "CreateArray";
            this.CreateArray.Font = new System.Drawing.Font("Ink Free", 25F, System.Drawing.FontStyle.Bold);
            this.CreateArray.Location = new System.Drawing.Point(601, 299);
            this.CreateArray.Margin = new System.Windows.Forms.Padding(4);
            this.CreateArray.Name = "CreateArray";
            this.CreateArray.Size = new System.Drawing.Size(393, 57);
            this.CreateArray.TabIndex = 5;
            this.CreateArray.Text = "Create an Array";
            this.CreateArray.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateArray.UseVisualStyleBackColor = true;
            this.CreateArray.Click += new System.EventHandler(this.CreateArray_Click);
            // 
            // ArraySize
            // 
            this.ArraySize.Font = new System.Drawing.Font("Ink Free", 15F);
            this.ArraySize.Location = new System.Drawing.Point(848, 112);
            this.ArraySize.Margin = new System.Windows.Forms.Padding(4);
            this.ArraySize.Name = "ArraySize";
            this.ArraySize.Size = new System.Drawing.Size(145, 38);
            this.ArraySize.TabIndex = 6;
            this.ArraySize.TextChanged += new System.EventHandler(this.ArraySize_TextChanged);
            // 
            // RandRange
            // 
            this.RandRange.Font = new System.Drawing.Font("Ink Free", 15F);
            this.RandRange.Location = new System.Drawing.Point(848, 182);
            this.RandRange.Margin = new System.Windows.Forms.Padding(4);
            this.RandRange.Name = "RandRange";
            this.RandRange.Size = new System.Drawing.Size(145, 38);
            this.RandRange.TabIndex = 7;
            this.RandRange.TextChanged += new System.EventHandler(this.RandRange_TextChanged);
            // 
            // sizelbl
            // 
            this.sizelbl.AutoSize = true;
            this.sizelbl.Font = new System.Drawing.Font("Ink Free", 15F);
            this.sizelbl.Location = new System.Drawing.Point(613, 116);
            this.sizelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizelbl.Name = "sizelbl";
            this.sizelbl.Size = new System.Drawing.Size(125, 31);
            this.sizelbl.TabIndex = 8;
            this.sizelbl.Text = "Array Size";
            // 
            // rangelbl
            // 
            this.rangelbl.AutoSize = true;
            this.rangelbl.Font = new System.Drawing.Font("Ink Free", 15F);
            this.rangelbl.Location = new System.Drawing.Point(613, 186);
            this.rangelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangelbl.Name = "rangelbl";
            this.rangelbl.Size = new System.Drawing.Size(169, 31);
            this.rangelbl.TabIndex = 9;
            this.rangelbl.Text = "Random Range";
            // 
            // UploadArray
            // 
            this.UploadArray.AccessibleName = "UploadArray";
            this.UploadArray.Font = new System.Drawing.Font("Ink Free", 25F, System.Drawing.FontStyle.Bold);
            this.UploadArray.Location = new System.Drawing.Point(601, 362);
            this.UploadArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UploadArray.Name = "UploadArray";
            this.UploadArray.Size = new System.Drawing.Size(393, 57);
            this.UploadArray.TabIndex = 10;
            this.UploadArray.Text = "Upload an Array";
            this.UploadArray.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UploadArray.UseVisualStyleBackColor = true;
            this.UploadArray.Click += new System.EventHandler(this.UploadArray_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Ink Free", 20F);
            this.label3.Location = new System.Drawing.Point(43, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "Input";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Ink Free", 20F);
            this.label4.Location = new System.Drawing.Point(43, 457);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Output";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Ink Free", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1067, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 53);
            this.label5.TabIndex = 13;
            this.label5.Text = "Choose Sort";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorCatText
            // 
            this.ErrorCatText.AutoSize = true;
            this.ErrorCatText.BackColor = System.Drawing.Color.Transparent;
            this.ErrorCatText.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold);
            this.ErrorCatText.Location = new System.Drawing.Point(813, 533);
            this.ErrorCatText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorCatText.Name = "ErrorCatText";
            this.ErrorCatText.Size = new System.Drawing.Size(0, 31);
            this.ErrorCatText.TabIndex = 16;
            this.ErrorCatText.Visible = false;
            // 
            // CatSpeech
            // 
            this.CatSpeech.BackColor = System.Drawing.Color.Transparent;
            this.CatSpeech.Image = global::SortingSort.Properties.Resources.SpeechBubble_svg;
            this.CatSpeech.Location = new System.Drawing.Point(788, 469);
            this.CatSpeech.Margin = new System.Windows.Forms.Padding(4);
            this.CatSpeech.Name = "CatSpeech";
            this.CatSpeech.Size = new System.Drawing.Size(433, 178);
            this.CatSpeech.TabIndex = 15;
            this.CatSpeech.TabStop = false;
            this.CatSpeech.Visible = false;
            // 
            // ErrorCat
            // 
            this.ErrorCat.Image = global::SortingSort.Properties.Resources.Error;
            this.ErrorCat.Location = new System.Drawing.Point(1079, 650);
            this.ErrorCat.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorCat.Name = "ErrorCat";
            this.ErrorCat.Size = new System.Drawing.Size(267, 246);
            this.ErrorCat.TabIndex = 14;
            this.ErrorCat.TabStop = false;
            this.ErrorCat.Visible = false;
            // 
            // BubbleSort
            // 
            this.BubbleSort.AutoSize = true;
            this.BubbleSort.Font = new System.Drawing.Font("Ink Free", 17F);
            this.BubbleSort.Location = new System.Drawing.Point(1067, 154);
            this.BubbleSort.Margin = new System.Windows.Forms.Padding(4);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(306, 40);
            this.BubbleSort.TabIndex = 17;
            this.BubbleSort.Text = "Bubble Sort (O(n^2))";
            this.BubbleSort.UseVisualStyleBackColor = true;
            // 
            // ShellSort
            // 
            this.ShellSort.AutoSize = true;
            this.ShellSort.Font = new System.Drawing.Font("Ink Free", 17F);
            this.ShellSort.Location = new System.Drawing.Point(1067, 202);
            this.ShellSort.Margin = new System.Windows.Forms.Padding(4);
            this.ShellSort.Name = "ShellSort";
            this.ShellSort.Size = new System.Drawing.Size(280, 40);
            this.ShellSort.TabIndex = 18;
            this.ShellSort.Text = "Shell Sort (O(n^2))";
            this.ShellSort.UseVisualStyleBackColor = true;
            // 
            // MergeSort
            // 
            this.MergeSort.AutoSize = true;
            this.MergeSort.Font = new System.Drawing.Font("Ink Free", 17F);
            this.MergeSort.Location = new System.Drawing.Point(1067, 250);
            this.MergeSort.Margin = new System.Windows.Forms.Padding(4);
            this.MergeSort.Name = "MergeSort";
            this.MergeSort.Size = new System.Drawing.Size(329, 40);
            this.MergeSort.TabIndex = 19;
            this.MergeSort.Text = "Merge Sort (O(n log n))";
            this.MergeSort.UseVisualStyleBackColor = true;
            // 
            // NoDownload
            // 
            this.NoDownload.AutoSize = true;
            this.NoDownload.Font = new System.Drawing.Font("Ink Free", 17F);
            this.NoDownload.Location = new System.Drawing.Point(783, 254);
            this.NoDownload.Margin = new System.Windows.Forms.Padding(4);
            this.NoDownload.Name = "NoDownload";
            this.NoDownload.Size = new System.Drawing.Size(189, 40);
            this.NoDownload.TabIndex = 20;
            this.NoDownload.Text = "No Download";
            this.NoDownload.UseVisualStyleBackColor = true;
            this.NoDownload.CheckedChanged += new System.EventHandler(this.NoDownload_CheckedChanged);
            // 
            // QuickSort
            // 
            this.QuickSort.AutoSize = true;
            this.QuickSort.Font = new System.Drawing.Font("Ink Free", 17F);
            this.QuickSort.Location = new System.Drawing.Point(1067, 295);
            this.QuickSort.Margin = new System.Windows.Forms.Padding(4);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(306, 40);
            this.QuickSort.TabIndex = 21;
            this.QuickSort.Text = "Quicksort (O(n log n))";
            this.QuickSort.UseVisualStyleBackColor = true;
            // 
            // SortingForm
            // 
            this.AccessibleName = "SortingForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1579, 897);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.NoDownload);
            this.Controls.Add(this.MergeSort);
            this.Controls.Add(this.ShellSort);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.ErrorCatText);
            this.Controls.Add(this.ErrorCat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UploadArray);
            this.Controls.Add(this.rangelbl);
            this.Controls.Add(this.sizelbl);
            this.Controls.Add(this.RandRange);
            this.Controls.Add(this.ArraySize);
            this.Controls.Add(this.CreateArray);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InsertionSort);
            this.Controls.Add(this.CatSpeech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SortingForm";
            this.Text = "Sort \'Em All";
            ((System.ComponentModel.ISupportInitialize)(this.CatSpeech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox InsertionSort;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button CreateArray;
        private System.Windows.Forms.TextBox ArraySize;
        private System.Windows.Forms.TextBox RandRange;
        private System.Windows.Forms.Label sizelbl;
        private System.Windows.Forms.Label rangelbl;
        private System.Windows.Forms.Button UploadArray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ErrorCat;
        private System.Windows.Forms.PictureBox CatSpeech;
        private System.Windows.Forms.Label ErrorCatText;
        private System.Windows.Forms.CheckBox BubbleSort;
        private System.Windows.Forms.CheckBox ShellSort;
        private System.Windows.Forms.CheckBox MergeSort;
        private System.Windows.Forms.CheckBox NoDownload;
        private System.Windows.Forms.CheckBox QuickSort;
    }
}

