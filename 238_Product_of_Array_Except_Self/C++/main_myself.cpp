#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
		// 先計算所有元素的乘積
		int numsLen = nums.size();
		int flag0 = 0;
		int flag0Index = -1;
		int product = 1;
		vector<int> ans(numsLen, 0);
		for(int i = 0; i < numsLen; ++i) {
			if(nums[i] != 0) {
				product*=nums[i];
			} else {
				flag0++;	// 計算0的個數
				flag0Index = i;
				if(flag0 > 1) {
					return ans;
				}
			}
		}
		// 計算結果
		if(flag0 == 1) {
			ans[flag0Index] = product;
			return ans;
		}
		for(int i = 0; i < numsLen; ++i) {
			ans[i] = product / nums[i];
		}
		return ans;
    }
};
int main(void) {
	vector<int> nums = {1,2,3,4};
	// vector<int> nums = {-1,1,0,-3,3};
	Solution obj;

	printf("nums\n");
	for(const auto& n : nums) {
		printf("%5d", n);
	}
	printf("\n");

	printf("ans\n");
	vector<int> ans = obj.productExceptSelf(nums);
	for(const auto& n : ans) {
		printf("%5d", n);
	}
	return 0;
}