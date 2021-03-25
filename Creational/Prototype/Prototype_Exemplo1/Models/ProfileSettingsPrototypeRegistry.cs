namespace Prototype_Exemplo1.Models
{
	public class ProfileSettingsPrototypeRegistry
	{
		private readonly ProfileSettings _defaultProfileSettings;
		private readonly ProfileSettings _secureProfileSettings;

		public ProfileSettingsPrototypeRegistry( ProfileSettings defaultProfileSettings, ProfileSettings secureProfileSettings )
		{
			_defaultProfileSettings = defaultProfileSettings;
			_secureProfileSettings = secureProfileSettings;
		}

		public ProfileSettings CreateDefaultProfileSettings()
		{
			return _defaultProfileSettings.Clone();
		}

		public ProfileSettings CreateSecureProfileSettings()
		{
			return _secureProfileSettings.Clone();
		}
	}
}
