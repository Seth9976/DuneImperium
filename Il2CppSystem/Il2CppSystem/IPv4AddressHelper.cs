using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000054 RID: 84
	public static class IPv4AddressHelper : Object
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x0002EB8C File Offset: 0x0002CD8C
		// Note: this type is marked as 'beforefieldinit'.
		static IPv4AddressHelper()
		{
			Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IPv4AddressHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr);
			IPv4AddressHelper.NativeMethodInfoPtr_ParseHostNumber_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100664162);
			IPv4AddressHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100664163);
			IPv4AddressHelper.NativeMethodInfoPtr_ParseCanonical_Private_Static_Boolean_ReadOnlySpan_1_Char_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100664164);
			IPv4AddressHelper.NativeMethodInfoPtr_IsValidCanonical_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100664165);
			IPv4AddressHelper.NativeMethodInfoPtr_ParseNonCanonical_Internal_Static_Int64_ptr_Char_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100664166);
			IPv4AddressHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100664167);
			IPv4AddressHelper.NativeMethodInfoPtr_Parse_Private_Static_Boolean_String_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100664168);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0002EC48 File Offset: 0x0002CE48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433493, RefRangeEnd = 433494, XrefRangeStart = 433493, XrefRangeEnd = 433493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseHostNumber(ReadOnlySpan<char> str, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_ParseHostNumber_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0002ECAC File Offset: 0x0002CEAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 433495, RefRangeEnd = 433498, XrefRangeStart = 433494, XrefRangeEnd = 433495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowIPv6;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unknownScheme;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0002ED30 File Offset: 0x0002CF30
		[CallerCount(0)]
		public unsafe static bool ParseCanonical(ReadOnlySpan<char> name, byte* numbers, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(name));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = numbers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_ParseCanonical_Private_Static_Boolean_ReadOnlySpan_1_Char_ptr_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0002EDA0 File Offset: 0x0002CFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433498, XrefRangeEnd = 433500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowIPv6;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_IsValidCanonical_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0002EE14 File Offset: 0x0002D014
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 433503, RefRangeEnd = 433508, XrefRangeStart = 433500, XrefRangeEnd = 433503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_ParseNonCanonical_Internal_Static_Int64_ptr_Char_Int32_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0002EE7C File Offset: 0x0002D07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433508, XrefRangeEnd = 433528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isLoopback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0002EEE4 File Offset: 0x0002D0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433528, XrefRangeEnd = 433530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Parse(string name, byte* numbers, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = numbers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_Parse_Private_Static_Boolean_String_ptr_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000039FF File Offset: 0x00001BFF
		public IPv4AddressHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_ParseHostNumber_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_Boolean_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonical_Private_Static_Boolean_ReadOnlySpan_1_Char_ptr_Byte_Int32_Int32_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCanonical_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_ParseNonCanonical_Internal_Static_Int64_ptr_Char_Int32_byref_Int32_Boolean_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Static_Boolean_String_ptr_Byte_Int32_Int32_0;
	}
}
