#include<iostream>

using namespace std;

typedef int BOOL;

#define TRUE	1
#define FALSE	0

template<class T>
class Stack
{
	public:
		T *Arr;
		int size;
		int top;
	
		Stack();
		Stack(int);
		//Stack(Stack&);

		~Stack();
	
		BOOL isStackEmpty();
		BOOL isStackFull();

		void Push(T);
		T Pop();

		void Display();
};

template<class T>
Stack<T> :: Stack()
{
	size = 10;
	Arr = new T[size];
	top = -1;
}

template<class T>
Stack<T> :: Stack(int No)
{
	size = No;
	Arr = new T[size];
	top = -1;
}

template<class T>
Stack<T> :: ~Stack()
{
	delete[]Arr;
	size = 0;
}

template<class T>
BOOL Stack<T> :: isStackFull()
{
	if(top == size - 1)
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

template<class T>
BOOL Stack<T> :: isStackEmpty()
{
	if(top == -1)
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

template<class T>
void Stack<T> :: Push(T No)
{
	if(isStackFull() == TRUE)
	{
		return;
	}
	
	top++;
	Arr[top] = No;
}

template<class T>
T Stack<T> :: Pop()
{
	if(isStackEmpty() == TRUE)
	{
		return -1;
	}

	T value = Arr[top];
	top--;
	
	return value;
}

template<class T>
void Stack<T> :: Display()
{
	for(int i = 0; i <= top; i++)
	{
		cout<<Arr[i];
	}
}

int main()
{
	Stack <int> iobj(4);

	Stack <float> fobj;
		
	Stack <char> cobj(5);

	iobj.Push(10);
	iobj.Push(20);
	iobj.Push(30);

	fobj.Push(10.0);
	fobj.Push(20.0);
	fobj.Push(30.0);

	cobj.Push('A');
	cobj.Push('B');
	cobj.Push('C');

	//Stack <float> fobj1(fobj);

	fobj.Display();

	//fobj1.Display();

	cout<<iobj.Pop();

	return 0;
}

