

fs = open("1.txt",'r')
child = {}
childList = []
prev = None
from itertools import islice
with open('1.txt') as fin:
    for line in islice(fin, 1,86):
        tmp = line.split('/')
        if len(tmp[1]) == 0:
            break
        else:
            childID = tmp[1].strip()
            childList.append(childID)
            child[childID] = ' '

        if(prev == line[childID]):
            child[childID] += line
            ret = " "
            ret += childID

            fo = open('childFiles.txt', 'w')
            fo.write(ret)
            fo.close()

fs.close()

