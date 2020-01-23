import sys
#from win32com.shell import shell, shellcon
import libproxyscript as proxy
import libglobalvariables as gv

#argv 0 will be name of the file
#argv 1 will be our input

#print("Number of arguments:" + str(len(sys.argv)) + 'arguments.')
#print('Argument List:', str(sys.argv))

if len(sys.argv)==1:
	if sys.argv[0].upper() == "ON":
		proxy.set_reg(gv.KEY,gv.PROXY)
	elif sys.argv[0].upper() == "OFF":
		proxy.del_reg()
	else:	
		print("arguments can be ON or OFF")
else:
	print("arguments can be ON or OFF")

proxy.refresh()

# Tell windows about the change
#shell.SHChangeNotify(shellcon.SHCNE_ASSOCCHANGED, shellcon.SHCNF_IDLIST, None, None) 
