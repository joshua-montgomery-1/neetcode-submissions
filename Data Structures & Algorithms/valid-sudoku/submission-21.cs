public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int size = board.Length;

        for (int x = 0; x < size; x++) {
            var row = GetRow<char>(board, x);

            if (!IsSetValid(row))
                return false;
        }

        for (int y = 0; y < size; y++) {
            var column = GetColumn<char>(board, y);

            if (!IsSetValid(column))
                return false;
        }

        for (int row = 0; row < size; row += 3) {
            for (int column = 0; column < size; column += 3) {
                if (!IsSetValid(GetBox(board, row, column)))
                    return false;
            }
        }

        return true;
    }

    public bool IsSetValid(IEnumerable<char> set) {
        HashSet<char> usedValues = new HashSet<char>();
        foreach (var value in set) {
            if (value == '.')
                continue;

            if (usedValues.Contains(value))
                return false;
            
            usedValues.Add(value);
        }

        return true;
    }

    public IEnumerable<T> GetRow<T>(T[][] array, int rowIndex) {
        foreach (var i in Enumerable.Range(0, array[0].Length)) {
            yield return array[rowIndex][i];
        }
    }

    public IEnumerable<T> GetColumn<T>(T[][] array, int columnIndex) {
        foreach (var i in Enumerable.Range(0, array.Length)) {
            yield return array[i][columnIndex];
        }
    }

    public IEnumerable<T> GetBox<T>(T[][] array, int startRow, int startColumn) {
        for (int row = startRow; row < startRow + 3; row++) {
            for (int column = startColumn; column < startColumn + 3; column++) {
                yield return array[row][column];
            }
    }
}
}
