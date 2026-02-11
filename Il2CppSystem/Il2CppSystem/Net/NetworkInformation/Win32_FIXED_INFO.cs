using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000220 RID: 544
	public sealed class Win32_FIXED_INFO : ValueType
	{
		// Token: 0x0600247B RID: 9339 RVA: 0x000A8C00 File Offset: 0x000A6E00
		// Note: this type is marked as 'beforefieldinit'.
		static Win32_FIXED_INFO()
		{
			Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_FIXED_INFO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr);
			Win32_FIXED_INFO.NativeFieldInfoPtr_HostName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "HostName");
			Win32_FIXED_INFO.NativeFieldInfoPtr_DomainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "DomainName");
			Win32_FIXED_INFO.NativeFieldInfoPtr_CurrentDnsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "CurrentDnsServer");
			Win32_FIXED_INFO.NativeFieldInfoPtr_DnsServerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "DnsServerList");
			Win32_FIXED_INFO.NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "NodeType");
			Win32_FIXED_INFO.NativeFieldInfoPtr_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "ScopeId");
			Win32_FIXED_INFO.NativeFieldInfoPtr_EnableRouting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableRouting");
			Win32_FIXED_INFO.NativeFieldInfoPtr_EnableProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableProxy");
			Win32_FIXED_INFO.NativeFieldInfoPtr_EnableDns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableDns");
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x0000FC57 File Offset: 0x0000DE57
		public Win32_FIXED_INFO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0000FC60 File Offset: 0x0000DE60
		public Win32_FIXED_INFO()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr))
		{
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x000A8CE4 File Offset: 0x000A6EE4
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x0000FC72 File Offset: 0x0000DE72
		public unsafe string HostName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_HostName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_HostName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x000A8D0C File Offset: 0x000A6F0C
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x0000FC91 File Offset: 0x0000DE91
		public unsafe string DomainName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DomainName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DomainName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x000A8D34 File Offset: 0x000A6F34
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x0000FCB0 File Offset: 0x0000DEB0
		public unsafe IntPtr CurrentDnsServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_CurrentDnsServer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_CurrentDnsServer)) = value;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x000A8D5C File Offset: 0x000A6F5C
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x0000FCCB File Offset: 0x0000DECB
		public Win32_IP_ADDR_STRING DnsServerList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DnsServerList);
				return new Win32_IP_ADDR_STRING(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DnsServerList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x000A8D8C File Offset: 0x000A6F8C
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x0000FCF9 File Offset: 0x0000DEF9
		public unsafe NetBiosNodeType NodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_NodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_NodeType)) = value;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x000A8DB4 File Offset: 0x000A6FB4
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x0000FD14 File Offset: 0x0000DF14
		public unsafe string ScopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_ScopeId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_ScopeId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x000A8DDC File Offset: 0x000A6FDC
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x0000FD33 File Offset: 0x0000DF33
		public unsafe uint EnableRouting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableRouting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableRouting)) = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x000A8E04 File Offset: 0x000A7004
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x0000FD4E File Offset: 0x0000DF4E
		public unsafe uint EnableProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableProxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableProxy)) = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x000A8E2C File Offset: 0x000A702C
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x0000FD69 File Offset: 0x0000DF69
		public unsafe uint EnableDns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableDns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableDns)) = value;
			}
		}

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeFieldInfoPtr_HostName;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeFieldInfoPtr_DomainName;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeFieldInfoPtr_CurrentDnsServer;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeFieldInfoPtr_DnsServerList;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeFieldInfoPtr_NodeType;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeFieldInfoPtr_ScopeId;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeFieldInfoPtr_EnableRouting;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeFieldInfoPtr_EnableProxy;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeFieldInfoPtr_EnableDns;
	}
}
