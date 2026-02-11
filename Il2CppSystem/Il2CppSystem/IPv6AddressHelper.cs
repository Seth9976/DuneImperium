using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000055 RID: 85
	public static class IPv6AddressHelper : Object
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x0002EF50 File Offset: 0x0002D150
		// Note: this type is marked as 'beforefieldinit'.
		static IPv6AddressHelper()
		{
			Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IPv6AddressHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr);
			IPv6AddressHelper.NativeMethodInfoPtr_FindCompressionRange_Internal_Static_ValueTuple_2_Int32_Int32_ReadOnlySpan_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664169);
			IPv6AddressHelper.NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Internal_Static_Boolean_ReadOnlySpan_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664170);
			IPv6AddressHelper.NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664171);
			IPv6AddressHelper.NativeMethodInfoPtr_Parse_Internal_Static_Void_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664172);
			IPv6AddressHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664173);
			IPv6AddressHelper.NativeMethodInfoPtr_IsLoopback_Private_Static_Boolean_ReadOnlySpan_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664174);
			IPv6AddressHelper.NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664175);
			IPv6AddressHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664176);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0002F020 File Offset: 0x0002D220
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 433536, RefRangeEnd = 433539, XrefRangeStart = 433530, XrefRangeEnd = 433536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<int, int> FindCompressionRange(ReadOnlySpan<ushort> numbers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(numbers));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_FindCompressionRange_Internal_Static_ValueTuple_2_Int32_Int32_ReadOnlySpan_1_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<int, int>(intPtr);
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0002F064 File Offset: 0x0002D264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433539, RefRangeEnd = 433540, XrefRangeStart = 433539, XrefRangeEnd = 433539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldHaveIpv4Embedded(ReadOnlySpan<ushort> numbers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(numbers));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Internal_Static_Boolean_ReadOnlySpan_1_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0002F0AC File Offset: 0x0002D2AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433556, RefRangeEnd = 433557, XrefRangeStart = 433540, XrefRangeEnd = 433556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidStrict(char* name, int start, ref int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0002F104 File Offset: 0x0002D304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433575, RefRangeEnd = 433576, XrefRangeStart = 433557, XrefRangeEnd = 433575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Parse(ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(address));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = numbers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_Parse_Internal_Static_Void_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0002F17C File Offset: 0x0002D37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433576, XrefRangeEnd = 433636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isLoopback;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0002F1F8 File Offset: 0x0002D3F8
		[CallerCount(0)]
		public unsafe static bool IsLoopback(ReadOnlySpan<ushort> numbers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(numbers));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_IsLoopback_Private_Static_Boolean_ReadOnlySpan_1_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0002F240 File Offset: 0x0002D440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433648, RefRangeEnd = 433649, XrefRangeStart = 433636, XrefRangeEnd = 433648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validateStrictAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0002F2A8 File Offset: 0x0002D4A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433650, RefRangeEnd = 433651, XrefRangeStart = 433649, XrefRangeEnd = 433650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char* name, int start, ref int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00003A08 File Offset: 0x00001C08
		public IPv6AddressHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_FindCompressionRange_Internal_Static_ValueTuple_2_Int32_Int32_ReadOnlySpan_1_UInt16_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Internal_Static_Boolean_ReadOnlySpan_1_UInt16_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_Void_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_String_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_IsLoopback_Private_Static_Boolean_ReadOnlySpan_1_UInt16_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0;
	}
}
