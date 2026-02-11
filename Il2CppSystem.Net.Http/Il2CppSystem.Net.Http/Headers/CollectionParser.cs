using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200001B RID: 27
	public static class CollectionParser : Object
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x0000B098 File Offset: 0x00009298
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionParser()
		{
			Il2CppClassPointerStore<CollectionParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "CollectionParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionParser>.NativeClassPtr);
			CollectionParser.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_Int32_ElementTryParser_1_T_byref_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionParser>.NativeClassPtr, 100663549);
			CollectionParser.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_Int32_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionParser>.NativeClassPtr, 100663550);
			CollectionParser.NativeMethodInfoPtr_TryParseStringElement_Private_Static_Boolean_Lexer_byref_String_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionParser>.NativeClassPtr, 100663551);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000B104 File Offset: 0x00009304
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1173131, RefRangeEnd = 1173143, XrefRangeStart = 1173114, XrefRangeEnd = 1173131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimalCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parser);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionParser.MethodInfoStoreGeneric_TryParse_Public_Static_Boolean_String_Int32_ElementTryParser_1_T_byref_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new List<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000B188 File Offset: 0x00009388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173143, XrefRangeEnd = 1173152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, int minimalCount, out List<string> result)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionParser.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_Int32_byref_List_1_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new List<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000B1FC File Offset: 0x000093FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173152, XrefRangeEnd = 1173165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseStringElement(Lexer lexer, out string parsedValue, out Token t)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionParser.NativeMethodInfoPtr_TryParseStringElement_Private_Static_Boolean_Lexer_byref_String_byref_Token_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			parsedValue = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002B9B File Offset: 0x00000D9B
		public CollectionParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_Int32_ElementTryParser_1_T_byref_List_1_T_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_Int32_byref_List_1_String_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_TryParseStringElement_Private_Static_Boolean_Lexer_byref_String_byref_Token_0;

		// Token: 0x0200004B RID: 75
		private sealed class MethodInfoStoreGeneric_TryParse_Public_Static_Boolean_String_Int32_ElementTryParser_1_T_byref_List_1_T_0<T>
		{
			// Token: 0x0400032E RID: 814
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionParser.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_Int32_ElementTryParser_1_T_byref_List_1_T_0, Il2CppClassPointerStore<CollectionParser>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
