using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000EA RID: 234
	public sealed class VolumeComponentDeprecated : Attribute
	{
		// Token: 0x060010C0 RID: 4288 RVA: 0x00008D26 File Offset: 0x00006F26
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeComponentDeprecated()
		{
			Il2CppClassPointerStore<VolumeComponentDeprecated>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VolumeComponentDeprecated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeComponentDeprecated>.NativeClassPtr);
			VolumeComponentDeprecated.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponentDeprecated>.NativeClassPtr, 100665765);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0004CE38 File Offset: 0x0004B038
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeComponentDeprecated()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeComponentDeprecated>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponentDeprecated.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00008D5F File Offset: 0x00006F5F
		public VolumeComponentDeprecated(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
