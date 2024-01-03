// The `new` keyword is used to instantiate an array object for two main reasons:
// 1. It **explicitly** allocates memory on the heap for the array, and initializes each of its elements to default values.
// 2. Arrays are "reference types", which means the declared variable only holds a *reference* to the array's memory location, but doesn't hold the data itself.
// This differs from "value types" (e.g. bool, char, int), which are **implicitly** stored on the stack, meaning their variables contain the actual data.
// Note: Strings are a special case of reference types, as they can be initialized without `new` due to language optimizations (more on this in later lessons).

void FraudulentOrders()
{
    string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

    Console.WriteLine($"{fraudulentOrderIDs[0]}");
    Console.WriteLine($"{fraudulentOrderIDs[1]}");
    Console.WriteLine($"{fraudulentOrderIDs[2]}");

    fraudulentOrderIDs[0] = "F000";
    Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

    Console.WriteLine($"There are currently {fraudulentOrderIDs.Length} fraudulent order IDs.");
}

void CheckInventory()
{
    int[] inventory = { 200, 450, 1200, 670, 995, 300 };
    int bin = 0;
    int sum = 0;

    foreach (int items in inventory)
    {
        bin++;
        Console.WriteLine($"There are {items} items in Bin {bin}");
        sum += items;
        Console.WriteLine($"Current total of items: {sum}");
    }

    Console.WriteLine($"There are {sum} total items in the inventory.");
}

void ArrayChallenge()
{
    string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179", "XZY34789", "WXY96874", "JLK72541", "MNB48936", "HJF50281", "POQ39274", "BDC15983", "UIO42675", "ZNA23847", "PLM09324", "ASX48376", "TRN57021", "QPO42856", "LMN90341", "DFG56271", "VBN84723", "KLU68219", "YTR29105", "RTR19273", "WEF74832", "XYZ12345", "UVW67890", "MNO54321", "PQR09876", "JKL54321", "GHI12345", "DEF67890", "ABC09876", "STU54321", "VWX12345", "YZA67890", "BCD09876", "EFG54321", "HIJ12345", "KLM67890", "NOP09876", "QRS54321", "TUV12345", "WXY67890", "ZAB09876", "CDE54321", "FGH12345", "ABC12345", "DEF67890", "GHI54321", "JKL09876", "MNO54321", "PQR12345", "STU67890", "VWX09876", "YZA54321", "BCD09876", "EFG54321", "HIJ12345", "KLM67890", "NOP09876", "QRS54321", "TUV12345", "WXY67890", "ZAB09876", "CDE54321", "FGH12345", "X123", "Y234", "F345", "T15", "M177", "B3003", "D235", "R179", "J789", "K987", "C876", "G654", "A321", "Z654", "E432", "N234", "S876", "H987", "L123", "O543", "Q654", "U876", "W987", "I234", "P654", "V543", "X876", "Y987", "Z234", "B432", "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179", "D789", "E987", "F876", "H654", "I321", "J654", "K432", "L234", "M876", "N987", "O123", "P543", "Q654", "R876", "S987", "T234", "U654", "V543", "W876", "X987", "Y234", "Z432", "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179", "D789", "E987", "F876", "H654", "I321", "J654", "K432", "L234", "M876", "N987", "O123", "P543", "Q654", "R876", "S987", "T234", "U654", "V543", "W876", "X987", "Y234", "Z432" };

    foreach (string ID in orderIDs)
    {
        if (ID.StartsWith("B"))
        {
            Console.WriteLine($"Possibly fraudulent ID detected: {ID}");
        }
    }
}
