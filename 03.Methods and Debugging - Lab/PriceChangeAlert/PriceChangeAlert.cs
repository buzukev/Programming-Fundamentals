using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double diff = GetPercentDiff(lastPrice, currentPrice);
            bool isSignificantDifference = isDifference(diff, threshold);
            string message = GetMessage(currentPrice, lastPrice, diff, isSignificantDifference);
            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }
    private static double GetPercentDiff(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) / lastPrice;
        return result;
    }
    private static bool isDifference(double diff, double threshold)
    {
        if (Math.Abs(diff) >= threshold)
        {
            return true;
        }
        return false;
    }
    private static string GetMessage(double currentPrice, double lastPrice, double diff, bool isSignificantDifference)
    {
        string result = "";
        if (diff == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diff*100);
        }
        else if (isSignificantDifference && (diff > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diff*100);
        }
        else if (isSignificantDifference && (diff < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diff*100);
        }
        return result;
    }
}