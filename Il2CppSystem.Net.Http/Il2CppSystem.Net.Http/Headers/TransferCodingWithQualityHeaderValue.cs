using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000038 RID: 56
	public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue
	{
		// Token: 0x06000384 RID: 900 RVA: 0x00012FBC File Offset: 0x000111BC
		// Note: this type is marked as 'beforefieldinit'.
		static TransferCodingWithQualityHeaderValue()
		{
			Il2CppClassPointerStore<TransferCodingWithQualityHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "TransferCodingWithQualityHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransferCodingWithQualityHeaderValue>.NativeClassPtr);
			TransferCodingWithQualityHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferCodingWithQualityHeaderValue>.NativeClassPtr, 100663889);
			TransferCodingWithQualityHeaderValue.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_Int32_byref_List_1_TransferCodingWithQualityHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferCodingWithQualityHeaderValue>.NativeClassPtr, 100663890);
			TransferCodingWithQualityHeaderValue.NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_TransferCodingWithQualityHeaderValue_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferCodingWithQualityHeaderValue>.NativeClassPtr, 100663891);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00013028 File Offset: 0x00011228
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransferCodingWithQualityHeaderValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransferCodingWithQualityHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransferCodingWithQualityHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00013064 File Offset: 0x00011264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176049, XrefRangeEnd = 1176058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, int minimalCount, out List<TransferCodingWithQualityHeaderValue> result)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TransferCodingWithQualityHeaderValue.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_Int32_byref_List_1_TransferCodingWithQualityHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new List<TransferCodingWithQualityHeaderValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000130D8 File Offset: 0x000112D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176058, XrefRangeEnd = 1176076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseElement(Lexer lexer, out TransferCodingWithQualityHeaderValue parsedValue, out Token t)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TransferCodingWithQualityHeaderValue.NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_TransferCodingWithQualityHeaderValue_byref_Token_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new TransferCodingWithQualityHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00003375 File Offset: 0x00001575
		public TransferCodingWithQualityHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_Int32_byref_List_1_TransferCodingWithQualityHeaderValue_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_TransferCodingWithQualityHeaderValue_byref_Token_0;
	}
}
