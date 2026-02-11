using System;
using dwd.core.bundles;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace dwd.core.loader.loaders
{
	// Token: 0x0200019F RID: 415
	public sealed class SingleSpriteRequest : Command
	{
		// Token: 0x060017A4 RID: 6052 RVA: 0x00072B24 File Offset: 0x00070D24
		// Note: this type is marked as 'beforefieldinit'.
		static SingleSpriteRequest()
		{
			Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "SingleSpriteRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr);
			SingleSpriteRequest.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, "assetName");
			SingleSpriteRequest.NativeFieldInfoPtr_LoadOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, "LoadOp");
			SingleSpriteRequest.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, "<Status>k__BackingField");
			SingleSpriteRequest.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, "Progress");
			SingleSpriteRequest.NativeFieldInfoPtr__LoadedAssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, "<LoadedAssetName>k__BackingField");
			SingleSpriteRequest.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, "<Asset>k__BackingField");
			SingleSpriteRequest.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, "<State>k__BackingField");
			SingleSpriteRequest.NativeMethodInfoPtr__ctor_Public_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667028);
			SingleSpriteRequest.NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667029);
			SingleSpriteRequest.NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667030);
			SingleSpriteRequest.NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667031);
			SingleSpriteRequest.NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667032);
			SingleSpriteRequest.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667033);
			SingleSpriteRequest.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667034);
			SingleSpriteRequest.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667035);
			SingleSpriteRequest.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667036);
			SingleSpriteRequest.NativeMethodInfoPtr_Cancel_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667037);
			SingleSpriteRequest.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667038);
			SingleSpriteRequest.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667039);
			SingleSpriteRequest.NativeMethodInfoPtr_loadAsset_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667040);
			SingleSpriteRequest.NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, 100667041);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00072CF8 File Offset: 0x00070EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879486, RefRangeEnd = 879487, XrefRangeStart = 879486, XrefRangeEnd = 879487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleSpriteRequest(AssetName assetName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr__ctor_Public_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00072D48 File Offset: 0x00070F48
		// (set) Token: 0x060017A7 RID: 6055 RVA: 0x00072D80 File Offset: 0x00070F80
		public unsafe ErrorInfo Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00072DC8 File Offset: 0x00070FC8
		// (set) Token: 0x060017A9 RID: 6057 RVA: 0x00072E00 File Offset: 0x00071000
		public unsafe AssetName LoadedAssetName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00072E48 File Offset: 0x00071048
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x00072E88 File Offset: 0x00071088
		public unsafe Sprite Asset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x00072ECC File Offset: 0x000710CC
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x00072F08 File Offset: 0x00071108
		public unsafe AssetRequestStates State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00072F48 File Offset: 0x00071148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879488, RefRangeEnd = 879489, XrefRangeStart = 879488, XrefRangeEnd = 879489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_Cancel_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00072F7C File Offset: 0x0007117C
		[CallerCount(0)]
		public unsafe float dwd_core_data_IHasProgress_GetPercent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00072FB8 File Offset: 0x000711B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879561, XrefRangeEnd = 879566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00072FF8 File Offset: 0x000711F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879566, XrefRangeEnd = 879571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator loadAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_loadAsset_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00073038 File Offset: 0x00071238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879571, XrefRangeEnd = 879578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AssignAsset(global::UnityEngine.Object asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest.NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0000A548 File Offset: 0x00008748
		public SingleSpriteRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00073088 File Offset: 0x00071288
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0000A551 File Offset: 0x00008751
		public AssetName assetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr_assetName);
				return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x000730B8 File Offset: 0x000712B8
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0000A57F File Offset: 0x0000877F
		public AsyncOperationHandle<Sprite> LoadOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr_LoadOp);
				return new AsyncOperationHandle<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<Sprite>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr_LoadOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<Sprite>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x000730E8 File Offset: 0x000712E8
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x0000A5AD File Offset: 0x000087AD
		public ErrorInfo _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr__Status_k__BackingField);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr__Status_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x00073118 File Offset: 0x00071318
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x0000A5DB File Offset: 0x000087DB
		public unsafe float Progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr_Progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr_Progress)) = value;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x00073140 File Offset: 0x00071340
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x0000A5F6 File Offset: 0x000087F6
		public AssetName _LoadedAssetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr__LoadedAssetName_k__BackingField);
				return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr__LoadedAssetName_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x00073170 File Offset: 0x00071370
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x0000A624 File Offset: 0x00008824
		public unsafe Sprite _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr__Asset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr__Asset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x000731A0 File Offset: 0x000713A0
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0000A643 File Offset: 0x00008843
		public unsafe AssetRequestStates _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeFieldInfoPtr_assetName;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeFieldInfoPtr_LoadOp;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeFieldInfoPtr_Progress;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeFieldInfoPtr__LoadedAssetName_k__BackingField;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AssetName_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Void_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr_loadAsset_Private_IEnumerator_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0;

		// Token: 0x02000346 RID: 838
		[ObfuscatedName("dwd.core.loader.loaders.SingleSpriteRequest+<execute>d__22")]
		public sealed class _execute_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x06002684 RID: 9860 RVA: 0x000A4484 File Offset: 0x000A2684
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__22()
			{
				Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, "<execute>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr);
				SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr, "<>1__state");
				SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr, "<>2__current");
				SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr, "<>4__this");
				SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr, "<loadAssetEnumerator>5__2");
				SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr, 100667042);
				SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr, 100667043);
				SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr, 100667044);
				SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr, 100667045);
				SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr, 100667046);
				SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr, 100667047);
			}

			// Token: 0x06002685 RID: 9861 RVA: 0x000A4578 File Offset: 0x000A2778
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleSpriteRequest._execute_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002686 RID: 9862 RVA: 0x000A45C0 File Offset: 0x000A27C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002687 RID: 9863 RVA: 0x000A45F4 File Offset: 0x000A27F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879506, XrefRangeEnd = 879520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AE5 RID: 2789
			// (get) Token: 0x06002688 RID: 9864 RVA: 0x000A4630 File Offset: 0x000A2830
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002689 RID: 9865 RVA: 0x000A4670 File Offset: 0x000A2870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879520, XrefRangeEnd = 879525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AE6 RID: 2790
			// (get) Token: 0x0600268A RID: 9866 RVA: 0x000A46A4 File Offset: 0x000A28A4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600268B RID: 9867 RVA: 0x0001185D File Offset: 0x0000FA5D
			public _execute_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AE1 RID: 2785
			// (get) Token: 0x0600268C RID: 9868 RVA: 0x000A46E4 File Offset: 0x000A28E4
			// (set) Token: 0x0600268D RID: 9869 RVA: 0x00011866 File Offset: 0x0000FA66
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AE2 RID: 2786
			// (get) Token: 0x0600268E RID: 9870 RVA: 0x000A470C File Offset: 0x000A290C
			// (set) Token: 0x0600268F RID: 9871 RVA: 0x00011881 File Offset: 0x0000FA81
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE3 RID: 2787
			// (get) Token: 0x06002690 RID: 9872 RVA: 0x000A473C File Offset: 0x000A293C
			// (set) Token: 0x06002691 RID: 9873 RVA: 0x000118A0 File Offset: 0x0000FAA0
			public unsafe SingleSpriteRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleSpriteRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE4 RID: 2788
			// (get) Token: 0x06002692 RID: 9874 RVA: 0x000A476C File Offset: 0x000A296C
			// (set) Token: 0x06002693 RID: 9875 RVA: 0x000118BF File Offset: 0x0000FABF
			public unsafe IEnumerator _loadAssetEnumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A32 RID: 6706
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A33 RID: 6707
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A34 RID: 6708
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A35 RID: 6709
			private static readonly IntPtr NativeFieldInfoPtr__loadAssetEnumerator_5__2;

			// Token: 0x04001A36 RID: 6710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A37 RID: 6711
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A38 RID: 6712
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A39 RID: 6713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A3A RID: 6714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A3B RID: 6715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000347 RID: 839
		[ObfuscatedName("dwd.core.loader.loaders.SingleSpriteRequest+<loadAsset>d__23")]
		public sealed class _loadAsset_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x06002694 RID: 9876 RVA: 0x000A479C File Offset: 0x000A299C
			// Note: this type is marked as 'beforefieldinit'.
			static _loadAsset_d__23()
			{
				Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SingleSpriteRequest>.NativeClassPtr, "<loadAsset>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr);
				SingleSpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr, "<>1__state");
				SingleSpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr, "<>2__current");
				SingleSpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr, "<>4__this");
				SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667048);
				SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667049);
				SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667050);
				SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667051);
				SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667052);
				SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr, 100667053);
			}

			// Token: 0x06002695 RID: 9877 RVA: 0x000A487C File Offset: 0x000A2A7C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _loadAsset_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleSpriteRequest._loadAsset_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002696 RID: 9878 RVA: 0x000A48C4 File Offset: 0x000A2AC4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002697 RID: 9879 RVA: 0x000A48F8 File Offset: 0x000A2AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879525, XrefRangeEnd = 879556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AEA RID: 2794
			// (get) Token: 0x06002698 RID: 9880 RVA: 0x000A4934 File Offset: 0x000A2B34
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002699 RID: 9881 RVA: 0x000A4974 File Offset: 0x000A2B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879556, XrefRangeEnd = 879561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AEB RID: 2795
			// (get) Token: 0x0600269A RID: 9882 RVA: 0x000A49A8 File Offset: 0x000A2BA8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600269B RID: 9883 RVA: 0x000118DE File Offset: 0x0000FADE
			public _loadAsset_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AE7 RID: 2791
			// (get) Token: 0x0600269C RID: 9884 RVA: 0x000A49E8 File Offset: 0x000A2BE8
			// (set) Token: 0x0600269D RID: 9885 RVA: 0x000118E7 File Offset: 0x0000FAE7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AE8 RID: 2792
			// (get) Token: 0x0600269E RID: 9886 RVA: 0x000A4A10 File Offset: 0x000A2C10
			// (set) Token: 0x0600269F RID: 9887 RVA: 0x00011902 File Offset: 0x0000FB02
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE9 RID: 2793
			// (get) Token: 0x060026A0 RID: 9888 RVA: 0x000A4A40 File Offset: 0x000A2C40
			// (set) Token: 0x060026A1 RID: 9889 RVA: 0x00011921 File Offset: 0x0000FB21
			public unsafe SingleSpriteRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleSpriteRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteRequest._loadAsset_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A3C RID: 6716
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A3D RID: 6717
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A3E RID: 6718
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A3F RID: 6719
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A40 RID: 6720
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A41 RID: 6721
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A42 RID: 6722
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A43 RID: 6723
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A44 RID: 6724
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
