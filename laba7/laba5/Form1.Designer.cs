namespace laba5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.restoreButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownIDRestore = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxField = new System.Windows.Forms.TextBox();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.fieldsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxWithWiFi = new System.Windows.Forms.CheckBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBoxReadingRoomsCount = new System.Windows.Forms.TextBox();
            this.textBoxBooksNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.clearWindow = new System.Windows.Forms.Button();
            this.printAll = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDRestore)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.fieldsButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.clearWindow);
            this.groupBox1.Controls.Add(this.printAll);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 669);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функционал";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.restoreButton);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.numericUpDownIDRestore);
            this.groupBox5.Location = new System.Drawing.Point(6, 261);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(475, 98);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Восстановление предыдущей версии объекта";
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restoreButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restoreButton.Location = new System.Drawing.Point(249, 54);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(215, 29);
            this.restoreButton.TabIndex = 9;
            this.restoreButton.Text = "Восстановить";
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(19, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "ID объекта";
            // 
            // numericUpDownIDRestore
            // 
            this.numericUpDownIDRestore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownIDRestore.Location = new System.Drawing.Point(11, 56);
            this.numericUpDownIDRestore.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIDRestore.Name = "numericUpDownIDRestore";
            this.numericUpDownIDRestore.Size = new System.Drawing.Size(102, 27);
            this.numericUpDownIDRestore.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.changeButton);
            this.groupBox4.Controls.Add(this.textBoxValue);
            this.groupBox4.Controls.Add(this.textBoxField);
            this.groupBox4.Controls.Add(this.numericUpDownID);
            this.groupBox4.Location = new System.Drawing.Point(6, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 97);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Изменение значения поля объекта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(264, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Значение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(158, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Поле";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID объекта";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeButton.Location = new System.Drawing.Point(362, 55);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(102, 29);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValue.Location = new System.Drawing.Point(249, 56);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(102, 27);
            this.textBoxValue.TabIndex = 2;
            // 
            // textBoxField
            // 
            this.textBoxField.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxField.Location = new System.Drawing.Point(130, 56);
            this.textBoxField.Name = "textBoxField";
            this.textBoxField.Size = new System.Drawing.Size(100, 27);
            this.textBoxField.TabIndex = 1;
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownID.Location = new System.Drawing.Point(11, 56);
            this.numericUpDownID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(102, 27);
            this.numericUpDownID.TabIndex = 0;
            // 
            // fieldsButton
            // 
            this.fieldsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fieldsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldsButton.Location = new System.Drawing.Point(19, 87);
            this.fieldsButton.Name = "fieldsButton";
            this.fieldsButton.Size = new System.Drawing.Size(217, 39);
            this.fieldsButton.TabIndex = 4;
            this.fieldsButton.Text = "Вывести поля класса";
            this.fieldsButton.UseVisualStyleBackColor = false;
            this.fieldsButton.Click += new System.EventHandler(this.fieldsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBoxWithWiFi);
            this.groupBox2.Controls.Add(this.textBoxRating);
            this.groupBox2.Controls.Add(this.textBoxReadingRoomsCount);
            this.groupBox2.Controls.Add(this.textBoxBooksNumber);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.create);
            this.groupBox2.Location = new System.Drawing.Point(6, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 282);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание нового объекта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Наличие Wi-Fi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Рейтинг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество читальных залов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество книг";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название библиотеки";
            // 
            // checkBoxWithWiFi
            // 
            this.checkBoxWithWiFi.AutoSize = true;
            this.checkBoxWithWiFi.Location = new System.Drawing.Point(249, 215);
            this.checkBoxWithWiFi.Name = "checkBoxWithWiFi";
            this.checkBoxWithWiFi.Size = new System.Drawing.Size(18, 17);
            this.checkBoxWithWiFi.TabIndex = 6;
            this.checkBoxWithWiFi.UseVisualStyleBackColor = true;
            // 
            // textBoxRating
            // 
            this.textBoxRating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRating.Location = new System.Drawing.Point(249, 172);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(215, 27);
            this.textBoxRating.TabIndex = 5;
            // 
            // textBoxReadingRoomsCount
            // 
            this.textBoxReadingRoomsCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxReadingRoomsCount.Location = new System.Drawing.Point(249, 130);
            this.textBoxReadingRoomsCount.Name = "textBoxReadingRoomsCount";
            this.textBoxReadingRoomsCount.Size = new System.Drawing.Size(215, 27);
            this.textBoxReadingRoomsCount.TabIndex = 4;
            // 
            // textBoxBooksNumber
            // 
            this.textBoxBooksNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBooksNumber.Location = new System.Drawing.Point(249, 88);
            this.textBoxBooksNumber.Name = "textBoxBooksNumber";
            this.textBoxBooksNumber.Size = new System.Drawing.Size(215, 27);
            this.textBoxBooksNumber.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(249, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(215, 27);
            this.textBoxName.TabIndex = 2;
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create.Location = new System.Drawing.Point(249, 238);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(215, 39);
            this.create.TabIndex = 1;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // clearWindow
            // 
            this.clearWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearWindow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearWindow.Location = new System.Drawing.Point(255, 26);
            this.clearWindow.Name = "clearWindow";
            this.clearWindow.Size = new System.Drawing.Size(215, 39);
            this.clearWindow.TabIndex = 2;
            this.clearWindow.Text = "Очистить окно вывода";
            this.clearWindow.UseVisualStyleBackColor = false;
            this.clearWindow.Click += new System.EventHandler(this.clearWindow_Click);
            // 
            // printAll
            // 
            this.printAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.printAll.Location = new System.Drawing.Point(19, 26);
            this.printAll.Name = "printAll";
            this.printAll.Size = new System.Drawing.Size(217, 39);
            this.printAll.TabIndex = 1;
            this.printAll.Text = "Вывести объкты";
            this.printAll.UseVisualStyleBackColor = false;
            this.printAll.Click += new System.EventHandler(this.printAll_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(155)))), ((int)(((byte)(176)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(774, 687);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Завершить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.output);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(517, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 669);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Окно вывода";
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(6, 26);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(453, 637);
            this.output.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 737);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "21ВП2 Малькова Лакеева (лаба7 вариант 5)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDRestore)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox checkBoxWithWiFi;
        private TextBox textBoxBooksNumber;
        private TextBox textBoxName;
        private Button create;
        private Button clearWindow;
        private Button printAll;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Button button4;
        private GroupBox groupBox3;
        private TextBox output;
        private TextBox textBoxRating;
        private TextBox textBoxReadingRoomsCount;
        private Button fieldsButton;
        private GroupBox groupBox4;
        private Button changeButton;
        private TextBox textBoxValue;
        private TextBox textBoxField;
        private NumericUpDown numericUpDownID;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox groupBox5;
        private Button restoreButton;
        private Label label9;
        private NumericUpDown numericUpDownIDRestore;
    }
}