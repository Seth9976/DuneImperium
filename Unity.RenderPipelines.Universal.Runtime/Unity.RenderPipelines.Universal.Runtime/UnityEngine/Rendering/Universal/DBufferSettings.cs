using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000C0 RID: 192
	[Serializable]
	public class DBufferSettings : Object
	{
		// Token: 0x06000F01 RID: 3841 RVA: 0x00049214 File Offset: 0x00047414
		// Note: this type is marked as 'beforefieldinit'.
		static DBufferSettings()
		{
			Il2CppClassPointerStore<DBufferSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DBufferSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBufferSettings>.NativeClassPtr);
			DBufferSettings.NativeFieldInfoPtr_surfaceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferSettings>.NativeClassPtr, "surfaceData");
			DBufferSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferSettings>.NativeClassPtr, 100665204);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0004926C File Offset: 0x0004746C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614880, XrefRangeEnd = 614881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBufferSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBufferSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBufferSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000093F7 File Offset: 0x000075F7
		public DBufferSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x000492A8 File Offset: 0x000474A8
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x00009400 File Offset: 0x00007600
		public unsafe DecalSurfaceData surfaceData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferSettings.NativeFieldInfoPtr_surfaceData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBufferSettings.NativeFieldInfoPtr_surfaceData)) = value;
			}
		}

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeFieldInfoPtr_surfaceData;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
