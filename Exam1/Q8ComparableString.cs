namespace Exam1;

public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        if (x != null && y == null){
            return 1;
        }
        if (x?.Length > y?.Length){
            return 1;
        }
        else if (x?.Length == y?.Length){
            for (int i = 0; i < x?.Length; i++){
                if (x?[i] > y?[i]){
                    return 1;
                }
                else if (x?[i] < y?[i]){
                    return -1;
                }
            }
            return 0;
        }
        else{
            return -1;
        }
    }
}
public class Q8ComparableString : IComparable<Q8ComparableString>{
    public string data;
    public Q8ComparableString(string word){
        this.data = word;
    }
    public static bool operator>(Q8ComparableString a, Q8ComparableString b){
        if (a.CompareTo(b) > 0){
            return true;
        }
        else if (a.CompareTo(b) < 0){
            return false;
        }
        return false;
    }
    public static bool operator<(Q8ComparableString a, Q8ComparableString b){
        if (a.CompareTo(b) < 0){
            return true;
        }
        else if (a.CompareTo(b) > 0){
            return false;
        }
        return false;
    }
    public static bool operator==(Q8ComparableString a, Q8ComparableString b){
        if (a.CompareTo(b) == 0){
            return true;
        }
        return false;
    }
    public static bool operator!=(Q8ComparableString a, Q8ComparableString b){
        if (a.CompareTo(b) != 0){
            return true;
        }
        return false;
    }
    public int CompareTo(Q8ComparableString x, Q8ComparableString y)
    {
        if (x.data != null && y.data == null){
            return 1;
        }
        if (x.data?.Length > y.data?.Length){
            return 1;
        }
        else if (x.data?.Length == y.data?.Length){
            for (int i = 0; i < x.data?.Length; i++){
                if (x.data?[i] > y.data?[i]){
                    return 1;
                }
                else if (x.data?[i] < y.data?[i]){
                    return -1;
                }
            }
            return 0;
        }
        else{
            return -1;
        }
    }

    public int CompareTo(Q8ComparableString other)
    {
        if (this.data != null && other.data == null){
            return 1;
        }
        if (this.data?.Length > other.data?.Length){
            return 1;
        }
        else if (this.data?.Length == other.data?.Length){
            for (int i = 0; i < this.data?.Length; i++){
                if (this.data?[i] > other.data?[i]){
                    return 1;
                }
                else if (this.data?[i] < other.data?[i]){
                    return -1;
                }
            }
            return 0;
        }
        else{
            return -1;
        }
    }
}