namespace Vitor.Hackerrank.Challenges.CountingValleys
{
    public static class Result
    {
        public static int countingValleys(int steps, string path)
        {
            var currentAltitude = 0;
            var totalVallyes = 0;

            for (var i = 0; i < steps; i++)
            {
                currentAltitude += path[i] == 'U' ? 1 : -1;
                if (currentAltitude == 0 && path[i] == 'U')
                    totalVallyes++;
            }

            return totalVallyes;
        }
    }
}
