namespace BaseProject.Domain.Interfaces;

public interface IIdentifier<T>
{
    public T Id { get; set; }
}