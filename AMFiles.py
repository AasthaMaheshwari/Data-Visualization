#open the file 
#make changes 
#save it after every change 
#
fp = open('logSorted.txt','r')

lines = fp.readlines()
ret = " "
for line in lines:
   for j in range(len(lines)):
     if (line[j].startswith('A') | line[j].startswith('M')):

           ret += line

fp = open('newAMfiles.txt', 'w')
fp.write(ret.strip())
fp.close()



