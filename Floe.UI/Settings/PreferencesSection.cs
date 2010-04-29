﻿using System;
using System.Configuration;

using Floe.UI.Interop;

namespace Floe.Configuration
{
	public sealed class PreferencesSection : ConfigurationSection
	{
		[ConfigurationProperty("user")]
		public UserElement User
		{
			get { return (UserElement)this["user"]; }
			set { this["user"] = value; }
		}

		[ConfigurationProperty("servers")]
		[ConfigurationCollection(typeof(ServerElement))]
		public ServerElementCollection Servers
		{
			get
			{
				return this["servers"] as ServerElementCollection;
			}
		}

		[ConfigurationProperty("output")]
		public OutputElement Output
		{
			get { return (OutputElement)this["output"]; }
			set { this["output"] = value; }
		}

		[ConfigurationProperty("windowPlacement")]
		public string WindowPlacement
		{
			get { return (string)this["windowPlacement"]; }
			set { this["windowPlacement"] = value; }
		}
	}
}