#include <stdio.h>
#include <string.h>
#include <stdbool.h>

bool isAnagram(char * s, char * t){
	int sLen = strlen(s);
	// check length
	if(sLen != strlen(t)) {
		return false;
	}
	// check letter
	int countS[26] = {0};
	int countT[26] = {0};
	for(int i = 0; i < sLen; ++i) {
		countS[s[i] - 'a']++;
		countT[t[i] - 'a']++;
	}
	for(int i = 0; i < 26; ++i) {
		if(countS[i] != countT[i]) {
			return false;
		}
	}
	return true;
}

int main () {
	// char s[] = "anagram", t[] = "nagaram";
	char s[] = "rat", t[] = "car";

	if(isAnagram(s,t)) {
		printf("True\n");
	} else {
		printf("False\n");
	}

	return 0;
}