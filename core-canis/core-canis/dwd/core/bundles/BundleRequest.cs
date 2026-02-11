using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.bundles
{
	// Token: 0x020001FD RID: 509
	public sealed class BundleRequest : Command
	{
		// Token: 0x06001C46 RID: 7238 RVA: 0x000839A0 File Offset: 0x00081BA0
		// Note: this type is marked as 'beforefieldinit'.
		static BundleRequest()
		{
			Il2CppClassPointerStore<BundleRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "BundleRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr);
			BundleRequest.NativeFieldInfoPtr_bundleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, "bundleManager");
			BundleRequest.NativeFieldInfoPtr_errorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, "errorCode");
			BundleRequest.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, "<State>k__BackingField");
			BundleRequest.NativeFieldInfoPtr__request_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, "<request>k__BackingField");
			BundleRequest.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, "priority");
			BundleRequest.NativeFieldInfoPtr_bundleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, "bundleName");
			BundleRequest.NativeMethodInfoPtr__ctor_Public_Void_String_RequestPriority_AssetBundleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667783);
			BundleRequest.NativeMethodInfoPtr_get_Error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667784);
			BundleRequest.NativeMethodInfoPtr_get_Progress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667785);
			BundleRequest.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667786);
			BundleRequest.NativeMethodInfoPtr_get_URL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667787);
			BundleRequest.NativeMethodInfoPtr_get_State_Public_get_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667788);
			BundleRequest.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667789);
			BundleRequest.NativeMethodInfoPtr_get_request_Private_get_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667790);
			BundleRequest.NativeMethodInfoPtr_set_request_Private_set_Void_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667791);
			BundleRequest.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667792);
			BundleRequest.NativeMethodInfoPtr_get_SafeToDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667793);
			BundleRequest.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, 100667794);
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00083B38 File Offset: 0x00081D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885464, XrefRangeEnd = 885470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BundleRequest(string bundleName, RequestPriority priority, AssetBundleManager bundleManager)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bundleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bundleManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr__ctor_Public_Void_String_RequestPriority_AssetBundleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00083BA4 File Offset: 0x00081DA4
		public unsafe string Error
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885470, XrefRangeEnd = 885472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_get_Error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00083BDC File Offset: 0x00081DDC
		public unsafe float Progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885472, XrefRangeEnd = 885478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_get_Progress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00083C18 File Offset: 0x00081E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float dwd_core_data_IHasProgress_GetPercent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00083C54 File Offset: 0x00081E54
		public unsafe string URL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885478, XrefRangeEnd = 885480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_get_URL_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00083C8C File Offset: 0x00081E8C
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x00083CC8 File Offset: 0x00081EC8
		public unsafe AssetRequestStates State
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_get_State_Public_get_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00083D08 File Offset: 0x00081F08
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x00083D48 File Offset: 0x00081F48
		public unsafe AssetBundleRequest request
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_get_request_Private_get_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_set_request_Private_set_Void_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00083D8C File Offset: 0x00081F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885480, XrefRangeEnd = 885485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x00083DCC File Offset: 0x00081FCC
		public unsafe bool SafeToDispose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_get_SafeToDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00083E08 File Offset: 0x00082008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885485, XrefRangeEnd = 885503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0000C2D1 File Offset: 0x0000A4D1
		public BundleRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00083E3C File Offset: 0x0008203C
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x0000C2DA File Offset: 0x0000A4DA
		public unsafe AssetBundleManager bundleManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr_bundleManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr_bundleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00083E6C File Offset: 0x0008206C
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x0000C2F9 File Offset: 0x0000A4F9
		public unsafe string errorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr_errorCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr_errorCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00083E94 File Offset: 0x00082094
		// (set) Token: 0x06001C59 RID: 7257 RVA: 0x0000C318 File Offset: 0x0000A518
		public unsafe AssetRequestStates _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00083EBC File Offset: 0x000820BC
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x0000C333 File Offset: 0x0000A533
		public unsafe AssetBundleRequest _request_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr__request_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr__request_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00083EEC File Offset: 0x000820EC
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x0000C352 File Offset: 0x0000A552
		public unsafe RequestPriority priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00083F14 File Offset: 0x00082114
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0000C36D File Offset: 0x0000A56D
		public unsafe string bundleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr_bundleName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest.NativeFieldInfoPtr_bundleName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeFieldInfoPtr_bundleManager;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeFieldInfoPtr_errorCode;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeFieldInfoPtr__request_k__BackingField;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeFieldInfoPtr_bundleName;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_RequestPriority_AssetBundleManager_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_String_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Public_get_Single_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_get_URL_Public_get_String_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_AssetRequestStates_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_get_request_Private_get_AssetBundleRequest_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_set_request_Private_set_Void_AssetBundleRequest_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr_get_SafeToDispose_Public_get_Boolean_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0200038E RID: 910
		[ObfuscatedName("dwd.core.bundles.BundleRequest+<execute>d__20")]
		public sealed class _execute_d__20 : Object
		{
			// Token: 0x060028AF RID: 10415 RVA: 0x000AB5B4 File Offset: 0x000A97B4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__20()
			{
				Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BundleRequest>.NativeClassPtr, "<execute>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr);
				BundleRequest._execute_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, "<>1__state");
				BundleRequest._execute_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, "<>2__current");
				BundleRequest._execute_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, "<>4__this");
				BundleRequest._execute_d__20.NativeFieldInfoPtr__count_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, "<count>5__2");
				BundleRequest._execute_d__20.NativeFieldInfoPtr__numberOfRepeatAttempts_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, "<numberOfRepeatAttempts>5__3");
				BundleRequest._execute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, 100667795);
				BundleRequest._execute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, 100667796);
				BundleRequest._execute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, 100667797);
				BundleRequest._execute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, 100667798);
				BundleRequest._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, 100667799);
				BundleRequest._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr, 100667800);
			}

			// Token: 0x060028B0 RID: 10416 RVA: 0x000AB6BC File Offset: 0x000A98BC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BundleRequest._execute_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest._execute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028B1 RID: 10417 RVA: 0x000AB704 File Offset: 0x000A9904
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest._execute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028B2 RID: 10418 RVA: 0x000AB738 File Offset: 0x000A9938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885427, XrefRangeEnd = 885459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest._execute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B8D RID: 2957
			// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000AB774 File Offset: 0x000A9974
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest._execute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028B4 RID: 10420 RVA: 0x000AB7B4 File Offset: 0x000A99B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885459, XrefRangeEnd = 885464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B8E RID: 2958
			// (get) Token: 0x060028B5 RID: 10421 RVA: 0x000AB7E8 File Offset: 0x000A99E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleRequest._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028B6 RID: 10422 RVA: 0x000127AA File Offset: 0x000109AA
			public _execute_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x060028B7 RID: 10423 RVA: 0x000AB828 File Offset: 0x000A9A28
			// (set) Token: 0x060028B8 RID: 10424 RVA: 0x000127B3 File Offset: 0x000109B3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest._execute_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest._execute_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B89 RID: 2953
			// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000AB850 File Offset: 0x000A9A50
			// (set) Token: 0x060028BA RID: 10426 RVA: 0x000127CE File Offset: 0x000109CE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest._execute_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest._execute_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B8A RID: 2954
			// (get) Token: 0x060028BB RID: 10427 RVA: 0x000AB880 File Offset: 0x000A9A80
			// (set) Token: 0x060028BC RID: 10428 RVA: 0x000127ED File Offset: 0x000109ED
			public unsafe BundleRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest._execute_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BundleRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest._execute_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B8B RID: 2955
			// (get) Token: 0x060028BD RID: 10429 RVA: 0x000AB8B0 File Offset: 0x000A9AB0
			// (set) Token: 0x060028BE RID: 10430 RVA: 0x0001280C File Offset: 0x00010A0C
			public unsafe int _count_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest._execute_d__20.NativeFieldInfoPtr__count_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest._execute_d__20.NativeFieldInfoPtr__count_5__2)) = value;
				}
			}

			// Token: 0x17000B8C RID: 2956
			// (get) Token: 0x060028BF RID: 10431 RVA: 0x000AB8D8 File Offset: 0x000A9AD8
			// (set) Token: 0x060028C0 RID: 10432 RVA: 0x00012827 File Offset: 0x00010A27
			public unsafe int _numberOfRepeatAttempts_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest._execute_d__20.NativeFieldInfoPtr__numberOfRepeatAttempts_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleRequest._execute_d__20.NativeFieldInfoPtr__numberOfRepeatAttempts_5__3)) = value;
				}
			}

			// Token: 0x04001B93 RID: 7059
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B94 RID: 7060
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B95 RID: 7061
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B96 RID: 7062
			private static readonly IntPtr NativeFieldInfoPtr__count_5__2;

			// Token: 0x04001B97 RID: 7063
			private static readonly IntPtr NativeFieldInfoPtr__numberOfRepeatAttempts_5__3;

			// Token: 0x04001B98 RID: 7064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B99 RID: 7065
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B9A RID: 7066
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B9B RID: 7067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B9C RID: 7068
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B9D RID: 7069
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
