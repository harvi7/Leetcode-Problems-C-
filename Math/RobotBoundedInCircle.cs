public class Solution {
    public bool IsRobotBounded(string instructions) {
        int x = 0, y = 0, i = 0;
        int[,] d = new int[,]{{0, 1}, {1, 0}, {0, -1}, { -1, 0}};
        foreach(char c in instructions)
        {
            if (c == 'R')
                i = (i + 1) % 4;
            else if (c == 'L')
                i = (i + 3) % 4;
            else {
                x += d[i, 0]; y += d[i, 1];
            }
        }
        return x == 0 && y == 0 || i > 0;
    }
}