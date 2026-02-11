using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x02000195 RID: 405
	[Serializable]
	public class IPAddress : Object
	{
		// Token: 0x06001895 RID: 6293 RVA: 0x0007CD14 File Offset: 0x0007AF14
		// Note: this type is marked as 'beforefieldinit'.
		static IPAddress()
		{
			Il2CppClassPointerStore<IPAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPAddress>.NativeClassPtr);
			IPAddress.NativeFieldInfoPtr_Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "Any");
			IPAddress.NativeFieldInfoPtr_Loopback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "Loopback");
			IPAddress.NativeFieldInfoPtr_Broadcast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "Broadcast");
			IPAddress.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "None");
			IPAddress.NativeFieldInfoPtr_LoopbackMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "LoopbackMask");
			IPAddress.NativeFieldInfoPtr_IPv6Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6Any");
			IPAddress.NativeFieldInfoPtr_IPv6Loopback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6Loopback");
			IPAddress.NativeFieldInfoPtr_IPv6None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6None");
			IPAddress.NativeFieldInfoPtr__addressOrScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "_addressOrScopeId");
			IPAddress.NativeFieldInfoPtr__numbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "_numbers");
			IPAddress.NativeFieldInfoPtr__toString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "_toString");
			IPAddress.NativeFieldInfoPtr__hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "_hashCode");
			IPAddress.NativeFieldInfoPtr_NumberOfLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "NumberOfLabels");
			IPAddress.NativeMethodInfoPtr_get_IsIPv4_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667179);
			IPAddress.NativeMethodInfoPtr_get_IsIPv6_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667180);
			IPAddress.NativeMethodInfoPtr_get_PrivateAddress_Private_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667181);
			IPAddress.NativeMethodInfoPtr_set_PrivateAddress_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667182);
			IPAddress.NativeMethodInfoPtr_get_PrivateScopeId_Private_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667183);
			IPAddress.NativeMethodInfoPtr_set_PrivateScopeId_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667184);
			IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667185);
			IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667186);
			IPAddress.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667187);
			IPAddress.NativeMethodInfoPtr__ctor_Internal_Void_ptr_UInt16_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667188);
			IPAddress.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667189);
			IPAddress.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667190);
			IPAddress.NativeMethodInfoPtr_Parse_Public_Static_IPAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667191);
			IPAddress.NativeMethodInfoPtr_TryWriteBytes_Public_Boolean_Span_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667192);
			IPAddress.NativeMethodInfoPtr_WriteIPv6Bytes_Private_Void_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667193);
			IPAddress.NativeMethodInfoPtr_WriteIPv4Bytes_Private_Void_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667194);
			IPAddress.NativeMethodInfoPtr_GetAddressBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667195);
			IPAddress.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667196);
			IPAddress.NativeMethodInfoPtr_get_ScopeId_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667197);
			IPAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667198);
			IPAddress.NativeMethodInfoPtr_IsLoopback_Public_Static_Boolean_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667199);
			IPAddress.NativeMethodInfoPtr_get_Address_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667200);
			IPAddress.NativeMethodInfoPtr_Equals_Internal_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667201);
			IPAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667202);
			IPAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667203);
			IPAddress.NativeMethodInfoPtr_MapToIPv6_Public_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667204);
			IPAddress.NativeMethodInfoPtr_ThrowAddressNullException_Private_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100667205);
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0007D064 File Offset: 0x0007B264
		public unsafe bool IsIPv4
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 468981, RefRangeEnd = 468982, XrefRangeStart = 468981, XrefRangeEnd = 468982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_IsIPv4_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0007D0A0 File Offset: 0x0007B2A0
		public unsafe bool IsIPv6
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 318072, RefRangeEnd = 318096, XrefRangeStart = 318072, XrefRangeEnd = 318096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_IsIPv6_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0007D0DC File Offset: 0x0007B2DC
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0007D118 File Offset: 0x0007B318
		public unsafe uint PrivateAddress
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_PrivateAddress_Private_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471257, XrefRangeEnd = 471258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_set_PrivateAddress_Private_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x0007D158 File Offset: 0x0007B358
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x0007D194 File Offset: 0x0007B394
		public unsafe uint PrivateScopeId
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_PrivateScopeId_Private_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_set_PrivateScopeId_Private_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0007D1D4 File Offset: 0x0007B3D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 471260, RefRangeEnd = 471264, XrefRangeStart = 471258, XrefRangeEnd = 471260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(long newAddress)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newAddress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0007D21C File Offset: 0x0007B41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471264, XrefRangeEnd = 471267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(Il2CppStructArray<byte> address, long scopeid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0007D278 File Offset: 0x0007B478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471274, RefRangeEnd = 471275, XrefRangeStart = 471267, XrefRangeEnd = 471274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(ReadOnlySpan<byte> address, long scopeid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(address));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0007D2D8 File Offset: 0x0007B4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471275, XrefRangeEnd = 471282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(ushort* numbers, int numbersLength, uint scopeid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = numbers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numbersLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Internal_Void_ptr_UInt16_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0007D33C File Offset: 0x0007B53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471282, XrefRangeEnd = 471285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(Il2CppStructArray<ushort> numbers, uint scopeid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(numbers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt16_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0007D398 File Offset: 0x0007B598
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 471289, RefRangeEnd = 471294, XrefRangeStart = 471285, XrefRangeEnd = 471289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string ipString, out IPAddress address)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ipString);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_IPAddress_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			address = ((intPtr4 == 0) ? null : new IPAddress(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0007D3FC File Offset: 0x0007B5FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 471297, RefRangeEnd = 471301, XrefRangeStart = 471294, XrefRangeEnd = 471297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPAddress Parse(string ipString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ipString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_Parse_Public_Static_IPAddress_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0007D440 File Offset: 0x0007B640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471302, RefRangeEnd = 471303, XrefRangeStart = 471301, XrefRangeEnd = 471302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryWriteBytes(Span<byte> destination, out int bytesWritten)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_TryWriteBytes_Public_Boolean_Span_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0007D4A0 File Offset: 0x0007B6A0
		[CallerCount(0)]
		public unsafe void WriteIPv6Bytes(Span<byte> destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_WriteIPv6Bytes_Private_Void_Span_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0007D4E8 File Offset: 0x0007B6E8
		[CallerCount(0)]
		public unsafe void WriteIPv4Bytes(Span<byte> destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_WriteIPv4Bytes_Private_Void_Span_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0007D530 File Offset: 0x0007B730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 471309, RefRangeEnd = 471311, XrefRangeStart = 471303, XrefRangeEnd = 471309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetAddressBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_GetAddressBytes_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0007D570 File Offset: 0x0007B770
		public unsafe AddressFamily AddressFamily
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 471311, RefRangeEnd = 471325, XrefRangeStart = 471311, XrefRangeEnd = 471311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x0007D5AC File Offset: 0x0007B7AC
		public unsafe long ScopeId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_ScopeId_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0007D5E8 File Offset: 0x0007B7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471325, XrefRangeEnd = 471330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0007D62C File Offset: 0x0007B82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471330, XrefRangeEnd = 471334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLoopback(IPAddress address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_IsLoopback_Public_Static_Boolean_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x0007D670 File Offset: 0x0007B870
		public unsafe long Address
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 471334, RefRangeEnd = 471335, XrefRangeStart = 471334, XrefRangeEnd = 471334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_Address_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0007D6AC File Offset: 0x0007B8AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471338, RefRangeEnd = 471339, XrefRangeStart = 471335, XrefRangeEnd = 471338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Object comparandObj, bool compareScopeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparandObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareScopeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_Equals_Internal_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0007D708 File Offset: 0x0007B908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471339, XrefRangeEnd = 471342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0007D760 File Offset: 0x0007B960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471342, XrefRangeEnd = 471398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0007D7A8 File Offset: 0x0007B9A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 471407, RefRangeEnd = 471408, XrefRangeStart = 471398, XrefRangeEnd = 471407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress MapToIPv6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_MapToIPv6_Public_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0007D7E8 File Offset: 0x0007B9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471408, XrefRangeEnd = 471414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ThrowAddressNullException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_ThrowAddressNullException_Private_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0000A8B0 File Offset: 0x00008AB0
		public IPAddress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x0007D81C File Offset: 0x0007BA1C
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x0000A8B9 File Offset: 0x00008AB9
		public unsafe static IPAddress Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x0007D844 File Offset: 0x0007BA44
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x0000A8CB File Offset: 0x00008ACB
		public unsafe static IPAddress Loopback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_Loopback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_Loopback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x0007D86C File Offset: 0x0007BA6C
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x0000A8DD File Offset: 0x00008ADD
		public unsafe static IPAddress Broadcast
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_Broadcast, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_Broadcast, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x0007D894 File Offset: 0x0007BA94
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x0000A8EF File Offset: 0x00008AEF
		public unsafe static IPAddress None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x0007D8BC File Offset: 0x0007BABC
		// (set) Token: 0x060018BB RID: 6331 RVA: 0x0000A901 File Offset: 0x00008B01
		public unsafe static long LoopbackMask
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_LoopbackMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_LoopbackMask, (void*)(&value));
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x0007D8D8 File Offset: 0x0007BAD8
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x0000A90F File Offset: 0x00008B0F
		public unsafe static IPAddress IPv6Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x0007D900 File Offset: 0x0007BB00
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x0000A921 File Offset: 0x00008B21
		public unsafe static IPAddress IPv6Loopback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6Loopback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6Loopback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x0007D928 File Offset: 0x0007BB28
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x0000A933 File Offset: 0x00008B33
		public unsafe static IPAddress IPv6None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x0007D950 File Offset: 0x0007BB50
		// (set) Token: 0x060018C3 RID: 6339 RVA: 0x0000A945 File Offset: 0x00008B45
		public unsafe uint _addressOrScopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr__addressOrScopeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr__addressOrScopeId)) = value;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0007D978 File Offset: 0x0007BB78
		// (set) Token: 0x060018C5 RID: 6341 RVA: 0x0000A960 File Offset: 0x00008B60
		public unsafe Il2CppStructArray<ushort> _numbers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr__numbers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr__numbers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x0007D9A8 File Offset: 0x0007BBA8
		// (set) Token: 0x060018C7 RID: 6343 RVA: 0x0000A97F File Offset: 0x00008B7F
		public unsafe string _toString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr__toString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr__toString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x0007D9D0 File Offset: 0x0007BBD0
		// (set) Token: 0x060018C9 RID: 6345 RVA: 0x0000A99E File Offset: 0x00008B9E
		public unsafe int _hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr__hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr__hashCode)) = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x0007D9F8 File Offset: 0x0007BBF8
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x0000A9B9 File Offset: 0x00008BB9
		public unsafe static int NumberOfLabels
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_NumberOfLabels, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_NumberOfLabels, (void*)(&value));
			}
		}

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeFieldInfoPtr_Any;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeFieldInfoPtr_Loopback;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeFieldInfoPtr_Broadcast;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeFieldInfoPtr_LoopbackMask;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeFieldInfoPtr_IPv6Any;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeFieldInfoPtr_IPv6Loopback;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeFieldInfoPtr_IPv6None;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeFieldInfoPtr__addressOrScopeId;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeFieldInfoPtr__numbers;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeFieldInfoPtr__toString;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeFieldInfoPtr__hashCode;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfLabels;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIPv4_Private_get_Boolean_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIPv6_Private_get_Boolean_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateAddress_Private_get_UInt32_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_set_PrivateAddress_Private_set_Void_UInt32_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateScopeId_Private_get_UInt32_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_set_PrivateScopeId_Private_set_Void_UInt32_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int64_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_Int64_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_UInt16_Int32_UInt32_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt16_UInt32_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_IPAddress_0;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_IPAddress_String_0;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr_TryWriteBytes_Public_Boolean_Span_1_Byte_byref_Int32_0;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeMethodInfoPtr_WriteIPv6Bytes_Private_Void_Span_1_Byte_0;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeMethodInfoPtr_WriteIPv4Bytes_Private_Void_Span_1_Byte_0;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeMethodInfoPtr_GetAddressBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeMethodInfoPtr_get_ScopeId_Public_get_Int64_0;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr_IsLoopback_Public_Static_Boolean_IPAddress_0;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_Int64_0;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Internal_Boolean_Object_Boolean_0;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_MapToIPv6_Public_IPAddress_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAddressNullException_Private_Static_Il2CppStructArray_1_Byte_0;

		// Token: 0x02000312 RID: 786
		public sealed class ReadOnlyIPAddress : IPAddress
		{
			// Token: 0x06002E90 RID: 11920 RVA: 0x00014CB0 File Offset: 0x00012EB0
			// Note: this type is marked as 'beforefieldinit'.
			static ReadOnlyIPAddress()
			{
				Il2CppClassPointerStore<IPAddress.ReadOnlyIPAddress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "ReadOnlyIPAddress");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPAddress.ReadOnlyIPAddress>.NativeClassPtr);
				IPAddress.ReadOnlyIPAddress.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress.ReadOnlyIPAddress>.NativeClassPtr, 100667207);
			}

			// Token: 0x06002E91 RID: 11921 RVA: 0x000CC180 File Offset: 0x000CA380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471253, XrefRangeEnd = 471257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyIPAddress(long newAddress)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress.ReadOnlyIPAddress>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref newAddress;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.ReadOnlyIPAddress.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E92 RID: 11922 RVA: 0x00014CE4 File Offset: 0x00012EE4
			public ReadOnlyIPAddress(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002484 RID: 9348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;
		}
	}
}
