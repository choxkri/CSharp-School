//class Test
//{
//    public static void Main(string[] args)
//    {
//        List<string> contenders = new List<string>()
//        {
//            "Contender 1",
//            "Contender 2",
//            "Contender 3",
//            "Contender 4",
//            "Contender 5",
//            "Contender 6",
//            "Contender 7",
//            "Contender 8",
//            "Contender 9",
//            "Contender 10"
//        };

//        Dictionary<string, List<int>> scores = new Dictionary<string, List<int>>();

//        // Loop for 3 rounds
//        for (int round = 1; round <= 3; round++)
//        {
//            Console.WriteLine($"Round {round}");

//            // Shuffle contenders for this round
//            Shuffle(contenders);

//            // Assign scores for each contender
//            for (int i = 0; i < contenders.Count; i++)
//            {
//                string contender = contenders[i];

//                // Create a list of scores for this contender if it doesn't exist
//                if (!scores.ContainsKey(contender))
//                {
//                    scores[contender] = new List<int>();
//                }

//                // Assign score based on position
//                int score;
//                switch (i)
//                {
//                    case 0:
//                        score = 5;
//                        break;
//                    case 1:
//                        score = 4;
//                        break;
//                    case 2:
//                        score = 3;
//                        break;
//                    case 3:
//                        score = 2;
//                        break;
//                    default:
//                        score = 1;
//                        break;
//                }

//                // Add score to list for this contender
//                scores[contender].Add(score);

//                Console.WriteLine($"{contender} scored {score}");
//            }

//            Console.WriteLine();
//        }

//        // Print final scores for each contender
//        Console.WriteLine("Final Scores:");
//        foreach (string contender in contenders)
//        {
//            Console.Write($"{contender}: ");

//            List<int> contenderScores = scores[contender];
//            foreach (int score in contenderScores)
//            {
//                Console.Write($"{score} ");
//            }

//            Console.WriteLine();
//        }
//    }

//    static void Shuffle<T>(List<T> list)
//    {
//        Random random = new Random();
//        int n = list.Count;
//        while (n > 1)
//        {
//            n--;
//            int k = random.Next(n + 1);
//            T value = list[k];
//            list[k] = list[n];
//            list[n] = value;
//        }
//    }
//}
