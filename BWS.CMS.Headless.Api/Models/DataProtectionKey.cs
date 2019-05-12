using System.ComponentModel.DataAnnotations;

namespace BWS.CMS.Headless.Api.Models
{
    public class DataProtectionKey
    {
        [Key]
        public string FriendlyName { get; set; }
        public string XmlData { get; set; }
    }
}
