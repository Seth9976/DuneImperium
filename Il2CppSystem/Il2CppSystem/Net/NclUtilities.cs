using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001B6 RID: 438
	public static class NclUtilities : Object
	{
		// Token: 0x06001B03 RID: 6915 RVA: 0x00085FF0 File Offset: 0x000841F0
		// Note: this type is marked as 'beforefieldinit'.
		static NclUtilities()
		{
			Il2CppClassPointerStore<NclUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NclUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr);
			NclUtilities.NativeFieldInfoPtr__LocalAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalAddresses");
			NclUtilities.NativeFieldInfoPtr__LocalAddressesLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalAddressesLock");
			NclUtilities.NativeFieldInfoPtr__LocalDomainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalDomainName");
			NclUtilities.NativeMethodInfoPtr_IsFatal_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100667485);
			NclUtilities.NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100667486);
			NclUtilities.NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100667487);
			NclUtilities.NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100667488);
			NclUtilities.NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100667489);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x000860C0 File Offset: 0x000842C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474440, RefRangeEnd = 474442, XrefRangeStart = 474437, XrefRangeEnd = 474440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFatal(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_IsFatal_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00086104 File Offset: 0x00084304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474442, XrefRangeEnd = 474445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAddressLocal(IPAddress ipAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ipAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00086148 File Offset: 0x00084348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474445, XrefRangeEnd = 474447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetLocalHost()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0008617C File Offset: 0x0008437C
		public unsafe static Il2CppReferenceArray<IPAddress> LocalAddresses
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 474512, RefRangeEnd = 474513, XrefRangeStart = 474447, XrefRangeEnd = 474512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x000861B0 File Offset: 0x000843B0
		public unsafe static Object LocalAddressesLock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474513, XrefRangeEnd = 474522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		public NclUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x000861E4 File Offset: 0x000843E4
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x0000B9AD File Offset: 0x00009BAD
		public unsafe static Il2CppReferenceArray<IPAddress> _LocalAddresses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NclUtilities.NativeFieldInfoPtr__LocalAddresses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NclUtilities.NativeFieldInfoPtr__LocalAddresses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0008620C File Offset: 0x0008440C
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x0000B9BF File Offset: 0x00009BBF
		public unsafe static Object _LocalAddressesLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NclUtilities.NativeFieldInfoPtr__LocalAddressesLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NclUtilities.NativeFieldInfoPtr__LocalAddressesLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x00086234 File Offset: 0x00084434
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0000B9D1 File Offset: 0x00009BD1
		public unsafe static string _LocalDomainName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NclUtilities.NativeFieldInfoPtr__LocalDomainName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NclUtilities.NativeFieldInfoPtr__LocalDomainName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeFieldInfoPtr__LocalAddresses;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeFieldInfoPtr__LocalAddressesLock;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeFieldInfoPtr__LocalDomainName;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr_IsFatal_Internal_Static_Boolean_Exception_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0;
	}
}
