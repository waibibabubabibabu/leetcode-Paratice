public class RandomizedSet
{
    HashSet<int> hash;
    int seed;
    public RandomizedSet()
    {
        hash = new HashSet<int>();
        seed = 0;
    }

    public bool Insert(int val)
    {
        if (hash.Contains(val) == true) return false;
        else { hash.Add(val); return true; }
    }

    public bool Remove(int val)
    {
        if (hash.Contains(val) == false) return false;
        else
        {
            hash.Remove(val);
            return true;
        }
    }

    public int GetRandom()//count>=1
    {
        Random rd = new Random();
        seed++;//实现真正的随机，但事实上官方题解只需要伪随机
        int random = rd.Next(hash.Count);
        int[] nums = new int[hash.Count];
        hash.CopyTo(nums);//每次复制太麻烦了
        return nums[random];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */

public class RandomizedSet2
{//因为每次copy数组太麻烦，因此这次共同维护两个数据结构
    Dictionary<int, int> dictionary;
    IList<int> nums;
    Random rand;
    public RandomizedSet2()
    {
        dictionary = new Dictionary<int, int>();
        nums = new List<int>();
        rand = new Random();//官方题解只需要伪随机
    }

    public bool Insert(int val)
    {
        if (dictionary.ContainsKey(val) == true) return false;
        int index = dictionary.Count;
        nums.Add(val);
        dictionary.Add(val, index);
        return true;
    }

    public bool Remove(int val)
    {
        if (dictionary.ContainsKey(val) == false) return false;
        int index = dictionary[val];
        //nums.RemoveAt(index);不能直接移除，要不random的取随机数就不好取了
        //更新dic的index信息，是最后一位的
        dictionary[nums[dictionary.Count-1]]=index;
        nums[index] = nums[dictionary.Count-1];//已经减了1
        nums.RemoveAt(dictionary.Count-1);
        dictionary.Remove(val);
        return true;
    }

    public int GetRandom()
    {
        int random = rand.Next(dictionary.Count);
        return nums[random];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */