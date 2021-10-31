using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T2009M.Entity;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2009M
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListViewDemo : Page
    {
        public ListViewDemo()
        {
            this.InitializeComponent();
            List<Student> listString = new List<Student>();
            Student student = new Student
            {
                RollNumber = "A001",
                FullName = "Nguyen Van A"
            };
            listString.Add(student);
            student = new Student
            {
                RollNumber = "A002",
                FullName = "Nguyen Van A"
            };
            listString.Add(student);
            student = new Student
            {
                RollNumber = "A003",
                FullName = "Nguyen Van A"
            };
            listString.Add(student);
            student = new Student
            {
                RollNumber = "A004",
                FullName = "Nguyen Van A"
            };
            listString.Add(student);
            listName.ItemsSource = listString;
        }
    }
}
