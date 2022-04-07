echo "Enter file name to delete"
read f
echo "Are you sure want to delete[y/n]"
read ch 
if test $ch='y'
then rm $f 
else exit 
fi
