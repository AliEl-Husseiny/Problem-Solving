// Last updated: 7/2/2026, 2:48:47 AM
/**
 * @param {Function} fn
 * @return {Function}
 */
function memoize(fn) {
    
     const cache = new Map();

    return function(...args) {
        let key = args.toString();

        if (cache[key] !== undefined) {
            return cache[key]; 
        }

        let result = fn(...args); 
        cache[key] = result;      
        return result;
    };
}


/** 
 * let callCount = 0;
 * const memoizedFn = memoize(function (a, b) {
 *	 callCount += 1;
 *   return a + b;
 * })
 * memoizedFn(2, 3) // 5
 * memoizedFn(2, 3) // 5
 * console.log(callCount) // 1 
 */