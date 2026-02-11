using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000217 RID: 535
	public class Normalization : Object
	{
		// Token: 0x06002398 RID: 9112 RVA: 0x000C7F70 File Offset: 0x000C6170
		// Note: this type is marked as 'beforefieldinit'.
		static Normalization()
		{
			Il2CppClassPointerStore<Normalization>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "Normalization");
			Normalization.NativeFieldInfoPtr_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "props");
			Normalization.NativeFieldInfoPtr_mappedChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "mappedChars");
			Normalization.NativeFieldInfoPtr_charMapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "charMapIndex");
			Normalization.NativeFieldInfoPtr_helperIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "helperIndex");
			Normalization.NativeFieldInfoPtr_mapIdxToComposite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "mapIdxToComposite");
			Normalization.NativeFieldInfoPtr_combiningClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "combiningClass");
			Normalization.NativeFieldInfoPtr_forLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "forLock");
			Normalization.NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "isReady");
			Normalization.NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669317);
			Normalization.NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669318);
			Normalization.NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669319);
			Normalization.NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669320);
			Normalization.NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669321);
			Normalization.NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669322);
			Normalization.NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669323);
			Normalization.NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669324);
			Normalization.NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669325);
			Normalization.NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669326);
			Normalization.NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669327);
			Normalization.NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669328);
			Normalization.NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669329);
			Normalization.NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669330);
			Normalization.NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669331);
			Normalization.NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669332);
			Normalization.NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669333);
			Normalization.NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669334);
			Normalization.NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669335);
			Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669336);
			Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669337);
			Normalization.NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669338);
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x000C81F0 File Offset: 0x000C63F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1369037, RefRangeEnd = 1369039, XrefRangeStart = 1369029, XrefRangeEnd = 1369037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint PropValue(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x000C8230 File Offset: 0x000C6430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369039, XrefRangeEnd = 1369047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CharMapIdx(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x000C8270 File Offset: 0x000C6470
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1369056, RefRangeEnd = 1369066, XrefRangeStart = 1369047, XrefRangeEnd = 1369056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte GetCombiningClass(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x000C82B0 File Offset: 0x000C64B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369075, RefRangeEnd = 1369076, XrefRangeStart = 1369066, XrefRangeEnd = 1369075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPrimaryCompositeFromMapIndex(int src)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x000C82F0 File Offset: 0x000C64F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369076, XrefRangeEnd = 1369085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPrimaryCompositeHelperIndex(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x000C8330 File Offset: 0x000C6530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369108, RefRangeEnd = 1369109, XrefRangeStart = 1369085, XrefRangeEnd = 1369108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Compose(string source, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000C837C File Offset: 0x000C657C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369109, XrefRangeEnd = 1369123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder Combine(string source, int start, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x000C83DC File Offset: 0x000C65DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1369148, RefRangeEnd = 1369151, XrefRangeStart = 1369123, XrefRangeEnd = 1369148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Combine(StringBuilder sb, int i, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x000C8430 File Offset: 0x000C6630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369151, XrefRangeEnd = 1369170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHangul(StringBuilder sb, string s, int current)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x000C8494 File Offset: 0x000C6694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369170, XrefRangeEnd = 1369171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Fetch(StringBuilder sb, string s, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x000C84F8 File Offset: 0x000C66F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369184, RefRangeEnd = 1369185, XrefRangeStart = 1369171, XrefRangeEnd = 1369184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x000C855C File Offset: 0x000C675C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369185, XrefRangeEnd = 1369201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TryCompose(int i, int starter, int candidate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref starter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref candidate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x000C85B8 File Offset: 0x000C67B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369267, RefRangeEnd = 1369268, XrefRangeStart = 1369201, XrefRangeEnd = 1369267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Decompose(string source, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x000C8604 File Offset: 0x000C6804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369298, RefRangeEnd = 1369299, XrefRangeStart = 1369268, XrefRangeEnd = 1369298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Decompose(string source, ref StringBuilder sb, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sb = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x000C8670 File Offset: 0x000C6870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1369333, RefRangeEnd = 1369335, XrefRangeStart = 1369299, XrefRangeEnd = 1369333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReorderCanonical(string src, ref StringBuilder sb, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sb = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000C86DC File Offset: 0x000C68DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369335, XrefRangeEnd = 1369353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DecomposeChar(ref StringBuilder sb, ref Il2CppStructArray<int> buf, string s, int i, int checkType, ref int start)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &start;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sb = ((intPtr5 == 0) ? null : new StringBuilder(intPtr5));
			IntPtr intPtr6 = intPtr2;
			buf = ((intPtr6 == 0) ? null : new Il2CppStructArray<int>(intPtr6));
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000C8790 File Offset: 0x000C6990
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1369357, RefRangeEnd = 1369362, XrefRangeStart = 1369353, XrefRangeEnd = 1369357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NormalizationCheck QuickCheck(char c, int type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000C87DC File Offset: 0x000C69DC
		[CallerCount(0)]
		public unsafe static int GetCanonicalHangul(int s, Il2CppStructArray<int> buf, int bufIdx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufIdx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x000C883C File Offset: 0x000C6A3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1369365, RefRangeEnd = 1369368, XrefRangeStart = 1369362, XrefRangeEnd = 1369365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCanonical(int c, Il2CppStructArray<int> buf, int bufIdx, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufIdx;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x000C88A8 File Offset: 0x000C6AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369381, RefRangeEnd = 1369382, XrefRangeStart = 1369368, XrefRangeEnd = 1369381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Normalize(string source, NormalizationForm normalizationForm)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizationForm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x000C88F4 File Offset: 0x000C6AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369389, RefRangeEnd = 1369390, XrefRangeStart = 1369382, XrefRangeEnd = 1369389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Normalize(string source, int type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x000C8940 File Offset: 0x000C6B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369390, XrefRangeEnd = 1369391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &props;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mappedChars;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charMapIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &helperIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mapIdxToComposite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &combiningClass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x0000B615 File Offset: 0x00009815
		public Normalization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x000C89BC File Offset: 0x000C6BBC
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x0000B61E File Offset: 0x0000981E
		public unsafe static byte* props
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_props, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_props, (void*)value);
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x000C89D8 File Offset: 0x000C6BD8
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x0000B62B File Offset: 0x0000982B
		public unsafe static int* mappedChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_mappedChars, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_mappedChars, (void*)value);
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000C89F4 File Offset: 0x000C6BF4
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x0000B638 File Offset: 0x00009838
		public unsafe static short* charMapIndex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_charMapIndex, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_charMapIndex, (void*)value);
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000C8A10 File Offset: 0x000C6C10
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x0000B645 File Offset: 0x00009845
		public unsafe static short* helperIndex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_helperIndex, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_helperIndex, (void*)value);
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000C8A2C File Offset: 0x000C6C2C
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x0000B652 File Offset: 0x00009852
		public unsafe static ushort* mapIdxToComposite
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_mapIdxToComposite, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_mapIdxToComposite, (void*)value);
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x000C8A48 File Offset: 0x000C6C48
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x0000B65F File Offset: 0x0000985F
		public unsafe static byte* combiningClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_combiningClass, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_combiningClass, (void*)value);
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x000C8A64 File Offset: 0x000C6C64
		// (set) Token: 0x060023BD RID: 9149 RVA: 0x0000B66C File Offset: 0x0000986C
		public unsafe static Object forLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_forLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_forLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x000C8A8C File Offset: 0x000C6C8C
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x0000B67E File Offset: 0x0000987E
		public unsafe static bool isReady
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_isReady, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_isReady, (void*)(&value));
			}
		}

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeFieldInfoPtr_props;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeFieldInfoPtr_mappedChars;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeFieldInfoPtr_charMapIndex;

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeFieldInfoPtr_helperIndex;

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeFieldInfoPtr_mapIdxToComposite;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeFieldInfoPtr_combiningClass;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeFieldInfoPtr_forLock;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeFieldInfoPtr_isReady;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0;

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0;

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0;

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0;
	}
}
