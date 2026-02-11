using System;
using dwd.iap.store;
using iap.claims;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.iap.steam
{
	// Token: 0x02000008 RID: 8
	public class SteamIAPStoreModel : IAPStoreModel
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000032D8 File Offset: 0x000014D8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamIAPStoreModel()
		{
			Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Steam.dll", "dwd.iap.steam", "SteamIAPStoreModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr);
			SteamIAPStoreModel.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, "SteamID");
			SteamIAPStoreModel.NativeFieldInfoPtr_anyProductPurchaseable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, "anyProductPurchaseable");
			SteamIAPStoreModel.NativeFieldInfoPtr_finalizedOrders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, "finalizedOrders");
			SteamIAPStoreModel.NativeFieldInfoPtr_GetLanguageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, "GetLanguageCallback");
			SteamIAPStoreModel.NativeFieldInfoPtr_purchaseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, "purchaseCommand");
			SteamIAPStoreModel.NativeMethodInfoPtr_get_IsStoreAvailable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, 100663352);
			SteamIAPStoreModel.NativeMethodInfoPtr_InitializeWithID_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, 100663353);
			SteamIAPStoreModel.NativeMethodInfoPtr_onOverlayActivated_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, 100663354);
			SteamIAPStoreModel.NativeMethodInfoPtr_preInitialize_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, 100663355);
			SteamIAPStoreModel.NativeMethodInfoPtr_populateCatalog_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, 100663356);
			SteamIAPStoreModel.NativeMethodInfoPtr_getOwnedProductsCommand_Protected_Virtual_GetProductOwnershipCommand_Action_1_HashSet_1_IAPProduct_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, 100663357);
			SteamIAPStoreModel.NativeMethodInfoPtr_purchase_Protected_Virtual_IEnumerator_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, 100663358);
			SteamIAPStoreModel.NativeMethodInfoPtr_onProductFulfillFailed_Protected_Virtual_Void_ClaimResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, 100663359);
			SteamIAPStoreModel.NativeMethodInfoPtr_uninitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, 100663360);
			SteamIAPStoreModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, 100663361);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003434 File Offset: 0x00001634
		public unsafe override bool IsStoreAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamIAPStoreModel.NativeMethodInfoPtr_get_IsStoreAvailable_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000347C File Offset: 0x0000167C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257878, XrefRangeEnd = 1257879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeWithID(string applicationID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(applicationID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamIAPStoreModel.NativeMethodInfoPtr_InitializeWithID_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000034CC File Offset: 0x000016CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257879, XrefRangeEnd = 1257887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onOverlayActivated(bool overlayActivated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overlayActivated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel.NativeMethodInfoPtr_onOverlayActivated_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000350C File Offset: 0x0000170C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257887, XrefRangeEnd = 1257892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator preInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamIAPStoreModel.NativeMethodInfoPtr_preInitialize_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003558 File Offset: 0x00001758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257892, XrefRangeEnd = 1257897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator populateCatalog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamIAPStoreModel.NativeMethodInfoPtr_populateCatalog_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000035A4 File Offset: 0x000017A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257897, XrefRangeEnd = 1257901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GetProductOwnershipCommand getOwnedProductsCommand(Action<HashSet<IAPProduct>> onOwnedProducts, Action<string> onFailed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onOwnedProducts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFailed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamIAPStoreModel.NativeMethodInfoPtr_getOwnedProductsCommand_Protected_Virtual_GetProductOwnershipCommand_Action_1_HashSet_1_IAPProduct_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetProductOwnershipCommand>(intPtr3) : null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003614 File Offset: 0x00001814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257901, XrefRangeEnd = 1257907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator purchase(IAPProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamIAPStoreModel.NativeMethodInfoPtr_purchase_Protected_Virtual_IEnumerator_IAPProduct_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003670 File Offset: 0x00001870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257907, XrefRangeEnd = 1257922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onProductFulfillFailed(ClaimResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamIAPStoreModel.NativeMethodInfoPtr_onProductFulfillFailed_Protected_Virtual_Void_ClaimResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000036C0 File Offset: 0x000018C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257922, XrefRangeEnd = 1257934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void uninitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamIAPStoreModel.NativeMethodInfoPtr_uninitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000036FC File Offset: 0x000018FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257934, XrefRangeEnd = 1257945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamIAPStoreModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000021A3 File Offset: 0x000003A3
		public SteamIAPStoreModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003738 File Offset: 0x00001938
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000021AC File Offset: 0x000003AC
		public unsafe ulong SteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel.NativeFieldInfoPtr_SteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel.NativeFieldInfoPtr_SteamID)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003760 File Offset: 0x00001960
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000021C7 File Offset: 0x000003C7
		public unsafe bool anyProductPurchaseable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel.NativeFieldInfoPtr_anyProductPurchaseable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel.NativeFieldInfoPtr_anyProductPurchaseable)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00003788 File Offset: 0x00001988
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000021E2 File Offset: 0x000003E2
		public unsafe HashSet<ulong> finalizedOrders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel.NativeFieldInfoPtr_finalizedOrders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel.NativeFieldInfoPtr_finalizedOrders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000037B8 File Offset: 0x000019B8
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002201 File Offset: 0x00000401
		public unsafe Func<string> GetLanguageCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel.NativeFieldInfoPtr_GetLanguageCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel.NativeFieldInfoPtr_GetLanguageCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000037E8 File Offset: 0x000019E8
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002220 File Offset: 0x00000420
		public unsafe PurchaseSteamProductCommand purchaseCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel.NativeFieldInfoPtr_purchaseCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchaseSteamProductCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel.NativeFieldInfoPtr_purchaseCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_anyProductPurchaseable;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_finalizedOrders;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_GetLanguageCallback;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_purchaseCommand;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStoreAvailable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_InitializeWithID_Public_Virtual_Void_String_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_onOverlayActivated_Private_Void_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_preInitialize_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_populateCatalog_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_getOwnedProductsCommand_Protected_Virtual_GetProductOwnershipCommand_Action_1_HashSet_1_IAPProduct_Action_1_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_purchase_Protected_Virtual_IEnumerator_IAPProduct_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_onProductFulfillFailed_Protected_Virtual_Void_ClaimResponse_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_uninitialize_Protected_Virtual_Void_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000013 RID: 19
		[ObfuscatedName("dwd.iap.steam.SteamIAPStoreModel+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060000D1 RID: 209 RVA: 0x00004F74 File Offset: 0x00003174
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamIAPStoreModel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamIAPStoreModel.__c>.NativeClassPtr);
				SteamIAPStoreModel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel.__c>.NativeClassPtr, "<>9");
				SteamIAPStoreModel.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel.__c>.NativeClassPtr, "<>9__9_0");
				SteamIAPStoreModel.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel.__c>.NativeClassPtr, "<>9__10_0");
				SteamIAPStoreModel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel.__c>.NativeClassPtr, 100663363);
				SteamIAPStoreModel.__c.NativeMethodInfoPtr__preInitialize_b__9_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel.__c>.NativeClassPtr, 100663364);
				SteamIAPStoreModel.__c.NativeMethodInfoPtr__populateCatalog_b__10_0_Internal_Boolean_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel.__c>.NativeClassPtr, 100663365);
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00005018 File Offset: 0x00003218
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamIAPStoreModel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x00005054 File Offset: 0x00003254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257775, XrefRangeEnd = 1257777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _preInitialize_b__9_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel.__c.NativeMethodInfoPtr__preInitialize_b__9_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x0000508C File Offset: 0x0000328C
			[CallerCount(0)]
			public unsafe bool _populateCatalog_b__10_0(IAPProduct p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel.__c.NativeMethodInfoPtr__populateCatalog_b__10_0_Internal_Boolean_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x000026EF File Offset: 0x000008EF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x000050DC File Offset: 0x000032DC
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x000026F8 File Offset: 0x000008F8
			public unsafe static SteamIAPStoreModel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamIAPStoreModel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamIAPStoreModel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamIAPStoreModel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005104 File Offset: 0x00003304
			// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000270A File Offset: 0x0000090A
			public unsafe static Func<string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamIAPStoreModel.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamIAPStoreModel.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000DA RID: 218 RVA: 0x0000512C File Offset: 0x0000332C
			// (set) Token: 0x060000DB RID: 219 RVA: 0x0000271C File Offset: 0x0000091C
			public unsafe static Func<IAPProduct, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamIAPStoreModel.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAPProduct, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamIAPStoreModel.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000079 RID: 121
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400007A RID: 122
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400007B RID: 123
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400007C RID: 124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400007D RID: 125
			private static readonly IntPtr NativeMethodInfoPtr__preInitialize_b__9_0_Internal_String_0;

			// Token: 0x0400007E RID: 126
			private static readonly IntPtr NativeMethodInfoPtr__populateCatalog_b__10_0_Internal_Boolean_IAPProduct_0;
		}

		// Token: 0x02000014 RID: 20
		[ObfuscatedName("dwd.iap.steam.SteamIAPStoreModel+<populateCatalog>d__10")]
		public sealed class _populateCatalog_d__10 : Object
		{
			// Token: 0x060000DC RID: 220 RVA: 0x00005154 File Offset: 0x00003354
			// Note: this type is marked as 'beforefieldinit'.
			static _populateCatalog_d__10()
			{
				Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, "<populateCatalog>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr);
				SteamIAPStoreModel._populateCatalog_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr, "<>1__state");
				SteamIAPStoreModel._populateCatalog_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr, "<>2__current");
				SteamIAPStoreModel._populateCatalog_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr, "<>4__this");
				SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr, 100663366);
				SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr, 100663367);
				SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr, 100663368);
				SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr, 100663369);
				SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr, 100663370);
				SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr, 100663371);
			}

			// Token: 0x060000DD RID: 221 RVA: 0x00005234 File Offset: 0x00003434
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _populateCatalog_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamIAPStoreModel._populateCatalog_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000DE RID: 222 RVA: 0x0000527C File Offset: 0x0000347C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000DF RID: 223 RVA: 0x000052B0 File Offset: 0x000034B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257777, XrefRangeEnd = 1257817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x000052EC File Offset: 0x000034EC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x0000532C File Offset: 0x0000352C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257817, XrefRangeEnd = 1257822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005360 File Offset: 0x00003560
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._populateCatalog_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x0000272E File Offset: 0x0000092E
			public _populateCatalog_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x000053A0 File Offset: 0x000035A0
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002737 File Offset: 0x00000937
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._populateCatalog_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._populateCatalog_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x000053C8 File Offset: 0x000035C8
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002752 File Offset: 0x00000952
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._populateCatalog_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._populateCatalog_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x000053F8 File Offset: 0x000035F8
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002771 File Offset: 0x00000971
			public unsafe SteamIAPStoreModel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._populateCatalog_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamIAPStoreModel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._populateCatalog_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400007F RID: 127
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000080 RID: 128
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000081 RID: 129
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000082 RID: 130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000083 RID: 131
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000084 RID: 132
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000085 RID: 133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000086 RID: 134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000087 RID: 135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000015 RID: 21
		[ObfuscatedName("dwd.iap.steam.SteamIAPStoreModel+<preInitialize>d__9")]
		public sealed class _preInitialize_d__9 : Object
		{
			// Token: 0x060000EA RID: 234 RVA: 0x00005428 File Offset: 0x00003628
			// Note: this type is marked as 'beforefieldinit'.
			static _preInitialize_d__9()
			{
				Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, "<preInitialize>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr);
				SteamIAPStoreModel._preInitialize_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr, "<>1__state");
				SteamIAPStoreModel._preInitialize_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr, "<>2__current");
				SteamIAPStoreModel._preInitialize_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr, "<>4__this");
				SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr, 100663372);
				SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr, 100663373);
				SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr, 100663374);
				SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr, 100663375);
				SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr, 100663376);
				SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr, 100663377);
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00005508 File Offset: 0x00003708
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _preInitialize_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamIAPStoreModel._preInitialize_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00005550 File Offset: 0x00003750
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00005584 File Offset: 0x00003784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257822, XrefRangeEnd = 1257854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060000EE RID: 238 RVA: 0x000055C0 File Offset: 0x000037C0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00005600 File Offset: 0x00003800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257854, XrefRangeEnd = 1257859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005634 File Offset: 0x00003834
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._preInitialize_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000F1 RID: 241 RVA: 0x00002790 File Offset: 0x00000990
			public _preInitialize_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005674 File Offset: 0x00003874
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002799 File Offset: 0x00000999
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._preInitialize_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._preInitialize_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000569C File Offset: 0x0000389C
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x000027B4 File Offset: 0x000009B4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._preInitialize_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._preInitialize_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x000056CC File Offset: 0x000038CC
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x000027D3 File Offset: 0x000009D3
			public unsafe SteamIAPStoreModel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._preInitialize_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamIAPStoreModel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._preInitialize_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000088 RID: 136
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000089 RID: 137
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400008A RID: 138
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400008B RID: 139
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400008C RID: 140
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400008D RID: 141
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400008E RID: 142
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400008F RID: 143
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000090 RID: 144
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000016 RID: 22
		[ObfuscatedName("dwd.iap.steam.SteamIAPStoreModel+<purchase>d__12")]
		public sealed class _purchase_d__12 : Object
		{
			// Token: 0x060000F8 RID: 248 RVA: 0x000056FC File Offset: 0x000038FC
			// Note: this type is marked as 'beforefieldinit'.
			static _purchase_d__12()
			{
				Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamIAPStoreModel>.NativeClassPtr, "<purchase>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr);
				SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr, "<>1__state");
				SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr, "<>2__current");
				SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr, "<>4__this");
				SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr, "product");
				SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr, 100663378);
				SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr, 100663379);
				SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr, 100663380);
				SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr, 100663381);
				SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr, 100663382);
				SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr, 100663383);
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x000057F0 File Offset: 0x000039F0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _purchase_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamIAPStoreModel._purchase_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000FA RID: 250 RVA: 0x00005838 File Offset: 0x00003A38
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000FB RID: 251 RVA: 0x0000586C File Offset: 0x00003A6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257859, XrefRangeEnd = 1257873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060000FC RID: 252 RVA: 0x000058A8 File Offset: 0x00003AA8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000FD RID: 253 RVA: 0x000058E8 File Offset: 0x00003AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257873, XrefRangeEnd = 1257878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060000FE RID: 254 RVA: 0x0000591C File Offset: 0x00003B1C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIAPStoreModel._purchase_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000FF RID: 255 RVA: 0x000027F2 File Offset: 0x000009F2
			public _purchase_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000100 RID: 256 RVA: 0x0000595C File Offset: 0x00003B5C
			// (set) Token: 0x06000101 RID: 257 RVA: 0x000027FB File Offset: 0x000009FB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000102 RID: 258 RVA: 0x00005984 File Offset: 0x00003B84
			// (set) Token: 0x06000103 RID: 259 RVA: 0x00002816 File Offset: 0x00000A16
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000104 RID: 260 RVA: 0x000059B4 File Offset: 0x00003BB4
			// (set) Token: 0x06000105 RID: 261 RVA: 0x00002835 File Offset: 0x00000A35
			public unsafe SteamIAPStoreModel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamIAPStoreModel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000106 RID: 262 RVA: 0x000059E4 File Offset: 0x00003BE4
			// (set) Token: 0x06000107 RID: 263 RVA: 0x00002854 File Offset: 0x00000A54
			public unsafe IAPProduct product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamIAPStoreModel._purchase_d__12.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000091 RID: 145
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000092 RID: 146
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000093 RID: 147
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000094 RID: 148
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04000095 RID: 149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000096 RID: 150
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000097 RID: 151
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000098 RID: 152
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000099 RID: 153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400009A RID: 154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
