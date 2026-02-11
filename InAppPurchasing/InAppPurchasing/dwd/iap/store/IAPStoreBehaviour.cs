using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.async;
using dwd.core.platform.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using lotus;

namespace dwd.iap.store
{
	// Token: 0x02000015 RID: 21
	public class IAPStoreBehaviour : VersionedView<PlatformProvider>
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x0000732C File Offset: 0x0000552C
		// Note: this type is marked as 'beforefieldinit'.
		static IAPStoreBehaviour()
		{
			Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "IAPStoreBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr);
			IAPStoreBehaviour.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "client");
			IAPStoreBehaviour.NativeFieldInfoPtr_productProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "productProvider");
			IAPStoreBehaviour.NativeFieldInfoPtr_storeFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "storeFactory");
			IAPStoreBehaviour.NativeFieldInfoPtr_storeModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "storeModel");
			IAPStoreBehaviour.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "initialized");
			IAPStoreBehaviour.NativeFieldInfoPtr_registeredEventHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "registeredEventHandlers");
			IAPStoreBehaviour.NativeFieldInfoPtr_refreshMissingDataCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "refreshMissingDataCommand");
			IAPStoreBehaviour.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "<Data>k__BackingField");
			IAPStoreBehaviour.NativeMethodInfoPtr_get_Client_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663492);
			IAPStoreBehaviour.NativeMethodInfoPtr_get_CommerceURL_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663493);
			IAPStoreBehaviour.NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663494);
			IAPStoreBehaviour.NativeMethodInfoPtr_get_havePlatformToken_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663495);
			IAPStoreBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663496);
			IAPStoreBehaviour.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663497);
			IAPStoreBehaviour.NativeMethodInfoPtr_ForceRefreshOwnedProducts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663498);
			IAPStoreBehaviour.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663499);
			IAPStoreBehaviour.NativeMethodInfoPtr_initialize_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663500);
			IAPStoreBehaviour.NativeMethodInfoPtr_getCommerceURL_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663501);
			IAPStoreBehaviour.NativeMethodInfoPtr_onStoreModelReceived_Private_Void_IAPStoreModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663502);
			IAPStoreBehaviour.NativeMethodInfoPtr_initializedFailed_Protected_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663503);
			IAPStoreBehaviour.NativeMethodInfoPtr_ReceivedOwnedProducts_Private_Void_HashSet_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663504);
			IAPStoreBehaviour.NativeMethodInfoPtr_FulfillProduct_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663505);
			IAPStoreBehaviour.NativeMethodInfoPtr_waitForAsyncData_Private_IEnumerator_IAsyncData_1_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663506);
			IAPStoreBehaviour.NativeMethodInfoPtr_waitForAsyncData_Private_IEnumerator_IAsyncDataWithInput_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663507);
			IAPStoreBehaviour.NativeMethodInfoPtr_Purchase_Public_Virtual_New_IEnumerator_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663508);
			IAPStoreBehaviour.NativeMethodInfoPtr_RestorePurchases_Public_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663509);
			IAPStoreBehaviour.NativeMethodInfoPtr_UserOwnsProduct_Public_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663510);
			IAPStoreBehaviour.NativeMethodInfoPtr_UserCanAccessProduct_Public_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663511);
			IAPStoreBehaviour.NativeMethodInfoPtr_hasOwnedProducts_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663512);
			IAPStoreBehaviour.NativeMethodInfoPtr_hasLicensedProducts_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663513);
			IAPStoreBehaviour.NativeMethodInfoPtr_get_OwnedProductsReceived_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663514);
			IAPStoreBehaviour.NativeMethodInfoPtr_get_IsStoreDataAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663515);
			IAPStoreBehaviour.NativeMethodInfoPtr_RefreshMissingData_Public_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663516);
			IAPStoreBehaviour.NativeMethodInfoPtr_RunRefreshMissingData_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663517);
			IAPStoreBehaviour.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663518);
			IAPStoreBehaviour.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663519);
			IAPStoreBehaviour.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_IReadOnlyDictionary_2_String_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663520);
			IAPStoreBehaviour.NativeMethodInfoPtr_set_Data_Private_set_Void_IReadOnlyDictionary_2_String_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663521);
			IAPStoreBehaviour.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, 100663522);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00007668 File Offset: 0x00005868
		public unsafe virtual string Client
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_get_Client_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000076A0 File Offset: 0x000058A0
		public unsafe virtual string CommerceURL
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_get_CommerceURL_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000076D8 File Offset: 0x000058D8
		public unsafe virtual string AnonymousClaimToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreBehaviour.NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000771C File Offset: 0x0000591C
		public unsafe bool havePlatformToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200843, XrefRangeEnd = 1200856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_get_havePlatformToken_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007758 File Offset: 0x00005958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200856, XrefRangeEnd = 1200876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007794 File Offset: 0x00005994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200876, XrefRangeEnd = 1200898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreBehaviour.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000077D0 File Offset: 0x000059D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200898, XrefRangeEnd = 1200900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceRefreshOwnedProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_ForceRefreshOwnedProducts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007804 File Offset: 0x00005A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200900, XrefRangeEnd = 1200958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00007838 File Offset: 0x00005A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200958, XrefRangeEnd = 1200963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_initialize_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007878 File Offset: 0x00005A78
		[CallerCount(0)]
		public unsafe virtual string getCommerceURL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreBehaviour.NativeMethodInfoPtr_getCommerceURL_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000078BC File Offset: 0x00005ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200963, XrefRangeEnd = 1200965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onStoreModelReceived(IAPStoreModel storeModel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeModel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_onStoreModelReceived_Private_Void_IAPStoreModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007900 File Offset: 0x00005B00
		[CallerCount(0)]
		public unsafe virtual void initializedFailed(string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreBehaviour.NativeMethodInfoPtr_initializedFailed_Protected_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00007950 File Offset: 0x00005B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200965, XrefRangeEnd = 1200999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivedOwnedProducts(HashSet<IAPProduct> ownedProducts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ownedProducts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_ReceivedOwnedProducts_Private_Void_HashSet_1_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00007994 File Offset: 0x00005B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200999, XrefRangeEnd = 1201031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FulfillProduct(string transactionID, string productID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_FulfillProduct_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000079E8 File Offset: 0x00005BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1201037, RefRangeEnd = 1201038, XrefRangeStart = 1201031, XrefRangeEnd = 1201037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator waitForAsyncData<T>(IAsyncData<T> asyncData, Action<T> onDataReceived)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onDataReceived);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.MethodInfoStoreGeneric_waitForAsyncData_Private_IEnumerator_IAsyncData_1_T_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007A4C File Offset: 0x00005C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1201037, RefRangeEnd = 1201038, XrefRangeStart = 1201037, XrefRangeEnd = 1201038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator waitForAsyncData<T>(IAsyncDataWithInput<T> asyncData, T inputData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncData);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = inputData;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref inputData;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.MethodInfoStoreGeneric_waitForAsyncData_Private_IEnumerator_IAsyncDataWithInput_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007AE4 File Offset: 0x00005CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201038, XrefRangeEnd = 1201045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Purchase(string id, Action onPurchase = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPurchase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreBehaviour.NativeMethodInfoPtr_Purchase_Public_Virtual_New_IEnumerator_String_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007B54 File Offset: 0x00005D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1201053, RefRangeEnd = 1201054, XrefRangeStart = 1201045, XrefRangeEnd = 1201053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IFailable RestorePurchases()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_RestorePurchases_Public_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00007B94 File Offset: 0x00005D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1201069, RefRangeEnd = 1201071, XrefRangeStart = 1201054, XrefRangeEnd = 1201069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UserOwnsProduct(ArchetypeID archID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_UserOwnsProduct_Public_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00007BE4 File Offset: 0x00005DE4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1201086, RefRangeEnd = 1201096, XrefRangeStart = 1201071, XrefRangeEnd = 1201086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UserCanAccessProduct(ArchetypeID archID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_UserCanAccessProduct_Public_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00007C34 File Offset: 0x00005E34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1201103, RefRangeEnd = 1201105, XrefRangeStart = 1201096, XrefRangeEnd = 1201103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool hasOwnedProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_hasOwnedProducts_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00007C70 File Offset: 0x00005E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201105, XrefRangeEnd = 1201110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool hasLicensedProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_hasLicensedProducts_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00007CAC File Offset: 0x00005EAC
		public unsafe bool OwnedProductsReceived
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201110, XrefRangeEnd = 1201114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_get_OwnedProductsReceived_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00007CE8 File Offset: 0x00005EE8
		public unsafe bool IsStoreDataAvailable
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1201117, RefRangeEnd = 1201121, XrefRangeStart = 1201114, XrefRangeEnd = 1201117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_get_IsStoreDataAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00007D24 File Offset: 0x00005F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201121, XrefRangeEnd = 1201129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command RefreshMissingData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_RefreshMissingData_Public_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00007D64 File Offset: 0x00005F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201129, XrefRangeEnd = 1201134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RunRefreshMissingData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_RunRefreshMissingData_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00007DA4 File Offset: 0x00005FA4
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00007DE0 File Offset: 0x00005FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201134, XrefRangeEnd = 1201140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00007E14 File Offset: 0x00006014
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00007E54 File Offset: 0x00006054
		public unsafe virtual IReadOnlyDictionary<string, IAPProduct> Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_IReadOnlyDictionary_2_String_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, IAPProduct>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr_set_Data_Private_set_Void_IReadOnlyDictionary_2_String_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00007E98 File Offset: 0x00006098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1201143, RefRangeEnd = 1201144, XrefRangeStart = 1201140, XrefRangeEnd = 1201143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPStoreBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000026CC File Offset: 0x000008CC
		public IAPStoreBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00007ED4 File Offset: 0x000060D4
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000026D5 File Offset: 0x000008D5
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00007EFC File Offset: 0x000060FC
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000026F4 File Offset: 0x000008F4
		public unsafe DirusProductProvider productProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_productProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirusProductProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_productProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00007F2C File Offset: 0x0000612C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002713 File Offset: 0x00000913
		public unsafe IAPStoreFactory storeFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_storeFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_storeFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00007F5C File Offset: 0x0000615C
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002732 File Offset: 0x00000932
		public unsafe IAPStoreModel storeModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_storeModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_storeModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00007F8C File Offset: 0x0000618C
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002751 File Offset: 0x00000951
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00007FB4 File Offset: 0x000061B4
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0000276C File Offset: 0x0000096C
		public unsafe bool registeredEventHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_registeredEventHandlers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_registeredEventHandlers)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00007FDC File Offset: 0x000061DC
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002787 File Offset: 0x00000987
		public unsafe Command refreshMissingDataCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_refreshMissingDataCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr_refreshMissingDataCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000800C File Offset: 0x0000620C
		// (set) Token: 0x06000125 RID: 293 RVA: 0x000027A6 File Offset: 0x000009A6
		public unsafe IReadOnlyDictionary<string, IAPProduct> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, IAPProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_productProvider;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_storeFactory;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_storeModel;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_registeredEventHandlers;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_refreshMissingDataCommand;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_get_Client_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_get_CommerceURL_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_get_havePlatformToken_Protected_get_Boolean_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_ForceRefreshOwnedProducts_Public_Void_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Private_IEnumerator_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_getCommerceURL_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_onStoreModelReceived_Private_Void_IAPStoreModel_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_initializedFailed_Protected_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedOwnedProducts_Private_Void_HashSet_1_IAPProduct_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_FulfillProduct_Private_Void_String_String_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_waitForAsyncData_Private_IEnumerator_IAsyncData_1_T_Action_1_T_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_waitForAsyncData_Private_IEnumerator_IAsyncDataWithInput_1_T_T_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_New_IEnumerator_String_Action_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_RestorePurchases_Public_IFailable_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_UserOwnsProduct_Public_Boolean_ArchetypeID_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_UserCanAccessProduct_Public_Boolean_ArchetypeID_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_hasOwnedProducts_Private_Boolean_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_hasLicensedProducts_Private_Boolean_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnedProductsReceived_Public_get_Boolean_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStoreDataAvailable_Public_get_Boolean_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_RefreshMissingData_Public_Command_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_RunRefreshMissingData_Private_IEnumerator_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_IReadOnlyDictionary_2_String_IAPProduct_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Private_set_Void_IReadOnlyDictionary_2_String_IAPProduct_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200003A RID: 58
		[ObfuscatedName("dwd.iap.store.IAPStoreBehaviour+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Object
		{
			// Token: 0x06000332 RID: 818 RVA: 0x0000EB48 File Offset: 0x0000CD48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass29_0>.NativeClassPtr);
				IAPStoreBehaviour.__c__DisplayClass29_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass29_0>.NativeClassPtr, "archID");
				IAPStoreBehaviour.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass29_0>.NativeClassPtr, 100663523);
				IAPStoreBehaviour.__c__DisplayClass29_0.NativeMethodInfoPtr__UserOwnsProduct_b__0_Internal_Boolean_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass29_0>.NativeClassPtr, 100663524);
			}

			// Token: 0x06000333 RID: 819 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000334 RID: 820 RVA: 0x0000EBEC File Offset: 0x0000CDEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200776, XrefRangeEnd = 1200781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UserOwnsProduct_b__0(IAPProduct product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.__c__DisplayClass29_0.NativeMethodInfoPtr__UserOwnsProduct_b__0_Internal_Boolean_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00003664 File Offset: 0x00001864
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000336 RID: 822 RVA: 0x0000EC3C File Offset: 0x0000CE3C
			// (set) Token: 0x06000337 RID: 823 RVA: 0x0000366D File Offset: 0x0000186D
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.__c__DisplayClass29_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.__c__DisplayClass29_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000228 RID: 552
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04000229 RID: 553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400022A RID: 554
			private static readonly IntPtr NativeMethodInfoPtr__UserOwnsProduct_b__0_Internal_Boolean_IAPProduct_0;
		}

		// Token: 0x0200003B RID: 59
		[ObfuscatedName("dwd.iap.store.IAPStoreBehaviour+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Object
		{
			// Token: 0x06000338 RID: 824 RVA: 0x0000EC6C File Offset: 0x0000CE6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass30_0>.NativeClassPtr);
				IAPStoreBehaviour.__c__DisplayClass30_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass30_0>.NativeClassPtr, "archID");
				IAPStoreBehaviour.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass30_0>.NativeClassPtr, 100663525);
				IAPStoreBehaviour.__c__DisplayClass30_0.NativeMethodInfoPtr__UserCanAccessProduct_b__0_Internal_Boolean_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass30_0>.NativeClassPtr, 100663526);
			}

			// Token: 0x06000339 RID: 825 RVA: 0x0000ECD4 File Offset: 0x0000CED4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreBehaviour.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0000ED10 File Offset: 0x0000CF10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200781, XrefRangeEnd = 1200786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UserCanAccessProduct_b__0(IAPProduct product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour.__c__DisplayClass30_0.NativeMethodInfoPtr__UserCanAccessProduct_b__0_Internal_Boolean_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600033B RID: 827 RVA: 0x0000368C File Offset: 0x0000188C
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x0600033C RID: 828 RVA: 0x0000ED60 File Offset: 0x0000CF60
			// (set) Token: 0x0600033D RID: 829 RVA: 0x00003695 File Offset: 0x00001895
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.__c__DisplayClass30_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour.__c__DisplayClass30_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400022B RID: 555
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x0400022C RID: 556
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400022D RID: 557
			private static readonly IntPtr NativeMethodInfoPtr__UserCanAccessProduct_b__0_Internal_Boolean_IAPProduct_0;
		}

		// Token: 0x0200003C RID: 60
		[ObfuscatedName("dwd.iap.store.IAPStoreBehaviour+<Purchase>d__27")]
		public sealed class _Purchase_d__27 : Object
		{
			// Token: 0x0600033E RID: 830 RVA: 0x0000ED90 File Offset: 0x0000CF90
			// Note: this type is marked as 'beforefieldinit'.
			static _Purchase_d__27()
			{
				Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "<Purchase>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr);
				IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, "<>1__state");
				IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, "<>2__current");
				IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, "<>4__this");
				IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, "id");
				IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, "onPurchase");
				IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr__purchaseCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, "<purchaseCommand>5__2");
				IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, 100663527);
				IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, 100663528);
				IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, 100663529);
				IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, 100663530);
				IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, 100663531);
				IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr, 100663532);
			}

			// Token: 0x0600033F RID: 831 RVA: 0x0000EEAC File Offset: 0x0000D0AC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Purchase_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreBehaviour._Purchase_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000340 RID: 832 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000341 RID: 833 RVA: 0x0000EF28 File Offset: 0x0000D128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200786, XrefRangeEnd = 1200788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000342 RID: 834 RVA: 0x0000EF64 File Offset: 0x0000D164
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000343 RID: 835 RVA: 0x0000EFA4 File Offset: 0x0000D1A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200788, XrefRangeEnd = 1200793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000344 RID: 836 RVA: 0x0000EFD8 File Offset: 0x0000D1D8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._Purchase_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000345 RID: 837 RVA: 0x000036B4 File Offset: 0x000018B4
			public _Purchase_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000346 RID: 838 RVA: 0x0000F018 File Offset: 0x0000D218
			// (set) Token: 0x06000347 RID: 839 RVA: 0x000036BD File Offset: 0x000018BD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000348 RID: 840 RVA: 0x0000F040 File Offset: 0x0000D240
			// (set) Token: 0x06000349 RID: 841 RVA: 0x000036D8 File Offset: 0x000018D8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x0600034A RID: 842 RVA: 0x0000F070 File Offset: 0x0000D270
			// (set) Token: 0x0600034B RID: 843 RVA: 0x000036F7 File Offset: 0x000018F7
			public unsafe IAPStoreBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x0600034C RID: 844 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
			// (set) Token: 0x0600034D RID: 845 RVA: 0x00003716 File Offset: 0x00001916
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x0600034E RID: 846 RVA: 0x0000F0C8 File Offset: 0x0000D2C8
			// (set) Token: 0x0600034F RID: 847 RVA: 0x00003735 File Offset: 0x00001935
			public unsafe Action onPurchase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr_onPurchase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000350 RID: 848 RVA: 0x0000F0F8 File Offset: 0x0000D2F8
			// (set) Token: 0x06000351 RID: 849 RVA: 0x00003754 File Offset: 0x00001954
			public unsafe PurchaseIAPProductCommand _purchaseCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr__purchaseCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchaseIAPProductCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._Purchase_d__27.NativeFieldInfoPtr__purchaseCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000230 RID: 560
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000231 RID: 561
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04000232 RID: 562
			private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeFieldInfoPtr__purchaseCommand_5__2;

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000236 RID: 566
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000237 RID: 567
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000238 RID: 568
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000239 RID: 569
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200003D RID: 61
		[ObfuscatedName("dwd.iap.store.IAPStoreBehaviour+<RunRefreshMissingData>d__38")]
		public sealed class _RunRefreshMissingData_d__38 : Object
		{
			// Token: 0x06000352 RID: 850 RVA: 0x0000F128 File Offset: 0x0000D328
			// Note: this type is marked as 'beforefieldinit'.
			static _RunRefreshMissingData_d__38()
			{
				Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "<RunRefreshMissingData>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr);
				IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr, "<>1__state");
				IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr, "<>2__current");
				IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr, "<>4__this");
				IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr, 100663533);
				IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr, 100663534);
				IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr, 100663535);
				IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr, 100663536);
				IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr, 100663537);
				IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr, 100663538);
			}

			// Token: 0x06000353 RID: 851 RVA: 0x0000F208 File Offset: 0x0000D408
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunRefreshMissingData_d__38(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreBehaviour._RunRefreshMissingData_d__38>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000354 RID: 852 RVA: 0x0000F250 File Offset: 0x0000D450
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000355 RID: 853 RVA: 0x0000F284 File Offset: 0x0000D484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200793, XrefRangeEnd = 1200798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000356 RID: 854 RVA: 0x0000F2C0 File Offset: 0x0000D4C0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000357 RID: 855 RVA: 0x0000F300 File Offset: 0x0000D500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200798, XrefRangeEnd = 1200803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000358 RID: 856 RVA: 0x0000F334 File Offset: 0x0000D534
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000359 RID: 857 RVA: 0x00003773 File Offset: 0x00001973
			public _RunRefreshMissingData_d__38(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x0600035A RID: 858 RVA: 0x0000F374 File Offset: 0x0000D574
			// (set) Token: 0x0600035B RID: 859 RVA: 0x0000377C File Offset: 0x0000197C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x0600035C RID: 860 RVA: 0x0000F39C File Offset: 0x0000D59C
			// (set) Token: 0x0600035D RID: 861 RVA: 0x00003797 File Offset: 0x00001997
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x0600035E RID: 862 RVA: 0x0000F3CC File Offset: 0x0000D5CC
			// (set) Token: 0x0600035F RID: 863 RVA: 0x000037B6 File Offset: 0x000019B6
			public unsafe IAPStoreBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._RunRefreshMissingData_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400023A RID: 570
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400023B RID: 571
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400023C RID: 572
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400023D RID: 573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400023E RID: 574
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400023F RID: 575
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000240 RID: 576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000241 RID: 577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000242 RID: 578
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200003E RID: 62
		[ObfuscatedName("dwd.iap.store.IAPStoreBehaviour+<initialize>d__19")]
		public sealed class _initialize_d__19 : Object
		{
			// Token: 0x06000360 RID: 864 RVA: 0x0000F3FC File Offset: 0x0000D5FC
			// Note: this type is marked as 'beforefieldinit'.
			static _initialize_d__19()
			{
				Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "<initialize>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr);
				IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr, "<>1__state");
				IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr, "<>2__current");
				IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr, "<>4__this");
				IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr__saveMetadataProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr, "<saveMetadataProvider>5__2");
				IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr, 100663539);
				IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr, 100663540);
				IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr, 100663541);
				IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr, 100663542);
				IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr, 100663543);
				IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr, 100663544);
			}

			// Token: 0x06000361 RID: 865 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _initialize_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreBehaviour._initialize_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000362 RID: 866 RVA: 0x0000F538 File Offset: 0x0000D738
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000363 RID: 867 RVA: 0x0000F56C File Offset: 0x0000D76C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200803, XrefRangeEnd = 1200822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x06000364 RID: 868 RVA: 0x0000F5A8 File Offset: 0x0000D7A8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000365 RID: 869 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200822, XrefRangeEnd = 1200827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000366 RID: 870 RVA: 0x0000F61C File Offset: 0x0000D81C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._initialize_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000367 RID: 871 RVA: 0x000037D5 File Offset: 0x000019D5
			public _initialize_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000368 RID: 872 RVA: 0x0000F65C File Offset: 0x0000D85C
			// (set) Token: 0x06000369 RID: 873 RVA: 0x000037DE File Offset: 0x000019DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x0600036A RID: 874 RVA: 0x0000F684 File Offset: 0x0000D884
			// (set) Token: 0x0600036B RID: 875 RVA: 0x000037F9 File Offset: 0x000019F9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600036C RID: 876 RVA: 0x0000F6B4 File Offset: 0x0000D8B4
			// (set) Token: 0x0600036D RID: 877 RVA: 0x00003818 File Offset: 0x00001A18
			public unsafe IAPStoreBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600036E RID: 878 RVA: 0x0000F6E4 File Offset: 0x0000D8E4
			// (set) Token: 0x0600036F RID: 879 RVA: 0x00003837 File Offset: 0x00001A37
			public unsafe SaveMetaDataProvider _saveMetadataProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr__saveMetadataProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._initialize_d__19.NativeFieldInfoPtr__saveMetadataProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000243 RID: 579
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000244 RID: 580
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000245 RID: 581
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000246 RID: 582
			private static readonly IntPtr NativeFieldInfoPtr__saveMetadataProvider_5__2;

			// Token: 0x04000247 RID: 583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000248 RID: 584
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000249 RID: 585
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400024A RID: 586
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400024B RID: 587
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400024C RID: 588
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200003F RID: 63
		[ObfuscatedName("dwd.iap.store.IAPStoreBehaviour+<waitForAsyncData>d__25`1")]
		public sealed class _waitForAsyncData_d__25<T> : Object
		{
			// Token: 0x06000370 RID: 880 RVA: 0x0000F714 File Offset: 0x0000D914
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForAsyncData_d__25()
			{
				Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "<waitForAsyncData>d__25`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr);
				IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr, "<>1__state");
				IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr, "<>2__current");
				IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr_asyncData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr, "asyncData");
				IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr_onDataReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr, "onDataReceived");
				IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr, 100663545);
				IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr, 100663546);
				IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr, 100663547);
				IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr, 100663548);
				IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr, 100663549);
				IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr, 100663550);
			}

			// Token: 0x06000371 RID: 881 RVA: 0x0000F844 File Offset: 0x0000DA44
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _waitForAsyncData_d__25(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__25<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000372 RID: 882 RVA: 0x0000F88C File Offset: 0x0000DA8C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000373 RID: 883 RVA: 0x0000F8C0 File Offset: 0x0000DAC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200827, XrefRangeEnd = 1200834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000374 RID: 884 RVA: 0x0000F8FC File Offset: 0x0000DAFC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000375 RID: 885 RVA: 0x0000F93C File Offset: 0x0000DB3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000376 RID: 886 RVA: 0x0000F970 File Offset: 0x0000DB70
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000377 RID: 887 RVA: 0x00003856 File Offset: 0x00001A56
			public _waitForAsyncData_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000378 RID: 888 RVA: 0x0000F9B0 File Offset: 0x0000DBB0
			// (set) Token: 0x06000379 RID: 889 RVA: 0x0000385F File Offset: 0x00001A5F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x0600037A RID: 890 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
			// (set) Token: 0x0600037B RID: 891 RVA: 0x0000387A File Offset: 0x00001A7A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x0600037C RID: 892 RVA: 0x0000FA08 File Offset: 0x0000DC08
			// (set) Token: 0x0600037D RID: 893 RVA: 0x00003899 File Offset: 0x00001A99
			public unsafe IAsyncData<T> asyncData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr_asyncData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncData<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr_asyncData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x0600037E RID: 894 RVA: 0x0000FA38 File Offset: 0x0000DC38
			// (set) Token: 0x0600037F RID: 895 RVA: 0x000038B8 File Offset: 0x00001AB8
			public unsafe Action<T> onDataReceived
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr_onDataReceived);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__25<T>.NativeFieldInfoPtr_onDataReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400024D RID: 589
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400024E RID: 590
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400024F RID: 591
			private static readonly IntPtr NativeFieldInfoPtr_asyncData;

			// Token: 0x04000250 RID: 592
			private static readonly IntPtr NativeFieldInfoPtr_onDataReceived;

			// Token: 0x04000251 RID: 593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000252 RID: 594
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000253 RID: 595
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000254 RID: 596
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000255 RID: 597
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000256 RID: 598
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("dwd.iap.store.IAPStoreBehaviour+<waitForAsyncData>d__26`1")]
		public sealed class _waitForAsyncData_d__26<T> : Object
		{
			// Token: 0x06000380 RID: 896 RVA: 0x0000FA68 File Offset: 0x0000DC68
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForAsyncData_d__26()
			{
				Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr, "<waitForAsyncData>d__26`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr);
				IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr, "<>1__state");
				IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr, "<>2__current");
				IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr_asyncData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr, "asyncData");
				IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr_inputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr, "inputData");
				IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr, 100663551);
				IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr, 100663552);
				IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr, 100663553);
				IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr, 100663554);
				IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr, 100663555);
				IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr, 100663556);
			}

			// Token: 0x06000381 RID: 897 RVA: 0x0000FB98 File Offset: 0x0000DD98
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _waitForAsyncData_d__26(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreBehaviour._waitForAsyncData_d__26<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000382 RID: 898 RVA: 0x0000FBE0 File Offset: 0x0000DDE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000383 RID: 899 RVA: 0x0000FC14 File Offset: 0x0000DE14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200834, XrefRangeEnd = 1200843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000384 RID: 900 RVA: 0x0000FC50 File Offset: 0x0000DE50
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000385 RID: 901 RVA: 0x0000FC90 File Offset: 0x0000DE90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000386 RID: 902 RVA: 0x0000FCC4 File Offset: 0x0000DEC4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000387 RID: 903 RVA: 0x000038D7 File Offset: 0x00001AD7
			public _waitForAsyncData_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000388 RID: 904 RVA: 0x0000FD04 File Offset: 0x0000DF04
			// (set) Token: 0x06000389 RID: 905 RVA: 0x000038E0 File Offset: 0x00001AE0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x0600038A RID: 906 RVA: 0x0000FD2C File Offset: 0x0000DF2C
			// (set) Token: 0x0600038B RID: 907 RVA: 0x000038FB File Offset: 0x00001AFB
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x0600038C RID: 908 RVA: 0x0000FD5C File Offset: 0x0000DF5C
			// (set) Token: 0x0600038D RID: 909 RVA: 0x0000391A File Offset: 0x00001B1A
			public unsafe IAsyncDataWithInput<T> asyncData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr_asyncData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncDataWithInput<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr_asyncData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600038E RID: 910 RVA: 0x0000FD8C File Offset: 0x0000DF8C
			// (set) Token: 0x0600038F RID: 911 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
			public unsafe T inputData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr_inputData);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreBehaviour._waitForAsyncData_d__26<T>.NativeFieldInfoPtr_inputData);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04000257 RID: 599
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000258 RID: 600
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000259 RID: 601
			private static readonly IntPtr NativeFieldInfoPtr_asyncData;

			// Token: 0x0400025A RID: 602
			private static readonly IntPtr NativeFieldInfoPtr_inputData;

			// Token: 0x0400025B RID: 603
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400025C RID: 604
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400025D RID: 605
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400025E RID: 606
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400025F RID: 607
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000260 RID: 608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000041 RID: 65
		private sealed class MethodInfoStoreGeneric_waitForAsyncData_Private_IEnumerator_IAsyncData_1_T_Action_1_T_0<T>
		{
			// Token: 0x04000261 RID: 609
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IAPStoreBehaviour.NativeMethodInfoPtr_waitForAsyncData_Private_IEnumerator_IAsyncData_1_T_Action_1_T_0, Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000042 RID: 66
		private sealed class MethodInfoStoreGeneric_waitForAsyncData_Private_IEnumerator_IAsyncDataWithInput_1_T_T_0<T>
		{
			// Token: 0x04000262 RID: 610
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IAPStoreBehaviour.NativeMethodInfoPtr_waitForAsyncData_Private_IEnumerator_IAsyncDataWithInput_1_T_T_0, Il2CppClassPointerStore<IAPStoreBehaviour>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
