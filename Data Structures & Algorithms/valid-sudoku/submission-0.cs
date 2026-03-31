public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        HashSet<char>[] row = new HashSet<char>[9]; 
        HashSet<char>[] column = new HashSet<char>[9];
        HashSet<char>[] box = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            row[i] = new HashSet<char>();
            column[i] = new HashSet<char>();
            box[i] = new HashSet<char>();
        }

        for(int c = 0; c < 9; c++){

            for(int r = 0; r < 9; r++){

                if(board[r][c] == '.') continue;

                int boxIndex = (r / 3) * 3 + (c / 3);
                char value = board[r][c]; 

                if(
                    row[r].Contains(value) ||
                    column[c].Contains(value) ||
                    box[boxIndex].Contains(value)
                ){
                    return false;

                }
                    

                row[r].Add(value);
                column[c].Add(value);
                box[boxIndex].Add(value);
                

            }
        }
        
        return true;
    }
}
