let mutable x = 10

let addOne x = 
    x <- x + 1
    x

let y = addOne x
printf "%d %d" x y