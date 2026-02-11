using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x02000196 RID: 406
	public class IPAddressParser : Object
	{
		// Token: 0x060018CC RID: 6348 RVA: 0x0007DA14 File Offset: 0x0007BC14
		// Note: this type is marked as 'beforefieldinit'.
		static IPAddressParser()
		{
			Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPAddressParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr);
			IPAddressParser.NativeMethodInfoPtr_Parse_Internal_Static_IPAddress_ReadOnlySpan_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667208);
			IPAddressParser.NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667209);
			IPAddressParser.NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_Void_UInt32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667210);
			IPAddressParser.NativeMethodInfoPtr_IPv4AddressToStringHelper_Private_Static_Int32_UInt32_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667211);
			IPAddressParser.NativeMethodInfoPtr_IPv6AddressToString_Internal_Static_String_Il2CppStructArray_1_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667212);
			IPAddressParser.NativeMethodInfoPtr_IPv6AddressToStringHelper_Internal_Static_StringBuilder_Il2CppStructArray_1_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667213);
			IPAddressParser.NativeMethodInfoPtr_FormatIPv4AddressNumber_Private_Static_Void_Int32_ptr_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667214);
			IPAddressParser.NativeMethodInfoPtr_Ipv4StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667215);
			IPAddressParser.NativeMethodInfoPtr_Ipv6StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667216);
			IPAddressParser.NativeMethodInfoPtr_AppendSections_Private_Static_Void_Il2CppStructArray_1_UInt16_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667217);
			IPAddressParser.NativeMethodInfoPtr_AppendHex_Private_Static_Void_UInt16_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667218);
			IPAddressParser.NativeMethodInfoPtr_ExtractIPv4Address_Private_Static_UInt32_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667219);
			IPAddressParser.NativeMethodInfoPtr_Reverse_Private_Static_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100667220);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0007DB48 File Offset: 0x0007BD48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 471427, RefRangeEnd = 471429, XrefRangeStart = 471414, XrefRangeEnd = 471427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ipSpan));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_Parse_Internal_Static_IPAddress_ReadOnlySpan_1_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0007DBA0 File Offset: 0x0007BDA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471431, RefRangeEnd = 471432, XrefRangeStart = 471429, XrefRangeEnd = 471431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IPv4AddressToString(uint address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref address;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0007DBD8 File Offset: 0x0007BDD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471434, RefRangeEnd = 471435, XrefRangeStart = 471432, XrefRangeEnd = 471434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IPv4AddressToString(uint address, StringBuilder destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref address;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_Void_UInt32_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0007DC1C File Offset: 0x0007BE1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 471454, RefRangeEnd = 471456, XrefRangeStart = 471435, XrefRangeEnd = 471454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IPv4AddressToStringHelper(uint address, char* addressString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref address;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = addressString;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_IPv4AddressToStringHelper_Private_Static_Int32_UInt32_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0007DC68 File Offset: 0x0007BE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471456, XrefRangeEnd = 471458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IPv6AddressToString(Il2CppStructArray<ushort> address, uint scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_IPv6AddressToString_Internal_Static_String_Il2CppStructArray_1_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0007DCB4 File Offset: 0x0007BEB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 471496, RefRangeEnd = 471498, XrefRangeStart = 471458, XrefRangeEnd = 471496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder IPv6AddressToStringHelper(Il2CppStructArray<ushort> address, uint scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_IPv6AddressToStringHelper_Internal_Static_StringBuilder_Il2CppStructArray_1_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0007DD08 File Offset: 0x0007BF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471498, XrefRangeEnd = 471503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = addressString;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_FormatIPv4AddressNumber_Private_Static_Void_Int32_ptr_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0007DD58 File Offset: 0x0007BF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471503, XrefRangeEnd = 471508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ipSpan));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &address;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_Ipv4StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0007DDAC File Offset: 0x0007BFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471508, XrefRangeEnd = 471513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ipSpan));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = numbers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numbersLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_Ipv6StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0007DE1C File Offset: 0x0007C01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471513, XrefRangeEnd = 471526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendSections(Il2CppStructArray<ushort> address, int fromInclusive, int toExclusive, StringBuilder buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromInclusive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toExclusive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_AppendSections_Private_Static_Void_Il2CppStructArray_1_UInt16_Int32_Int32_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0007DE80 File Offset: 0x0007C080
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 471527, RefRangeEnd = 471533, XrefRangeStart = 471526, XrefRangeEnd = 471527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendHex(ushort value, StringBuilder buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_AppendHex_Private_Static_Void_UInt16_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0007DEC4 File Offset: 0x0007C0C4
		[CallerCount(0)]
		public unsafe static uint ExtractIPv4Address(Il2CppStructArray<ushort> address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_ExtractIPv4Address_Private_Static_UInt32_Il2CppStructArray_1_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0007DF08 File Offset: 0x0007C108
		[CallerCount(0)]
		public unsafe static ushort Reverse(ushort number)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddressParser.NativeMethodInfoPtr_Reverse_Private_Static_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0000A9C7 File Offset: 0x00008BC7
		public IPAddressParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_IPAddress_ReadOnlySpan_1_Char_Boolean_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_String_UInt32_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_Void_UInt32_StringBuilder_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_IPv4AddressToStringHelper_Private_Static_Int32_UInt32_ptr_Char_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_IPv6AddressToString_Internal_Static_String_Il2CppStructArray_1_UInt16_UInt32_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_IPv6AddressToStringHelper_Internal_Static_StringBuilder_Il2CppStructArray_1_UInt16_UInt32_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_FormatIPv4AddressNumber_Private_Static_Void_Int32_ptr_Char_byref_Int32_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_Ipv4StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Int64_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_Ipv6StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_UInt32_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_AppendSections_Private_Static_Void_Il2CppStructArray_1_UInt16_Int32_Int32_StringBuilder_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_AppendHex_Private_Static_Void_UInt16_StringBuilder_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_ExtractIPv4Address_Private_Static_UInt32_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Private_Static_UInt16_UInt16_0;
	}
}
