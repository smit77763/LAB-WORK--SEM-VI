#Display the name & size of the Files which occupies the max & min disk space.

a=`ls -S1r | head -1`
b=`ls -S1 | head -1`
echo "$a is the file with minimum disk space"
echo "$b is the file with maximum disk space"
