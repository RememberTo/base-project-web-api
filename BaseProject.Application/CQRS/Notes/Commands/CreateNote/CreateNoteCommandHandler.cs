using MediatR;

namespace BaseProject.Application.CQRS.Notes.Commands.CreateNote
{
    public class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, Guid>
    {
        public async Task<Guid> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
        {
          throw new System.NotImplementedException();
        }
    }
}
