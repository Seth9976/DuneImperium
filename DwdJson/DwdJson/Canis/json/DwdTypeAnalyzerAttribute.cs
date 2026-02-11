using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.json
{
	// Token: 0x0200000F RID: 15
	public class DwdTypeAnalyzerAttribute : Attribute
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00002316 File Offset: 0x00000516
		// Note: this type is marked as 'beforefieldinit'.
		static DwdTypeAnalyzerAttribute()
		{
			Il2CppClassPointerStore<DwdTypeAnalyzerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "DwdTypeAnalyzerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdTypeAnalyzerAttribute>.NativeClassPtr);
			DwdTypeAnalyzerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdTypeAnalyzerAttribute>.NativeClassPtr, 100663343);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003FC8 File Offset: 0x000021C8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdTypeAnalyzerAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdTypeAnalyzerAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdTypeAnalyzerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000234F File Offset: 0x0000054F
		public DwdTypeAnalyzerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
