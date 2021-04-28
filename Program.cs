using System;

namespace DNA
{
    class Program
    {
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

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

        static void Main(string[] args)
        {
            
            string DNA,InputYN,InputYN2 = "Y";
            while (InputYN2 == "Y")
            {
                Console.Write("");
                DNA = Console.ReadLine();

                if (IsValidSequence(DNA) == true)
                {
                    Console.WriteLine("Current half DNA sequence : {0}", DNA);
                    Console.Write("Do you want to replicate it ? (Y/N) : ");
                    InputYN = Console.ReadLine();

                    while(InputYN != "Y" && InputYN != "N")
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        InputYN = Console.ReadLine();
                    }

                    if (InputYN == "Y")
                    {
                        Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(DNA));
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");
                        InputYN2 = Console.ReadLine();
                        while (InputYN2 != "Y" && InputYN2 != "N")
                        {
                            Console.WriteLine("Please input Y or N.");
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            InputYN2 = Console.ReadLine();
                        }
                        if (InputYN2 != "N")
                        {
                            Console.WriteLine("");
                        }
                    }
                    else if (InputYN == "N")
                    {
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");
                        InputYN2 = Console.ReadLine();
                        while (InputYN2 != "Y" && InputYN2 != "N")
                        {
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            InputYN2 = Console.ReadLine();
                        }
                        if (InputYN2 != "N")
                        {
                            Console.WriteLine("");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                    Console.Write("Do you want to process another sequence ? (Y / N) : ");
                    InputYN2 = Console.ReadLine();

                    if (InputYN2 == "N")
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        while (InputYN2 != "Y" && InputYN2 != "N")
                        {
                            Console.WriteLine("Please input Y or N.");
                            Console.WriteLine("");
                        }
                        if (InputYN2 == "N")
                        {
                            Console.WriteLine("");
                        }
                    }
                }
            }
            
            Console.ReadLine();
        }
    }
}
