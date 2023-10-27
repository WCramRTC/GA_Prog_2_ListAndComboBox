# GA_Prog_2_ListAndComboBox

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