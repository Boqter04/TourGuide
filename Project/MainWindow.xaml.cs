using Project.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using Microsoft.Win32;

namespace Project
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Region> Regions;
        private int CurrentPhotoIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Regions = new ObservableCollection<Region>
            {
                new Region
                {
                    Name = "Europe",
                    TouristPoints = new ObservableCollection<TouristPoint>
                    {
                        new TouristPoint
                        {
                            PhotoPaths = new ObservableCollection<string>
                            {
                                "Images/Paris1.jpg",
                                "Images/Paris2.jpg",
                                "Images/Paris3.jpg"
                            },
                            Name = "Eiffel Tower",
                            Description = "Iconic landmark in Paris.",
                            InterestingFacts = "It was the tallest structure in the world until 1930.",
                            LocalCuisine = "French cuisine.",
                            Currency = "Euro",
                            Timezone = "CET",
                            Weather = "Mild",
                            PlacesOfInterest = "Louvre Museum, Notre-Dame",
                            Dangers = "Pickpocketing",
                            Prices = "Accommodation: €100-200/night, Meals: €10-50"
                        },
                        new TouristPoint
{
                            PhotoPaths = new ObservableCollection<string>
                            {
                                "Images/Rome1.jpg",
                                "Images/Rome2.jpg",
                                "Images/Rome3.jpg",
                            },
                            Name = "Colosseum",
                            Description = "Ancient amphitheater in Rome.",
                            InterestingFacts = "The Colosseum could hold up to 80,000 spectators.",
                            LocalCuisine = "Italian cuisine.",
                            Currency = "Euro",
                            Timezone = "CET",
                            Weather = "Mediterranean",
                            PlacesOfInterest = "Vatican City, Trevi Fountain",
                            Dangers = "Tourist scams",
                            Prices = "Accommodation: €80-150/night, Meals: €8-40"
                        },
                        new TouristPoint
{
                            PhotoPaths = new ObservableCollection<string>
                            {
                                "Images/Alps1.jpg",
                                "Images/Alps2.jpg",
                                "Images/Alps3.jpg",
                            },
                            Name = "Swiss Alps",
                            Description = "Stunning mountain range in Switzerland.",
                            InterestingFacts = "The Swiss Alps cover about 60% of Switzerland's total land area.",
                            LocalCuisine = "Swiss cuisine, including fondue and raclette.",
                            Currency = "Swiss Franc (CHF)",
                            Timezone = "CET",
                            Weather = "Alpine climate",
                            PlacesOfInterest = "Matterhorn, Jungfraujoch, Lake Geneva",
                            Dangers = "Avalanches, unpredictable weather",
                            Prices = "Accommodation: CHF 150-300/night, Meals: CHF 20-70"
                        },
                        new TouristPoint
{
                            PhotoPaths = new ObservableCollection<string>
                            {                    
                                "Images/Svalbard2.jpg",
                                "Images/Svalbard3.jpg"
                            },
                            Name = "Svalbard",
                            Description = "Remote archipelago in the Arctic Ocean.",
                            InterestingFacts = "Svalbard is home to more polar bears than people.",
                            LocalCuisine = "Norwegian cuisine with a focus on local Arctic ingredients.",
                            Currency = "Norwegian Krone (NOK)",
                            Timezone = "CET",
                            Weather = "Polar climate",
                            PlacesOfInterest = "Longyearbyen, Nordenskiöld Glacier, Svalbard Global Seed Vault",
                            Dangers = "Extreme cold, polar bears",
                            Prices = "Accommodation: NOK 1000-2000/night, Meals: NOK 150-400"
                        },
                        new TouristPoint
{
                            PhotoPaths = new ObservableCollection<string>
                            {
                                "Images/Tromso1.jpg",
                                "Images/Tromso2.png",                               
                            },
                            Name = "Tromsø",
                            Description = "A city in northern Norway, known as the gateway to the Arctic.",
                            InterestingFacts = "Tromsø is one of the best places in the world to see the Northern Lights.",
                            LocalCuisine = "Norwegian cuisine with a focus on seafood, reindeer, and Arctic char.",
                            Currency = "Norwegian Krone (NOK)",
                            Timezone = "CET",
                            Weather = "Subarctic climate",
                            PlacesOfInterest = "Arctic Cathedral, Polaria, Fjellheisen Cable Car",
                            Dangers = "Extreme winter conditions, icy roads",
                            Prices = "Accommodation: NOK 800-1800/night, Meals: NOK 120-350"
                        }
                    }
                },
                new Region
                {
                    Name = "Asia",
                    TouristPoints = new ObservableCollection<TouristPoint>
                    {
                        new TouristPoint
                        {
                            PhotoPaths = new ObservableCollection<string>
                            {
                                "Images/GWC4.jpg",
                                "Images/GWC2.jpg",
                                "Images/GWC3.jpg"
                            },
                            Name = "Great Wall of China",
                            Description = "Historic fortification in China.",
                            InterestingFacts = "It is over 13,000 miles long.",
                            LocalCuisine = "Chinese cuisine.",
                            Currency = "Renminbi",
                            Timezone = "CST",
                            Weather = "Varies by region",
                            PlacesOfInterest = "Beijing, Forbidden City",
                            Dangers = "Tourist scams",
                            Prices = "Accommodation: ¥200-500/night, Meals: ¥50-200"
                        },
                        new TouristPoint
                        {
                            PhotoPaths = new ObservableCollection<string>
                            {
                                "Images/AngkorWat1.png",                              
                                "Images/AngkorWat4.jpeg", 
                            },
                            Name = "Angkor Wat",
                            Description = "A vast temple complex in Cambodia, and the largest religious monument in the world.",
                            InterestingFacts = "Originally built as a Hindu temple, it later became a Buddhist site.",
                            LocalCuisine = "Khmer cuisine.",
                            Currency = "Cambodian Riel (KHR)",
                            Timezone = "ICT (Indochina Time)",
                            Weather = "Tropical, hot and humid, with a distinct wet and dry season.",
                            PlacesOfInterest = "Siem Reap, Angkor Thom, Bayon Temple, Ta Prohm",
                            Dangers = "Heat exhaustion, dehydration, and tourist scams.",
                            Prices = "Accommodation: $20-100/night, Meals: $5-20"
                        },
                        new TouristPoint
                        {
                            PhotoPaths = new ObservableCollection<string>
                            {
                                "Images/Tokyo1.jpg",
                                "Images/Tokyo2.jpg",
                                "Images/Tokyo3.jpg",
                            },
                            Name = "Tokyo",
                            Description = "The bustling capital city of Japan, known for its mix of traditional and modern attractions.",
                            InterestingFacts = "Tokyo is the most populous metropolitan area in the world.",
                            LocalCuisine = "Japanese cuisine, including sushi, ramen, and tempura.",
                            Currency = "Japanese Yen (JPY)",
                            Timezone = "JST (Japan Standard Time)",
                            Weather = "Temperate climate with hot summers and mild winters.",
                            PlacesOfInterest = "Shibuya Crossing, Tokyo Tower, Senso-ji Temple, Akihabara, Shinjuku Gyoen",
                            Dangers = "Earthquakes, pickpocketing in crowded areas.",
                            Prices = "Accommodation: ¥5,000-30,000/night, Meals: ¥1,000-5,000"
                        },
                        new TouristPoint
                        {
                            PhotoPaths = new ObservableCollection<string>
                            {
                                "Images/Bali1.jpg",
                                "Images/Bali2.jpg",
                                "Images/Bali3.png",
                            },
                            Name = "Bali",
                            Description = "A beautiful island in Indonesia known for its stunning beaches, vibrant culture, and scenic rice terraces.",
                            InterestingFacts = "Bali is often called the 'Island of the Gods' due to its rich religious and cultural heritage.",
                            LocalCuisine = "Balinese cuisine, including nasi goreng, satay, and babi guling.",
                            Currency = "Indonesian Rupiah (IDR)",
                            Timezone = "WITA (Central Indonesia Time)",
                            Weather = "Tropical climate with a distinct dry and wet season.",
                            PlacesOfInterest = "Ubud, Kuta Beach, Tanah Lot Temple, Uluwatu, Mount Batur",
                            Dangers = "Strong ocean currents, petty theft, and occasional volcanic activity.",
                            Prices = "Accommodation: IDR 500,000-2,000,000/night, Meals: IDR 50,000-200,000"
                        },
                        new TouristPoint
{
                            PhotoPaths = new ObservableCollection<string>
                            {
                                "Images/ME4.jpg",
                                "Images/ME2.jpg",
                                "Images/ME3.jpg"
                            },
                            Name = "Mount Everest",
                            Description = "The highest mountain in the world.",
                            InterestingFacts = "Mount Everest is 29,029 feet tall.",
                            LocalCuisine = "Nepalese and Tibetan cuisine.",
                            Currency = "Nepalese Rupee",
                            Timezone = "NPT",
                            Weather = "Extremely cold, with temperatures dropping to -60°C at the summit.",
                            PlacesOfInterest = "Base Camp, Khumbu Icefall, South Col",
                            Dangers = "Altitude sickness, extreme weather conditions, avalanches",
                            Prices = "Accommodation: $50-150/night in nearby towns, Meals: $5-20"
}

                    }
                }
            };
            RegionsListBox.ItemsSource = Regions;
        }

        private void RegionsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RegionsListBox.SelectedItem is Region selectedRegion)
            {
                TouristPointsListBox.ItemsSource = selectedRegion.TouristPoints;
            }
        }

        private void TouristPointsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TouristPointsListBox.SelectedItem is TouristPoint selectedPoint)
            {
                TouristPointDetailsPanel.Visibility = Visibility.Visible;
                CurrentPhotoIndex = 0;
                UpdatePhotoDisplay(selectedPoint);

                Description.Text = selectedPoint.Description;
                InterestingFacts.Text = selectedPoint.InterestingFacts;
                LocalCuisine.Text = selectedPoint.LocalCuisine;
                Currency.Text = selectedPoint.Currency;
                Timezone.Text = selectedPoint.Timezone;
                Weather.Text = selectedPoint.Weather;
                PlacesOfInterest.Text = selectedPoint.PlacesOfInterest;
                Dangers.Text = selectedPoint.Dangers;
                Prices.Text = selectedPoint.Prices;
            }
        }

        private void UpdatePhotoDisplay(TouristPoint point)
        {
            if (point.PhotoPaths.Count > 0)
            {
                Photo.Source = new BitmapImage(new Uri(point.PhotoPaths[CurrentPhotoIndex], UriKind.RelativeOrAbsolute));
                PhotoIndexText.Text = $"{CurrentPhotoIndex + 1}/{point.PhotoPaths.Count}";
            }
            else
            {
                Photo.Source = null;
                PhotoIndexText.Text = "No photos available";
            }
        }

        private void PreviousPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            if (TouristPointsListBox.SelectedItem is TouristPoint selectedPoint)
            {
                if (CurrentPhotoIndex > 0)
                {
                    CurrentPhotoIndex--;
                    UpdatePhotoDisplay(selectedPoint);
                }
            }
        }

        private void NextPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            if (TouristPointsListBox.SelectedItem is TouristPoint selectedPoint)
            {
                if (CurrentPhotoIndex < selectedPoint.PhotoPaths.Count - 1)
                {
                    CurrentPhotoIndex++;
                    UpdatePhotoDisplay(selectedPoint);
                }
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string query = SearchTextBox.Text.ToLower().Trim();
            var filteredPoints = new ObservableCollection<TouristPoint>();

            if (string.IsNullOrEmpty(query))
            {
                TouristPointsListBox.ItemsSource = null;
            }
            else
            {
                foreach (var region in Regions)
                {
                    foreach (var point in region.TouristPoints)
                    {
                        if (point.Name.ToLower().Contains(query))
                        {
                            filteredPoints.Add(point);
                        }
                    }
                }

                TouristPointsListBox.ItemsSource = filteredPoints;
                TouristPointsListBox.DisplayMemberPath = "Name";
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            TouristPointDetailsPanel.Visibility = Visibility.Collapsed;
            TouristPointsListBox.SelectedItem = null;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            TouristPoint selectedTouristPoint = GetSelectedTouristPoint();

            if (selectedTouristPoint == null)
            {
                MessageBox.Show("Please select a tourist point to save.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                DefaultExt = ".pdf"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsPdf(selectedTouristPoint, filePath);
                MessageBox.Show("File saved successfully!");
            }
        }

        private void SaveAsPdf(TouristPoint touristPoint, string filePath)
        {
            using (PdfDocument document = new PdfDocument())
            {
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont fontTitle = new XFont("Verdana", 16, XFontStyleEx.Bold);
                XFont fontContent = new XFont("Verdana", 12, XFontStyleEx.Regular);

                int yPosition = 20; // Starting vertical position

                gfx.DrawString($"Tourist Point: {touristPoint.Name}", fontTitle, XBrushes.Black, new XRect(50, yPosition, page.Width - 50, 0));
                yPosition += 40; // Move down for the next line

                gfx.DrawString($"Description: {touristPoint.Description}", fontContent, XBrushes.Black, new XRect(20, yPosition, page.Width - 40, 0));
                yPosition += 40; // Adjust according to content length

                gfx.DrawString($"Interesting Facts: {touristPoint.InterestingFacts}", fontContent, XBrushes.Black, new XRect(20, yPosition, page.Width - 40, 0));
                yPosition += 40;

                gfx.DrawString($"Local Cuisine: {touristPoint.LocalCuisine}", fontContent, XBrushes.Black, new XRect(20, yPosition, page.Width - 40, 0));
                yPosition += 40;

                gfx.DrawString($"Currency: {touristPoint.Currency}", fontContent, XBrushes.Black, new XRect(20, yPosition, page.Width - 40, 0));
                yPosition += 40;

                gfx.DrawString($"Timezone: {touristPoint.Timezone}", fontContent, XBrushes.Black, new XRect(20, yPosition, page.Width - 40, 0));
                yPosition += 40;

                gfx.DrawString($"Weather: {touristPoint.Weather}", fontContent, XBrushes.Black, new XRect(20, yPosition, page.Width - 40, 0));
                yPosition += 40;

                gfx.DrawString($"Places of Interest: {touristPoint.PlacesOfInterest}", fontContent, XBrushes.Black, new XRect(20, yPosition, page.Width - 40, 0));
                yPosition += 40;

                gfx.DrawString($"Dangers: {touristPoint.Dangers}", fontContent, XBrushes.Black, new XRect(20, yPosition, page.Width - 40, 0));
                yPosition += 40;

                gfx.DrawString($"Prices: {touristPoint.Prices}", fontContent, XBrushes.Black, new XRect(20, yPosition, page.Width - 40, 0));

                document.Save(filePath);
            }
        }


        private TouristPoint GetSelectedTouristPoint()
        {
            // Assuming TouristPointsListBox is the ListBox that displays the TouristPoints
            return TouristPointsListBox.SelectedItem as TouristPoint;
        }
    }
}
