#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class Solution {
public:
	vector<int> productExceptSelf(vector<int>& nums) {
		int n = nums.size();
		vector<int> res(n, 1);
		int left = 1, right = 1;
		for (int i = 0; i < n; i++) {
			res[i] *= left;
			left *= nums[i];
			res[n - 1 - i] *= right;
			right *= nums[n - 1 - i];
		}
		return res;
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