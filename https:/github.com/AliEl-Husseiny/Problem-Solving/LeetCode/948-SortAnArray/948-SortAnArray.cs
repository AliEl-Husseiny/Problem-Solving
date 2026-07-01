// Last updated: 7/2/2026, 2:50:11 AM
public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }
    
    private void MergeSort(int[] nums, int left, int right) {
        if (left >= right) return;
        
        int mid = left + (right - left) / 2;
        
        MergeSort(nums, left, mid);
        MergeSort(nums, mid + 1, right);
        
        Merge(nums, left, mid, right);
    }
    
    private void Merge(int[] nums, int left, int mid, int right) {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        
        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];
        
        for (int i = 0; i < n1; i++) {
            leftArr[i] = nums[left + i];
        }
        for (int j = 0; j < n2; j++) {
            rightArr[j] = nums[mid + 1 + j];
        }
        
        int p = 0, q = 0, k = left;
        
        while (p < n1 && q < n2) {
            if (leftArr[p] <= rightArr[q]) {
                nums[k] = leftArr[p];
                p++;
            } else {
                nums[k] = rightArr[q];
                q++;
            }
            k++;
        }
        
        while (p < n1) {
            nums[k] = leftArr[p];
            p++;
            k++;
        }
        
        while (q < n2) {
            nums[k] = rightArr[q];
            q++;
            k++;
        }
    }
}