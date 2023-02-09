//Moore, Douglas
namespace ConsoleApp3
{

    /* Beginning Of Notes/Log:
     * 3D space
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
    List<int> pLaceholder = new List<int> { };

    internal class Program
    {

        static void Main(string[] args)
        {

            //The room you start in.
            int x = 1;
            int y = 1;
            int z = 1;
            //Warning, Can Break .EXE


            ConsoleKeyInfo ans;
            Random rng = new Random();
            int min1 = 0;
            int max1 = 2;
            int min2 = 0;
            int max2 = 2;
            int min3 = 0;
            int max3 = 2;
            int min4 = 0;
            int max4 = 2;
            int min5 = 0;
            int max5 = 2;
            int min6 = 0;
            int max6 = 2;
            int rn;
            int up;
            int down;
            int left;
            int right;
            int numbers;
            int ascend;
            int decend;
            int tiles = 1;
            int room;
            bool asking;
            int roofh = 4;

            ans = Console.ReadKey();

            while (true)
            {
                numbers = 10;
                up = 0;
                down = 0;
                left = 0;
                right = 0;
                decend = 0;
                ascend = 0;

                //Room Generation V ///////////////////////

                if (z > 0)
                {
                    min1 = -10;
                    min2 = -10;
                    min3 = -10;
                    min4 = -10;
                    max5 = 20;
                }
                if (z <= 0)
                {
                    min1 = 0;
                    min2 = 0;
                    min3 = 0;
                    min4 = 0;
                    max5 = 2;
                }

                //Wall Generation V ///////////////////////

                Console.Clear();
                room = x * y * z + y * x * z + z * x * y;
                Console.WriteLine("room = " + room);
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
                rn = rng.Next(min1, max1);
                if (ans.Key == ConsoleKey.S || rn <= 1)
                {
                    up = 1;
                    roofh--;
                }
                rn = rng.Next(min2, max2);
                if (ans.Key == ConsoleKey.D || rn <= 1)
                {
                    left = 1;
                    roofh--;
                }
                rn = rng.Next(min3, max3);
                if (ans.Key == ConsoleKey.A || rn <= 1)
                {
                    right = 1;
                    roofh--;
                }
                rn = rng.Next(min4, max4);
                if (ans.Key == ConsoleKey.W || rn <= 1)
                {
                    down = 1;
                    roofh--;
                }
                rn = rng.Next(min5, max5);
                if (ans.Key == ConsoleKey.E || rn <= 1)
                {
                    decend = 1;
                }
                rn = rng.Next(min6, max6);
                if (roofh >= 1)
                {
                    ascend = 1;
                }
                roofh = 4;

                //Movement Inquiry V ///////////

                if (decend == 1)
                {
                    Console.WriteLine(":decend? = q");
                    numbers--;
                }
                if (ascend == 1)
                {
                    Console.WriteLine(":ascend? = e");
                    numbers--;
                }
                if (up == 1)
                {
                    Console.WriteLine(":up? = w");
                    numbers--;
                }
                if (down == 1)
                {
                    Console.WriteLine(":down? = s");
                    numbers--;
                }
                if (left == 1)
                {
                    Console.WriteLine(":left? = a");
                    numbers--;
                }
                if (right == 1)
                {
                    Console.WriteLine(":right? = d");
                    numbers--;
                }
                while (numbers > 0)
                {
                    Console.WriteLine(" ");
                    numbers--;
                }
                Console.WriteLine(@"///////////////////////////////////////////////////////////////////////////////////////////////////////////");

                //Storage V /////////////////////

                int xtimes = 10 ^ x * 3;
                int ytimes = 10 ^ y * 2;
                int ztimes = 10 ^ z * 1;
                int timen = x * xtimes + y * ytimes + z * ztimes
                    ;
                Storage(timen);
                static void Storage(int timen)
                {
                    pLaceholder[timen](timen);
                }

                //Textures V ///////////////////

                if (tiles == 1)
                {
                    //0;
                    if (up == 0)
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"         \________________________/");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"         \                        /");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                    }
                    if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                    }
                    if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                    }
                    if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"         /________________________\");

                    }
                    else
                    {
                        Console.WriteLine(@"         /                        \");

                    }
                }
                if (tiles == 2)
                {
                    //0;
                    if (up == 0)
                    {
                        //12
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"         /oooooooooooooooooooooooo\");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"         /                        \");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                    }
                    else if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                    }
                    else if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                    }
                    else if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"         \oooooooooooooooooooooooo/");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");

                    }
                    else
                    {
                        Console.WriteLine(@"         \                        /");

                    }

                }
                if (tiles == 3)
                {
                    //0;
                    if (up == 0)
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"        _]________________________[_");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"        _]                        [_");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                    }
                    if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |/                         ");
                        Console.WriteLine(@"         /                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                    }
                    if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                    }
                    if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"        _]________________________[_");

                    }
                    else
                    {
                        Console.WriteLine(@"        _]                        [_");

                    }
                }
                if (tiles == 4)
                {
                    //0;
                    if (up == 0)
                    {
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _]|=|++t            [___");
                        Console.WriteLine(@"          [____][____]{}{}{}[____]");
                        Console.WriteLine(@"          ____][____]      [____][");
                        Console.WriteLine(@"          ]|||||]            [____");
                        Console.WriteLine(@"          ____][____]      [____][");
                        Console.WriteLine(@"          ___](****)[____][____][_");
                        Console.WriteLine(@"          [____]      [____][&e&2]");
                        Console.WriteLine(@"          _][____]            [___");
                        Console.WriteLine(@"          ____][_\ _]()00()[____][");
                        Console.WriteLine(@"          _][____][__\     c/[____");
                        Console.WriteLine(@"          [____][____]\    /[____]");
                        Console.WriteLine(@"        /\/\/--\^\__/\/\/\//\__/\ /\");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"                                    ");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                    }
                    if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"     \__                           ");
                        Console.WriteLine(@"        ]                          ");
                        Console.WriteLine(@"       [_,                         ");
                        Console.WriteLine(@"       o |                         ");
                        Console.WriteLine(@"       __p                         ");
                        Console.WriteLine(@"      |     /                      ");
                        Console.WriteLine(@"    n |__, /o                      ");
                        Console.WriteLine(@"    U    |/                        ");
                        Console.WriteLine(@"       _-'                         ");
                        Console.WriteLine(@"     _|                            ");
                        Console.WriteLine(@"    /                              ");
                    }
                    if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                  | ");
                        Console.WriteLine(@"                               v\ \ ");
                        Console.WriteLine(@"                                 \\|");
                        Console.WriteLine(@"                                 _\|");
                        Console.WriteLine(@"                                [   ");
                        Console.WriteLine(@"                               /IIII");
                        Console.WriteLine(@"                              [___  ");
                        Console.WriteLine(@"                                 \  ");
                        Console.WriteLine(@"                                 |_ ");
                        Console.WriteLine(@"                                  ] ");
                        Console.WriteLine(@"                                  \ ");
                    }
                    if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"     ---|                        /  ");
                        Console.WriteLine(@"      u /                       [_? ");
                        Console.WriteLine(@"       /                         \  ");
                        Console.WriteLine(@"       \                       ___] ");
                        Console.WriteLine(@"    [  _\                      | j  ");
                        Console.WriteLine(@"     ] |                        \ J ");
                        Console.WriteLine(@"    [  |                         \__");
                        Console.WriteLine(@"     ] |                           [");
                        Console.WriteLine(@"    [  _=-'                       [o");
                        Console.WriteLine(@"     ]|                          [__");
                        Console.WriteLine(@"    [ |                           |_");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"        [____][____][____][____][___");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ][____][____][____][____");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ___][____][____][____][_");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");

                    }
                    else
                    {
                        Console.WriteLine(@"                                    ");

                    }
                }
                if (tiles == 5)
                {
                    //0;
                    if (up == 0)
                    {
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"        ");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"                                    ");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                    }
                    if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                    }
                    if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                    }
                    if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                            ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"        ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");

                    }
                    else
                    {
                        Console.WriteLine(@"                                    ");

                    }
                }
                if (tiles == 6)
                {
                    //0;
                    if (up == 0)
                    {
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ][____][____][____][____");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ___][____][____][____][_");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"        [____][____][____][____][___");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"                                    ");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                    }
                    if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     ___]                           ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                    }
                    if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                [___");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                    }
                    if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    ___]                        [___");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"        [____][____][____][____][___");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ][____][____][____][____");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ___][____][____][____][_");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");

                    }
                    else
                    {
                        Console.WriteLine(@"                                    ");

                    }
                }

                //Movement V///////////////////

                asking = true;
                while (asking == true)
                {
                    ans = Console.ReadKey();
                    if (ans.Key == ConsoleKey.W && up == 1)
                    {
                        y++;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.S && down == 1)
                    {
                        y--;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.A && left == 1)
                    {
                        x--;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.D && right == 1)
                    {
                       x++;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.E && ascend == 1)
                    {
                        z++;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.Q && decend == 1)
                    {
                        z--;
                        asking = false;
                    }
                }
            }
        }
    }
}
//RPG Project