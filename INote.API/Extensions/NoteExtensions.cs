using INote.API.Dtos;
using INote.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INote.API.Extensions
{
    public static class NoteExtensions
    {
        public static GetNoteDto ToGetNoteDto(this Note note)
        {
            return new GetNoteDto
            {
                Id = note.Id,
                Title = note.Title,
                Content = note.Content,
                CreatedTime = note.CreatedTime,
                ModifiedTime = note.ModifiedTime
            };
        }
    }
}