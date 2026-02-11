using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000221 RID: 545
	public sealed class Win32_FIXED_INFO_Marshal : ValueType
	{
		// Token: 0x06002490 RID: 9360 RVA: 0x000A8E54 File Offset: 0x000A7054
		// Note: this type is marked as 'beforefieldinit'.
		static Win32_FIXED_INFO_Marshal()
		{
			Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_FIXED_INFO_Marshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr);
			Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_HostName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "HostName");
			Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_DomainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "DomainName");
			Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_CurrentDnsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "CurrentDnsServer");
			Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_DnsServerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "DnsServerList");
			Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "NodeType");
			Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "ScopeId");
			Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_EnableRouting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "EnableRouting");
			Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_EnableProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "EnableProxy");
			Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_EnableDns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "EnableDns");
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0000FD84 File Offset: 0x0000DF84
		public Win32_FIXED_INFO_Marshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x0000FD8D File Offset: 0x0000DF8D
		public Win32_FIXED_INFO_Marshal()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr))
		{
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x000A8F38 File Offset: 0x000A7138
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x0000FD9F File Offset: 0x0000DF9F
		public unsafe Win32_FIXED_INFO_Marshal._HostName_e__FixedBuffer HostName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_HostName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_HostName)) = value;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x000A8F60 File Offset: 0x000A7160
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0000FDBA File Offset: 0x0000DFBA
		public unsafe Win32_FIXED_INFO_Marshal._DomainName_e__FixedBuffer DomainName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_DomainName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_DomainName)) = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x000A8F88 File Offset: 0x000A7188
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0000FDD5 File Offset: 0x0000DFD5
		public unsafe IntPtr CurrentDnsServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_CurrentDnsServer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_CurrentDnsServer)) = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x000A8FB0 File Offset: 0x000A71B0
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0000FDF0 File Offset: 0x0000DFF0
		public Win32_IP_ADDR_STRING DnsServerList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_DnsServerList);
				return new Win32_IP_ADDR_STRING(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_DnsServerList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x000A8FE0 File Offset: 0x000A71E0
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x0000FE1E File Offset: 0x0000E01E
		public unsafe NetBiosNodeType NodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_NodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_NodeType)) = value;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x000A9008 File Offset: 0x000A7208
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x0000FE39 File Offset: 0x0000E039
		public unsafe Win32_FIXED_INFO_Marshal._ScopeId_e__FixedBuffer ScopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_ScopeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_ScopeId)) = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x000A9030 File Offset: 0x000A7230
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x0000FE54 File Offset: 0x0000E054
		public unsafe uint EnableRouting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_EnableRouting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_EnableRouting)) = value;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x000A9058 File Offset: 0x000A7258
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x0000FE6F File Offset: 0x0000E06F
		public unsafe uint EnableProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_EnableProxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_EnableProxy)) = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000A9080 File Offset: 0x000A7280
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x0000FE8A File Offset: 0x0000E08A
		public unsafe uint EnableDns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_EnableDns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO_Marshal.NativeFieldInfoPtr_EnableDns)) = value;
			}
		}

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeFieldInfoPtr_HostName;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeFieldInfoPtr_DomainName;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeFieldInfoPtr_CurrentDnsServer;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeFieldInfoPtr_DnsServerList;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeFieldInfoPtr_NodeType;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeFieldInfoPtr_ScopeId;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeFieldInfoPtr_EnableRouting;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeFieldInfoPtr_EnableProxy;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeFieldInfoPtr_EnableDns;

		// Token: 0x02000367 RID: 871
		[ObfuscatedName("System.Net.NetworkInformation.Win32_FIXED_INFO_Marshal+<HostName>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _HostName_e__FixedBuffer
		{
			// Token: 0x0600327E RID: 12926 RVA: 0x00017E68 File Offset: 0x00016068
			// Note: this type is marked as 'beforefieldinit'.
			static _HostName_e__FixedBuffer()
			{
				Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._HostName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "<HostName>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._HostName_e__FixedBuffer>.NativeClassPtr);
				Win32_FIXED_INFO_Marshal._HostName_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._HostName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x0600327F RID: 12927 RVA: 0x00017E9C File Offset: 0x0001609C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._HostName_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x040026C4 RID: 9924
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x040026C5 RID: 9925
			[FieldOffset(0)]
			public byte FixedElementField;
		}

		// Token: 0x02000368 RID: 872
		[ObfuscatedName("System.Net.NetworkInformation.Win32_FIXED_INFO_Marshal+<DomainName>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _DomainName_e__FixedBuffer
		{
			// Token: 0x06003280 RID: 12928 RVA: 0x00017EAE File Offset: 0x000160AE
			// Note: this type is marked as 'beforefieldinit'.
			static _DomainName_e__FixedBuffer()
			{
				Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._DomainName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "<DomainName>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._DomainName_e__FixedBuffer>.NativeClassPtr);
				Win32_FIXED_INFO_Marshal._DomainName_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._DomainName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003281 RID: 12929 RVA: 0x00017EE2 File Offset: 0x000160E2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._DomainName_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x040026C6 RID: 9926
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x040026C7 RID: 9927
			[FieldOffset(0)]
			public byte FixedElementField;
		}

		// Token: 0x02000369 RID: 873
		[ObfuscatedName("System.Net.NetworkInformation.Win32_FIXED_INFO_Marshal+<ScopeId>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _ScopeId_e__FixedBuffer
		{
			// Token: 0x06003282 RID: 12930 RVA: 0x00017EF4 File Offset: 0x000160F4
			// Note: this type is marked as 'beforefieldinit'.
			static _ScopeId_e__FixedBuffer()
			{
				Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._ScopeId_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal>.NativeClassPtr, "<ScopeId>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._ScopeId_e__FixedBuffer>.NativeClassPtr);
				Win32_FIXED_INFO_Marshal._ScopeId_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._ScopeId_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003283 RID: 12931 RVA: 0x00017F28 File Offset: 0x00016128
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_FIXED_INFO_Marshal._ScopeId_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x040026C8 RID: 9928
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x040026C9 RID: 9929
			[FieldOffset(0)]
			public byte FixedElementField;
		}
	}
}
