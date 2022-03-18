Microsoft Windows [Version 10.0.19042.1469]
(c) Microsoft Corporation. All rights reserved.

C:\Users\z004du6d>cd /console.jenkins

C:\console.jenkins>git init
Initialized empty Git repository in C:/console.jenkins/.git/

C:\console.jenkins>git add .

C:\console.jenkins>git status
On branch master

No commits yet

Changes to be committed:
  (use "git rm --cached <file>..." to unstage)
        new file:   3944/htmlreports/Extent_20Report/dashboard.html
        new file:   3945/htmlreports/Extent_20Report/dashboard.html
        new file:   3946/htmlreports/Extent_20Report/dashboard.html
        new file:   3947/htmlreports/Extent_20Report/dashboard.html
        new file:   ConsoleApp1/.gitattributes
        new file:   ConsoleApp1/.gitignore
        new file:   ConsoleApp1/ConsoleApp1.sln
        new file:   ConsoleApp1/ConsoleApp1/App.config
        new file:   ConsoleApp1/ConsoleApp1/ConsoleApp1.csproj
        new file:   ConsoleApp1/ConsoleApp1/Program.cs
        new file:   ConsoleApp1/ConsoleApp1/Properties/AssemblyInfo.cs
        new file:   ConsoleApp1/ConsoleApp1/packages.config
        new file:   JenkinsReport.html


C:\console.jenkins>git commit -m "First commit"
[master (root-commit) 7425ae6] First commit
 13 files changed, 2466 insertions(+)
 create mode 100644 3944/htmlreports/Extent_20Report/dashboard.html
 create mode 100644 3945/htmlreports/Extent_20Report/dashboard.html
 create mode 100644 3946/htmlreports/Extent_20Report/dashboard.html
 create mode 100644 3947/htmlreports/Extent_20Report/dashboard.html
 create mode 100644 ConsoleApp1/.gitattributes
 create mode 100644 ConsoleApp1/.gitignore
 create mode 100644 ConsoleApp1/ConsoleApp1.sln
 create mode 100644 ConsoleApp1/ConsoleApp1/App.config
 create mode 100644 ConsoleApp1/ConsoleApp1/ConsoleApp1.csproj
 create mode 100644 ConsoleApp1/ConsoleApp1/Program.cs
 create mode 100644 ConsoleApp1/ConsoleApp1/Properties/AssemblyInfo.cs
 create mode 100644 ConsoleApp1/ConsoleApp1/packages.config
 create mode 100644 JenkinsReport.html

C:\console.jenkins>git remote add origin  https://github.com/Meryem-b/neww.git

C:\console.jenkins>git push -u origin master
Enumerating objects: 26, done.
Counting objects: 100% (26/26), done.
Delta compression using up to 12 threads
Compressing objects: 100% (16/16), done.
Writing objects: 100% (26/26), 12.27 KiB | 4.09 MiB/s, done.
Total 26 (delta 2), reused 0 (delta 0), pack-reused 0
remote: Resolving deltas: 100% (2/2), done.
To https://github.com/Meryem-b/neww.git
 * [new branch]      master -> master
Branch 'master' set up to track remote branch 'master' from 'origin'.

C:\console.jenkins>
