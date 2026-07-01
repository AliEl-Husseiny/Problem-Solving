// Last updated: 7/2/2026, 2:48:07 AM
var isEmpty = function(obj) {
    for (const _ in obj) return false;
    return true;
};