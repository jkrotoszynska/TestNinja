namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            /*
            // admin może wycofać
            if (user.IsAdmin)
                return true;

            // osoba składająca rezerwacje może ją wycofać
            if (MadeBy == user)
                return true;

            // inne osoby nie mogą wycofać
            return false;
            */
            return (user.IsAdmin || MadeBy == user);
        }
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}