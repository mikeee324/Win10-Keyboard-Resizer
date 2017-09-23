# Win10-Keyboard-Resizer
A quick tool that resizes the Windows 10 Software/OnScreen Keyboard.  

## How does it work
It works by changing a registry key value that the software keyboard uses to determine the size of the screen.  
By default the key doesn't exist, this tool will handle that and create the key if it doesn't exist yet.  
  
	
The key it changes is here:
`HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Scaling`  
The Value it changes is called `Monitorsize` and needs to be a `String` value.  
  
## How do I use it  
You can download it from [here]()  
Once open just drag the slider or enter a value in the textbox. Click save and your On Screen keyboard should be smaller!
