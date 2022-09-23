using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using static System.IO.File;

namespace RomanNumsUtils;

class Config
{
	public bool ViceVersa = false;
}

public sealed class ConfigLoader 
{
	private bool? _IsViceVersa;
	public bool IsViceVersa
	{
		get
		{
			if (_IsViceVersa == null) throw new Exception("You haven't load the config file!");
			else return _IsViceVersa ?? false;
		}
		set
		{
			_IsViceVersa = value;
		}
	} 
	public void Load(string yamlPath)
	{
		string yml = ReadAllText(yamlPath);
		IDeserializer deserializer = new DeserializerBuilder()
			.WithNamingConvention(PascalCaseNamingConvention.Instance)
			.Build();
		try {
			var p = deserializer.Deserialize<Config>(yml);
			_IsViceVersa = p.ViceVersa;
		} catch (YamlException ex) {
			Console.WriteLine(ex.Message);
		}		
	}
}
