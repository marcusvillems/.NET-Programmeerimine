using System.ComponentModel;

namespace Parcel_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            FirstParcelLine(boxSizes);
        }


        public static bool FirstParcelLine(List<BoxSize> boxSizes)
        {
            bool parcelFits = false;

            foreach (BoxSize box in boxSizes) 
            {
                Console.WriteLine("New sorting line starts");

                var boxLenghtInHalf = box.Lenght / 2;

                var halfBoxDiagonalNotSqrt = (boxLenghtInHalf * boxLenghtInHalf) + (box.Widht * box.Widht);

                var halfParcelDiagonal = Math.Sqrt(halfBoxDiagonalNotSqrt);
                
                foreach (SortingLineParam sortingLine in box.SortingLineParams) 
                {

                    if (sortingLine.Widht >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line widht is {0} and fits", sortingLine.Widht);
                    }
                    else
                    {
                        Console.WriteLine("Parcel does not fit.");
                    }
                }
            }

            return parcelFits; 
        }


        public static readonly List<BoxSize> boxSizes = new List<BoxSize>
        {
            new BoxSize
            {
                Lenght = 120,
                Widht = 60,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Widht = 100
                    },
                    new SortingLineParam
                    {
                        Widht = 75
                    }
                }
            },
            new BoxSize
            {
                Lenght = 35,
                Widht = 100,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Widht = 75
                    },
                    new SortingLineParam
                    {
                        Widht = 50
                    },
                    new SortingLineParam
                    {
                        Widht = 80
                    },
                    new SortingLineParam
                    {
                        Widht = 100
                    },
                    new SortingLineParam
                    {
                        Widht = 37
                    }
                }
            },

            new BoxSize
            {
                Lenght = 50,
                Widht = 70,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Widht = 60
                    },
                    new SortingLineParam
                    {
                        Widht = 60
                    },
                    new SortingLineParam
                    {
                        Widht = 55
                    },
                    new SortingLineParam
                    {
                        Widht = 90
                    }
                }
            }
        };
    }

    

    class BoxSize
    {
        public int Lenght { get; set; }
        public int Widht { get; set; }
        public List<SortingLineParam> SortingLineParams { get; set; }
            = new List<SortingLineParam>();
    }           


    class SortingLineParam
    {
        public int Widht { get; set; }
        public int lenght { get; set; }

    }
}