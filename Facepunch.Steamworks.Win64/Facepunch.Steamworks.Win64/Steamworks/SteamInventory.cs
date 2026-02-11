using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Linq;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000A1 RID: 161
	public class SteamInventory : SteamSharedClass<SteamInventory>
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00045788 File Offset: 0x00043988
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventory()
		{
			Il2CppClassPointerStore<SteamInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr);
			SteamInventory.NativeFieldInfoPtr_OnInventoryUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "OnInventoryUpdated");
			SteamInventory.NativeFieldInfoPtr_OnDefinitionsUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "OnDefinitionsUpdated");
			SteamInventory.NativeFieldInfoPtr__Currency_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<Currency>k__BackingField");
			SteamInventory.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<Items>k__BackingField");
			SteamInventory.NativeFieldInfoPtr__Definitions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<Definitions>k__BackingField");
			SteamInventory.NativeFieldInfoPtr__defMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "_defMap");
			SteamInventory.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665523);
			SteamInventory.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665524);
			SteamInventory.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665525);
			SteamInventory.NativeMethodInfoPtr_InventoryUpdated_Private_Static_Void_SteamInventoryFullUpdate_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665526);
			SteamInventory.NativeMethodInfoPtr_add_OnInventoryUpdated_Public_Static_add_Void_Action_1_InventoryResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665527);
			SteamInventory.NativeMethodInfoPtr_remove_OnInventoryUpdated_Public_Static_rem_Void_Action_1_InventoryResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665528);
			SteamInventory.NativeMethodInfoPtr_add_OnDefinitionsUpdated_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665529);
			SteamInventory.NativeMethodInfoPtr_remove_OnDefinitionsUpdated_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665530);
			SteamInventory.NativeMethodInfoPtr_LoadDefinitions_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665531);
			SteamInventory.NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665532);
			SteamInventory.NativeMethodInfoPtr_WaitForDefinitions_Public_Static_Task_1_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665533);
			SteamInventory.NativeMethodInfoPtr_FindDefinition_Public_Static_InventoryDef_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665534);
			SteamInventory.NativeMethodInfoPtr_get_Currency_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665535);
			SteamInventory.NativeMethodInfoPtr_set_Currency_Internal_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665536);
			SteamInventory.NativeMethodInfoPtr_GetDefinitionsWithPricesAsync_Public_Static_Task_1_Il2CppReferenceArray_1_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665537);
			SteamInventory.NativeMethodInfoPtr_get_Items_Public_Static_get_Il2CppReferenceArray_1_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665538);
			SteamInventory.NativeMethodInfoPtr_set_Items_Internal_Static_set_Void_Il2CppReferenceArray_1_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665539);
			SteamInventory.NativeMethodInfoPtr_get_Definitions_Public_Static_get_Il2CppReferenceArray_1_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665540);
			SteamInventory.NativeMethodInfoPtr_set_Definitions_Internal_Static_set_Void_Il2CppReferenceArray_1_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665541);
			SteamInventory.NativeMethodInfoPtr_GetDefinitions_Internal_Static_Il2CppReferenceArray_1_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665542);
			SteamInventory.NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665543);
			SteamInventory.NativeMethodInfoPtr_GetAllItemsAsync_Public_Static_Task_1_Nullable_1_InventoryResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665544);
			SteamInventory.NativeMethodInfoPtr_GenerateItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_InventoryDef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665545);
			SteamInventory.NativeMethodInfoPtr_CraftItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_Il2CppReferenceArray_1_InventoryItem_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665546);
			SteamInventory.NativeMethodInfoPtr_CraftItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_Il2CppReferenceArray_1_Amount_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665547);
			SteamInventory.NativeMethodInfoPtr_DeserializeAsync_Public_Static_Task_1_Nullable_1_InventoryResult_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665548);
			SteamInventory.NativeMethodInfoPtr_GrantPromoItemsAsync_Public_Static_Task_1_Nullable_1_InventoryResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665549);
			SteamInventory.NativeMethodInfoPtr_TriggerItemDropAsync_Public_Static_Task_1_Nullable_1_InventoryResult_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665550);
			SteamInventory.NativeMethodInfoPtr_AddPromoItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665551);
			SteamInventory.NativeMethodInfoPtr_StartPurchaseAsync_Public_Static_Task_1_Nullable_1_InventoryPurchaseResult_Il2CppReferenceArray_1_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665552);
			SteamInventory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100665553);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00045A9C File Offset: 0x00043C9C
		public unsafe static ISteamInventory Internal
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 939617, RefRangeEnd = 939653, XrefRangeStart = 939613, XrefRangeEnd = 939617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamInventory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamInventory>(intPtr3) : null;
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00045AD0 File Offset: 0x00043CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939653, XrefRangeEnd = 939658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamInventory.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00045B1C File Offset: 0x00043D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 939698, RefRangeEnd = 939699, XrefRangeStart = 939658, XrefRangeEnd = 939698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents(bool server)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00045B50 File Offset: 0x00043D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939699, XrefRangeEnd = 939708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InventoryUpdated(SteamInventoryFullUpdate_t x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_InventoryUpdated_Private_Static_Void_SteamInventoryFullUpdate_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00045B84 File Offset: 0x00043D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939708, XrefRangeEnd = 939717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnInventoryUpdated(Action<InventoryResult> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_add_OnInventoryUpdated_Public_Static_add_Void_Action_1_InventoryResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00045BBC File Offset: 0x00043DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939717, XrefRangeEnd = 939726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnInventoryUpdated(Action<InventoryResult> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_remove_OnInventoryUpdated_Public_Static_rem_Void_Action_1_InventoryResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00045BF4 File Offset: 0x00043DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939726, XrefRangeEnd = 939733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnDefinitionsUpdated(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_add_OnDefinitionsUpdated_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00045C2C File Offset: 0x00043E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939733, XrefRangeEnd = 939740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnDefinitionsUpdated(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_remove_OnDefinitionsUpdated_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00045C64 File Offset: 0x00043E64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 939793, RefRangeEnd = 939797, XrefRangeStart = 939740, XrefRangeEnd = 939793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadDefinitions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_LoadDefinitions_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00045C8C File Offset: 0x00043E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939797, XrefRangeEnd = 939803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadItemDefinitions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00045CB4 File Offset: 0x00043EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939803, XrefRangeEnd = 939816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> WaitForDefinitions(float timeoutSeconds = 30f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeoutSeconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_WaitForDefinitions_Public_Static_Task_1_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00045CF4 File Offset: 0x00043EF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 939821, RefRangeEnd = 939823, XrefRangeStart = 939816, XrefRangeEnd = 939821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InventoryDef FindDefinition(InventoryDefId defId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_FindDefinition_Public_Static_InventoryDef_InventoryDefId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr3) : null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00045D34 File Offset: 0x00043F34
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00045D60 File Offset: 0x00043F60
		public unsafe static string Currency
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939823, XrefRangeEnd = 939825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_get_Currency_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939825, XrefRangeEnd = 939829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_set_Currency_Internal_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00045D98 File Offset: 0x00043F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939829, XrefRangeEnd = 939842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Il2CppReferenceArray<InventoryDef>> GetDefinitionsWithPricesAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetDefinitionsWithPricesAsync_Public_Static_Task_1_Il2CppReferenceArray_1_InventoryDef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppReferenceArray<InventoryDef>>>(intPtr3) : null;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00045DCC File Offset: 0x00043FCC
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00045E00 File Offset: 0x00044000
		public unsafe static Il2CppReferenceArray<InventoryItem> Items
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939842, XrefRangeEnd = 939844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_get_Items_Public_Static_get_Il2CppReferenceArray_1_InventoryItem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryItem>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939844, XrefRangeEnd = 939848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_set_Items_Internal_Static_set_Void_Il2CppReferenceArray_1_InventoryItem_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00045E38 File Offset: 0x00044038
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00045E6C File Offset: 0x0004406C
		public unsafe static Il2CppReferenceArray<InventoryDef> Definitions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939848, XrefRangeEnd = 939850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_get_Definitions_Public_Static_get_Il2CppReferenceArray_1_InventoryDef_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryDef>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939850, XrefRangeEnd = 939854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_set_Definitions_Internal_Static_set_Void_Il2CppReferenceArray_1_InventoryDef_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00045EA4 File Offset: 0x000440A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939854, XrefRangeEnd = 939882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<InventoryDef> GetDefinitions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetDefinitions_Internal_Static_Il2CppReferenceArray_1_InventoryDef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryDef>>(intPtr3) : null;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00045ED8 File Offset: 0x000440D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939882, XrefRangeEnd = 939888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAllItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00045F08 File Offset: 0x00044108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939888, XrefRangeEnd = 939901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<InventoryResult>> GetAllItemsAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetAllItemsAsync_Public_Static_Task_1_Nullable_1_InventoryResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00045F3C File Offset: 0x0004413C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939901, XrefRangeEnd = 939915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<InventoryResult>> GenerateItemAsync(InventoryDef target, int amount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GenerateItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_InventoryDef_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00045F90 File Offset: 0x00044190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939915, XrefRangeEnd = 939930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<InventoryResult>> CraftItemAsync(Il2CppReferenceArray<InventoryItem> list, InventoryDef target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_CraftItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_Il2CppReferenceArray_1_InventoryItem_InventoryDef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00045FE8 File Offset: 0x000441E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939930, XrefRangeEnd = 939945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<InventoryResult>> CraftItemAsync(Il2CppReferenceArray<InventoryItem.Amount> list, InventoryDef target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_CraftItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_Il2CppReferenceArray_1_Amount_InventoryDef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00046040 File Offset: 0x00044240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939945, XrefRangeEnd = 939959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<InventoryResult>> DeserializeAsync(Il2CppStructArray<byte> data, int dataLength = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_DeserializeAsync_Public_Static_Task_1_Nullable_1_InventoryResult_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00046094 File Offset: 0x00044294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939959, XrefRangeEnd = 939972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<InventoryResult>> GrantPromoItemsAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GrantPromoItemsAsync_Public_Static_Task_1_Nullable_1_InventoryResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000460C8 File Offset: 0x000442C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939972, XrefRangeEnd = 939985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<InventoryResult>> TriggerItemDropAsync(InventoryDefId id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_TriggerItemDropAsync_Public_Static_Task_1_Nullable_1_InventoryResult_InventoryDefId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00046108 File Offset: 0x00044308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939985, XrefRangeEnd = 939998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<InventoryResult>> AddPromoItemAsync(InventoryDefId id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_AddPromoItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_InventoryDefId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00046148 File Offset: 0x00044348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939998, XrefRangeEnd = 940012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<InventoryPurchaseResult>> StartPurchaseAsync(Il2CppReferenceArray<InventoryDef> items)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_StartPurchaseAsync_Public_Static_Task_1_Nullable_1_InventoryPurchaseResult_Il2CppReferenceArray_1_InventoryDef_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryPurchaseResult>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0004618C File Offset: 0x0004438C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940012, XrefRangeEnd = 940015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamInventory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0000280A File Offset: 0x00000A0A
		public SteamInventory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x000461C8 File Offset: 0x000443C8
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x00002813 File Offset: 0x00000A13
		public unsafe static Action<InventoryResult> OnInventoryUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamInventory.NativeFieldInfoPtr_OnInventoryUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InventoryResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventory.NativeFieldInfoPtr_OnInventoryUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x000461F0 File Offset: 0x000443F0
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00002825 File Offset: 0x00000A25
		public unsafe static Action OnDefinitionsUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamInventory.NativeFieldInfoPtr_OnDefinitionsUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventory.NativeFieldInfoPtr_OnDefinitionsUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00046218 File Offset: 0x00044418
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00002837 File Offset: 0x00000A37
		public unsafe static string _Currency_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamInventory.NativeFieldInfoPtr__Currency_k__BackingField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventory.NativeFieldInfoPtr__Currency_k__BackingField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00046238 File Offset: 0x00044438
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00002849 File Offset: 0x00000A49
		public unsafe static Il2CppReferenceArray<InventoryItem> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamInventory.NativeFieldInfoPtr__Items_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventory.NativeFieldInfoPtr__Items_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00046260 File Offset: 0x00044460
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x0000285B File Offset: 0x00000A5B
		public unsafe static Il2CppReferenceArray<InventoryDef> _Definitions_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamInventory.NativeFieldInfoPtr__Definitions_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryDef>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventory.NativeFieldInfoPtr__Definitions_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00046288 File Offset: 0x00044488
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x0000286D File Offset: 0x00000A6D
		public unsafe static Dictionary<int, InventoryDef> _defMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamInventory.NativeFieldInfoPtr__defMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, InventoryDef>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventory.NativeFieldInfoPtr__defMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeFieldInfoPtr_OnInventoryUpdated;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeFieldInfoPtr_OnDefinitionsUpdated;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeFieldInfoPtr__Currency_k__BackingField;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeFieldInfoPtr__Definitions_k__BackingField;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeFieldInfoPtr__defMap;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamInventory_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_InventoryUpdated_Private_Static_Void_SteamInventoryFullUpdate_t_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_add_OnInventoryUpdated_Public_Static_add_Void_Action_1_InventoryResult_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnInventoryUpdated_Public_Static_rem_Void_Action_1_InventoryResult_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDefinitionsUpdated_Public_Static_add_Void_Action_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDefinitionsUpdated_Public_Static_rem_Void_Action_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefinitions_Private_Static_Void_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Void_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_WaitForDefinitions_Public_Static_Task_1_Boolean_Single_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_FindDefinition_Public_Static_InventoryDef_InventoryDefId_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_get_Currency_Public_Static_get_String_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_set_Currency_Internal_Static_set_Void_String_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_GetDefinitionsWithPricesAsync_Public_Static_Task_1_Il2CppReferenceArray_1_InventoryDef_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Static_get_Il2CppReferenceArray_1_InventoryItem_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Internal_Static_set_Void_Il2CppReferenceArray_1_InventoryItem_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_get_Definitions_Public_Static_get_Il2CppReferenceArray_1_InventoryDef_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_set_Definitions_Internal_Static_set_Void_Il2CppReferenceArray_1_InventoryDef_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_GetDefinitions_Internal_Static_Il2CppReferenceArray_1_InventoryDef_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_0;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItemsAsync_Public_Static_Task_1_Nullable_1_InventoryResult_0;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr_GenerateItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_InventoryDef_Int32_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr_CraftItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_Il2CppReferenceArray_1_InventoryItem_InventoryDef_0;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_CraftItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_Il2CppReferenceArray_1_Amount_InventoryDef_0;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeAsync_Public_Static_Task_1_Nullable_1_InventoryResult_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_GrantPromoItemsAsync_Public_Static_Task_1_Nullable_1_InventoryResult_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_TriggerItemDropAsync_Public_Static_Task_1_Nullable_1_InventoryResult_InventoryDefId_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItemAsync_Public_Static_Task_1_Nullable_1_InventoryResult_InventoryDefId_0;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr_StartPurchaseAsync_Public_Static_Task_1_Nullable_1_InventoryPurchaseResult_Il2CppReferenceArray_1_InventoryDef_0;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000231 RID: 561
		[ObfuscatedName("Steamworks.SteamInventory+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C58 RID: 7256 RVA: 0x00084770 File Offset: 0x00082970
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr);
				SteamInventory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9");
				SteamInventory.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__3_0");
				SteamInventory.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__3_1");
				SteamInventory.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__19_0");
				SteamInventory.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__29_0");
				SteamInventory.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__33_0");
				SteamInventory.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__33_1");
				SteamInventory.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__34_0");
				SteamInventory.__c.NativeFieldInfoPtr___9__34_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__34_1");
				SteamInventory.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__39_0");
				SteamInventory.__c.NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__39_1");
				SteamInventory.__c.NativeFieldInfoPtr___9__39_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, "<>9__39_2");
				SteamInventory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665555);
				SteamInventory.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_SteamInventoryFullUpdate_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665556);
				SteamInventory.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_SteamInventoryDefinitionUpdate_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665557);
				SteamInventory.__c.NativeMethodInfoPtr__GetDefinitionsWithPricesAsync_b__19_0_Internal_InventoryDef_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665558);
				SteamInventory.__c.NativeMethodInfoPtr__GetDefinitions_b__29_0_Internal_InventoryDef_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665559);
				SteamInventory.__c.NativeMethodInfoPtr__CraftItemAsync_b__33_0_Internal_InventoryItemId_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665560);
				SteamInventory.__c.NativeMethodInfoPtr__CraftItemAsync_b__33_1_Internal_UInt32_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665561);
				SteamInventory.__c.NativeMethodInfoPtr__CraftItemAsync_b__34_0_Internal_InventoryItemId_Amount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665562);
				SteamInventory.__c.NativeMethodInfoPtr__CraftItemAsync_b__34_1_Internal_UInt32_Amount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665563);
				SteamInventory.__c.NativeMethodInfoPtr__StartPurchaseAsync_b__39_0_Internal_InventoryDefId_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665564);
				SteamInventory.__c.NativeMethodInfoPtr__StartPurchaseAsync_b__39_1_Internal_InventoryDefId_IGrouping_2_InventoryDefId_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665565);
				SteamInventory.__c.NativeMethodInfoPtr__StartPurchaseAsync_b__39_2_Internal_UInt32_IGrouping_2_InventoryDefId_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr, 100665566);
			}

			// Token: 0x06001C59 RID: 7257 RVA: 0x0008497C File Offset: 0x00082B7C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C5A RID: 7258 RVA: 0x000849B8 File Offset: 0x00082BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938942, XrefRangeEnd = 938951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_0(SteamInventoryFullUpdate_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_SteamInventoryFullUpdate_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C5B RID: 7259 RVA: 0x000849F8 File Offset: 0x00082BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938951, XrefRangeEnd = 938952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_1(SteamInventoryDefinitionUpdate_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_SteamInventoryDefinitionUpdate_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C5C RID: 7260 RVA: 0x00084A38 File Offset: 0x00082C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938952, XrefRangeEnd = 938956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InventoryDef _GetDefinitionsWithPricesAsync_b__19_0(InventoryDefId x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__GetDefinitionsWithPricesAsync_b__19_0_Internal_InventoryDef_InventoryDefId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr3) : null;
				}
			}

			// Token: 0x06001C5D RID: 7261 RVA: 0x00084A84 File Offset: 0x00082C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938956, XrefRangeEnd = 938960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InventoryDef _GetDefinitions_b__29_0(InventoryDefId x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__GetDefinitions_b__29_0_Internal_InventoryDef_InventoryDefId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr3) : null;
				}
			}

			// Token: 0x06001C5E RID: 7262 RVA: 0x00084AD0 File Offset: 0x00082CD0
			[CallerCount(0)]
			public unsafe InventoryItemId _CraftItemAsync_b__33_0(InventoryItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__CraftItemAsync_b__33_0_Internal_InventoryItemId_InventoryItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C5F RID: 7263 RVA: 0x00084B24 File Offset: 0x00082D24
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _CraftItemAsync_b__33_1(InventoryItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__CraftItemAsync_b__33_1_Internal_UInt32_InventoryItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C60 RID: 7264 RVA: 0x00084B78 File Offset: 0x00082D78
			[CallerCount(0)]
			public unsafe InventoryItemId _CraftItemAsync_b__34_0(InventoryItem.Amount x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__CraftItemAsync_b__34_0_Internal_InventoryItemId_Amount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C61 RID: 7265 RVA: 0x00084BCC File Offset: 0x00082DCC
			[CallerCount(0)]
			public unsafe uint _CraftItemAsync_b__34_1(InventoryItem.Amount x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__CraftItemAsync_b__34_1_Internal_UInt32_Amount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C62 RID: 7266 RVA: 0x00084C20 File Offset: 0x00082E20
			[CallerCount(0)]
			public unsafe InventoryDefId _StartPurchaseAsync_b__39_0(InventoryDef x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__StartPurchaseAsync_b__39_0_Internal_InventoryDefId_InventoryDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C63 RID: 7267 RVA: 0x00084C70 File Offset: 0x00082E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938960, XrefRangeEnd = 938964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InventoryDefId _StartPurchaseAsync_b__39_1(IGrouping<InventoryDefId, InventoryDef> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__StartPurchaseAsync_b__39_1_Internal_InventoryDefId_IGrouping_2_InventoryDefId_InventoryDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C64 RID: 7268 RVA: 0x00084CC0 File Offset: 0x00082EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938964, XrefRangeEnd = 938967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _StartPurchaseAsync_b__39_2(IGrouping<InventoryDefId, InventoryDef> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.__c.NativeMethodInfoPtr__StartPurchaseAsync_b__39_2_Internal_UInt32_IGrouping_2_InventoryDefId_InventoryDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C65 RID: 7269 RVA: 0x00009B0F File Offset: 0x00007D0F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x06001C66 RID: 7270 RVA: 0x00084D10 File Offset: 0x00082F10
			// (set) Token: 0x06001C67 RID: 7271 RVA: 0x00009B18 File Offset: 0x00007D18
			public unsafe static SteamInventory.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamInventory.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x06001C68 RID: 7272 RVA: 0x00084D38 File Offset: 0x00082F38
			// (set) Token: 0x06001C69 RID: 7273 RVA: 0x00009B2A File Offset: 0x00007D2A
			public unsafe static Action<SteamInventoryFullUpdate_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamInventoryFullUpdate_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00084D60 File Offset: 0x00082F60
			// (set) Token: 0x06001C6B RID: 7275 RVA: 0x00009B3C File Offset: 0x00007D3C
			public unsafe static Action<SteamInventoryDefinitionUpdate_t> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamInventoryDefinitionUpdate_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00084D88 File Offset: 0x00082F88
			// (set) Token: 0x06001C6D RID: 7277 RVA: 0x00009B4E File Offset: 0x00007D4E
			public unsafe static Func<InventoryDefId, InventoryDef> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InventoryDefId, InventoryDef>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00084DB0 File Offset: 0x00082FB0
			// (set) Token: 0x06001C6F RID: 7279 RVA: 0x00009B60 File Offset: 0x00007D60
			public unsafe static Func<InventoryDefId, InventoryDef> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InventoryDefId, InventoryDef>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00084DD8 File Offset: 0x00082FD8
			// (set) Token: 0x06001C71 RID: 7281 RVA: 0x00009B72 File Offset: 0x00007D72
			public unsafe static Func<InventoryItem, InventoryItemId> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InventoryItem, InventoryItemId>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00084E00 File Offset: 0x00083000
			// (set) Token: 0x06001C73 RID: 7283 RVA: 0x00009B84 File Offset: 0x00007D84
			public unsafe static Func<InventoryItem, uint> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InventoryItem, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00084E28 File Offset: 0x00083028
			// (set) Token: 0x06001C75 RID: 7285 RVA: 0x00009B96 File Offset: 0x00007D96
			public unsafe static Func<InventoryItem.Amount, InventoryItemId> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InventoryItem.Amount, InventoryItemId>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00084E50 File Offset: 0x00083050
			// (set) Token: 0x06001C77 RID: 7287 RVA: 0x00009BA8 File Offset: 0x00007DA8
			public unsafe static Func<InventoryItem.Amount, uint> __9__34_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__34_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InventoryItem.Amount, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__34_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00084E78 File Offset: 0x00083078
			// (set) Token: 0x06001C79 RID: 7289 RVA: 0x00009BBA File Offset: 0x00007DBA
			public unsafe static Func<InventoryDef, InventoryDefId> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InventoryDef, InventoryDefId>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06001C7A RID: 7290 RVA: 0x00084EA0 File Offset: 0x000830A0
			// (set) Token: 0x06001C7B RID: 7291 RVA: 0x00009BCC File Offset: 0x00007DCC
			public unsafe static Func<IGrouping<InventoryDefId, InventoryDef>, InventoryDefId> __9__39_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__39_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<InventoryDefId, InventoryDef>, InventoryDefId>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__39_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x06001C7C RID: 7292 RVA: 0x00084EC8 File Offset: 0x000830C8
			// (set) Token: 0x06001C7D RID: 7293 RVA: 0x00009BDE File Offset: 0x00007DDE
			public unsafe static Func<IGrouping<InventoryDefId, InventoryDef>, uint> __9__39_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamInventory.__c.NativeFieldInfoPtr___9__39_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<InventoryDefId, InventoryDef>, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamInventory.__c.NativeFieldInfoPtr___9__39_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002099 RID: 8345
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400209A RID: 8346
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400209B RID: 8347
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x0400209C RID: 8348
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x0400209D RID: 8349
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400209E RID: 8350
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x0400209F RID: 8351
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x040020A0 RID: 8352
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x040020A1 RID: 8353
			private static readonly IntPtr NativeFieldInfoPtr___9__34_1;

			// Token: 0x040020A2 RID: 8354
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040020A3 RID: 8355
			private static readonly IntPtr NativeFieldInfoPtr___9__39_1;

			// Token: 0x040020A4 RID: 8356
			private static readonly IntPtr NativeFieldInfoPtr___9__39_2;

			// Token: 0x040020A5 RID: 8357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040020A6 RID: 8358
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_SteamInventoryFullUpdate_t_0;

			// Token: 0x040020A7 RID: 8359
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_SteamInventoryDefinitionUpdate_t_0;

			// Token: 0x040020A8 RID: 8360
			private static readonly IntPtr NativeMethodInfoPtr__GetDefinitionsWithPricesAsync_b__19_0_Internal_InventoryDef_InventoryDefId_0;

			// Token: 0x040020A9 RID: 8361
			private static readonly IntPtr NativeMethodInfoPtr__GetDefinitions_b__29_0_Internal_InventoryDef_InventoryDefId_0;

			// Token: 0x040020AA RID: 8362
			private static readonly IntPtr NativeMethodInfoPtr__CraftItemAsync_b__33_0_Internal_InventoryItemId_InventoryItem_0;

			// Token: 0x040020AB RID: 8363
			private static readonly IntPtr NativeMethodInfoPtr__CraftItemAsync_b__33_1_Internal_UInt32_InventoryItem_0;

			// Token: 0x040020AC RID: 8364
			private static readonly IntPtr NativeMethodInfoPtr__CraftItemAsync_b__34_0_Internal_InventoryItemId_Amount_0;

			// Token: 0x040020AD RID: 8365
			private static readonly IntPtr NativeMethodInfoPtr__CraftItemAsync_b__34_1_Internal_UInt32_Amount_0;

			// Token: 0x040020AE RID: 8366
			private static readonly IntPtr NativeMethodInfoPtr__StartPurchaseAsync_b__39_0_Internal_InventoryDefId_InventoryDef_0;

			// Token: 0x040020AF RID: 8367
			private static readonly IntPtr NativeMethodInfoPtr__StartPurchaseAsync_b__39_1_Internal_InventoryDefId_IGrouping_2_InventoryDefId_InventoryDef_0;

			// Token: 0x040020B0 RID: 8368
			private static readonly IntPtr NativeMethodInfoPtr__StartPurchaseAsync_b__39_2_Internal_UInt32_IGrouping_2_InventoryDefId_InventoryDef_0;
		}

		// Token: 0x02000232 RID: 562
		[ObfuscatedName("Steamworks.SteamInventory+<AddPromoItemAsync>d__38")]
		public sealed class _AddPromoItemAsync_d__38 : ValueType
		{
			// Token: 0x06001C7E RID: 7294 RVA: 0x00084EF0 File Offset: 0x000830F0
			// Note: this type is marked as 'beforefieldinit'.
			static _AddPromoItemAsync_d__38()
			{
				Il2CppClassPointerStore<SteamInventory._AddPromoItemAsync_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<AddPromoItemAsync>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._AddPromoItemAsync_d__38>.NativeClassPtr);
				SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._AddPromoItemAsync_d__38>.NativeClassPtr, "<>1__state");
				SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._AddPromoItemAsync_d__38>.NativeClassPtr, "<>t__builder");
				SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._AddPromoItemAsync_d__38>.NativeClassPtr, "id");
				SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._AddPromoItemAsync_d__38>.NativeClassPtr, "<>u__1");
				SteamInventory._AddPromoItemAsync_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._AddPromoItemAsync_d__38>.NativeClassPtr, 100665567);
				SteamInventory._AddPromoItemAsync_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._AddPromoItemAsync_d__38>.NativeClassPtr, 100665568);
			}

			// Token: 0x06001C7F RID: 7295 RVA: 0x00084F94 File Offset: 0x00083194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938967, XrefRangeEnd = 938998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._AddPromoItemAsync_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C80 RID: 7296 RVA: 0x00084FCC File Offset: 0x000831CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938998, XrefRangeEnd = 939004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._AddPromoItemAsync_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C81 RID: 7297 RVA: 0x00009BF0 File Offset: 0x00007DF0
			public _AddPromoItemAsync_d__38(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C82 RID: 7298 RVA: 0x00009BF9 File Offset: 0x00007DF9
			public _AddPromoItemAsync_d__38()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._AddPromoItemAsync_d__38>.NativeClassPtr))
			{
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06001C83 RID: 7299 RVA: 0x00085014 File Offset: 0x00083214
			// (set) Token: 0x06001C84 RID: 7300 RVA: 0x00009C0B File Offset: 0x00007E0B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0008503C File Offset: 0x0008323C
			// (set) Token: 0x06001C86 RID: 7302 RVA: 0x00009C26 File Offset: 0x00007E26
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0008506C File Offset: 0x0008326C
			// (set) Token: 0x06001C88 RID: 7304 RVA: 0x00009C54 File Offset: 0x00007E54
			public unsafe InventoryDefId id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00085094 File Offset: 0x00083294
			// (set) Token: 0x06001C8A RID: 7306 RVA: 0x00009C6F File Offset: 0x00007E6F
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._AddPromoItemAsync_d__38.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020B1 RID: 8369
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020B2 RID: 8370
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020B3 RID: 8371
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040020B4 RID: 8372
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020B5 RID: 8373
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020B6 RID: 8374
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000233 RID: 563
		[ObfuscatedName("Steamworks.SteamInventory+<CraftItemAsync>d__33")]
		public sealed class _CraftItemAsync_d__33 : ValueType
		{
			// Token: 0x06001C8B RID: 7307 RVA: 0x000850C4 File Offset: 0x000832C4
			// Note: this type is marked as 'beforefieldinit'.
			static _CraftItemAsync_d__33()
			{
				Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<CraftItemAsync>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__33>.NativeClassPtr);
				SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__33>.NativeClassPtr, "<>1__state");
				SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__33>.NativeClassPtr, "<>t__builder");
				SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__33>.NativeClassPtr, "target");
				SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__33>.NativeClassPtr, "list");
				SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__33>.NativeClassPtr, "<>u__1");
				SteamInventory._CraftItemAsync_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__33>.NativeClassPtr, 100665569);
				SteamInventory._CraftItemAsync_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__33>.NativeClassPtr, 100665570);
			}

			// Token: 0x06001C8C RID: 7308 RVA: 0x0008517C File Offset: 0x0008337C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939004, XrefRangeEnd = 939084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._CraftItemAsync_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C8D RID: 7309 RVA: 0x000851B4 File Offset: 0x000833B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939084, XrefRangeEnd = 939090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._CraftItemAsync_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C8E RID: 7310 RVA: 0x00009C9D File Offset: 0x00007E9D
			public _CraftItemAsync_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C8F RID: 7311 RVA: 0x00009CA6 File Offset: 0x00007EA6
			public _CraftItemAsync_d__33()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__33>.NativeClassPtr))
			{
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x06001C90 RID: 7312 RVA: 0x000851FC File Offset: 0x000833FC
			// (set) Token: 0x06001C91 RID: 7313 RVA: 0x00009CB8 File Offset: 0x00007EB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00085224 File Offset: 0x00083424
			// (set) Token: 0x06001C93 RID: 7315 RVA: 0x00009CD3 File Offset: 0x00007ED3
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00085254 File Offset: 0x00083454
			// (set) Token: 0x06001C95 RID: 7317 RVA: 0x00009D01 File Offset: 0x00007F01
			public unsafe InventoryDef target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06001C96 RID: 7318 RVA: 0x00085284 File Offset: 0x00083484
			// (set) Token: 0x06001C97 RID: 7319 RVA: 0x00009D20 File Offset: 0x00007F20
			public unsafe Il2CppReferenceArray<InventoryItem> list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryItem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06001C98 RID: 7320 RVA: 0x000852B4 File Offset: 0x000834B4
			// (set) Token: 0x06001C99 RID: 7321 RVA: 0x00009D3F File Offset: 0x00007F3F
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__33.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020B7 RID: 8375
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020B8 RID: 8376
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020B9 RID: 8377
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040020BA RID: 8378
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x040020BB RID: 8379
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020BC RID: 8380
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020BD RID: 8381
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000234 RID: 564
		[ObfuscatedName("Steamworks.SteamInventory+<CraftItemAsync>d__34")]
		public sealed class _CraftItemAsync_d__34 : ValueType
		{
			// Token: 0x06001C9A RID: 7322 RVA: 0x000852E4 File Offset: 0x000834E4
			// Note: this type is marked as 'beforefieldinit'.
			static _CraftItemAsync_d__34()
			{
				Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<CraftItemAsync>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__34>.NativeClassPtr);
				SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__34>.NativeClassPtr, "<>1__state");
				SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__34>.NativeClassPtr, "<>t__builder");
				SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__34>.NativeClassPtr, "target");
				SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__34>.NativeClassPtr, "list");
				SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__34>.NativeClassPtr, "<>u__1");
				SteamInventory._CraftItemAsync_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__34>.NativeClassPtr, 100665571);
				SteamInventory._CraftItemAsync_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__34>.NativeClassPtr, 100665572);
			}

			// Token: 0x06001C9B RID: 7323 RVA: 0x0008539C File Offset: 0x0008359C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939090, XrefRangeEnd = 939170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._CraftItemAsync_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C9C RID: 7324 RVA: 0x000853D4 File Offset: 0x000835D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939170, XrefRangeEnd = 939176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._CraftItemAsync_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C9D RID: 7325 RVA: 0x00009D6D File Offset: 0x00007F6D
			public _CraftItemAsync_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C9E RID: 7326 RVA: 0x00009D76 File Offset: 0x00007F76
			public _CraftItemAsync_d__34()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._CraftItemAsync_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06001C9F RID: 7327 RVA: 0x0008541C File Offset: 0x0008361C
			// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x00009D88 File Offset: 0x00007F88
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x00085444 File Offset: 0x00083644
			// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x00009DA3 File Offset: 0x00007FA3
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x00085474 File Offset: 0x00083674
			// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x00009DD1 File Offset: 0x00007FD1
			public unsafe InventoryDef target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x000854A4 File Offset: 0x000836A4
			// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x00009DF0 File Offset: 0x00007FF0
			public unsafe Il2CppReferenceArray<InventoryItem.Amount> list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryItem.Amount>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x000854D4 File Offset: 0x000836D4
			// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x00009E0F File Offset: 0x0000800F
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._CraftItemAsync_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020BE RID: 8382
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020BF RID: 8383
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020C0 RID: 8384
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040020C1 RID: 8385
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x040020C2 RID: 8386
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020C3 RID: 8387
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020C4 RID: 8388
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000235 RID: 565
		[ObfuscatedName("Steamworks.SteamInventory+<DeserializeAsync>d__35")]
		public sealed class _DeserializeAsync_d__35 : ValueType
		{
			// Token: 0x06001CA9 RID: 7337 RVA: 0x00085504 File Offset: 0x00083704
			// Note: this type is marked as 'beforefieldinit'.
			static _DeserializeAsync_d__35()
			{
				Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<DeserializeAsync>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr);
				SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr, "<>1__state");
				SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr, "<>t__builder");
				SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr, "data");
				SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr_dataLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr, "dataLength");
				SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr__ptr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr, "<ptr>5__2");
				SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr, "<>u__1");
				SteamInventory._DeserializeAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr, 100665573);
				SteamInventory._DeserializeAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr, 100665574);
			}

			// Token: 0x06001CAA RID: 7338 RVA: 0x000855D0 File Offset: 0x000837D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939176, XrefRangeEnd = 939224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._DeserializeAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CAB RID: 7339 RVA: 0x00085608 File Offset: 0x00083808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939224, XrefRangeEnd = 939230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._DeserializeAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CAC RID: 7340 RVA: 0x00009E3D File Offset: 0x0000803D
			public _DeserializeAsync_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CAD RID: 7341 RVA: 0x00009E46 File Offset: 0x00008046
			public _DeserializeAsync_d__35()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._DeserializeAsync_d__35>.NativeClassPtr))
			{
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00085650 File Offset: 0x00083850
			// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00009E58 File Offset: 0x00008058
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00085678 File Offset: 0x00083878
			// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x00009E73 File Offset: 0x00008073
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x000856A8 File Offset: 0x000838A8
			// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00009EA1 File Offset: 0x000080A1
			public unsafe Il2CppStructArray<byte> data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x000856D8 File Offset: 0x000838D8
			// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x00009EC0 File Offset: 0x000080C0
			public unsafe int dataLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr_dataLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr_dataLength)) = value;
				}
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00085700 File Offset: 0x00083900
			// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x00009EDB File Offset: 0x000080DB
			public unsafe IntPtr _ptr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr__ptr_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr__ptr_5__2)) = value;
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00085728 File Offset: 0x00083928
			// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00009EF6 File Offset: 0x000080F6
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._DeserializeAsync_d__35.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020C5 RID: 8389
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020C6 RID: 8390
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020C7 RID: 8391
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040020C8 RID: 8392
			private static readonly IntPtr NativeFieldInfoPtr_dataLength;

			// Token: 0x040020C9 RID: 8393
			private static readonly IntPtr NativeFieldInfoPtr__ptr_5__2;

			// Token: 0x040020CA RID: 8394
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020CB RID: 8395
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020CC RID: 8396
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000236 RID: 566
		[ObfuscatedName("Steamworks.SteamInventory+<GenerateItemAsync>d__32")]
		public sealed class _GenerateItemAsync_d__32 : ValueType
		{
			// Token: 0x06001CBA RID: 7354 RVA: 0x00085758 File Offset: 0x00083958
			// Note: this type is marked as 'beforefieldinit'.
			static _GenerateItemAsync_d__32()
			{
				Il2CppClassPointerStore<SteamInventory._GenerateItemAsync_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<GenerateItemAsync>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._GenerateItemAsync_d__32>.NativeClassPtr);
				SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GenerateItemAsync_d__32>.NativeClassPtr, "<>1__state");
				SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GenerateItemAsync_d__32>.NativeClassPtr, "<>t__builder");
				SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GenerateItemAsync_d__32>.NativeClassPtr, "target");
				SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GenerateItemAsync_d__32>.NativeClassPtr, "amount");
				SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GenerateItemAsync_d__32>.NativeClassPtr, "<>u__1");
				SteamInventory._GenerateItemAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._GenerateItemAsync_d__32>.NativeClassPtr, 100665575);
				SteamInventory._GenerateItemAsync_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._GenerateItemAsync_d__32>.NativeClassPtr, 100665576);
			}

			// Token: 0x06001CBB RID: 7355 RVA: 0x00085810 File Offset: 0x00083A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939230, XrefRangeEnd = 939269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._GenerateItemAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CBC RID: 7356 RVA: 0x00085848 File Offset: 0x00083A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939269, XrefRangeEnd = 939275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._GenerateItemAsync_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CBD RID: 7357 RVA: 0x00009F24 File Offset: 0x00008124
			public _GenerateItemAsync_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CBE RID: 7358 RVA: 0x00009F2D File Offset: 0x0000812D
			public _GenerateItemAsync_d__32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._GenerateItemAsync_d__32>.NativeClassPtr))
			{
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00085890 File Offset: 0x00083A90
			// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x00009F3F File Offset: 0x0000813F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x000858B8 File Offset: 0x00083AB8
			// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x00009F5A File Offset: 0x0000815A
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x000858E8 File Offset: 0x00083AE8
			// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x00009F88 File Offset: 0x00008188
			public unsafe InventoryDef target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00085918 File Offset: 0x00083B18
			// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x00009FA7 File Offset: 0x000081A7
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00085940 File Offset: 0x00083B40
			// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x00009FC2 File Offset: 0x000081C2
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GenerateItemAsync_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020CD RID: 8397
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020CE RID: 8398
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020CF RID: 8399
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040020D0 RID: 8400
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x040020D1 RID: 8401
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020D2 RID: 8402
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020D3 RID: 8403
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000237 RID: 567
		[ObfuscatedName("Steamworks.SteamInventory+<GetAllItemsAsync>d__31")]
		public sealed class _GetAllItemsAsync_d__31 : ValueType
		{
			// Token: 0x06001CC9 RID: 7369 RVA: 0x00085970 File Offset: 0x00083B70
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAllItemsAsync_d__31()
			{
				Il2CppClassPointerStore<SteamInventory._GetAllItemsAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<GetAllItemsAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._GetAllItemsAsync_d__31>.NativeClassPtr);
				SteamInventory._GetAllItemsAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GetAllItemsAsync_d__31>.NativeClassPtr, "<>1__state");
				SteamInventory._GetAllItemsAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GetAllItemsAsync_d__31>.NativeClassPtr, "<>t__builder");
				SteamInventory._GetAllItemsAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GetAllItemsAsync_d__31>.NativeClassPtr, "<>u__1");
				SteamInventory._GetAllItemsAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._GetAllItemsAsync_d__31>.NativeClassPtr, 100665577);
				SteamInventory._GetAllItemsAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._GetAllItemsAsync_d__31>.NativeClassPtr, 100665578);
			}

			// Token: 0x06001CCA RID: 7370 RVA: 0x00085A00 File Offset: 0x00083C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939275, XrefRangeEnd = 939306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._GetAllItemsAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CCB RID: 7371 RVA: 0x00085A38 File Offset: 0x00083C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939306, XrefRangeEnd = 939312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._GetAllItemsAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CCC RID: 7372 RVA: 0x00009FF0 File Offset: 0x000081F0
			public _GetAllItemsAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CCD RID: 7373 RVA: 0x00009FF9 File Offset: 0x000081F9
			public _GetAllItemsAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._GetAllItemsAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00085A80 File Offset: 0x00083C80
			// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0000A00B File Offset: 0x0000820B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetAllItemsAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetAllItemsAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00085AA8 File Offset: 0x00083CA8
			// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0000A026 File Offset: 0x00008226
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetAllItemsAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetAllItemsAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x00085AD8 File Offset: 0x00083CD8
			// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x0000A054 File Offset: 0x00008254
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetAllItemsAsync_d__31.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetAllItemsAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020D4 RID: 8404
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020D5 RID: 8405
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020D6 RID: 8406
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020D7 RID: 8407
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020D8 RID: 8408
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000238 RID: 568
		[ObfuscatedName("Steamworks.SteamInventory+<GetDefinitionsWithPricesAsync>d__19")]
		public sealed class _GetDefinitionsWithPricesAsync_d__19 : ValueType
		{
			// Token: 0x06001CD4 RID: 7380 RVA: 0x00085B08 File Offset: 0x00083D08
			// Note: this type is marked as 'beforefieldinit'.
			static _GetDefinitionsWithPricesAsync_d__19()
			{
				Il2CppClassPointerStore<SteamInventory._GetDefinitionsWithPricesAsync_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<GetDefinitionsWithPricesAsync>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._GetDefinitionsWithPricesAsync_d__19>.NativeClassPtr);
				SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GetDefinitionsWithPricesAsync_d__19>.NativeClassPtr, "<>1__state");
				SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GetDefinitionsWithPricesAsync_d__19>.NativeClassPtr, "<>t__builder");
				SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GetDefinitionsWithPricesAsync_d__19>.NativeClassPtr, "<>u__1");
				SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._GetDefinitionsWithPricesAsync_d__19>.NativeClassPtr, 100665579);
				SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._GetDefinitionsWithPricesAsync_d__19>.NativeClassPtr, 100665580);
			}

			// Token: 0x06001CD5 RID: 7381 RVA: 0x00085B98 File Offset: 0x00083D98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939312, XrefRangeEnd = 939381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CD6 RID: 7382 RVA: 0x00085BD0 File Offset: 0x00083DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939381, XrefRangeEnd = 939387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CD7 RID: 7383 RVA: 0x0000A082 File Offset: 0x00008282
			public _GetDefinitionsWithPricesAsync_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CD8 RID: 7384 RVA: 0x0000A08B File Offset: 0x0000828B
			public _GetDefinitionsWithPricesAsync_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._GetDefinitionsWithPricesAsync_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x00085C18 File Offset: 0x00083E18
			// (set) Token: 0x06001CDA RID: 7386 RVA: 0x0000A09D File Offset: 0x0000829D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00085C40 File Offset: 0x00083E40
			// (set) Token: 0x06001CDC RID: 7388 RVA: 0x0000A0B8 File Offset: 0x000082B8
			public AsyncTaskMethodBuilder<Il2CppReferenceArray<InventoryDef>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppReferenceArray<InventoryDef>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<InventoryDef>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<InventoryDef>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x06001CDD RID: 7389 RVA: 0x00085C70 File Offset: 0x00083E70
			// (set) Token: 0x06001CDE RID: 7390 RVA: 0x0000A0E6 File Offset: 0x000082E6
			public CallResult<SteamInventoryRequestPricesResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeFieldInfoPtr___u__1);
					return new CallResult<SteamInventoryRequestPricesResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<SteamInventoryRequestPricesResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GetDefinitionsWithPricesAsync_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<SteamInventoryRequestPricesResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020D9 RID: 8409
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020DA RID: 8410
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020DB RID: 8411
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020DC RID: 8412
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020DD RID: 8413
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000239 RID: 569
		[ObfuscatedName("Steamworks.SteamInventory+<GrantPromoItemsAsync>d__36")]
		public sealed class _GrantPromoItemsAsync_d__36 : ValueType
		{
			// Token: 0x06001CDF RID: 7391 RVA: 0x00085CA0 File Offset: 0x00083EA0
			// Note: this type is marked as 'beforefieldinit'.
			static _GrantPromoItemsAsync_d__36()
			{
				Il2CppClassPointerStore<SteamInventory._GrantPromoItemsAsync_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<GrantPromoItemsAsync>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._GrantPromoItemsAsync_d__36>.NativeClassPtr);
				SteamInventory._GrantPromoItemsAsync_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GrantPromoItemsAsync_d__36>.NativeClassPtr, "<>1__state");
				SteamInventory._GrantPromoItemsAsync_d__36.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GrantPromoItemsAsync_d__36>.NativeClassPtr, "<>t__builder");
				SteamInventory._GrantPromoItemsAsync_d__36.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._GrantPromoItemsAsync_d__36>.NativeClassPtr, "<>u__1");
				SteamInventory._GrantPromoItemsAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._GrantPromoItemsAsync_d__36>.NativeClassPtr, 100665581);
				SteamInventory._GrantPromoItemsAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._GrantPromoItemsAsync_d__36>.NativeClassPtr, 100665582);
			}

			// Token: 0x06001CE0 RID: 7392 RVA: 0x00085D30 File Offset: 0x00083F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939387, XrefRangeEnd = 939418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._GrantPromoItemsAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CE1 RID: 7393 RVA: 0x00085D68 File Offset: 0x00083F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939418, XrefRangeEnd = 939424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._GrantPromoItemsAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CE2 RID: 7394 RVA: 0x0000A114 File Offset: 0x00008314
			public _GrantPromoItemsAsync_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CE3 RID: 7395 RVA: 0x0000A11D File Offset: 0x0000831D
			public _GrantPromoItemsAsync_d__36()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._GrantPromoItemsAsync_d__36>.NativeClassPtr))
			{
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00085DB0 File Offset: 0x00083FB0
			// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x0000A12F File Offset: 0x0000832F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GrantPromoItemsAsync_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GrantPromoItemsAsync_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00085DD8 File Offset: 0x00083FD8
			// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0000A14A File Offset: 0x0000834A
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GrantPromoItemsAsync_d__36.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GrantPromoItemsAsync_d__36.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x00085E08 File Offset: 0x00084008
			// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x0000A178 File Offset: 0x00008378
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GrantPromoItemsAsync_d__36.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._GrantPromoItemsAsync_d__36.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020DE RID: 8414
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020DF RID: 8415
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020E0 RID: 8416
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020E1 RID: 8417
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020E2 RID: 8418
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200023A RID: 570
		[ObfuscatedName("Steamworks.SteamInventory+<StartPurchaseAsync>d__39")]
		public sealed class _StartPurchaseAsync_d__39 : ValueType
		{
			// Token: 0x06001CEA RID: 7402 RVA: 0x00085E38 File Offset: 0x00084038
			// Note: this type is marked as 'beforefieldinit'.
			static _StartPurchaseAsync_d__39()
			{
				Il2CppClassPointerStore<SteamInventory._StartPurchaseAsync_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<StartPurchaseAsync>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._StartPurchaseAsync_d__39>.NativeClassPtr);
				SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._StartPurchaseAsync_d__39>.NativeClassPtr, "<>1__state");
				SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._StartPurchaseAsync_d__39>.NativeClassPtr, "<>t__builder");
				SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._StartPurchaseAsync_d__39>.NativeClassPtr, "items");
				SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._StartPurchaseAsync_d__39>.NativeClassPtr, "<>u__1");
				SteamInventory._StartPurchaseAsync_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._StartPurchaseAsync_d__39>.NativeClassPtr, 100665583);
				SteamInventory._StartPurchaseAsync_d__39.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._StartPurchaseAsync_d__39>.NativeClassPtr, 100665584);
			}

			// Token: 0x06001CEB RID: 7403 RVA: 0x00085EDC File Offset: 0x000840DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939424, XrefRangeEnd = 939516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._StartPurchaseAsync_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CEC RID: 7404 RVA: 0x00085F14 File Offset: 0x00084114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939516, XrefRangeEnd = 939522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._StartPurchaseAsync_d__39.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CED RID: 7405 RVA: 0x0000A1A6 File Offset: 0x000083A6
			public _StartPurchaseAsync_d__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CEE RID: 7406 RVA: 0x0000A1AF File Offset: 0x000083AF
			public _StartPurchaseAsync_d__39()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._StartPurchaseAsync_d__39>.NativeClassPtr))
			{
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06001CEF RID: 7407 RVA: 0x00085F5C File Offset: 0x0008415C
			// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x0000A1C1 File Offset: 0x000083C1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x00085F84 File Offset: 0x00084184
			// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0000A1DC File Offset: 0x000083DC
			public AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x00085FB4 File Offset: 0x000841B4
			// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x0000A20A File Offset: 0x0000840A
			public unsafe Il2CppReferenceArray<InventoryDef> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryDef>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x00085FE4 File Offset: 0x000841E4
			// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x0000A229 File Offset: 0x00008429
			public CallResult<SteamInventoryStartPurchaseResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr___u__1);
					return new CallResult<SteamInventoryStartPurchaseResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<SteamInventoryStartPurchaseResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._StartPurchaseAsync_d__39.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<SteamInventoryStartPurchaseResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020E3 RID: 8419
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020E4 RID: 8420
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020E5 RID: 8421
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x040020E6 RID: 8422
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020E7 RID: 8423
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020E8 RID: 8424
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200023B RID: 571
		[ObfuscatedName("Steamworks.SteamInventory+<TriggerItemDropAsync>d__37")]
		public sealed class _TriggerItemDropAsync_d__37 : ValueType
		{
			// Token: 0x06001CF7 RID: 7415 RVA: 0x00086014 File Offset: 0x00084214
			// Note: this type is marked as 'beforefieldinit'.
			static _TriggerItemDropAsync_d__37()
			{
				Il2CppClassPointerStore<SteamInventory._TriggerItemDropAsync_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<TriggerItemDropAsync>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._TriggerItemDropAsync_d__37>.NativeClassPtr);
				SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._TriggerItemDropAsync_d__37>.NativeClassPtr, "<>1__state");
				SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._TriggerItemDropAsync_d__37>.NativeClassPtr, "<>t__builder");
				SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._TriggerItemDropAsync_d__37>.NativeClassPtr, "id");
				SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._TriggerItemDropAsync_d__37>.NativeClassPtr, "<>u__1");
				SteamInventory._TriggerItemDropAsync_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._TriggerItemDropAsync_d__37>.NativeClassPtr, 100665585);
				SteamInventory._TriggerItemDropAsync_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._TriggerItemDropAsync_d__37>.NativeClassPtr, 100665586);
			}

			// Token: 0x06001CF8 RID: 7416 RVA: 0x000860B8 File Offset: 0x000842B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939522, XrefRangeEnd = 939553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._TriggerItemDropAsync_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CF9 RID: 7417 RVA: 0x000860F0 File Offset: 0x000842F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939553, XrefRangeEnd = 939559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._TriggerItemDropAsync_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CFA RID: 7418 RVA: 0x0000A257 File Offset: 0x00008457
			public _TriggerItemDropAsync_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CFB RID: 7419 RVA: 0x0000A260 File Offset: 0x00008460
			public _TriggerItemDropAsync_d__37()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._TriggerItemDropAsync_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00086138 File Offset: 0x00084338
			// (set) Token: 0x06001CFD RID: 7421 RVA: 0x0000A272 File Offset: 0x00008472
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06001CFE RID: 7422 RVA: 0x00086160 File Offset: 0x00084360
			// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0000A28D File Offset: 0x0000848D
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00086190 File Offset: 0x00084390
			// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0000A2BB File Offset: 0x000084BB
			public unsafe InventoryDefId id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x06001D02 RID: 7426 RVA: 0x000861B8 File Offset: 0x000843B8
			// (set) Token: 0x06001D03 RID: 7427 RVA: 0x0000A2D6 File Offset: 0x000084D6
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._TriggerItemDropAsync_d__37.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020E9 RID: 8425
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020EA RID: 8426
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020EB RID: 8427
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040020EC RID: 8428
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020ED RID: 8429
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020EE RID: 8430
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200023C RID: 572
		[ObfuscatedName("Steamworks.SteamInventory+<WaitForDefinitions>d__13")]
		public sealed class _WaitForDefinitions_d__13 : ValueType
		{
			// Token: 0x06001D04 RID: 7428 RVA: 0x000861E8 File Offset: 0x000843E8
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForDefinitions_d__13()
			{
				Il2CppClassPointerStore<SteamInventory._WaitForDefinitions_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, "<WaitForDefinitions>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory._WaitForDefinitions_d__13>.NativeClassPtr);
				SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._WaitForDefinitions_d__13>.NativeClassPtr, "<>1__state");
				SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._WaitForDefinitions_d__13>.NativeClassPtr, "<>t__builder");
				SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr_timeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._WaitForDefinitions_d__13>.NativeClassPtr, "timeoutSeconds");
				SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr__sw_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._WaitForDefinitions_d__13>.NativeClassPtr, "<sw>5__2");
				SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventory._WaitForDefinitions_d__13>.NativeClassPtr, "<>u__1");
				SteamInventory._WaitForDefinitions_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._WaitForDefinitions_d__13>.NativeClassPtr, 100665587);
				SteamInventory._WaitForDefinitions_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory._WaitForDefinitions_d__13>.NativeClassPtr, 100665588);
			}

			// Token: 0x06001D05 RID: 7429 RVA: 0x000862A0 File Offset: 0x000844A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939559, XrefRangeEnd = 939607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._WaitForDefinitions_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D06 RID: 7430 RVA: 0x000862D8 File Offset: 0x000844D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939607, XrefRangeEnd = 939613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory._WaitForDefinitions_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D07 RID: 7431 RVA: 0x0000A304 File Offset: 0x00008504
			public _WaitForDefinitions_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D08 RID: 7432 RVA: 0x0000A30D File Offset: 0x0000850D
			public _WaitForDefinitions_d__13()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventory._WaitForDefinitions_d__13>.NativeClassPtr))
			{
			}

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00086320 File Offset: 0x00084520
			// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0000A31F File Offset: 0x0000851F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00086348 File Offset: 0x00084548
			// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0000A33A File Offset: 0x0000853A
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x06001D0D RID: 7437 RVA: 0x00086378 File Offset: 0x00084578
			// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0000A368 File Offset: 0x00008568
			public unsafe float timeoutSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr_timeoutSeconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr_timeoutSeconds)) = value;
				}
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x06001D0F RID: 7439 RVA: 0x000863A0 File Offset: 0x000845A0
			// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0000A383 File Offset: 0x00008583
			public unsafe Stopwatch _sw_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr__sw_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr__sw_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x06001D11 RID: 7441 RVA: 0x000863D0 File Offset: 0x000845D0
			// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0000A3A2 File Offset: 0x000085A2
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventory._WaitForDefinitions_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040020EF RID: 8431
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020F0 RID: 8432
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040020F1 RID: 8433
			private static readonly IntPtr NativeFieldInfoPtr_timeoutSeconds;

			// Token: 0x040020F2 RID: 8434
			private static readonly IntPtr NativeFieldInfoPtr__sw_5__2;

			// Token: 0x040020F3 RID: 8435
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040020F4 RID: 8436
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020F5 RID: 8437
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
