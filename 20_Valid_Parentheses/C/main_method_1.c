#include <stdio.h>
#include <string.h>
#include <stdbool.h>

#define MAX_SIZE 10000
char stack[MAX_SIZE];
int stackIndex = -1;

void push(char letter) {
	if(stackIndex < MAX_SIZE) {
		stackIndex++;
		stack[stackIndex] = letter;
	}
}
void pop(void) {
	if(stackIndex > -1) {
		stackIndex--;
	}
}
char peek(void) {
	if(stackIndex > -1) {
		return stack[stackIndex];
	}
	return '\0';
}
bool isEmpty(void) {
	return (stackIndex == -1) ? (true) : (false);
}
bool isValid(char * s){
	stackIndex = -1;	// 在LeetCode執行程式，如果不加上這行，會出現錯誤，可能是因為stackIndex是全域變數，LeetCode在調用函數時，只會不停調用isValid，所以不會重置全域變數(stackIndex)
	int sLen = strlen(s);
	for(int i = 0; i < sLen; ++i) {
		if(s[i] == '(' || s[i] == '[' || s[i] == '{') {
			push(s[i]);
		} else {
			if(isEmpty()) return false;
			if(s[i] == ')' && peek() != '(') return false;
			if(s[i] == ']' && peek() != '[') return false;
			if(s[i] == '}' && peek() != '{') return false;
			pop();
		}
	}
	return (isEmpty()) ? (true) : (false);
}

int main () {
	// char s[] = "()";
	// char s[] = "()[]{}";
	// char s[] = "(]";
	// char s[] = "(";
	char s[] = "{[]}";

	if(isValid(s)) {
		printf("True\n");
	} else {
		printf("False\n");
	}

	return 0;
}