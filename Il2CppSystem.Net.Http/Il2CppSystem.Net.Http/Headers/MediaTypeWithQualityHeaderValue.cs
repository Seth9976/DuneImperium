using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200002C RID: 44
	public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue
	{
		// Token: 0x060002D4 RID: 724 RVA: 0x0000FE04 File Offset: 0x0000E004
		// Note: this type is marked as 'beforefieldinit'.
		static MediaTypeWithQualityHeaderValue()
		{
			Il2CppClassPointerStore<MediaTypeWithQualityHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "MediaTypeWithQualityHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaTypeWithQualityHeaderValue>.NativeClassPtr);
			MediaTypeWithQualityHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeWithQualityHeaderValue>.NativeClassPtr, 100663757);
			MediaTypeWithQualityHeaderValue.NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_MediaTypeWithQualityHeaderValue_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeWithQualityHeaderValue>.NativeClassPtr, 100663758);
			MediaTypeWithQualityHeaderValue.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_Int32_byref_List_1_MediaTypeWithQualityHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeWithQualityHeaderValue>.NativeClassPtr, 100663759);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000FE70 File Offset: 0x0000E070
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MediaTypeWithQualityHeaderValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaTypeWithQualityHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeWithQualityHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000FEAC File Offset: 0x0000E0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175044, XrefRangeEnd = 1175061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out Token t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lexer);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MediaTypeWithQualityHeaderValue.NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_MediaTypeWithQualityHeaderValue_byref_Token_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new MediaTypeWithQualityHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000FF20 File Offset: 0x0000E120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175061, XrefRangeEnd = 1175070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue> result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimalCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MediaTypeWithQualityHeaderValue.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_Int32_byref_List_1_MediaTypeWithQualityHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new List<MediaTypeWithQualityHeaderValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000303D File Offset: 0x0000123D
		public MediaTypeWithQualityHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_MediaTypeWithQualityHeaderValue_byref_Token_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_Int32_byref_List_1_MediaTypeWithQualityHeaderValue_0;
	}
}
