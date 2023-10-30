# GA_Prog_2_ListAndComboBox

## Controls

ListBoxes and ComboBoxes are the controls you run into when you have either a drop down box, or a list box where you can select 1 ( or multiple ) options.

They are useful for listing options to the user, and then using properties like `selectedIndex` and `selectedItem` to interact with the users choice from our List.

The list box and combo box both work exactly alike ( except you can't select more than one choice with the combo box ). When we talk about properties and things like `.ItemsSource` we are referring to both of them at the same time.


> [WPF-Tutorial - ListBox](https://wpf-tutorial.com/list-controls/listbox-control/)  
> [WPF-Tutorial - ComboBox](https://wpf-tutorial.com/list-controls/combobox-control/) 

> ***ListBox and ComboBox controls are near identical. So what works for 1 should work for the other. Including properties.***

***Designer***
```
<ListBox x:Name="lbListBox" />
<ComboBox x:Name="cmbBoxName" />
```

***Code***
```
I'm going to just used the term box to refer to both combo and list box.

Connect a list : box.ItemsSource = list;
Get Selected Index : int index = box.SelectedIndex;
Get Selected Item : object item = box.SelectedItem;
```
---
> **Part 1** - Add a Combo Box, Create a Global List, Attach it to your Combo Box
>
> 1. Create a new wpf project, name it GA_YourName_ListAndComboBox 
> 2. `Designer: ` - 
* Add a combo box (Name = `cmbFirstName).
> 3. `Code: ` - Create a global list with at least 5 first names.
> 4. Attach the list of first names to your combo box using `.ItemsSource`.
> 5. Run your code
>
> ***Result: When you run your application, you should see the names appear in your combo box when you click on it.***  

> --- 
> **Part 2** - Add a List Box, Create a 2nd Global List, Attach it to your List Box 
> `listBoxName.ItemsSource = list;`
> 1. `Designer: `
* Add a list box (Name = `lbLastNames).
> 2. `Code: ` - Create a seperate global list with at least 5 last names.
> 3. Attach the list of first names to your list box using `.ItemsSource`.
> 4. Run your code
>
> ***Result: When you run your application, you should see your List Box filled with the Last Names.***  

> --- 
> **Part 3** - Add A Button, Display Names Using the Selected Index and a MessageBox  
> `int selectedIndex = box.SelectedIndex;`
>
> 1. `Designer: ` - 
* Add a button ( Content = "Display Full Name" ), add a click event.
> 2. `Code: ` - In your click event, use the `selectedIndex` from both Boxes, and your lists, and display the Full Name in a message box.
> Ex `string firstName = firstNameList[index]`;
>
> ***Result: If two names are selected, one in each box, when you click the button a Message box with the full name should appear.***  

> --- 
> **Part 4** - Add two labels and Text Boxes, Add the names to the correct lists, refresh your Combo And List Boxes to see the new names
> `box.Items.Refresh()`
>
> 1. `Designer: `

* Add 2 Labels ( Content : "First Name" and "Last Name" ).
* Add 2 Text Boxes ( One for a first name, one for a last name. Give them names ).
* Add a button ( Content = "Add Student" ), add a click event.
 
> 2. `Code: ` - In your click event, get the first and last name the user entered. Add them to the correct lists.
> 3. In the same click even `Refresh` both list and combo box.
> 4. Run
>
> ***Result: If done properly, you should be able to enter a new first and last name. When the button is clicked, you will see those names added to the end of your combo and list box.*** 

> --- 
> **Part 5** - Add a button. On Click should remove the selected students First And Last name from the Lists, and refresh the Boxes
> `list.RemoveAt(index)`
>
> 1. `Designer: `

* Add 1 Button ( Content = "Remove student", every button should have a name )
 
> 2. `Code: ` - In your click event, get the selected index of the box with the first name.
> 3. Use that selected index to remove the first AND last names from their list.
> 4. Refresh the Boxes
> 5. Run
>
> ***Result: If done properly, when you selected a first name and click "Remove Student" then the first name and last name should disappear from the Boxes.*** 

> --- 
> **Part 6** - Add a `OnSelectedIndex_Change` event to your list box. When a last name is selected, the first name in the Combo Box is automatically highlighted.  
> `cmbFirstName.SelectedIndex = index`
> 1. `Designer: `

* ***DOUBLE CLICK ON YOUR LIST BOX*** This should create a new event ( like with your buttons, but this responds to when you select a different object in the box.
 
> 2. `Code: ` - In your event, get the selected index of your ListBox, and then ASSIGN the value to the Selected Index of your Combo Box.
> Ex. `cmb.SelectedIndex = lb.SelectedIndex`
> 3. Run
>
> ***Result: When you click on a last Name in your List Box, the first Name assoicated in the Combo Box should automatically be selected. This is because if the lists are setup properly and have the same amount of values, the selected index should relate the first and last name.*** 

> ---
> **Submission : Submit your GitHub Repo URL**
---

## Step By Step

1. Create a new WPF project in Visual Studio: Name it "GA_YourName_ListAndComboBox".

### Part 1 - Add a Combo Box, Create a Global List, Attach it to your Combo Box


2. Add
* Combo Box ( Name = "`cmbFirstName`" )

`Designer`
```xml
	<ComboBox x:Name="cmbFirstName" />
```

3. Declare and Initialize a Global List of strings with a name of `firstNames`. 
4. Populate it with at least 5 first names.
5. Inside of your `MainWindow()` method, attach your list to your combo boxes `.ItemsSource`.
    * `cmbFirstName.ItemsSource = firstNames;`

> There are multiple ways to work with a list / combo box. You can manually add items to the list one by one to an internal list. But we use what's known as the `.ItemsSource`. This alows us to assign a list to the combo/list box and it will automatically populate it.


`Code`
```csharp
public partial class MainWindow : Window
{
    List<string> firstNames = new List<string> { "John", "Jane", "Doe", "Mary", "Bob" };

    public MainWindow()
    {
        InitializeComponent();
        cmbFirstName.ItemsSource = firstNames; // Assign our list to the combo box
    }
}
```

***Result***

When you run your application, you should see your combo box populated with the list of first names.

---

### Part 2 - Add a List Box, Create a 2nd Global List, Attach it to your List Box 

1. Add
* ListBox ( Name = "`lbLastNames`" )

`Designer`
```xml
    <ListBox x:Name="lbLastNames" />
```

2. Create another global list with the name `lastNames`.

`Code`
```csharp
    List<string> lastNames = new List<string> { "Smith", "Doe", "Johnson", "Taylor", "Brown" };
```

3. Set the ItemsSource of the List Box: In the constructor of MainWindow, set the ItemsSource of the list box.

`Code`
```csharp
    lbLastNames.ItemsSource = lastNames;
```

***Result***

When you run your code, you should now see your list of last names in the list box.

### Part 3 - Add A Button, Display Names Using the Selected Index and a MessageBox  

1. Add
    * Button ( Name="btnDisplayFullName", Content = "Display Full Name" ), add click event

```xml
<Button Content="Display Full Name" Name="btnDisplayFullName" Click="btnDisplayFullName_Click"/>
```

2. Using the `.SelectedIndex` of our combo / list boxes, we can return the associated index for our two lists.
    * `int firstNameIndex = cbFirstNames.SelectedIndex`
    * `int lastNameIndex = lblastNames.SelectedIndex`

3. Using the 2 indexs, you can access their related element from our names lists.
    * `string firstName = firstNames[firstNameIndex];`
    * `string lastName = lastNames[lastNameIndex];`

4. You can then concatenate the first an last names together and display them in a `MessageBox`.
    *  `string fullName = firstName + " " + lastName;`
    *  `MessageBox.Show(fullName); // Display Full Name`

```csharp
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

```

***Result***

When the application is running pick 1 name from the first name box, and 1 name from the last name box. When you click the button a message box should appear, displaying the two names as a single name.

---

### Part 4 - Add two labels and Text Boxes, Add the names to the correct lists, refresh your Combo And List Boxes to see the new names

1. Add Controls
* Label ( Content = "`First Name`" )
* Label ( Content = "`Last Name`" )
* TextBox ( Name="`txtFirstName`")
* TextBox ( Name="`txtLastName`")
* Button ( Name="`btnAddNames`", Content = "`Add Names`" ), and add a click event.

`Designer`
```xml
    <Label Content="First Name" />
    <Label Content="Last Name" />
    <TextBox x:Name="txtFirstName" />
    <TextBox x:Name="txtLastName" />
     <Button x:Name="btnAddNames" Content="Add Names" Click="btnAddNames_Click"/>
```


2. In your click event
    1. Get the first and last name from our 2 text boxes.
    2. Add those names to the correct lists.
    3. Using the `.Items.Refresh()` method on the list and combo box, refresh the combo boxes.

> When the Combo and List Boxes are connected to a `List` and an `.ItemsSource` the boxes don't refresh automtically. That's why we call `box.Items.Refresh()`. Each box contains it's only list of objects, being populated by the `List` we created. When we add or remove something from them it doesn't show up. But when we say `.Items.Refresh()` it will refresh based on it's `.ItemsSource`.

```csharp
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
```

***Result***  
Enter a first name and a last name, then click the "Add Student" button. The new names should appear in the combo box and list box.

---

### Part 5 - Add a button. On Click should remove the selected students First And Last name from the Lists, and refresh the Boxes

1. Add contol
    * Button ( x:Name="`btnRemoveStudentAtIndex`", Content="`Remove Students At Index`" ), and add an event.

`Designer`
```xml
<Button x:Name="btnRemoveStudentAtIndex" Content="Remove Students At Index" Click="btnRemoveStudentAtIndex_Click"/>
```

2. In the click event
    1. Grab the selected indexs from the combo box, for the first name, and the list box, for the last name.
    * `int firstNameIndex = cbFirstNames.SelectedIndex;`
    * `int lastNameIndex = lbLastNames.SelectedIndex;`
      
    2. Using the `.RemoveAt(index)` method, remove the selected elements from our lists.
    * `firstNames.RemoveAt(firstNameIndex); // Removing first name`
    * `lastNames.RemoveAt(lastNameIndex); // Removing last name`

    3. Finally, Refresh your list and combo boxes.
    * `cbFirstNames.Items.Refresh();`
    * `lbLastNames.Items.Refresh();`

`Code`
```csharp
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
```

***Result***  
Select a student and click "Remove Student". The selected student should be removed from both the combo box and list box.


### Part 6  - Add a `OnSelectedIndex_Change` event to your list box. When a last name is selected, the first name in the Combo Box is automatically highlighted. 

1. Add a ***New Event*** to an already existing control.
    1. Double click on the `lbLastNames` list box.
    2. This should create a ***New Event***, the `SelectionChanged` event. This even triggers everytime someone chooses a different option on the appropriate list or combo box.

`Designer`
```xml
<ListBox x:Name="lbLastNames" SelectionChanged="lbLastNames_SelectionChanged"/>
```

2. In the new `lbLastNames_SelectionChanged` event
    1. We are going to pull the selected index from our list box and **Assign** it to our combo box. When you assign a value to the `.SelectedIndex` of a control, it automatically highlights in on our Gui. 
    * `cmbFirstName.SelectedIndex = lbLastNames.SelectedIndex;`

```csharp
private void OnLastNameSelected(object sender, SelectionChangedEventArgs e)
{
    cmbFirstName.SelectedIndex = lbLastNames.SelectedIndex;
}

```

***Result***   
Select a last name in the list box, and the corresponding first name (by Index) should automatically be selected in the combo box

---

### Submission
Submit your GitHub repository URL