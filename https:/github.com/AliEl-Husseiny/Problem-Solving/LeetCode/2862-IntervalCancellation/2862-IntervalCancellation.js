// Last updated: 7/2/2026, 2:48:10 AM
var cancellable = function(fn, args, t) {
    fn(...args);
    let timer = setInterval(() => fn(...args), t);

    let cancelFn = () => clearInterval(timer);
    return cancelFn;
};