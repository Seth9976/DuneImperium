using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x020001BF RID: 447
	public class SocketAddress : Object
	{
		// Token: 0x06001B6B RID: 7019 RVA: 0x00087430 File Offset: 0x00085630
		// Note: this type is marked as 'beforefieldinit'.
		static SocketAddress()
		{
			Il2CppClassPointerStore<SocketAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "SocketAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr);
			SocketAddress.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, "m_Size");
			SocketAddress.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, "m_Buffer");
			SocketAddress.NativeFieldInfoPtr_m_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, "m_changed");
			SocketAddress.NativeFieldInfoPtr_m_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, "m_hash");
			SocketAddress.NativeMethodInfoPtr_get_Family_Public_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667524);
			SocketAddress.NativeMethodInfoPtr_get_Size_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667525);
			SocketAddress.NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667526);
			SocketAddress.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667527);
			SocketAddress.NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667528);
			SocketAddress.NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667529);
			SocketAddress.NativeMethodInfoPtr_GetIPAddress_Internal_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667530);
			SocketAddress.NativeMethodInfoPtr_GetIPEndPoint_Internal_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667531);
			SocketAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667532);
			SocketAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667533);
			SocketAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100667534);
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0008758C File Offset: 0x0008578C
		public unsafe AddressFamily Family
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 474676, RefRangeEnd = 474678, XrefRangeStart = 474676, XrefRangeEnd = 474676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr_get_Family_Public_get_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x000875C8 File Offset: 0x000857C8
		public unsafe int Size
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr_get_Size_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000839 RID: 2105
		public unsafe byte this[int offset]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 474678, RefRangeEnd = 474680, XrefRangeStart = 474678, XrefRangeEnd = 474678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00087650 File Offset: 0x00085850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474680, XrefRangeEnd = 474687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAddress(AddressFamily family, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x000876A8 File Offset: 0x000858A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474704, RefRangeEnd = 474705, XrefRangeStart = 474687, XrefRangeEnd = 474704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAddress(IPAddress ipAddress)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ipAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000876F4 File Offset: 0x000858F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474706, RefRangeEnd = 474707, XrefRangeStart = 474705, XrefRangeEnd = 474706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAddress(IPAddress ipaddress, int port)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ipaddress);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00087750 File Offset: 0x00085950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474712, RefRangeEnd = 474713, XrefRangeStart = 474707, XrefRangeEnd = 474712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress GetIPAddress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr_GetIPAddress_Internal_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00087790 File Offset: 0x00085990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474718, RefRangeEnd = 474719, XrefRangeStart = 474713, XrefRangeEnd = 474718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint GetIPEndPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr_GetIPEndPoint_Internal_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000877D0 File Offset: 0x000859D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474719, XrefRangeEnd = 474724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00087828 File Offset: 0x00085A28
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00087870 File Offset: 0x00085A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474724, XrefRangeEnd = 474756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0000BC42 File Offset: 0x00009E42
		public SocketAddress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x000878B4 File Offset: 0x00085AB4
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0000BC4B File Offset: 0x00009E4B
		public unsafe int m_Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_Size)) = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x000878DC File Offset: 0x00085ADC
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0000BC66 File Offset: 0x00009E66
		public unsafe Il2CppStructArray<byte> m_Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x0008790C File Offset: 0x00085B0C
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0000BC85 File Offset: 0x00009E85
		public unsafe bool m_changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_changed)) = value;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00087934 File Offset: 0x00085B34
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		public unsafe int m_hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_hash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_hash)) = value;
			}
		}

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeFieldInfoPtr_m_Size;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeFieldInfoPtr_m_changed;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeFieldInfoPtr_m_hash;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeMethodInfoPtr_get_Family_Public_get_AddressFamily_0;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Int32_0;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_Int32_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_Int32_0;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeMethodInfoPtr_GetIPAddress_Internal_IPAddress_0;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr_GetIPEndPoint_Internal_IPEndPoint_0;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
