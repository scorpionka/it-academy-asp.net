namespace HW3.Client.PresentationServices.Interfaces
{
    public interface IUserPresentationService
    {
        void CreateUser(User user);
        User ReadUser(Guid id);
        void UpdateUser(User user);
        void DeleteUser(Guid id);
        List<User> AllUsers();

        Country ReadCountry(Guid id);

        City ReadCity(Guid id);

    }
}
