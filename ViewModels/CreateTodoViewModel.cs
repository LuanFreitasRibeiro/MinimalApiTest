using Flunt.Notifications;
using Flunt.Validations;

public class CreateTodoViewModel : Notifiable<Notification>
{
    public string Title { get; set; }

    public Todo MapTo()
    {
        //AddNotifications(new Contract<Notification>()
        //    .Requires()
        //    .IsNullOrEmpty(Title, "Title is required")
        //    .IsGreaterOrEqualsThan(Title, 5, "Title must be greater than 5"));

        return new Todo(Guid.NewGuid(), Title, false);
    }
}


