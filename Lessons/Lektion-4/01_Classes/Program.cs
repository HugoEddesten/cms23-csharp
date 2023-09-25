using _01_Classes.Services;

/*

    Access modifiers
    --------------------------------------------------------------------------------------
    private         accessbar endast inom scopet som variabeln ligger inom.
    public          accessbar överallt i hela din solution dvs även mellan olika projekt.
    internal        accessbar endast i projektet.




*/



// Gör en instans av en customerService så vi kan använda den
var customerSevice = new CustomerService();

customerSevice.GetCustomers();
