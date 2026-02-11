using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x02000197 RID: 407
	[Serializable]
	public class IPEndPoint : EndPoint
	{
		// Token: 0x060018DB RID: 6363 RVA: 0x0007DF48 File Offset: 0x0007C148
		// Note: this type is marked as 'beforefieldinit'.
		static IPEndPoint()
		{
			Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPEndPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr);
			IPEndPoint.NativeFieldInfoPtr__address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "_address");
			IPEndPoint.NativeFieldInfoPtr__port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "_port");
			IPEndPoint.NativeFieldInfoPtr_Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "Any");
			IPEndPoint.NativeFieldInfoPtr_IPv6Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "IPv6Any");
			IPEndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100667221);
			IPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100667222);
			IPEndPoint.NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100667223);
			IPEndPoint.NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100667224);
			IPEndPoint.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100667225);
			IPEndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100667226);
			IPEndPoint.NativeMethodInfoPtr_Create_Public_Virtual_EndPoint_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100667227);
			IPEndPoint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100667228);
			IPEndPoint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100667229);
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x0007E07C File Offset: 0x0007C27C
		public unsafe override AddressFamily AddressFamily
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_get_AddressFamily_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0007E0C4 File Offset: 0x0007C2C4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 471547, RefRangeEnd = 471557, XrefRangeStart = 471533, XrefRangeEnd = 471547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint(IPAddress address, int port)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x0007E120 File Offset: 0x0007C320
		public unsafe IPAddress Address
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPEndPoint.NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x0007E160 File Offset: 0x0007C360
		public unsafe int Port
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPEndPoint.NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0007E19C File Offset: 0x0007C39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471557, XrefRangeEnd = 471564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0007E1E0 File Offset: 0x0007C3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471564, XrefRangeEnd = 471568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SocketAddress Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0007E22C File Offset: 0x0007C42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471568, XrefRangeEnd = 471606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EndPoint Create(SocketAddress socketAddress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socketAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_Create_Public_Virtual_EndPoint_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0007E288 File Offset: 0x0007C488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471606, XrefRangeEnd = 471609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0007E2E0 File Offset: 0x0007C4E0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0000A9D0 File Offset: 0x00008BD0
		public IPEndPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x0007E328 File Offset: 0x0007C528
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x0000A9D9 File Offset: 0x00008BD9
		public unsafe IPAddress _address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr__address);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr__address), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x0007E358 File Offset: 0x0007C558
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		public unsafe int _port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr__port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr__port)) = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x0007E380 File Offset: 0x0007C580
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x0000AA13 File Offset: 0x00008C13
		public unsafe static IPEndPoint Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPEndPoint.NativeFieldInfoPtr_Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPEndPoint.NativeFieldInfoPtr_Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x0007E3A8 File Offset: 0x0007C5A8
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x0000AA25 File Offset: 0x00008C25
		public unsafe static IPEndPoint IPv6Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPEndPoint.NativeFieldInfoPtr_IPv6Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPEndPoint.NativeFieldInfoPtr_IPv6Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeFieldInfoPtr__address;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeFieldInfoPtr__port;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeFieldInfoPtr_Any;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeFieldInfoPtr_IPv6Any;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_get_AddressFamily_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_SocketAddress_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_EndPoint_SocketAddress_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
