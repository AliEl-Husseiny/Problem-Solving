// Last updated: 7/2/2026, 2:48:38 AM
/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function(arr, fn) {
    let fil=[]
    for(let i=0;i<arr.length;i++){
        if(fn(arr[i],i)){
            fil.push(arr[i]);
        }
    }
    return fil
};