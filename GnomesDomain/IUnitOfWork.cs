namespace Gnomes.Domain
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();

        void SaveChanges();
    }
}
