using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x0200001D RID: 29
	public class PlatformUtilities : Object
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x0000BB8C File Offset: 0x00009D8C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformUtilities()
		{
			Il2CppClassPointerStore<PlatformUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "PlatformUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformUtilities>.NativeClassPtr);
			PlatformUtilities.NativeMethodInfoPtr_PlatformUsesMultiThreading_Internal_Static_Boolean_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtilities>.NativeClassPtr, 100663612);
			PlatformUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtilities>.NativeClassPtr, 100663613);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138742, RefRangeEnd = 1138743, XrefRangeStart = 1138742, XrefRangeEnd = 1138742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PlatformUsesMultiThreading(RuntimePlatform platform)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtilities.NativeMethodInfoPtr_PlatformUsesMultiThreading_Internal_Static_Boolean_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000BC24 File Offset: 0x00009E24
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformUtilities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002B28 File Offset: 0x00000D28
		public PlatformUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_PlatformUsesMultiThreading_Internal_Static_Boolean_RuntimePlatform_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
