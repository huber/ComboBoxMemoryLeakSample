.Net Framework 4.8 Windows Forms ComboBox MemoryLeak
====================================================

The .NET Framework 4.7 and 4.8 introduces new features for accessibility. 
Apparently a memory leak has crept in. 
If level 3 of the accessibility features is active, the concrete subclass of System.Windows.Forms.AccessibilityObject contains a dictionary in which all items that have ever been assigned to the ComboBox. Unfortunately this dictionary will not be updated if the items are removed from the ComboBox. 

The project was created with .NET Framework. The error can be easily traced by pressing the first button "Add Items" and then the second button "Remove Items". The ListBox will be filled with the items which have been removed before. The process can be repeated several times, you can see that the ListBox is constantly growing. 

If you change the project to .NET Framework 4.6, the problem does not exist, because in this case an implementation of AccessibilityObject is used which does not have this dictionary at all. 