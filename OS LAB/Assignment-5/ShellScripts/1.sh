# !/bin/bash

echo "Enter Marks 1" 
read m1
echo "Enter Marks 2" 
read m2
echo "Enter Marks 3" 
read m3
total=$(expr $m1 + $m2 + $m3)
 per=$(expr $total / 3)
if [ $per -ge 70 ]
then
echo "You Got Distinction"
elif [ $per -ge 60 ]
then
echo "You Got 1st Class" 
elif [ $per -ge 50 ]
then
echo "You Got 2nd Class" 
else
echo "You Failed" 
fi
