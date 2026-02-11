using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.util
{
	// Token: 0x02000094 RID: 148
	public static class ResourceUtil : global::Il2CppSystem.Object
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00005B2C File Offset: 0x00003D2C
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceUtil()
		{
			Il2CppClassPointerStore<ResourceUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "ResourceUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceUtil>.NativeClassPtr);
			ResourceUtil.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceUtil>.NativeClassPtr, 100664744);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0003B0F8 File Offset: 0x000392F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862778, RefRangeEnd = 862780, XrefRangeStart = 862771, XrefRangeEnd = 862778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadAsset(global::UnityEngine.Object asset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceUtil.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00005B65 File Offset: 0x00003D65
		public ResourceUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0;
	}
}
