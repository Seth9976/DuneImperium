using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace TMPro
{
	// Token: 0x02000031 RID: 49
	[Serializable]
	public class TMP_Glyph : TMP_TextElement_Legacy
	{
		// Token: 0x0600055E RID: 1374 RVA: 0x0001B4AC File Offset: 0x000196AC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Glyph()
		{
			Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Glyph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr);
			TMP_Glyph.NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr, 100663865);
			TMP_Glyph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr, 100663866);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001B504 File Offset: 0x00019704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041071, XrefRangeEnd = 1041075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Glyph Clone(TMP_Glyph source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Glyph.NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Glyph>(intPtr3) : null;
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0001B548 File Offset: 0x00019748
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Glyph()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Glyph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00004AB6 File Offset: 0x00002CB6
		public TMP_Glyph(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
