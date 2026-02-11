using System;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace iap.claims
{
	// Token: 0x0200000D RID: 13
	public class SubmitClaimCommand : Command
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00004140 File Offset: 0x00002340
		// Note: this type is marked as 'beforefieldinit'.
		static SubmitClaimCommand()
		{
			Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Claims.dll", "iap.claims", "SubmitClaimCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr);
			SubmitClaimCommand.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "client");
			SubmitClaimCommand.NativeFieldInfoPtr_authTokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "authTokenType");
			SubmitClaimCommand.NativeFieldInfoPtr_authToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "authToken");
			SubmitClaimCommand.NativeFieldInfoPtr_commerceURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "commerceURL");
			SubmitClaimCommand.NativeFieldInfoPtr_onClaimSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "onClaimSuccess");
			SubmitClaimCommand.NativeFieldInfoPtr_onClaimFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "onClaimFailure");
			SubmitClaimCommand.NativeFieldInfoPtr_appId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "appId");
			SubmitClaimCommand.NativeFieldInfoPtr_sessionTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "sessionTicket");
			SubmitClaimCommand.NativeFieldInfoPtr_receipt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "receipt");
			SubmitClaimCommand.NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "productId");
			SubmitClaimCommand.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "token");
			SubmitClaimCommand.NativeFieldInfoPtr_GooglePlayMediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "GooglePlayMediaType");
			SubmitClaimCommand.NativeFieldInfoPtr_AppStoreMediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "AppStoreMediaType");
			SubmitClaimCommand.NativeFieldInfoPtr_SteamMicroTxnMediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "SteamMicroTxnMediaType");
			SubmitClaimCommand.NativeFieldInfoPtr_SteamDLCMediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "SteamDLCMediaType");
			SubmitClaimCommand.NativeFieldInfoPtr_NintendoSwitchStoreMediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "NintendoSwitchStoreMediaType");
			SubmitClaimCommand.NativeFieldInfoPtr_XBoxStoreMediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "XBoxStoreMediaType");
			SubmitClaimCommand.NativeMethodInfoPtr__ctor_Public_Void_ClaimConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, 100663366);
			SubmitClaimCommand.NativeMethodInfoPtr__ctor_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, 100663367);
			SubmitClaimCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, 100663368);
			SubmitClaimCommand.NativeMethodInfoPtr_addHeader_Private_Void_byref_Dictionary_2_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, 100663369);
			SubmitClaimCommand.NativeMethodInfoPtr_getBodyData_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, 100663370);
			SubmitClaimCommand.NativeMethodInfoPtr_getMediaType_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, 100663371);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000433C File Offset: 0x0000253C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1268216, RefRangeEnd = 1268219, XrefRangeStart = 1268206, XrefRangeEnd = 1268216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubmitClaimCommand(ClaimConfig claimConfig)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claimConfig);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand.NativeMethodInfoPtr__ctor_Public_Void_ClaimConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004388 File Offset: 0x00002588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268219, XrefRangeEnd = 1268222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubmitClaimCommand(string appId, string sessionTicket)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(appId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sessionTicket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand.NativeMethodInfoPtr__ctor_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000043E8 File Offset: 0x000025E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268222, XrefRangeEnd = 1268227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubmitClaimCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004434 File Offset: 0x00002634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268227, XrefRangeEnd = 1268231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addHeader(ref Dictionary<string, string> headers, string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand.NativeMethodInfoPtr_addHeader_Private_Void_byref_Dictionary_2_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			headers = ((intPtr4 == 0) ? null : new Dictionary<string, string>(intPtr4));
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000044B0 File Offset: 0x000026B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268231, XrefRangeEnd = 1268253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> getBodyData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand.NativeMethodInfoPtr_getBodyData_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000044F0 File Offset: 0x000026F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268253, XrefRangeEnd = 1268255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getMediaType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand.NativeMethodInfoPtr_getMediaType_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000024A5 File Offset: 0x000006A5
		public SubmitClaimCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000451C File Offset: 0x0000271C
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000024AE File Offset: 0x000006AE
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004544 File Offset: 0x00002744
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000024CD File Offset: 0x000006CD
		public unsafe string authTokenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_authTokenType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_authTokenType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000456C File Offset: 0x0000276C
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000024EC File Offset: 0x000006EC
		public unsafe string authToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_authToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_authToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00004594 File Offset: 0x00002794
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000250B File Offset: 0x0000070B
		public unsafe string commerceURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_commerceURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_commerceURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000045BC File Offset: 0x000027BC
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000252A File Offset: 0x0000072A
		public unsafe Action<ClaimResponse> onClaimSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_onClaimSuccess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClaimResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_onClaimSuccess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000045EC File Offset: 0x000027EC
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002549 File Offset: 0x00000749
		public unsafe Action<string> onClaimFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_onClaimFailure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_onClaimFailure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000461C File Offset: 0x0000281C
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002568 File Offset: 0x00000768
		public unsafe string appId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_appId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_appId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004644 File Offset: 0x00002844
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002587 File Offset: 0x00000787
		public unsafe string sessionTicket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_sessionTicket);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_sessionTicket), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000466C File Offset: 0x0000286C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000025A6 File Offset: 0x000007A6
		public unsafe string receipt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_receipt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_receipt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004694 File Offset: 0x00002894
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000025C5 File Offset: 0x000007C5
		public unsafe string productId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_productId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_productId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000046BC File Offset: 0x000028BC
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000025E4 File Offset: 0x000007E4
		public unsafe string token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_token);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.NativeFieldInfoPtr_token), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000046E4 File Offset: 0x000028E4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002603 File Offset: 0x00000803
		public unsafe static string GooglePlayMediaType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubmitClaimCommand.NativeFieldInfoPtr_GooglePlayMediaType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitClaimCommand.NativeFieldInfoPtr_GooglePlayMediaType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00004704 File Offset: 0x00002904
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002615 File Offset: 0x00000815
		public unsafe static string AppStoreMediaType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubmitClaimCommand.NativeFieldInfoPtr_AppStoreMediaType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitClaimCommand.NativeFieldInfoPtr_AppStoreMediaType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00004724 File Offset: 0x00002924
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002627 File Offset: 0x00000827
		public unsafe static string SteamMicroTxnMediaType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubmitClaimCommand.NativeFieldInfoPtr_SteamMicroTxnMediaType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitClaimCommand.NativeFieldInfoPtr_SteamMicroTxnMediaType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00004744 File Offset: 0x00002944
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002639 File Offset: 0x00000839
		public unsafe static string SteamDLCMediaType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubmitClaimCommand.NativeFieldInfoPtr_SteamDLCMediaType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitClaimCommand.NativeFieldInfoPtr_SteamDLCMediaType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004764 File Offset: 0x00002964
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000264B File Offset: 0x0000084B
		public unsafe static string NintendoSwitchStoreMediaType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubmitClaimCommand.NativeFieldInfoPtr_NintendoSwitchStoreMediaType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitClaimCommand.NativeFieldInfoPtr_NintendoSwitchStoreMediaType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004784 File Offset: 0x00002984
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000265D File Offset: 0x0000085D
		public unsafe static string XBoxStoreMediaType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubmitClaimCommand.NativeFieldInfoPtr_XBoxStoreMediaType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitClaimCommand.NativeFieldInfoPtr_XBoxStoreMediaType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_authTokenType;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_authToken;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_commerceURL;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_onClaimSuccess;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_onClaimFailure;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_appId;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_sessionTicket;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_receipt;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_productId;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_token;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_GooglePlayMediaType;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_AppStoreMediaType;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_SteamMicroTxnMediaType;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_SteamDLCMediaType;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_NintendoSwitchStoreMediaType;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_XBoxStoreMediaType;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClaimConfig_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_addHeader_Private_Void_byref_Dictionary_2_String_String_String_String_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_getBodyData_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_getMediaType_Private_Static_String_0;

		// Token: 0x02000018 RID: 24
		[Serializable]
		public class ClaimRequestBody : Object
		{
			// Token: 0x06000124 RID: 292 RVA: 0x00005DF0 File Offset: 0x00003FF0
			// Note: this type is marked as 'beforefieldinit'.
			static ClaimRequestBody()
			{
				Il2CppClassPointerStore<SubmitClaimCommand.ClaimRequestBody>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "ClaimRequestBody");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitClaimCommand.ClaimRequestBody>.NativeClassPtr);
				SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_AppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand.ClaimRequestBody>.NativeClassPtr, "AppId");
				SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_SessionTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand.ClaimRequestBody>.NativeClassPtr, "SessionTicket");
				SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_Receipt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand.ClaimRequestBody>.NativeClassPtr, "Receipt");
				SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand.ClaimRequestBody>.NativeClassPtr, "ProductId");
				SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand.ClaimRequestBody>.NativeClassPtr, "Token");
				SubmitClaimCommand.ClaimRequestBody.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand.ClaimRequestBody>.NativeClassPtr, 100663372);
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00005E94 File Offset: 0x00004094
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClaimRequestBody()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmitClaimCommand.ClaimRequestBody>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand.ClaimRequestBody.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00002AA7 File Offset: 0x00000CA7
			public ClaimRequestBody(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000127 RID: 295 RVA: 0x00005ED0 File Offset: 0x000040D0
			// (set) Token: 0x06000128 RID: 296 RVA: 0x00002AB0 File Offset: 0x00000CB0
			public unsafe string AppId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_AppId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_AppId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000129 RID: 297 RVA: 0x00005EF8 File Offset: 0x000040F8
			// (set) Token: 0x0600012A RID: 298 RVA: 0x00002ACF File Offset: 0x00000CCF
			public unsafe string SessionTicket
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_SessionTicket);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_SessionTicket), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x0600012B RID: 299 RVA: 0x00005F20 File Offset: 0x00004120
			// (set) Token: 0x0600012C RID: 300 RVA: 0x00002AEE File Offset: 0x00000CEE
			public unsafe string Receipt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_Receipt);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_Receipt), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x0600012D RID: 301 RVA: 0x00005F48 File Offset: 0x00004148
			// (set) Token: 0x0600012E RID: 302 RVA: 0x00002B0D File Offset: 0x00000D0D
			public unsafe string ProductId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_ProductId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_ProductId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x0600012F RID: 303 RVA: 0x00005F70 File Offset: 0x00004170
			// (set) Token: 0x06000130 RID: 304 RVA: 0x00002B2C File Offset: 0x00000D2C
			public unsafe string Token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_Token);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand.ClaimRequestBody.NativeFieldInfoPtr_Token), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040000A1 RID: 161
			private static readonly IntPtr NativeFieldInfoPtr_AppId;

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeFieldInfoPtr_SessionTicket;

			// Token: 0x040000A3 RID: 163
			private static readonly IntPtr NativeFieldInfoPtr_Receipt;

			// Token: 0x040000A4 RID: 164
			private static readonly IntPtr NativeFieldInfoPtr_ProductId;

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeFieldInfoPtr_Token;

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000019 RID: 25
		[ObfuscatedName("iap.claims.SubmitClaimCommand+<execute>d__20")]
		public sealed class _execute_d__20 : Object
		{
			// Token: 0x06000131 RID: 305 RVA: 0x00005F98 File Offset: 0x00004198
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__20()
			{
				Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubmitClaimCommand>.NativeClassPtr, "<execute>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr);
				SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr, "<>1__state");
				SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr, "<>2__current");
				SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr, "<>4__this");
				SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr__webRequest_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr, "<webRequest>5__2");
				SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr, 100663373);
				SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr, 100663374);
				SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr, 100663375);
				SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr, 100663376);
				SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr, 100663377);
				SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr, 100663378);
			}

			// Token: 0x06000132 RID: 306 RVA: 0x0000608C File Offset: 0x0000428C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmitClaimCommand._execute_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000133 RID: 307 RVA: 0x000060D4 File Offset: 0x000042D4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00006108 File Offset: 0x00004308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268110, XrefRangeEnd = 1268201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x06000135 RID: 309 RVA: 0x00006144 File Offset: 0x00004344
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000136 RID: 310 RVA: 0x00006184 File Offset: 0x00004384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268201, XrefRangeEnd = 1268206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x06000137 RID: 311 RVA: 0x000061B8 File Offset: 0x000043B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitClaimCommand._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000138 RID: 312 RVA: 0x00002B4B File Offset: 0x00000D4B
			public _execute_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000139 RID: 313 RVA: 0x000061F8 File Offset: 0x000043F8
			// (set) Token: 0x0600013A RID: 314 RVA: 0x00002B54 File Offset: 0x00000D54
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600013B RID: 315 RVA: 0x00006220 File Offset: 0x00004420
			// (set) Token: 0x0600013C RID: 316 RVA: 0x00002B6F File Offset: 0x00000D6F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600013D RID: 317 RVA: 0x00006250 File Offset: 0x00004450
			// (set) Token: 0x0600013E RID: 318 RVA: 0x00002B8E File Offset: 0x00000D8E
			public unsafe SubmitClaimCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmitClaimCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x0600013F RID: 319 RVA: 0x00006280 File Offset: 0x00004480
			// (set) Token: 0x06000140 RID: 320 RVA: 0x00002BAD File Offset: 0x00000DAD
			public unsafe DwdWebRequestCommand _webRequest_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr__webRequest_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitClaimCommand._execute_d__20.NativeFieldInfoPtr__webRequest_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000A7 RID: 167
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000A9 RID: 169
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeFieldInfoPtr__webRequest_5__2;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000AC RID: 172
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000AD RID: 173
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000AE RID: 174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000AF RID: 175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000B0 RID: 176
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
