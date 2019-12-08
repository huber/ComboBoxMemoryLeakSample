using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;

namespace ComboBoxMemoryLeakSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a new <see cref="TestItem"/> to the combobox
        /// </summary>
        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            var item = new TestItem("Hello World - " + Guid.NewGuid());
            comboBoxLeak.Items.Add(item);
            comboBoxLeak.SelectedItem = item;
            ToogleButtons(true);
        }

        /// <summary>
        /// Removes the item from the combobox and afterwards, retrieves the <see cref="TestItem"/> which should not be
        /// accessible anymore, from an internal data structures (<c>comboBoxLeak.AccessibleObject.ItemAccessibleObjects</c>) which leaks
        /// this item...
        /// </summary>
        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            // Clear Items in the DropDown.
            comboBoxLeak.Items.Clear();

            ToogleButtons(false);

            // Use Reflection to get the private data.
            var list = GetItemAccessibleObjectsProperty(comboBoxLeak.AccessibilityObject);

            FillListBox(list);
        }

        /// <summary>
        /// Sets the visibility of the two buttons
        /// </summary>
        private void ToogleButtons(bool b)
        {
            buttonAddItems.Enabled = !b;
            buttonRemoveItem.Enabled = b;
        }

        /// <summary>
        /// Get the <c>System.Windows.Forms.ComboBox.ComboBoxUiaProvider.ItemAccessibleObjects</c> property"/> of the given
        /// <see cref="AccessibleObject"/> object...
        /// </summary>
        /// <remarks>In case when <param name="accessibleObject"></param> is not of type <c>System.Windows.Forms.ComboBox.ComboBoxUiaProvider.ItemAccessibleObjects</c> property"/>, <c>null</c> will be returned.</remarks>
        /// <param name="accessibleObject"></param>
        /// <returns></returns>
        private IEnumerable GetItemAccessibleObjectsProperty(AccessibleObject accessibleObject)
        {
            return GetProperty(accessibleObject.GetType(), accessibleObject, "ItemAccessibleObjects") as IEnumerable;
        }

        /// <summary>
        /// Helper method to fill list box with the leaked Items
        /// </summary>
        /// <param name="list">Can be null if compiled with .net Framework 4.6 or less</param>
        private void FillListBox(IEnumerable list)
        {
            listBox1.Items.Clear();

            if (list != null)
                foreach (DictionaryEntry item in list)
                    listBox1.Items.Add(item.Key as TestItem);
        }

        /// <summary>
        /// Reflection Helper-Method to get value of non-public property
        /// </summary>
        internal static object GetProperty(Type type, object instance, string propertyName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                                     | BindingFlags.Static;
            var field = type.GetProperty(propertyName, bindFlags);

            return field?.GetValue(instance);
        }
    }
}
