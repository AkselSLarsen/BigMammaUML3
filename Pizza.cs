namespace BigMammaUML3 {
    public class Pizza : MenuItem {
        private bool _isDeepPan;

        public Pizza(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic, bool isDeepPan) : base(number, name, description, price, menuType, isVegan, isOrganic) {
            _isDeepPan = isDeepPan;
        }

        public bool DeepPan {
            get { return _isDeepPan; }
            set { _isDeepPan = value; }
        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }
        public override int GetHashCode() {
            return base.GetHashCode();
        }
        public override string PrintInfo() {
            return base.PrintInfo() + $" DeepPan {DeepPan}";
        }
        public override string ToString() {
            return base.ToString();
        }
    }
}