
fp = open('newAMfiles.txt','r')

line = fp.readline()
#line = fp.readline()


# for line in lines:
#     if(line.startwith('A')|line.startwith('M')):
#         filename = 1
#     else:
#         filename = 0
#
# files = {}
# for key in files:
#     files[key] == 1


while(line):
    ret = " "
    ret += line

    fo = open('54.txt', 'w')
    fo.write(ret)
    fo.close()



fp.close()

# for key in files
# files[key] == 1
# print
# files = {}
# filename == 1 | 0 (A|D)

# filename = "whole path"
# tmp = filename.split()
# for i in range(len(tmp))
# if i not in layers
# layer

