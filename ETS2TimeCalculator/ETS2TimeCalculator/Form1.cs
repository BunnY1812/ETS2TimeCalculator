using Guna.UI2.WinForms.Suite;
using System;
using System.Windows.Forms;

namespace ETS2TimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum ConversionMode { ETS2ToReal, RealToETS2 }
        private enum TimeScale { EU_NonUrban, UK_NonUrban, Cities, TruckersMP, Custom }

        private double GetScaleFactor(TimeScale scale, double customScale = 1)
        {
            switch (scale)
            {
                case TimeScale.EU_NonUrban: return 19;
                case TimeScale.UK_NonUrban: return 15;
                case TimeScale.Cities: return 3;
                case TimeScale.TruckersMP: return 6;
                case TimeScale.Custom: return customScale;
                default: return 19;
            }
        }

        private TimeSpan ConvertTime(TimeSpan input, ConversionMode mode, double scale)
        {
            if (mode == ConversionMode.ETS2ToReal)
                return TimeSpan.FromSeconds(input.TotalSeconds / scale);
            else
                return TimeSpan.FromSeconds(input.TotalSeconds * scale);
        }

        private void UpdateResult()
        {
            try
            {
                int hours = (int)numericHours.Value;
                int minutes = (int)numericMinutes.Value;
                int seconds = (int)numericSeconds.Value;
                TimeSpan inputTime = new TimeSpan(0, hours, minutes, seconds);

                ConversionMode mode = radioETS2ToReal.Checked ? ConversionMode.ETS2ToReal : ConversionMode.RealToETS2;

                TimeScale scaleType = TimeScale.EU_NonUrban;
                if (radioUK.Checked) scaleType = TimeScale.UK_NonUrban;
                else if (radioCities.Checked) scaleType = TimeScale.Cities;
                else if (radioTruckersMP.Checked) scaleType = TimeScale.TruckersMP;
                else if (radioCustom.Checked) scaleType = TimeScale.Custom;

                double customScale = (double)numericCustomScale.Value;
                double scale = GetScaleFactor(scaleType, customScale);

                TimeSpan result = ConvertTime(inputTime, mode, scale);

                // Переводим всё в часы
                double totalHours = result.TotalHours;
                int totalHoursInt = (int)totalHours;
                int remainingMinutes = result.Minutes;
                int remainingSeconds = result.Seconds;

                // Форматируем вывод
                lblResult.Text = $"{totalHoursInt}ч {remainingMinutes:00}м {remainingSeconds:00}с";

                // Обновляем реальное время если включен режим ETS2->Реальное
                if (radioETS2ToReal.Checked && checkBoxRealTime.Checked)
                {
                    UpdateRealTime(result);
                }
                else
                {
                    lblEndTime.Text = "--:--:--";
                }
            }
            catch
            {
                lblResult.Text = "Ошибка ввода";
            }
        }

        private void UpdateRealTime(TimeSpan duration)
        {
            try
            {
                DateTime startTime = dateTimePickerStart.Value;
                DateTime endTime = startTime.Add(duration);
                lblEndTime.Text = endTime.ToString("HH:mm:ss");

                // Дополнительная информация
                if (duration.TotalHours >= 24)
                {
                    int days = (int)duration.TotalDays;
                    lblEndTime.Text += $" (+{days} дн.)";
                }
            }
            catch
            {
                lblEndTime.Text = "Ошибка";
            }
        }

        private void Numeric_ValueChanged(object sender, EventArgs e) => UpdateResult();

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            numericCustomScale.Enabled = radioCustom.Checked;

            // Показываем чекбокс только в режиме ETS2 → Реальное
            bool showRealTimeCheckbox = radioETS2ToReal.Checked;
            checkBoxRealTime.Visible = showRealTimeCheckbox;

            // Если чекбокс не виден - снимаем галку и скрываем панель
            if (!showRealTimeCheckbox)
            {
                checkBoxRealTime.Checked = false;
                panelRealTime.Visible = false;
                panelRealTimeControls.Enabled = false;
                lblEndTime.Text = "--:--:--";
            }
            else
            {
                // Если чекбокс виден, но не отмечен - панель скрыта
                panelRealTime.Visible = checkBoxRealTime.Checked;
                panelRealTimeControls.Enabled = checkBoxRealTime.Checked;
            }

            UpdateResult();
        }

        private void CheckBoxRealTime_CheckedChanged(object sender, EventArgs e)
        {
            // Показываем/скрываем всю панель реального времени
            panelRealTime.Visible = checkBoxRealTime.Checked;
            panelRealTimeControls.Enabled = checkBoxRealTime.Checked;

            // Если панель скрыта, сбрасываем отображение времени
            if (!checkBoxRealTime.Checked)
            {
                lblEndTime.Text = "--:--:--";
            }

            UpdateResult();
        }

        private void DateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Now;
            checkBoxRealTime.Checked = false; // По умолчанию выключено
            panelRealTime.Visible = false;    // Панель скрыта
            panelRealTimeControls.Enabled = false;
            UpdateResult();
        }
    }
}