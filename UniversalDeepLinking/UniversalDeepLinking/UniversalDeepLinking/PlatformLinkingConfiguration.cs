using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ImaginationOverflow.UniversalDeepLinking
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	public class PlatformLinkingConfiguration : Object
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002F00 File Offset: 0x00001100
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformLinkingConfiguration()
		{
			Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking", "PlatformLinkingConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr);
			PlatformLinkingConfiguration.NativeFieldInfoPtr__domainProtocols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr, "_domainProtocols");
			PlatformLinkingConfiguration.NativeFieldInfoPtr__deepLinkingProtocols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr, "_deepLinkingProtocols");
			PlatformLinkingConfiguration.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr, "_initialized");
			PlatformLinkingConfiguration.NativeMethodInfoPtr_get_IsInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr, 100663332);
			PlatformLinkingConfiguration.NativeMethodInfoPtr_set_IsInitialized_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr, 100663333);
			PlatformLinkingConfiguration.NativeMethodInfoPtr_get_DeepLinkingProtocols_Public_get_List_1_LinkInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr, 100663334);
			PlatformLinkingConfiguration.NativeMethodInfoPtr_set_DeepLinkingProtocols_Public_set_Void_List_1_LinkInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr, 100663335);
			PlatformLinkingConfiguration.NativeMethodInfoPtr_get_DomainProtocols_Public_get_List_1_LinkInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr, 100663336);
			PlatformLinkingConfiguration.NativeMethodInfoPtr_set_DomainProtocols_Public_set_Void_List_1_LinkInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr, 100663337);
			PlatformLinkingConfiguration.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr, 100663338);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002FF8 File Offset: 0x000011F8
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003034 File Offset: 0x00001234
		public unsafe bool IsInitialized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformLinkingConfiguration.NativeMethodInfoPtr_get_IsInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformLinkingConfiguration.NativeMethodInfoPtr_set_IsInitialized_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003074 File Offset: 0x00001274
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000030B4 File Offset: 0x000012B4
		public unsafe List<LinkInformation> DeepLinkingProtocols
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformLinkingConfiguration.NativeMethodInfoPtr_get_DeepLinkingProtocols_Public_get_List_1_LinkInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformLinkingConfiguration.NativeMethodInfoPtr_set_DeepLinkingProtocols_Public_set_Void_List_1_LinkInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000030F8 File Offset: 0x000012F8
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00003138 File Offset: 0x00001338
		public unsafe List<LinkInformation> DomainProtocols
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformLinkingConfiguration.NativeMethodInfoPtr_get_DomainProtocols_Public_get_List_1_LinkInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformLinkingConfiguration.NativeMethodInfoPtr_set_DomainProtocols_Public_set_Void_List_1_LinkInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000317C File Offset: 0x0000137C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240466, RefRangeEnd = 1240469, XrefRangeStart = 1240453, XrefRangeEnd = 1240466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformLinkingConfiguration(bool init = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformLinkingConfiguration>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref init;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformLinkingConfiguration.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020F0 File Offset: 0x000002F0
		public PlatformLinkingConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000031C4 File Offset: 0x000013C4
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000020F9 File Offset: 0x000002F9
		public unsafe List<LinkInformation> _domainProtocols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformLinkingConfiguration.NativeFieldInfoPtr__domainProtocols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformLinkingConfiguration.NativeFieldInfoPtr__domainProtocols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000031F4 File Offset: 0x000013F4
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002118 File Offset: 0x00000318
		public unsafe List<LinkInformation> _deepLinkingProtocols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformLinkingConfiguration.NativeFieldInfoPtr__deepLinkingProtocols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LinkInformation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformLinkingConfiguration.NativeFieldInfoPtr__deepLinkingProtocols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003224 File Offset: 0x00001424
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002137 File Offset: 0x00000337
		public unsafe bool _initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformLinkingConfiguration.NativeFieldInfoPtr__initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformLinkingConfiguration.NativeFieldInfoPtr__initialized)) = value;
			}
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr__domainProtocols;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr__deepLinkingProtocols;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr__initialized;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInitialized_Public_get_Boolean_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_set_IsInitialized_Public_set_Void_Boolean_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_DeepLinkingProtocols_Public_get_List_1_LinkInformation_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_set_DeepLinkingProtocols_Public_set_Void_List_1_LinkInformation_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainProtocols_Public_get_List_1_LinkInformation_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_set_DomainProtocols_Public_set_Void_List_1_LinkInformation_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
