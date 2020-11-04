using System.Globalization;

namespace BigMammaUML3 {
    public abstract class MenuItem : IMenuItem {
        private int _number;
        private string _name;
        private string _description;
        private double _price;
        private MenuType _menuType;
        private bool _isVegan;
        private bool _isOrganic;

        public MenuItem(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic) {
            _number = number;
            _name = name;
            _description = description;
            _price = price;
            _menuType = menuType;
            _isVegan = isVegan;
            _isOrganic = isOrganic;
        }

        public int Number {
            get { return _number; }
        }
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string Description {
            get { return _description; }
            set { _description = value; }
        }
        public double Price {
            get { return _price; }
            set { _price = value; }
        }
        public MenuType Type {
            get { return _menuType; }
            set { _menuType = value; }
        }
        public bool IsVegan {
            get { return _isVegan; }
            set { _isVegan = value; }
        }
        public bool IsOrganic {
            get { return _isOrganic; }
            set { _isOrganic = value; }
        }

        public virtual string PrintInfo() {   // Denne metode printer formateret ud.
            return $"Number {_number} \tName {_name} \n\tDescription {_description} Price {_price.ToString("N2")} MenuType {_menuType} IsVegan {_isVegan} IsOrganic {_isOrganic}";
        }

        public override string ToString() {
            return $"Number {_number} Name {_name} Description {_description} Price {_price} MenuType {_menuType} IsVegan {_isVegan} IsOrganic {_isOrganic}";
        }
    }
}