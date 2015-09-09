using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;


namespace InformationalApp.Classes
{
    class TextSearchFilter
    {
       public virtual Predicate<Object> Filter { get; set; }
        public TextSearchFilter(ICollectionView filteredView, TextBox textBox)
        {
            string filterText = "";

           /* filteredView.Filter = delegate(object obj)
            {

                if (string.IsNullOrEmpty(filterText))
                    return true;

                string str = obj as string;

                if (string.IsNullOrEmpty(str))
                    return false;

                int index = str.IndexOf(filterText, 0, StringComparison.CurrentCultureIgnoreCase);

                return index > -1;

            };
            textBox.TextChanged += delegate
            {
                filterText = textBox.Text;
                filteredView.Refresh();
            };**/
        }
    }
}
