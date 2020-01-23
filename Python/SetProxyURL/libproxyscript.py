import _winreg as _winreg
from ctypes import *
from ctypes.wintypes import *
import libglobalvariables as gv


HINTERNET = LPVOID
INTERNET_OPTION_REFRESH = 37


def refresh():
    InternetSetOption = windll.wininet.InternetSetOptionW
    InternetSetOption.argtypes = [HINTERNET, DWORD, LPVOID, DWORD]
    InternetSetOption.restype  = BOOL
    InternetSetOption(None, INTERNET_OPTION_REFRESH, None, 0) 


def del_reg():
	try:
		hKey = _winreg.CreateKey( _winreg.HKEY_CURRENT_USER, gv.REG_PATH)
		_winreg.DeleteValue(hKey, gv.KEY)
	except WindowsError as ew:
		print("Already Proxy Set Off")
		print(ew)
	else:
		print("Proxy Set Off")
		

def set_reg(name, value):
    try:
        _winreg.CreateKey(_winreg.HKEY_CURRENT_USER, gv.REG_PATH)
        registry_key = _winreg.OpenKey(_winreg.HKEY_CURRENT_USER, gv.REG_PATH, 0, 
                                       _winreg.KEY_WRITE)
        _winreg.SetValueEx(registry_key, name, 0, _winreg.REG_SZ, value)
        _winreg.CloseKey(registry_key)
        return True
    except WindowsError:
        return False

def get_reg(name):
    try:
        registry_key = _winreg.OpenKey(_winreg.HKEY_CURRENT_USER, gv.REG_PATH, 0,
                                       _winreg.KEY_READ)
        value, regtype = _winreg.QueryValueEx(registry_key, name)
        _winreg.CloseKey(registry_key)
        return value
    except WindowsError:
        return None