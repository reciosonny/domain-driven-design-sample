namespace SampleWebApp.Domain.Persistence {
    public interface IUnitOfWork {
        void Complete();
        void CompleteAsync();
    }
}