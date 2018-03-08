
fp = open('AMFiles.py','r')

lines = fp.readlines()
ret = " "
for line in lines:
   for j in range(len(lines)):
     if (line[j].startswith('A')):

           ret += line
     else:
         ret +=line


fp = open('AMSeperated.txt', 'w')
fp.write(ret.strip())
fp.close()

