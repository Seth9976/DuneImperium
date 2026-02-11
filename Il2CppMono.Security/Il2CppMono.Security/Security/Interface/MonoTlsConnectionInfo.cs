using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000026 RID: 38
	public class MonoTlsConnectionInfo : Object
	{
		// Token: 0x0600022A RID: 554 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsConnectionInfo()
		{
			Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoTlsConnectionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr);
			MonoTlsConnectionInfo.NativeFieldInfoPtr__CipherSuiteCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, "<CipherSuiteCode>k__BackingField");
			MonoTlsConnectionInfo.NativeFieldInfoPtr__ProtocolVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, "<ProtocolVersion>k__BackingField");
			MonoTlsConnectionInfo.NativeFieldInfoPtr__PeerDomainName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, "<PeerDomainName>k__BackingField");
			MonoTlsConnectionInfo.NativeMethodInfoPtr_get_CipherSuiteCode_Public_get_CipherSuiteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663623);
			MonoTlsConnectionInfo.NativeMethodInfoPtr_set_CipherSuiteCode_Public_set_Void_CipherSuiteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663624);
			MonoTlsConnectionInfo.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_TlsProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663625);
			MonoTlsConnectionInfo.NativeMethodInfoPtr_set_ProtocolVersion_Public_set_Void_TlsProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663626);
			MonoTlsConnectionInfo.NativeMethodInfoPtr_set_PeerDomainName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663627);
			MonoTlsConnectionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663628);
			MonoTlsConnectionInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr, 100663629);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0000C71C File Offset: 0x0000A91C
		public unsafe CipherSuiteCode CipherSuiteCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr_get_CipherSuiteCode_Public_get_CipherSuiteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr_set_CipherSuiteCode_Public_set_Void_CipherSuiteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000C75C File Offset: 0x0000A95C
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0000C798 File Offset: 0x0000A998
		public unsafe TlsProtocols ProtocolVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_TlsProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr_set_ProtocolVersion_Public_set_Void_TlsProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
		public unsafe string PeerDomainName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr_set_PeerDomainName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000C81C File Offset: 0x0000AA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149364, XrefRangeEnd = 1149373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsConnectionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000C860 File Offset: 0x0000AA60
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsConnectionInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsConnectionInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsConnectionInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002EC7 File Offset: 0x000010C7
		public MonoTlsConnectionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000C89C File Offset: 0x0000AA9C
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002ED0 File Offset: 0x000010D0
		public unsafe CipherSuiteCode _CipherSuiteCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__CipherSuiteCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__CipherSuiteCode_k__BackingField)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000C8C4 File Offset: 0x0000AAC4
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002EEB File Offset: 0x000010EB
		public unsafe TlsProtocols _ProtocolVersion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__ProtocolVersion_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__ProtocolVersion_k__BackingField)) = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000C8EC File Offset: 0x0000AAEC
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002F06 File Offset: 0x00001106
		public unsafe string _PeerDomainName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__PeerDomainName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsConnectionInfo.NativeFieldInfoPtr__PeerDomainName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr__CipherSuiteCode_k__BackingField;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr__ProtocolVersion_k__BackingField;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr__PeerDomainName_k__BackingField;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_get_CipherSuiteCode_Public_get_CipherSuiteCode_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_set_CipherSuiteCode_Public_set_Void_CipherSuiteCode_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolVersion_Public_get_TlsProtocols_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_set_ProtocolVersion_Public_set_Void_TlsProtocols_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_set_PeerDomainName_Public_set_Void_String_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
