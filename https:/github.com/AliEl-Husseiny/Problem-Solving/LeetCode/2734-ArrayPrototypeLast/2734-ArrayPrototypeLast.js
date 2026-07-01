// Last updated: 7/2/2026, 2:48:43 AM
Array.prototype.last = function () {
  return this.length === 0 ? -1 : this[this.length - 1];
};

// ✅ Example 1:
let nums1 = JSON.parse('[null, {}, 3]');
console.log(nums1.last()); // Output: 3

// ✅ Example 2:
let nums2 = JSON.parse('[]');
console.log(nums2.last()); // Output: -1