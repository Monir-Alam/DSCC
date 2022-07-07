using System.ComponentModel.DataAnnotations;

namespace InterDept.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String FileHeading { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd-MM-yyyy}")]
        public DateTime FileInDate { get; set; }
        public DateTime FileOutDate { get; set; }
    }
}
