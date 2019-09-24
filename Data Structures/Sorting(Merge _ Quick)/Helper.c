#include "Header.h"

/*********************************************** MERGE SORT **************************************************************/
void Partition(int *Arr , int i , int j)
{
	int mid = 0;

	/* length of partition should be atleast 1 */
	if (i < j)
	{
		mid = (i + j) / 2;
		/* create 1 partition from i to mid, 2nd from mid+1 to j */
		Partition(Arr , i , mid);
		Partition(Arr , (mid + 1) , j);
		Merge(Arr , i , mid , (mid + 1) , j);
	}
}

void Merge(int *Arr , int i1 , int j1 , int i2 , int j2)
{
	int k = 0 , temp[SIZE] , a = 0 , b = 0;

	a = i1;
	b = i2;

	/* compare the elements from 2 sub-arrays till elements exist in both arrays */
	while ((a <= j1) && (b <= j2))
	{
		if (Arr[a] < Arr[b])
		{
			temp[k] = Arr[a];
			k++; 
			a++;
		}
		else
		{
			temp[k] = Arr[b];
			k++; 
			b++;
		}
	}

	/* case 1, left sub-array is exhausted, copy elements of right sub-array in temp */
	while (b <= j2)
	{
		temp[k] = Arr[b];
		k++; 
		b++;
	}

	/* case 2, right sub-array is exhausted, copy elements of left sub-array in temp */
	while (a <= j1)
	{
		temp[k] = Arr[a];
		k++; 
		a++;
	}

	/* copy sorted elements from temp[] back to Arr[] at their original positions */
	k = 0;
	for (a = i1; a <= j2; a++)
	{
		Arr[a] = temp[k];
		k++;
	}
}
/*********************************************** MERGE SORT **************************************************************/


/*********************************************** QUICK SORT **************************************************************/
void Quick_Sort(int Arr[] , int l , int h)
{
	int low = l , high = h , key = 0 , temp = 0;

	key = Arr[(l + h) / 2];

	while (low <= high)
	{
		/* keep smaller elements than pivot el to left */
		while (Arr[low] < key)
		{
			low++;
		}

		/* keep larger elements than pivot el to right */
		while (Arr[high] > key)
		{
			high--;
		}

		if (low <= high)
		{
			temp = Arr[low];
			Arr[low] = Arr[high];
			Arr[high] = temp;

			low++;
			high--;
		}
	}

	/* send left & right partitions again for quick sort */
	if (l < high)
	{
		Quick_Sort(Arr , l , high);		
	}

	if (low < h)
	{
		Quick_Sort(Arr , low , h);
	}
}
/*********************************************** QUICK SORT **************************************************************/

