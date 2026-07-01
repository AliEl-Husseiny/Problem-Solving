// Last updated: 7/2/2026, 2:48:03 AM
public class Solution {
    public int MaximumSafenessFactor(IList<IList<int>> grid) {
        int n = grid.Count;
        int[][] dist = new int[n][];
        for (int i = 0; i < n; i++) {
            dist[i] = new int[n];
            for (int j = 0; j < n; j++) {
                dist[i][j] = int.MaxValue;
            }
        }
        
        Queue<(int, int)> queue = new Queue<(int, int)>();
        int[][] dirs = new int[][] { new int[]{1,0}, new int[]{-1,0}, new int[]{0,1}, new int[]{0,-1} };
        
        // Initialize queue with all thieves
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1) {
                    dist[i][j] = 0;
                    queue.Enqueue((i, j));
                }
            }
        }
        
        // Multi-source BFS for distance to nearest thief
        while (queue.Count > 0) {
            var (r, c) = queue.Dequeue();
            foreach (var d in dirs) {
                int nr = r + d[0];
                int nc = c + d[1];
                if (nr >= 0 && nr < n && nc >= 0 && nc < n && dist[nr][nc] == int.MaxValue) {
                    dist[nr][nc] = dist[r][c] + 1;
                    queue.Enqueue((nr, nc));
                }
            }
        }
        
        // Binary search for max safeness factor
        int low = 0, high = dist[0][0];
        int answer = 0;
        while (low <= high) {
            int mid = (low + high) / 2;
            if (CanReach(dist, n, mid)) {
                answer = mid;
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        return answer;
    }
    
    private bool CanReach(int[][] dist, int n, int minDist) {
        if (dist[0][0] < minDist || dist[n-1][n-1] < minDist) return false;
        
        bool[][] visited = new bool[n][];
        for (int i = 0; i < n; i++) visited[i] = new bool[n];
        
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((0,0));
        visited[0][0] = true;
        
        int[][] dirs = new int[][] { new int[]{1,0}, new int[]{-1,0}, new int[]{0,1}, new int[]{0,-1} };
        
        while (queue.Count > 0) {
            var (r, c) = queue.Dequeue();
            if (r == n-1 && c == n-1) return true;
            foreach (var d in dirs) {
                int nr = r + d[0];
                int nc = c + d[1];
                if (nr >= 0 && nr < n && nc >= 0 && nc < n && !visited[nr][nc] && dist[nr][nc] >= minDist) {
                    visited[nr][nc] = true;
                    queue.Enqueue((nr, nc));
                }
            }
        }
        return false;
    }
}