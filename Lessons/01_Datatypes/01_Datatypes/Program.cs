/* Sträng-metoder

    
    string text = " HejHejHej";

    Console.WriteLine(text);
    Console.WriteLine(text.ToUpper());
    Console.WriteLine(text.ToLower());
    Console.WriteLine(text.Trim());
    Console.WriteLine(text.Replace("j", "b"));

*/


/*

    INTEGRALS AND FLOATING POINTS

        Type        Bits        Range (min, max)
        -------------------------------------------------------------
      * byte        8           0                           255
        sbyte       8           -128                        127  
        short       16          -32768                      32767
        ushort      16          0                           65532    
      * int         32          -2 147 483 648              2 147 483 647
        uint        32          0                           4 294 967 295    
      * long        64          -9 223 372 036 854 775 808  9 223 372 036 854 775 807
        ulong       64          0                           18 446 744 073 709 551 615
        
        Type        Bytes       Decimal range       Suffix
        --------------------------------------------------------------
        float       4           6-9 digits          f eller F
        double      8           15-16 digits        inget eller d eller D
      * decimal     16          28-29 digits        m eller M

    Operationer på float
    --------------------------
    float floatValue = 0.1f + 0.1f + 0.1f;      // 0.3

    double floatValue = 0.1 + 0.1 + 0.1;        // 0.300000000000000004
    
    decimal floatValue = 0.1m + 0.1m + 0.1m;    // 0.3

*/

/*
    
    BOOLEAN
    
    Type                Bits                Value
    -------------------------------------------------------------------
    bool                0/1                 true/false
    
    bool isEnabled = false;
    bool isActive = true;

*/

/*

    GUID/UUID (Globally Unique Identifier)
    --------------------------------------------------------------------
    Guid        16 bytes        Guid.NewGuid()      e40311e5-7a5d-47ad-a66d-e47610a68483

    Guid userId = Guid.NewGuid();

*/
