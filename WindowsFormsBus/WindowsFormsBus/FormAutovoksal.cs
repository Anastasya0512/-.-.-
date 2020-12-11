using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsBus
{
    public partial class FormAutovoksal : Form
    {
        private readonly AutovoksalCollection autovoksalCollection;
        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;
        public FormAutovoksal()
        {
            InitializeComponent();
            autovoksalCollection = new AutovoksalCollection(pictureBoxAutovoksal.Width, pictureBoxAutovoksal.Height);
            logger = LogManager.GetCurrentClassLogger();
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxAutovoksal.SelectedIndex;
            listBoxAutovoksal.Items.Clear();
            for (int i = 0; i < autovoksalCollection.Keys.Count; i++)
            {
                listBoxAutovoksal.Items.Add(autovoksalCollection.Keys[i]);
            }
            if (listBoxAutovoksal.Items.Count > 0 && (index == -1 || index >= listBoxAutovoksal.Items.Count))
            {
                listBoxAutovoksal.SelectedIndex = 0;
            }
            else if (listBoxAutovoksal.Items.Count > 0 && index > -1 && index < listBoxAutovoksal.Items.Count)
            {
                listBoxAutovoksal.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxAutovoksal.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAutovoksal.Width, pictureBoxAutovoksal.Height);
                Graphics gr = Graphics.FromImage(bmp);
                autovoksalCollection[listBoxAutovoksal.SelectedItem.ToString()].Draw(gr);
                pictureBoxAutovoksal.Image = bmp;
            }
        }
        private void buttonAddAutovoksal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAutovoksalName.Text))
            {
                MessageBox.Show("Введите название автовокзала", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили автовокзал {textBoxAutovoksalName.Text}");
            autovoksalCollection.AddAutovoksal(textBoxAutovoksalName.Text);
            ReloadLevels();
        }

        private void buttonDeleteAutovoksal_Click_1(object sender, EventArgs e)
        {
            if (listBoxAutovoksal.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить автовокзал {listBoxAutovoksal.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили автовокзал{listBoxAutovoksal.SelectedItem.ToString()}");
                    autovoksalCollection.DelAutovoksal(listBoxAutovoksal.SelectedItem.ToString());
                    ReloadLevels();
                    Draw();
                }
            }
        }

        private void buttonTakeBus_Click_1(object sender, EventArgs e)
        {
            if (listBoxAutovoksal.SelectedIndex > -1 && maskedTextBoxNumber.Text != "")
            {
                try
                {
                    var bus = autovoksalCollection[listBoxAutovoksal.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxNumber.Text);
                    if (bus != null)
                    {
                        FormBus form = new FormBus();
                        form.SetBus(bus);
                        form.ShowDialog();
                        logger.Info($"Изъят автобус {bus} с места{maskedTextBoxNumber.Text}");
                        Draw();
                    }
                }
                catch (AutovoksalNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message} Не найдено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message} Неизвестная ошибка");
                }
            }
        }
    
        private void listBoxAutovoksal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
            logger.Info($"Перешли на автовокзал{ listBoxAutovoksal.SelectedItem.ToString()}");
        }
        private void AddBus(EasyBus bus)
        {
            if (bus != null && listBoxAutovoksal.SelectedIndex > -1)
            {
                try
                {
                    if ((autovoksalCollection[listBoxAutovoksal.SelectedItem.ToString()]) + bus)
                    {
                        Draw();
                        logger.Info($"Добавлен автобус {bus}");
                    }
                    else
                    {
                        MessageBox.Show("Автобус не удалось поставить");
                        logger.Warn($"Автобус не удалось поставить");
                    }
                    Draw();
                }
                catch (AutovoksalOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message} Переполнение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message} Неизвестная ошибка");
                }
            }
        }       

        private void buttonAddBus_Click_1(object sender, EventArgs e)
        {
            var formBusConfig = new FormBusConfig();
            formBusConfig.AddEvent(AddBus);
            formBusConfig.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    autovoksalCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message} Неизвестная ошибка при сохранении");
                }

            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    autovoksalCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (AutovoksalOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message} Занятое место");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message} Неизвестная ошибка при загрузке");
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxAutovoksal.SelectedIndex > -1)
            {
                autovoksalCollection[listBoxAutovoksal.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}

    
