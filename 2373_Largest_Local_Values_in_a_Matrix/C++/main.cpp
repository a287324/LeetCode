#include <iostream>
#include <unordered_map>
#include <vector>

using namespace std;

class Solution {
	public:
		vector<vector<int>> largestLocal(vector<vector<int>>& grid) {
			const int n = grid.size();
			vector<vector<int>> ans(n-2, vector<int>(n-2));
			for(int i = 0; i < n-2; ++i) {
				for(int j = 0; j < n-2; ++j) {
					for(int x = i; x <= i+2; ++x) {
						for(int y = j; y <= j+2; ++y) {
							ans[i][j] = max(ans[i][j], grid[x][y]);
						}
					}
				}
			}
			return ans;
		}
};
int main(void) {
	vector<vector<int>> matrix = {{9,9,8,1},{5,6,2,6},{8,2,6,4},{6,2,2,2}};
	vector<vector<int>> ans;
	Solution Obj;

	ans = Obj.largestLocal(matrix);

	for(const auto& row : ans) {
		for(const auto& val : row) {
			printf("%5d", val);
		}
		printf("\n");
	}
	return 0;
}