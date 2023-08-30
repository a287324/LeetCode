#include <iostream>
#include <unordered_map>
#include <vector>

using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        vector<int> ans;
        unordered_map<int, int> repeat;
        for(int i = 0; i < nums.size(); ++i) {
            if(repeat.count(nums[i])) {
                ans.push_back(repeat[nums[i]]);
                ans.push_back(i);
				return ans;
            }
            repeat[target - nums[i]] = i;
        }
        return ans;
    }
};
int main(void) {
	vector<int> nums = {2, 11, 15, 7};
	int target = 9;
	vector<int> ans;
	Solution Obj;

	ans = Obj.twoSum(nums, target);

	for(const int& n : ans) {
		cout << n << endl;
	}
	return 0;
}