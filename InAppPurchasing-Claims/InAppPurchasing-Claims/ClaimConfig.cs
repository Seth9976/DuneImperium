using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace iap.claims
{
	// Token: 0x02000004 RID: 4
	public sealed class ClaimConfig : Object
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002E60 File Offset: 0x00001060
		// Note: this type is marked as 'beforefieldinit'.
		static ClaimConfig()
		{
			Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Claims.dll", "iap.claims", "ClaimConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr);
			ClaimConfig.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, "Client");
			ClaimConfig.NativeFieldInfoPtr_AuthTokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, "AuthTokenType");
			ClaimConfig.NativeFieldInfoPtr_AuthToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, "AuthToken");
			ClaimConfig.NativeFieldInfoPtr_CommerceURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, "CommerceURL");
			ClaimConfig.NativeFieldInfoPtr_OnClaimSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, "OnClaimSuccess");
			ClaimConfig.NativeFieldInfoPtr_OnClaimFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, "OnClaimFailure");
			ClaimConfig.NativeFieldInfoPtr__AppId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, "<AppId>k__BackingField");
			ClaimConfig.NativeFieldInfoPtr__SessionTicket_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, "<SessionTicket>k__BackingField");
			ClaimConfig.NativeMethodInfoPtr_get_AppId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, 100663309);
			ClaimConfig.NativeMethodInfoPtr_get_SessionTicket_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, 100663310);
			ClaimConfig.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr, 100663311);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002F6C File Offset: 0x0000116C
		public unsafe string AppId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimConfig.NativeMethodInfoPtr_get_AppId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002FA4 File Offset: 0x000011A4
		public unsafe string SessionTicket
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimConfig.NativeMethodInfoPtr_get_SessionTicket_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002FDC File Offset: 0x000011DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1267861, RefRangeEnd = 1267862, XrefRangeStart = 1267856, XrefRangeEnd = 1267861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimConfig([Optional] Il2CppStringArray ids)
		{
			if (ids == null)
			{
				ids = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimConfig>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimConfig.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020A0 File Offset: 0x000002A0
		public ClaimConfig(params string[] ids)
			: this(new Il2CppStringArray(ids))
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020AE File Offset: 0x000002AE
		public ClaimConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00003034 File Offset: 0x00001234
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020B7 File Offset: 0x000002B7
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000305C File Offset: 0x0000125C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000020D6 File Offset: 0x000002D6
		public unsafe string AuthTokenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_AuthTokenType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_AuthTokenType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00003084 File Offset: 0x00001284
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020F5 File Offset: 0x000002F5
		public unsafe string AuthToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_AuthToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_AuthToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000030AC File Offset: 0x000012AC
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002114 File Offset: 0x00000314
		public unsafe string CommerceURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_CommerceURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_CommerceURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000030D4 File Offset: 0x000012D4
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002133 File Offset: 0x00000333
		public unsafe Action<ClaimResponse> OnClaimSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_OnClaimSuccess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClaimResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_OnClaimSuccess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003104 File Offset: 0x00001304
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe Action<string> OnClaimFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_OnClaimFailure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr_OnClaimFailure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003134 File Offset: 0x00001334
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002171 File Offset: 0x00000371
		public unsafe string _AppId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr__AppId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr__AppId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000315C File Offset: 0x0000135C
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002190 File Offset: 0x00000390
		public unsafe string _SessionTicket_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr__SessionTicket_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimConfig.NativeFieldInfoPtr__SessionTicket_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_AuthTokenType;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_AuthToken;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_CommerceURL;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_OnClaimSuccess;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_OnClaimFailure;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr__AppId_k__BackingField;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr__SessionTicket_k__BackingField;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_AppId_Public_get_String_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_SessionTicket_Public_get_String_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;
	}
}
