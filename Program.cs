using System;

namespace DNA_Replication
{
    class Program
    {
        static void Main(string[] args)
        {
            string halfDNASequence = Console.ReadLine();
            char another = char.Parse(Console.ReadLine());
            do
            {
                while (IsValidSequence(halfDNASequence) == true)
                {
                Console.WriteLine("Current half DNA sequence : " + halfDNASequence);

                    Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
                    char YesorNO = char.Parse(Console.ReadLine());

                    if (YesorNO == 'Y')
                    {
                        Console.WriteLine("Replicated half DNA sequence : " + ReplicateSequence(halfDNASequence));
                    }
                    else if (YesorNO == 'N')
                    {
                        break;
                    }
                    else
                    {
                        while (YesorNO != 'Y' && YesorNO != 'N')
                        {
                            Console.WriteLine("Please input Y or N.");
                            YesorNO = char.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                    char YouWantAnother = char.Parse(Console.ReadLine());
                    Console.WriteLine(AnotherSequence(YouWantAnother));
                }

                while (IsValidSequence(halfDNASequence) == false)
                {
                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                    char YouWantAnother = char.Parse(Console.ReadLine());
                    Console.WriteLine(AnotherSequence(YouWantAnother));
                }
            } while (another == 'Y');
        }



        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

        static string ReplicateSequence(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

        static bool AnotherSequence(char YouWantAnother)
        {
            if (YouWantAnother == 'Y')
            {
                return true;
            }
            return false;
        }
    }
}








       