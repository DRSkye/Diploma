using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ManagedCuda;
using ManagedCuda.BasicTypes;
using ManagedCuda.VectorTypes;
using ManagedCuda.CudaFFT;
using System.Diagnostics;

namespace CourseWork2
{
    public partial class MainWindow : Form
    {
        private Color colorStart, colorFinish; //Ranga of Colors
        private int fileCount = 0; //Count of files
        private string path; //Path to the directory with data
        private List<string> logs = new List<string>();
        private int[] helpMas;
        private float[] buffer;
        const double maxFreq = 10000.0;
        const int bufSize = 4096;
        private int[] numbers;

        public MainWindow()
        {
            InitializeComponent();
            colorStart = Color.FromArgb(0,255,255);
            colorFinish = Color.FromArgb(0,255,0);
        }

        #region buttons

        //Exit
        private void exitButton_Click(object sender, EventArgs e)
        {
            logs.Add("Завершение...");

            var sw = new StreamWriter("Logs.txt");
            foreach (var item in logs)
            {
                sw.WriteLine(item);
            }
            sw.Close();

            Close();
        }

        //Opening a directory with data
        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                logs.Add("Ожидается выбор папки...");
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath;
                    fileCount = Directory.GetFiles(path).Length;
                    depthBoxFinish.Text = Convert.ToString(fileCount);
                    progressBar.Value = 0;
                    progressBar.Maximum = fileCount;
                    spectrGroupBox.Enabled = true;
                    depthGroupBox.Enabled = true;
                    helpMas = null;
                    logs.Add("Папка выбрана: " + path);
                    logs.Add("Файлов в папке: " + fileCount.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии папки!");
            }
        }

