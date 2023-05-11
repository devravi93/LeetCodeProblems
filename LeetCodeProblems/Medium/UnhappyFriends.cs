namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/count-unhappy-friends/
    /// Problem Statement : You are given a list of preferences for n friends, where n is always even.
    /// For each person i, preferences[i] contains a list of friends sorted in the order of preference.In other words, 
    /// a friend earlier in the list is more preferred than a friend later in the list. Friends in each list are denoted by integers from 0 to n-1.
    /// All the friends are divided into pairs.The pairings are given in a list pairs, where pairs[i] = [xi, yi] denotes xi is paired with yi and yi is paired with xi.
    /// However, this pairing may cause some of the friends to be unhappy. A friend x is unhappy if x is paired with y and there exists a friend u who is paired with v but:
    /// x prefers u over y, and u prefers x over v. Return the number of unhappy friends.
    /// </summary>
    public class UnhappyFriends
    {
        public int Process(int n, int[][] preferences, int[][] pairs)
        {
            int unHappy = 0;

            for (int i = 0; i < n; i++)
            {
                var pref = preferences[i];
                var pair = findPair(pairs, i);
                var otherIndividual = pair.First(t => t != i);
                var otherPref = preferences[otherIndividual];

                var indexOfOther = pref.ToList().IndexOf(otherIndividual);
                if (indexOfOther == 0)
                    continue;

                if (indexOfOther == -1)
                {
                    unHappy++;
                    continue;
                }

                var preferedFriends = pref.Take(new Range(0, indexOfOther));

                foreach (var preferedFriend in preferedFriends)
                {
                    var friendsPref = preferences[preferedFriend];
                    var friendsPair = findPair(pairs, preferedFriend);
                    var friendsOtherIndividual = friendsPair.First(t => t != preferedFriend);
                    var friendsIndexOfOther = friendsPref.ToList().IndexOf(friendsOtherIndividual);

                    if (friendsIndexOfOther == 0)
                        continue;

                    var indexOfCurrent = friendsPref.ToList().IndexOf(i);
                    if (indexOfCurrent < friendsIndexOfOther)
                    {
                        unHappy++;
                        break;
                    }
                }
            }

            return unHappy;
        }

        private int[] findPair(int[][] pairs, int i)
        {
            foreach (var pair in pairs)
            {
                if (pair[0] == i || pair[1] == i)
                    return pair;
            }

            return new int[] { };
        }
    }
}
