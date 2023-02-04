namespace DesafioContaBancaria.Entities.Exceptions {
    public class DomainException : ApplicationException {
        public DomainException(string Message) : base(Message) {
        }
    }
}
