using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pls.Async.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoWork();
            MessageBox.Show("Done");
        }

        private static void DoWork()
        {
            Thread.Sleep(10*1000);
        }

        Action action = DoWork;
        private void BtnAsync_Click(object sender, RoutedEventArgs e)
        {
            action.BeginInvoke(EndInvoke, null);
        }

        private void EndInvoke(IAsyncResult ar)
        {
            MessageBox.Show("Done");
            action.EndInvoke(ar);
            //Dispatcher.Invoke()
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Int32 num = 0;
            if (Int32.TryParse(Num.Content.ToString(), out num))
            {
                Num.Content = (num + 1).ToString();
            }
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //await Task.Run(new Action(DoWork));
            try
            {
                //string str = await GetStringAsyncA();
                //Console.WriteLine(str);

                Task<string> t1 = GetStringAsyncA();
                Task<string> t2 = GetStringAsyncA();
                
                string[] strs = await Task.WhenAll(t1, t2);
                foreach (string str in strs)
                {
                    Console.WriteLine(str);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            MessageBox.Show("Done");
        }


        private static string GetString()
        {
            Thread.Sleep(10*1000);
            return "Polaris";
        }

        private Task<String> GetStringAsyncA()
        {
            Task<string> t1 = Task.Run<string>(() => GetString());
            t1.ContinueWith(t => { MessageBox.Show(t.Result); });
            t1.ConfigureAwait(false);//不用同步的UI线程上下文
            return t1;
        }

        #region "Async"
        private Func<string> _delGetString = GetString;
        private IAsyncResult BeginGetString(AsyncCallback callback, object state)
        {
            return _delGetString.BeginInvoke(callback, state);
        }
        private string EndGetString(IAsyncResult ar)
        {
            return _delGetString.EndInvoke(ar);
        }
        #endregion

        public async void GetStringAsyncB()
        {
            string str = await Task.Factory.FromAsync<string>(BeginGetString, EndGetString, null);
            MessageBox.Show(str);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GetStringAsyncB();
        }

        public Task<string> GetStringAsyncC(CancellationTokenSource source)
        {
            return Task.Run<string>(() =>
            {
                string str = GetString();
                if (source.IsCancellationRequested)
                {
                    //source.Token.ThrowIfCancellationRequested();
                    return string.Empty;
                }
                MessageBox.Show(str);
                return str;
            }, source.Token);
        }

        private string GetString(Int32 ntime)
        {
            Thread.Sleep(ntime);
            throw new Exception(ntime.ToString());
        }

        private CancellationTokenSource _source;

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            _source = new CancellationTokenSource();
            Task taskResult = null;
            try
            {
                Task<string> t1 = GetStringAsyncC(_source);
                Task<string> t2 = GetStringAsyncC(_source);

                await (taskResult = Task.WhenAll(t1,t2));
            }
            catch (Exception exception)
            {
                if(taskResult != null)
                {
                    foreach (Exception ex in taskResult.Exception.InnerExceptions)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            _source.Cancel();
        }

        public Task<string> GetStringAsyncD()
        {
            return Task.Run<string>(() =>
            {
                Random rd = new Random();
                string str = GetString(rd.Next(1000));
                return str;
            });
        }

        private async void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Task taskResult = null;
            try
            {
                Task<string> t1 = GetStringAsyncD();
                Task<string> t2 = GetStringAsyncD();

                await (taskResult = Task.WhenAll(t1, t2));
            }
            catch (Exception exception)
            {
                if (taskResult != null)
                {
                    foreach (Exception ex in taskResult.Exception.InnerExceptions)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
