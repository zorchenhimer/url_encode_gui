# What is this?

This is just a little utility I threw together to make a routine task of mine less painful.  Provide a string in the top box (e.g. a filename) and it's URL encoded counterpart will be in the bottom box.

Extra characters are replaced on top of what `System.Uri.EscapeUriString()` already replaces in order to not cause problems with a *nix shell.  This includes ';' and '~', among others.

# When would I use this?

Let's say you have a file on an FTP server (*ServerA*) and want to transfer said file to another server (*ServerB*).  Copy the filename to the top box in the utility (e.g. *This;is[a]horrible-Filename!.txt*) and it will give you a string that you can use in a `wget` (or similar) command from the receiving server's shell:

`User@ServerB:~$ wget ftp://ftp.ServerA.net/This%3Bis%5Ba%5Dhorrible-Filename%21.txt`
