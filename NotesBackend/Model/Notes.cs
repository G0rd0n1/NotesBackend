using System.ComponentModel.DataAnnotations;

namespace NotesBackend.Model
{
    public class Notes
    {
        [Key]
        public int notesId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
