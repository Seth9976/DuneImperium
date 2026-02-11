using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace iap.claims
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class ClaimResponse : Object
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003184 File Offset: 0x00001384
		// Note: this type is marked as 'beforefieldinit'.
		static ClaimResponse()
		{
			Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Claims.dll", "iap.claims", "ClaimResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr);
			ClaimResponse.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, "<Id>k__BackingField");
			ClaimResponse.NativeFieldInfoPtr_ArchetypeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, "ArchetypeIDs");
			ClaimResponse.NativeFieldInfoPtr_TransactionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, "TransactionID");
			ClaimResponse.NativeFieldInfoPtr__Url_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, "<Url>k__BackingField");
			ClaimResponse.NativeFieldInfoPtr__Created_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, "<Created>k__BackingField");
			ClaimResponse.NativeFieldInfoPtr__Updated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, "<Updated>k__BackingField");
			ClaimResponse.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, "status");
			ClaimResponse.NativeFieldInfoPtr_FulfilledId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, "FulfilledId");
			ClaimResponse.NativeFieldInfoPtr_DeniedId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, "DeniedId");
			ClaimResponse.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663312);
			ClaimResponse.NativeMethodInfoPtr_get_Url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663313);
			ClaimResponse.NativeMethodInfoPtr_get_Created_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663314);
			ClaimResponse.NativeMethodInfoPtr_get_Updated_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663315);
			ClaimResponse.NativeMethodInfoPtr_get_StatusId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663316);
			ClaimResponse.NativeMethodInfoPtr_get_StatusName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663317);
			ClaimResponse.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Status_List_1_ArchetypeID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663318);
			ClaimResponse.NativeMethodInfoPtr_IsFulfilled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663319);
			ClaimResponse.NativeMethodInfoPtr_IsAwaitingFulfillment_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663320);
			ClaimResponse.NativeMethodInfoPtr_FailedFullfillment_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663321);
			ClaimResponse.NativeMethodInfoPtr_FulfillmentDenied_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663322);
			ClaimResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, 100663323);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003358 File Offset: 0x00001558
		public unsafe string Id
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003390 File Offset: 0x00001590
		public unsafe string Url
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr_get_Url_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000033C8 File Offset: 0x000015C8
		public unsafe string Created
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr_get_Created_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003400 File Offset: 0x00001600
		public unsafe string Updated
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr_get_Updated_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003438 File Offset: 0x00001638
		public unsafe int StatusId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr_get_StatusId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003474 File Offset: 0x00001674
		public unsafe string StatusName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr_get_StatusName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000034AC File Offset: 0x000016AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267868, XrefRangeEnd = 1267876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimResponse(string id, string url, string created, string updated, ClaimResponse.Status status, List<ArchetypeID> archetypeIds, string transactionId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(created);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(updated);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(status);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypeIds);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Status_List_1_ArchetypeID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003568 File Offset: 0x00001768
		[CallerCount(0)]
		public unsafe bool IsFulfilled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr_IsFulfilled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000035A4 File Offset: 0x000017A4
		[CallerCount(0)]
		public unsafe bool IsAwaitingFulfillment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr_IsAwaitingFulfillment_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000035E0 File Offset: 0x000017E0
		[CallerCount(0)]
		public unsafe bool FailedFullfillment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr_FailedFullfillment_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000361C File Offset: 0x0000181C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1267876, RefRangeEnd = 1267877, XrefRangeStart = 1267876, XrefRangeEnd = 1267876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FulfillmentDenied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.NativeMethodInfoPtr_FulfillmentDenied_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003658 File Offset: 0x00001858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267877, XrefRangeEnd = 1267919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021AF File Offset: 0x000003AF
		public ClaimResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000369C File Offset: 0x0000189C
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000021B8 File Offset: 0x000003B8
		public unsafe string _Id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr__Id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000036C4 File Offset: 0x000018C4
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000021D7 File Offset: 0x000003D7
		public unsafe List<ArchetypeID> ArchetypeIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr_ArchetypeIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr_ArchetypeIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000036F4 File Offset: 0x000018F4
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000021F6 File Offset: 0x000003F6
		public unsafe string TransactionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr_TransactionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr_TransactionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000371C File Offset: 0x0000191C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002215 File Offset: 0x00000415
		public unsafe string _Url_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr__Url_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr__Url_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00003744 File Offset: 0x00001944
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002234 File Offset: 0x00000434
		public unsafe string _Created_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr__Created_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr__Created_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000376C File Offset: 0x0000196C
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002253 File Offset: 0x00000453
		public unsafe string _Updated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr__Updated_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr__Updated_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003794 File Offset: 0x00001994
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002272 File Offset: 0x00000472
		public unsafe ClaimResponse.Status status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr_status);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClaimResponse.Status>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.NativeFieldInfoPtr_status), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000037C4 File Offset: 0x000019C4
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002291 File Offset: 0x00000491
		public unsafe static int FulfilledId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClaimResponse.NativeFieldInfoPtr_FulfilledId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClaimResponse.NativeFieldInfoPtr_FulfilledId, (void*)(&value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000037E0 File Offset: 0x000019E0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0000229F File Offset: 0x0000049F
		public unsafe static int DeniedId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClaimResponse.NativeFieldInfoPtr_DeniedId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClaimResponse.NativeFieldInfoPtr_DeniedId, (void*)(&value));
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_ArchetypeIDs;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_TransactionID;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__Url_k__BackingField;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr__Created_k__BackingField;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr__Updated_k__BackingField;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_FulfilledId;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_DeniedId;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_Url_Public_get_String_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_Created_Public_get_String_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_Updated_Public_get_String_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusId_Public_get_Int32_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusName_Public_get_String_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Status_List_1_ArchetypeID_String_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_IsFulfilled_Public_Boolean_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_IsAwaitingFulfillment_Public_Boolean_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_FailedFullfillment_Public_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_FulfillmentDenied_Public_Boolean_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000012 RID: 18
		[Serializable]
		public class Status : Object
		{
			// Token: 0x060000CE RID: 206 RVA: 0x00004DC4 File Offset: 0x00002FC4
			// Note: this type is marked as 'beforefieldinit'.
			static Status()
			{
				Il2CppClassPointerStore<ClaimResponse.Status>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClaimResponse>.NativeClassPtr, "Status");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimResponse.Status>.NativeClassPtr);
				ClaimResponse.Status.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse.Status>.NativeClassPtr, "<Id>k__BackingField");
				ClaimResponse.Status.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimResponse.Status>.NativeClassPtr, "<Name>k__BackingField");
				ClaimResponse.Status.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse.Status>.NativeClassPtr, 100663324);
				ClaimResponse.Status.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse.Status>.NativeClassPtr, 100663325);
				ClaimResponse.Status.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse.Status>.NativeClassPtr, 100663326);
				ClaimResponse.Status.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimResponse.Status>.NativeClassPtr, 100663327);
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060000CF RID: 207 RVA: 0x00004E68 File Offset: 0x00003068
			public unsafe int Id
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.Status.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x00004EA4 File Offset: 0x000030A4
			public unsafe string Name
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.Status.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x00004EDC File Offset: 0x000030DC
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Status(int id, string name)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimResponse.Status>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimResponse.Status.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00004F38 File Offset: 0x00003138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267862, XrefRangeEnd = 1267868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimResponse.Status.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x000027E7 File Offset: 0x000009E7
			public Status(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x00004F7C File Offset: 0x0000317C
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x000027F0 File Offset: 0x000009F0
			public unsafe int _Id_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.Status.NativeFieldInfoPtr__Id_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.Status.NativeFieldInfoPtr__Id_k__BackingField)) = value;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x00004FA4 File Offset: 0x000031A4
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000280B File Offset: 0x00000A0B
			public unsafe string _Name_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.Status.NativeFieldInfoPtr__Name_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimResponse.Status.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400006D RID: 109
			private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

			// Token: 0x0400006E RID: 110
			private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

			// Token: 0x0400006F RID: 111
			private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

			// Token: 0x04000070 RID: 112
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

			// Token: 0x04000071 RID: 113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

			// Token: 0x04000072 RID: 114
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}
	}
}
