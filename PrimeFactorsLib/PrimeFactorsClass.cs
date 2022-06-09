namespace PrimeFactorsLib
{
    public class PrimeFactorsClass
    {
        public string PrimeFactors(int a)
        {
            List<int> primeFactors = new List<int> {};
            int n = 2;
            int newA = a;
            while (n <= a / 2) {
                if (newA % n != 0) {
                    n++;
                    continue;
                }
                primeFactors.Add(n);
                newA /= n;
            }
            if (newA != 1)
            {
                primeFactors.Add(newA);
            }
            primeFactors.Reverse();
            return String.Join(" x ", primeFactors);
        }
    }
}