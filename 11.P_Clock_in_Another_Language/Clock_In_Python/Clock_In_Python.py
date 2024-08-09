class Counter:
    def __init__(self):
        self.name = None
        self.count = 0
    
    @property
    def ticks(self):
        return self.count
    
    def get_name(self):
        return self.name
    
    @property
    def set_name(self, value):
        self.increment()
        self.name = value
    
    def initialize(self, name):
        self.name = name
        self.count = 0
        
    def increment(self):
        self.count += 1
        
    def reset(self):
        self.count = 0

class Clock:
    
    def __init__(self):
        self.hour = Counter()
        self.minute = Counter()
        self.second = Counter()
        
    def tick(self):
        self.second.increment()
        if self.second.ticks == 60:
            self.second.reset()
            self.minute.increment()
            if self.minute.ticks == 60:
                self.minute.reset()
                self.hour.increment()
    
    def reset(self):
        self.hour.reset()
        self.minute.reset()
        self.second.reset()
        
    @property
    def time(self):
        return f"{self.hour.ticks:02}:{self.minute.ticks:02}:{self.second.ticks:02}"
    
if __name__ == "__main__":
    clock = Clock()

    for x in range (3700):
        clock.tick()
        print(clock.time)
    
    myCounter = Counter()
    myCounter.increment()