using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.SceneManagement;

namespace UnityEngine.Rendering
{
	// Token: 0x02000097 RID: 151
	[Serializable]
	public class ProbeVolumeSceneData : Object
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x000361E4 File Offset: 0x000343E4
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeVolumeSceneData()
		{
			Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeSceneData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr);
			ProbeVolumeSceneData.NativeFieldInfoPtr_s_SceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "s_SceneGUID");
			ProbeVolumeSceneData.NativeFieldInfoPtr_serializedBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "serializedBounds");
			ProbeVolumeSceneData.NativeFieldInfoPtr_serializedHasVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "serializedHasVolumes");
			ProbeVolumeSceneData.NativeFieldInfoPtr_serializedProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "serializedProfiles");
			ProbeVolumeSceneData.NativeFieldInfoPtr_serializedBakeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "serializedBakeSettings");
			ProbeVolumeSceneData.NativeFieldInfoPtr_serializedBakingSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "serializedBakingSets");
			ProbeVolumeSceneData.NativeFieldInfoPtr_parentAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "parentAsset");
			ProbeVolumeSceneData.NativeFieldInfoPtr_parentSceneDataPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "parentSceneDataPropertyName");
			ProbeVolumeSceneData.NativeFieldInfoPtr_sceneBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "sceneBounds");
			ProbeVolumeSceneData.NativeFieldInfoPtr_hasProbeVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "hasProbeVolumes");
			ProbeVolumeSceneData.NativeFieldInfoPtr_sceneProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "sceneProfiles");
			ProbeVolumeSceneData.NativeFieldInfoPtr_sceneBakingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "sceneBakingSettings");
			ProbeVolumeSceneData.NativeFieldInfoPtr_bakingSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "bakingSets");
			ProbeVolumeSceneData.NativeFieldInfoPtr_m_LightingScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "m_LightingScenario");
			ProbeVolumeSceneData.NativeFieldInfoPtr_m_OtherScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "m_OtherScenario");
			ProbeVolumeSceneData.NativeFieldInfoPtr_m_ScenarioBlendingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "m_ScenarioBlendingFactor");
			ProbeVolumeSceneData.NativeMethodInfoPtr_GetSceneGUID_Internal_Static_String_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665007);
			ProbeVolumeSceneData.NativeMethodInfoPtr_get_lightingScenario_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665008);
			ProbeVolumeSceneData.NativeMethodInfoPtr_get_otherScenario_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665009);
			ProbeVolumeSceneData.NativeMethodInfoPtr_get_scenarioBlendingFactor_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665010);
			ProbeVolumeSceneData.NativeMethodInfoPtr_SetActiveScenario_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665011);
			ProbeVolumeSceneData.NativeMethodInfoPtr_BlendLightingScenario_Internal_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665012);
			ProbeVolumeSceneData.NativeMethodInfoPtr__ctor_Public_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665013);
			ProbeVolumeSceneData.NativeMethodInfoPtr_SetParentObject_Public_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665014);
			ProbeVolumeSceneData.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665015);
			ProbeVolumeSceneData.NativeMethodInfoPtr_UpdateBakingSets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665016);
			ProbeVolumeSceneData.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665017);
			ProbeVolumeSceneData.NativeMethodInfoPtr_CreateNewBakingSet_Internal_BakingSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665018);
			ProbeVolumeSceneData.NativeMethodInfoPtr_InitializeBakingSet_Private_Void_BakingSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665019);
			ProbeVolumeSceneData.NativeMethodInfoPtr_InitializeScenarios_Private_Void_BakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665020);
			ProbeVolumeSceneData.NativeMethodInfoPtr_SyncBakingSetSettings_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, 100665021);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00036480 File Offset: 0x00034680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970006, XrefRangeEnd = 970016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSceneGUID(Scene scene)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_GetSceneGUID_Internal_Static_String_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x000364B8 File Offset: 0x000346B8
		public unsafe string lightingScenario
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_get_lightingScenario_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x000364F0 File Offset: 0x000346F0
		public unsafe string otherScenario
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_get_otherScenario_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00036528 File Offset: 0x00034728
		public unsafe float scenarioBlendingFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_get_scenarioBlendingFactor_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00036564 File Offset: 0x00034764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 970055, RefRangeEnd = 970056, XrefRangeStart = 970016, XrefRangeEnd = 970055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveScenario(string scenario)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenario);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_SetActiveScenario_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x000365A8 File Offset: 0x000347A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 970110, RefRangeEnd = 970113, XrefRangeStart = 970056, XrefRangeEnd = 970110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendLightingScenario(string otherScenario, float blendingFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(otherScenario);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendingFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_BlendLightingScenario_Internal_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000365F8 File Offset: 0x000347F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970113, XrefRangeEnd = 970185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeVolumeSceneData(Object parentAsset, string parentSceneDataPropertyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSceneDataPropertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr__ctor_Public_Void_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00036658 File Offset: 0x00034858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970185, XrefRangeEnd = 970188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParentObject(Object parent, string parentSceneDataPropertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSceneDataPropertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_SetParentObject_Public_Void_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000366AC File Offset: 0x000348AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970188, XrefRangeEnd = 970321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000366E0 File Offset: 0x000348E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 970344, RefRangeEnd = 970346, XrefRangeStart = 970321, XrefRangeEnd = 970344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBakingSets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_UpdateBakingSets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00036714 File Offset: 0x00034914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970346, XrefRangeEnd = 970480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00036748 File Offset: 0x00034948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970480, XrefRangeEnd = 970502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeVolumeSceneData.BakingSet CreateNewBakingSet(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_CreateNewBakingSet_Internal_BakingSet_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProbeVolumeSceneData.BakingSet>(intPtr3) : null;
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00036798 File Offset: 0x00034998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 970511, RefRangeEnd = 970513, XrefRangeStart = 970502, XrefRangeEnd = 970511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeBakingSet(ProbeVolumeSceneData.BakingSet set, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_InitializeBakingSet_Private_Void_BakingSet_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x000367EC File Offset: 0x000349EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 970531, RefRangeEnd = 970533, XrefRangeStart = 970513, XrefRangeEnd = 970531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeScenarios(ProbeVolumeSceneData.BakingSet set)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_InitializeScenarios_Private_Void_BakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00036830 File Offset: 0x00034A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 970567, RefRangeEnd = 970568, XrefRangeStart = 970533, XrefRangeEnd = 970567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncBakingSetSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.NativeMethodInfoPtr_SyncBakingSetSettings_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00006D5D File Offset: 0x00004F5D
		public ProbeVolumeSceneData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00036864 File Offset: 0x00034A64
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x00006D66 File Offset: 0x00004F66
		public unsafe static PropertyInfo s_SceneGUID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProbeVolumeSceneData.NativeFieldInfoPtr_s_SceneGUID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeVolumeSceneData.NativeFieldInfoPtr_s_SceneGUID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0003688C File Offset: 0x00034A8C
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x00006D78 File Offset: 0x00004F78
		public unsafe List<ProbeVolumeSceneData.SerializableBoundItem> serializedBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_serializedBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeVolumeSceneData.SerializableBoundItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_serializedBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x000368BC File Offset: 0x00034ABC
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x00006D97 File Offset: 0x00004F97
		public unsafe List<ProbeVolumeSceneData.SerializableHasPVItem> serializedHasVolumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_serializedHasVolumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeVolumeSceneData.SerializableHasPVItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_serializedHasVolumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x000368EC File Offset: 0x00034AEC
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00006DB6 File Offset: 0x00004FB6
		public unsafe List<ProbeVolumeSceneData.SerializablePVProfile> serializedProfiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_serializedProfiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeVolumeSceneData.SerializablePVProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_serializedProfiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0003691C File Offset: 0x00034B1C
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x00006DD5 File Offset: 0x00004FD5
		public unsafe List<ProbeVolumeSceneData.SerializablePVBakeSettings> serializedBakeSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_serializedBakeSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeVolumeSceneData.SerializablePVBakeSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_serializedBakeSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0003694C File Offset: 0x00034B4C
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x00006DF4 File Offset: 0x00004FF4
		public unsafe List<ProbeVolumeSceneData.BakingSet> serializedBakingSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_serializedBakingSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeVolumeSceneData.BakingSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_serializedBakingSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0003697C File Offset: 0x00034B7C
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00006E13 File Offset: 0x00005013
		public unsafe Object parentAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_parentAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_parentAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x000369AC File Offset: 0x00034BAC
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x00006E32 File Offset: 0x00005032
		public unsafe string parentSceneDataPropertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_parentSceneDataPropertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_parentSceneDataPropertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x000369D4 File Offset: 0x00034BD4
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00006E51 File Offset: 0x00005051
		public unsafe Dictionary<string, Bounds> sceneBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_sceneBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Bounds>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_sceneBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00036A04 File Offset: 0x00034C04
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x00006E70 File Offset: 0x00005070
		public unsafe Dictionary<string, bool> hasProbeVolumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_hasProbeVolumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_hasProbeVolumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00036A34 File Offset: 0x00034C34
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00006E8F File Offset: 0x0000508F
		public unsafe Dictionary<string, ProbeReferenceVolumeProfile> sceneProfiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_sceneProfiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ProbeReferenceVolumeProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_sceneProfiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00036A64 File Offset: 0x00034C64
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00006EAE File Offset: 0x000050AE
		public unsafe Dictionary<string, ProbeVolumeBakingProcessSettings> sceneBakingSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_sceneBakingSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ProbeVolumeBakingProcessSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_sceneBakingSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00036A94 File Offset: 0x00034C94
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00006ECD File Offset: 0x000050CD
		public unsafe List<ProbeVolumeSceneData.BakingSet> bakingSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_bakingSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeVolumeSceneData.BakingSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_bakingSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00036AC4 File Offset: 0x00034CC4
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00006EEC File Offset: 0x000050EC
		public unsafe string m_LightingScenario
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_m_LightingScenario);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_m_LightingScenario), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00036AEC File Offset: 0x00034CEC
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00006F0B File Offset: 0x0000510B
		public unsafe string m_OtherScenario
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_m_OtherScenario);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_m_OtherScenario), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00036B14 File Offset: 0x00034D14
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x00006F2A File Offset: 0x0000512A
		public unsafe float m_ScenarioBlendingFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_m_ScenarioBlendingFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.NativeFieldInfoPtr_m_ScenarioBlendingFactor)) = value;
			}
		}

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeFieldInfoPtr_s_SceneGUID;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeFieldInfoPtr_serializedBounds;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeFieldInfoPtr_serializedHasVolumes;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeFieldInfoPtr_serializedProfiles;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeFieldInfoPtr_serializedBakeSettings;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeFieldInfoPtr_serializedBakingSets;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeFieldInfoPtr_parentAsset;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeFieldInfoPtr_parentSceneDataPropertyName;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeFieldInfoPtr_sceneBounds;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeFieldInfoPtr_hasProbeVolumes;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeFieldInfoPtr_sceneProfiles;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeFieldInfoPtr_sceneBakingSettings;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeFieldInfoPtr_bakingSets;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeFieldInfoPtr_m_LightingScenario;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherScenario;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeFieldInfoPtr_m_ScenarioBlendingFactor;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneGUID_Internal_Static_String_Scene_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_get_lightingScenario_Internal_get_String_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_get_otherScenario_Internal_get_String_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_get_scenarioBlendingFactor_Internal_get_Single_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveScenario_Internal_Void_String_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_BlendLightingScenario_Internal_Void_String_Single_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_String_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_SetParentObject_Public_Void_Object_String_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBakingSets_Private_Void_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewBakingSet_Internal_BakingSet_String_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBakingSet_Private_Void_BakingSet_String_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_InitializeScenarios_Private_Void_BakingSet_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_SyncBakingSetSettings_Internal_Void_0;

		// Token: 0x020001D9 RID: 473
		[Serializable]
		public sealed class SerializableBoundItem : ValueType
		{
			// Token: 0x060019DE RID: 6622 RVA: 0x0006BD50 File Offset: 0x00069F50
			// Note: this type is marked as 'beforefieldinit'.
			static SerializableBoundItem()
			{
				Il2CppClassPointerStore<ProbeVolumeSceneData.SerializableBoundItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "SerializableBoundItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializableBoundItem>.NativeClassPtr);
				ProbeVolumeSceneData.SerializableBoundItem.NativeFieldInfoPtr_sceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializableBoundItem>.NativeClassPtr, "sceneGUID");
				ProbeVolumeSceneData.SerializableBoundItem.NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializableBoundItem>.NativeClassPtr, "bounds");
			}

			// Token: 0x060019DF RID: 6623 RVA: 0x0000CE88 File Offset: 0x0000B088
			public SerializableBoundItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060019E0 RID: 6624 RVA: 0x0000CE91 File Offset: 0x0000B091
			public SerializableBoundItem()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializableBoundItem>.NativeClassPtr))
			{
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x060019E1 RID: 6625 RVA: 0x0006BDA4 File Offset: 0x00069FA4
			// (set) Token: 0x060019E2 RID: 6626 RVA: 0x0000CEA3 File Offset: 0x0000B0A3
			public unsafe string sceneGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializableBoundItem.NativeFieldInfoPtr_sceneGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializableBoundItem.NativeFieldInfoPtr_sceneGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x060019E3 RID: 6627 RVA: 0x0006BDCC File Offset: 0x00069FCC
			// (set) Token: 0x060019E4 RID: 6628 RVA: 0x0000CEC2 File Offset: 0x0000B0C2
			public unsafe Bounds bounds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializableBoundItem.NativeFieldInfoPtr_bounds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializableBoundItem.NativeFieldInfoPtr_bounds)) = value;
				}
			}

			// Token: 0x040012DB RID: 4827
			private static readonly IntPtr NativeFieldInfoPtr_sceneGUID;

			// Token: 0x040012DC RID: 4828
			private static readonly IntPtr NativeFieldInfoPtr_bounds;
		}

		// Token: 0x020001DA RID: 474
		[Serializable]
		public sealed class SerializableHasPVItem : ValueType
		{
			// Token: 0x060019E5 RID: 6629 RVA: 0x0006BDF4 File Offset: 0x00069FF4
			// Note: this type is marked as 'beforefieldinit'.
			static SerializableHasPVItem()
			{
				Il2CppClassPointerStore<ProbeVolumeSceneData.SerializableHasPVItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "SerializableHasPVItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializableHasPVItem>.NativeClassPtr);
				ProbeVolumeSceneData.SerializableHasPVItem.NativeFieldInfoPtr_sceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializableHasPVItem>.NativeClassPtr, "sceneGUID");
				ProbeVolumeSceneData.SerializableHasPVItem.NativeFieldInfoPtr_hasProbeVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializableHasPVItem>.NativeClassPtr, "hasProbeVolumes");
			}

			// Token: 0x060019E6 RID: 6630 RVA: 0x0000CEDD File Offset: 0x0000B0DD
			public SerializableHasPVItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060019E7 RID: 6631 RVA: 0x0000CEE6 File Offset: 0x0000B0E6
			public SerializableHasPVItem()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializableHasPVItem>.NativeClassPtr))
			{
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x060019E8 RID: 6632 RVA: 0x0006BE48 File Offset: 0x0006A048
			// (set) Token: 0x060019E9 RID: 6633 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
			public unsafe string sceneGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializableHasPVItem.NativeFieldInfoPtr_sceneGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializableHasPVItem.NativeFieldInfoPtr_sceneGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x060019EA RID: 6634 RVA: 0x0006BE70 File Offset: 0x0006A070
			// (set) Token: 0x060019EB RID: 6635 RVA: 0x0000CF17 File Offset: 0x0000B117
			public unsafe bool hasProbeVolumes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializableHasPVItem.NativeFieldInfoPtr_hasProbeVolumes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializableHasPVItem.NativeFieldInfoPtr_hasProbeVolumes)) = value;
				}
			}

			// Token: 0x040012DD RID: 4829
			private static readonly IntPtr NativeFieldInfoPtr_sceneGUID;

			// Token: 0x040012DE RID: 4830
			private static readonly IntPtr NativeFieldInfoPtr_hasProbeVolumes;
		}

		// Token: 0x020001DB RID: 475
		[Serializable]
		public sealed class SerializablePVProfile : ValueType
		{
			// Token: 0x060019EC RID: 6636 RVA: 0x0006BE98 File Offset: 0x0006A098
			// Note: this type is marked as 'beforefieldinit'.
			static SerializablePVProfile()
			{
				Il2CppClassPointerStore<ProbeVolumeSceneData.SerializablePVProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "SerializablePVProfile");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializablePVProfile>.NativeClassPtr);
				ProbeVolumeSceneData.SerializablePVProfile.NativeFieldInfoPtr_sceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializablePVProfile>.NativeClassPtr, "sceneGUID");
				ProbeVolumeSceneData.SerializablePVProfile.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializablePVProfile>.NativeClassPtr, "profile");
			}

			// Token: 0x060019ED RID: 6637 RVA: 0x0000CF32 File Offset: 0x0000B132
			public SerializablePVProfile(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060019EE RID: 6638 RVA: 0x0000CF3B File Offset: 0x0000B13B
			public SerializablePVProfile()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializablePVProfile>.NativeClassPtr))
			{
			}

			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x060019EF RID: 6639 RVA: 0x0006BEEC File Offset: 0x0006A0EC
			// (set) Token: 0x060019F0 RID: 6640 RVA: 0x0000CF4D File Offset: 0x0000B14D
			public unsafe string sceneGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializablePVProfile.NativeFieldInfoPtr_sceneGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializablePVProfile.NativeFieldInfoPtr_sceneGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x060019F1 RID: 6641 RVA: 0x0006BF14 File Offset: 0x0006A114
			// (set) Token: 0x060019F2 RID: 6642 RVA: 0x0000CF6C File Offset: 0x0000B16C
			public unsafe ProbeReferenceVolumeProfile profile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializablePVProfile.NativeFieldInfoPtr_profile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolumeProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializablePVProfile.NativeFieldInfoPtr_profile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012DF RID: 4831
			private static readonly IntPtr NativeFieldInfoPtr_sceneGUID;

			// Token: 0x040012E0 RID: 4832
			private static readonly IntPtr NativeFieldInfoPtr_profile;
		}

		// Token: 0x020001DC RID: 476
		[Serializable]
		public sealed class SerializablePVBakeSettings : ValueType
		{
			// Token: 0x060019F3 RID: 6643 RVA: 0x0006BF44 File Offset: 0x0006A144
			// Note: this type is marked as 'beforefieldinit'.
			static SerializablePVBakeSettings()
			{
				Il2CppClassPointerStore<ProbeVolumeSceneData.SerializablePVBakeSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "SerializablePVBakeSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializablePVBakeSettings>.NativeClassPtr);
				ProbeVolumeSceneData.SerializablePVBakeSettings.NativeFieldInfoPtr_sceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializablePVBakeSettings>.NativeClassPtr, "sceneGUID");
				ProbeVolumeSceneData.SerializablePVBakeSettings.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializablePVBakeSettings>.NativeClassPtr, "settings");
			}

			// Token: 0x060019F4 RID: 6644 RVA: 0x0000CF8B File Offset: 0x0000B18B
			public SerializablePVBakeSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060019F5 RID: 6645 RVA: 0x0000CF94 File Offset: 0x0000B194
			public SerializablePVBakeSettings()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeSceneData.SerializablePVBakeSettings>.NativeClassPtr))
			{
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x060019F6 RID: 6646 RVA: 0x0006BF98 File Offset: 0x0006A198
			// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0000CFA6 File Offset: 0x0000B1A6
			public unsafe string sceneGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializablePVBakeSettings.NativeFieldInfoPtr_sceneGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializablePVBakeSettings.NativeFieldInfoPtr_sceneGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x060019F8 RID: 6648 RVA: 0x0006BFC0 File Offset: 0x0006A1C0
			// (set) Token: 0x060019F9 RID: 6649 RVA: 0x0000CFC5 File Offset: 0x0000B1C5
			public unsafe ProbeVolumeBakingProcessSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializablePVBakeSettings.NativeFieldInfoPtr_settings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.SerializablePVBakeSettings.NativeFieldInfoPtr_settings)) = value;
				}
			}

			// Token: 0x040012E1 RID: 4833
			private static readonly IntPtr NativeFieldInfoPtr_sceneGUID;

			// Token: 0x040012E2 RID: 4834
			private static readonly IntPtr NativeFieldInfoPtr_settings;
		}

		// Token: 0x020001DD RID: 477
		[Serializable]
		public class BakingSet : Object
		{
			// Token: 0x060019FA RID: 6650 RVA: 0x0006BFE8 File Offset: 0x0006A1E8
			// Note: this type is marked as 'beforefieldinit'.
			static BakingSet()
			{
				Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeSceneData>.NativeClassPtr, "BakingSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr);
				ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr, "name");
				ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_sceneGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr, "sceneGUIDs");
				ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr, "settings");
				ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr, "profile");
				ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_lightingScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr, "lightingScenarios");
				ProbeVolumeSceneData.BakingSet.NativeMethodInfoPtr_CreateScenario_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr, 100665023);
				ProbeVolumeSceneData.BakingSet.NativeMethodInfoPtr_RemoveScenario_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr, 100665024);
				ProbeVolumeSceneData.BakingSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr, 100665025);
			}

			// Token: 0x060019FB RID: 6651 RVA: 0x0006C0B4 File Offset: 0x0006A2B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969973, XrefRangeEnd = 969989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string CreateScenario(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.BakingSet.NativeMethodInfoPtr_CreateScenario_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060019FC RID: 6652 RVA: 0x0006C0FC File Offset: 0x0006A2FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969989, XrefRangeEnd = 969993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool RemoveScenario(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.BakingSet.NativeMethodInfoPtr_RemoveScenario_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019FD RID: 6653 RVA: 0x0006C14C File Offset: 0x0006A34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969993, XrefRangeEnd = 970006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BakingSet()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeSceneData.BakingSet>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeSceneData.BakingSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019FE RID: 6654 RVA: 0x0000CFE0 File Offset: 0x0000B1E0
			public BakingSet(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x060019FF RID: 6655 RVA: 0x0006C188 File Offset: 0x0006A388
			// (set) Token: 0x06001A00 RID: 6656 RVA: 0x0000CFE9 File Offset: 0x0000B1E9
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x06001A01 RID: 6657 RVA: 0x0006C1B0 File Offset: 0x0006A3B0
			// (set) Token: 0x06001A02 RID: 6658 RVA: 0x0000D008 File Offset: 0x0000B208
			public unsafe List<string> sceneGUIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_sceneGUIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_sceneGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0006C1E0 File Offset: 0x0006A3E0
			// (set) Token: 0x06001A04 RID: 6660 RVA: 0x0000D027 File Offset: 0x0000B227
			public unsafe ProbeVolumeBakingProcessSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_settings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_settings)) = value;
				}
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0006C208 File Offset: 0x0006A408
			// (set) Token: 0x06001A06 RID: 6662 RVA: 0x0000D042 File Offset: 0x0000B242
			public unsafe ProbeReferenceVolumeProfile profile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_profile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolumeProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_profile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06001A07 RID: 6663 RVA: 0x0006C238 File Offset: 0x0006A438
			// (set) Token: 0x06001A08 RID: 6664 RVA: 0x0000D061 File Offset: 0x0000B261
			public unsafe List<string> lightingScenarios
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_lightingScenarios);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeSceneData.BakingSet.NativeFieldInfoPtr_lightingScenarios), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012E3 RID: 4835
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040012E4 RID: 4836
			private static readonly IntPtr NativeFieldInfoPtr_sceneGUIDs;

			// Token: 0x040012E5 RID: 4837
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x040012E6 RID: 4838
			private static readonly IntPtr NativeFieldInfoPtr_profile;

			// Token: 0x040012E7 RID: 4839
			private static readonly IntPtr NativeFieldInfoPtr_lightingScenarios;

			// Token: 0x040012E8 RID: 4840
			private static readonly IntPtr NativeMethodInfoPtr_CreateScenario_Internal_String_String_0;

			// Token: 0x040012E9 RID: 4841
			private static readonly IntPtr NativeMethodInfoPtr_RemoveScenario_Internal_Boolean_String_0;

			// Token: 0x040012EA RID: 4842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
