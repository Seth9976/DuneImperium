using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000027 RID: 39
	public static class TMP_Compatibility : Object
	{
		// Token: 0x06000394 RID: 916 RVA: 0x00003D66 File Offset: 0x00001F66
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Compatibility()
		{
			Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Compatibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr);
			TMP_Compatibility.NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr, 100663623);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00015190 File Offset: 0x00013390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038117, RefRangeEnd = 1038118, XrefRangeStart = 1038117, XrefRangeEnd = 1038117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Compatibility.NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00003D9F File Offset: 0x00001F9F
		public TMP_Compatibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0;

		// Token: 0x0200007B RID: 123
		public enum AnchorPositions
		{
			// Token: 0x04000B99 RID: 2969
			TopLeft,
			// Token: 0x04000B9A RID: 2970
			Top,
			// Token: 0x04000B9B RID: 2971
			TopRight,
			// Token: 0x04000B9C RID: 2972
			Left,
			// Token: 0x04000B9D RID: 2973
			Center,
			// Token: 0x04000B9E RID: 2974
			Right,
			// Token: 0x04000B9F RID: 2975
			BottomLeft,
			// Token: 0x04000BA0 RID: 2976
			Bottom,
			// Token: 0x04000BA1 RID: 2977
			BottomRight,
			// Token: 0x04000BA2 RID: 2978
			BaseLine,
			// Token: 0x04000BA3 RID: 2979
			None
		}
	}
}
