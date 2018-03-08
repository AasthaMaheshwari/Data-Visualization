fs = open('GITComplete.txt','r')
id_array = []
log_array = {}
line = fs.readline()
while(line):
	tmp = line.split(';',1)
	id = int(tmp[0])
	id_array.append(id)
	log_array[id] = tmp[1].strip()
	line = fs.readline()
fs.close()
id_array.sort(reverse=True)

ret = ""
for id in id_array:
	ret += str(id) + ';' + log_array[id] + '\n'
fs = open('logSorted.txt', 'w')
fs.write(ret.strip())
fs.close()
