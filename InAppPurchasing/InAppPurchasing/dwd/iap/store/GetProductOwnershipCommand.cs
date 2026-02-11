using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.platform.authentication;
using iap.claims;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.iap.store
{
	// Token: 0x0200000E RID: 14
	public class GetProductOwnershipCommand : Command
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00005298 File Offset: 0x00003498
		// Note: this type is marked as 'beforefieldinit'.
		static GetProductOwnershipCommand()
		{
			Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "GetProductOwnershipCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr);
			GetProductOwnershipCommand.NativeFieldInfoPtr_storeModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "storeModel");
			GetProductOwnershipCommand.NativeFieldInfoPtr_onOwnedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "onOwnedProducts");
			GetProductOwnershipCommand.NativeFieldInfoPtr_onFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "onFailed");
			GetProductOwnershipCommand.NativeFieldInfoPtr_ownedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "ownedProducts");
			GetProductOwnershipCommand.NativeFieldInfoPtr_ownershipEndpointArchetypeIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "ownershipEndpointArchetypeIds");
			GetProductOwnershipCommand.NativeFieldInfoPtr_MaxDaysOffline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "MaxDaysOffline");
			GetProductOwnershipCommand.NativeMethodInfoPtr_getPlatformTokenProducts_Protected_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663391);
			GetProductOwnershipCommand.NativeMethodInfoPtr_get_platformToken_Private_get_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663392);
			GetProductOwnershipCommand.NativeMethodInfoPtr_get_havePlatformToken_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663393);
			GetProductOwnershipCommand.NativeMethodInfoPtr__ctor_Protected_Void_IAPStoreModel_Action_1_HashSet_1_IAPProduct_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663394);
			GetProductOwnershipCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663395);
			GetProductOwnershipCommand.NativeMethodInfoPtr_initMetadata_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663396);
			GetProductOwnershipCommand.NativeMethodInfoPtr_checkLocalOwnershipDiscrepancies_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663397);
			GetProductOwnershipCommand.NativeMethodInfoPtr_verifyLocalOwnership_Protected_List_1_ValueTuple_2_ArchetypeID_Il2CppStringArray_Func_2_IAPProduct_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663398);
			GetProductOwnershipCommand.NativeMethodInfoPtr_onClaimSuccess_Protected_Void_ClaimResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663399);
			GetProductOwnershipCommand.NativeMethodInfoPtr_onClaimSuccessWithArchIds_Protected_Void_ClaimResponse_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663400);
			GetProductOwnershipCommand.NativeMethodInfoPtr_onClaimSuccessWithArchId_Protected_Void_ClaimResponse_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663401);
			GetProductOwnershipCommand.NativeMethodInfoPtr_onClaimFailure_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, 100663402);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005430 File Offset: 0x00003630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1200309, RefRangeEnd = 1200310, XrefRangeStart = 1200277, XrefRangeEnd = 1200309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ArchetypeID> getPlatformTokenProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.NativeMethodInfoPtr_getPlatformTokenProducts_Protected_List_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr3) : null;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00005470 File Offset: 0x00003670
		public unsafe PlatformToken platformToken
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1200323, RefRangeEnd = 1200327, XrefRangeStart = 1200310, XrefRangeEnd = 1200323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.NativeMethodInfoPtr_get_platformToken_Private_get_PlatformToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr3) : null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000054B0 File Offset: 0x000036B0
		public unsafe bool havePlatformToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200327, XrefRangeEnd = 1200328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.NativeMethodInfoPtr_get_havePlatformToken_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000054EC File Offset: 0x000036EC
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 998618, RefRangeEnd = 998746, XrefRangeStart = 998618, XrefRangeEnd = 998746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetProductOwnershipCommand(IAPStoreModel storeModel, Action<HashSet<IAPProduct>> onOwnedProducts, Action<string> onFailed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeModel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onOwnedProducts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFailed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.NativeMethodInfoPtr__ctor_Protected_Void_IAPStoreModel_Action_1_HashSet_1_IAPProduct_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000555C File Offset: 0x0000375C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200328, XrefRangeEnd = 1200333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetProductOwnershipCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000055A8 File Offset: 0x000037A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200333, XrefRangeEnd = 1200337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator initMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetProductOwnershipCommand.NativeMethodInfoPtr_initMetadata_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000055F4 File Offset: 0x000037F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200337, XrefRangeEnd = 1200341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator checkLocalOwnershipDiscrepancies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetProductOwnershipCommand.NativeMethodInfoPtr_checkLocalOwnershipDiscrepancies_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005640 File Offset: 0x00003840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1200411, RefRangeEnd = 1200412, XrefRangeStart = 1200341, XrefRangeEnd = 1200411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ValueTuple<ArchetypeID, Il2CppStringArray>> verifyLocalOwnership(Func<IAPProduct, Il2CppStringArray> getStoreOwnership)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getStoreOwnership);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.NativeMethodInfoPtr_verifyLocalOwnership_Protected_List_1_ValueTuple_2_ArchetypeID_Il2CppStringArray_Func_2_IAPProduct_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<ArchetypeID, Il2CppStringArray>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005690 File Offset: 0x00003890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200412, XrefRangeEnd = 1200417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onClaimSuccess(ClaimResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.NativeMethodInfoPtr_onClaimSuccess_Protected_Void_ClaimResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000056D4 File Offset: 0x000038D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200417, XrefRangeEnd = 1200431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onClaimSuccessWithArchIds(ClaimResponse response, List<ArchetypeID> archetypeIds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypeIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.NativeMethodInfoPtr_onClaimSuccessWithArchIds_Protected_Void_ClaimResponse_List_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005728 File Offset: 0x00003928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200431, XrefRangeEnd = 1200465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onClaimSuccessWithArchId(ClaimResponse response, ArchetypeID archetypeID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.NativeMethodInfoPtr_onClaimSuccessWithArchId_Protected_Void_ClaimResponse_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000577C File Offset: 0x0000397C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onClaimFailure(string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.NativeMethodInfoPtr_onClaimFailure_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000022F4 File Offset: 0x000004F4
		public GetProductOwnershipCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000057C0 File Offset: 0x000039C0
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000022FD File Offset: 0x000004FD
		public unsafe IAPStoreModel storeModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.NativeFieldInfoPtr_storeModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.NativeFieldInfoPtr_storeModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000057F0 File Offset: 0x000039F0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000231C File Offset: 0x0000051C
		public unsafe Action<HashSet<IAPProduct>> onOwnedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.NativeFieldInfoPtr_onOwnedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HashSet<IAPProduct>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.NativeFieldInfoPtr_onOwnedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00005820 File Offset: 0x00003A20
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000233B File Offset: 0x0000053B
		public unsafe Action<string> onFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.NativeFieldInfoPtr_onFailed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.NativeFieldInfoPtr_onFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00005850 File Offset: 0x00003A50
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000235A File Offset: 0x0000055A
		public unsafe HashSet<IAPProduct> ownedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.NativeFieldInfoPtr_ownedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IAPProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.NativeFieldInfoPtr_ownedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00005880 File Offset: 0x00003A80
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002379 File Offset: 0x00000579
		public unsafe List<ArchetypeID> ownershipEndpointArchetypeIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.NativeFieldInfoPtr_ownershipEndpointArchetypeIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.NativeFieldInfoPtr_ownershipEndpointArchetypeIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000058B0 File Offset: 0x00003AB0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002398 File Offset: 0x00000598
		public unsafe static int MaxDaysOffline
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetProductOwnershipCommand.NativeFieldInfoPtr_MaxDaysOffline, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetProductOwnershipCommand.NativeFieldInfoPtr_MaxDaysOffline, (void*)(&value));
			}
		}

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_storeModel;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_onOwnedProducts;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_onFailed;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_ownedProducts;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_ownershipEndpointArchetypeIds;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_MaxDaysOffline;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_getPlatformTokenProducts_Protected_List_1_ArchetypeID_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_get_platformToken_Private_get_PlatformToken_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_get_havePlatformToken_Protected_get_Boolean_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IAPStoreModel_Action_1_HashSet_1_IAPProduct_Action_1_String_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_initMetadata_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_checkLocalOwnershipDiscrepancies_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_verifyLocalOwnership_Protected_List_1_ValueTuple_2_ArchetypeID_Il2CppStringArray_Func_2_IAPProduct_Il2CppStringArray_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_onClaimSuccess_Protected_Void_ClaimResponse_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_onClaimSuccessWithArchIds_Protected_Void_ClaimResponse_List_1_ArchetypeID_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_onClaimSuccessWithArchId_Protected_Void_ClaimResponse_ArchetypeID_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_onClaimFailure_Protected_Void_String_0;

		// Token: 0x02000034 RID: 52
		[ObfuscatedName("dwd.iap.store.GetProductOwnershipCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060002EA RID: 746 RVA: 0x0000DD54 File Offset: 0x0000BF54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GetProductOwnershipCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetProductOwnershipCommand.__c>.NativeClassPtr);
				GetProductOwnershipCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand.__c>.NativeClassPtr, "<>9");
				GetProductOwnershipCommand.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand.__c>.NativeClassPtr, "<>9__5_0");
				GetProductOwnershipCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand.__c>.NativeClassPtr, 100663404);
				GetProductOwnershipCommand.__c.NativeMethodInfoPtr__getPlatformTokenProducts_b__5_0_Internal_ArchetypeID_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand.__c>.NativeClassPtr, 100663405);
			}

			// Token: 0x060002EB RID: 747 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetProductOwnershipCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EC RID: 748 RVA: 0x0000DE0C File Offset: 0x0000C00C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200198, XrefRangeEnd = 1200202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _getPlatformTokenProducts_b__5_0(Object p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.__c.NativeMethodInfoPtr__getPlatformTokenProducts_b__5_0_Internal_ArchetypeID_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x060002ED RID: 749 RVA: 0x00003470 File Offset: 0x00001670
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060002EE RID: 750 RVA: 0x0000DE5C File Offset: 0x0000C05C
			// (set) Token: 0x060002EF RID: 751 RVA: 0x00003479 File Offset: 0x00001679
			public unsafe static GetProductOwnershipCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetProductOwnershipCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetProductOwnershipCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetProductOwnershipCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000DE84 File Offset: 0x0000C084
			// (set) Token: 0x060002F1 RID: 753 RVA: 0x0000348B File Offset: 0x0000168B
			public unsafe static Func<Object, ArchetypeID> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetProductOwnershipCommand.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetProductOwnershipCommand.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001FC RID: 508
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001FD RID: 509
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040001FE RID: 510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001FF RID: 511
			private static readonly IntPtr NativeMethodInfoPtr__getPlatformTokenProducts_b__5_0_Internal_ArchetypeID_Object_0;
		}

		// Token: 0x02000035 RID: 53
		[ObfuscatedName("dwd.iap.store.GetProductOwnershipCommand+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x060002F2 RID: 754 RVA: 0x0000DEAC File Offset: 0x0000C0AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<GetProductOwnershipCommand.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetProductOwnershipCommand.__c__DisplayClass12_0>.NativeClassPtr);
				GetProductOwnershipCommand.__c__DisplayClass12_0.NativeFieldInfoPtr_offlineProductStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand.__c__DisplayClass12_0>.NativeClassPtr, "offlineProductStorage");
				GetProductOwnershipCommand.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand.__c__DisplayClass12_0>.NativeClassPtr, 100663406);
				GetProductOwnershipCommand.__c__DisplayClass12_0.NativeMethodInfoPtr__execute_b__0_Internal_Void_OfflineProductStorage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand.__c__DisplayClass12_0>.NativeClassPtr, 100663407);
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x0000DF14 File Offset: 0x0000C114
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetProductOwnershipCommand.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F4 RID: 756 RVA: 0x0000DF50 File Offset: 0x0000C150
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__0(OfflineProductStorage storage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(storage);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand.__c__DisplayClass12_0.NativeMethodInfoPtr__execute_b__0_Internal_Void_OfflineProductStorage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x0000349D File Offset: 0x0000169D
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000DF94 File Offset: 0x0000C194
			// (set) Token: 0x060002F7 RID: 759 RVA: 0x000034A6 File Offset: 0x000016A6
			public unsafe OfflineProductStorage offlineProductStorage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.__c__DisplayClass12_0.NativeFieldInfoPtr_offlineProductStorage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfflineProductStorage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand.__c__DisplayClass12_0.NativeFieldInfoPtr_offlineProductStorage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000200 RID: 512
			private static readonly IntPtr NativeFieldInfoPtr_offlineProductStorage;

			// Token: 0x04000201 RID: 513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000202 RID: 514
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Void_OfflineProductStorage_0;
		}

		// Token: 0x02000036 RID: 54
		[ObfuscatedName("dwd.iap.store.GetProductOwnershipCommand+<checkLocalOwnershipDiscrepancies>d__14")]
		public sealed class _checkLocalOwnershipDiscrepancies_d__14 : Object
		{
			// Token: 0x060002F8 RID: 760 RVA: 0x0000DFC4 File Offset: 0x0000C1C4
			// Note: this type is marked as 'beforefieldinit'.
			static _checkLocalOwnershipDiscrepancies_d__14()
			{
				Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "<checkLocalOwnershipDiscrepancies>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr);
				GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr, "<>1__state");
				GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr, "<>2__current");
				GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr, 100663408);
				GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr, 100663409);
				GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr, 100663410);
				GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr, 100663411);
				GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr, 100663412);
				GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr, 100663413);
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x0000E090 File Offset: 0x0000C290
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _checkLocalOwnershipDiscrepancies_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002FA RID: 762 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002FB RID: 763 RVA: 0x0000E10C File Offset: 0x0000C30C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x060002FC RID: 764 RVA: 0x0000E148 File Offset: 0x0000C348
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002FD RID: 765 RVA: 0x0000E188 File Offset: 0x0000C388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200202, XrefRangeEnd = 1200207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x060002FE RID: 766 RVA: 0x0000E1BC File Offset: 0x0000C3BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002FF RID: 767 RVA: 0x000034C5 File Offset: 0x000016C5
			public _checkLocalOwnershipDiscrepancies_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x06000300 RID: 768 RVA: 0x0000E1FC File Offset: 0x0000C3FC
			// (set) Token: 0x06000301 RID: 769 RVA: 0x000034CE File Offset: 0x000016CE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000302 RID: 770 RVA: 0x0000E224 File Offset: 0x0000C424
			// (set) Token: 0x06000303 RID: 771 RVA: 0x000034E9 File Offset: 0x000016E9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._checkLocalOwnershipDiscrepancies_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000203 RID: 515
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000204 RID: 516
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000205 RID: 517
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000206 RID: 518
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000207 RID: 519
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000208 RID: 520
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000209 RID: 521
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400020A RID: 522
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000037 RID: 55
		[ObfuscatedName("dwd.iap.store.GetProductOwnershipCommand+<execute>d__12")]
		public sealed class _execute_d__12 : Object
		{
			// Token: 0x06000304 RID: 772 RVA: 0x0000E254 File Offset: 0x0000C454
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__12()
			{
				Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "<execute>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr);
				GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, "<>1__state");
				GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, "<>2__current");
				GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, "<>4__this");
				GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, "<>8__1");
				GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr__noCatalog_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, "<noCatalog>5__2");
				GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr__online_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, "<online>5__3");
				GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, 100663414);
				GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, 100663415);
				GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, 100663416);
				GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, 100663417);
				GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, 100663418);
				GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr, 100663419);
			}

			// Token: 0x06000305 RID: 773 RVA: 0x0000E370 File Offset: 0x0000C570
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetProductOwnershipCommand._execute_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000306 RID: 774 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000307 RID: 775 RVA: 0x0000E3EC File Offset: 0x0000C5EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200207, XrefRangeEnd = 1200267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000308 RID: 776 RVA: 0x0000E428 File Offset: 0x0000C628
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000309 RID: 777 RVA: 0x0000E468 File Offset: 0x0000C668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200267, XrefRangeEnd = 1200272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x0600030A RID: 778 RVA: 0x0000E49C File Offset: 0x0000C69C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600030B RID: 779 RVA: 0x00003508 File Offset: 0x00001708
			public _execute_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x0600030C RID: 780 RVA: 0x0000E4DC File Offset: 0x0000C6DC
			// (set) Token: 0x0600030D RID: 781 RVA: 0x00003511 File Offset: 0x00001711
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x0600030E RID: 782 RVA: 0x0000E504 File Offset: 0x0000C704
			// (set) Token: 0x0600030F RID: 783 RVA: 0x0000352C File Offset: 0x0000172C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000310 RID: 784 RVA: 0x0000E534 File Offset: 0x0000C734
			// (set) Token: 0x06000311 RID: 785 RVA: 0x0000354B File Offset: 0x0000174B
			public unsafe GetProductOwnershipCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetProductOwnershipCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000312 RID: 786 RVA: 0x0000E564 File Offset: 0x0000C764
			// (set) Token: 0x06000313 RID: 787 RVA: 0x0000356A File Offset: 0x0000176A
			public unsafe GetProductOwnershipCommand.__c__DisplayClass12_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetProductOwnershipCommand.__c__DisplayClass12_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x06000314 RID: 788 RVA: 0x0000E594 File Offset: 0x0000C794
			// (set) Token: 0x06000315 RID: 789 RVA: 0x00003589 File Offset: 0x00001789
			public unsafe bool _noCatalog_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr__noCatalog_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr__noCatalog_5__2)) = value;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000316 RID: 790 RVA: 0x0000E5BC File Offset: 0x0000C7BC
			// (set) Token: 0x06000317 RID: 791 RVA: 0x000035A4 File Offset: 0x000017A4
			public unsafe bool _online_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr__online_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._execute_d__12.NativeFieldInfoPtr__online_5__3)) = value;
				}
			}

			// Token: 0x0400020B RID: 523
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400020C RID: 524
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400020D RID: 525
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400020E RID: 526
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400020F RID: 527
			private static readonly IntPtr NativeFieldInfoPtr__noCatalog_5__2;

			// Token: 0x04000210 RID: 528
			private static readonly IntPtr NativeFieldInfoPtr__online_5__3;

			// Token: 0x04000211 RID: 529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000212 RID: 530
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000213 RID: 531
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000214 RID: 532
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000215 RID: 533
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000216 RID: 534
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000038 RID: 56
		[ObfuscatedName("dwd.iap.store.GetProductOwnershipCommand+<initMetadata>d__13")]
		public sealed class _initMetadata_d__13 : Object
		{
			// Token: 0x06000318 RID: 792 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
			// Note: this type is marked as 'beforefieldinit'.
			static _initMetadata_d__13()
			{
				Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetProductOwnershipCommand>.NativeClassPtr, "<initMetadata>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr);
				GetProductOwnershipCommand._initMetadata_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr, "<>1__state");
				GetProductOwnershipCommand._initMetadata_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr, "<>2__current");
				GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr, 100663420);
				GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr, 100663421);
				GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr, 100663422);
				GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr, 100663423);
				GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr, 100663424);
				GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr, 100663425);
			}

			// Token: 0x06000319 RID: 793 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _initMetadata_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetProductOwnershipCommand._initMetadata_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600031A RID: 794 RVA: 0x0000E6F8 File Offset: 0x0000C8F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600031B RID: 795 RVA: 0x0000E72C File Offset: 0x0000C92C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x0600031C RID: 796 RVA: 0x0000E768 File Offset: 0x0000C968
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600031D RID: 797 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200272, XrefRangeEnd = 1200277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x0600031E RID: 798 RVA: 0x0000E7DC File Offset: 0x0000C9DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProductOwnershipCommand._initMetadata_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600031F RID: 799 RVA: 0x000035BF File Offset: 0x000017BF
			public _initMetadata_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000320 RID: 800 RVA: 0x0000E81C File Offset: 0x0000CA1C
			// (set) Token: 0x06000321 RID: 801 RVA: 0x000035C8 File Offset: 0x000017C8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._initMetadata_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._initMetadata_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000322 RID: 802 RVA: 0x0000E844 File Offset: 0x0000CA44
			// (set) Token: 0x06000323 RID: 803 RVA: 0x000035E3 File Offset: 0x000017E3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._initMetadata_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetProductOwnershipCommand._initMetadata_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000217 RID: 535
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000218 RID: 536
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000219 RID: 537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400021A RID: 538
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400021B RID: 539
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400021C RID: 540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400021D RID: 541
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400021E RID: 542
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
