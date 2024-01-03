using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadEventApp
{
    public partial class Form1 : Form
    {
       
        private readonly string numbersFilePath = "numbers.txt";
        private readonly string sumFilePath = "sums.txt";
        private readonly string productFilePath = "products.txt";

        private TaskCompletionSource<bool> generationTaskCompletionSource;
        private TaskCompletionSource<bool> sumTaskCompletionSource;
        private TaskCompletionSource<bool> productTaskCompletionSource;

        public Form1()
        {
            InitializeComponent();
        }

        private async Task GenerateNumbers()
        {
            
                using (StreamWriter file = new StreamWriter(numbersFilePath))
                {
                    Random random = new Random();
                    for (int i = 0; i < 10; i++) // Генерируем 10 пар чисел
                    {
                        int num1 = random.Next(1, 11);
                        int num2 = random.Next(1, 11);
                        await file.WriteLineAsync($"{num1} {num2}");
                       
                    }
                }

            generationTaskCompletionSource.TrySetResult(true); 
           
        }

        private async Task CalculateSum()
        {
           await generationTaskCompletionSource.Task;
            
                using (StreamReader file = new StreamReader(numbersFilePath))
                using (StreamWriter sumFile = new StreamWriter(sumFilePath))
                {
                    string line;
                    while ((line = await file.ReadLineAsync()) != null)
                    {
                        string[] numbers = line.Split(' ');
                        int num1 = int.Parse(numbers[0]);
                        int num2 = int.Parse(numbers[1]);
                        
                       await sumFile.WriteLineAsync($"{num1+num2}");
                      
                    }
                }

            sumTaskCompletionSource.TrySetResult(true);

        }

        private async Task CalculateProduct()
        {
            await sumTaskCompletionSource.Task;
                using (StreamReader file = new StreamReader(numbersFilePath))
                using (StreamWriter productFile = new StreamWriter(productFilePath))
                {
                    string line;
                    while ((line = await file.ReadLineAsync()) != null)
                    {
                        string[] numbers = line.Split(' ');
                        int num1 = int.Parse(numbers[0]);
                        int num2 = int.Parse(numbers[1]);
                        await  productFile.WriteLineAsync($"{num1 * num2}");
                       
                    }
                }

            productTaskCompletionSource.TrySetResult(true);


        }

        private async void  btnStart_Click_1(object sender, EventArgs e)
        {
            generationTaskCompletionSource = new TaskCompletionSource<bool>();
            sumTaskCompletionSource = new TaskCompletionSource<bool>();
            productTaskCompletionSource = new TaskCompletionSource<bool>();

            Task generateTask = GenerateNumbers();
          
            Task sumTask = CalculateSum();
           
            Task productTask = CalculateProduct();

            await generateTask;
            await sumTask;
            await productTask;

            UpdateUIAfterCompletion();
        }
       private void UpdateUIAfterCompletion()
        {
            if(InvokeRequired)
            {
                this.Invoke(new Action(UpdateUIAfterCompletion));
                return;
                   
            }

            txtNumbersResult.Text = File.ReadAllText(numbersFilePath);
            
            txtSumResult.Text = File.ReadAllText(sumFilePath);
           
            txtProductResult.Text = File.ReadAllText(productFilePath);
            MessageBox.Show("Операции завершены");
                         
            
        }
          
    }
}
