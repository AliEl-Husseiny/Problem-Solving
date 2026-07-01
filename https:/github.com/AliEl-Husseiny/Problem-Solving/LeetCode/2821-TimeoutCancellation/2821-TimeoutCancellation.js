// Last updated: 7/2/2026, 2:48:15 AM

var cancellable = function(fn, args, t) {
   
    var timeout = setTimeout(() =>
        fn(...args)
    , t)
    var cancelFn = () => clearTimeout(timeout);

    return cancelFn;
};