#include <iostream>
#include <cstring>
#include <stack>
#include <algorithm>

using namespace std;
// 說明: https://youtu.be/BLUj14tLhv8?t=3459
class Solution {
public:
	int maxSubArray(vector<int>& nums) {
		int curr = -10e5;
		int max = -10e5;
		int reg;
		for(int i = 0; i < nums.size(); ++i) {
			reg = curr + nums[i];
			curr = (reg < nums[i]) ? (nums[i]) : (reg);	//
			if(max < curr) {
				max = curr;
			}
		}
		return max;
	}
};
int main(void) {
	// vector<int> nums = {-2,1,-3,4,-1,2,1,-5,4};
	vector<int> nums = {1};
	// vector<int> nums = {5,4,-1,7,8};
	Solution obj;

	printf("%d\n", obj.maxSubArray(nums));
	return 0;
}