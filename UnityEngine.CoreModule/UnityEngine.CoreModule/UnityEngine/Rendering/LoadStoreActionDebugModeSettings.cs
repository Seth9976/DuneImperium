using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000336 RID: 822
	public static class LoadStoreActionDebugModeSettings
	{
		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x0001283F File Offset: 0x00010A3F
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x0001284B File Offset: 0x00010A4B
		public static bool LoadStoreDebugModeEnabled
		{
			get
			{
				return LoadStoreActionDebugModeSettings.get_LoadStoreDebugModeEnabledDelegateField();
			}
			set
			{
				LoadStoreActionDebugModeSettings.set_LoadStoreDebugModeEnabledDelegateField(value);
			}
		}

		// Token: 0x040029B6 RID: 10678
		private static readonly LoadStoreActionDebugModeSettings.get_LoadStoreDebugModeEnabledDelegate get_LoadStoreDebugModeEnabledDelegateField = IL2CPP.ResolveICall<LoadStoreActionDebugModeSettings.get_LoadStoreDebugModeEnabledDelegate>("UnityEngine.Rendering.LoadStoreActionDebugModeSettings::get_LoadStoreDebugModeEnabled");

		// Token: 0x040029B7 RID: 10679
		private static readonly LoadStoreActionDebugModeSettings.set_LoadStoreDebugModeEnabledDelegate set_LoadStoreDebugModeEnabledDelegateField = IL2CPP.ResolveICall<LoadStoreActionDebugModeSettings.set_LoadStoreDebugModeEnabledDelegate>("UnityEngine.Rendering.LoadStoreActionDebugModeSettings::set_LoadStoreDebugModeEnabled");

		// Token: 0x02000B88 RID: 2952
		// (Invoke) Token: 0x06004003 RID: 16387
		private delegate bool get_LoadStoreDebugModeEnabledDelegate();

		// Token: 0x02000B89 RID: 2953
		// (Invoke) Token: 0x06004005 RID: 16389
		private delegate void set_LoadStoreDebugModeEnabledDelegate(bool value);
	}
}
