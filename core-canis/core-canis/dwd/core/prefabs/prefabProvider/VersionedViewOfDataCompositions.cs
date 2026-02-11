using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.prefabs.prefabProvider
{
	// Token: 0x02000112 RID: 274
	public class VersionedViewOfDataCompositions : VersionedView<IVersionedList<DataComposition>>
	{
		// Token: 0x06000F9D RID: 3997 RVA: 0x00007544 File Offset: 0x00005744
		// Note: this type is marked as 'beforefieldinit'.
		static VersionedViewOfDataCompositions()
		{
			Il2CppClassPointerStore<VersionedViewOfDataCompositions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.prefabProvider", "VersionedViewOfDataCompositions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedViewOfDataCompositions>.NativeClassPtr);
			VersionedViewOfDataCompositions.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedViewOfDataCompositions>.NativeClassPtr, 100665562);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000518D8 File Offset: 0x0004FAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868542, XrefRangeEnd = 868545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionedViewOfDataCompositions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedViewOfDataCompositions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedViewOfDataCompositions.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0000757D File Offset: 0x0000577D
		public VersionedViewOfDataCompositions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
