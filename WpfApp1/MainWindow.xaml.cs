using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
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
using Newtonsoft.Json;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Todo> todolist;

        public MainWindow()

        {
            InitializeComponent();
        }

        private async void btnRunQuery_Click(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            var uri = "http://localhost:8080/api/todo";
            var result = await client.GetStringAsync(uri);
            todolist = JsonConvert.DeserializeObject<ObservableCollection<Todo>>(result);
            this.todolistView.ItemsSource = todolist;
        }
    }
}
