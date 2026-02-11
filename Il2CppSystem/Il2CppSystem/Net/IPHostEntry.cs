using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001B3 RID: 435
	public class IPHostEntry : Object
	{
		// Token: 0x06001AED RID: 6893 RVA: 0x00085C30 File Offset: 0x00083E30
		// Note: this type is marked as 'beforefieldinit'.
		static IPHostEntry()
		{
			Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPHostEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr);
			IPHostEntry.NativeFieldInfoPtr_hostName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "hostName");
			IPHostEntry.NativeFieldInfoPtr_aliases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "aliases");
			IPHostEntry.NativeFieldInfoPtr_addressList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "addressList");
			IPHostEntry.NativeFieldInfoPtr_isTrustedHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "isTrustedHost");
			IPHostEntry.NativeMethodInfoPtr_get_HostName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100667477);
			IPHostEntry.NativeMethodInfoPtr_set_HostName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100667478);
			IPHostEntry.NativeMethodInfoPtr_set_Aliases_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100667479);
			IPHostEntry.NativeMethodInfoPtr_get_AddressList_Public_get_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100667480);
			IPHostEntry.NativeMethodInfoPtr_set_AddressList_Public_set_Void_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100667481);
			IPHostEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100667482);
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x00085D28 File Offset: 0x00083F28
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x00085D60 File Offset: 0x00083F60
		public unsafe string HostName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_get_HostName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_set_HostName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700080E RID: 2062
		// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x00085DA4 File Offset: 0x00083FA4
		public unsafe Il2CppStringArray Aliases
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_set_Aliases_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x00085DE8 File Offset: 0x00083FE8
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x00085E28 File Offset: 0x00084028
		public unsafe Il2CppReferenceArray<IPAddress> AddressList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_get_AddressList_Public_get_Il2CppReferenceArray_1_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_set_AddressList_Public_set_Void_Il2CppReferenceArray_1_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00085E6C File Offset: 0x0008406C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474416, RefRangeEnd = 474418, XrefRangeStart = 474415, XrefRangeEnd = 474416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPHostEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0000B8A9 File Offset: 0x00009AA9
		public IPHostEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00085EA8 File Offset: 0x000840A8
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0000B8B2 File Offset: 0x00009AB2
		public unsafe string hostName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_hostName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_hostName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x00085ED0 File Offset: 0x000840D0
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x0000B8D1 File Offset: 0x00009AD1
		public unsafe Il2CppStringArray aliases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_aliases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_aliases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x00085F00 File Offset: 0x00084100
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x0000B8F0 File Offset: 0x00009AF0
		public unsafe Il2CppReferenceArray<IPAddress> addressList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_addressList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_addressList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x00085F30 File Offset: 0x00084130
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x0000B90F File Offset: 0x00009B0F
		public unsafe bool isTrustedHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_isTrustedHost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_isTrustedHost)) = value;
			}
		}

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeFieldInfoPtr_hostName;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeFieldInfoPtr_aliases;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeFieldInfoPtr_addressList;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeFieldInfoPtr_isTrustedHost;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_get_HostName_Public_get_String_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_set_HostName_Public_set_Void_String_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_set_Aliases_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressList_Public_get_Il2CppReferenceArray_1_IPAddress_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_set_AddressList_Public_set_Void_Il2CppReferenceArray_1_IPAddress_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
