﻿using MediatR;

namespace BaseProject.Application.CQRS.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQuery
    : IRequest<NoteDetailsVm> 
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}