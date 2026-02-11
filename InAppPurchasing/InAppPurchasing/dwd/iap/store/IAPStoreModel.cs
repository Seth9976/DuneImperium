using System;
using System.Runtime.InteropServices;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.providers;
using dwd.core.logging;
using iap.claims;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine;

namespace dwd.iap.store
{
	// Token: 0x02000017 RID: 23
	public class IAPStoreModel : DataProvider
	{
		// Token: 0x06000138 RID: 312 RVA: 0x000084FC File Offset: 0x000066FC
		// Note: this type is marked as 'beforefieldinit'.
		static IAPStoreModel()
		{
			Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "IAPStoreModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr);
			IAPStoreModel.NativeFieldInfoPtr_OnModelInitializedFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "OnModelInitializedFailed");
			IAPStoreModel.NativeFieldInfoPtr_OnFulfillProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "OnFulfillProduct");
			IAPStoreModel.NativeFieldInfoPtr_OnOwnedProductsReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "OnOwnedProductsReceived");
			IAPStoreModel.NativeFieldInfoPtr_FAKESTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "FAKESTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_STUBSTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "STUBSTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_APPLESTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "APPLESTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_MACSTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "MACSTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_GOOGLEPLAYSTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "GOOGLEPLAYSTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_AMAZONSTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "AMAZONSTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_WINDOWSSTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "WINDOWSSTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_XBOXSTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "XBOXSTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_PLAYSTATIONSTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "PLAYSTATIONSTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_STEAMSTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "STEAMSTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_DIRECTSTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "DIRECTSTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_NINTENDOSTORENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "NINTENDOSTORENAME");
			IAPStoreModel.NativeFieldInfoPtr_PLATFORM_TOKEN_TYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "PLATFORM_TOKEN_TYPE");
			IAPStoreModel.NativeFieldInfoPtr_ANON_TOKEN_TYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "ANON_TOKEN_TYPE");
			IAPStoreModel.NativeFieldInfoPtr_editorLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "editorLogger");
			IAPStoreModel.NativeFieldInfoPtr__DebugLogging_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<DebugLogging>k__BackingField");
			IAPStoreModel.NativeFieldInfoPtr_catalog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "catalog");
			IAPStoreModel.NativeFieldInfoPtr_catalogAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "catalogAvailable");
			IAPStoreModel.NativeFieldInfoPtr_ownedProductsReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "ownedProductsReceived");
			IAPStoreModel.NativeFieldInfoPtr_ownedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "ownedProducts");
			IAPStoreModel.NativeFieldInfoPtr_licensedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "licensedProducts");
			IAPStoreModel.NativeFieldInfoPtr_unfulfilledProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "unfulfilledProducts");
			IAPStoreModel.NativeFieldInfoPtr_pendingClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "pendingClaims");
			IAPStoreModel.NativeFieldInfoPtr_history = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "history");
			IAPStoreModel.NativeFieldInfoPtr_inputShield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "inputShield");
			IAPStoreModel.NativeFieldInfoPtr_productProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "productProvider");
			IAPStoreModel.NativeFieldInfoPtr_purchaseInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "purchaseInProgress");
			IAPStoreModel.NativeFieldInfoPtr_storeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "storeName");
			IAPStoreModel.NativeMethodInfoPtr_add_OnModelInitializedFailed_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663571);
			IAPStoreModel.NativeMethodInfoPtr_remove_OnModelInitializedFailed_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663572);
			IAPStoreModel.NativeMethodInfoPtr_add_OnFulfillProduct_Public_Static_add_Void_Action_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663573);
			IAPStoreModel.NativeMethodInfoPtr_remove_OnFulfillProduct_Public_Static_rem_Void_Action_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663574);
			IAPStoreModel.NativeMethodInfoPtr_add_OnOwnedProductsReceived_Public_Static_add_Void_Action_1_HashSet_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663575);
			IAPStoreModel.NativeMethodInfoPtr_remove_OnOwnedProductsReceived_Public_Static_rem_Void_Action_1_HashSet_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663576);
			IAPStoreModel.NativeMethodInfoPtr_get_grayLogErrorLabel_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663577);
			IAPStoreModel.NativeMethodInfoPtr_get_EditorLogger_Public_Static_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663578);
			IAPStoreModel.NativeMethodInfoPtr_set_EditorLogger_Public_Static_set_Void_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663579);
			IAPStoreModel.NativeMethodInfoPtr_get_DebugLogging_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663580);
			IAPStoreModel.NativeMethodInfoPtr_set_DebugLogging_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663581);
			IAPStoreModel.NativeMethodInfoPtr_get_Catalog_Public_get_IReadOnlyDictionary_2_String_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663582);
			IAPStoreModel.NativeMethodInfoPtr_InitializeWithID_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663583);
			IAPStoreModel.NativeMethodInfoPtr_AddToCatalog_Public_Void_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663584);
			IAPStoreModel.NativeMethodInfoPtr_get_CatalogAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663585);
			IAPStoreModel.NativeMethodInfoPtr_get_OwnedProductsReceived_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663586);
			IAPStoreModel.NativeMethodInfoPtr_get_OwnedProducts_Public_get_IReadOnlyCollection_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663587);
			IAPStoreModel.NativeMethodInfoPtr_get_LicensedProducts_Public_get_HashSet_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663588);
			IAPStoreModel.NativeMethodInfoPtr_AddToOwnedProducts_Public_IEnumerator_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663589);
			IAPStoreModel.NativeMethodInfoPtr_get_History_Public_get_ReadOnlyCollection_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663590);
			IAPStoreModel.NativeMethodInfoPtr_AddToHistory_Public_Void_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663591);
			IAPStoreModel.NativeMethodInfoPtr_get_ProductProvider_Public_get_IIAPProductProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663592);
			IAPStoreModel.NativeMethodInfoPtr_Initialize_Public_IEnumerator_IIAPProductProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663593);
			IAPStoreModel.NativeMethodInfoPtr_onOwnedProductsReceived_Private_Void_HashSet_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663594);
			IAPStoreModel.NativeMethodInfoPtr_invokeInitializedFailed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663595);
			IAPStoreModel.NativeMethodInfoPtr_RefreshOwnedProducts_Public_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663596);
			IAPStoreModel.NativeMethodInfoPtr_preInitialize_Protected_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663597);
			IAPStoreModel.NativeMethodInfoPtr_populateCatalog_Protected_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663598);
			IAPStoreModel.NativeMethodInfoPtr_getOwnedProductsCommand_Protected_Abstract_Virtual_New_GetProductOwnershipCommand_Action_1_HashSet_1_IAPProduct_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663599);
			IAPStoreModel.NativeMethodInfoPtr_populateHistory_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663600);
			IAPStoreModel.NativeMethodInfoPtr_postInitialize_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663601);
			IAPStoreModel.NativeMethodInfoPtr_get_PurchaseInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663602);
			IAPStoreModel.NativeMethodInfoPtr_set_PurchaseInProgress_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663603);
			IAPStoreModel.NativeMethodInfoPtr_checkPendingClaims_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663604);
			IAPStoreModel.NativeMethodInfoPtr_GetPurchaseCommand_Public_PurchaseIAPProductCommand_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663605);
			IAPStoreModel.NativeMethodInfoPtr_GetRestorePurchaseCommand_Public_Virtual_New_IAPRestorePurchasesCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663606);
			IAPStoreModel.NativeMethodInfoPtr_purchase_Protected_Abstract_Virtual_New_IEnumerator_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663607);
			IAPStoreModel.NativeMethodInfoPtr_RefreshProductCatalog_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663608);
			IAPStoreModel.NativeMethodInfoPtr_get_StoreName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663609);
			IAPStoreModel.NativeMethodInfoPtr_get_IsStoreAvailable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663610);
			IAPStoreModel.NativeMethodInfoPtr_get_CanMakePayments_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663611);
			IAPStoreModel.NativeMethodInfoPtr_Uninitialize_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663612);
			IAPStoreModel.NativeMethodInfoPtr_uninitialize_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663613);
			IAPStoreModel.NativeMethodInfoPtr_get_PlatformToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663614);
			IAPStoreModel.NativeMethodInfoPtr_get_CommerceURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663615);
			IAPStoreModel.NativeMethodInfoPtr_GetSubmitClaimCommand_Public_Command_Action_2_ClaimResponse_ArchetypeID_Action_1_String_ArchetypeID_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663616);
			IAPStoreModel.NativeMethodInfoPtr_GetSubmitClaimCommand_Public_Command_Action_2_ClaimResponse_List_1_ArchetypeID_Action_1_String_List_1_ArchetypeID_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663617);
			IAPStoreModel.NativeMethodInfoPtr_GetSubmitClaimCommand_Public_Command_Action_1_ClaimResponse_Action_1_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663618);
			IAPStoreModel.NativeMethodInfoPtr_buildClaimConfig_Private_ClaimConfig_Action_1_ClaimResponse_Action_1_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663619);
			IAPStoreModel.NativeMethodInfoPtr_getAuthToken_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663620);
			IAPStoreModel.NativeMethodInfoPtr_getAuthTokenType_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663621);
			IAPStoreModel.NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663622);
			IAPStoreModel.NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_List_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663623);
			IAPStoreModel.NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663624);
			IAPStoreModel.NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663625);
			IAPStoreModel.NativeMethodInfoPtr_fulfillProduct_Protected_Virtual_New_Void_ClaimResponse_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663626);
			IAPStoreModel.NativeMethodInfoPtr_onProductFulfill_Private_Void_ClaimResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663627);
			IAPStoreModel.NativeMethodInfoPtr_onProductFulfillFailed_Protected_Virtual_New_Void_ClaimResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663628);
			IAPStoreModel.NativeMethodInfoPtr_GetProductFromArchetypeId_Public_IAPProduct_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663629);
			IAPStoreModel.NativeMethodInfoPtr_OnStoreModelException_Protected_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663630);
			IAPStoreModel.NativeMethodInfoPtr_LogError_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663631);
			IAPStoreModel.NativeMethodInfoPtr_LogError_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663632);
			IAPStoreModel.NativeMethodInfoPtr_LogWarning_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663633);
			IAPStoreModel.NativeMethodInfoPtr_Log_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663634);
			IAPStoreModel.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663635);
			IAPStoreModel.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663636);
			IAPStoreModel.NativeMethodInfoPtr_LogStatic_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663637);
			IAPStoreModel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663638);
			IAPStoreModel.NativeMethodInfoPtr__checkPendingClaims_b__74_0_Private_Void_PendingClaims_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663640);
			IAPStoreModel.NativeMethodInfoPtr__AddToUnfulfilledProducts_b__100_0_Private_IAPProduct_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, 100663641);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00008D10 File Offset: 0x00006F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201496, XrefRangeEnd = 1201509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnModelInitializedFailed(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_add_OnModelInitializedFailed_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00008D48 File Offset: 0x00006F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201509, XrefRangeEnd = 1201522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnModelInitializedFailed(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_remove_OnModelInitializedFailed_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00008D80 File Offset: 0x00006F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201522, XrefRangeEnd = 1201535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnFulfillProduct(Action<string, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_add_OnFulfillProduct_Public_Static_add_Void_Action_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008DB8 File Offset: 0x00006FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201535, XrefRangeEnd = 1201548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnFulfillProduct(Action<string, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_remove_OnFulfillProduct_Public_Static_rem_Void_Action_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201548, XrefRangeEnd = 1201561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnOwnedProductsReceived(Action<HashSet<IAPProduct>> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_add_OnOwnedProductsReceived_Public_Static_add_Void_Action_1_HashSet_1_IAPProduct_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00008E28 File Offset: 0x00007028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201561, XrefRangeEnd = 1201574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnOwnedProductsReceived(Action<HashSet<IAPProduct>> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_remove_OnOwnedProductsReceived_Public_Static_rem_Void_Action_1_HashSet_1_IAPProduct_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00008E60 File Offset: 0x00007060
		public unsafe string grayLogErrorLabel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201574, XrefRangeEnd = 1201577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_grayLogErrorLabel_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00008E98 File Offset: 0x00007098
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00008ECC File Offset: 0x000070CC
		public unsafe static dwd.core.logging.ILogger EditorLogger
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1201590, RefRangeEnd = 1201598, XrefRangeStart = 1201577, XrefRangeEnd = 1201590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_EditorLogger_Public_Static_get_ILogger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<dwd.core.logging.ILogger>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201598, XrefRangeEnd = 1201604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_set_EditorLogger_Public_Static_set_Void_ILogger_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00008F04 File Offset: 0x00007104
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00008F4C File Offset: 0x0000714C
		public unsafe virtual bool DebugLogging
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_get_DebugLogging_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_set_DebugLogging_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00008F98 File Offset: 0x00007198
		public unsafe IReadOnlyDictionary<string, IAPProduct> Catalog
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_Catalog_Public_get_IReadOnlyDictionary_2_String_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, IAPProduct>>(intPtr3) : null;
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00008FD8 File Offset: 0x000071D8
		[CallerCount(0)]
		public unsafe virtual void InitializeWithID(string applicationID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(applicationID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_InitializeWithID_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00009028 File Offset: 0x00007228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201604, XrefRangeEnd = 1201620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToCatalog(IAPProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_AddToCatalog_Public_Void_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000906C File Offset: 0x0000726C
		public unsafe bool CatalogAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_CatalogAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000090A8 File Offset: 0x000072A8
		public unsafe bool OwnedProductsReceived
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_OwnedProductsReceived_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000090E4 File Offset: 0x000072E4
		public unsafe IReadOnlyCollection<IAPProduct> OwnedProducts
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_OwnedProducts_Public_get_IReadOnlyCollection_1_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<IAPProduct>>(intPtr3) : null;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00009124 File Offset: 0x00007324
		public unsafe HashSet<IAPProduct> LicensedProducts
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_LicensedProducts_Public_get_HashSet_1_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<IAPProduct>>(intPtr3) : null;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00009164 File Offset: 0x00007364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201620, XrefRangeEnd = 1201626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AddToOwnedProducts(IAPProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_AddToOwnedProducts_Public_IEnumerator_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000091B4 File Offset: 0x000073B4
		public unsafe ReadOnlyCollection<IAPProduct> History
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201626, XrefRangeEnd = 1201630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_History_Public_get_ReadOnlyCollection_1_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<IAPProduct>>(intPtr3) : null;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000091F4 File Offset: 0x000073F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201630, XrefRangeEnd = 1201641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToHistory(IAPProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_AddToHistory_Public_Void_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00009238 File Offset: 0x00007438
		public unsafe IIAPProductProvider ProductProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_ProductProvider_Public_get_IIAPProductProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIAPProductProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00009278 File Offset: 0x00007478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201641, XrefRangeEnd = 1201647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Initialize(IIAPProductProvider productProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(productProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_Initialize_Public_IEnumerator_IIAPProductProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000092C8 File Offset: 0x000074C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201647, XrefRangeEnd = 1201683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onOwnedProductsReceived(HashSet<IAPProduct> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_onOwnedProductsReceived_Private_Void_HashSet_1_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000930C File Offset: 0x0000750C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201683, XrefRangeEnd = 1201692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void invokeInitializedFailed(string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_invokeInitializedFailed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00009350 File Offset: 0x00007550
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1201697, RefRangeEnd = 1201700, XrefRangeStart = 1201692, XrefRangeEnd = 1201697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RefreshOwnedProducts(bool forceInitialized = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forceInitialized;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_RefreshOwnedProducts_Public_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000939C File Offset: 0x0000759C
		[CallerCount(0)]
		public unsafe virtual IEnumerator preInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_preInitialize_Protected_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000093E8 File Offset: 0x000075E8
		[CallerCount(0)]
		public unsafe virtual IEnumerator populateCatalog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_populateCatalog_Protected_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00009434 File Offset: 0x00007634
		[CallerCount(0)]
		public unsafe virtual GetProductOwnershipCommand getOwnedProductsCommand(Action<HashSet<IAPProduct>> onOwnedProducts, Action<string> onFailed)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_getOwnedProductsCommand_Protected_Abstract_Virtual_New_GetProductOwnershipCommand_Action_1_HashSet_1_IAPProduct_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetProductOwnershipCommand>(intPtr3) : null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000094A4 File Offset: 0x000076A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201700, XrefRangeEnd = 1201704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator populateHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_populateHistory_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000094F0 File Offset: 0x000076F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201704, XrefRangeEnd = 1201708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator postInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_postInitialize_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000953C File Offset: 0x0000773C
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00009578 File Offset: 0x00007778
		public unsafe bool PurchaseInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_PurchaseInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_set_PurchaseInProgress_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000095B8 File Offset: 0x000077B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201708, XrefRangeEnd = 1201713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator checkPendingClaims()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_checkPendingClaims_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000095F8 File Offset: 0x000077F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1201736, RefRangeEnd = 1201737, XrefRangeStart = 1201713, XrefRangeEnd = 1201736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PurchaseIAPProductCommand GetPurchaseCommand(string productID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_GetPurchaseCommand_Public_PurchaseIAPProductCommand_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PurchaseIAPProductCommand>(intPtr3) : null;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00009648 File Offset: 0x00007848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201737, XrefRangeEnd = 1201741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAPRestorePurchasesCommand GetRestorePurchaseCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_GetRestorePurchaseCommand_Public_Virtual_New_IAPRestorePurchasesCommand_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAPRestorePurchasesCommand>(intPtr3) : null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00009694 File Offset: 0x00007894
		[CallerCount(0)]
		public unsafe virtual IEnumerator purchase(IAPProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_purchase_Protected_Abstract_Virtual_New_IEnumerator_IAPProduct_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000096F0 File Offset: 0x000078F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201741, XrefRangeEnd = 1201746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RefreshProductCatalog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_RefreshProductCatalog_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00009730 File Offset: 0x00007930
		public unsafe string StoreName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_StoreName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00009768 File Offset: 0x00007968
		public unsafe virtual bool IsStoreAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_get_IsStoreAvailable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000097B0 File Offset: 0x000079B0
		public unsafe virtual bool CanMakePayments
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_get_CanMakePayments_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000097F8 File Offset: 0x000079F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201746, XrefRangeEnd = 1201783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Uninitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_Uninitialize_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000982C File Offset: 0x00007A2C
		[CallerCount(0)]
		public unsafe virtual void uninitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_uninitialize_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00009868 File Offset: 0x00007A68
		public unsafe string PlatformToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201783, XrefRangeEnd = 1201787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_PlatformToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000098A0 File Offset: 0x00007AA0
		public unsafe string CommerceURL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201787, XrefRangeEnd = 1201794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_get_CommerceURL_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000098D8 File Offset: 0x00007AD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1201813, RefRangeEnd = 1201814, XrefRangeStart = 1201794, XrefRangeEnd = 1201813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GetSubmitClaimCommand(Action<ClaimResponse, ArchetypeID> onClaimSuccess, Action<string> onClaimFailure, ArchetypeID archetypeID, [Optional] Il2CppStringArray ids)
		{
			if (ids == null)
			{
				ids = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onClaimSuccess);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onClaimFailure);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_GetSubmitClaimCommand_Public_Command_Action_2_ClaimResponse_ArchetypeID_Action_1_String_ArchetypeID_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00009970 File Offset: 0x00007B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201814, XrefRangeEnd = 1201843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GetSubmitClaimCommand(Action<ClaimResponse, List<ArchetypeID>> onClaimSuccess, Action<string> onClaimFailure, List<ArchetypeID> archetypeIds, [Optional] Il2CppStringArray ids)
		{
			if (ids == null)
			{
				ids = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onClaimSuccess);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onClaimFailure);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypeIds);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_GetSubmitClaimCommand_Public_Command_Action_2_ClaimResponse_List_1_ArchetypeID_Action_1_String_List_1_ArchetypeID_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00009A08 File Offset: 0x00007C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201843, XrefRangeEnd = 1201848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GetSubmitClaimCommand(Action<ClaimResponse> onClaimSuccess, Action<string> onClaimFailure, [Optional] Il2CppStringArray ids)
		{
			if (ids == null)
			{
				ids = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onClaimSuccess);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onClaimFailure);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_GetSubmitClaimCommand_Public_Command_Action_1_ClaimResponse_Action_1_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00009A8C File Offset: 0x00007C8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1201871, RefRangeEnd = 1201874, XrefRangeStart = 1201848, XrefRangeEnd = 1201871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimConfig buildClaimConfig(Action<ClaimResponse> onClaimSuccess, Action<string> onClaimFailure, [Optional] Il2CppStringArray ids)
		{
			if (ids == null)
			{
				ids = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onClaimSuccess);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onClaimFailure);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_buildClaimConfig_Private_ClaimConfig_Action_1_ClaimResponse_Action_1_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimConfig>(intPtr3) : null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00009B10 File Offset: 0x00007D10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1201908, RefRangeEnd = 1201909, XrefRangeStart = 1201874, XrefRangeEnd = 1201908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getAuthToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_getAuthToken_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00009B48 File Offset: 0x00007D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1201925, RefRangeEnd = 1201926, XrefRangeStart = 1201909, XrefRangeEnd = 1201925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getAuthTokenType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_getAuthTokenType_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00009B80 File Offset: 0x00007D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1201940, RefRangeEnd = 1201941, XrefRangeStart = 1201926, XrefRangeEnd = 1201940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToUnfulfilledProducts(string claimId, IAPProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(claimId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00009BD4 File Offset: 0x00007DD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1202024, RefRangeEnd = 1202028, XrefRangeStart = 1201941, XrefRangeEnd = 1202024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToUnfulfilledProducts(string claimId, List<IAPProduct> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(claimId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_List_1_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00009C28 File Offset: 0x00007E28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1202041, RefRangeEnd = 1202043, XrefRangeStart = 1202028, XrefRangeEnd = 1202041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToUnfulfilledProducts(string claimId, List<ArchetypeID> archetypeIds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(claimId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypeIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_List_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00009C7C File Offset: 0x00007E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202043, XrefRangeEnd = 1202070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToUnfulfilledProducts(string claimId, ArchetypeID archID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(claimId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00009CD0 File Offset: 0x00007ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202070, XrefRangeEnd = 1202093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void fulfillProduct(ClaimResponse response, IAPProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_fulfillProduct_Protected_Virtual_New_Void_ClaimResponse_IAPProduct_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00009D30 File Offset: 0x00007F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202093, XrefRangeEnd = 1202130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onProductFulfill(ClaimResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_onProductFulfill_Private_Void_ClaimResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00009D74 File Offset: 0x00007F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202130, XrefRangeEnd = 1202173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onProductFulfillFailed(ClaimResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreModel.NativeMethodInfoPtr_onProductFulfillFailed_Protected_Virtual_New_Void_ClaimResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00009DC4 File Offset: 0x00007FC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1202190, RefRangeEnd = 1202193, XrefRangeStart = 1202173, XrefRangeEnd = 1202190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPProduct GetProductFromArchetypeId(ArchetypeID archetypeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_GetProductFromArchetypeId_Public_IAPProduct_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr3) : null;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00009E14 File Offset: 0x00008014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202193, XrefRangeEnd = 1202197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStoreModelException(Exception ex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_OnStoreModelException_Protected_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00009E58 File Offset: 0x00008058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1202208, RefRangeEnd = 1202210, XrefRangeStart = 1202197, XrefRangeEnd = 1202208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogError(string e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_LogError_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00009E9C File Offset: 0x0000809C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202210, XrefRangeEnd = 1202217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogError(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_LogError_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00009EE0 File Offset: 0x000080E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202217, XrefRangeEnd = 1202224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogWarning(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_LogWarning_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00009F24 File Offset: 0x00008124
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1202231, RefRangeEnd = 1202252, XrefRangeStart = 1202224, XrefRangeEnd = 1202231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Log(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_Log_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00009F68 File Offset: 0x00008168
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1202259, RefRangeEnd = 1202262, XrefRangeStart = 1202252, XrefRangeEnd = 1202259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Log(LogType logType, string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00009FB8 File Offset: 0x000081B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202262, XrefRangeEnd = 1202269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Log(LogType logType, string msg, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000A028 File Offset: 0x00008228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202269, XrefRangeEnd = 1202277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogStatic(string msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr_LogStatic_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000A060 File Offset: 0x00008260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1202315, RefRangeEnd = 1202316, XrefRangeStart = 1202277, XrefRangeEnd = 1202315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPStoreModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000A09C File Offset: 0x0000829C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _checkPendingClaims_b__74_0(PendingClaims c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr__checkPendingClaims_b__74_0_Private_Void_PendingClaims_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202316, XrefRangeEnd = 1202334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPProduct _AddToUnfulfilledProducts_b__100_0(ArchetypeID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.NativeMethodInfoPtr__AddToUnfulfilledProducts_b__100_0_Private_IAPProduct_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr3) : null;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000027ED File Offset: 0x000009ED
		public Command GetSubmitClaimCommand(Action<ClaimResponse, ArchetypeID> onClaimSuccess, Action<string> onClaimFailure, ArchetypeID archetypeID, params string[] ids)
		{
			return this.GetSubmitClaimCommand(onClaimSuccess, onClaimFailure, archetypeID, new Il2CppStringArray(ids));
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000027FF File Offset: 0x000009FF
		public Command GetSubmitClaimCommand(Action<ClaimResponse, List<ArchetypeID>> onClaimSuccess, Action<string> onClaimFailure, List<ArchetypeID> archetypeIds, params string[] ids)
		{
			return this.GetSubmitClaimCommand(onClaimSuccess, onClaimFailure, archetypeIds, new Il2CppStringArray(ids));
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002811 File Offset: 0x00000A11
		public Command GetSubmitClaimCommand(Action<ClaimResponse> onClaimSuccess, Action<string> onClaimFailure, params string[] ids)
		{
			return this.GetSubmitClaimCommand(onClaimSuccess, onClaimFailure, new Il2CppStringArray(ids));
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002821 File Offset: 0x00000A21
		public ClaimConfig buildClaimConfig(Action<ClaimResponse> onClaimSuccess, Action<string> onClaimFailure, params string[] ids)
		{
			return this.buildClaimConfig(onClaimSuccess, onClaimFailure, new Il2CppStringArray(ids));
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002831 File Offset: 0x00000A31
		public virtual void Log(LogType logType, string msg, params global::Il2CppSystem.Object[] args)
		{
			this.Log(logType, msg, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002841 File Offset: 0x00000A41
		public IAPStoreModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000A130 File Offset: 0x00008330
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0000284A File Offset: 0x00000A4A
		public unsafe static Action<string> OnModelInitializedFailed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_OnModelInitializedFailed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_OnModelInitializedFailed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000A158 File Offset: 0x00008358
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000285C File Offset: 0x00000A5C
		public unsafe static Action<string, string> OnFulfillProduct
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_OnFulfillProduct, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_OnFulfillProduct, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000A180 File Offset: 0x00008380
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000286E File Offset: 0x00000A6E
		public unsafe static Action<HashSet<IAPProduct>> OnOwnedProductsReceived
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_OnOwnedProductsReceived, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HashSet<IAPProduct>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_OnOwnedProductsReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000A1A8 File Offset: 0x000083A8
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002880 File Offset: 0x00000A80
		public unsafe static string FAKESTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_FAKESTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_FAKESTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000A1C8 File Offset: 0x000083C8
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002892 File Offset: 0x00000A92
		public unsafe static string STUBSTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_STUBSTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_STUBSTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000A1E8 File Offset: 0x000083E8
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000028A4 File Offset: 0x00000AA4
		public unsafe static string APPLESTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_APPLESTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_APPLESTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000A208 File Offset: 0x00008408
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000028B6 File Offset: 0x00000AB6
		public unsafe static string MACSTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_MACSTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_MACSTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000A228 File Offset: 0x00008428
		// (set) Token: 0x06000194 RID: 404 RVA: 0x000028C8 File Offset: 0x00000AC8
		public unsafe static string GOOGLEPLAYSTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_GOOGLEPLAYSTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_GOOGLEPLAYSTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000A248 File Offset: 0x00008448
		// (set) Token: 0x06000196 RID: 406 RVA: 0x000028DA File Offset: 0x00000ADA
		public unsafe static string AMAZONSTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_AMAZONSTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_AMAZONSTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000A268 File Offset: 0x00008468
		// (set) Token: 0x06000198 RID: 408 RVA: 0x000028EC File Offset: 0x00000AEC
		public unsafe static string WINDOWSSTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_WINDOWSSTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_WINDOWSSTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000A288 File Offset: 0x00008488
		// (set) Token: 0x0600019A RID: 410 RVA: 0x000028FE File Offset: 0x00000AFE
		public unsafe static string XBOXSTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_XBOXSTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_XBOXSTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000A2A8 File Offset: 0x000084A8
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002910 File Offset: 0x00000B10
		public unsafe static string PLAYSTATIONSTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_PLAYSTATIONSTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_PLAYSTATIONSTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000A2C8 File Offset: 0x000084C8
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002922 File Offset: 0x00000B22
		public unsafe static string STEAMSTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_STEAMSTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_STEAMSTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000A2E8 File Offset: 0x000084E8
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002934 File Offset: 0x00000B34
		public unsafe static string DIRECTSTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_DIRECTSTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_DIRECTSTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000A308 File Offset: 0x00008508
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002946 File Offset: 0x00000B46
		public unsafe static string NINTENDOSTORENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_NINTENDOSTORENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_NINTENDOSTORENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000A328 File Offset: 0x00008528
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002958 File Offset: 0x00000B58
		public unsafe static string PLATFORM_TOKEN_TYPE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_PLATFORM_TOKEN_TYPE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_PLATFORM_TOKEN_TYPE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000A348 File Offset: 0x00008548
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000296A File Offset: 0x00000B6A
		public unsafe static string ANON_TOKEN_TYPE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_ANON_TOKEN_TYPE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_ANON_TOKEN_TYPE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000A368 File Offset: 0x00008568
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000297C File Offset: 0x00000B7C
		public unsafe static dwd.core.logging.ILogger editorLogger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.NativeFieldInfoPtr_editorLogger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<dwd.core.logging.ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.NativeFieldInfoPtr_editorLogger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000A390 File Offset: 0x00008590
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000298E File Offset: 0x00000B8E
		public unsafe bool _DebugLogging_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr__DebugLogging_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr__DebugLogging_k__BackingField)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000A3B8 File Offset: 0x000085B8
		// (set) Token: 0x060001AC RID: 428 RVA: 0x000029A9 File Offset: 0x00000BA9
		public unsafe Dictionary<string, IAPProduct> catalog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_catalog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IAPProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_catalog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000A3E8 File Offset: 0x000085E8
		// (set) Token: 0x060001AE RID: 430 RVA: 0x000029C8 File Offset: 0x00000BC8
		public unsafe bool catalogAvailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_catalogAvailable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_catalogAvailable)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000A410 File Offset: 0x00008610
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x000029E3 File Offset: 0x00000BE3
		public unsafe bool ownedProductsReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_ownedProductsReceived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_ownedProductsReceived)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000A438 File Offset: 0x00008638
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000029FE File Offset: 0x00000BFE
		public unsafe HashSet<IAPProduct> ownedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_ownedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IAPProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_ownedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000A468 File Offset: 0x00008668
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002A1D File Offset: 0x00000C1D
		public unsafe HashSet<IAPProduct> licensedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_licensedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IAPProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_licensedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000A498 File Offset: 0x00008698
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002A3C File Offset: 0x00000C3C
		public unsafe Dictionary<string, List<IAPProduct>> unfulfilledProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_unfulfilledProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<IAPProduct>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_unfulfilledProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000A4C8 File Offset: 0x000086C8
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002A5B File Offset: 0x00000C5B
		public unsafe PendingClaims pendingClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_pendingClaims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingClaims>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_pendingClaims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000A4F8 File Offset: 0x000086F8
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002A7A File Offset: 0x00000C7A
		public unsafe List<IAPProduct> history
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_history);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAPProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_history), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000A528 File Offset: 0x00008728
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002A99 File Offset: 0x00000C99
		public unsafe GameObject inputShield
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_inputShield);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_inputShield), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000A558 File Offset: 0x00008758
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002AB8 File Offset: 0x00000CB8
		public unsafe IIAPProductProvider productProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_productProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IIAPProductProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_productProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000A588 File Offset: 0x00008788
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002AD7 File Offset: 0x00000CD7
		public unsafe bool purchaseInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_purchaseInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_purchaseInProgress)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000A5B0 File Offset: 0x000087B0
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002AF2 File Offset: 0x00000CF2
		public unsafe string storeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_storeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.NativeFieldInfoPtr_storeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_OnModelInitializedFailed;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_OnFulfillProduct;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_OnOwnedProductsReceived;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr_FAKESTORENAME;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_STUBSTORENAME;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_APPLESTORENAME;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_MACSTORENAME;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_GOOGLEPLAYSTORENAME;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_AMAZONSTORENAME;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_WINDOWSSTORENAME;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_XBOXSTORENAME;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_PLAYSTATIONSTORENAME;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_STEAMSTORENAME;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_DIRECTSTORENAME;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_NINTENDOSTORENAME;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_PLATFORM_TOKEN_TYPE;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_ANON_TOKEN_TYPE;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_editorLogger;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr__DebugLogging_k__BackingField;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_catalog;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_catalogAvailable;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_ownedProductsReceived;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_ownedProducts;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_licensedProducts;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_unfulfilledProducts;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_pendingClaims;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_history;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_inputShield;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_productProvider;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_purchaseInProgress;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_storeName;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_add_OnModelInitializedFailed_Public_Static_add_Void_Action_1_String_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnModelInitializedFailed_Public_Static_rem_Void_Action_1_String_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_add_OnFulfillProduct_Public_Static_add_Void_Action_2_String_String_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnFulfillProduct_Public_Static_rem_Void_Action_2_String_String_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_add_OnOwnedProductsReceived_Public_Static_add_Void_Action_1_HashSet_1_IAPProduct_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnOwnedProductsReceived_Public_Static_rem_Void_Action_1_HashSet_1_IAPProduct_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_get_grayLogErrorLabel_Private_get_String_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_get_EditorLogger_Public_Static_get_ILogger_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_set_EditorLogger_Public_Static_set_Void_ILogger_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugLogging_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_set_DebugLogging_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_Catalog_Public_get_IReadOnlyDictionary_2_String_IAPProduct_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_InitializeWithID_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_AddToCatalog_Public_Void_IAPProduct_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_CatalogAvailable_Public_get_Boolean_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnedProductsReceived_Public_get_Boolean_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnedProducts_Public_get_IReadOnlyCollection_1_IAPProduct_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_LicensedProducts_Public_get_HashSet_1_IAPProduct_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_AddToOwnedProducts_Public_IEnumerator_IAPProduct_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_get_History_Public_get_ReadOnlyCollection_1_IAPProduct_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_AddToHistory_Public_Void_IAPProduct_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_get_ProductProvider_Public_get_IIAPProductProvider_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_IEnumerator_IIAPProductProvider_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_onOwnedProductsReceived_Private_Void_HashSet_1_IAPProduct_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_invokeInitializedFailed_Private_Void_String_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_RefreshOwnedProducts_Public_IEnumerator_Boolean_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_preInitialize_Protected_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_populateCatalog_Protected_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_getOwnedProductsCommand_Protected_Abstract_Virtual_New_GetProductOwnershipCommand_Action_1_HashSet_1_IAPProduct_Action_1_String_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_populateHistory_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_postInitialize_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_PurchaseInProgress_Public_get_Boolean_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_set_PurchaseInProgress_Internal_set_Void_Boolean_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_checkPendingClaims_Private_IEnumerator_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_GetPurchaseCommand_Public_PurchaseIAPProductCommand_String_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_GetRestorePurchaseCommand_Public_Virtual_New_IAPRestorePurchasesCommand_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_purchase_Protected_Abstract_Virtual_New_IEnumerator_IAPProduct_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_RefreshProductCatalog_Public_IEnumerator_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_get_StoreName_Public_get_String_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStoreAvailable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_get_CanMakePayments_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_Uninitialize_Internal_Void_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_uninitialize_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformToken_Public_get_String_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_get_CommerceURL_Public_get_String_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_GetSubmitClaimCommand_Public_Command_Action_2_ClaimResponse_ArchetypeID_Action_1_String_ArchetypeID_Il2CppStringArray_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_GetSubmitClaimCommand_Public_Command_Action_2_ClaimResponse_List_1_ArchetypeID_Action_1_String_List_1_ArchetypeID_Il2CppStringArray_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_GetSubmitClaimCommand_Public_Command_Action_1_ClaimResponse_Action_1_String_Il2CppStringArray_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_buildClaimConfig_Private_ClaimConfig_Action_1_ClaimResponse_Action_1_String_Il2CppStringArray_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_getAuthToken_Private_String_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_getAuthTokenType_Private_String_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_IAPProduct_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_List_1_IAPProduct_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_List_1_ArchetypeID_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_AddToUnfulfilledProducts_Public_Void_String_ArchetypeID_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_fulfillProduct_Protected_Virtual_New_Void_ClaimResponse_IAPProduct_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_onProductFulfill_Private_Void_ClaimResponse_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_onProductFulfillFailed_Protected_Virtual_New_Void_ClaimResponse_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_GetProductFromArchetypeId_Public_IAPProduct_ArchetypeID_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_OnStoreModelException_Protected_Void_Exception_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Void_String_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Void_Exception_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Void_String_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Void_String_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_String_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_LogStatic_Public_Static_Void_String_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr__checkPendingClaims_b__74_0_Private_Void_PendingClaims_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr__AddToUnfulfilledProducts_b__100_0_Private_IAPProduct_ArchetypeID_0;

		// Token: 0x02000043 RID: 67
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000392 RID: 914 RVA: 0x0000FF04 File Offset: 0x0000E104
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr);
				IAPStoreModel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, "<>9");
				IAPStoreModel.__c.NativeFieldInfoPtr___9__61_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, "<>9__61_0");
				IAPStoreModel.__c.NativeFieldInfoPtr___9__78_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, "<>9__78_0");
				IAPStoreModel.__c.NativeFieldInfoPtr___9__99_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, "<>9__99_0");
				IAPStoreModel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, 100663643);
				IAPStoreModel.__c.NativeMethodInfoPtr__Initialize_b__61_0_Internal_String_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, 100663644);
				IAPStoreModel.__c.NativeMethodInfoPtr__RefreshProductCatalog_b__78_0_Internal_String_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, 100663645);
				IAPStoreModel.__c.NativeMethodInfoPtr__AddToUnfulfilledProducts_b__99_0_Internal_ArchetypeID_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, 100663646);
				IAPStoreModel.__c.NativeMethodInfoPtr___cctor_b__115_0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, 100663647);
				IAPStoreModel.__c.NativeMethodInfoPtr___cctor_b__115_1_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, 100663648);
				IAPStoreModel.__c.NativeMethodInfoPtr___cctor_b__115_2_Internal_Void_HashSet_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr, 100663649);
			}

			// Token: 0x06000393 RID: 915 RVA: 0x0001000C File Offset: 0x0000E20C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000394 RID: 916 RVA: 0x00010048 File Offset: 0x0000E248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Initialize_b__61_0(IAPProduct p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c.NativeMethodInfoPtr__Initialize_b__61_0_Internal_String_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000395 RID: 917 RVA: 0x00010090 File Offset: 0x0000E290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _RefreshProductCatalog_b__78_0(IAPProduct p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c.NativeMethodInfoPtr__RefreshProductCatalog_b__78_0_Internal_String_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000396 RID: 918 RVA: 0x000100D8 File Offset: 0x0000E2D8
			[CallerCount(0)]
			public unsafe ArchetypeID _AddToUnfulfilledProducts_b__99_0(IAPProduct p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c.NativeMethodInfoPtr__AddToUnfulfilledProducts_b__99_0_Internal_ArchetypeID_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06000397 RID: 919 RVA: 0x00010128 File Offset: 0x0000E328
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__115_0(string <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c.NativeMethodInfoPtr___cctor_b__115_0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000398 RID: 920 RVA: 0x0001016C File Offset: 0x0000E36C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__115_1(string <p0>, string <p1>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(<p1>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c.NativeMethodInfoPtr___cctor_b__115_1_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000399 RID: 921 RVA: 0x000101C0 File Offset: 0x0000E3C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__115_2(HashSet<IAPProduct> <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c.NativeMethodInfoPtr___cctor_b__115_2_Internal_Void_HashSet_1_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600039A RID: 922 RVA: 0x00003939 File Offset: 0x00001B39
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x0600039B RID: 923 RVA: 0x00010204 File Offset: 0x0000E404
			// (set) Token: 0x0600039C RID: 924 RVA: 0x00003942 File Offset: 0x00001B42
			public unsafe static IAPStoreModel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x0600039D RID: 925 RVA: 0x0001022C File Offset: 0x0000E42C
			// (set) Token: 0x0600039E RID: 926 RVA: 0x00003954 File Offset: 0x00001B54
			public unsafe static Func<IAPProduct, string> __9__61_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.__c.NativeFieldInfoPtr___9__61_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAPProduct, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.__c.NativeFieldInfoPtr___9__61_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x0600039F RID: 927 RVA: 0x00010254 File Offset: 0x0000E454
			// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003966 File Offset: 0x00001B66
			public unsafe static Func<IAPProduct, string> __9__78_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.__c.NativeFieldInfoPtr___9__78_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAPProduct, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.__c.NativeFieldInfoPtr___9__78_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x060003A1 RID: 929 RVA: 0x0001027C File Offset: 0x0000E47C
			// (set) Token: 0x060003A2 RID: 930 RVA: 0x00003978 File Offset: 0x00001B78
			public unsafe static Func<IAPProduct, ArchetypeID> __9__99_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IAPStoreModel.__c.NativeFieldInfoPtr___9__99_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAPProduct, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IAPStoreModel.__c.NativeFieldInfoPtr___9__99_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000263 RID: 611
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000264 RID: 612
			private static readonly IntPtr NativeFieldInfoPtr___9__61_0;

			// Token: 0x04000265 RID: 613
			private static readonly IntPtr NativeFieldInfoPtr___9__78_0;

			// Token: 0x04000266 RID: 614
			private static readonly IntPtr NativeFieldInfoPtr___9__99_0;

			// Token: 0x04000267 RID: 615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000268 RID: 616
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__61_0_Internal_String_IAPProduct_0;

			// Token: 0x04000269 RID: 617
			private static readonly IntPtr NativeMethodInfoPtr__RefreshProductCatalog_b__78_0_Internal_String_IAPProduct_0;

			// Token: 0x0400026A RID: 618
			private static readonly IntPtr NativeMethodInfoPtr__AddToUnfulfilledProducts_b__99_0_Internal_ArchetypeID_IAPProduct_0;

			// Token: 0x0400026B RID: 619
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__115_0_Internal_Void_String_0;

			// Token: 0x0400026C RID: 620
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__115_1_Internal_Void_String_String_0;

			// Token: 0x0400026D RID: 621
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__115_2_Internal_Void_HashSet_1_IAPProduct_0;
		}

		// Token: 0x02000044 RID: 68
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<>c__DisplayClass100_0")]
		public sealed class __c__DisplayClass100_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060003A3 RID: 931 RVA: 0x000102A4 File Offset: 0x0000E4A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass100_0()
			{
				Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass100_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<>c__DisplayClass100_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass100_0>.NativeClassPtr);
				IAPStoreModel.__c__DisplayClass100_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass100_0>.NativeClassPtr, "id");
				IAPStoreModel.__c__DisplayClass100_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass100_0>.NativeClassPtr, 100663650);
				IAPStoreModel.__c__DisplayClass100_0.NativeMethodInfoPtr__AddToUnfulfilledProducts_b__1_Internal_Boolean_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass100_0>.NativeClassPtr, 100663651);
			}

			// Token: 0x060003A4 RID: 932 RVA: 0x0001030C File Offset: 0x0000E50C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass100_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass100_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass100_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003A5 RID: 933 RVA: 0x00010348 File Offset: 0x0000E548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201235, XrefRangeEnd = 1201240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddToUnfulfilledProducts_b__1(IAPProduct p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass100_0.NativeMethodInfoPtr__AddToUnfulfilledProducts_b__1_Internal_Boolean_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003A6 RID: 934 RVA: 0x0000398A File Offset: 0x00001B8A
			public __c__DisplayClass100_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060003A7 RID: 935 RVA: 0x00010398 File Offset: 0x0000E598
			// (set) Token: 0x060003A8 RID: 936 RVA: 0x00003993 File Offset: 0x00001B93
			public unsafe ArchetypeID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass100_0.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass100_0.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400026E RID: 622
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400026F RID: 623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000270 RID: 624
			private static readonly IntPtr NativeMethodInfoPtr__AddToUnfulfilledProducts_b__1_Internal_Boolean_IAPProduct_0;
		}

		// Token: 0x02000045 RID: 69
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<>c__DisplayClass101_0")]
		public sealed class __c__DisplayClass101_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060003A9 RID: 937 RVA: 0x000103C8 File Offset: 0x0000E5C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass101_0()
			{
				Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass101_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<>c__DisplayClass101_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass101_0>.NativeClassPtr);
				IAPStoreModel.__c__DisplayClass101_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass101_0>.NativeClassPtr, "archID");
				IAPStoreModel.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass101_0>.NativeClassPtr, 100663652);
				IAPStoreModel.__c__DisplayClass101_0.NativeMethodInfoPtr__AddToUnfulfilledProducts_b__0_Internal_Boolean_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass101_0>.NativeClassPtr, 100663653);
			}

			// Token: 0x060003AA RID: 938 RVA: 0x00010430 File Offset: 0x0000E630
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass101_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass101_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003AB RID: 939 RVA: 0x0001046C File Offset: 0x0000E66C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201240, XrefRangeEnd = 1201245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddToUnfulfilledProducts_b__0(IAPProduct p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass101_0.NativeMethodInfoPtr__AddToUnfulfilledProducts_b__0_Internal_Boolean_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003AC RID: 940 RVA: 0x000039B2 File Offset: 0x00001BB2
			public __c__DisplayClass101_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060003AD RID: 941 RVA: 0x000104BC File Offset: 0x0000E6BC
			// (set) Token: 0x060003AE RID: 942 RVA: 0x000039BB File Offset: 0x00001BBB
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass101_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass101_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000271 RID: 625
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04000272 RID: 626
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000273 RID: 627
			private static readonly IntPtr NativeMethodInfoPtr__AddToUnfulfilledProducts_b__0_Internal_Boolean_IAPProduct_0;
		}

		// Token: 0x02000046 RID: 70
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<>c__DisplayClass105_0")]
		public sealed class __c__DisplayClass105_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060003AF RID: 943 RVA: 0x000104EC File Offset: 0x0000E6EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass105_0()
			{
				Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass105_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<>c__DisplayClass105_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass105_0>.NativeClassPtr);
				IAPStoreModel.__c__DisplayClass105_0.NativeFieldInfoPtr_archetypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass105_0>.NativeClassPtr, "archetypeId");
				IAPStoreModel.__c__DisplayClass105_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass105_0>.NativeClassPtr, 100663654);
				IAPStoreModel.__c__DisplayClass105_0.NativeMethodInfoPtr__GetProductFromArchetypeId_b__0_Internal_Boolean_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass105_0>.NativeClassPtr, 100663655);
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x00010554 File Offset: 0x0000E754
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass105_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass105_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass105_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x00010590 File Offset: 0x0000E790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201245, XrefRangeEnd = 1201250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProductFromArchetypeId_b__0(IAPProduct p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass105_0.NativeMethodInfoPtr__GetProductFromArchetypeId_b__0_Internal_Boolean_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x000039DA File Offset: 0x00001BDA
			public __c__DisplayClass105_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x000105E0 File Offset: 0x0000E7E0
			// (set) Token: 0x060003B4 RID: 948 RVA: 0x000039E3 File Offset: 0x00001BE3
			public unsafe ArchetypeID archetypeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass105_0.NativeFieldInfoPtr_archetypeId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass105_0.NativeFieldInfoPtr_archetypeId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000274 RID: 628
			private static readonly IntPtr NativeFieldInfoPtr_archetypeId;

			// Token: 0x04000275 RID: 629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000276 RID: 630
			private static readonly IntPtr NativeMethodInfoPtr__GetProductFromArchetypeId_b__0_Internal_Boolean_IAPProduct_0;
		}

		// Token: 0x02000047 RID: 71
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<>c__DisplayClass92_0")]
		public sealed class __c__DisplayClass92_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060003B5 RID: 949 RVA: 0x00010610 File Offset: 0x0000E810
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass92_0()
			{
				Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass92_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<>c__DisplayClass92_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass92_0>.NativeClassPtr);
				IAPStoreModel.__c__DisplayClass92_0.NativeFieldInfoPtr_onClaimSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass92_0>.NativeClassPtr, "onClaimSuccess");
				IAPStoreModel.__c__DisplayClass92_0.NativeFieldInfoPtr_archetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass92_0>.NativeClassPtr, "archetypeID");
				IAPStoreModel.__c__DisplayClass92_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass92_0>.NativeClassPtr, 100663656);
				IAPStoreModel.__c__DisplayClass92_0.NativeMethodInfoPtr__GetSubmitClaimCommand_b__0_Internal_Void_ClaimResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass92_0>.NativeClassPtr, 100663657);
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x0001068C File Offset: 0x0000E88C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass92_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass92_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass92_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x000106C8 File Offset: 0x0000E8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201250, XrefRangeEnd = 1201251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetSubmitClaimCommand_b__0(ClaimResponse response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass92_0.NativeMethodInfoPtr__GetSubmitClaimCommand_b__0_Internal_Void_ClaimResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x00003A02 File Offset: 0x00001C02
			public __c__DisplayClass92_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x0001070C File Offset: 0x0000E90C
			// (set) Token: 0x060003BA RID: 954 RVA: 0x00003A0B File Offset: 0x00001C0B
			public unsafe Action<ClaimResponse, ArchetypeID> onClaimSuccess
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass92_0.NativeFieldInfoPtr_onClaimSuccess);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClaimResponse, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass92_0.NativeFieldInfoPtr_onClaimSuccess), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060003BB RID: 955 RVA: 0x0001073C File Offset: 0x0000E93C
			// (set) Token: 0x060003BC RID: 956 RVA: 0x00003A2A File Offset: 0x00001C2A
			public unsafe ArchetypeID archetypeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass92_0.NativeFieldInfoPtr_archetypeID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass92_0.NativeFieldInfoPtr_archetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000277 RID: 631
			private static readonly IntPtr NativeFieldInfoPtr_onClaimSuccess;

			// Token: 0x04000278 RID: 632
			private static readonly IntPtr NativeFieldInfoPtr_archetypeID;

			// Token: 0x04000279 RID: 633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400027A RID: 634
			private static readonly IntPtr NativeMethodInfoPtr__GetSubmitClaimCommand_b__0_Internal_Void_ClaimResponse_0;
		}

		// Token: 0x02000048 RID: 72
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<>c__DisplayClass93_0")]
		public sealed class __c__DisplayClass93_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060003BD RID: 957 RVA: 0x0001076C File Offset: 0x0000E96C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass93_0()
			{
				Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass93_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<>c__DisplayClass93_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass93_0>.NativeClassPtr);
				IAPStoreModel.__c__DisplayClass93_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass93_0>.NativeClassPtr, "<>4__this");
				IAPStoreModel.__c__DisplayClass93_0.NativeFieldInfoPtr_onClaimSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass93_0>.NativeClassPtr, "onClaimSuccess");
				IAPStoreModel.__c__DisplayClass93_0.NativeFieldInfoPtr_archetypeIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass93_0>.NativeClassPtr, "archetypeIds");
				IAPStoreModel.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass93_0>.NativeClassPtr, 100663658);
				IAPStoreModel.__c__DisplayClass93_0.NativeMethodInfoPtr__GetSubmitClaimCommand_b__0_Internal_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass93_0>.NativeClassPtr, 100663659);
				IAPStoreModel.__c__DisplayClass93_0.NativeMethodInfoPtr__GetSubmitClaimCommand_b__1_Internal_Void_ClaimResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass93_0>.NativeClassPtr, 100663660);
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00010810 File Offset: 0x0000EA10
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass93_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel.__c__DisplayClass93_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003BF RID: 959 RVA: 0x0001084C File Offset: 0x0000EA4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201251, XrefRangeEnd = 1201252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSubmitClaimCommand_b__0(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass93_0.NativeMethodInfoPtr__GetSubmitClaimCommand_b__0_Internal_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x0001089C File Offset: 0x0000EA9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201252, XrefRangeEnd = 1201288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetSubmitClaimCommand_b__1(ClaimResponse response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel.__c__DisplayClass93_0.NativeMethodInfoPtr__GetSubmitClaimCommand_b__1_Internal_Void_ClaimResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x00003A49 File Offset: 0x00001C49
			public __c__DisplayClass93_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x000108E0 File Offset: 0x0000EAE0
			// (set) Token: 0x060003C3 RID: 963 RVA: 0x00003A52 File Offset: 0x00001C52
			public unsafe IAPStoreModel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass93_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass93_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x060003C4 RID: 964 RVA: 0x00010910 File Offset: 0x0000EB10
			// (set) Token: 0x060003C5 RID: 965 RVA: 0x00003A71 File Offset: 0x00001C71
			public unsafe Action<ClaimResponse, List<ArchetypeID>> onClaimSuccess
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass93_0.NativeFieldInfoPtr_onClaimSuccess);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClaimResponse, List<ArchetypeID>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass93_0.NativeFieldInfoPtr_onClaimSuccess), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x060003C6 RID: 966 RVA: 0x00010940 File Offset: 0x0000EB40
			// (set) Token: 0x060003C7 RID: 967 RVA: 0x00003A90 File Offset: 0x00001C90
			public unsafe List<ArchetypeID> archetypeIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass93_0.NativeFieldInfoPtr_archetypeIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel.__c__DisplayClass93_0.NativeFieldInfoPtr_archetypeIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400027B RID: 635
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400027C RID: 636
			private static readonly IntPtr NativeFieldInfoPtr_onClaimSuccess;

			// Token: 0x0400027D RID: 637
			private static readonly IntPtr NativeFieldInfoPtr_archetypeIds;

			// Token: 0x0400027E RID: 638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400027F RID: 639
			private static readonly IntPtr NativeMethodInfoPtr__GetSubmitClaimCommand_b__0_Internal_Boolean_ArchetypeID_0;

			// Token: 0x04000280 RID: 640
			private static readonly IntPtr NativeMethodInfoPtr__GetSubmitClaimCommand_b__1_Internal_Void_ClaimResponse_0;
		}

		// Token: 0x02000049 RID: 73
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<AddToOwnedProducts>d__52")]
		public sealed class _AddToOwnedProducts_d__52 : global::Il2CppSystem.Object
		{
			// Token: 0x060003C8 RID: 968 RVA: 0x00010970 File Offset: 0x0000EB70
			// Note: this type is marked as 'beforefieldinit'.
			static _AddToOwnedProducts_d__52()
			{
				Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<AddToOwnedProducts>d__52");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr);
				IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr, "<>1__state");
				IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr, "<>2__current");
				IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr, "product");
				IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr, "<>4__this");
				IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr, 100663661);
				IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr, 100663662);
				IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr, 100663663);
				IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr, 100663664);
				IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr, 100663665);
				IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr, 100663666);
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x00010A64 File Offset: 0x0000EC64
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AddToOwnedProducts_d__52(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel._AddToOwnedProducts_d__52>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003CA RID: 970 RVA: 0x00010AAC File Offset: 0x0000ECAC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003CB RID: 971 RVA: 0x00010AE0 File Offset: 0x0000ECE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201288, XrefRangeEnd = 1201312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x060003CC RID: 972 RVA: 0x00010B1C File Offset: 0x0000ED1C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003CD RID: 973 RVA: 0x00010B5C File Offset: 0x0000ED5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201312, XrefRangeEnd = 1201317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x060003CE RID: 974 RVA: 0x00010B90 File Offset: 0x0000ED90
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._AddToOwnedProducts_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00003AAF File Offset: 0x00001CAF
			public _AddToOwnedProducts_d__52(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060003D0 RID: 976 RVA: 0x00010BD0 File Offset: 0x0000EDD0
			// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003AB8 File Offset: 0x00001CB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x060003D2 RID: 978 RVA: 0x00010BF8 File Offset: 0x0000EDF8
			// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003AD3 File Offset: 0x00001CD3
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x060003D4 RID: 980 RVA: 0x00010C28 File Offset: 0x0000EE28
			// (set) Token: 0x060003D5 RID: 981 RVA: 0x00003AF2 File Offset: 0x00001CF2
			public unsafe IAPProduct product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x060003D6 RID: 982 RVA: 0x00010C58 File Offset: 0x0000EE58
			// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003B11 File Offset: 0x00001D11
			public unsafe IAPStoreModel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._AddToOwnedProducts_d__52.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000281 RID: 641
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000282 RID: 642
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000283 RID: 643
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04000284 RID: 644
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000285 RID: 645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000286 RID: 646
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000287 RID: 647
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000288 RID: 648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000289 RID: 649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400028A RID: 650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200004A RID: 74
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<Initialize>d__61")]
		public sealed class _Initialize_d__61 : global::Il2CppSystem.Object
		{
			// Token: 0x060003D8 RID: 984 RVA: 0x00010C88 File Offset: 0x0000EE88
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__61()
			{
				Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<Initialize>d__61");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr);
				IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr, "<>1__state");
				IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr, "<>2__current");
				IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr, "<>4__this");
				IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr_productProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr, "productProvider");
				IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr, 100663667);
				IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr, 100663668);
				IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr, 100663669);
				IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr, 100663670);
				IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr, 100663671);
				IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr, 100663672);
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x00010D7C File Offset: 0x0000EF7C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Initialize_d__61(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel._Initialize_d__61>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00010DC4 File Offset: 0x0000EFC4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003DB RID: 987 RVA: 0x00010DF8 File Offset: 0x0000EFF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201317, XrefRangeEnd = 1201344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060003DC RID: 988 RVA: 0x00010E34 File Offset: 0x0000F034
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003DD RID: 989 RVA: 0x00010E74 File Offset: 0x0000F074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201344, XrefRangeEnd = 1201349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060003DE RID: 990 RVA: 0x00010EA8 File Offset: 0x0000F0A8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._Initialize_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003DF RID: 991 RVA: 0x00003B30 File Offset: 0x00001D30
			public _Initialize_d__61(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x060003E0 RID: 992 RVA: 0x00010EE8 File Offset: 0x0000F0E8
			// (set) Token: 0x060003E1 RID: 993 RVA: 0x00003B39 File Offset: 0x00001D39
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x060003E2 RID: 994 RVA: 0x00010F10 File Offset: 0x0000F110
			// (set) Token: 0x060003E3 RID: 995 RVA: 0x00003B54 File Offset: 0x00001D54
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x00010F40 File Offset: 0x0000F140
			// (set) Token: 0x060003E5 RID: 997 RVA: 0x00003B73 File Offset: 0x00001D73
			public unsafe IAPStoreModel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060003E6 RID: 998 RVA: 0x00010F70 File Offset: 0x0000F170
			// (set) Token: 0x060003E7 RID: 999 RVA: 0x00003B92 File Offset: 0x00001D92
			public unsafe IIAPProductProvider productProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr_productProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IIAPProductProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._Initialize_d__61.NativeFieldInfoPtr_productProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400028B RID: 651
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400028C RID: 652
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400028D RID: 653
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400028E RID: 654
			private static readonly IntPtr NativeFieldInfoPtr_productProvider;

			// Token: 0x0400028F RID: 655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000290 RID: 656
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000291 RID: 657
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000292 RID: 658
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000293 RID: 659
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000294 RID: 660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200004B RID: 75
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<RefreshOwnedProducts>d__64")]
		public sealed class _RefreshOwnedProducts_d__64 : global::Il2CppSystem.Object
		{
			// Token: 0x060003E8 RID: 1000 RVA: 0x00010FA0 File Offset: 0x0000F1A0
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshOwnedProducts_d__64()
			{
				Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<RefreshOwnedProducts>d__64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr);
				IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr, "<>1__state");
				IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr, "<>2__current");
				IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr, "<>4__this");
				IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr_forceInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr, "forceInitialized");
				IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr, 100663673);
				IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr, 100663674);
				IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr, 100663675);
				IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr, 100663676);
				IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr, 100663677);
				IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr, 100663678);
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x00011094 File Offset: 0x0000F294
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RefreshOwnedProducts_d__64(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel._RefreshOwnedProducts_d__64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x000110DC File Offset: 0x0000F2DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x00011110 File Offset: 0x0000F310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201349, XrefRangeEnd = 1201362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x060003EC RID: 1004 RVA: 0x0001114C File Offset: 0x0000F34C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x0001118C File Offset: 0x0000F38C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201362, XrefRangeEnd = 1201367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x060003EE RID: 1006 RVA: 0x000111C0 File Offset: 0x0000F3C0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshOwnedProducts_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x00003BB1 File Offset: 0x00001DB1
			public _RefreshOwnedProducts_d__64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00011200 File Offset: 0x0000F400
			// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00003BBA File Offset: 0x00001DBA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00011228 File Offset: 0x0000F428
			// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00003BD5 File Offset: 0x00001DD5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00011258 File Offset: 0x0000F458
			// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00003BF4 File Offset: 0x00001DF4
			public unsafe IAPStoreModel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00011288 File Offset: 0x0000F488
			// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00003C13 File Offset: 0x00001E13
			public unsafe bool forceInitialized
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr_forceInitialized);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshOwnedProducts_d__64.NativeFieldInfoPtr_forceInitialized)) = value;
				}
			}

			// Token: 0x04000295 RID: 661
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000296 RID: 662
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000297 RID: 663
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000298 RID: 664
			private static readonly IntPtr NativeFieldInfoPtr_forceInitialized;

			// Token: 0x04000299 RID: 665
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400029A RID: 666
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400029B RID: 667
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400029C RID: 668
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400029D RID: 669
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400029E RID: 670
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200004C RID: 76
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<RefreshProductCatalog>d__78")]
		public sealed class _RefreshProductCatalog_d__78 : global::Il2CppSystem.Object
		{
			// Token: 0x060003F8 RID: 1016 RVA: 0x000112B0 File Offset: 0x0000F4B0
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshProductCatalog_d__78()
			{
				Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<RefreshProductCatalog>d__78");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr);
				IAPStoreModel._RefreshProductCatalog_d__78.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr, "<>1__state");
				IAPStoreModel._RefreshProductCatalog_d__78.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr, "<>2__current");
				IAPStoreModel._RefreshProductCatalog_d__78.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr, "<>4__this");
				IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr, 100663679);
				IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr, 100663680);
				IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr, 100663681);
				IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr, 100663682);
				IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr, 100663683);
				IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr, 100663684);
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x00011390 File Offset: 0x0000F590
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RefreshProductCatalog_d__78(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel._RefreshProductCatalog_d__78>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x000113D8 File Offset: 0x0000F5D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x0001140C File Offset: 0x0000F60C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201367, XrefRangeEnd = 1201405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060003FC RID: 1020 RVA: 0x00011448 File Offset: 0x0000F648
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x00011488 File Offset: 0x0000F688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201405, XrefRangeEnd = 1201410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x060003FE RID: 1022 RVA: 0x000114BC File Offset: 0x0000F6BC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._RefreshProductCatalog_d__78.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x00003C2E File Offset: 0x00001E2E
			public _RefreshProductCatalog_d__78(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x000114FC File Offset: 0x0000F6FC
			// (set) Token: 0x06000401 RID: 1025 RVA: 0x00003C37 File Offset: 0x00001E37
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshProductCatalog_d__78.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshProductCatalog_d__78.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x06000402 RID: 1026 RVA: 0x00011524 File Offset: 0x0000F724
			// (set) Token: 0x06000403 RID: 1027 RVA: 0x00003C52 File Offset: 0x00001E52
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshProductCatalog_d__78.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshProductCatalog_d__78.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x06000404 RID: 1028 RVA: 0x00011554 File Offset: 0x0000F754
			// (set) Token: 0x06000405 RID: 1029 RVA: 0x00003C71 File Offset: 0x00001E71
			public unsafe IAPStoreModel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshProductCatalog_d__78.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._RefreshProductCatalog_d__78.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400029F RID: 671
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002A0 RID: 672
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002A1 RID: 673
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002A2 RID: 674
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002A3 RID: 675
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002A4 RID: 676
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002A5 RID: 677
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002A6 RID: 678
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002A7 RID: 679
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200004D RID: 77
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<checkPendingClaims>d__74")]
		public sealed class _checkPendingClaims_d__74 : global::Il2CppSystem.Object
		{
			// Token: 0x06000406 RID: 1030 RVA: 0x00011584 File Offset: 0x0000F784
			// Note: this type is marked as 'beforefieldinit'.
			static _checkPendingClaims_d__74()
			{
				Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<checkPendingClaims>d__74");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr);
				IAPStoreModel._checkPendingClaims_d__74.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr, "<>1__state");
				IAPStoreModel._checkPendingClaims_d__74.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr, "<>2__current");
				IAPStoreModel._checkPendingClaims_d__74.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr, "<>4__this");
				IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr, 100663685);
				IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr, 100663686);
				IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr, 100663687);
				IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr, 100663688);
				IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr, 100663689);
				IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr, 100663690);
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x00011664 File Offset: 0x0000F864
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _checkPendingClaims_d__74(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel._checkPendingClaims_d__74>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x000116AC File Offset: 0x0000F8AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x000116E0 File Offset: 0x0000F8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201410, XrefRangeEnd = 1201481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x0600040A RID: 1034 RVA: 0x0001171C File Offset: 0x0000F91C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x0001175C File Offset: 0x0000F95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201481, XrefRangeEnd = 1201486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x0600040C RID: 1036 RVA: 0x00011790 File Offset: 0x0000F990
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._checkPendingClaims_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x00003C90 File Offset: 0x00001E90
			public _checkPendingClaims_d__74(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x0600040E RID: 1038 RVA: 0x000117D0 File Offset: 0x0000F9D0
			// (set) Token: 0x0600040F RID: 1039 RVA: 0x00003C99 File Offset: 0x00001E99
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._checkPendingClaims_d__74.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._checkPendingClaims_d__74.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x06000410 RID: 1040 RVA: 0x000117F8 File Offset: 0x0000F9F8
			// (set) Token: 0x06000411 RID: 1041 RVA: 0x00003CB4 File Offset: 0x00001EB4
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._checkPendingClaims_d__74.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._checkPendingClaims_d__74.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x06000412 RID: 1042 RVA: 0x00011828 File Offset: 0x0000FA28
			// (set) Token: 0x06000413 RID: 1043 RVA: 0x00003CD3 File Offset: 0x00001ED3
			public unsafe IAPStoreModel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._checkPendingClaims_d__74.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._checkPendingClaims_d__74.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002A8 RID: 680
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002A9 RID: 681
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002AA RID: 682
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002AB RID: 683
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002AC RID: 684
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002AD RID: 685
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002AE RID: 686
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002AF RID: 687
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002B0 RID: 688
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200004E RID: 78
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<populateHistory>d__68")]
		public sealed class _populateHistory_d__68 : global::Il2CppSystem.Object
		{
			// Token: 0x06000414 RID: 1044 RVA: 0x00011858 File Offset: 0x0000FA58
			// Note: this type is marked as 'beforefieldinit'.
			static _populateHistory_d__68()
			{
				Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<populateHistory>d__68");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr);
				IAPStoreModel._populateHistory_d__68.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr, "<>1__state");
				IAPStoreModel._populateHistory_d__68.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr, "<>2__current");
				IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr, 100663691);
				IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr, 100663692);
				IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr, 100663693);
				IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr, 100663694);
				IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr, 100663695);
				IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr, 100663696);
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x00011924 File Offset: 0x0000FB24
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _populateHistory_d__68(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel._populateHistory_d__68>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x0001196C File Offset: 0x0000FB6C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x000119A0 File Offset: 0x0000FBA0
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000418 RID: 1048 RVA: 0x000119DC File Offset: 0x0000FBDC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x00011A1C File Offset: 0x0000FC1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201486, XrefRangeEnd = 1201491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x0600041A RID: 1050 RVA: 0x00011A50 File Offset: 0x0000FC50
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._populateHistory_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x00003CF2 File Offset: 0x00001EF2
			public _populateHistory_d__68(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x0600041C RID: 1052 RVA: 0x00011A90 File Offset: 0x0000FC90
			// (set) Token: 0x0600041D RID: 1053 RVA: 0x00003CFB File Offset: 0x00001EFB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._populateHistory_d__68.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._populateHistory_d__68.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x0600041E RID: 1054 RVA: 0x00011AB8 File Offset: 0x0000FCB8
			// (set) Token: 0x0600041F RID: 1055 RVA: 0x00003D16 File Offset: 0x00001F16
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._populateHistory_d__68.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._populateHistory_d__68.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002B1 RID: 689
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002B2 RID: 690
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002B3 RID: 691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002B4 RID: 692
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002B5 RID: 693
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002B6 RID: 694
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002B7 RID: 695
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002B8 RID: 696
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200004F RID: 79
		[ObfuscatedName("dwd.iap.store.IAPStoreModel+<postInitialize>d__69")]
		public sealed class _postInitialize_d__69 : global::Il2CppSystem.Object
		{
			// Token: 0x06000420 RID: 1056 RVA: 0x00011AE8 File Offset: 0x0000FCE8
			// Note: this type is marked as 'beforefieldinit'.
			static _postInitialize_d__69()
			{
				Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreModel>.NativeClassPtr, "<postInitialize>d__69");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr);
				IAPStoreModel._postInitialize_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr, "<>1__state");
				IAPStoreModel._postInitialize_d__69.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr, "<>2__current");
				IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr, 100663697);
				IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr, 100663698);
				IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr, 100663699);
				IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr, 100663700);
				IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr, 100663701);
				IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr, 100663702);
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00011BB4 File Offset: 0x0000FDB4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _postInitialize_d__69(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreModel._postInitialize_d__69>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x00011BFC File Offset: 0x0000FDFC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x00011C30 File Offset: 0x0000FE30
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x06000424 RID: 1060 RVA: 0x00011C6C File Offset: 0x0000FE6C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x00011CAC File Offset: 0x0000FEAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201491, XrefRangeEnd = 1201496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x06000426 RID: 1062 RVA: 0x00011CE0 File Offset: 0x0000FEE0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreModel._postInitialize_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00003D35 File Offset: 0x00001F35
			public _postInitialize_d__69(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000428 RID: 1064 RVA: 0x00011D20 File Offset: 0x0000FF20
			// (set) Token: 0x06000429 RID: 1065 RVA: 0x00003D3E File Offset: 0x00001F3E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._postInitialize_d__69.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._postInitialize_d__69.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x0600042A RID: 1066 RVA: 0x00011D48 File Offset: 0x0000FF48
			// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003D59 File Offset: 0x00001F59
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._postInitialize_d__69.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreModel._postInitialize_d__69.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002B9 RID: 697
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002BA RID: 698
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002BB RID: 699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002BC RID: 700
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002BD RID: 701
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002BE RID: 702
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002BF RID: 703
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002C0 RID: 704
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
