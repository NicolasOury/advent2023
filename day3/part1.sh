sed  's/[^0-9.]/ SYMBOL/g ; s/\./ DOT /g ; s/\([0-9]\)/ \1 DIGIT /g ; s/$/ END-OF-ROW/' input.txt > read_grid.fs
cat lib1.fs | gforth

