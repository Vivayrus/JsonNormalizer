namespace JsonNormalizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            inputJson = new TextBox();
            outputJson = new TextBox();
            fileSelBtn = new Button();
            normilizeBtn = new Button();
            button1 = new Button();
            labelInput = new Label();
            outputLabel = new Label();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // inputJson
            // 
            inputJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            inputJson.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            inputJson.Location = new Point(13, 48);
            inputJson.MaxLength = 1000000;
            inputJson.Multiline = true;
            inputJson.Name = "inputJson";
            inputJson.ScrollBars = ScrollBars.Both;
            inputJson.Size = new Size(600, 500);
            inputJson.TabIndex = 0;
            inputJson.WordWrap = false;
            // 
            // outputJson
            // 
            outputJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            outputJson.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            outputJson.Location = new Point(619, 48);
            outputJson.MaxLength = 1000000;
            outputJson.Multiline = true;
            outputJson.Name = "outputJson";
            outputJson.ScrollBars = ScrollBars.Both;
            outputJson.Size = new Size(600, 500);
            outputJson.TabIndex = 1;
            outputJson.WordWrap = false;
            // 
            // fileSelBtn
            // 
            fileSelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fileSelBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fileSelBtn.Location = new Point(13, 554);
            fileSelBtn.Name = "fileSelBtn";
            fileSelBtn.Size = new Size(191, 41);
            fileSelBtn.TabIndex = 2;
            fileSelBtn.Text = "Открыть файл";
            fileSelBtn.UseVisualStyleBackColor = true;
            fileSelBtn.Click += fileSelBtn_Click;
            // 
            // normilizeBtn
            // 
            normilizeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            normilizeBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            normilizeBtn.Location = new Point(407, 554);
            normilizeBtn.Name = "normilizeBtn";
            normilizeBtn.Size = new Size(191, 41);
            normilizeBtn.TabIndex = 4;
            normilizeBtn.Text = "Преобразовать";
            normilizeBtn.UseVisualStyleBackColor = true;
            normilizeBtn.Click += normilizeBtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(210, 554);
            button1.Name = "button1";
            button1.Size = new Size(191, 41);
            button1.TabIndex = 3;
            button1.Text = "Сохранить как...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelInput
            // 
            labelInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelInput.AutoSize = true;
            labelInput.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInput.Location = new Point(13, 19);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(194, 26);
            labelInput.TabIndex = 2;
            labelInput.Text = "Входные данные";
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            outputLabel.Location = new Point(619, 19);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(213, 26);
            outputLabel.TabIndex = 2;
            outputLabel.Text = "Выходные данные";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "JSON";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt) | *.txt | JSON файлы (*.JSON) | *.JSON | Все файлы |*.*";
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.JSON)|*.JSON|All Files (*.*)|*.*";
            openFileDialog1.Title = "Выбор файла";
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearBtn.Location = new Point(604, 554);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(191, 41);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Очистить данные";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 607);
            Controls.Add(outputLabel);
            Controls.Add(labelInput);
            Controls.Add(clearBtn);
            Controls.Add(normilizeBtn);
            Controls.Add(button1);
            Controls.Add(fileSelBtn);
            Controls.Add(outputJson);
            Controls.Add(inputJson);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1240, 646);
            MinimumSize = new Size(1240, 646);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Нормализатор JSON";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputJson;
        private TextBox outputJson;
        private Button fileSelBtn;
        private Button normilizeBtn;
        private Button button1;
        private Label labelInput;
        private Label outputLabel;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button clearBtn;
    }
}
