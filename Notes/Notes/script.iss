[Setup]
AppName=Notes
AppVersion=1.0
DefaultDirName={pf}\Notes
DefaultGroupName=Notes
OutputBaseFilename=NotesInstaller
SetupIconFile=Resources\appicon.ico
Compression=lzma
SolidCompression=yes

[Files]
Source: "bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs

[Icons]
Name: "{group}\Notes"; Filename: "{app}\Notes.exe"; IconFilename: "{app}\Resources\appicon.ico"
Name: "{commondesktop}\Notes"; Filename: "{app}\Notes.exe"; IconFilename: "{app}\Resources\appicon.ico"