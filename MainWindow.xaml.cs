using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DataGridMasterDetail
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

        void WindowLoaded(object sender, RoutedEventArgs e)
        {
            MyDxGridControl.ItemsSource = Employees;
        }

        List<Employee> employees;
        public List<Employee> Employees
        {
            get
            {
                if (employees == null)
                    PopluateEmployees();
                return employees;

            }
        }

        void PopluateEmployees()
        {
            employees = new List<Employee>();
            employees.Add(new Employee("Bruce", "Cambell", "Sales Manager", "Education includes a BA in psychology from Colorado State University in 1970. He also completed 'The Art of the Cold Call.' Bruce is a member of Toastmasters International."));
            employees[0].Orders.Add(new Order("Suppliers Inc.", DateTime.Now, "TV", 20));
            employees[0].Orders.Add(new Order("Suppliers Inc.", DateTime.Now.AddDays(3), "Projector", 15));
            employees.Add(new Employee("Cindy", "Haneline", "Vice President of Sales", "Cindy received her BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981. She is fluent in French and Italian and reads German. She joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993. Cindy is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association."));
            employees[1].Orders.Add(new Order("Suppliers Inc.", DateTime.Now.AddDays(1), "Blu-Ray Player", 10));
        }
    }
}
