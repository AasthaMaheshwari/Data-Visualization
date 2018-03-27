import sys,os

inFile = 'logSorted.txt'
existingFiles = {}

fs = open(inFile, 'r')

line = fs.readline()
while(line):
	tmp = line.split(';')
	id = tmp[0].strip()
	commitId = tmp[1].strip()
	author = tmp[2].strip()
	time = tmp[3].strip()
	log = tmp[4].strip()
	changedFiles = tmp[5].strip()
	if len(changedFiles) > 0:
		tmp2 = changedFiles.split(',')
		for file in tmp2:
			tmp3 = file.split(' ', 1)
			flag = tmp3[0]
			filename = tmp3[1]
			if flag == 'A':
				existingFiles[filename] = 1
			elif flag == 'D':
				existingFiles[filename] = 0
	outFile = id + '.txt'
	ret = commitId + ';' + author + ';' + time + ';' + log + '\n'
	for key in existingFiles:
		if existingFiles[key] == 1:
			ret += key + '\n'
	fs2 = open(outFile, 'w')
	fs2.write(ret.strip())
	fs2.close()
	line = fs.readline()
fs.close()


