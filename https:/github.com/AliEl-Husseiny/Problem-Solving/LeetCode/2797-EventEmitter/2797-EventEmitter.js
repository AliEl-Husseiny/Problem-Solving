// Last updated: 7/2/2026, 2:48:26 AM
class EventEmitter {

   constructor(){
    this.events = {};
   }

    subscribe(eventName, callback) {
        
        if(!this.events[eventName]){
            this.events[eventName] = []
        }

this.events[eventName].push(callback)

        return {
            unsubscribe: () => {
              this.events[eventName]  = this.events[eventName].filter(cb => cb !== callback)
              if(this.events[eventName].length === 0) {
delete this.events[eventName]
              }
            }
        };
    }
    

    emit(eventName, args = []) {
        if(!this.events[eventName]){
            return []
        }
        return this.events[eventName].map(callback =>callback(...args) )
    }
}