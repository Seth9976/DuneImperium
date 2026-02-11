using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200002C RID: 44
	public static class TextGeneratorUtilities : Object
	{
		// Token: 0x060004F7 RID: 1271 RVA: 0x00014980 File Offset: 0x00012B80
		// Note: this type is marked as 'beforefieldinit'.
		static TextGeneratorUtilities()
		{
			Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextGeneratorUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr);
			TextGeneratorUtilities.NativeFieldInfoPtr_largePositiveVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, "largePositiveVector2");
			TextGeneratorUtilities.NativeFieldInfoPtr_largeNegativeVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, "largeNegativeVector2");
			TextGeneratorUtilities.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663600);
			TextGeneratorUtilities.NativeMethodInfoPtr_HexCharsToColor_Public_Static_Color32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663601);
			TextGeneratorUtilities.NativeMethodInfoPtr_HexCharsToColor_Public_Static_Color32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663602);
			TextGeneratorUtilities.NativeMethodInfoPtr_HexToInt_Public_Static_UInt32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663603);
			TextGeneratorUtilities.NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663604);
			TextGeneratorUtilities.NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663605);
			TextGeneratorUtilities.NativeMethodInfoPtr_PackUV_Public_Static_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663606);
			TextGeneratorUtilities.NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663607);
			TextGeneratorUtilities.NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663608);
			TextGeneratorUtilities.NativeMethodInfoPtr_InsertOpeningTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663609);
			TextGeneratorUtilities.NativeMethodInfoPtr_InsertClosingTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663610);
			TextGeneratorUtilities.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Public_Static_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663611);
			TextGeneratorUtilities.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Static_Boolean_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663612);
			TextGeneratorUtilities.NativeMethodInfoPtr_ReplaceClosingStyleTag_Public_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663613);
			TextGeneratorUtilities.NativeMethodInfoPtr_InsertOpeningStyleTag_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663614);
			TextGeneratorUtilities.NativeMethodInfoPtr_InsertClosingStyleTag_Internal_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663615);
			TextGeneratorUtilities.NativeMethodInfoPtr_InsertTextStyleInTextProcessingArray_Private_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_Il2CppStructArray_1_UInt32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663616);
			TextGeneratorUtilities.NativeMethodInfoPtr_GetStyle_Public_Static_TextStyle_TextGenerationSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663617);
			TextGeneratorUtilities.NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663618);
			TextGeneratorUtilities.NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_TextBackingContainer_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663619);
			TextGeneratorUtilities.NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663620);
			TextGeneratorUtilities.NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663621);
			TextGeneratorUtilities.NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663622);
			TextGeneratorUtilities.NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663623);
			TextGeneratorUtilities.NativeMethodInfoPtr_FillCharacterVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663624);
			TextGeneratorUtilities.NativeMethodInfoPtr_FillSpriteVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663625);
			TextGeneratorUtilities.NativeMethodInfoPtr_AdjustLineOffset_Public_Static_Void_Int32_Int32_Single_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663626);
			TextGeneratorUtilities.NativeMethodInfoPtr_ResizeLineExtents_Public_Static_Void_Int32_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663627);
			TextGeneratorUtilities.NativeMethodInfoPtr_LegacyStyleToNewStyle_Public_Static_FontStyles_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663628);
			TextGeneratorUtilities.NativeMethodInfoPtr_LegacyAlignmentToNewAlignment_Public_Static_TextAlignment_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663629);
			TextGeneratorUtilities.NativeMethodInfoPtr_ConvertToUTF32_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663630);
			TextGeneratorUtilities.NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663631);
			TextGeneratorUtilities.NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663632);
			TextGeneratorUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663633);
			TextGeneratorUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663634);
			TextGeneratorUtilities.NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663635);
			TextGeneratorUtilities.NativeMethodInfoPtr_GetAttributeParameters_Public_Static_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663636);
			TextGeneratorUtilities.NativeMethodInfoPtr_IsBitmapRendering_Public_Static_Boolean_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663637);
			TextGeneratorUtilities.NativeMethodInfoPtr_IsBaseGlyph_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663638);
			TextGeneratorUtilities.NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663639);
			TextGeneratorUtilities.NativeMethodInfoPtr_GammaToLinear_Internal_Static_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663640);
			TextGeneratorUtilities.NativeMethodInfoPtr_GammaToLinear_Private_Static_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663641);
			TextGeneratorUtilities.NativeMethodInfoPtr_IsValidUTF16_Public_Static_Boolean_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663642);
			TextGeneratorUtilities.NativeMethodInfoPtr_IsValidUTF32_Public_Static_Boolean_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663643);
			TextGeneratorUtilities.NativeMethodInfoPtr_IsHangul_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663644);
			TextGeneratorUtilities.NativeMethodInfoPtr_IsCJK_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663645);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00014D70 File Offset: 0x00012F70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1104558, RefRangeEnd = 1104560, XrefRangeStart = 1104558, XrefRangeEnd = 1104558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00014DBC File Offset: 0x00012FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104560, XrefRangeEnd = 1104627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int tagCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hexChars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_HexCharsToColor_Public_Static_Color32_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00014E0C File Offset: 0x0001300C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104627, XrefRangeEnd = 1104648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hexChars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_HexCharsToColor_Public_Static_Color32_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00014E6C File Offset: 0x0001306C
		[CallerCount(80)]
		[CachedScanResults(RefRangeStart = 1104648, RefRangeEnd = 1104728, XrefRangeStart = 1104648, XrefRangeEnd = 1104648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint HexToInt(char hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_HexToInt_Public_Static_UInt32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00014EAC File Offset: 0x000130AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104732, RefRangeEnd = 1104733, XrefRangeStart = 1104728, XrefRangeEnd = 1104732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00014F0C File Offset: 0x0001310C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1104738, RefRangeEnd = 1104740, XrefRangeStart = 1104733, XrefRangeEnd = 1104738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length, out int lastIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00014F78 File Offset: 0x00013178
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1104740, RefRangeEnd = 1104752, XrefRangeStart = 1104740, XrefRangeEnd = 1104740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 PackUV(float x, float y, float scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_PackUV_Public_Static_Vector2_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00014FD4 File Offset: 0x000131D4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1104756, RefRangeEnd = 1104764, XrefRangeStart = 1104752, XrefRangeEnd = 1104756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.MethodInfoStoreGeneric_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00015020 File Offset: 0x00013220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1104767, RefRangeEnd = 1104769, XrefRangeStart = 1104764, XrefRangeEnd = 1104767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array, int size)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.MethodInfoStoreGeneric_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001507C File Offset: 0x0001327C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104776, RefRangeEnd = 1104777, XrefRangeStart = 1104769, XrefRangeEnd = 1104776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertOpeningTextStyle(TextStyle style, ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &textStyleStackDepth;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(textStyleStacks);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_InsertOpeningTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			textStyleStacks = ((intPtr7 == 0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			generationSettings = ((intPtr8 == 0) ? null : new TextGenerationSettings(intPtr8));
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001514C File Offset: 0x0001334C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104784, RefRangeEnd = 1104785, XrefRangeStart = 1104777, XrefRangeEnd = 1104784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertClosingTextStyle(TextStyle style, ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &textStyleStackDepth;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(textStyleStacks);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_InsertClosingTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			textStyleStacks = ((intPtr7 == 0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			generationSettings = ((intPtr8 == 0) ? null : new TextGenerationSettings(intPtr8));
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001521C File Offset: 0x0001341C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104800, RefRangeEnd = 1104801, XrefRangeStart = 1104785, XrefRangeEnd = 1104800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcOffset;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &textStyleStackDepth;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(textStyleStacks);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Public_Static_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			textStyleStacks = ((intPtr7 == 0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			generationSettings = ((intPtr8 == 0) ? null : new TextGenerationSettings(intPtr8));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00015318 File Offset: 0x00013518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104816, RefRangeEnd = 1104817, XrefRangeStart = 1104801, XrefRangeEnd = 1104816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReplaceOpeningStyleTag(ref Il2CppStructArray<uint> sourceText, int srcIndex, out int srcOffset, ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcOffset;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &textStyleStackDepth;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(textStyleStacks);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Static_Boolean_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			sourceText = ((intPtr7 == 0) ? null : new Il2CppStructArray<uint>(intPtr7));
			IntPtr intPtr8 = intPtr2;
			charBuffer = ((intPtr8 == 0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr8));
			IntPtr intPtr9 = intPtr3;
			textStyleStacks = ((intPtr9 == 0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr9));
			IntPtr intPtr10 = intPtr4;
			generationSettings = ((intPtr10 == 0) ? null : new TextGenerationSettings(intPtr10));
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001542C File Offset: 0x0001362C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1104827, RefRangeEnd = 1104829, XrefRangeStart = 1104817, XrefRangeEnd = 1104827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReplaceClosingStyleTag(ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &textStyleStackDepth;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(textStyleStacks);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_ReplaceClosingStyleTag_Public_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			textStyleStacks = ((intPtr7 == 0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			generationSettings = ((intPtr8 == 0) ? null : new TextGenerationSettings(intPtr8));
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000154E8 File Offset: 0x000136E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104836, RefRangeEnd = 1104837, XrefRangeStart = 1104829, XrefRangeEnd = 1104836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertOpeningStyleTag(TextStyle style, ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &textStyleStackDepth;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(textStyleStacks);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_InsertOpeningStyleTag_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			textStyleStacks = ((intPtr7 == 0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			generationSettings = ((intPtr8 == 0) ? null : new TextGenerationSettings(intPtr8));
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000155B8 File Offset: 0x000137B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104845, RefRangeEnd = 1104846, XrefRangeStart = 1104837, XrefRangeEnd = 1104845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertClosingStyleTag(ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &textStyleStackDepth;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(textStyleStacks);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_InsertClosingStyleTag_Internal_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			textStyleStacks = ((intPtr7 == 0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			generationSettings = ((intPtr8 == 0) ? null : new TextGenerationSettings(intPtr8));
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00015674 File Offset: 0x00013874
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1104879, RefRangeEnd = 1104886, XrefRangeStart = 1104846, XrefRangeEnd = 1104879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertTextStyleInTextProcessingArray(ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, Il2CppStructArray<uint> styleDefinition, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(styleDefinition);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &textStyleStackDepth;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(textStyleStacks);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_InsertTextStyleInTextProcessingArray_Private_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_Il2CppStructArray_1_UInt32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			textStyleStacks = ((intPtr7 == 0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			generationSettings = ((intPtr8 == 0) ? null : new TextGenerationSettings(intPtr8));
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00015744 File Offset: 0x00013944
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1104895, RefRangeEnd = 1104902, XrefRangeStart = 1104886, XrefRangeEnd = 1104895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generationSetting);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GetStyle_Public_Static_TextStyle_TextGenerationSettings_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextStyle>(intPtr3) : null;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00015798 File Offset: 0x00013998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104902, XrefRangeEnd = 1104907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStyleHashCode(ref Il2CppStructArray<uint> text, int index, out int closeIndex)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(text);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			text = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001580C File Offset: 0x00013A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104907, XrefRangeEnd = 1104912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_TextBackingContainer_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001586C File Offset: 0x00013A6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104919, RefRangeEnd = 1104920, XrefRangeStart = 1104912, XrefRangeEnd = 1104919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetUTF16(Il2CppStructArray<uint> text, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000158BC File Offset: 0x00013ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104927, RefRangeEnd = 1104928, XrefRangeStart = 1104920, XrefRangeEnd = 1104927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetUTF16(TextBackingContainer text, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_TextBackingContainer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00015910 File Offset: 0x00013B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104939, RefRangeEnd = 1104940, XrefRangeStart = 1104928, XrefRangeEnd = 1104939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetUTF32(Il2CppStructArray<uint> text, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00015960 File Offset: 0x00013B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104951, RefRangeEnd = 1104952, XrefRangeStart = 1104940, XrefRangeEnd = 1104951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetUTF32(TextBackingContainer text, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_TextBackingContainer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000159B4 File Offset: 0x00013BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104975, RefRangeEnd = 1104976, XrefRangeStart = 1104952, XrefRangeEnd = 1104975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref convertToLinearSpace;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_FillCharacterVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00015A18 File Offset: 0x00013C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104994, RefRangeEnd = 1104995, XrefRangeStart = 1104976, XrefRangeEnd = 1104994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref convertToLinearSpace;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_FillSpriteVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00015A7C File Offset: 0x00013C7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1104995, RefRangeEnd = 1104997, XrefRangeStart = 1104995, XrefRangeEnd = 1104995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_AdjustLineOffset_Public_Static_Void_Int32_Int32_Single_TextInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00015ADC File Offset: 0x00013CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1105012, RefRangeEnd = 1105014, XrefRangeStart = 1104997, XrefRangeEnd = 1105012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeLineExtents(int size, TextInfo textInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_ResizeLineExtents_Public_Static_Void_Int32_TextInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00015B20 File Offset: 0x00013D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105014, RefRangeEnd = 1105015, XrefRangeStart = 1105014, XrefRangeEnd = 1105014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fontStyle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_LegacyStyleToNewStyle_Public_Static_FontStyles_FontStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00015B60 File Offset: 0x00013D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105015, RefRangeEnd = 1105016, XrefRangeStart = 1105015, XrefRangeEnd = 1105015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_LegacyAlignmentToNewAlignment_Public_Static_TextAlignment_TextAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00015BA0 File Offset: 0x00013DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105016, RefRangeEnd = 1105017, XrefRangeStart = 1105016, XrefRangeEnd = 1105016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurrogate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurrogate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_ConvertToUTF32_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00015BEC File Offset: 0x00013DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105022, RefRangeEnd = 1105023, XrefRangeStart = 1105017, XrefRangeEnd = 1105022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(styleDefinition));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_TextBackingContainer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00015C40 File Offset: 0x00013E40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105028, RefRangeEnd = 1105029, XrefRangeStart = 1105023, XrefRangeEnd = 1105028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMarkupTagHashCode(Il2CppStructArray<uint> styleDefinition, int readIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(styleDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00015C90 File Offset: 0x00013E90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1105032, RefRangeEnd = 1105036, XrefRangeStart = 1105029, XrefRangeEnd = 1105032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpperASCIIFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00015CD0 File Offset: 0x00013ED0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1105039, RefRangeEnd = 1105041, XrefRangeStart = 1105036, XrefRangeEnd = 1105039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUpperASCIIFast(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00015D10 File Offset: 0x00013F10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1105044, RefRangeEnd = 1105047, XrefRangeStart = 1105041, XrefRangeEnd = 1105044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpperFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00015D50 File Offset: 0x00013F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105047, XrefRangeEnd = 1105051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAttributeParameters(Il2CppStructArray<char> chars, int startIndex, int length, ref Il2CppStructArray<float> parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GetAttributeParameters_Public_Static_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parameters = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00015DD8 File Offset: 0x00013FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105051, RefRangeEnd = 1105052, XrefRangeStart = 1105051, XrefRangeEnd = 1105051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphRenderMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_IsBitmapRendering_Public_Static_Boolean_GlyphRenderMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00015E18 File Offset: 0x00014018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1105052, RefRangeEnd = 1105054, XrefRangeStart = 1105052, XrefRangeEnd = 1105052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBaseGlyph(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_IsBaseGlyph_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00015E58 File Offset: 0x00014058
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1105054, RefRangeEnd = 1105058, XrefRangeStart = 1105054, XrefRangeEnd = 1105054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color MinAlpha(this Color c1, Color c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00015EA4 File Offset: 0x000140A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1105064, RefRangeEnd = 1105072, XrefRangeStart = 1105058, XrefRangeEnd = 1105064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GammaToLinear(Color32 c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GammaToLinear_Internal_Static_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00015EE4 File Offset: 0x000140E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1105072, RefRangeEnd = 1105075, XrefRangeStart = 1105072, XrefRangeEnd = 1105072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte GammaToLinear(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_GammaToLinear_Private_Static_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00015F24 File Offset: 0x00014124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105076, RefRangeEnd = 1105077, XrefRangeStart = 1105075, XrefRangeEnd = 1105076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidUTF16(TextBackingContainer text, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_IsValidUTF16_Public_Static_Boolean_TextBackingContainer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00015F78 File Offset: 0x00014178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105078, RefRangeEnd = 1105079, XrefRangeStart = 1105077, XrefRangeEnd = 1105078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidUTF32(TextBackingContainer text, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_IsValidUTF32_Public_Static_Boolean_TextBackingContainer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00015FCC File Offset: 0x000141CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1105079, RefRangeEnd = 1105081, XrefRangeStart = 1105079, XrefRangeEnd = 1105079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHangul(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_IsHangul_Internal_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0001600C File Offset: 0x0001420C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1105081, RefRangeEnd = 1105083, XrefRangeStart = 1105081, XrefRangeEnd = 1105081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCJK(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGeneratorUtilities.NativeMethodInfoPtr_IsCJK_Internal_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000054B6 File Offset: 0x000036B6
		public TextGeneratorUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001604C File Offset: 0x0001424C
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x000054BF File Offset: 0x000036BF
		public unsafe static Vector2 largePositiveVector2
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TextGeneratorUtilities.NativeFieldInfoPtr_largePositiveVector2, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextGeneratorUtilities.NativeFieldInfoPtr_largePositiveVector2, (void*)(&value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00016068 File Offset: 0x00014268
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x000054CD File Offset: 0x000036CD
		public unsafe static Vector2 largeNegativeVector2
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TextGeneratorUtilities.NativeFieldInfoPtr_largeNegativeVector2, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextGeneratorUtilities.NativeFieldInfoPtr_largeNegativeVector2, (void*)(&value));
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00016084 File Offset: 0x00014284
		public static bool IsTagName(ref string text, string tag, int index)
		{
			bool flag = text.Length < index + tag.Length;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				for (int i = 0; i < tag.Length; i++)
				{
					bool flag3 = TextUtilities.ToUpperFast(text.get_Chars(index + i)) != tag.get_Chars(i);
					if (flag3)
					{
						return false;
					}
				}
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000054DB File Offset: 0x000036DB
		public static bool IsTagName(ref Il2CppStructArray<int> text, string tag, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000054E8 File Offset: 0x000036E8
		public static void ReplaceOpeningStyleTag(ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000054F5 File Offset: 0x000036F5
		public static int GetTagHashCode(ref Il2CppStructArray<int> text, int index, out int closeIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000160EC File Offset: 0x000142EC
		public static int GetTagHashCode(ref string text, int index, out int closeIndex)
		{
			int num = 0;
			closeIndex = 0;
			for (int i = index; i < text.Length; i++)
			{
				bool flag = text.get_Chars(i) == '"';
				if (!flag)
				{
					bool flag2 = text.get_Chars(i) == '>';
					if (flag2)
					{
						closeIndex = i;
						break;
					}
					num = ((num << 5) + num) ^ (int)TextUtilities.ToUpperASCIIFast((uint)text.get_Chars(i));
				}
			}
			return num;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0001615C File Offset: 0x0001435C
		public static bool IsEmoji(uint c)
		{
			return c == 8205U || c == 8252U || c == 8265U || c == 8419U || c == 8482U || c == 8505U || (c >= 8596U && c <= 8601U) || (c >= 8617U && c <= 8618U) || (c >= 8986U && c <= 8987U) || c == 9000U || c == 9096U || c == 9167U || (c >= 9193U && c <= 9203U) || (c >= 9208U && c <= 9210U) || c == 9410U || (c >= 9642U && c <= 9643U) || c == 9654U || c == 9664U || (c >= 9723U && c <= 9726U) || (c >= 9728U && c <= 9733U) || (c >= 9735U && c <= 9746U) || (c >= 9748U && c <= 9861U) || (c >= 9872U && c <= 9989U) || (c >= 9992U && c <= 10002U) || c == 10004U || c == 10006U || c == 10013U || c == 10017U || c == 10024U || (c >= 10035U && c <= 10036U) || c == 10052U || c == 10055U || c == 10060U || c == 10062U || (c >= 10067U && c <= 10069U) || c == 10071U || (c >= 10083U && c <= 10087U) || (c >= 10133U && c <= 10135U) || c == 10145U || c == 10160U || c == 10175U || (c >= 10548U && c <= 10549U) || (c >= 11013U && c <= 11015U) || (c >= 11035U && c <= 11036U) || c == 11088U || c == 11093U || c == 12336U || c == 12349U || c == 12951U || c == 12953U || c == 65039U || (c >= 126976U && c <= 127231U) || (c >= 127245U && c <= 127247U) || c == 127279U || (c >= 127340U && c <= 127345U) || (c >= 127358U && c <= 127359U) || c == 127374U || (c >= 127377U && c <= 127386U) || (c >= 127405U && c <= 127487U) || (c >= 127489U && c <= 127503U) || c == 127514U || c == 127535U || (c >= 127538U && c <= 127546U) || (c >= 127548U && c <= 127551U) || (c >= 127561U && c <= 128317U) || (c >= 128326U && c <= 128591U) || (c >= 128640U && c <= 128767U) || (c >= 128884U && c <= 128895U) || (c >= 128981U && c <= 129023U) || (c >= 129036U && c <= 129039U) || (c >= 129096U && c <= 129103U) || (c >= 129114U && c <= 129119U) || (c >= 129160U && c <= 129167U) || (c >= 129198U && c <= 129279U) || (c >= 129292U && c <= 129338U) || (c >= 129340U && c <= 129349U) || (c >= 129351U && c <= 129791U) || (c >= 130048U && c <= 131069U) || (c >= 917536U && c <= 917631U);
		}

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr_largePositiveVector2;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_largeNegativeVector2;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_HexCharsToColor_Public_Static_Color32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_HexCharsToColor_Public_Static_Color32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_HexToInt_Public_Static_UInt32_Char_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_PackUV_Public_Static_Vector2_Single_Single_Single_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_InsertOpeningTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_InsertClosingTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceOpeningStyleTag_Public_Static_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Static_Boolean_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceClosingStyleTag_Public_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_InsertOpeningStyleTag_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_InsertClosingStyleTag_Internal_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_InsertTextStyleInTextProcessingArray_Private_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_Il2CppStructArray_1_UInt32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Public_Static_TextStyle_TextGenerationSettings_Int32_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_TextBackingContainer_Int32_byref_Int32_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_TextBackingContainer_Int32_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_TextBackingContainer_Int32_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_FillCharacterVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_FillSpriteVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_AdjustLineOffset_Public_Static_Void_Int32_Int32_Single_TextInfo_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_ResizeLineExtents_Public_Static_Void_Int32_TextInfo_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_LegacyStyleToNewStyle_Public_Static_FontStyles_FontStyle_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_LegacyAlignmentToNewAlignment_Public_Static_TextAlignment_TextAnchor_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToUTF32_Public_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_TextBackingContainer_Int32_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeParameters_Public_Static_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_IsBitmapRendering_Public_Static_Boolean_GlyphRenderMode_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_IsBaseGlyph_Public_Static_Boolean_UInt32_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_GammaToLinear_Internal_Static_Color32_Color32_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_GammaToLinear_Private_Static_Byte_Byte_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_IsValidUTF16_Public_Static_Boolean_TextBackingContainer_Int32_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_IsValidUTF32_Public_Static_Boolean_TextBackingContainer_Int32_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_IsHangul_Internal_Static_Boolean_UInt32_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_IsCJK_Internal_Static_Boolean_UInt32_0;

		// Token: 0x040003E4 RID: 996
		public const float largePositiveFloat = 32767f;

		// Token: 0x040003E5 RID: 997
		public const float largeNegativeFloat = -32767f;

		// Token: 0x040003E6 RID: 998
		public const int k_DoubleQuotes = 34;

		// Token: 0x040003E7 RID: 999
		public const int k_GreaterThan = 62;

		// Token: 0x040003E8 RID: 1000
		public const int k_ZeroWidthSpace = 8203;

		// Token: 0x040003E9 RID: 1001
		public const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

		// Token: 0x0200004D RID: 77
		private sealed class MethodInfoStoreGeneric_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x040005F8 RID: 1528
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TextGeneratorUtilities.NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004E RID: 78
		private sealed class MethodInfoStoreGeneric_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x040005F9 RID: 1529
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TextGeneratorUtilities.NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
