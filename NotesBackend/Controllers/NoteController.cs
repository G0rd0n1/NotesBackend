using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using NotesBackend.Model;

namespace NotesBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        
        private readonly NotesDbContext _notesDbContext;

        
        public NotesController(NotesDbContext notesDbContext)
        {
            _notesDbContext = notesDbContext;
        }

       
        [HttpGet]
        [Route("GetAllNotes")]
        public async Task<IEnumerable<Notes>> GetMembers()
        {
            
            return await _notesDbContext.Notes.ToListAsync();
        }

        
        [HttpPost]
        [Route("AddNotes")]
        public async Task<Notes> AddMember(Notes objNote)
        {
            
            _notesDbContext.Notes.Add(objNote);
            await _notesDbContext.SaveChangesAsync();
           
            return objNote;
        }

        
        [HttpPatch]
        [Route("UpdateNotes/{id}")]
        public async Task<Notes> UpdateMember(Notes objNote)
        {
            
            _notesDbContext.Entry(objNote).State = EntityState.Modified;
            await _notesDbContext.SaveChangesAsync();
           
            return objNote;
        }

        [HttpDelete]
        [Route("DeleteNote/{id}")]
        public bool DeleteNote(int id)
        {
            bool a = false;
            
            var note = _notesDbContext.Notes.Find(id);
            if (note != null)
            {
                a = true;
               
                _notesDbContext.Entry(note).State = EntityState.Deleted;
                _notesDbContext.SaveChanges();
            }
            else
            {
                a = false;
            }
            
            return a;
        }
    }
}

