using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000C2 RID: 194
	[Serializable]
	public class DecalScreenSpaceSettings : Object
	{
		// Token: 0x06000F06 RID: 3846 RVA: 0x000492D0 File Offset: 0x000474D0
		// Note: this type is marked as 'beforefieldinit'.
		static DecalScreenSpaceSettings()
		{
			Il2CppClassPointerStore<DecalScreenSpaceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalScreenSpaceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalScreenSpaceSettings>.NativeClassPtr);
			DecalScreenSpaceSettings.NativeFieldInfoPtr_normalBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalScreenSpaceSettings>.NativeClassPtr, "normalBlend");
			DecalScreenSpaceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalScreenSpaceSettings>.NativeClassPtr, 100665205);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00049328 File Offset: 0x00047528
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalScreenSpaceSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalScreenSpaceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalScreenSpaceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0000941B File Offset: 0x0000761B
		public DecalScreenSpaceSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00049364 File Offset: 0x00047564
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x00009424 File Offset: 0x00007624
		public unsafe DecalNormalBlend normalBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceSettings.NativeFieldInfoPtr_normalBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalScreenSpaceSettings.NativeFieldInfoPtr_normalBlend)) = value;
			}
		}

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_normalBlend;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
