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

namespace GA_Prog_2_ListAndComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Part 1 and 2 - Global Lists
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
            Preload(); // Calling preload to load list

            // Part 1 and 2 - Attaching Lists to Combo and List Box
            cbFirstNames.ItemsSource = firstNames; // First name list added to combo box
            lbLastNames.ItemsSource = lastNames; // Last name list added to list box


        } // MainWindow()

        // Preload - used to keep code organized
        public void Preload()
        {
            firstNames.Add("Tony");
            firstNames.Add("Steve");
            firstNames.Add("Bruce");
            firstNames.Add("Natasha");
            firstNames.Add("Wanda");

            lastNames.Add("Stark");
            lastNames.Add("Rogers");
            lastNames.Add("Banner");
            lastNames.Add("Romanoff");
            lastNames.Add("Maximoff");
        } // Preload

        // Part 3
        // Click Event : Display Full Name
        private void btnDisplayFullName_Click(object sender, RoutedEventArgs e)
        {
            // Getting selected index from combo box
            int firstNameIndex = cbFirstNames.SelectedIndex;
            // Getting selected index from list box
            int lastNameIndex = lbLastNames.SelectedIndex;

            // Using the index to get the first name from the list
            string firstName = firstNames[firstNameIndex];
            // Using the index to get the last name from the list
            string lastName = lastNames[lastNameIndex];

            // Concatenating a full name
            string fullName = firstName + " " + lastName;

            MessageBox.Show(fullName); // Display Full Name

        } // btnDisplayFullName_Click

        // Part 4
        // Click Event : Add names to each list, refresh list

        private void btnAddNames_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text; // Users first name input

            string lastName = txtLastName.Text; // Users last name input

            firstNames.Add(firstName); // Adding first name to first name list
            lastNames.Add(lastName); // Adding last name to last name list

            // Refresh each of the Boxes to show the newly added names to the list

            cbFirstNames.Items.Refresh();
            lbLastNames.Items.Refresh();

        } // btnAddNames_Click

        // Part 5
        // Click Event : Remove Student at Index

        private void btnRemoveStudentAtIndex_Click(object sender, RoutedEventArgs e)
        {
            // Getting selected index from combo box
            int firstNameIndex = cbFirstNames.SelectedIndex;
            // Getting selected index from list box
            int lastNameIndex = lbLastNames.SelectedIndex;

            firstNames.RemoveAt(firstNameIndex); // Removing first name
            lastNames.RemoveAt(lastNameIndex); // Removing last name


            // Refresh each of the Boxes to show the newly added names to the list

            cbFirstNames.Items.Refresh();
            lbLastNames.Items.Refresh();

        } // btnRemoveStudentAtIndex_Click

        private void lbLastNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int lbSelectedIndex = lbLastNames.SelectedIndex;

            // Assigning the index to the combo boxes selected value
            // This will automatically select the item in the combo box
            cbFirstNames.SelectedIndex = lbSelectedIndex;


        } // lbLastNames_SelectionChanged
    } // class

} // namespace
