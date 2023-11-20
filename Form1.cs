using Microsoft.Win32;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace OptizProgWinform
{
    public partial class Form1 : Form
    {
        private static int win32NewValue;
        private static string labelText = "None";

        private const string win32KeyPath = @"SYSTEM\CurrentControlSet\Control\PriorityControl";
        private const string win32Name = "Win32PrioritySeparation";

        public Form1()
        {
            InitializeComponent();
            CheckWin32Value();
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ числовым или является ли символ разделителем числа
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Отменяем ввод символа
            }
        }

        private void ResetWin32_Click(object sender, EventArgs e)
        {
            win32NewValue = 42;
            Win32PriorityButton_Click(this, EventArgs.Empty);
            CheckWin32Value();
        }

        private void CheckWin32Value()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(win32KeyPath, true))
            {
                if (key != null)
                {
                    object value = key.GetValue("Win32PrioritySeparation");
                    if (value != null)
                    {
                        labelText = value.ToString();
                        label1.Text = labelText; // Обновляем текст на форме

                    }
                }
                else
                {
                    labelText = "None";
                    label1.Text = labelText;
                }
            }

        }

        private void Win32PriorityButton_Click(object sender, EventArgs e)
        {

            if (int.TryParse(comboBox1.Text, out win32NewValue))
            {

                try
                {
                    // Открываем раздел реестра для записи
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(win32KeyPath, true))
                    {
                        if (key != null)
                        {
                            // Задаем новое значение параметра
                            key.SetValue(win32Name, win32NewValue);
                            Console.WriteLine("Значение параметра успешно изменено.");
                            CheckWin32Value();

                        }
                        else
                        {
                            Console.WriteLine("Не удалось найти раздел реестра.");

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);

                }
            }
            else
            {
                Console.WriteLine("Некорректное значение в TextBox. Введите целое число.");
            }
        }


    }
}