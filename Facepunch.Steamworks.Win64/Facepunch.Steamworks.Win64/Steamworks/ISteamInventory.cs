using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000018 RID: 24
	public class ISteamInventory : SteamInterface
	{
		// Token: 0x06000353 RID: 851 RVA: 0x00022608 File Offset: 0x00020808
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamInventory()
		{
			Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr);
			ISteamInventory.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664102);
			ISteamInventory.NativeMethodInfoPtr_SteamAPI_SteamInventory_v003_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664103);
			ISteamInventory.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664104);
			ISteamInventory.NativeMethodInfoPtr_SteamAPI_SteamGameServerInventory_v003_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664105);
			ISteamInventory.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664106);
			ISteamInventory.NativeMethodInfoPtr__GetResultStatus_Private_Static_Result_IntPtr_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664107);
			ISteamInventory.NativeMethodInfoPtr_GetResultStatus_Internal_Result_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664108);
			ISteamInventory.NativeMethodInfoPtr__GetResultItems_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664109);
			ISteamInventory.NativeMethodInfoPtr_GetResultItems_Internal_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664110);
			ISteamInventory.NativeMethodInfoPtr__GetResultItemProperty_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_UInt32_String_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664111);
			ISteamInventory.NativeMethodInfoPtr_GetResultItemProperty_Internal_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664112);
			ISteamInventory.NativeMethodInfoPtr__GetResultTimestamp_Private_Static_UInt32_IntPtr_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664113);
			ISteamInventory.NativeMethodInfoPtr_GetResultTimestamp_Internal_UInt32_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664114);
			ISteamInventory.NativeMethodInfoPtr__CheckResultSteamID_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664115);
			ISteamInventory.NativeMethodInfoPtr_CheckResultSteamID_Internal_Boolean_SteamInventoryResult_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664116);
			ISteamInventory.NativeMethodInfoPtr__DestroyResult_Private_Static_Void_IntPtr_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664117);
			ISteamInventory.NativeMethodInfoPtr_DestroyResult_Internal_Void_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664118);
			ISteamInventory.NativeMethodInfoPtr__GetAllItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664119);
			ISteamInventory.NativeMethodInfoPtr_GetAllItems_Internal_Boolean_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664120);
			ISteamInventory.NativeMethodInfoPtr__GetItemsByID_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_byref_InventoryItemId_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664121);
			ISteamInventory.NativeMethodInfoPtr_GetItemsByID_Internal_Boolean_byref_SteamInventoryResult_t_byref_InventoryItemId_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664122);
			ISteamInventory.NativeMethodInfoPtr__SerializeResult_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664123);
			ISteamInventory.NativeMethodInfoPtr_SerializeResult_Internal_Boolean_SteamInventoryResult_t_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664124);
			ISteamInventory.NativeMethodInfoPtr__DeserializeResult_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_IntPtr_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664125);
			ISteamInventory.NativeMethodInfoPtr_DeserializeResult_Internal_Boolean_byref_SteamInventoryResult_t_IntPtr_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664126);
			ISteamInventory.NativeMethodInfoPtr__GenerateItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664127);
			ISteamInventory.NativeMethodInfoPtr_GenerateItems_Internal_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664128);
			ISteamInventory.NativeMethodInfoPtr__GrantPromoItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664129);
			ISteamInventory.NativeMethodInfoPtr_GrantPromoItems_Internal_Boolean_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664130);
			ISteamInventory.NativeMethodInfoPtr__AddPromoItem_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664131);
			ISteamInventory.NativeMethodInfoPtr_AddPromoItem_Internal_Boolean_byref_SteamInventoryResult_t_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664132);
			ISteamInventory.NativeMethodInfoPtr__AddPromoItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664133);
			ISteamInventory.NativeMethodInfoPtr_AddPromoItems_Internal_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664134);
			ISteamInventory.NativeMethodInfoPtr__ConsumeItem_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryItemId_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664135);
			ISteamInventory.NativeMethodInfoPtr_ConsumeItem_Internal_Boolean_byref_SteamInventoryResult_t_InventoryItemId_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664136);
			ISteamInventory.NativeMethodInfoPtr__ExchangeItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664137);
			ISteamInventory.NativeMethodInfoPtr_ExchangeItems_Internal_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664138);
			ISteamInventory.NativeMethodInfoPtr__TransferItemQuantity_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryItemId_UInt32_InventoryItemId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664139);
			ISteamInventory.NativeMethodInfoPtr_TransferItemQuantity_Internal_Boolean_byref_SteamInventoryResult_t_InventoryItemId_UInt32_InventoryItemId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664140);
			ISteamInventory.NativeMethodInfoPtr__SendItemDropHeartbeat_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664141);
			ISteamInventory.NativeMethodInfoPtr_SendItemDropHeartbeat_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664142);
			ISteamInventory.NativeMethodInfoPtr__TriggerItemDrop_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664143);
			ISteamInventory.NativeMethodInfoPtr_TriggerItemDrop_Internal_Boolean_byref_SteamInventoryResult_t_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664144);
			ISteamInventory.NativeMethodInfoPtr__TradeItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_SteamId_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664145);
			ISteamInventory.NativeMethodInfoPtr_TradeItems_Internal_Boolean_byref_SteamInventoryResult_t_SteamId_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664146);
			ISteamInventory.NativeMethodInfoPtr__LoadItemDefinitions_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664147);
			ISteamInventory.NativeMethodInfoPtr_LoadItemDefinitions_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664148);
			ISteamInventory.NativeMethodInfoPtr__GetItemDefinitionIDs_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664149);
			ISteamInventory.NativeMethodInfoPtr_GetItemDefinitionIDs_Internal_Boolean_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664150);
			ISteamInventory.NativeMethodInfoPtr__GetItemDefinitionProperty_Private_Static_Boolean_IntPtr_InventoryDefId_String_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664151);
			ISteamInventory.NativeMethodInfoPtr_GetItemDefinitionProperty_Internal_Boolean_InventoryDefId_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664152);
			ISteamInventory.NativeMethodInfoPtr__RequestEligiblePromoItemDefinitionsIDs_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664153);
			ISteamInventory.NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Internal_CallResult_1_SteamInventoryEligiblePromoItemDefIDs_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664154);
			ISteamInventory.NativeMethodInfoPtr__GetEligiblePromoItemDefinitionIDs_Private_Static_Boolean_IntPtr_SteamId_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664155);
			ISteamInventory.NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Internal_Boolean_SteamId_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664156);
			ISteamInventory.NativeMethodInfoPtr__StartPurchase_Private_Static_SteamAPICall_t_IntPtr_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664157);
			ISteamInventory.NativeMethodInfoPtr_StartPurchase_Internal_CallResult_1_SteamInventoryStartPurchaseResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664158);
			ISteamInventory.NativeMethodInfoPtr__RequestPrices_Private_Static_SteamAPICall_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664159);
			ISteamInventory.NativeMethodInfoPtr_RequestPrices_Internal_CallResult_1_SteamInventoryRequestPricesResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664160);
			ISteamInventory.NativeMethodInfoPtr__GetNumItemsWithPrices_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664161);
			ISteamInventory.NativeMethodInfoPtr_GetNumItemsWithPrices_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664162);
			ISteamInventory.NativeMethodInfoPtr__GetItemsWithPrices_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664163);
			ISteamInventory.NativeMethodInfoPtr_GetItemsWithPrices_Internal_Boolean_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664164);
			ISteamInventory.NativeMethodInfoPtr__GetItemPrice_Private_Static_Boolean_IntPtr_InventoryDefId_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664165);
			ISteamInventory.NativeMethodInfoPtr_GetItemPrice_Internal_Boolean_InventoryDefId_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664166);
			ISteamInventory.NativeMethodInfoPtr__StartUpdateProperties_Private_Static_SteamInventoryUpdateHandle_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664167);
			ISteamInventory.NativeMethodInfoPtr_StartUpdateProperties_Internal_SteamInventoryUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664168);
			ISteamInventory.NativeMethodInfoPtr__RemoveProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664169);
			ISteamInventory.NativeMethodInfoPtr_RemoveProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664170);
			ISteamInventory.NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664171);
			ISteamInventory.NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664172);
			ISteamInventory.NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664173);
			ISteamInventory.NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664174);
			ISteamInventory.NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664175);
			ISteamInventory.NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664176);
			ISteamInventory.NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664177);
			ISteamInventory.NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664178);
			ISteamInventory.NativeMethodInfoPtr__SubmitUpdateProperties_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664179);
			ISteamInventory.NativeMethodInfoPtr_SubmitUpdateProperties_Internal_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664180);
			ISteamInventory.NativeMethodInfoPtr__InspectItem_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664181);
			ISteamInventory.NativeMethodInfoPtr_InspectItem_Internal_Boolean_byref_SteamInventoryResult_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr, 100664182);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00022C8C File Offset: 0x00020E8C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamInventory(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamInventory>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00022CD4 File Offset: 0x00020ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932988, XrefRangeEnd = 932990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamInventory_v003()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_SteamAPI_SteamInventory_v003_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00022D04 File Offset: 0x00020F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamInventory.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00022D4C File Offset: 0x00020F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932990, XrefRangeEnd = 932992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamGameServerInventory_v003()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_SteamAPI_SteamGameServerInventory_v003_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00022D7C File Offset: 0x00020F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetServerInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamInventory.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00022DC4 File Offset: 0x00020FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932992, XrefRangeEnd = 932994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _GetResultStatus(IntPtr self, SteamInventoryResult_t resultHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetResultStatus_Private_Static_Result_IntPtr_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00022E10 File Offset: 0x00021010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932996, RefRangeEnd = 932997, XrefRangeStart = 932994, XrefRangeEnd = 932996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetResultStatus_Internal_Result_SteamInventoryResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00022E5C File Offset: 0x0002105C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932997, XrefRangeEnd = 932999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetResultItems(IntPtr self, SteamInventoryResult_t resultHandle, [In] [Out] Il2CppStructArray<SteamItemDetails_t> pOutItemsArray, ref uint punOutItemsArraySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultHandle;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punOutItemsArraySize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetResultItems_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutItemsArray = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamItemDetails_t>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00022ED8 File Offset: 0x000210D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 933001, RefRangeEnd = 933004, XrefRangeStart = 932999, XrefRangeEnd = 933001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetResultItems(SteamInventoryResult_t resultHandle, [In] [Out] Il2CppStructArray<SteamItemDetails_t> pOutItemsArray, ref uint punOutItemsArraySize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punOutItemsArraySize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetResultItems_Internal_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutItemsArray = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamItemDetails_t>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00022F54 File Offset: 0x00021154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933004, XrefRangeEnd = 933007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetResultItemProperty(IntPtr self, SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unItemIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchValueBuffer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punValueBufferSizeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetResultItemProperty_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_UInt32_String_IntPtr_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00022FDC File Offset: 0x000211DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933030, RefRangeEnd = 933032, XrefRangeStart = 933007, XrefRangeEnd = 933030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unItemIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punValueBufferSizeOut;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetResultItemProperty_Internal_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValueBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00023070 File Offset: 0x00021270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933032, XrefRangeEnd = 933034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetResultTimestamp(IntPtr self, SteamInventoryResult_t resultHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetResultTimestamp_Private_Static_UInt32_IntPtr_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000230BC File Offset: 0x000212BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933034, XrefRangeEnd = 933036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetResultTimestamp_Internal_UInt32_SteamInventoryResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00023108 File Offset: 0x00021308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933036, XrefRangeEnd = 933038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CheckResultSteamID(IntPtr self, SteamInventoryResult_t resultHandle, SteamId steamIDExpected)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDExpected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__CheckResultSteamID_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00023164 File Offset: 0x00021364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933040, RefRangeEnd = 933041, XrefRangeStart = 933038, XrefRangeEnd = 933040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckResultSteamID(SteamInventoryResult_t resultHandle, SteamId steamIDExpected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDExpected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_CheckResultSteamID_Internal_Boolean_SteamInventoryResult_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000231BC File Offset: 0x000213BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933041, XrefRangeEnd = 933043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _DestroyResult(IntPtr self, SteamInventoryResult_t resultHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__DestroyResult_Private_Static_Void_IntPtr_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000231FC File Offset: 0x000213FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933045, RefRangeEnd = 933046, XrefRangeStart = 933043, XrefRangeEnd = 933045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyResult(SteamInventoryResult_t resultHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_DestroyResult_Internal_Void_SteamInventoryResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0002323C File Offset: 0x0002143C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933046, XrefRangeEnd = 933048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetAllItems(IntPtr self, ref SteamInventoryResult_t pResultHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetAllItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00023288 File Offset: 0x00021488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933050, RefRangeEnd = 933052, XrefRangeStart = 933048, XrefRangeEnd = 933050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAllItems(ref SteamInventoryResult_t pResultHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetAllItems_Internal_Boolean_byref_SteamInventoryResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000232D4 File Offset: 0x000214D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933052, XrefRangeEnd = 933054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetItemsByID(IntPtr self, ref SteamInventoryResult_t pResultHandle, ref InventoryItemId pInstanceIDs, uint unCountInstanceIDs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pInstanceIDs;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unCountInstanceIDs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetItemsByID_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_byref_InventoryItemId_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0002333C File Offset: 0x0002153C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933054, XrefRangeEnd = 933056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetItemsByID(ref SteamInventoryResult_t pResultHandle, ref InventoryItemId pInstanceIDs, uint unCountInstanceIDs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pInstanceIDs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unCountInstanceIDs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetItemsByID_Internal_Boolean_byref_SteamInventoryResult_t_byref_InventoryItemId_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000233A4 File Offset: 0x000215A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933056, XrefRangeEnd = 933058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SerializeResult(IntPtr self, SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pOutBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punOutBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__SerializeResult_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_IntPtr_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0002340C File Offset: 0x0002160C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933060, RefRangeEnd = 933062, XrefRangeStart = 933058, XrefRangeEnd = 933060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SerializeResult(SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pOutBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punOutBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_SerializeResult_Internal_Boolean_SteamInventoryResult_t_IntPtr_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00023474 File Offset: 0x00021674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933062, XrefRangeEnd = 933064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _DeserializeResult(IntPtr self, ref SteamInventoryResult_t pOutResultHandle, IntPtr pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutResultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRESERVED_MUST_BE_FALSE;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__DeserializeResult_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_IntPtr_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000234EC File Offset: 0x000216EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933066, RefRangeEnd = 933067, XrefRangeStart = 933064, XrefRangeEnd = 933066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeserializeResult(ref SteamInventoryResult_t pOutResultHandle, IntPtr pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pOutResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRESERVED_MUST_BE_FALSE;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_DeserializeResult_Internal_Boolean_byref_SteamInventoryResult_t_IntPtr_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00023560 File Offset: 0x00021760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933067, XrefRangeEnd = 933069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GenerateItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, [In] [Out] Il2CppStructArray<InventoryDefId> pArrayItemDefs, [In] [Out] Il2CppStructArray<uint> punArrayQuantity, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GenerateItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*pArrayItemDefs = ((intPtr5 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*punArrayQuantity = ((intPtr6 == 0) ? null : new Il2CppStructArray<uint>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00023600 File Offset: 0x00021800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933071, RefRangeEnd = 933072, XrefRangeStart = 933069, XrefRangeEnd = 933071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GenerateItems(ref SteamInventoryResult_t pResultHandle, [In] [Out] Il2CppStructArray<InventoryDefId> pArrayItemDefs, [In] [Out] Il2CppStructArray<uint> punArrayQuantity, uint unArrayLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GenerateItems_Internal_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*pArrayItemDefs = ((intPtr5 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*punArrayQuantity = ((intPtr6 == 0) ? null : new Il2CppStructArray<uint>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000236A0 File Offset: 0x000218A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933072, XrefRangeEnd = 933074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GrantPromoItems(IntPtr self, ref SteamInventoryResult_t pResultHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GrantPromoItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000236EC File Offset: 0x000218EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933076, RefRangeEnd = 933077, XrefRangeStart = 933074, XrefRangeEnd = 933076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GrantPromoItems(ref SteamInventoryResult_t pResultHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GrantPromoItems_Internal_Boolean_byref_SteamInventoryResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00023738 File Offset: 0x00021938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933077, XrefRangeEnd = 933079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _AddPromoItem(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryDefId itemDef)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemDef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__AddPromoItem_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryDefId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00023794 File Offset: 0x00021994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933081, RefRangeEnd = 933082, XrefRangeStart = 933079, XrefRangeEnd = 933081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddPromoItem(ref SteamInventoryResult_t pResultHandle, InventoryDefId itemDef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemDef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_AddPromoItem_Internal_Boolean_byref_SteamInventoryResult_t_InventoryDefId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000237EC File Offset: 0x000219EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933082, XrefRangeEnd = 933084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _AddPromoItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, [In] [Out] Il2CppStructArray<InventoryDefId> pArrayItemDefs, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__AddPromoItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pArrayItemDefs = ((intPtr4 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00023868 File Offset: 0x00021A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933084, XrefRangeEnd = 933086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddPromoItems(ref SteamInventoryResult_t pResultHandle, [In] [Out] Il2CppStructArray<InventoryDefId> pArrayItemDefs, uint unArrayLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_AddPromoItems_Internal_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pArrayItemDefs = ((intPtr4 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000238E4 File Offset: 0x00021AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933086, XrefRangeEnd = 933088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ConsumeItem(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemConsume;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__ConsumeItem_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryItemId_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0002394C File Offset: 0x00021B4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933090, RefRangeEnd = 933091, XrefRangeStart = 933088, XrefRangeEnd = 933090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ConsumeItem(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemConsume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_ConsumeItem_Internal_Boolean_byref_SteamInventoryResult_t_InventoryItemId_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000239B4 File Offset: 0x00021BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933091, XrefRangeEnd = 933093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ExchangeItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, [In] [Out] Il2CppStructArray<InventoryDefId> pArrayGenerate, [In] [Out] Il2CppStructArray<uint> punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] Il2CppStructArray<InventoryItemId> pArrayDestroy, [In] [Out] Il2CppStructArray<uint> punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayGenerateLength;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayDestroyLength;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__ExchangeItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			*pArrayGenerate = ((intPtr7 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr7));
			IntPtr intPtr8 = intPtr2;
			*punArrayGenerateQuantity = ((intPtr8 == 0) ? null : new Il2CppStructArray<uint>(intPtr8));
			IntPtr intPtr9 = intPtr3;
			*pArrayDestroy = ((intPtr9 == 0) ? null : new Il2CppStructArray<InventoryItemId>(intPtr9));
			IntPtr intPtr10 = intPtr4;
			*punArrayDestroyQuantity = ((intPtr10 == 0) ? null : new Il2CppStructArray<uint>(intPtr10));
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00023AAC File Offset: 0x00021CAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933095, RefRangeEnd = 933097, XrefRangeStart = 933093, XrefRangeEnd = 933095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ExchangeItems(ref SteamInventoryResult_t pResultHandle, [In] [Out] Il2CppStructArray<InventoryDefId> pArrayGenerate, [In] [Out] Il2CppStructArray<uint> punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] Il2CppStructArray<InventoryItemId> pArrayDestroy, [In] [Out] Il2CppStructArray<uint> punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayGenerateLength;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayDestroyLength;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_ExchangeItems_Internal_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			*pArrayGenerate = ((intPtr7 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr7));
			IntPtr intPtr8 = intPtr2;
			*punArrayGenerateQuantity = ((intPtr8 == 0) ? null : new Il2CppStructArray<uint>(intPtr8));
			IntPtr intPtr9 = intPtr3;
			*pArrayDestroy = ((intPtr9 == 0) ? null : new Il2CppStructArray<InventoryItemId>(intPtr9));
			IntPtr intPtr10 = intPtr4;
			*punArrayDestroyQuantity = ((intPtr10 == 0) ? null : new Il2CppStructArray<uint>(intPtr10));
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00023BA0 File Offset: 0x00021DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933097, XrefRangeEnd = 933099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _TransferItemQuantity(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemIdSource;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unQuantity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemIdDest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__TransferItemQuantity_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryItemId_UInt32_InventoryItemId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00023C18 File Offset: 0x00021E18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933101, RefRangeEnd = 933103, XrefRangeStart = 933099, XrefRangeEnd = 933101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TransferItemQuantity(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemIdSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemIdDest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_TransferItemQuantity_Internal_Boolean_byref_SteamInventoryResult_t_InventoryItemId_UInt32_InventoryItemId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00023C8C File Offset: 0x00021E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933103, XrefRangeEnd = 933105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SendItemDropHeartbeat(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__SendItemDropHeartbeat_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00023CC0 File Offset: 0x00021EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933105, XrefRangeEnd = 933107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendItemDropHeartbeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_SendItemDropHeartbeat_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00023CF4 File Offset: 0x00021EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933107, XrefRangeEnd = 933109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _TriggerItemDrop(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dropListDefinition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__TriggerItemDrop_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryDefId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00023D50 File Offset: 0x00021F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933111, RefRangeEnd = 933112, XrefRangeStart = 933109, XrefRangeEnd = 933111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TriggerItemDrop(ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dropListDefinition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_TriggerItemDrop_Internal_Boolean_byref_SteamInventoryResult_t_InventoryDefId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00023DA8 File Offset: 0x00021FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933112, XrefRangeEnd = 933114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _TradeItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, SteamId steamIDTradePartner, [In] [Out] Il2CppStructArray<InventoryItemId> pArrayGive, [In] [Out] Il2CppStructArray<uint> pArrayGiveQuantity, uint nArrayGiveLength, [In] [Out] Il2CppStructArray<InventoryItemId> pArrayGet, [In] [Out] Il2CppStructArray<uint> pArrayGetQuantity, uint nArrayGetLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDTradePartner;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nArrayGiveLength;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nArrayGetLength;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__TradeItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_SteamId_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			*pArrayGive = ((intPtr7 == 0) ? null : new Il2CppStructArray<InventoryItemId>(intPtr7));
			IntPtr intPtr8 = intPtr2;
			*pArrayGiveQuantity = ((intPtr8 == 0) ? null : new Il2CppStructArray<uint>(intPtr8));
			IntPtr intPtr9 = intPtr3;
			*pArrayGet = ((intPtr9 == 0) ? null : new Il2CppStructArray<InventoryItemId>(intPtr9));
			IntPtr intPtr10 = intPtr4;
			*pArrayGetQuantity = ((intPtr10 == 0) ? null : new Il2CppStructArray<uint>(intPtr10));
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00023EB0 File Offset: 0x000220B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933114, XrefRangeEnd = 933116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TradeItems(ref SteamInventoryResult_t pResultHandle, SteamId steamIDTradePartner, [In] [Out] Il2CppStructArray<InventoryItemId> pArrayGive, [In] [Out] Il2CppStructArray<uint> pArrayGiveQuantity, uint nArrayGiveLength, [In] [Out] Il2CppStructArray<InventoryItemId> pArrayGet, [In] [Out] Il2CppStructArray<uint> pArrayGetQuantity, uint nArrayGetLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDTradePartner;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nArrayGiveLength;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nArrayGetLength;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_TradeItems_Internal_Boolean_byref_SteamInventoryResult_t_SteamId_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			*pArrayGive = ((intPtr7 == 0) ? null : new Il2CppStructArray<InventoryItemId>(intPtr7));
			IntPtr intPtr8 = intPtr2;
			*pArrayGiveQuantity = ((intPtr8 == 0) ? null : new Il2CppStructArray<uint>(intPtr8));
			IntPtr intPtr9 = intPtr3;
			*pArrayGet = ((intPtr9 == 0) ? null : new Il2CppStructArray<InventoryItemId>(intPtr9));
			IntPtr intPtr10 = intPtr4;
			*pArrayGetQuantity = ((intPtr10 == 0) ? null : new Il2CppStructArray<uint>(intPtr10));
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00023FB4 File Offset: 0x000221B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933116, XrefRangeEnd = 933118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _LoadItemDefinitions(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__LoadItemDefinitions_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00023FF4 File Offset: 0x000221F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933120, RefRangeEnd = 933122, XrefRangeStart = 933118, XrefRangeEnd = 933120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadItemDefinitions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_LoadItemDefinitions_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00024030 File Offset: 0x00022230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933122, XrefRangeEnd = 933124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetItemDefinitionIDs(IntPtr self, [In] [Out] Il2CppStructArray<InventoryDefId> pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punItemDefIDsArraySize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetItemDefinitionIDs_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pItemDefIDs = ((intPtr4 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000240A0 File Offset: 0x000222A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 933126, RefRangeEnd = 933130, XrefRangeStart = 933124, XrefRangeEnd = 933126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetItemDefinitionIDs([In] [Out] Il2CppStructArray<InventoryDefId> pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punItemDefIDsArraySize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetItemDefinitionIDs_Internal_Boolean_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pItemDefIDs = ((intPtr4 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0002410C File Offset: 0x0002230C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933130, XrefRangeEnd = 933133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetItemDefinitionProperty(IntPtr self, InventoryDefId iDefinition, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iDefinition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchValueBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punValueBufferSizeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetItemDefinitionProperty_Private_Static_Boolean_IntPtr_InventoryDefId_String_IntPtr_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00024188 File Offset: 0x00022388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933133, XrefRangeEnd = 933156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetItemDefinitionProperty(InventoryDefId iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iDefinition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punValueBufferSizeOut;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetItemDefinitionProperty_Internal_Boolean_InventoryDefId_String_byref_String_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValueBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00024210 File Offset: 0x00022410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933156, XrefRangeEnd = 933158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _RequestEligiblePromoItemDefinitionsIDs(IntPtr self, SteamId steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__RequestEligiblePromoItemDefinitionsIDs_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0002425C File Offset: 0x0002245C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933158, XrefRangeEnd = 933163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<SteamInventoryEligiblePromoItemDefIDs_t> RequestEligiblePromoItemDefinitionsIDs(SteamId steamID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Internal_CallResult_1_SteamInventoryEligiblePromoItemDefIDs_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<SteamInventoryEligiblePromoItemDefIDs_t>(intPtr);
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000242A0 File Offset: 0x000224A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933163, XrefRangeEnd = 933165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetEligiblePromoItemDefinitionIDs(IntPtr self, SteamId steamID, [In] [Out] Il2CppStructArray<InventoryDefId> pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punItemDefIDsArraySize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetEligiblePromoItemDefinitionIDs_Private_Static_Boolean_IntPtr_SteamId_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pItemDefIDs = ((intPtr4 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0002431C File Offset: 0x0002251C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933165, XrefRangeEnd = 933167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetEligiblePromoItemDefinitionIDs(SteamId steamID, [In] [Out] Il2CppStructArray<InventoryDefId> pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punItemDefIDsArraySize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Internal_Boolean_SteamId_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pItemDefIDs = ((intPtr4 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00024398 File Offset: 0x00022598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933167, XrefRangeEnd = 933169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _StartPurchase(IntPtr self, [In] [Out] Il2CppStructArray<InventoryDefId> pArrayItemDefs, [In] [Out] Il2CppStructArray<uint> punArrayQuantity, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__StartPurchase_Private_Static_SteamAPICall_t_IntPtr_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*pArrayItemDefs = ((intPtr5 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*punArrayQuantity = ((intPtr6 == 0) ? null : new Il2CppStructArray<uint>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0002442C File Offset: 0x0002262C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933174, RefRangeEnd = 933175, XrefRangeStart = 933169, XrefRangeEnd = 933174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<SteamInventoryStartPurchaseResult_t> StartPurchase([In] [Out] Il2CppStructArray<InventoryDefId> pArrayItemDefs, [In] [Out] Il2CppStructArray<uint> punArrayQuantity, uint unArrayLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_StartPurchase_Internal_CallResult_1_SteamInventoryStartPurchaseResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*pArrayItemDefs = ((intPtr5 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*punArrayQuantity = ((intPtr6 == 0) ? null : new Il2CppStructArray<uint>(intPtr6));
			return new CallResult<SteamInventoryStartPurchaseResult_t>(intPtr3);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000244B8 File Offset: 0x000226B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933175, XrefRangeEnd = 933177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _RequestPrices(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__RequestPrices_Private_Static_SteamAPICall_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000244F8 File Offset: 0x000226F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933182, RefRangeEnd = 933183, XrefRangeStart = 933177, XrefRangeEnd = 933182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<SteamInventoryRequestPricesResult_t> RequestPrices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_RequestPrices_Internal_CallResult_1_SteamInventoryRequestPricesResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<SteamInventoryRequestPricesResult_t>(intPtr);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00024530 File Offset: 0x00022730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933183, XrefRangeEnd = 933185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetNumItemsWithPrices(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetNumItemsWithPrices_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00024570 File Offset: 0x00022770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933187, RefRangeEnd = 933188, XrefRangeStart = 933185, XrefRangeEnd = 933187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetNumItemsWithPrices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetNumItemsWithPrices_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000245AC File Offset: 0x000227AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933188, XrefRangeEnd = 933190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetItemsWithPrices(IntPtr self, [In] [Out] Il2CppStructArray<InventoryDefId> pArrayItemDefs, [In] [Out] Il2CppStructArray<ulong> pCurrentPrices, [In] [Out] Il2CppStructArray<ulong> pBasePrices, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetItemsWithPrices_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			*pArrayItemDefs = ((intPtr6 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			*pCurrentPrices = ((intPtr7 == 0) ? null : new Il2CppStructArray<ulong>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			*pBasePrices = ((intPtr8 == 0) ? null : new Il2CppStructArray<ulong>(intPtr8));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00024660 File Offset: 0x00022860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933192, RefRangeEnd = 933193, XrefRangeStart = 933190, XrefRangeEnd = 933192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetItemsWithPrices([In] [Out] Il2CppStructArray<InventoryDefId> pArrayItemDefs, [In] [Out] Il2CppStructArray<ulong> pCurrentPrices, [In] [Out] Il2CppStructArray<ulong> pBasePrices, uint unArrayLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetItemsWithPrices_Internal_Boolean_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			*pArrayItemDefs = ((intPtr6 == 0) ? null : new Il2CppStructArray<InventoryDefId>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			*pCurrentPrices = ((intPtr7 == 0) ? null : new Il2CppStructArray<ulong>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			*pBasePrices = ((intPtr8 == 0) ? null : new Il2CppStructArray<ulong>(intPtr8));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00024714 File Offset: 0x00022914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933193, XrefRangeEnd = 933195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetItemPrice(IntPtr self, InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iDefinition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCurrentPrice;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pBasePrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__GetItemPrice_Private_Static_Boolean_IntPtr_InventoryDefId_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0002477C File Offset: 0x0002297C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 933197, RefRangeEnd = 933201, XrefRangeStart = 933195, XrefRangeEnd = 933197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetItemPrice(InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iDefinition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCurrentPrice;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pBasePrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_GetItemPrice_Internal_Boolean_InventoryDefId_byref_UInt64_byref_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000247E4 File Offset: 0x000229E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933201, XrefRangeEnd = 933203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamInventoryUpdateHandle_t _StartUpdateProperties(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__StartUpdateProperties_Private_Static_SteamInventoryUpdateHandle_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00024824 File Offset: 0x00022A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933203, XrefRangeEnd = 933205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_StartUpdateProperties_Internal_SteamInventoryUpdateHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00024860 File Offset: 0x00022A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933205, XrefRangeEnd = 933208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _RemoveProperty(IntPtr self, SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__RemoveProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000248CC File Offset: 0x00022ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933208, XrefRangeEnd = 933211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveProperty(SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_RemoveProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00024938 File Offset: 0x00022B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933211, XrefRangeEnd = 933216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetProperty(IntPtr self, SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, string pchPropertyValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000249B8 File Offset: 0x00022BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933216, XrefRangeEnd = 933221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetProperty(SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, string pchPropertyValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00024A34 File Offset: 0x00022C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933221, XrefRangeEnd = 933224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetProperty(IntPtr self, SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, bool bValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00024AB0 File Offset: 0x00022CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933224, XrefRangeEnd = 933227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetProperty(SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, bool bValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00024B28 File Offset: 0x00022D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933227, XrefRangeEnd = 933230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetProperty(IntPtr self, SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, long nValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00024BA4 File Offset: 0x00022DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933230, XrefRangeEnd = 933233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetProperty(SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, long nValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00024C1C File Offset: 0x00022E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933233, XrefRangeEnd = 933236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetProperty(IntPtr self, SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, float flValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00024C98 File Offset: 0x00022E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933236, XrefRangeEnd = 933239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetProperty(SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, float flValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00024D10 File Offset: 0x00022F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933239, XrefRangeEnd = 933241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SubmitUpdateProperties(IntPtr self, SteamInventoryUpdateHandle_t handle, ref SteamInventoryResult_t pResultHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__SubmitUpdateProperties_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00024D6C File Offset: 0x00022F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933241, XrefRangeEnd = 933243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, ref SteamInventoryResult_t pResultHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_SubmitUpdateProperties_Internal_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00024DC4 File Offset: 0x00022FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933243, XrefRangeEnd = 933246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _InspectItem(IntPtr self, ref SteamInventoryResult_t pResultHandle, string pchItemToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchItemToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr__InspectItem_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00024E24 File Offset: 0x00023024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933246, XrefRangeEnd = 933249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InspectItem(ref SteamInventoryResult_t pResultHandle, string pchItemToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchItemToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInventory.NativeMethodInfoPtr_InspectItem_Internal_Boolean_byref_SteamInventoryResult_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002336 File Offset: 0x00000536
		public ISteamInventory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamInventory_v003_Internal_Static_IntPtr_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamGameServerInventory_v003_Internal_Static_IntPtr_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr__GetResultStatus_Private_Static_Result_IntPtr_SteamInventoryResult_t_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_GetResultStatus_Internal_Result_SteamInventoryResult_t_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr__GetResultItems_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_GetResultItems_Internal_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr__GetResultItemProperty_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_UInt32_String_IntPtr_byref_UInt32_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_GetResultItemProperty_Internal_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr__GetResultTimestamp_Private_Static_UInt32_IntPtr_SteamInventoryResult_t_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_GetResultTimestamp_Internal_UInt32_SteamInventoryResult_t_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr__CheckResultSteamID_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_SteamId_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_CheckResultSteamID_Internal_Boolean_SteamInventoryResult_t_SteamId_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr__DestroyResult_Private_Static_Void_IntPtr_SteamInventoryResult_t_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_DestroyResult_Internal_Void_SteamInventoryResult_t_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr__GetAllItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItems_Internal_Boolean_byref_SteamInventoryResult_t_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr__GetItemsByID_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_byref_InventoryItemId_UInt32_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsByID_Internal_Boolean_byref_SteamInventoryResult_t_byref_InventoryItemId_UInt32_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr__SerializeResult_Private_Static_Boolean_IntPtr_SteamInventoryResult_t_IntPtr_byref_UInt32_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_SerializeResult_Internal_Boolean_SteamInventoryResult_t_IntPtr_byref_UInt32_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr__DeserializeResult_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_IntPtr_UInt32_Boolean_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeResult_Internal_Boolean_byref_SteamInventoryResult_t_IntPtr_UInt32_Boolean_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr__GenerateItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_GenerateItems_Internal_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr__GrantPromoItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_GrantPromoItems_Internal_Boolean_byref_SteamInventoryResult_t_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr__AddPromoItem_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryDefId_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItem_Internal_Boolean_byref_SteamInventoryResult_t_InventoryDefId_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr__AddPromoItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_UInt32_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItems_Internal_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_UInt32_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr__ConsumeItem_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryItemId_UInt32_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeItem_Internal_Boolean_byref_SteamInventoryResult_t_InventoryItemId_UInt32_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr__ExchangeItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_ExchangeItems_Internal_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr__TransferItemQuantity_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryItemId_UInt32_InventoryItemId_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_TransferItemQuantity_Internal_Boolean_byref_SteamInventoryResult_t_InventoryItemId_UInt32_InventoryItemId_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr__SendItemDropHeartbeat_Private_Static_Void_IntPtr_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_SendItemDropHeartbeat_Internal_Void_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr__TriggerItemDrop_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_InventoryDefId_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_TriggerItemDrop_Internal_Boolean_byref_SteamInventoryResult_t_InventoryDefId_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr__TradeItems_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_SteamId_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_TradeItems_Internal_Boolean_byref_SteamInventoryResult_t_SteamId_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_InventoryItemId_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr__LoadItemDefinitions_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_LoadItemDefinitions_Internal_Boolean_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr__GetItemDefinitionIDs_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDefinitionIDs_Internal_Boolean_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr__GetItemDefinitionProperty_Private_Static_Boolean_IntPtr_InventoryDefId_String_IntPtr_byref_UInt32_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDefinitionProperty_Internal_Boolean_InventoryDefId_String_byref_String_byref_UInt32_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr__RequestEligiblePromoItemDefinitionsIDs_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Internal_CallResult_1_SteamInventoryEligiblePromoItemDefIDs_t_SteamId_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr__GetEligiblePromoItemDefinitionIDs_Private_Static_Boolean_IntPtr_SteamId_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Internal_Boolean_SteamId_Il2CppStructArray_1_InventoryDefId_byref_UInt32_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr__StartPurchase_Private_Static_SteamAPICall_t_IntPtr_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_StartPurchase_Internal_CallResult_1_SteamInventoryStartPurchaseResult_t_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr__RequestPrices_Private_Static_SteamAPICall_t_IntPtr_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_RequestPrices_Internal_CallResult_1_SteamInventoryRequestPricesResult_t_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr__GetNumItemsWithPrices_Private_Static_UInt32_IntPtr_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_GetNumItemsWithPrices_Internal_UInt32_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr__GetItemsWithPrices_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsWithPrices_Internal_Boolean_Il2CppStructArray_1_InventoryDefId_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr__GetItemPrice_Private_Static_Boolean_IntPtr_InventoryDefId_byref_UInt64_byref_UInt64_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_GetItemPrice_Internal_Boolean_InventoryDefId_byref_UInt64_byref_UInt64_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr__StartUpdateProperties_Private_Static_SteamInventoryUpdateHandle_t_IntPtr_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_StartUpdateProperties_Internal_SteamInventoryUpdateHandle_t_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr__RemoveProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_RemoveProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_String_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_String_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_Boolean_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_Boolean_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_Int64_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_Int64_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr__SetProperty_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_InventoryItemId_String_Single_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Internal_Boolean_SteamInventoryUpdateHandle_t_InventoryItemId_String_Single_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr__SubmitUpdateProperties_Private_Static_Boolean_IntPtr_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_SubmitUpdateProperties_Internal_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr__InspectItem_Private_Static_Boolean_IntPtr_byref_SteamInventoryResult_t_String_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_InspectItem_Internal_Boolean_byref_SteamInventoryResult_t_String_0;
	}
}
