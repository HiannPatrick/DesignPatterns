namespace Prototype_Exemplo1.Models
{
	public class ProfileSettings
	{
		public bool IsPrivate { get; set; }
		public bool HideEmail { get; set; }
		public bool HideAge { get; set; }

		public ProfileSettings Clone()
		{
			return new ProfileSettings()
			{
				IsPrivate = IsPrivate,
				HideEmail = HideEmail,
				HideAge = HideAge
			};
		}
	}
}
