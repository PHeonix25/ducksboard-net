using System.Runtime.Serialization;

namespace Ducksboard.Model
{
    [DataContract]
    public class TimelineValue
    {
        public const string DefaultImageUrlRed = "https://dashboard.ducksboard.com/static/img/timeline/red.gif";
        public const string DefaultImageUrlOrange = "https://dashboard.ducksboard.com/static/img/timeline/orange.gif";
        public const string DefaultImageUrlGreen = "https://dashboard.ducksboard.com/static/img/timeline/green.gif";
        public const string DefaultImageUrlCreated = "https://dashboard.ducksboard.com/static/img/timeline/created.png";
        public const string DefaultImageUrlEdited = "https://dashboard.ducksboard.com/static/img/timeline/edited.png";
        public const string DefaultImageUrlDeleted = "https://dashboard.ducksboard.com/static/img/timeline/deleted.png";

        [DataMember(Name = "title", Order = 1)]
        public string Title { get; set; }

        [DataMember(Name = "image", Order = 2)]
        public string ImageUrl { get; set; }

        [DataMember(Name = "content", Order = 3)]
        public string Content { get; set; }
    }
}