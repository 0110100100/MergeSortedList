public class Program
{
    public List<int> MergeSortedLists(List<int> a, List<int> b)
    {
        List<int> res = new List<int>();
        int i = a.Count - 1;
        int j = b.Count - 1;
        
        while (i >= 0 && j >= 0)
        {
            if (a[i] >= b[j])
            {
                res.Add(a[i]);
                i--;
            }
            else
            {
                res.Add(b[j]);
                j--;
            }
        }

        while (i >= 0)
        {
            res.Add(a[i]);
            i--;
        }

        while (j >= 0)
        {
            res.Add(b[j]);
            j--;
        }

        return res;
    }

    static void Main(string[] args)
    {

    }
}