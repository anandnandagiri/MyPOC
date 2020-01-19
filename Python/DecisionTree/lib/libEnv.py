from platform import system as system_name # Returns the system/OS name
from os import system as system_call       # Execute a shell command
import subprocess as sp

def clear_screen():
	command = "cls" if system_name().lower()=="windows" else "clear"
	sp.call(command,shell=True)


def clear_screen_old():

    # Clear command as function of OS
    command = "cls" if system_name().lower()=="windows" else "clear"

    # Action
    system_call(command)
	
	