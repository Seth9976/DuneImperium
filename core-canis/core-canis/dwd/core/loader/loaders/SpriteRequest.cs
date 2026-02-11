using System;
using dwd.core.bundles;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace dwd.core.loader.loaders
{
	// Token: 0x020001A1 RID: 417
	public sealed class SpriteRequest : Command
	{
		// Token: 0x060017E0 RID: 6112 RVA: 0x0007386C File Offset: 0x00071A6C
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteRequest()
		{
			Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "SpriteRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr);
			SpriteRequest.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, "assetName");
			SpriteRequest.NativeFieldInfoPtr_LoadOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, "LoadOp");
			SpriteRequest.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, "<Status>k__BackingField");
			SpriteRequest.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, "Progress");
			SpriteRequest.NativeFieldInfoPtr__LoadedAssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, "<LoadedAssetName>k__BackingField");
			SpriteRequest.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, "<Asset>k__BackingField");
			SpriteRequest.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, "<State>k__BackingField");
			SpriteRequest.NativeMethodInfoPtr__ctor_Public_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667080);
			SpriteRequest.NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667081);
			SpriteRequest.NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667082);
			SpriteRequest.NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667083);
			SpriteRequest.NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667084);
			SpriteRequest.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667085);
			SpriteRequest.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667086);
			SpriteRequest.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667087);
			SpriteRequest.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667088);
			SpriteRequest.NativeMethodInfoPtr_Cancel_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667089);
			SpriteRequest.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667090);
			SpriteRequest.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667091);
			SpriteRequest.NativeMethodInfoPtr_loadAsset_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667092);
			SpriteRequest.NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, 100667093);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00073A40 File Offset: 0x00071C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879486, RefRangeEnd = 879487, XrefRangeStart = 879486, XrefRangeEnd = 879487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteRequest(AssetName assetName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr__ctor_Public_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00073A90 File Offset: 0x00071C90
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x00073AC8 File Offset: 0x00071CC8
		public unsafe ErrorInfo Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x00073B10 File Offset: 0x00071D10
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x00073B48 File Offset: 0x00071D48
		public unsafe AssetName LoadedAssetName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AssetName(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00073B90 File Offset: 0x00071D90
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x00073BD0 File Offset: 0x00071DD0
		public unsafe Sprite Asset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00073C14 File Offset: 0x00071E14
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x00073C50 File Offset: 0x00071E50
		public unsafe AssetRequestStates State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00073C90 File Offset: 0x00071E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879488, RefRangeEnd = 879489, XrefRangeStart = 879488, XrefRangeEnd = 879489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_Cancel_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00073CC4 File Offset: 0x00071EC4
		[CallerCount(0)]
		public unsafe float dwd_core_data_IHasProgress_GetPercent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00073D00 File Offset: 0x00071F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879705, XrefRangeEnd = 879710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00073D40 File Offset: 0x00071F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879710, XrefRangeEnd = 879715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator loadAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_loadAsset_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00073D80 File Offset: 0x00071F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879715, XrefRangeEnd = 879722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AssignAsset(global::UnityEngine.Object asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest.NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x0000A774 File Offset: 0x00008974
		public SpriteRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x00073DD0 File Offset: 0x00071FD0
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x0000A77D File Offset: 0x0000897D
		public AssetName assetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr_assetName);
				return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x00073E00 File Offset: 0x00072000
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x0000A7AB File Offset: 0x000089AB
		public AsyncOperationHandle<Il2CppReferenceArray<global::UnityEngine.Object>> LoadOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr_LoadOp);
				return new AsyncOperationHandle<Il2CppReferenceArray<global::UnityEngine.Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<Il2CppReferenceArray<global::UnityEngine.Object>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr_LoadOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<Il2CppReferenceArray<global::UnityEngine.Object>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x00073E30 File Offset: 0x00072030
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x0000A7D9 File Offset: 0x000089D9
		public ErrorInfo _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr__Status_k__BackingField);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr__Status_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00073E60 File Offset: 0x00072060
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x0000A807 File Offset: 0x00008A07
		public unsafe float Progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr_Progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr_Progress)) = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x00073E88 File Offset: 0x00072088
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x0000A822 File Offset: 0x00008A22
		public AssetName _LoadedAssetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr__LoadedAssetName_k__BackingField);
				return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr__LoadedAssetName_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00073EB8 File Offset: 0x000720B8
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x0000A850 File Offset: 0x00008A50
		public unsafe Sprite _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr__Asset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr__Asset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x00073EE8 File Offset: 0x000720E8
		// (set) Token: 0x060017FD RID: 6141 RVA: 0x0000A86F File Offset: 0x00008A6F
		public unsafe AssetRequestStates _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeFieldInfoPtr_assetName;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeFieldInfoPtr_LoadOp;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeFieldInfoPtr_Progress;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeFieldInfoPtr__LoadedAssetName_k__BackingField;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AssetName_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Void_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_loadAsset_Private_IEnumerator_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0;

		// Token: 0x0200034A RID: 842
		[ObfuscatedName("dwd.core.loader.loaders.SpriteRequest+<execute>d__22")]
		public sealed class _execute_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x060026C0 RID: 9920 RVA: 0x000A505C File Offset: 0x000A325C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__22()
			{
				Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, "<execute>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr);
				SpriteRequest._execute_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr, "<>1__state");
				SpriteRequest._execute_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr, "<>2__current");
				SpriteRequest._execute_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr, "<>4__this");
				SpriteRequest._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr, "<loadAssetEnumerator>5__2");
				SpriteRequest._execute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr, 100667094);
				SpriteRequest._execute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr, 100667095);
				SpriteRequest._execute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr, 100667096);
				SpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr, 100667097);
				SpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr, 100667098);
				SpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr, 100667099);
			}

			// Token: 0x060026C1 RID: 9921 RVA: 0x000A5150 File Offset: 0x000A3350
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteRequest._execute_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._execute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026C2 RID: 9922 RVA: 0x000A5198 File Offset: 0x000A3398
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._execute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026C3 RID: 9923 RVA: 0x000A51CC File Offset: 0x000A33CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879650, XrefRangeEnd = 879664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._execute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x060026C4 RID: 9924 RVA: 0x000A5208 File Offset: 0x000A3408
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026C5 RID: 9925 RVA: 0x000A5248 File Offset: 0x000A3448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879664, XrefRangeEnd = 879669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AFC RID: 2812
			// (get) Token: 0x060026C6 RID: 9926 RVA: 0x000A527C File Offset: 0x000A347C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026C7 RID: 9927 RVA: 0x00011A23 File Offset: 0x0000FC23
			public _execute_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x060026C8 RID: 9928 RVA: 0x000A52BC File Offset: 0x000A34BC
			// (set) Token: 0x060026C9 RID: 9929 RVA: 0x00011A2C File Offset: 0x0000FC2C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._execute_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._execute_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AF8 RID: 2808
			// (get) Token: 0x060026CA RID: 9930 RVA: 0x000A52E4 File Offset: 0x000A34E4
			// (set) Token: 0x060026CB RID: 9931 RVA: 0x00011A47 File Offset: 0x0000FC47
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._execute_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._execute_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF9 RID: 2809
			// (get) Token: 0x060026CC RID: 9932 RVA: 0x000A5314 File Offset: 0x000A3514
			// (set) Token: 0x060026CD RID: 9933 RVA: 0x00011A66 File Offset: 0x0000FC66
			public unsafe SpriteRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._execute_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._execute_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFA RID: 2810
			// (get) Token: 0x060026CE RID: 9934 RVA: 0x000A5344 File Offset: 0x000A3544
			// (set) Token: 0x060026CF RID: 9935 RVA: 0x00011A85 File Offset: 0x0000FC85
			public unsafe IEnumerator _loadAssetEnumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A58 RID: 6744
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A59 RID: 6745
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A5A RID: 6746
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A5B RID: 6747
			private static readonly IntPtr NativeFieldInfoPtr__loadAssetEnumerator_5__2;

			// Token: 0x04001A5C RID: 6748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A5D RID: 6749
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A5E RID: 6750
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A5F RID: 6751
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A60 RID: 6752
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A61 RID: 6753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200034B RID: 843
		[ObfuscatedName("dwd.core.loader.loaders.SpriteRequest+<loadAsset>d__23")]
		public sealed class _loadAsset_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x060026D0 RID: 9936 RVA: 0x000A5374 File Offset: 0x000A3574
			// Note: this type is marked as 'beforefieldinit'.
			static _loadAsset_d__23()
			{
				Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteRequest>.NativeClassPtr, "<loadAsset>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr);
				SpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr, "<>1__state");
				SpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr, "<>2__current");
				SpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr, "<>4__this");
				SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667100);
				SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667101);
				SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667102);
				SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667103);
				SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667104);
				SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667105);
			}

			// Token: 0x060026D1 RID: 9937 RVA: 0x000A5454 File Offset: 0x000A3654
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _loadAsset_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteRequest._loadAsset_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026D2 RID: 9938 RVA: 0x000A549C File Offset: 0x000A369C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026D3 RID: 9939 RVA: 0x000A54D0 File Offset: 0x000A36D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879669, XrefRangeEnd = 879700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B00 RID: 2816
			// (get) Token: 0x060026D4 RID: 9940 RVA: 0x000A550C File Offset: 0x000A370C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026D5 RID: 9941 RVA: 0x000A554C File Offset: 0x000A374C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879700, XrefRangeEnd = 879705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B01 RID: 2817
			// (get) Token: 0x060026D6 RID: 9942 RVA: 0x000A5580 File Offset: 0x000A3780
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026D7 RID: 9943 RVA: 0x00011AA4 File Offset: 0x0000FCA4
			public _loadAsset_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AFD RID: 2813
			// (get) Token: 0x060026D8 RID: 9944 RVA: 0x000A55C0 File Offset: 0x000A37C0
			// (set) Token: 0x060026D9 RID: 9945 RVA: 0x00011AAD File Offset: 0x0000FCAD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AFE RID: 2814
			// (get) Token: 0x060026DA RID: 9946 RVA: 0x000A55E8 File Offset: 0x000A37E8
			// (set) Token: 0x060026DB RID: 9947 RVA: 0x00011AC8 File Offset: 0x0000FCC8
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFF RID: 2815
			// (get) Token: 0x060026DC RID: 9948 RVA: 0x000A5618 File Offset: 0x000A3818
			// (set) Token: 0x060026DD RID: 9949 RVA: 0x00011AE7 File Offset: 0x0000FCE7
			public unsafe SpriteRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A62 RID: 6754
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A63 RID: 6755
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A64 RID: 6756
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A65 RID: 6757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A66 RID: 6758
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A67 RID: 6759
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A68 RID: 6760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A69 RID: 6761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A6A RID: 6762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
