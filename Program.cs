
    bool IsMatch(string s, string p) 
    {   
        Dictionary<(int i, int j), bool> hashTable = new();
        bool dfs(int i, int j)
        {
            if(i >= s.Length && j >= p.Length)
                return true;
            if(j >= p.Length)
                return false;

            if(hashTable.ContainsKey((i, j)))
                return hashTable[(i, j)];
            
            bool match = false;
            if(i < s.Length)
                match = p[j] == s[i] || p[j] == '.';

            if(j + 1 < p.Length && p[j+1] == '*')
            {
                if(!match)
                {
                    hashTable[(i, j)] = dfs(i, j+2);
                    return hashTable[(i, j)];
                }
                else
                {
                    hashTable[(i, j)] = dfs(i+1, j);
                    return hashTable[(i, j)];
                }
            }

            if(match)
            {
                hashTable[(i, j)] = dfs(i+1, j+1);
                return hashTable[(i, j)];
            }

            return false;
        }

        return dfs(0, 0);
    }

Console.WriteLine(IsMatch("aab", "c*a*b"));

