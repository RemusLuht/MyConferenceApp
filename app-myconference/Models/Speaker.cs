using Android.Database;

namespace app_myconference.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Image { get; set; } = "https://static.wikia.nocookie.net/dreamworks/images/0/09/Shrek_dreamworks.png/revision/latest/thumbnail/width/360/height/360?cb=20170921225439";
    }
}
