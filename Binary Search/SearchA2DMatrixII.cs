public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {        
        int row = 0;
        int col = matrix[0].Length-1;
        
        while (row < matrix.Length && col >= 0)
        {
            if (target == matrix[row][col]) return true;
            
            if (target > matrix[row][col]) 
                row++;
            else
                col--;            
        }
        return false;    
    }
}