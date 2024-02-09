VARIABLE SCORE
0 SCORE !

VARIABLE CARDS 9 CELLS ALLOT
 
CARDS 9 CELLS -1 FILL

: is-winning ( value -- bool ) 
	0 \ not winning so far (and we 
	10 0 DO 
		OVER CARDS I CELLS + @ = OR 
	     LOOP
	NIP ;


: increase-score ( score -- new-score )
	DUP 0= IF DROP 1 ELSE 1 lshift THEN ;
	

: count-score ( n1 n2 n3 .... nn score -- score )
	depth 1 > IF 
			SWAP IS-WINNING IF INCREASE-SCORE THEN 
			RECURSE 
		THEN ;

: | 10 0 DO 
  	   CARDS I CELLS + !
         LOOP ; 

: Card  parse-name 
   0 count-score SCORE +!  
   ; immediate
   

include input.txt

0 count-score SCORE +!
SCORE @  .
