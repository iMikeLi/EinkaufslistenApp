using System;
using System.Collections.ObjectModel; // Wichtig für ObservableCollection!
using EinkaufslistenApp.Models;
using Microsoft.Maui.Controls;

namespace EinkaufslistenApp
{
    public partial class CreateShoppingListPage : ContentPage
    {
        // Hier speichern wir alle Einkaufslisten
        private ObservableCollection<ShoppingList> shoppingLists = new ObservableCollection<ShoppingList>();

        public CreateShoppingListPage()
        {
            InitializeComponent();

            // Die Liste mit der Benutzeroberfläche verbinden
            ShoppingListsView.ItemsSource = shoppingLists;
        }

        private void OnCreateShoppingListClicked(object sender, EventArgs e)
        {
            var newList = new ShoppingList
            {
                Name = "Neue Einkaufsliste",
                CreatedAt = DateTime.Now
            };

            shoppingLists.Insert(0, newList);
        }


        private void OnDeleteShoppingListClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is ShoppingList list)
            {
                shoppingLists.Remove(list);
            }
        }

    }
}
