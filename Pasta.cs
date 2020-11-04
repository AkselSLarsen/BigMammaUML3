namespace BigMammaUML3 {
    public class Pasta : MenuItem {
        private bool _wholeGrain;

        public Pasta(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic, bool wholeGrain) : base(number, name, description, price, menuType, isVegan, isOrganic) {
            _wholeGrain = wholeGrain;
        }

        public bool WholeGrain {
            get { return _wholeGrain; }
            set { _wholeGrain = value; }
        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }
        public override int GetHashCode() {
            return base.GetHashCode();
        }
        public override string PrintInfo() {
            return base.PrintInfo() + $" Whole Grain {WholeGrain}";
        }
        public override string ToString() {
            return base.ToString();
        }
    }
}