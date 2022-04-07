clear 
echo -e "\n1. File Listing" 
echo "2. Create Directory"
echo "3. View File Content"
echo "4. Copy File"
echo "5. Delete File"
echo -e "\n Enter Your Choice[1-5] "
read ch
case $ch in
1)ls;;
2)echo "Enter Directory Name"
read d mkdir $d;;
3)echo "Enter File Name"
read f mkdir $f;;
4)echo "Enter Source" read s
echo "Enter Destination"
read df cp $s $df;;
5)echo "Enter file Name"
read f rm $f;;
*)echo "Invalid Choice"
esac
