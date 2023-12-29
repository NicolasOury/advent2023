VARIABLE SCORE
0 SCORE !

: in-stack ( [s] v -- [s] b )
	depth 1 = IF 
		DROP 0 ELSE
		OVER OVER = ( [s] v b ) 
		>R SWAP >R 
		RECURSE 
 		R> SWAP R> OR  
		THEN ;

: count-success : parse-name  ;

: clear depth 0 do drop loop ;

: Card  parse-name clear ; immediate
: | 13 parse ; immediate
