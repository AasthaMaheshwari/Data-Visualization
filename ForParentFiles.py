
fs = open ("1.txt",'r')

parent = {}
parentList = []
prev = None
from itertools import islice
with open('1.txt') as fin:
    for line in islice(fin, 1,86):
        tmp = line.split('/')
        parentID = tmp[0].strip()
        parentList.append(parentID)
        parent[parentID] = ' '
        if prev is None or prev == line[parentID]:
            parent[parentID] +=  line
            ret = " "
            ret += parentID

            fo = open('parentFiles.txt', 'w')
            fo.write(ret)
            fo.close()

fs.close()

