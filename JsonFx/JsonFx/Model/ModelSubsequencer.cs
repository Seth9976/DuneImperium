using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using JsonFx.IO;
using JsonFx.Serialization;

namespace JsonFx.Model
{
	// Token: 0x02000021 RID: 33
	public static class ModelSubsequencer : Object
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00009670 File Offset: 0x00007870
		// Note: this type is marked as 'beforefieldinit'.
		static ModelSubsequencer()
		{
			Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Model", "ModelSubsequencer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr);
			ModelSubsequencer.NativeFieldInfoPtr_ErrorUnexpectedEndOfInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, "ErrorUnexpectedEndOfInput");
			ModelSubsequencer.NativeFieldInfoPtr_ErrorInvalidPropertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, "ErrorInvalidPropertyValue");
			ModelSubsequencer.NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663460);
			ModelSubsequencer.NativeMethodInfoPtr_IsObject_Public_Static_Boolean_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663461);
			ModelSubsequencer.NativeMethodInfoPtr_HasProperty_Public_Static_Boolean_IEnumerable_1_Token_Func_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663462);
			ModelSubsequencer.NativeMethodInfoPtr_Property_Public_Static_IEnumerable_1_Token_IEnumerable_1_Token_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663463);
			ModelSubsequencer.NativeMethodInfoPtr_Properties_Public_Static_IEnumerable_1_KeyValuePair_2_String_IEnumerable_1_Token_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663464);
			ModelSubsequencer.NativeMethodInfoPtr_Properties_Public_Static_IEnumerable_1_KeyValuePair_2_String_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663465);
			ModelSubsequencer.NativeMethodInfoPtr_PropertiesIterator_Private_Static_IEnumerable_1_KeyValuePair_2_String_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663466);
			ModelSubsequencer.NativeMethodInfoPtr_IsArray_Public_Static_Boolean_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663467);
			ModelSubsequencer.NativeMethodInfoPtr_ArrayItems_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663468);
			ModelSubsequencer.NativeMethodInfoPtr_ArrayItems_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663469);
			ModelSubsequencer.NativeMethodInfoPtr_ArrayItemsIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663470);
			ModelSubsequencer.NativeMethodInfoPtr_Descendants_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663471);
			ModelSubsequencer.NativeMethodInfoPtr_DescendantsIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663472);
			ModelSubsequencer.NativeMethodInfoPtr_DescendantsAndSelf_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663473);
			ModelSubsequencer.NativeMethodInfoPtr_DescendantsAndSelfIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663474);
			ModelSubsequencer.NativeMethodInfoPtr_SplitValues_Internal_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663475);
			ModelSubsequencer.NativeMethodInfoPtr_SplitValuesIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663476);
			ModelSubsequencer.NativeMethodInfoPtr_SpliceNextValue_Private_Static_IEnumerable_1_Token_Stream_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663477);
			ModelSubsequencer.NativeMethodInfoPtr_SkipNextValue_Private_Static_Void_Stream_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, 100663478);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00009844 File Offset: 0x00007A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1191561, RefRangeEnd = 1191562, XrefRangeStart = 1191545, XrefRangeEnd = 1191561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitive(this IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00009888 File Offset: 0x00007A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1191578, RefRangeEnd = 1191579, XrefRangeStart = 1191562, XrefRangeEnd = 1191578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsObject(this IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_IsObject_Public_Static_Boolean_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000098CC File Offset: 0x00007ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191579, XrefRangeEnd = 1191582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasProperty(this IEnumerable<Token> source, Func<string, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_HasProperty_Public_Static_Boolean_IEnumerable_1_Token_Func_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009920 File Offset: 0x00007B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191582, XrefRangeEnd = 1191611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Token> Property(this IEnumerable<Token> source, string propertyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_Property_Public_Static_IEnumerable_1_Token_IEnumerable_1_Token_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00009978 File Offset: 0x00007B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191611, XrefRangeEnd = 1191612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<string, IEnumerable<Token>>> Properties(this IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_Properties_Public_Static_IEnumerable_1_KeyValuePair_2_String_IEnumerable_1_Token_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, IEnumerable<Token>>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000099BC File Offset: 0x00007BBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1191628, RefRangeEnd = 1191631, XrefRangeStart = 1191612, XrefRangeEnd = 1191628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<string, IEnumerable<Token>>> Properties(this IEnumerable<Token> source, Func<string, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_Properties_Public_Static_IEnumerable_1_KeyValuePair_2_String_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, IEnumerable<Token>>>>(intPtr3) : null;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00009A14 File Offset: 0x00007C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191631, XrefRangeEnd = 1191638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<string, IEnumerable<Token>>> PropertiesIterator(IEnumerable<Token> source, Func<string, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_PropertiesIterator_Private_Static_IEnumerable_1_KeyValuePair_2_String_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, IEnumerable<Token>>>>(intPtr3) : null;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00009A6C File Offset: 0x00007C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1191654, RefRangeEnd = 1191655, XrefRangeStart = 1191638, XrefRangeEnd = 1191654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsArray(this IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_IsArray_Public_Static_Boolean_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00009AB0 File Offset: 0x00007CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191655, XrefRangeEnd = 1191656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<Token>> ArrayItems(this IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_ArrayItems_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<Token>>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00009AF4 File Offset: 0x00007CF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1191672, RefRangeEnd = 1191674, XrefRangeStart = 1191656, XrefRangeEnd = 1191672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<Token>> ArrayItems(this IEnumerable<Token> source, Func<int, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_ArrayItems_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<Token>>>(intPtr3) : null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00009B4C File Offset: 0x00007D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191674, XrefRangeEnd = 1191681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<Token>> ArrayItemsIterator(IEnumerable<Token> source, Func<int, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_ArrayItemsIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<Token>>>(intPtr3) : null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00009BA4 File Offset: 0x00007DA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1191697, RefRangeEnd = 1191699, XrefRangeStart = 1191681, XrefRangeEnd = 1191697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<Token>> Descendants(this IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_Descendants_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<Token>>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1191705, RefRangeEnd = 1191707, XrefRangeStart = 1191699, XrefRangeEnd = 1191705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<Token>> DescendantsIterator(IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_DescendantsIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<Token>>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00009C2C File Offset: 0x00007E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191707, XrefRangeEnd = 1191722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<Token>> DescendantsAndSelf(this IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_DescendantsAndSelf_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<Token>>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009C70 File Offset: 0x00007E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191722, XrefRangeEnd = 1191728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<Token>> DescendantsAndSelfIterator(IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_DescendantsAndSelfIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<Token>>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009CB4 File Offset: 0x00007EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191728, XrefRangeEnd = 1191744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<Token>> SplitValues(this IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_SplitValues_Internal_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<Token>>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009CF8 File Offset: 0x00007EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191744, XrefRangeEnd = 1191750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<Token>> SplitValuesIterator(IEnumerable<Token> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_SplitValuesIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<Token>>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00009D3C File Offset: 0x00007F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1191783, RefRangeEnd = 1191785, XrefRangeStart = 1191750, XrefRangeEnd = 1191783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Token> SpliceNextValue(Stream<Token> stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_SpliceNextValue_Private_Static_IEnumerable_1_Token_Stream_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00009D80 File Offset: 0x00007F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191785, XrefRangeEnd = 1191788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SkipNextValue(Stream<Token> stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.NativeMethodInfoPtr_SkipNextValue_Private_Static_Void_Stream_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public ModelSubsequencer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00009DB8 File Offset: 0x00007FB8
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002ACE File Offset: 0x00000CCE
		public unsafe static string ErrorUnexpectedEndOfInput
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModelSubsequencer.NativeFieldInfoPtr_ErrorUnexpectedEndOfInput, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelSubsequencer.NativeFieldInfoPtr_ErrorUnexpectedEndOfInput, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00009DD8 File Offset: 0x00007FD8
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002AE0 File Offset: 0x00000CE0
		public unsafe static string ErrorInvalidPropertyValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModelSubsequencer.NativeFieldInfoPtr_ErrorInvalidPropertyValue, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelSubsequencer.NativeFieldInfoPtr_ErrorInvalidPropertyValue, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_ErrorUnexpectedEndOfInput;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_ErrorInvalidPropertyValue;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_IEnumerable_1_Token_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_IsObject_Public_Static_Boolean_IEnumerable_1_Token_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Static_Boolean_IEnumerable_1_Token_Func_2_String_Boolean_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_Property_Public_Static_IEnumerable_1_Token_IEnumerable_1_Token_String_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_Properties_Public_Static_IEnumerable_1_KeyValuePair_2_String_IEnumerable_1_Token_IEnumerable_1_Token_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_Properties_Public_Static_IEnumerable_1_KeyValuePair_2_String_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_String_Boolean_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_PropertiesIterator_Private_Static_IEnumerable_1_KeyValuePair_2_String_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_String_Boolean_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_IsArray_Public_Static_Boolean_IEnumerable_1_Token_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_ArrayItems_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_ArrayItems_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_Int32_Boolean_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_ArrayItemsIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_Func_2_Int32_Boolean_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_Descendants_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_DescendantsIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_DescendantsAndSelf_Public_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_DescendantsAndSelfIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_SplitValues_Internal_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_SplitValuesIterator_Private_Static_IEnumerable_1_IEnumerable_1_Token_IEnumerable_1_Token_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_SpliceNextValue_Private_Static_IEnumerable_1_Token_Stream_1_Token_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_SkipNextValue_Private_Static_Void_Stream_1_Token_0;

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("JsonFx.Model.ModelSubsequencer+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06000339 RID: 825 RVA: 0x0000F950 File Offset: 0x0000DB50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<ModelSubsequencer.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelSubsequencer.__c__DisplayClass5_0>.NativeClassPtr);
				ModelSubsequencer.__c__DisplayClass5_0.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer.__c__DisplayClass5_0>.NativeClassPtr, "propertyName");
				ModelSubsequencer.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer.__c__DisplayClass5_0>.NativeClassPtr, 100663479);
				ModelSubsequencer.__c__DisplayClass5_0.NativeMethodInfoPtr__Property_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer.__c__DisplayClass5_0>.NativeClassPtr, 100663480);
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0000F9B8 File Offset: 0x0000DBB8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelSubsequencer.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600033B RID: 827 RVA: 0x0000F9F4 File Offset: 0x0000DBF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Property_b__0(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer.__c__DisplayClass5_0.NativeMethodInfoPtr__Property_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600033C RID: 828 RVA: 0x0000335B File Offset: 0x0000155B
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x0600033D RID: 829 RVA: 0x0000FA44 File Offset: 0x0000DC44
			// (set) Token: 0x0600033E RID: 830 RVA: 0x00003364 File Offset: 0x00001564
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer.__c__DisplayClass5_0.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer.__c__DisplayClass5_0.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400021F RID: 543
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x04000220 RID: 544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000221 RID: 545
			private static readonly IntPtr NativeMethodInfoPtr__Property_b__0_Internal_Boolean_String_0;
		}

		// Token: 0x02000041 RID: 65
		[ObfuscatedName("JsonFx.Model.ModelSubsequencer+<ArrayItemsIterator>d__12")]
		public sealed class _ArrayItemsIterator_d__12 : Object
		{
			// Token: 0x0600033F RID: 831 RVA: 0x0000FA6C File Offset: 0x0000DC6C
			// Note: this type is marked as 'beforefieldinit'.
			static _ArrayItemsIterator_d__12()
			{
				Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, "<ArrayItemsIterator>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr);
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, "<>1__state");
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, "<>2__current");
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, "<>l__initialThreadId");
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, "source");
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, "<>3__source");
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, "predicate");
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___3__predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, "<>3__predicate");
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr__stream_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, "<stream>5__2");
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr__index_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, "<index>5__3");
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, 100663481);
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, 100663482);
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, 100663483);
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, 100663484);
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, 100663485);
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, 100663486);
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, 100663487);
				ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr, 100663488);
			}

			// Token: 0x06000340 RID: 832 RVA: 0x0000FBEC File Offset: 0x0000DDEC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ArrayItemsIterator_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelSubsequencer._ArrayItemsIterator_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000341 RID: 833 RVA: 0x0000FC34 File Offset: 0x0000DE34
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000342 RID: 834 RVA: 0x0000FC68 File Offset: 0x0000DE68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191302, XrefRangeEnd = 1191304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x06000343 RID: 835 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
			public unsafe IEnumerable<Token> System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<JsonFx.Serialization.Token>>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
				}
			}

			// Token: 0x06000344 RID: 836 RVA: 0x0000FCE4 File Offset: 0x0000DEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191304, XrefRangeEnd = 1191309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x06000345 RID: 837 RVA: 0x0000FD18 File Offset: 0x0000DF18
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000346 RID: 838 RVA: 0x0000FD58 File Offset: 0x0000DF58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191309, XrefRangeEnd = 1191318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IEnumerable<Token>> System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<Token>>>(intPtr3) : null;
			}

			// Token: 0x06000347 RID: 839 RVA: 0x0000FD98 File Offset: 0x0000DF98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._ArrayItemsIterator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000348 RID: 840 RVA: 0x00003383 File Offset: 0x00001583
			public _ArrayItemsIterator_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x06000349 RID: 841 RVA: 0x0000FDD8 File Offset: 0x0000DFD8
			// (set) Token: 0x0600034A RID: 842 RVA: 0x0000338C File Offset: 0x0000158C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x0600034B RID: 843 RVA: 0x0000FE00 File Offset: 0x0000E000
			// (set) Token: 0x0600034C RID: 844 RVA: 0x000033A7 File Offset: 0x000015A7
			public unsafe IEnumerable<Token> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x0600034D RID: 845 RVA: 0x0000FE30 File Offset: 0x0000E030
			// (set) Token: 0x0600034E RID: 846 RVA: 0x000033C6 File Offset: 0x000015C6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x0600034F RID: 847 RVA: 0x0000FE58 File Offset: 0x0000E058
			// (set) Token: 0x06000350 RID: 848 RVA: 0x000033E1 File Offset: 0x000015E1
			public unsafe IEnumerable<Token> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x06000351 RID: 849 RVA: 0x0000FE88 File Offset: 0x0000E088
			// (set) Token: 0x06000352 RID: 850 RVA: 0x00003400 File Offset: 0x00001600
			public unsafe IEnumerable<Token> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x06000353 RID: 851 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
			// (set) Token: 0x06000354 RID: 852 RVA: 0x0000341F File Offset: 0x0000161F
			public unsafe Func<int, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x06000355 RID: 853 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
			// (set) Token: 0x06000356 RID: 854 RVA: 0x0000343E File Offset: 0x0000163E
			public unsafe Func<int, bool> __3__predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___3__predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr___3__predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x06000357 RID: 855 RVA: 0x0000FF18 File Offset: 0x0000E118
			// (set) Token: 0x06000358 RID: 856 RVA: 0x0000345D File Offset: 0x0000165D
			public unsafe Stream<Token> _stream_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr__stream_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr__stream_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x06000359 RID: 857 RVA: 0x0000FF48 File Offset: 0x0000E148
			// (set) Token: 0x0600035A RID: 858 RVA: 0x0000347C File Offset: 0x0000167C
			public unsafe int _index_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr__index_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._ArrayItemsIterator_d__12.NativeFieldInfoPtr__index_5__3)) = value;
				}
			}

			// Token: 0x04000222 RID: 546
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000223 RID: 547
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000224 RID: 548
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000225 RID: 549
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000226 RID: 550
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000227 RID: 551
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000228 RID: 552
			private static readonly IntPtr NativeFieldInfoPtr___3__predicate;

			// Token: 0x04000229 RID: 553
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__2;

			// Token: 0x0400022A RID: 554
			private static readonly IntPtr NativeFieldInfoPtr__index_5__3;

			// Token: 0x0400022B RID: 555
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400022C RID: 556
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400022D RID: 557
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0;

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000230 RID: 560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000231 RID: 561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0;

			// Token: 0x04000232 RID: 562
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000042 RID: 66
		[ObfuscatedName("JsonFx.Model.ModelSubsequencer+<DescendantsAndSelfIterator>d__16")]
		public sealed class _DescendantsAndSelfIterator_d__16 : Object
		{
			// Token: 0x0600035B RID: 859 RVA: 0x0000FF70 File Offset: 0x0000E170
			// Note: this type is marked as 'beforefieldinit'.
			static _DescendantsAndSelfIterator_d__16()
			{
				Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, "<DescendantsAndSelfIterator>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr);
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, "<>1__state");
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, "<>2__current");
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, "<>l__initialThreadId");
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, "source");
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, "<>3__source");
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, "<>7__wrap1");
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, 100663489);
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, 100663490);
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, 100663491);
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, 100663492);
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, 100663493);
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, 100663494);
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, 100663495);
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, 100663496);
				ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr, 100663497);
			}

			// Token: 0x0600035C RID: 860 RVA: 0x000100C8 File Offset: 0x0000E2C8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DescendantsAndSelfIterator_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelSubsequencer._DescendantsAndSelfIterator_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600035D RID: 861 RVA: 0x00010110 File Offset: 0x0000E310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191318, XrefRangeEnd = 1191323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600035E RID: 862 RVA: 0x00010144 File Offset: 0x0000E344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191323, XrefRangeEnd = 1191345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600035F RID: 863 RVA: 0x00010180 File Offset: 0x0000E380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191345, XrefRangeEnd = 1191348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000360 RID: 864 RVA: 0x000101B4 File Offset: 0x0000E3B4
			public unsafe IEnumerable<Token> System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<JsonFx.Serialization.Token>>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
				}
			}

			// Token: 0x06000361 RID: 865 RVA: 0x000101F4 File Offset: 0x0000E3F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191348, XrefRangeEnd = 1191353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000362 RID: 866 RVA: 0x00010228 File Offset: 0x0000E428
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000363 RID: 867 RVA: 0x00010268 File Offset: 0x0000E468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191353, XrefRangeEnd = 1191361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IEnumerable<Token>> System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<Token>>>(intPtr3) : null;
			}

			// Token: 0x06000364 RID: 868 RVA: 0x000102A8 File Offset: 0x0000E4A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000365 RID: 869 RVA: 0x00003497 File Offset: 0x00001697
			public _DescendantsAndSelfIterator_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x06000366 RID: 870 RVA: 0x000102E8 File Offset: 0x0000E4E8
			// (set) Token: 0x06000367 RID: 871 RVA: 0x000034A0 File Offset: 0x000016A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x06000368 RID: 872 RVA: 0x00010310 File Offset: 0x0000E510
			// (set) Token: 0x06000369 RID: 873 RVA: 0x000034BB File Offset: 0x000016BB
			public unsafe IEnumerable<Token> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x0600036A RID: 874 RVA: 0x00010340 File Offset: 0x0000E540
			// (set) Token: 0x0600036B RID: 875 RVA: 0x000034DA File Offset: 0x000016DA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x0600036C RID: 876 RVA: 0x00010368 File Offset: 0x0000E568
			// (set) Token: 0x0600036D RID: 877 RVA: 0x000034F5 File Offset: 0x000016F5
			public unsafe IEnumerable<Token> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x0600036E RID: 878 RVA: 0x00010398 File Offset: 0x0000E598
			// (set) Token: 0x0600036F RID: 879 RVA: 0x00003514 File Offset: 0x00001714
			public unsafe IEnumerable<Token> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000370 RID: 880 RVA: 0x000103C8 File Offset: 0x0000E5C8
			// (set) Token: 0x06000371 RID: 881 RVA: 0x00003533 File Offset: 0x00001733
			public unsafe IEnumerator<IEnumerable<Token>> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<Token>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsAndSelfIterator_d__16.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000236 RID: 566
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000237 RID: 567
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000238 RID: 568
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000239 RID: 569
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400023A RID: 570
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400023B RID: 571
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400023C RID: 572
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400023D RID: 573
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0;

			// Token: 0x0400023E RID: 574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400023F RID: 575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000240 RID: 576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0;

			// Token: 0x04000241 RID: 577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000043 RID: 67
		[ObfuscatedName("JsonFx.Model.ModelSubsequencer+<DescendantsIterator>d__14")]
		public sealed class _DescendantsIterator_d__14 : Object
		{
			// Token: 0x06000372 RID: 882 RVA: 0x000103F8 File Offset: 0x0000E5F8
			// Note: this type is marked as 'beforefieldinit'.
			static _DescendantsIterator_d__14()
			{
				Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, "<DescendantsIterator>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr);
				ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, "<>1__state");
				ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, "<>2__current");
				ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, "<>l__initialThreadId");
				ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, "source");
				ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, "<>3__source");
				ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, "<>7__wrap1");
				ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr__property_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, "<property>5__3");
				ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, "<>7__wrap3");
				ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr__item_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, "<item>5__5");
				ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, "<>7__wrap5");
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663498);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663499);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663500);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663501);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663502);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663503);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663504);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663505);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663506);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663507);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663508);
				ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr, 100663509);
			}

			// Token: 0x06000373 RID: 883 RVA: 0x000105DC File Offset: 0x0000E7DC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DescendantsIterator_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelSubsequencer._DescendantsIterator_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000374 RID: 884 RVA: 0x00010624 File Offset: 0x0000E824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191361, XrefRangeEnd = 1191382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000375 RID: 885 RVA: 0x00010658 File Offset: 0x0000E858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191382, XrefRangeEnd = 1191458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000376 RID: 886 RVA: 0x00010694 File Offset: 0x0000E894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191458, XrefRangeEnd = 1191461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000377 RID: 887 RVA: 0x000106C8 File Offset: 0x0000E8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191461, XrefRangeEnd = 1191464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000378 RID: 888 RVA: 0x000106FC File Offset: 0x0000E8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191464, XrefRangeEnd = 1191467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000379 RID: 889 RVA: 0x00010730 File Offset: 0x0000E930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191467, XrefRangeEnd = 1191470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x0600037A RID: 890 RVA: 0x00010764 File Offset: 0x0000E964
			public unsafe IEnumerable<Token> System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<JsonFx.Serialization.Token>>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
				}
			}

			// Token: 0x0600037B RID: 891 RVA: 0x000107A4 File Offset: 0x0000E9A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191470, XrefRangeEnd = 1191475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x0600037C RID: 892 RVA: 0x000107D8 File Offset: 0x0000E9D8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600037D RID: 893 RVA: 0x00010818 File Offset: 0x0000EA18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191475, XrefRangeEnd = 1191483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IEnumerable<Token>> System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<Token>>>(intPtr3) : null;
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00010858 File Offset: 0x0000EA58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._DescendantsIterator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600037F RID: 895 RVA: 0x00003552 File Offset: 0x00001752
			public _DescendantsIterator_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x06000380 RID: 896 RVA: 0x00010898 File Offset: 0x0000EA98
			// (set) Token: 0x06000381 RID: 897 RVA: 0x0000355B File Offset: 0x0000175B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000382 RID: 898 RVA: 0x000108C0 File Offset: 0x0000EAC0
			// (set) Token: 0x06000383 RID: 899 RVA: 0x00003576 File Offset: 0x00001776
			public unsafe IEnumerable<Token> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000384 RID: 900 RVA: 0x000108F0 File Offset: 0x0000EAF0
			// (set) Token: 0x06000385 RID: 901 RVA: 0x00003595 File Offset: 0x00001795
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000386 RID: 902 RVA: 0x00010918 File Offset: 0x0000EB18
			// (set) Token: 0x06000387 RID: 903 RVA: 0x000035B0 File Offset: 0x000017B0
			public unsafe IEnumerable<Token> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x06000388 RID: 904 RVA: 0x00010948 File Offset: 0x0000EB48
			// (set) Token: 0x06000389 RID: 905 RVA: 0x000035CF File Offset: 0x000017CF
			public unsafe IEnumerable<Token> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x0600038A RID: 906 RVA: 0x00010978 File Offset: 0x0000EB78
			// (set) Token: 0x0600038B RID: 907 RVA: 0x000035EE File Offset: 0x000017EE
			public unsafe IEnumerator<KeyValuePair<string, IEnumerable<Token>>> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, IEnumerable<Token>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x0600038C RID: 908 RVA: 0x000109A8 File Offset: 0x0000EBA8
			// (set) Token: 0x0600038D RID: 909 RVA: 0x0000360D File Offset: 0x0000180D
			public KeyValuePair<string, IEnumerable<Token>> _property_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr__property_5__3);
					return new KeyValuePair<string, IEnumerable<Token>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, IEnumerable<Token>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr__property_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, IEnumerable<Token>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x0600038E RID: 910 RVA: 0x000109D8 File Offset: 0x0000EBD8
			// (set) Token: 0x0600038F RID: 911 RVA: 0x0000363B File Offset: 0x0000183B
			public unsafe IEnumerator<IEnumerable<Token>> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<Token>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000390 RID: 912 RVA: 0x00010A08 File Offset: 0x0000EC08
			// (set) Token: 0x06000391 RID: 913 RVA: 0x0000365A File Offset: 0x0000185A
			public unsafe IEnumerable<Token> _item_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr__item_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr__item_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000392 RID: 914 RVA: 0x00010A38 File Offset: 0x0000EC38
			// (set) Token: 0x06000393 RID: 915 RVA: 0x00003679 File Offset: 0x00001879
			public unsafe IEnumerator<IEnumerable<Token>> __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___7__wrap5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<Token>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._DescendantsIterator_d__14.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000242 RID: 578
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000243 RID: 579
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000244 RID: 580
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000245 RID: 581
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000246 RID: 582
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000247 RID: 583
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000248 RID: 584
			private static readonly IntPtr NativeFieldInfoPtr__property_5__3;

			// Token: 0x04000249 RID: 585
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400024A RID: 586
			private static readonly IntPtr NativeFieldInfoPtr__item_5__5;

			// Token: 0x0400024B RID: 587
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x0400024C RID: 588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400024D RID: 589
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400024E RID: 590
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400024F RID: 591
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000250 RID: 592
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04000251 RID: 593
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04000252 RID: 594
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x04000253 RID: 595
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0;

			// Token: 0x04000254 RID: 596
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000255 RID: 597
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000256 RID: 598
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0;

			// Token: 0x04000257 RID: 599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000044 RID: 68
		[ObfuscatedName("JsonFx.Model.ModelSubsequencer+<PropertiesIterator>d__8")]
		public sealed class _PropertiesIterator_d__8 : Object
		{
			// Token: 0x06000394 RID: 916 RVA: 0x00010A68 File Offset: 0x0000EC68
			// Note: this type is marked as 'beforefieldinit'.
			static _PropertiesIterator_d__8()
			{
				Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, "<PropertiesIterator>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr);
				ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, "<>1__state");
				ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, "<>2__current");
				ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, "<>l__initialThreadId");
				ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, "source");
				ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, "<>3__source");
				ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, "predicate");
				ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___3__predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, "<>3__predicate");
				ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr__stream_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, "<stream>5__2");
				ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr__depth_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, "<depth>5__3");
				ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, 100663510);
				ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, 100663511);
				ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, 100663512);
				ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, 100663513);
				ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, 100663514);
				ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, 100663515);
				ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, 100663516);
				ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr, 100663517);
			}

			// Token: 0x06000395 RID: 917 RVA: 0x00010BE8 File Offset: 0x0000EDE8
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PropertiesIterator_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelSubsequencer._PropertiesIterator_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000396 RID: 918 RVA: 0x00010C30 File Offset: 0x0000EE30
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000397 RID: 919 RVA: 0x00010C64 File Offset: 0x0000EE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191483, XrefRangeEnd = 1191493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x06000398 RID: 920 RVA: 0x00010CA0 File Offset: 0x0000EEA0
			public unsafe KeyValuePair<string, IEnumerable<Token>> prop_KeyValuePair_2_String_IEnumerable_1_Token_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, IEnumerable<Token>>(intPtr);
				}
			}

			// Token: 0x06000399 RID: 921 RVA: 0x00010CD8 File Offset: 0x0000EED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191493, XrefRangeEnd = 1191498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600039A RID: 922 RVA: 0x00010D0C File Offset: 0x0000EF0C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191498, XrefRangeEnd = 1191501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600039B RID: 923 RVA: 0x00010D4C File Offset: 0x0000EF4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191501, XrefRangeEnd = 1191510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<string, IEnumerable<Token>>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IEnumerable_1_Token_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, IEnumerable<Token>>>>(intPtr3) : null;
			}

			// Token: 0x0600039C RID: 924 RVA: 0x00010D8C File Offset: 0x0000EF8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._PropertiesIterator_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600039D RID: 925 RVA: 0x00003698 File Offset: 0x00001898
			public _PropertiesIterator_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x0600039E RID: 926 RVA: 0x00010DCC File Offset: 0x0000EFCC
			// (set) Token: 0x0600039F RID: 927 RVA: 0x000036A1 File Offset: 0x000018A1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x060003A0 RID: 928 RVA: 0x00010DF4 File Offset: 0x0000EFF4
			// (set) Token: 0x060003A1 RID: 929 RVA: 0x000036BC File Offset: 0x000018BC
			public KeyValuePair<string, IEnumerable<Token>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, IEnumerable<Token>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, IEnumerable<Token>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, IEnumerable<Token>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x060003A2 RID: 930 RVA: 0x00010E24 File Offset: 0x0000F024
			// (set) Token: 0x060003A3 RID: 931 RVA: 0x000036EA File Offset: 0x000018EA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x060003A4 RID: 932 RVA: 0x00010E4C File Offset: 0x0000F04C
			// (set) Token: 0x060003A5 RID: 933 RVA: 0x00003705 File Offset: 0x00001905
			public unsafe IEnumerable<Token> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x060003A6 RID: 934 RVA: 0x00010E7C File Offset: 0x0000F07C
			// (set) Token: 0x060003A7 RID: 935 RVA: 0x00003724 File Offset: 0x00001924
			public unsafe IEnumerable<Token> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x060003A8 RID: 936 RVA: 0x00010EAC File Offset: 0x0000F0AC
			// (set) Token: 0x060003A9 RID: 937 RVA: 0x00003743 File Offset: 0x00001943
			public unsafe Func<string, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x060003AA RID: 938 RVA: 0x00010EDC File Offset: 0x0000F0DC
			// (set) Token: 0x060003AB RID: 939 RVA: 0x00003762 File Offset: 0x00001962
			public unsafe Func<string, bool> __3__predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___3__predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr___3__predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x060003AC RID: 940 RVA: 0x00010F0C File Offset: 0x0000F10C
			// (set) Token: 0x060003AD RID: 941 RVA: 0x00003781 File Offset: 0x00001981
			public unsafe Stream<Token> _stream_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr__stream_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr__stream_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x060003AE RID: 942 RVA: 0x00010F3C File Offset: 0x0000F13C
			// (set) Token: 0x060003AF RID: 943 RVA: 0x000037A0 File Offset: 0x000019A0
			public unsafe int _depth_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr__depth_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._PropertiesIterator_d__8.NativeFieldInfoPtr__depth_5__3)) = value;
				}
			}

			// Token: 0x04000258 RID: 600
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000259 RID: 601
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400025A RID: 602
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400025B RID: 603
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400025C RID: 604
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x0400025D RID: 605
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x0400025E RID: 606
			private static readonly IntPtr NativeFieldInfoPtr___3__predicate;

			// Token: 0x0400025F RID: 607
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__2;

			// Token: 0x04000260 RID: 608
			private static readonly IntPtr NativeFieldInfoPtr__depth_5__3;

			// Token: 0x04000261 RID: 609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000262 RID: 610
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000263 RID: 611
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000264 RID: 612
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IEnumerable_1_Token_0;

			// Token: 0x04000265 RID: 613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000266 RID: 614
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000267 RID: 615
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IEnumerable_1_Token_0;

			// Token: 0x04000268 RID: 616
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000045 RID: 69
		[ObfuscatedName("JsonFx.Model.ModelSubsequencer+<SplitValuesIterator>d__18")]
		public sealed class _SplitValuesIterator_d__18 : Object
		{
			// Token: 0x060003B0 RID: 944 RVA: 0x00010F64 File Offset: 0x0000F164
			// Note: this type is marked as 'beforefieldinit'.
			static _SplitValuesIterator_d__18()
			{
				Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModelSubsequencer>.NativeClassPtr, "<SplitValuesIterator>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr);
				ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, "<>1__state");
				ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, "<>2__current");
				ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, "<>l__initialThreadId");
				ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, "source");
				ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, "<>3__source");
				ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr__stream_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, "<stream>5__2");
				ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, 100663518);
				ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, 100663519);
				ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, 100663520);
				ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, 100663521);
				ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, 100663522);
				ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, 100663523);
				ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, 100663524);
				ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, 100663525);
				ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr, 100663526);
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x000110BC File Offset: 0x0000F2BC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SplitValuesIterator_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelSubsequencer._SplitValuesIterator_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x00011104 File Offset: 0x0000F304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191510, XrefRangeEnd = 1191515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x00011138 File Offset: 0x0000F338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191515, XrefRangeEnd = 1191529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x00011174 File Offset: 0x0000F374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191529, XrefRangeEnd = 1191532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x000111A8 File Offset: 0x0000F3A8
			public unsafe IEnumerable<Token> System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<JsonFx.Serialization.Token>>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
				}
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x000111E8 File Offset: 0x0000F3E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191532, XrefRangeEnd = 1191537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x0001121C File Offset: 0x0000F41C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x0001125C File Offset: 0x0000F45C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191537, XrefRangeEnd = 1191545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IEnumerable<Token>> System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<Token>>>(intPtr3) : null;
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x0001129C File Offset: 0x0000F49C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelSubsequencer._SplitValuesIterator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060003BA RID: 954 RVA: 0x000037BB File Offset: 0x000019BB
			public _SplitValuesIterator_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x060003BB RID: 955 RVA: 0x000112DC File Offset: 0x0000F4DC
			// (set) Token: 0x060003BC RID: 956 RVA: 0x000037C4 File Offset: 0x000019C4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x060003BD RID: 957 RVA: 0x00011304 File Offset: 0x0000F504
			// (set) Token: 0x060003BE RID: 958 RVA: 0x000037DF File Offset: 0x000019DF
			public unsafe IEnumerable<Token> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x060003BF RID: 959 RVA: 0x00011334 File Offset: 0x0000F534
			// (set) Token: 0x060003C0 RID: 960 RVA: 0x000037FE File Offset: 0x000019FE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x060003C1 RID: 961 RVA: 0x0001135C File Offset: 0x0000F55C
			// (set) Token: 0x060003C2 RID: 962 RVA: 0x00003819 File Offset: 0x00001A19
			public unsafe IEnumerable<Token> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x060003C3 RID: 963 RVA: 0x0001138C File Offset: 0x0000F58C
			// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003838 File Offset: 0x00001A38
			public unsafe IEnumerable<Token> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x060003C5 RID: 965 RVA: 0x000113BC File Offset: 0x0000F5BC
			// (set) Token: 0x060003C6 RID: 966 RVA: 0x00003857 File Offset: 0x00001A57
			public unsafe Stream<Token> _stream_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr__stream_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream<Token>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelSubsequencer._SplitValuesIterator_d__18.NativeFieldInfoPtr__stream_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000269 RID: 617
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400026A RID: 618
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400026B RID: 619
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400026C RID: 620
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400026D RID: 621
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x0400026E RID: 622
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__2;

			// Token: 0x0400026F RID: 623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000270 RID: 624
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000271 RID: 625
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000272 RID: 626
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000273 RID: 627
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_Token_0;

			// Token: 0x04000274 RID: 628
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000275 RID: 629
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000276 RID: 630
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_Token_0;

			// Token: 0x04000277 RID: 631
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
