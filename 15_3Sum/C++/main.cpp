#include <iostream>
#include <map>
#include <vector>
#include <algorithm>

using namespace std;
class Solution {
public:
    vector<vector<int>> threeSum(vector<int>& nums) {
		vector<vector<int>> ans;
		int numsLen = nums.size();

		// 如果長度小於3
		if(nums.size() < 3) {
			return ans;
		}
		// 排序
        sort(nums.begin(), nums.end());
		// 檢查最小值是否大於0
		if(nums[0] > 0) {
			return ans;
		}
		// 檢查最大值是否小於0
		if(nums[numsLen-1] < 0) {
			return ans;
		}
		// 搜尋解
		for(int i = 0; i < nums.size()-2; ++i) {
			int left = i + 1;
			int right = nums.size()-1;
			// 如果
			if(i > 0 && nums[i] == nums[i-1]) {
				continue;
			}
			while(left < right) {
				// 計算總和
				int reg = nums[i] + nums[left] + nums[right];

				// 判斷總和
				if(reg == 0) {
					ans.push_back({nums[i], nums[left], nums[right]});
				}
				// 更改旗標位置
				if(reg <= 0) {
					do {
						left++;
					}while(left < nums.size() && nums[left] == nums[left-1]);
				}
				if(reg >= 0) {
					do {
						right--;
					}while(right > 0 && nums[right] == nums[right+1]);
				}
			}
		}
		return ans;
    }
};
int main(void) {
	vector<int> nums = {-1,0,1,2,-1,-4};

	Solution Obj;

	vector<vector<int>> ans = Obj.threeSum(nums);
	if(ans.size() == 0) {
		printf("no solution\n");
	}
	for(int i = 0; i < ans.size(); ++i) {
		for(int j = 0; j < ans[i].size(); ++j) {
			printf("%3d", ans[i][j]);
		}
		printf("\n");
	}
	return 0;
}
