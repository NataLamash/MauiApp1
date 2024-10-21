using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private List<Item> items = new List<Item>();

        public MainPage()
        {
            InitializeComponent();
            InitializeData();
            PopulateGrid();
        }

        private void InitializeData()
        {
            items.Add(new Product
            {
                Name = "Milk",
                Price = 20.50m,
                Country = "Ukraine",
                PackagingDate = DateTime.Now.AddDays(-5),
                Description = "Fresh milk",
                ExpiryDate = DateTime.Now.AddMonths(1),
                Quantity = 1,
                UnitOfMeasure = "liter"
            });

            items.Add(new Book
            {
                Name = "C# for Beginners",
                Price = 150m,
                Country = "Ukraine",
                PackagingDate = DateTime.Now.AddDays(-10),
                Description = "Educational book",
                PagesCount = 300,
                Publisher = "XYZ Publisher",
                Authors = new List<string> { "Ivan Ivanov", "Petro Petrenko" }
            });
        }

        private void PopulateGrid()
        {
            ItemsGrid.Children.Clear();  
            ItemsGrid.RowDefinitions.Clear();  

            
            ItemsGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            
            for (int i = 0; i < items.Count; i++)
            {
                
                ItemsGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                Item item = items[i];

                
                var nameLabel = new Label { Text = item.Name };
                Grid.SetRow(nameLabel, i + 1);  
                Grid.SetColumn(nameLabel, 0);   
                ItemsGrid.Children.Add(nameLabel);

                var priceLabel = new Label { Text = item.Price.ToString() };
                Grid.SetRow(priceLabel, i + 1); 
                Grid.SetColumn(priceLabel, 1);  
                ItemsGrid.Children.Add(priceLabel);

                
                var countryLabel = new Label { Text = item.Country };
                Grid.SetRow(countryLabel, i + 1); 
                Grid.SetColumn(countryLabel, 2);  
                ItemsGrid.Children.Add(countryLabel);

                
                var packagingDateLabel = new Label { Text = item.PackagingDate.ToShortDateString() };
                Grid.SetRow(packagingDateLabel, i + 1); 
                Grid.SetColumn(packagingDateLabel, 3);  
                ItemsGrid.Children.Add(packagingDateLabel);

                
                var descriptionLabel = new Label { Text = item.Description };
                Grid.SetRow(descriptionLabel, i + 1); 
                Grid.SetColumn(descriptionLabel, 4);  
                ItemsGrid.Children.Add(descriptionLabel);
            }
        }

        private void OnAddItemClicked(object sender, EventArgs e)
        {
            var newItem = new Product
            {
                Name = "Cheese",
                Price = 80m,
                Country = "Ukraine",
                PackagingDate = DateTime.Now,
                Description = "Hard cheese",
                ExpiryDate = DateTime.Now.AddMonths(3),
                Quantity = 1,
                UnitOfMeasure = "kg"
            };

            items.Add(newItem);
            PopulateGrid();
        }

        private void OnRemoveItemClicked(object sender, EventArgs e)
        {
            if (items.Count > 0)
            {
                items.RemoveAt(items.Count - 1);
                PopulateGrid();
            }
        }
    }
}