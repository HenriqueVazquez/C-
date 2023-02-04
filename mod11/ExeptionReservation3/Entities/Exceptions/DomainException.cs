
namespace ExeptionReservation3.Entities.Exceptions {
    internal class DomainException : ApplicationException {
        public DomainException(string Message) : base(Message){ 
        }
    }
}
