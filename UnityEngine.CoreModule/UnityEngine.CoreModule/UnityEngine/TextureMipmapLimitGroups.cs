using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020002EF RID: 751
	public static class TextureMipmapLimitGroups
	{
		// Token: 0x06002D5D RID: 11613 RVA: 0x000B36DC File Offset: 0x000B18DC
		public static Il2CppStringArray GetGroups()
		{
			IntPtr intPtr = TextureMipmapLimitGroups.GetGroupsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00011ED5 File Offset: 0x000100D5
		public static bool HasGroup(string groupName)
		{
			return TextureMipmapLimitGroups.HasGroupDelegateField(IL2CPP.ManagedStringToIl2Cpp(groupName));
		}

		// Token: 0x040028FE RID: 10494
		private static readonly TextureMipmapLimitGroups.GetGroupsDelegate GetGroupsDelegateField = IL2CPP.ResolveICall<TextureMipmapLimitGroups.GetGroupsDelegate>("UnityEngine.TextureMipmapLimitGroups::GetGroups");

		// Token: 0x040028FF RID: 10495
		private static readonly TextureMipmapLimitGroups.HasGroupDelegate HasGroupDelegateField = IL2CPP.ResolveICall<TextureMipmapLimitGroups.HasGroupDelegate>("UnityEngine.TextureMipmapLimitGroups::HasGroup");

		// Token: 0x02000B3A RID: 2874
		// (Invoke) Token: 0x06003F69 RID: 16233
		private delegate IntPtr GetGroupsDelegate();

		// Token: 0x02000B3B RID: 2875
		// (Invoke) Token: 0x06003F6B RID: 16235
		private delegate bool HasGroupDelegate(IntPtr groupName);
	}
}
