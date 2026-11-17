public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rowHashSet = new HashSet<char>();
        var columnHashSet = new HashSet<char>();

        // validate rows and columns
        for(int i = 0; i < board.Length; i++){
            rowHashSet.Clear();
            columnHashSet.Clear();
            for(int j = 0; j < board[i].Length; j++) {
                if(rowHashSet.Contains(board[i][j])) {
                    return false;
                }
                else if(board[i][j] != '.') {
                    rowHashSet.Add(board[i][j]);
                }
                if(columnHashSet.Contains(board[j][i])) {
                    return false;
                }
                else if(board[j][i] != '.') {
                    columnHashSet.Add(board[j][i]);
                }
            }
        }

        // validate 3x3
        var threeByThreeHashSet = new HashSet<char>();
        for(int row = 0; row < board.Length; row +=3) {
            for(int column = 0; column < board[row].Length; column += 3){
                threeByThreeHashSet.Clear();
                for(int r = 0; r < 3; r++) {
                    for(int c = 0; c < 3; c++) {
                        if(threeByThreeHashSet.Contains(board[row + r][column + c])) {
                            return false;
                        }
                        else if(board[row + r][column + c] != '.'){
                            threeByThreeHashSet.Add(board[row + r][column + c]);
                        }
                    }
                }
            }
        }
        return true;
    }
}
