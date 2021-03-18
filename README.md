# Unlimited Horizon - Call Recordings Viewer
## What is it?
An easy-to-use tool for viewing, filtering and exporting call recordings downloaded in bulk from the Unlimited Horizon IP phone system (by Gamma).

When it comes to storing call recordings there are only two viable options - allow your phone provider to charge you for the storage of recordings on their server, or download the call recordings as ZIP files and store them on your company's on-premise server.

This easy-to-use tool makes it easy to store and access call recordings on-premise without compromising on cost or storage space. Simply download your call recordings as a ZIP (*Recorded Calls -> Bulk Download*), store them in a convenient folder and tell this tool where to find those ZIP files.

![Horizon - Call Recordings Viewer (v1.1)](https://imgur.com/MSDyPTR.png)

## Set up
### Deployment
The application can be distributed in numerous ways; however, the easiest method (in my opinion) is to store the application centrally (on a network-accessible shared folder) along with an edited configuration file (more on that below) and then create a shortcut to this application on a users desktop (this could be done with GPO or manually).

### Configuration
Currently there are only a few basic configuration options but for deployment to multiple machines, the configuration file can greatly increase deployment speed and reduce risk of user error/confusion.


**Please note:**  once the program is launched on a users computer, the configuration file is copied to their AppData folder, meaning that changes made to the centrally-stored configuration file after the user has first launched the application won't automatically be updated for that user on that particular computer.


There are **three** main configuration options:
|Setting|Purpose|
|--|--|
|DefaultCallRecordingsSource|Location of the folder containing all call recording archives to be loaded in. This program searches the folder recursively so archives in subfolders are allowed.|
|DefaultCallRecordingsTemp|Location of where temporary files should be stored (e.g. when the file must be extracted to be played). These are deleted once the program closes.|
|CallRecordingUsers|List of users in the Horizon system. Allows a user to filter call recordings by user without knowing their direct dial number. *Currently not used.* |


![Example Configuration File](https://imgur.com/ZsTlYXS.png)
