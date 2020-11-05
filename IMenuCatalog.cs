using System.Collections.Generic;
using BigMammaUML3;

public interface IMenuCatalog {
	int Count {
		get;
	}

	void Add(IMenuItem aMenuItem);

	IMenuItem Search(int number);

	void Delete(int number);

	void PrintPizzasMenu();

	void PrintBeveragesMenu();

	void PrintPastaMenu();

	void Update(int number, IMenuItem theMenuItem);

	List<IMenuItem> FindAllVegan(MenuType type);

	List<IMenuItem> FindAllOrganic(MenuType type);

	IMenuItem MostExpensiveMenuItem();

	void ReadFromFile(ICommandReader reader);
}