module LeapYear

let isLeapYear (year: int): bool = year % 4 = 0 && (year % 100 <> 0 || year % 400 = 0)
