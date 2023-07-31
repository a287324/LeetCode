#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class Solution {
public:
	int maxProfit(vector<int>& prices) {
		int buy = prices[0];
		int profit = 0, varProfit = 0;
		for(int i = 1; i < prices.size(); ++i) {
			if(buy > prices[i]) {
				buy = prices[i];
			} else {
				varProfit = prices[i] - buy;
			}
			if(varProfit > profit) {
				profit = varProfit;
			}
		}
		return profit;
	}
};
int main(void) {
	// vector<int> prices = {7,1,5,3,6,4};
	// vector<int> prices = {7,6,4,3,1};
	vector<int> prices = {2,4,1};
	Solution Obj;

	printf("%d\n", Obj.maxProfit(prices));
	return 0;
}