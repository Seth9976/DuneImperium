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
using UnityEngine.U2D;

namespace dwd.core.loader.loaders
{
	// Token: 0x020001A0 RID: 416
	public sealed class SpriteAtlasRequest : Command
	{
		// Token: 0x060017C2 RID: 6082 RVA: 0x000731C8 File Offset: 0x000713C8
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAtlasRequest()
		{
			Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "SpriteAtlasRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr);
			SpriteAtlasRequest.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, "assetName");
			SpriteAtlasRequest.NativeFieldInfoPtr_LoadOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, "LoadOp");
			SpriteAtlasRequest.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, "<Status>k__BackingField");
			SpriteAtlasRequest.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, "Progress");
			SpriteAtlasRequest.NativeFieldInfoPtr__LoadedAssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, "<LoadedAssetName>k__BackingField");
			SpriteAtlasRequest.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, "<Asset>k__BackingField");
			SpriteAtlasRequest.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, "<State>k__BackingField");
			SpriteAtlasRequest.NativeMethodInfoPtr__ctor_Public_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667054);
			SpriteAtlasRequest.NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667055);
			SpriteAtlasRequest.NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667056);
			SpriteAtlasRequest.NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667057);
			SpriteAtlasRequest.NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667058);
			SpriteAtlasRequest.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667059);
			SpriteAtlasRequest.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667060);
			SpriteAtlasRequest.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667061);
			SpriteAtlasRequest.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667062);
			SpriteAtlasRequest.NativeMethodInfoPtr_Cancel_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667063);
			SpriteAtlasRequest.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667064);
			SpriteAtlasRequest.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667065);
			SpriteAtlasRequest.NativeMethodInfoPtr_loadAsset_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667066);
			SpriteAtlasRequest.NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, 100667067);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0007339C File Offset: 0x0007159C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879486, RefRangeEnd = 879487, XrefRangeStart = 879486, XrefRangeEnd = 879487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteAtlasRequest(AssetName assetName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr__ctor_Public_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x000733EC File Offset: 0x000715EC
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00073424 File Offset: 0x00071624
		public unsafe ErrorInfo Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0007346C File Offset: 0x0007166C
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x000734A4 File Offset: 0x000716A4
		public unsafe AssetName LoadedAssetName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x000734EC File Offset: 0x000716EC
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0007352C File Offset: 0x0007172C
		public unsafe Sprite Asset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x00073570 File Offset: 0x00071770
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x000735AC File Offset: 0x000717AC
		public unsafe AssetRequestStates State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x000735EC File Offset: 0x000717EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879488, RefRangeEnd = 879489, XrefRangeStart = 879488, XrefRangeEnd = 879489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_Cancel_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00073620 File Offset: 0x00071820
		[CallerCount(0)]
		public unsafe float dwd_core_data_IHasProgress_GetPercent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0007365C File Offset: 0x0007185C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879633, XrefRangeEnd = 879638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0007369C File Offset: 0x0007189C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879638, XrefRangeEnd = 879643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator loadAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_loadAsset_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x000736DC File Offset: 0x000718DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879643, XrefRangeEnd = 879650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AssignAsset(global::UnityEngine.Object asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest.NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0000A65E File Offset: 0x0000885E
		public SpriteAtlasRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0007372C File Offset: 0x0007192C
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0000A667 File Offset: 0x00008867
		public AssetName assetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr_assetName);
				return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0007375C File Offset: 0x0007195C
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x0000A695 File Offset: 0x00008895
		public AsyncOperationHandle<SpriteAtlas> LoadOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr_LoadOp);
				return new AsyncOperationHandle<SpriteAtlas>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<SpriteAtlas>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr_LoadOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<SpriteAtlas>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0007378C File Offset: 0x0007198C
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x0000A6C3 File Offset: 0x000088C3
		public ErrorInfo _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr__Status_k__BackingField);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr__Status_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x000737BC File Offset: 0x000719BC
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0000A6F1 File Offset: 0x000088F1
		public unsafe float Progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr_Progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr_Progress)) = value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x000737E4 File Offset: 0x000719E4
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x0000A70C File Offset: 0x0000890C
		public AssetName _LoadedAssetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr__LoadedAssetName_k__BackingField);
				return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr__LoadedAssetName_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x00073814 File Offset: 0x00071A14
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x0000A73A File Offset: 0x0000893A
		public unsafe Sprite _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr__Asset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr__Asset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x00073844 File Offset: 0x00071A44
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x0000A759 File Offset: 0x00008959
		public unsafe AssetRequestStates _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr_assetName;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeFieldInfoPtr_LoadOp;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeFieldInfoPtr_Progress;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeFieldInfoPtr__LoadedAssetName_k__BackingField;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AssetName_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Void_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_loadAsset_Private_IEnumerator_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0;

		// Token: 0x02000348 RID: 840
		[ObfuscatedName("dwd.core.loader.loaders.SpriteAtlasRequest+<execute>d__22")]
		public sealed class _execute_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x060026A2 RID: 9890 RVA: 0x000A4A70 File Offset: 0x000A2C70
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__22()
			{
				Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, "<execute>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr);
				SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr, "<>1__state");
				SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr, "<>2__current");
				SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr, "<>4__this");
				SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr, "<loadAssetEnumerator>5__2");
				SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr, 100667068);
				SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr, 100667069);
				SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr, 100667070);
				SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr, 100667071);
				SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr, 100667072);
				SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr, 100667073);
			}

			// Token: 0x060026A3 RID: 9891 RVA: 0x000A4B64 File Offset: 0x000A2D64
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlasRequest._execute_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026A4 RID: 9892 RVA: 0x000A4BAC File Offset: 0x000A2DAC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026A5 RID: 9893 RVA: 0x000A4BE0 File Offset: 0x000A2DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879578, XrefRangeEnd = 879592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AF0 RID: 2800
			// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000A4C1C File Offset: 0x000A2E1C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026A7 RID: 9895 RVA: 0x000A4C5C File Offset: 0x000A2E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879592, XrefRangeEnd = 879597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AF1 RID: 2801
			// (get) Token: 0x060026A8 RID: 9896 RVA: 0x000A4C90 File Offset: 0x000A2E90
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026A9 RID: 9897 RVA: 0x00011940 File Offset: 0x0000FB40
			public _execute_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AEC RID: 2796
			// (get) Token: 0x060026AA RID: 9898 RVA: 0x000A4CD0 File Offset: 0x000A2ED0
			// (set) Token: 0x060026AB RID: 9899 RVA: 0x00011949 File Offset: 0x0000FB49
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AED RID: 2797
			// (get) Token: 0x060026AC RID: 9900 RVA: 0x000A4CF8 File Offset: 0x000A2EF8
			// (set) Token: 0x060026AD RID: 9901 RVA: 0x00011964 File Offset: 0x0000FB64
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AEE RID: 2798
			// (get) Token: 0x060026AE RID: 9902 RVA: 0x000A4D28 File Offset: 0x000A2F28
			// (set) Token: 0x060026AF RID: 9903 RVA: 0x00011983 File Offset: 0x0000FB83
			public unsafe SpriteAtlasRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAtlasRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AEF RID: 2799
			// (get) Token: 0x060026B0 RID: 9904 RVA: 0x000A4D58 File Offset: 0x000A2F58
			// (set) Token: 0x060026B1 RID: 9905 RVA: 0x000119A2 File Offset: 0x0000FBA2
			public unsafe IEnumerator _loadAssetEnumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A45 RID: 6725
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A46 RID: 6726
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A47 RID: 6727
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A48 RID: 6728
			private static readonly IntPtr NativeFieldInfoPtr__loadAssetEnumerator_5__2;

			// Token: 0x04001A49 RID: 6729
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A4A RID: 6730
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A4B RID: 6731
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A4C RID: 6732
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A4D RID: 6733
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A4E RID: 6734
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000349 RID: 841
		[ObfuscatedName("dwd.core.loader.loaders.SpriteAtlasRequest+<loadAsset>d__23")]
		public sealed class _loadAsset_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x060026B2 RID: 9906 RVA: 0x000A4D88 File Offset: 0x000A2F88
			// Note: this type is marked as 'beforefieldinit'.
			static _loadAsset_d__23()
			{
				Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteAtlasRequest>.NativeClassPtr, "<loadAsset>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr);
				SpriteAtlasRequest._loadAsset_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr, "<>1__state");
				SpriteAtlasRequest._loadAsset_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr, "<>2__current");
				SpriteAtlasRequest._loadAsset_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr, "<>4__this");
				SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr, 100667074);
				SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr, 100667075);
				SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr, 100667076);
				SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr, 100667077);
				SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr, 100667078);
				SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr, 100667079);
			}

			// Token: 0x060026B3 RID: 9907 RVA: 0x000A4E68 File Offset: 0x000A3068
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _loadAsset_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlasRequest._loadAsset_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026B4 RID: 9908 RVA: 0x000A4EB0 File Offset: 0x000A30B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026B5 RID: 9909 RVA: 0x000A4EE4 File Offset: 0x000A30E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879597, XrefRangeEnd = 879628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AF5 RID: 2805
			// (get) Token: 0x060026B6 RID: 9910 RVA: 0x000A4F20 File Offset: 0x000A3120
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026B7 RID: 9911 RVA: 0x000A4F60 File Offset: 0x000A3160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879628, XrefRangeEnd = 879633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AF6 RID: 2806
			// (get) Token: 0x060026B8 RID: 9912 RVA: 0x000A4F94 File Offset: 0x000A3194
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasRequest._loadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026B9 RID: 9913 RVA: 0x000119C1 File Offset: 0x0000FBC1
			public _loadAsset_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AF2 RID: 2802
			// (get) Token: 0x060026BA RID: 9914 RVA: 0x000A4FD4 File Offset: 0x000A31D4
			// (set) Token: 0x060026BB RID: 9915 RVA: 0x000119CA File Offset: 0x0000FBCA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._loadAsset_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._loadAsset_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AF3 RID: 2803
			// (get) Token: 0x060026BC RID: 9916 RVA: 0x000A4FFC File Offset: 0x000A31FC
			// (set) Token: 0x060026BD RID: 9917 RVA: 0x000119E5 File Offset: 0x0000FBE5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._loadAsset_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._loadAsset_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF4 RID: 2804
			// (get) Token: 0x060026BE RID: 9918 RVA: 0x000A502C File Offset: 0x000A322C
			// (set) Token: 0x060026BF RID: 9919 RVA: 0x00011A04 File Offset: 0x0000FC04
			public unsafe SpriteAtlasRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._loadAsset_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAtlasRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasRequest._loadAsset_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A4F RID: 6735
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A50 RID: 6736
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A51 RID: 6737
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A52 RID: 6738
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A53 RID: 6739
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A54 RID: 6740
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A55 RID: 6741
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A56 RID: 6742
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A57 RID: 6743
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
