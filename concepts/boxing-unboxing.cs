class boxingunboxing{

    public static void show()
    {
        // Boxing -> Implicit casting -> lower to higher
        int i = 12;
        object obj = i;

        Console.WriteLine("object value : " + obj);

        // Unboxing -> Explicit casting -> higher to lower
        object objnew = 122;
        int j = (int)objnew;

        Console.WriteLine("integer j value : " + j); // o/p = 122

        double d = 167.89;
        int k =(int) d;

        Console.WriteLine("integer k value : " + k); // o/p = 167
        //explicit casting may have loose of data as the output come as 167 and we loose value after decimal i.e. .89;

    }

}
