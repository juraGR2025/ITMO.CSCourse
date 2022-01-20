namespace controlExercise_3_4
{
    partial class dataValidationForm
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
            this.userValidationPanel1 = new controlExercise_3_4.UserValidationPanel();
            this.SuspendLayout();
            // 
            // userValidationPanel1
            // 
            this.userValidationPanel1.Location = new System.Drawing.Point(26, 12);
            this.userValidationPanel1.Name = "userValidationPanel1";
            this.userValidationPanel1.Size = new System.Drawing.Size(617, 219);
            this.userValidationPanel1.TabIndex = 0;
            // 
            // dataValidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 251);
            this.Controls.Add(this.userValidationPanel1);
            this.Name = "dataValidationForm";
            this.Text = "Форма с валидацией данных";
            this.ResumeLayout(false);

        }


        #endregion

        private UserValidationPanel userValidationPanel1;
    }
}

