using System;
using System.Collections.Generic;
using BigMammaUML3;

public class MenuCatalog : IMenuCatalog {
	private List<IMenuItem> _list;

	public int Count => _list.Count;

	public MenuCatalog() {
		_list = new List<IMenuItem>();
	}

	public void Add(IMenuItem aMenuItem) {
		if (Search(aMenuItem.Number) != null) {
			throw new MenuItemNumberExistsException("An item with that number already exists.");
		}
		_list.Add(aMenuItem);
	}

	public void Delete(int number) {
		IMenuItem tmp = Search(number);
		if (tmp != null) {
			_list.Remove(tmp);
		}
	}

	public List<IMenuItem> FindAllOrganic(MenuType type) {
		List<IMenuItem> organics = new List<IMenuItem>();
		foreach (IMenuItem menuItem in _list) {
			if (menuItem.Type == type && menuItem.IsOrganic) {
				organics.Add(menuItem);
			}
		}
		return organics;
	}

	public List<IMenuItem> FindAllVegan(MenuType type) {
		List<IMenuItem> vegan = new List<IMenuItem>();
		foreach (IMenuItem menuItem in _list) {
			if (menuItem.Type == type && menuItem.IsVegan) {
				vegan.Add(menuItem);
			}
		}
		return vegan;
	}

	public IMenuItem MostExpensiveMenuItem() {
		IMenuItem costly = _list[0];
		foreach (IMenuItem menuItem in _list) {
			if (costly.Price < menuItem.Price) {
				costly = menuItem;
			}
		}
		return costly;
	}

	public void PrintBeveragesMenu() {
		foreach (IMenuItem menuItem in _list) {
			if (menuItem is Beverage) {
				Program.print(menuItem.PrintInfo() + "\n");
			}
		}
	}

	public void PrintPizzasMenu() {
		foreach (IMenuItem menuItem in _list) {
			if (menuItem is Pizza) {
				Program.print(menuItem.PrintInfo() + "\n");
			}
		}
	}

	public void PrintPastaMenu() {
		foreach (IMenuItem menuItem in _list) {
			if (menuItem is Pasta) {
				Program.print(menuItem.PrintInfo() + "\n");
			}
		}
	}

	public IMenuItem Search(int number) {
		IMenuItem toFind = null;
		foreach (IMenuItem menuItem in _list) {
			if (menuItem != null && menuItem.Number == number) {
				toFind = menuItem;
			}
		}
		return toFind;
	}

	public void Update(int number, IMenuItem theMenuItem) {
		IMenuItem toReplace = Search(number);
		toReplace = theMenuItem;
	}

	public void ReadFromFile(ICommandReader reader) {
		foreach (string s in reader.Commands) {
			char[] separator = new char[1]
			{
				';'
			};
			string[] c = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			string[] array = c;
			foreach (string str in array) {
				str.Trim();
			}
			int number = 0;
			try {
				int.TryParse(c[1], out number);
			} catch (Exception e3) {
				Program.print("Failure to parse number from file" + e3.Message);
				return;
			}
			double price = 0.0;
			try {
				double.TryParse(c[4], out price);
			} catch (Exception e2) {
				Program.print("Failure to parse price from file" + e2.Message);
				return;
			}
			int tmp = 0;
			MenuType menuType;
			try {
				int.TryParse(c[5], out tmp);
				menuType = (MenuType)tmp;
			} catch (Exception e) {
				Program.print("Failure to parse menu type from file" + e.Message);
				return;
			}
			bool isVegan = c[6].ToLower().Contains("t");
			bool isOrganic = c[7].ToLower().Contains("t");
			if (c[0].ToLower() == "pizza") {
				bool isDeepPan = c[8].ToLower().Contains("t");
				Add(new Pizza(number, c[2], c[3], price, menuType, isVegan, isOrganic, isDeepPan));
				continue;
			}
			if (c[0].ToLower() == "pasta") {
				bool isWholeGrain = c[8].ToLower().Contains("t");
				Add(new Pasta(number, c[2], c[3], price, menuType, isVegan, isOrganic, isWholeGrain));
				continue;
			}
			if (c[0].ToLower() == "beverage") {
				bool isAlcoholic = c[8].ToLower().Contains("t");
				Add(new Beverage(number, c[2], c[3], price, menuType, isVegan, isOrganic, isAlcoholic));
				continue;
			}
			throw new InvalidMenuTypeException("No menu type matching " + c[0]);
		}
	}
}