VARIABLE SUM
0 SUM !
VARIABLE CURRENT-NUMBER
VARIABLE INCLUDED-NUMBER
VARIABLE X
VARIABLE Y

: NUMBER-ENDED 
	INCLUDED-NUMBER @ 
		IF CURRENT-NUMBER @ SUM +! THEN
	0 INCLUDED-NUMBER !
        0 CURRENT-NUMBER ! ;

: END-OF-ROW
	1 Y +!
       ; 

: DOT NUMBER-ENDED 1 X +! ;
: DIGIT CURRENT-NUMBER @ 10 * + CURRENT-NUMBER ! 1 X +! ;
: SYMBOL NUMBER-ENDED 1 X +! ;

include read_grid.fs

VARIABLE WIDTH
X @ Y @ /  WIDTH !

VARIABLE HEIGHT
Y @    HEIGHT !

HEIGHT @ 2 + CONSTANT A-HEIGHT
WIDTH @ 2 + CONSTANT A-WIDTH
A-HEIGHT A-WIDTH * CONSTANT SIZE

VARIABLE SYMBOLS SIZE CELLS ALLOT
VARIABLE NEIGHBOUR1 SIZE CELLS ALLOT
VARIABLE NEIGHBOUR2 SIZE CELLS ALLOT

SYMBOLS SIZE CELLS ERASE
NEIGHBOUR1 SIZE 1 + CELLS ERASE
NEIGHBOUR2 SIZE 1 + CELLS ERASE

: A-SET ( v addr x y -- ) A-HEIGHT * + CELLS + ! ;
: A-GET ( addr x y -- v)  A-HEIGHT * + CELLS + @ ;

: END-OF-ROW
	NUMBER-ENDED
	1 Y +!
	1 X !
       ;
1 X !
1 Y !

: SYMBOL NUMBER-ENDED -1 SYMBOLS X @ Y @ A-SET 1 X +! ;
include read_grid.fs

0 CURRENT-NUMBER !
0 INCLUDED-NUMBER !

: INCLUDE-IF-NEIGHBOUR-IS-SYMBOL ( x y -- )
	2 -1 DO 
		OVER I + 
		2 -1 DO 
			OVER I +
			OVER SWAP 
			SYMBOLS ROT ROT A-GET INCLUDED-NUMBER @ OR INCLUDED-NUMBER ! 
			LOOP
			DROP
		LOOP DROP DROP ;
	
: DIGIT CURRENT-NUMBER @ 10 * + CURRENT-NUMBER !
	X @ Y @  INCLUDE-IF-NEIGHBOUR-IS-SYMBOL 
 	1 X +! ;

1 X !
1 Y !

include read_grid.fs

SUM @ .
