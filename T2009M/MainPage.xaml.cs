using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2009M
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int choosedGender = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Save (object sender, RoutedEventArgs e)
        {
            var rollNumber = txtRollNumber.Text;
            var fullName = txtFullName.Text;
            var email = txtEmail.Text;
            var phone = txtPhone.Text;
            var address = txtAddress.Text;
            var birthday = datepickerBirthday.SelectedDate;
            var gender = choosedGender;
            var student = new Student
            {
                RollNumber = rollNumber,
                FullName = fullName,
                Email = email,
                Phone = phone,
                Address = address,
                Dob = birthday.Value.DateTime,
                Gender = gender
            };
            Debug.WriteLine(student.ToString());
            HandleReset();
        }
        private void HandleReset()
        {
            txtRollNumber.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
        private void Reset(object sender, RoutedEventArgs e)
        {
            HandleReset();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            switch (radioButton.Tag.ToString())
            {
                case "male":
                    choosedGender = 1;
                    break;
                case "fmale":
                    choosedGender = 0;
                    break;
            }
        }
    }
}
