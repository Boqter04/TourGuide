using System.Collections.ObjectModel;

namespace Project.Models
{
    public class Region
    {
        public string Name { get; set; }
        public ObservableCollection<TouristPoint> TouristPoints { get; set; }

        public Region()
        {
            TouristPoints = new ObservableCollection<TouristPoint>();
        }
    }
}
