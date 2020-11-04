namespace BigMammaUML3 {
    public class Beverage : MenuItem {
        private bool _isAlcoholic;

        public Beverage(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic, bool isAlcoholic) : base(number, name, description, price, menuType, isVegan, isOrganic) {
            _isAlcoholic = isAlcoholic;
        }

        public bool Alcohol {
            get { return _isAlcoholic; }
            set { _isAlcoholic = value; } 
        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }
        public override int GetHashCode() {
            return base.GetHashCode();
        }
        public override string PrintInfo() {
            return base.PrintInfo() + $" Alcohol {Alcohol}";
        }
        public override string ToString() {
            return base.ToString();
        }
    }
}