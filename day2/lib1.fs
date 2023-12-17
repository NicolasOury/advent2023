0 variable sum
: maybe-add IF sum +! ELSE DROP THEN ;
: Game maybe-add parse-name 1 - S>NUMBER DROP -1 ; immediate

: red; 12 <= and ;
: red, 12 <= and ;
: red 12 <= and ;

: green; 13 <= and ;
: green, 13 <= and ;
: green 13 <= and ;

: blue; 14 <= and ;
: blue, 14 <= and ;
: blue 14 <= and ;

0 0
include input.txt

maybe-add

sum @ .
