using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000D2 RID: 210
	[Serializable]
	public class ExcludeEntryFromExport : Object
	{
		// Token: 0x06000ADF RID: 2783 RVA: 0x000068AB File Offset: 0x00004AAB
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeEntryFromExport()
		{
			Il2CppClassPointerStore<ExcludeEntryFromExport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "ExcludeEntryFromExport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeEntryFromExport>.NativeClassPtr);
			ExcludeEntryFromExport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeEntryFromExport>.NativeClassPtr, 100665103);
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000322E4 File Offset: 0x000304E4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeEntryFromExport()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeEntryFromExport>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeEntryFromExport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000068E4 File Offset: 0x00004AE4
		public ExcludeEntryFromExport(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
