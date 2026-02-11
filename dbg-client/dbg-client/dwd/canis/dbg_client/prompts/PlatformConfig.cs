using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.canis.dbg_client.prompts
{
	// Token: 0x02000070 RID: 112
	[Serializable]
	public sealed class PlatformConfig : ValueType
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x0002AA98 File Offset: 0x00028C98
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformConfig()
		{
			Il2CppClassPointerStore<PlatformConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.prompts", "PlatformConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformConfig>.NativeClassPtr);
			PlatformConfig.NativeFieldInfoPtr_platforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformConfig>.NativeClassPtr, "platforms");
			PlatformConfig.NativeFieldInfoPtr_pageConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformConfig>.NativeClassPtr, "pageConfigs");
			PlatformConfig.NativeMethodInfoPtr__ctor_Public_Void_List_1_RuntimePlatform_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformConfig>.NativeClassPtr, 100663927);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0002AB04 File Offset: 0x00028D04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 500551, RefRangeEnd = 500553, XrefRangeStart = 500521, XrefRangeEnd = 500551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformConfig(List<RuntimePlatform> platforms, List<string> tabs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformConfig>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(platforms);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tabs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformConfig.NativeMethodInfoPtr__ctor_Public_Void_List_1_RuntimePlatform_List_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00003E2D File Offset: 0x0000202D
		public PlatformConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00003E36 File Offset: 0x00002036
		public PlatformConfig()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformConfig>.NativeClassPtr))
		{
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0002AB68 File Offset: 0x00028D68
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00003E48 File Offset: 0x00002048
		public unsafe List<RuntimePlatform> platforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConfig.NativeFieldInfoPtr_platforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuntimePlatform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConfig.NativeFieldInfoPtr_platforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0002AB98 File Offset: 0x00028D98
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00003E67 File Offset: 0x00002067
		public unsafe List<PageConfig> pageConfigs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConfig.NativeFieldInfoPtr_pageConfigs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PageConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConfig.NativeFieldInfoPtr_pageConfigs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_platforms;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_pageConfigs;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_RuntimePlatform_List_1_String_0;
	}
}