        //Choose colors
        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if ((Button)sender == colorButtonStart)
                {
                    logs.Add("Выбор начального цвета...");
                    colorStart = colorDialog.Color;
                    colorBoxStart.BackColor = colorStart;
                    logs.Add("Начальный цвет выбран:" + colorStart.ToString());
                }
                else
                {
                    logs.Add("Выбор конечного цвета...");
                    colorFinish = colorDialog.Color;
                    colorBoxFinish.BackColor = colorFinish;
                    logs.Add("Конечный цвет выбран:" + colorFinish.ToString());
                }
            }
        }

        #endregion buttons

        //Для степени двойки
        private short[] PowOfTwo(short[] soundLine, ref short K)
        {
            logs.Add("Приводим размерность входных данных к степени двойки...");
            int len = soundLine.Length;
            uint pow = 2;
            short k = 1;
            while (len > pow)
            {
                pow *= 2;
                k++;
            }

            K = k;
            if (len == pow)
                return soundLine;
            else
            {
                short[] newMas = new short[pow];
                for (int i = 0; i < pow; i++)
                {
                    if (i < len)
                        newMas[i] = soundLine[i];
                    else
                        newMas[i] = 0;
                }

                logs.Add("Размерность данных приведена к степени двойки! Показатель степени: " + K.ToString());
                return newMas;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = 50000;
            int deviceID = 0;
            CudaContext ctx = new CudaContext(deviceID);
            CudaKernel kernel = ctx.LoadKernel("FFT.ptx", "VecAdd");
            kernel.GridDimensions = (N + 255) / 256;
            kernel.BlockDimensions = 256;

            // Allocate input vectors h_A and h_B in host memory
            float[] h_A = new float[N];
            float[] h_B = new float[N];

            // TODO: Initialize input vectors h_A, h_B
            for(uint i=0;i<N;i++)
            {
                h_A[i] = i;
                h_B[i] = i + 5;
            }

            // Allocate vectors in device memory and copy vectors from host memory to device memory 
            CudaDeviceVariable<float> d_A = h_A;
            CudaDeviceVariable<float> d_B = h_B;
            CudaDeviceVariable<float> d_C = new CudaDeviceVariable<float>(N);

            // Invoke kernel
            
            kernel.Run(d_A.DevicePointer, d_B.DevicePointer, d_C.DevicePointer, N);

            // Copy result from device memory to host memory
            // h_C contains the result in host memory
            float[] h_C = d_C;
        }

        #region change
        //Chenging depth
        private void depth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(depthBoxStart.Text) < 1)
                    depthBoxStart.Text = 1.ToString();
                if (Convert.ToInt32(depthBoxStart.Text) > Int32.MaxValue)
                    depthBoxStart.Text = Int32.MaxValue.ToString();
                if (Convert.ToInt32(depthBoxFinish.Text) < Convert.ToInt32(depthBoxStart.Text))
                    depthBoxFinish.Text = depthBoxStart.Text;
                if (Convert.ToInt32(depthBoxFinish.Text) > Int32.MaxValue) //filecount
                    depthBoxFinish.Text = Int32.MaxValue.ToString();
                logs.Add("Диапозон глубины был изменён на [" + depthBoxStart.Text + ";" + depthBoxFinish.Text + "]");
            }
            catch
            {
                logs.Add("Попытка задать неверные границы глубины!");
                MessageBox.Show("Неправильно задан диапозон глубины!");
            }
        }

        //Chenging frequency
        private void frequency_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(frequencyBoxStart.Text) < 1)
                    frequencyBoxStart.Text = 1.ToString();
                if (Convert.ToInt32(frequencyBoxStart.Text) > Int32.MaxValue)
                    frequencyBoxStart.Text = Int32.MaxValue.ToString();
                if (Convert.ToInt32(frequencyBoxFinish.Text) < Convert.ToInt32(frequencyBoxStart.Text))
                    frequencyBoxFinish.Text = frequencyBoxStart.Text;
                if (Convert.ToInt32(frequencyBoxFinish.Text) > Int32.MaxValue)
                    frequencyBoxFinish.Text = Int32.MaxValue.ToString();
                logs.Add("Диапозон часторы был изменён на [" + frequencyBoxStart.Text + ";" + frequencyBoxFinish.Text + "]");
            }
            catch
            {
                logs.Add("Попытка задать неверные границы частоты!");
                MessageBox.Show("Неправильно задан диапозон Частот!");
            }
        }

        #endregion change

        //About the program
        private void helpButton_Click(object sender, EventArgs e)
        {
            try
            {
                logs.Add("Открываем справку...");
                //HelpForm helpForm = new HelpForm();
                //helpForm.Show(); //Не ShowDialog чтобы не прерывать главный процесс
                logs.Add("Справка закрыта!");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, справка не может быть открыта!");
            }
        }

        //Get colors
        private Color GetColors(double min, double max, double energy)
        {
            if (energy == -1.0)
                return colorStart;
            var dif = max - min;
            dif = energy / dif;
            var col = (int)Math.Round(dif * 256);
            if (col == 256)
                col--;
            if (col == 0)
                col++;
            col = 256 - col;
            if (dif >0.75)
                return Color.FromArgb(0, 256 - col, 0);
            else
                return Color.FromArgb(0, col, 255);
        }

        //Save as img
        private void saveButton_Click(object sender, EventArgs e)
        {
            logs.Add("Начинаем сохранение данных в виде изображения...");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int width, heigth;
            double max = double.MinValue;
            Color color;
            List<string> file = new List<string>();
            string[] str;
            using (StreamReader sr = new StreamReader("OutPut.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                    str = line.Split(' ');
                    for (int i = 0; i < bufSize; i++)
                    {
                        if (Convert.ToDouble(str[i]) > max)
                            max = Convert.ToDouble(str[i]);
                    }
                }
                sr.Dispose();
            }
            heigth = file.Count;
            width = file[0].Split(' ').Length;
            logs.Add(string.Format("Создано изображение размером {0}x{1}", width, heigth));
            Bitmap bmp = new Bitmap(width, heigth);

            for (int y = 0; y < file.Count; y++)
            {
                str = file[y].Split(' ');
                for (int x = 0; x < bufSize; x++)
                {
                    color = GetColors(0, max, Convert.ToDouble(str[x]));
                    bmp.SetPixel(x, y, color);
                }
            }
            logs.Add("Изображение готово!");

            logs.Add("Сохранение изображения...");
            imgBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bmp.Save("Pic.png");
            imgBox.Image = Image.FromFile("Pic.png");
            bmp.Dispose();
            watch.Stop();
            logs.Add("Изображение сохранено!");
            logs.Add(string.Format("Визуализация изображения разрешения {0}х{1} заняла: {2}", width, heigth, watch.Elapsed));
            logs.Add("");
        }

        //Get helpMas
        private void GetHelpMas(int pow)
        {
            logs.Add("Начинаем вычислять вспомогательный массив...");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            char c;
            string str;
            char[] s;
            int help;
            for (int i=0;i<helpMas.Length;i++)
            {
                if (helpMas[i] != 0)
                    continue;
                str = Convert.ToString(i, 2);
                while(str.Length != pow)
                {
                    str = '0' + str;
                }
                s = str.ToCharArray();
                for(int j =0;j<pow/2;j++)
                {
                    c = s[j];
                    s[j] = s[pow - j - 1];
                    s[pow - j - 1] = c;
                }
                str = "";
                foreach(var d in s)
                {
                    str += d;
                }
                help = Convert.ToInt32(str, 2);
                helpMas[i] = help;
                helpMas[help] = i;
            }
            watch.Stop();
            logs.Add("Вспомогательный массив посчитан! Времени заняло: " + watch.Elapsed.ToString());
        }

        //Get newMasData
        private short[] GetNew(short[] mas)
        {
            short c;
            bool[] help = new bool[helpMas.Length];
            for (int i=0;i<helpMas.Length;i++)
            {
                if (help[i] == true)
                    continue;
                c = mas[i];
                mas[i] = mas[helpMas[i]];
                mas[helpMas[i]] = c;
                help[i] = true;
                help[helpMas[i]] = true;
            }

            return mas;
        }

        //Get new Index
        private int GetIndex(int index, int nfft)
        {
            if (index == 0)
                return -1;
            double idx = Math.Log((double)index * maxFreq / (double)(nfft - 0)) * bufSize / Math.Log(maxFreq);
            if (idx < 0.0)
                return -1;
            return (int)Math.Floor(idx);
        }

        //Get new Index
        private int GetIndexLin(int index, int nfft)
        {
            return (int)Math.Floor((double)index * bufSize / nfft);
        }

        //Start
        private void startButton_Click(object sender, EventArgs e)
        {
            logs.Add("Начинаем вычисления...");
            Stopwatch timer = new Stopwatch();
            Stopwatch watch = new Stopwatch();
            Stopwatch stopwatch = new Stopwatch();
            timer.Start();
            startTime.Text = DateTime.Now.ToString();

            logs.Add("Получаем список файлов...");
            string[] fileList;
            fileList = Directory.GetFiles(path);
            int startDepth = Int32.Parse(depthBoxStart.Text);
            int finishDepth = Int32.Parse(depthBoxFinish.Text);
            progressBar.Maximum = finishDepth - startDepth + 1;
            byte[] byteMas;
            short[] soundLine;
            byte[] b = new byte[2];
            short K = 0; //Показатель степени
            byte deviceID = 0;
            cuFloatComplex[] h_data;
            CudaDeviceVariable<cuFloatComplex> d_data;
            cuFloatComplex[] h_answer;
            int index;
            StreamWriter sw;
            int nfft;

            progressBar.Value = 0;
            for (int i = 1; i <= fileCount; i++)
            {
                if (i < startDepth || i > finishDepth)
                    continue;

                stopwatch.Start();
                logs.Add("Читаем данные из " + i.ToString() + " файла...");
                byteMas = File.ReadAllBytes(fileList[i-1]);
                soundLine = new short[byteMas.Length / 2];
                for (int j = 0; j < byteMas.Length; j += 2)
                {
                    b[0] = byteMas[j];
                    b[1] = byteMas[j + 1];
                    soundLine[j / 2] = BitConverter.ToInt16(b, 0);
                }
                logs.Add("Данные считаны!");
                soundLine = (short[])PowOfTwo(soundLine, ref K).Clone();

                //if (helpMas == null)
                //{
                //    helpMas = new int[soundLine.Length];
                //    GetHelpMas(K);
                //}

                //Сборщик мусора
                byteMas = null; //Удаляем ссылку
                GC.Collect(); //Запуск сборщика мусора; Мусор- это всё, на что не указывает ссылка

                CudaContext ctx = new CudaContext(deviceID, CUCtxFlags.MapHost | CUCtxFlags.BlockingSync);
                h_data = new cuFloatComplex[soundLine.Length];
                for (int j = 0; j < soundLine.Length; j++)
                {
                    h_data[j].real = (float)Convert.ToDouble(soundLine[j]);
                    h_data[j].imag = 0;
                }
                d_data = new CudaDeviceVariable<cuFloatComplex>(soundLine.Length);
                d_data.CopyToDevice(h_data);
                CudaFFTPlan1D plan = new CudaFFTPlan1D( d_data.Size, cufftType.C2C, 1);
                watch.Start();
                plan.Exec(d_data.DevicePointer, TransformDirection.Forward);
                watch.Stop();
                h_answer = d_data;
                logs.Add("Вычисления на GPU закончены!");
                logs.Add("Вычисление " + i.ToString() + " дорожки на GPU заняло: " + watch.Elapsed.ToString());

                nfft = h_answer.Length / 2 + 1;
                buffer = new float[bufSize];
                numbers = new int[bufSize];

                int count = 0;
                for (int j=0;j< nfft; j++) //до nfft
                {
                    index = GetIndex(j, nfft); //nfft
                    if (index < 0)
                        count++;
                    if (index >= 0)
                    {
                        buffer[index] += (float)Math.Sqrt(Math.Pow(h_answer[j].real /(double)nfft, 2) + Math.Pow(h_answer[i].imag / (double)nfft, 2));
                        numbers[index]++;
                    }
                }
                for (int j = 0; j < bufSize; j++)
                {
                    if (buffer[j] > 0)
                    {
                        buffer[j] /= (float)numbers[j];
                    }
                    else
                        buffer[j] = -1.0f;
                }

                sw = new StreamWriter("OutPut.txt", true);
                foreach(var item in buffer)
                {
                    sw.Write(item + " ");
                }
                sw.WriteLine();
                sw.Close();

                buffer = null;
                numbers = null;
                h_data = null;
                d_data.Dispose();
                plan.Dispose();
                h_answer = null;
                CudaContext.ProfilerStop();
                ctx.Dispose();
                soundLine = null;
                GC.Collect();

                progressBar.Value++;
                stopwatch.Stop();
                logs.Add(string.Format("Вычисление {0} дорожки заняло: {1}", i, stopwatch.Elapsed));
                logs.Add("");
            }

            GC.Collect();
            finishTime.Text = DateTime.Now.ToString();
            timer.Stop();
            logs.Add("Все вычисления закончены!");
            logs.Add("Вычисления заняли: " + timer.Elapsed.ToString());
            logs.Add("");
        }

        #region logs

        //Clear logs
        private void clearButton_Click(object sender, EventArgs e)
        {
            logs.Clear();
        }

        //Open logs
        private void openLogs_Click(object sender, EventArgs e)
        {
            LogsWindow logsWindow = new LogsWindow(logs);
            logsWindow.ShowDialog();
        }

        #endregion logs
    }
}
