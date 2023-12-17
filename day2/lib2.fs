0 variable sum
0 variable reds
0 variable greens
0 variable blues

: power 
	reds @
	greens @
	blues @
	* *
        0 reds !
        0 blues !
        0 greens !
         ;
 
: Game power sum +! parse-name DROP DROP ; immediate

: red reds @ max reds ! ;
: red; red ;
: red, red ;

: green greens @ max greens ! ;
: green; green ;
: green, green ;

: blue  blues @ max blues ! ;
: blue; blue ;
: blue, blue ;

include input.txt

power 
sum @ + .
