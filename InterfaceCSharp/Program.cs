using InterfaceCSharp;

SomeFile file = new();
file.WriteTextFile(); // của itextfile
file.WriteBinaryFile(); //của ibinaryfile
file.ReadFile(); // => dùng chung vì cả hai đều có
((IBinaryFile)file).ReadFile(); //=> của ibinaryfile, c# old

(file as ITextFile).ReadFile(); // của itextfile, c# new


AnyFile anyFile = new();
anyFile.WriteTextFile();
anyFile.WriteBinaryFile();
(anyFile as ITextFile).ReadFile();
(anyFile as IBinaryFile).ReadFile();
(anyFile as IBinaryFile).ShowInfo();