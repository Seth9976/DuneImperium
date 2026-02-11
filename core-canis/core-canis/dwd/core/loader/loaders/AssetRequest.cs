using System;
using dwd.core.bundles;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace dwd.core.loader.loaders
{
	// Token: 0x0200019E RID: 414
	public sealed class AssetRequest<T> : Command where T : global::UnityEngine.Object
	{
		// Token: 0x06001786 RID: 6022 RVA: 0x00072374 File Offset: 0x00070574
		// Note: this type is marked as 'beforefieldinit'.
		static AssetRequest()
		{
			Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "AssetRequest`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr);
			AssetRequest<T>.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "assetName");
			AssetRequest<T>.NativeFieldInfoPtr_LoadOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "LoadOp");
			AssetRequest<T>.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<Status>k__BackingField");
			AssetRequest<T>.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "Progress");
			AssetRequest<T>.NativeFieldInfoPtr__LoadedAssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<LoadedAssetName>k__BackingField");
			AssetRequest<T>.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<Asset>k__BackingField");
			AssetRequest<T>.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<State>k__BackingField");
			AssetRequest<T>.NativeMethodInfoPtr__ctor_Public_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667002);
			AssetRequest<T>.NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667003);
			AssetRequest<T>.NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667004);
			AssetRequest<T>.NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667005);
			AssetRequest<T>.NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667006);
			AssetRequest<T>.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667007);
			AssetRequest<T>.NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667008);
			AssetRequest<T>.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667009);
			AssetRequest<T>.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667010);
			AssetRequest<T>.NativeMethodInfoPtr_Cancel_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667011);
			AssetRequest<T>.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667012);
			AssetRequest<T>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667013);
			AssetRequest<T>.NativeMethodInfoPtr_LoadAsset_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667014);
			AssetRequest<T>.NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, 100667015);
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00072584 File Offset: 0x00070784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879486, RefRangeEnd = 879487, XrefRangeStart = 879484, XrefRangeEnd = 879486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetRequest(AssetName assetName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr__ctor_Public_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x000725D4 File Offset: 0x000707D4
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x0007260C File Offset: 0x0007080C
		public unsafe ErrorInfo Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879487, XrefRangeEnd = 879488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x00072654 File Offset: 0x00070854
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x0007268C File Offset: 0x0007088C
		public unsafe AssetName LoadedAssetName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x000726D4 File Offset: 0x000708D4
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x00072710 File Offset: 0x00070910
		public unsafe T Asset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00072788 File Offset: 0x00070988
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x000727C4 File Offset: 0x000709C4
		public unsafe AssetRequestStates State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00072804 File Offset: 0x00070A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879488, RefRangeEnd = 879489, XrefRangeStart = 879488, XrefRangeEnd = 879488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_Cancel_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00072838 File Offset: 0x00070A38
		[CallerCount(0)]
		public unsafe float dwd_core_data_IHasProgress_GetPercent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00072874 File Offset: 0x00070A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 723627, RefRangeEnd = 723628, XrefRangeStart = 723627, XrefRangeEnd = 723628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000728B4 File Offset: 0x00070AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879493, RefRangeEnd = 879494, XrefRangeStart = 879489, XrefRangeEnd = 879493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_LoadAsset_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x000728F4 File Offset: 0x00070AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879505, RefRangeEnd = 879506, XrefRangeStart = 879494, XrefRangeEnd = 879505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AssignAsset(global::UnityEngine.Object asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>.NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0000A451 File Offset: 0x00008651
		public AssetRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x00072944 File Offset: 0x00070B44
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x0000A45A File Offset: 0x0000865A
		public AssetName assetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_assetName);
				return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x00072974 File Offset: 0x00070B74
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x0000A488 File Offset: 0x00008688
		public AsyncOperationHandle<T> LoadOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_LoadOp);
				return new AsyncOperationHandle<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_LoadOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<T>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x000729A4 File Offset: 0x00070BA4
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x0000A4B6 File Offset: 0x000086B6
		public ErrorInfo _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Status_k__BackingField);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Status_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x000729D4 File Offset: 0x00070BD4
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x0000A4E4 File Offset: 0x000086E4
		public unsafe float Progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_Progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr_Progress)) = value;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x000729FC File Offset: 0x00070BFC
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x0000A4FF File Offset: 0x000086FF
		public AssetName _LoadedAssetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__LoadedAssetName_k__BackingField);
				return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__LoadedAssetName_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00072A2C File Offset: 0x00070C2C
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x00072A54 File Offset: 0x00070C54
		public unsafe T _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Asset_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__Asset_k__BackingField);
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

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00072AFC File Offset: 0x00070CFC
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x0000A52D File Offset: 0x0000872D
		public unsafe AssetRequestStates _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeFieldInfoPtr_assetName;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeFieldInfoPtr_LoadOp;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeFieldInfoPtr_Progress;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeFieldInfoPtr__LoadedAssetName_k__BackingField;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AssetName_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_ErrorInfo_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadedAssetName_Public_get_AssetName_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadedAssetName_Private_set_Void_AssetName_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_AssetRequestStates_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_AssetRequestStates_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Void_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_IHasProgress_GetPercent_Private_Virtual_Final_New_Single_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Private_IEnumerator_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_AssignAsset_Private_Boolean_Object_0;

		// Token: 0x02000344 RID: 836
		[ObfuscatedName("dwd.core.loader.loaders.AssetRequest`1+<LoadAsset>d__23")]
		public sealed class _LoadAsset_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x06002666 RID: 9830 RVA: 0x000A3E20 File Offset: 0x000A2020
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsset_d__23()
			{
				Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<LoadAsset>d__23"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr);
				AssetRequest<T>._LoadAsset_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr, "<>1__state");
				AssetRequest<T>._LoadAsset_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr, "<>2__current");
				AssetRequest<T>._LoadAsset_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr, "<>4__this");
				AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr, 100667016);
				AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr, 100667017);
				AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr, 100667018);
				AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr, 100667019);
				AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr, 100667020);
				AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr, 100667021);
			}

			// Token: 0x06002667 RID: 9831 RVA: 0x000A3F3C File Offset: 0x000A213C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAsset_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetRequest<T>._LoadAsset_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002668 RID: 9832 RVA: 0x000A3F84 File Offset: 0x000A2184
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002669 RID: 9833 RVA: 0x000A3FB8 File Offset: 0x000A21B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879445, XrefRangeEnd = 879474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AD9 RID: 2777
			// (get) Token: 0x0600266A RID: 9834 RVA: 0x000A3FF4 File Offset: 0x000A21F4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600266B RID: 9835 RVA: 0x000A4034 File Offset: 0x000A2234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000ADA RID: 2778
			// (get) Token: 0x0600266C RID: 9836 RVA: 0x000A4068 File Offset: 0x000A2268
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._LoadAsset_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600266D RID: 9837 RVA: 0x0001177A File Offset: 0x0000F97A
			public _LoadAsset_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AD6 RID: 2774
			// (get) Token: 0x0600266E RID: 9838 RVA: 0x000A40A8 File Offset: 0x000A22A8
			// (set) Token: 0x0600266F RID: 9839 RVA: 0x00011783 File Offset: 0x0000F983
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._LoadAsset_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._LoadAsset_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AD7 RID: 2775
			// (get) Token: 0x06002670 RID: 9840 RVA: 0x000A40D0 File Offset: 0x000A22D0
			// (set) Token: 0x06002671 RID: 9841 RVA: 0x0001179E File Offset: 0x0000F99E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._LoadAsset_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._LoadAsset_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD8 RID: 2776
			// (get) Token: 0x06002672 RID: 9842 RVA: 0x000A4100 File Offset: 0x000A2300
			// (set) Token: 0x06002673 RID: 9843 RVA: 0x000117BD File Offset: 0x0000F9BD
			public unsafe AssetRequest<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._LoadAsset_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetRequest<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._LoadAsset_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A1F RID: 6687
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A20 RID: 6688
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A21 RID: 6689
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A22 RID: 6690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A23 RID: 6691
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A24 RID: 6692
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A25 RID: 6693
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A26 RID: 6694
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A27 RID: 6695
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000345 RID: 837
		[ObfuscatedName("dwd.core.loader.loaders.AssetRequest`1+<execute>d__22")]
		public sealed class _execute_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x06002674 RID: 9844 RVA: 0x000A4130 File Offset: 0x000A2330
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__22()
			{
				Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetRequest<T>>.NativeClassPtr, "<execute>d__22"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr);
				AssetRequest<T>._execute_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr, "<>1__state");
				AssetRequest<T>._execute_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr, "<>2__current");
				AssetRequest<T>._execute_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr, "<>4__this");
				AssetRequest<T>._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr, "<loadAssetEnumerator>5__2");
				AssetRequest<T>._execute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr, 100667022);
				AssetRequest<T>._execute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr, 100667023);
				AssetRequest<T>._execute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr, 100667024);
				AssetRequest<T>._execute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr, 100667025);
				AssetRequest<T>._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr, 100667026);
				AssetRequest<T>._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr, 100667027);
			}

			// Token: 0x06002675 RID: 9845 RVA: 0x000A4260 File Offset: 0x000A2460
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetRequest<T>._execute_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002676 RID: 9846 RVA: 0x000A42A8 File Offset: 0x000A24A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002677 RID: 9847 RVA: 0x000A42DC File Offset: 0x000A24DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879474, XrefRangeEnd = 879484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000ADF RID: 2783
			// (get) Token: 0x06002678 RID: 9848 RVA: 0x000A4318 File Offset: 0x000A2518
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002679 RID: 9849 RVA: 0x000A4358 File Offset: 0x000A2558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AE0 RID: 2784
			// (get) Token: 0x0600267A RID: 9850 RVA: 0x000A438C File Offset: 0x000A258C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequest<T>._execute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600267B RID: 9851 RVA: 0x000117DC File Offset: 0x0000F9DC
			public _execute_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ADB RID: 2779
			// (get) Token: 0x0600267C RID: 9852 RVA: 0x000A43CC File Offset: 0x000A25CC
			// (set) Token: 0x0600267D RID: 9853 RVA: 0x000117E5 File Offset: 0x0000F9E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000ADC RID: 2780
			// (get) Token: 0x0600267E RID: 9854 RVA: 0x000A43F4 File Offset: 0x000A25F4
			// (set) Token: 0x0600267F RID: 9855 RVA: 0x00011800 File Offset: 0x0000FA00
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADD RID: 2781
			// (get) Token: 0x06002680 RID: 9856 RVA: 0x000A4424 File Offset: 0x000A2624
			// (set) Token: 0x06002681 RID: 9857 RVA: 0x0001181F File Offset: 0x0000FA1F
			public unsafe AssetRequest<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetRequest<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADE RID: 2782
			// (get) Token: 0x06002682 RID: 9858 RVA: 0x000A4454 File Offset: 0x000A2654
			// (set) Token: 0x06002683 RID: 9859 RVA: 0x0001183E File Offset: 0x0000FA3E
			public unsafe IEnumerator _loadAssetEnumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequest<T>._execute_d__22.NativeFieldInfoPtr__loadAssetEnumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A28 RID: 6696
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A29 RID: 6697
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A2A RID: 6698
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A2B RID: 6699
			private static readonly IntPtr NativeFieldInfoPtr__loadAssetEnumerator_5__2;

			// Token: 0x04001A2C RID: 6700
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A2D RID: 6701
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A2E RID: 6702
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A2F RID: 6703
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A30 RID: 6704
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A31 RID: 6705
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
