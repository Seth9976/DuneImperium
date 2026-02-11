using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.utils
{
	// Token: 0x020000F1 RID: 241
	public class ConfigureGameOptionKeyAttribute : PropertyAttribute
	{
		// Token: 0x06000A6D RID: 2669 RVA: 0x00006FC9 File Offset: 0x000051C9
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureGameOptionKeyAttribute()
		{
			Il2CppClassPointerStore<ConfigureGameOptionKeyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.utils", "ConfigureGameOptionKeyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionKeyAttribute>.NativeClassPtr);
			ConfigureGameOptionKeyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionKeyAttribute>.NativeClassPtr, 100664798);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0003E3BC File Offset: 0x0003C5BC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGameOptionKeyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionKeyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionKeyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00007002 File Offset: 0x00005202
		public ConfigureGameOptionKeyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
