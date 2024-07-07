if (args.Length != 1) return;

string filePath = args[0];

if (filePath == null) return;
if (!File.Exists(filePath)) return;

byte[] bytes = File.ReadAllBytes(filePath);

string directoryPath = Path.GetDirectoryName(filePath);
string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
string newPath = Path.Combine(directoryPath, fileNameWithoutExtension) + ".log";

File.WriteAllBytes(newPath, bytes);
