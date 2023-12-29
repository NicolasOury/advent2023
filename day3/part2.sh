sed  's/[^0-9*]/ DOT /g ; s/*/ SYMBOL /g ; s/\([0-9]\)/ \1 DIGIT /g ; s/$/ END-OF-ROW/' input.txt > read_grid.fs
cat lib2.fs | gforth

