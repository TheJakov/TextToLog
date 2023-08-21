if (args.Length != 1) return;

string filePath = args[0];

if (filePath == null) return;
if (!File.Exists(filePath)) return;

byte[] bytes = File.ReadAllBytes(filePath);

string directoryPath = Path.GetDirectoryName(filePath);
string fileName = Path.GetFileName(filePath);
string newPath = Path.Join(directoryPath, fileName.Split('.').First()) + ".log";

File.WriteAllBytes(newPath, bytes);