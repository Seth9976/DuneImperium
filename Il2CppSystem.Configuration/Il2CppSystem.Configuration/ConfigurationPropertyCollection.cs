using System;
using System.Reflection;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Configuration
{
	// Token: 0x02000005 RID: 5
	[DefaultMember("Item")]
	public class ConfigurationPropertyCollection : Object
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002062 File Offset: 0x00000262
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationPropertyCollection()
		{
			Il2CppClassPointerStore<ConfigurationPropertyCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "System.Configuration", "ConfigurationPropertyCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationPropertyCollection>.NativeClassPtr);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002087 File Offset: 0x00000287
		public ConfigurationPropertyCollection(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
