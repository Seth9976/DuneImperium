using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000096 RID: 150
	public class ProbeVolumePerSceneData : MonoBehaviour
	{
		// Token: 0x06000B28 RID: 2856 RVA: 0x00035B04 File Offset: 0x00033D04
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeVolumePerSceneData()
		{
			Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumePerSceneData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr);
			ProbeVolumePerSceneData.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, "asset");
			ProbeVolumePerSceneData.NativeFieldInfoPtr_cellSharedDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, "cellSharedDataAsset");
			ProbeVolumePerSceneData.NativeFieldInfoPtr_cellSupportDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, "cellSupportDataAsset");
			ProbeVolumePerSceneData.NativeFieldInfoPtr_serializedScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, "serializedScenarios");
			ProbeVolumePerSceneData.NativeFieldInfoPtr_scenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, "scenarios");
			ProbeVolumePerSceneData.NativeFieldInfoPtr_assetLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, "assetLoaded");
			ProbeVolumePerSceneData.NativeFieldInfoPtr_activeScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, "activeScenario");
			ProbeVolumePerSceneData.NativeFieldInfoPtr_otherScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, "otherScenario");
			ProbeVolumePerSceneData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100664992);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100664993);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100664994);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_RemoveScenario_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100664995);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_RenameScenario_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100664996);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_ResolveCells_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100664997);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_ResolveSharedCellData_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100664998);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_ResolvePerScenarioCellData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100664999);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_QueueAssetLoading_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100665000);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_QueueAssetRemoval_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100665001);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100665002);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100665003);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_Initialize_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100665004);
			ProbeVolumePerSceneData.NativeMethodInfoPtr_UpdateActiveScenario_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100665005);
			ProbeVolumePerSceneData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, 100665006);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00035D00 File Offset: 0x00033F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969777, XrefRangeEnd = 969797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00035D34 File Offset: 0x00033F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969797, XrefRangeEnd = 969822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00035D68 File Offset: 0x00033F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969822, XrefRangeEnd = 969827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00035D9C File Offset: 0x00033F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969827, XrefRangeEnd = 969831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveScenario(string scenario)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenario);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_RemoveScenario_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00035DE0 File Offset: 0x00033FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969831, XrefRangeEnd = 969840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenameScenario(string scenario, string newName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenario);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_RenameScenario_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00035E34 File Offset: 0x00034034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969840, XrefRangeEnd = 969841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveCells()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_ResolveCells_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00035E70 File Offset: 0x00034070
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 969845, RefRangeEnd = 969848, XrefRangeStart = 969841, XrefRangeEnd = 969845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveSharedCellData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_ResolveSharedCellData_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00035EAC File Offset: 0x000340AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 969856, RefRangeEnd = 969858, XrefRangeStart = 969848, XrefRangeEnd = 969856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolvePerScenarioCellData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_ResolvePerScenarioCellData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00035EE8 File Offset: 0x000340E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 969868, RefRangeEnd = 969871, XrefRangeStart = 969858, XrefRangeEnd = 969868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueAssetLoading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_QueueAssetLoading_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00035F1C File Offset: 0x0003411C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 969883, RefRangeEnd = 969888, XrefRangeStart = 969871, XrefRangeEnd = 969883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueAssetRemoval()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_QueueAssetRemoval_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00035F50 File Offset: 0x00034150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969888, XrefRangeEnd = 969916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00035F84 File Offset: 0x00034184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969916, XrefRangeEnd = 969928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00035FB8 File Offset: 0x000341B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969945, RefRangeEnd = 969946, XrefRangeStart = 969928, XrefRangeEnd = 969945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_Initialize_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00035FEC File Offset: 0x000341EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 969956, RefRangeEnd = 969958, XrefRangeStart = 969946, XrefRangeEnd = 969956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActiveScenario(string activeScenario, string otherScenario)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(activeScenario);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(otherScenario);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr_UpdateActiveScenario_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00036040 File Offset: 0x00034240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969958, XrefRangeEnd = 969973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeVolumePerSceneData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumePerSceneData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00006C60 File Offset: 0x00004E60
		public ProbeVolumePerSceneData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0003607C File Offset: 0x0003427C
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x00006C69 File Offset: 0x00004E69
		public unsafe ProbeVolumeAsset asset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_asset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeVolumeAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_asset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x000360AC File Offset: 0x000342AC
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00006C88 File Offset: 0x00004E88
		public unsafe TextAsset cellSharedDataAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_cellSharedDataAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_cellSharedDataAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x000360DC File Offset: 0x000342DC
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00006CA7 File Offset: 0x00004EA7
		public unsafe TextAsset cellSupportDataAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_cellSupportDataAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_cellSupportDataAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0003610C File Offset: 0x0003430C
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00006CC6 File Offset: 0x00004EC6
		public unsafe List<ProbeVolumePerSceneData.SerializablePerScenarioDataItem> serializedScenarios
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_serializedScenarios);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_serializedScenarios), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0003613C File Offset: 0x0003433C
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00006CE5 File Offset: 0x00004EE5
		public unsafe Dictionary<string, ProbeVolumePerSceneData.PerScenarioData> scenarios
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_scenarios);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ProbeVolumePerSceneData.PerScenarioData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_scenarios), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0003616C File Offset: 0x0003436C
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00006D04 File Offset: 0x00004F04
		public unsafe bool assetLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_assetLoaded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_assetLoaded)) = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00036194 File Offset: 0x00034394
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00006D1F File Offset: 0x00004F1F
		public unsafe string activeScenario
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_activeScenario);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_activeScenario), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000361BC File Offset: 0x000343BC
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00006D3E File Offset: 0x00004F3E
		public unsafe string otherScenario
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_otherScenario);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.NativeFieldInfoPtr_otherScenario), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_asset;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_cellSharedDataAsset;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeFieldInfoPtr_cellSupportDataAsset;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeFieldInfoPtr_serializedScenarios;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeFieldInfoPtr_scenarios;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_assetLoaded;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr_activeScenario;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr_otherScenario;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_RemoveScenario_Internal_Void_String_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_RenameScenario_Internal_Void_String_String_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_ResolveCells_Internal_Boolean_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSharedCellData_Internal_Boolean_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_ResolvePerScenarioCellData_Private_Boolean_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_QueueAssetLoading_Internal_Void_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_QueueAssetRemoval_Internal_Void_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActiveScenario_Internal_Void_String_String_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001D7 RID: 471
		[Serializable]
		public sealed class PerScenarioData : ValueType
		{
			// Token: 0x060019CE RID: 6606 RVA: 0x0006BBB4 File Offset: 0x00069DB4
			// Note: this type is marked as 'beforefieldinit'.
			static PerScenarioData()
			{
				Il2CppClassPointerStore<ProbeVolumePerSceneData.PerScenarioData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, "PerScenarioData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumePerSceneData.PerScenarioData>.NativeClassPtr);
				ProbeVolumePerSceneData.PerScenarioData.NativeFieldInfoPtr_sceneHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData.PerScenarioData>.NativeClassPtr, "sceneHash");
				ProbeVolumePerSceneData.PerScenarioData.NativeFieldInfoPtr_cellDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData.PerScenarioData>.NativeClassPtr, "cellDataAsset");
				ProbeVolumePerSceneData.PerScenarioData.NativeFieldInfoPtr_cellOptionalDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData.PerScenarioData>.NativeClassPtr, "cellOptionalDataAsset");
			}

			// Token: 0x060019CF RID: 6607 RVA: 0x0000CDAC File Offset: 0x0000AFAC
			public PerScenarioData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060019D0 RID: 6608 RVA: 0x0000CDB5 File Offset: 0x0000AFB5
			public PerScenarioData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumePerSceneData.PerScenarioData>.NativeClassPtr))
			{
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x060019D1 RID: 6609 RVA: 0x0006BC1C File Offset: 0x00069E1C
			// (set) Token: 0x060019D2 RID: 6610 RVA: 0x0000CDC7 File Offset: 0x0000AFC7
			public unsafe int sceneHash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.PerScenarioData.NativeFieldInfoPtr_sceneHash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.PerScenarioData.NativeFieldInfoPtr_sceneHash)) = value;
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x060019D3 RID: 6611 RVA: 0x0006BC44 File Offset: 0x00069E44
			// (set) Token: 0x060019D4 RID: 6612 RVA: 0x0000CDE2 File Offset: 0x0000AFE2
			public unsafe TextAsset cellDataAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.PerScenarioData.NativeFieldInfoPtr_cellDataAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.PerScenarioData.NativeFieldInfoPtr_cellDataAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0006BC74 File Offset: 0x00069E74
			// (set) Token: 0x060019D6 RID: 6614 RVA: 0x0000CE01 File Offset: 0x0000B001
			public unsafe TextAsset cellOptionalDataAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.PerScenarioData.NativeFieldInfoPtr_cellOptionalDataAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.PerScenarioData.NativeFieldInfoPtr_cellOptionalDataAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012D6 RID: 4822
			private static readonly IntPtr NativeFieldInfoPtr_sceneHash;

			// Token: 0x040012D7 RID: 4823
			private static readonly IntPtr NativeFieldInfoPtr_cellDataAsset;

			// Token: 0x040012D8 RID: 4824
			private static readonly IntPtr NativeFieldInfoPtr_cellOptionalDataAsset;
		}

		// Token: 0x020001D8 RID: 472
		[Serializable]
		public sealed class SerializablePerScenarioDataItem : ValueType
		{
			// Token: 0x060019D7 RID: 6615 RVA: 0x0006BCA4 File Offset: 0x00069EA4
			// Note: this type is marked as 'beforefieldinit'.
			static SerializablePerScenarioDataItem()
			{
				Il2CppClassPointerStore<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumePerSceneData>.NativeClassPtr, "SerializablePerScenarioDataItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.NativeClassPtr);
				ProbeVolumePerSceneData.SerializablePerScenarioDataItem.NativeFieldInfoPtr_scenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.NativeClassPtr, "scenario");
				ProbeVolumePerSceneData.SerializablePerScenarioDataItem.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.NativeClassPtr, "data");
			}

			// Token: 0x060019D8 RID: 6616 RVA: 0x0000CE20 File Offset: 0x0000B020
			public SerializablePerScenarioDataItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060019D9 RID: 6617 RVA: 0x0000CE29 File Offset: 0x0000B029
			public SerializablePerScenarioDataItem()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.NativeClassPtr))
			{
			}

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x060019DA RID: 6618 RVA: 0x0006BCF8 File Offset: 0x00069EF8
			// (set) Token: 0x060019DB RID: 6619 RVA: 0x0000CE3B File Offset: 0x0000B03B
			public unsafe string scenario
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.SerializablePerScenarioDataItem.NativeFieldInfoPtr_scenario);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.SerializablePerScenarioDataItem.NativeFieldInfoPtr_scenario), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x060019DC RID: 6620 RVA: 0x0006BD20 File Offset: 0x00069F20
			// (set) Token: 0x060019DD RID: 6621 RVA: 0x0000CE5A File Offset: 0x0000B05A
			public ProbeVolumePerSceneData.PerScenarioData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.SerializablePerScenarioDataItem.NativeFieldInfoPtr_data);
					return new ProbeVolumePerSceneData.PerScenarioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeVolumePerSceneData.PerScenarioData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumePerSceneData.SerializablePerScenarioDataItem.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProbeVolumePerSceneData.PerScenarioData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012D9 RID: 4825
			private static readonly IntPtr NativeFieldInfoPtr_scenario;

			// Token: 0x040012DA RID: 4826
			private static readonly IntPtr NativeFieldInfoPtr_data;
		}
	}
}
