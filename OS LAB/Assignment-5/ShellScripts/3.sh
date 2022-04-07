##Display the name of the file which was last modified by taking the directory name from user.
clear
echo -e "\n Enter the full path to the destination directory"
read dirname
cd $dirname
ls -t | head -1
