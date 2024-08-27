using System;
using System.Collections.ObjectModel;
 
namespace Project.Models
{
    public class TouristPoint
    {
        public string Name { get; set; }
        public ObservableCollection<string> PhotoPaths { get; set; } // Collection of photo paths
        public string Description { get; set; }
        public string InterestingFacts { get; set; }
        public string LocalCuisine { get; set; }
        public string Currency { get; set; }
        public string Timezone { get; set; }
        public string Weather { get; set; }
        public string PlacesOfInterest { get; set; }
        public string Dangers { get; set; }
        public string Prices { get; set; }

        // Constructor to initialize the TouristPoint object.
        public TouristPoint()
        {
            // The PhotoPaths property is initialized with an empty ObservableCollection to ensure it can be used immediately.
            PhotoPaths = new ObservableCollection<string>();
        }
    }
}
