# ID and Log dictionary
fo = open('GITLog.txt','r')
ids = {}
log = {}
id = 1
line = fo.readline()
while(line):
	tmp = line.split(' ',1)
	commitid = tmp[0]
	ids[commitid] = id
	log[commitid] = tmp[1].strip()
	id+=1
	line = fo.readline()
fo.close()


# Author Dictionary
fo = open('GITAuthor.txt','r')
author = {}
line = fo.readline()
while(line):
	tmp = line.strip().split(' ',1)
	commitid = tmp[0]
	author[commitid] = tmp [1]
	line = fo.readline()
fo.close()


# Date Dictionary
fo = open('GITDate.txt','r')
date = {}
line = fo.readline()
while(line):
	tmp = line.strip().split(' ',2)
	commitid = tmp[0]
	date[commitid] = tmp[2]
	line = fo.readline()
fo.close()

# Files Dictionary

commit = []

fo = open('GITFiles.txt','r')
file = {}
content = fo.read().strip()
lines = content.split('\n')
n = len(lines)
for i in range(n):
	line = lines[i]
	if(line.startswith('A') | line.startswith('M') | line.startswith('D') | line.startswith('R')):
		file[commitid] = file[commitid] + line + '\n'
	else:
		tmp = line.split()
		commitid = tmp[0]
		commit.append(commitid)
		file[commitid] = ''
fo.close()

# Combining dictionaries

commit = author.keys()
n = len(commit)
ret = ''
for i in range(n):
	commits = commit[i]
	authors = author[commits]
	logs = log[commits]
	dates = date[commits]
	files = file[commits]
	files = files.strip().replace('\n',',').replace('\t',' ')
	tmp_ids = ids[commits]
	ret += str(tmp_ids) + ';' + commits + ';' + authors + ';' + dates + ';' + logs + ';' + files + '\n'
ret = ret.strip()

# Writing to end log file
fo = open('GITComplete.txt','w')
fo.write(ret)
fo.close()

