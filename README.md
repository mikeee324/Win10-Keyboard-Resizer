# Win10-Keyboard-Resizer
A quick tool that resizes the Windows 10 Software/OnScreen Keyboard.  

## How does it work
It works by changing a registry key value that the software keyboard uses to determine the size of the screen.  
By default the key doesn't exist, this tool will handle that and create the key if it doesn't exist yet.  
  
	
The key it changes is here:
`HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Scaling`  
The Value it changes is called `Monitorsize` and needs to be a `String` value.  
  
## How do I use it  
You can download it from [here](https://github.com/mikeee324/Win10-Keyboard-Resizer/releases)  
Once open just drag the slider or enter a value in the textbox. Click save and your On Screen keyboard should be smaller!
  
## Screenshots  
### 100% Scale (Default)
![App Screenshot 1](/docs/images/app1.PNG?raw=true "App Screenshot 1")  
![Keyboard Screenshot 1](/docs/images/keyboard1.PNG?raw=true "Keyboard Screenshot 1")  
### 25% Scale  
![App Screenshot 2](/docs/images/app2.PNG?raw=true "App Screenshot 2")  
![Keyboard Screenshot 2](/docs/images/keyboard2.PNG?raw=true "Keyboard Screenshot 2")
