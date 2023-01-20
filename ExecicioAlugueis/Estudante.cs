using System.Globalization;
using System.Text.RegularExpressions;

namespace ExercicioAlugueis {
    class Estudante {

        private string _name;
        private string _email;
        public Estudante(string name, string email) {
            _name = name;
            _email = email;
        }

        public string Name {
            get { return _name; }
            set {

                _name = value;

            }
        }
    

        public string Email {
            get { return _email; }
            set {
                _email = value;

            }
        }
    

    public override string ToString() {
        return
        _name
        + ", "
        + _email;

    }
}
}