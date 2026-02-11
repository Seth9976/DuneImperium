using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x020000EC RID: 236
	public sealed class VolumeManager : Object
	{
		// Token: 0x060010DB RID: 4315 RVA: 0x0004D468 File Offset: 0x0004B668
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeManager()
		{
			Il2CppClassPointerStore<VolumeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VolumeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr);
			VolumeManager.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "s_Instance");
			VolumeManager.NativeFieldInfoPtr__stack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "<stack>k__BackingField");
			VolumeManager.NativeFieldInfoPtr_s_SupportedVolumeComponentsForRenderPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "s_SupportedVolumeComponentsForRenderPipeline");
			VolumeManager.NativeFieldInfoPtr__baseComponentTypeArray_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "<baseComponentTypeArray>k__BackingField");
			VolumeManager.NativeFieldInfoPtr_k_MaxLayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "k_MaxLayerCount");
			VolumeManager.NativeFieldInfoPtr_m_SortedVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "m_SortedVolumes");
			VolumeManager.NativeFieldInfoPtr_m_Volumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "m_Volumes");
			VolumeManager.NativeFieldInfoPtr_m_SortNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "m_SortNeeded");
			VolumeManager.NativeFieldInfoPtr_m_ComponentsDefaultState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "m_ComponentsDefaultState");
			VolumeManager.NativeFieldInfoPtr_m_TempColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "m_TempColliders");
			VolumeManager.NativeFieldInfoPtr_m_DefaultStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "m_DefaultStack");
			VolumeManager.NativeMethodInfoPtr_get_instance_Public_Static_get_VolumeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665784);
			VolumeManager.NativeMethodInfoPtr_get_stack_Public_get_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665785);
			VolumeManager.NativeMethodInfoPtr_set_stack_Public_set_Void_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665786);
			VolumeManager.NativeMethodInfoPtr_get_baseComponentTypes_Public_get_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665787);
			VolumeManager.NativeMethodInfoPtr_set_baseComponentTypes_Private_set_Void_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665788);
			VolumeManager.NativeMethodInfoPtr_GetSupportedVolumeComponents_Internal_Static_List_1_ValueTuple_2_String_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665789);
			VolumeManager.NativeMethodInfoPtr_FilterVolumeComponentTypes_Private_Static_List_1_ValueTuple_2_String_Type_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665790);
			VolumeManager.NativeMethodInfoPtr_get_baseComponentTypeArray_Public_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665791);
			VolumeManager.NativeMethodInfoPtr_set_baseComponentTypeArray_Private_set_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665792);
			VolumeManager.NativeMethodInfoPtr_GetDefaultVolumeComponent_Internal_VolumeComponent_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665793);
			VolumeManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665794);
			VolumeManager.NativeMethodInfoPtr_CreateStack_Public_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665795);
			VolumeManager.NativeMethodInfoPtr_ResetMainStack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665796);
			VolumeManager.NativeMethodInfoPtr_DestroyStack_Public_Void_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665797);
			VolumeManager.NativeMethodInfoPtr_ReloadBaseTypes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665798);
			VolumeManager.NativeMethodInfoPtr_Register_Public_Void_Volume_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665799);
			VolumeManager.NativeMethodInfoPtr_Unregister_Public_Void_Volume_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665800);
			VolumeManager.NativeMethodInfoPtr_IsComponentActiveInMask_Public_Boolean_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665801);
			VolumeManager.NativeMethodInfoPtr_SetLayerDirty_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665802);
			VolumeManager.NativeMethodInfoPtr_UpdateVolumeLayer_Internal_Void_Volume_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665803);
			VolumeManager.NativeMethodInfoPtr_OverrideData_Private_Void_VolumeStack_List_1_VolumeComponent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665804);
			VolumeManager.NativeMethodInfoPtr_ReplaceData_Internal_Void_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665805);
			VolumeManager.NativeMethodInfoPtr_CheckBaseTypes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665806);
			VolumeManager.NativeMethodInfoPtr_CheckStack_Public_Void_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665807);
			VolumeManager.NativeMethodInfoPtr_CheckUpdateRequired_Private_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665808);
			VolumeManager.NativeMethodInfoPtr_Update_Public_Void_Transform_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665809);
			VolumeManager.NativeMethodInfoPtr_Update_Public_Void_VolumeStack_Transform_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665810);
			VolumeManager.NativeMethodInfoPtr_GetVolumes_Public_Il2CppReferenceArray_1_Volume_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665811);
			VolumeManager.NativeMethodInfoPtr_GrabVolumes_Private_List_1_Volume_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665812);
			VolumeManager.NativeMethodInfoPtr_SortByPriority_Private_Static_Void_List_1_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665813);
			VolumeManager.NativeMethodInfoPtr_IsVolumeRenderedByCamera_Private_Static_Boolean_Volume_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, 100665814);
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x0004D7E0 File Offset: 0x0004B9E0
		public unsafe static VolumeManager instance
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 978274, RefRangeEnd = 978295, XrefRangeStart = 978266, XrefRangeEnd = 978274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_get_instance_Public_Static_get_VolumeManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0004D814 File Offset: 0x0004BA14
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x0004D854 File Offset: 0x0004BA54
		public unsafe VolumeStack stack
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_get_stack_Public_get_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeStack>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_set_stack_Public_set_Void_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0004D898 File Offset: 0x0004BA98
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x0004D8D8 File Offset: 0x0004BAD8
		public unsafe IEnumerable<Type> baseComponentTypes
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_get_baseComponentTypes_Public_get_IEnumerable_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978295, XrefRangeEnd = 978299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_set_baseComponentTypes_Private_set_Void_IEnumerable_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0004D91C File Offset: 0x0004BB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 978314, RefRangeEnd = 978315, XrefRangeStart = 978299, XrefRangeEnd = 978314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ValueTuple<string, Type>> GetSupportedVolumeComponents(Type currentPipelineType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPipelineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_GetSupportedVolumeComponents_Internal_Static_List_1_ValueTuple_2_String_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, Type>>>(intPtr3) : null;
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0004D960 File Offset: 0x0004BB60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 978369, RefRangeEnd = 978370, XrefRangeStart = 978315, XrefRangeEnd = 978369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ValueTuple<string, Type>> FilterVolumeComponentTypes(Il2CppReferenceArray<Type> types, Type currentPipelineType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentPipelineType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_FilterVolumeComponentTypes_Private_Static_List_1_ValueTuple_2_String_Type_Il2CppReferenceArray_1_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, Type>>>(intPtr3) : null;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0004D9B8 File Offset: 0x0004BBB8
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x0004D9F8 File Offset: 0x0004BBF8
		public unsafe Il2CppReferenceArray<Type> baseComponentTypeArray
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_get_baseComponentTypeArray_Public_get_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_set_baseComponentTypeArray_Private_set_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0004DA3C File Offset: 0x0004BC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978370, XrefRangeEnd = 978385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeComponent GetDefaultVolumeComponent(Type volumeComponentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volumeComponentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_GetDefaultVolumeComponent_Internal_VolumeComponent_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeComponent>(intPtr3) : null;
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0004DA8C File Offset: 0x0004BC8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 978436, RefRangeEnd = 978437, XrefRangeStart = 978385, XrefRangeEnd = 978436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0004DAC8 File Offset: 0x0004BCC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 978449, RefRangeEnd = 978450, XrefRangeStart = 978437, XrefRangeEnd = 978449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeStack CreateStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_CreateStack_Public_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeStack>(intPtr3) : null;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0004DB08 File Offset: 0x0004BD08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 978451, RefRangeEnd = 978452, XrefRangeStart = 978450, XrefRangeEnd = 978451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetMainStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_ResetMainStack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0004DB3C File Offset: 0x0004BD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978452, XrefRangeEnd = 978454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStack(VolumeStack stack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_DestroyStack_Public_Void_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0004DB80 File Offset: 0x0004BD80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 978495, RefRangeEnd = 978497, XrefRangeStart = 978454, XrefRangeEnd = 978495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadBaseTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_ReloadBaseTypes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0004DBB4 File Offset: 0x0004BDB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 978524, RefRangeEnd = 978528, XrefRangeStart = 978497, XrefRangeEnd = 978524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(Volume volume, int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_Register_Public_Void_Volume_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0004DC04 File Offset: 0x0004BE04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 978549, RefRangeEnd = 978553, XrefRangeStart = 978528, XrefRangeEnd = 978549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister(Volume volume, int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_Unregister_Public_Void_Volume_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0004DC54 File Offset: 0x0004BE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978553, XrefRangeEnd = 978585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsComponentActiveInMask<T>(LayerMask layerMask) where T : VolumeComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerMask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.MethodInfoStoreGeneric_IsComponentActiveInMask_Public_Boolean_LayerMask_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0004DCA0 File Offset: 0x0004BEA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 978603, RefRangeEnd = 978605, XrefRangeStart = 978585, XrefRangeEnd = 978603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayerDirty(int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_SetLayerDirty_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0004DCE0 File Offset: 0x0004BEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978605, XrefRangeEnd = 978607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevLayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_UpdateVolumeLayer_Internal_Void_Volume_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0004DD40 File Offset: 0x0004BF40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 978613, RefRangeEnd = 978615, XrefRangeStart = 978607, XrefRangeEnd = 978613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interpFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_OverrideData_Private_Void_VolumeStack_List_1_VolumeComponent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0004DDA4 File Offset: 0x0004BFA4
		[CallerCount(0)]
		public unsafe void ReplaceData(VolumeStack stack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_ReplaceData_Internal_Void_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0004DDE8 File Offset: 0x0004BFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978615, XrefRangeEnd = 978624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckBaseTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_CheckBaseTypes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0004DE1C File Offset: 0x0004C01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978624, XrefRangeEnd = 978653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStack(VolumeStack stack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_CheckStack_Public_Void_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0004DE60 File Offset: 0x0004C060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978653, XrefRangeEnd = 978654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckUpdateRequired(VolumeStack stack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_CheckUpdateRequired_Private_Boolean_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0004DEB0 File Offset: 0x0004C0B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 978655, RefRangeEnd = 978656, XrefRangeStart = 978654, XrefRangeEnd = 978655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(Transform trigger, LayerMask layerMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_Update_Public_Void_Transform_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0004DF00 File Offset: 0x0004C100
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 978701, RefRangeEnd = 978703, XrefRangeStart = 978656, XrefRangeEnd = 978701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(VolumeStack stack, Transform trigger, LayerMask layerMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trigger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_Update_Public_Void_VolumeStack_Transform_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0004DF64 File Offset: 0x0004C164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 978726, RefRangeEnd = 978727, XrefRangeStart = 978703, XrefRangeEnd = 978726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Volume> GetVolumes(LayerMask layerMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerMask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_GetVolumes_Public_Il2CppReferenceArray_1_Volume_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Volume>>(intPtr3) : null;
			}
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0004DFB0 File Offset: 0x0004C1B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 978779, RefRangeEnd = 978781, XrefRangeStart = 978727, XrefRangeEnd = 978779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Volume> GrabVolumes(LayerMask mask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_GrabVolumes_Private_List_1_Volume_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Volume>>(intPtr3) : null;
			}
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0004DFFC File Offset: 0x0004C1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978781, XrefRangeEnd = 978795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SortByPriority(List<Volume> volumes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volumes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_SortByPriority_Private_Static_Void_List_1_Volume_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0004E034 File Offset: 0x0004C234
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVolumeRenderedByCamera(Volume volume, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.NativeMethodInfoPtr_IsVolumeRenderedByCamera_Private_Static_Boolean_Volume_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00008DE9 File Offset: 0x00006FE9
		public VolumeManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x0004E088 File Offset: 0x0004C288
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x00008DF2 File Offset: 0x00006FF2
		public unsafe static Lazy<VolumeManager> s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumeManager.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<VolumeManager>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumeManager.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x0004E0B0 File Offset: 0x0004C2B0
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x00008E04 File Offset: 0x00007004
		public unsafe VolumeStack _stack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr__stack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr__stack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0004E0E0 File Offset: 0x0004C2E0
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x00008E23 File Offset: 0x00007023
		public unsafe static Dictionary<Type, List<ValueTuple<string, Type>>> s_SupportedVolumeComponentsForRenderPipeline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumeManager.NativeFieldInfoPtr_s_SupportedVolumeComponentsForRenderPipeline, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, List<ValueTuple<string, Type>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumeManager.NativeFieldInfoPtr_s_SupportedVolumeComponentsForRenderPipeline, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0004E108 File Offset: 0x0004C308
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x00008E35 File Offset: 0x00007035
		public unsafe Il2CppReferenceArray<Type> _baseComponentTypeArray_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr__baseComponentTypeArray_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr__baseComponentTypeArray_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0004E138 File Offset: 0x0004C338
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x00008E54 File Offset: 0x00007054
		public unsafe static int k_MaxLayerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(VolumeManager.NativeFieldInfoPtr_k_MaxLayerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumeManager.NativeFieldInfoPtr_k_MaxLayerCount, (void*)(&value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x0004E154 File Offset: 0x0004C354
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x00008E62 File Offset: 0x00007062
		public unsafe Dictionary<int, List<Volume>> m_SortedVolumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_SortedVolumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<Volume>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_SortedVolumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0004E184 File Offset: 0x0004C384
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x00008E81 File Offset: 0x00007081
		public unsafe List<Volume> m_Volumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_Volumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Volume>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_Volumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x0004E1B4 File Offset: 0x0004C3B4
		// (set) Token: 0x0600110B RID: 4363 RVA: 0x00008EA0 File Offset: 0x000070A0
		public unsafe Dictionary<int, bool> m_SortNeeded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_SortNeeded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_SortNeeded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x0004E1E4 File Offset: 0x0004C3E4
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x00008EBF File Offset: 0x000070BF
		public unsafe List<VolumeComponent> m_ComponentsDefaultState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_ComponentsDefaultState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_ComponentsDefaultState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0004E214 File Offset: 0x0004C414
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x00008EDE File Offset: 0x000070DE
		public unsafe List<Collider> m_TempColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_TempColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_TempColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0004E244 File Offset: 0x0004C444
		// (set) Token: 0x06001111 RID: 4369 RVA: 0x00008EFD File Offset: 0x000070FD
		public unsafe VolumeStack m_DefaultStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_DefaultStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeManager.NativeFieldInfoPtr_m_DefaultStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeFieldInfoPtr__stack_k__BackingField;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeFieldInfoPtr_s_SupportedVolumeComponentsForRenderPipeline;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeFieldInfoPtr__baseComponentTypeArray_k__BackingField;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxLayerCount;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeFieldInfoPtr_m_SortedVolumes;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeFieldInfoPtr_m_Volumes;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeFieldInfoPtr_m_SortNeeded;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeFieldInfoPtr_m_ComponentsDefaultState;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr_m_TempColliders;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultStack;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_VolumeManager_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_get_stack_Public_get_VolumeStack_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_set_stack_Public_set_Void_VolumeStack_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_get_baseComponentTypes_Public_get_IEnumerable_1_Type_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_set_baseComponentTypes_Private_set_Void_IEnumerable_1_Type_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_GetSupportedVolumeComponents_Internal_Static_List_1_ValueTuple_2_String_Type_Type_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_FilterVolumeComponentTypes_Private_Static_List_1_ValueTuple_2_String_Type_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_get_baseComponentTypeArray_Public_get_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_set_baseComponentTypeArray_Private_set_Void_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultVolumeComponent_Internal_VolumeComponent_Type_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_CreateStack_Public_VolumeStack_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_ResetMainStack_Public_Void_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStack_Public_Void_VolumeStack_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_ReloadBaseTypes_Private_Void_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_Volume_Int32_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_Volume_Int32_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_IsComponentActiveInMask_Public_Boolean_LayerMask_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerDirty_Internal_Void_Int32_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolumeLayer_Internal_Void_Volume_Int32_Int32_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_OverrideData_Private_Void_VolumeStack_List_1_VolumeComponent_Single_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceData_Internal_Void_VolumeStack_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_CheckBaseTypes_Public_Void_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_CheckStack_Public_Void_VolumeStack_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_CheckUpdateRequired_Private_Boolean_VolumeStack_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Transform_LayerMask_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_VolumeStack_Transform_LayerMask_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_GetVolumes_Public_Il2CppReferenceArray_1_Volume_LayerMask_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_GrabVolumes_Private_List_1_Volume_LayerMask_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_SortByPriority_Private_Static_Void_List_1_Volume_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_IsVolumeRenderedByCamera_Private_Static_Boolean_Volume_Camera_0;

		// Token: 0x02000208 RID: 520
		[ObfuscatedName("UnityEngine.Rendering.VolumeManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B05 RID: 6917 RVA: 0x0006E9B0 File Offset: 0x0006CBB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr);
				VolumeManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr, "<>9");
				VolumeManager.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr, "<>9__12_0");
				VolumeManager.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr, "<>9__29_0");
				VolumeManager.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr, "<>9__42_0");
				VolumeManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr, 100665817);
				VolumeManager.__c.NativeMethodInfoPtr__FilterVolumeComponentTypes_b__12_0_Internal_String_ValueTuple_2_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr, 100665818);
				VolumeManager.__c.NativeMethodInfoPtr__ReloadBaseTypes_b__29_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr, 100665819);
				VolumeManager.__c.NativeMethodInfoPtr__GetVolumes_b__42_0_Internal_Boolean_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr, 100665820);
				VolumeManager.__c.NativeMethodInfoPtr___cctor_b__46_0_Internal_VolumeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr, 100665821);
			}

			// Token: 0x06001B06 RID: 6918 RVA: 0x0006EA90 File Offset: 0x0006CC90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B07 RID: 6919 RVA: 0x0006EACC File Offset: 0x0006CCCC
			[CallerCount(0)]
			public unsafe string _FilterVolumeComponentTypes_b__12_0(ValueTuple<string, Type> i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(i));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.__c.NativeMethodInfoPtr__FilterVolumeComponentTypes_b__12_0_Internal_String_ValueTuple_2_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001B08 RID: 6920 RVA: 0x0006EB1C File Offset: 0x0006CD1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978257, XrefRangeEnd = 978258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ReloadBaseTypes_b__29_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.__c.NativeMethodInfoPtr__ReloadBaseTypes_b__29_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B09 RID: 6921 RVA: 0x0006EB6C File Offset: 0x0006CD6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978258, XrefRangeEnd = 978262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetVolumes_b__42_0(Volume v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.__c.NativeMethodInfoPtr__GetVolumes_b__42_0_Internal_Boolean_Volume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B0A RID: 6922 RVA: 0x0006EBBC File Offset: 0x0006CDBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978262, XrefRangeEnd = 978266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VolumeManager __cctor_b__46_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeManager.__c.NativeMethodInfoPtr___cctor_b__46_0_Internal_VolumeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeManager>(intPtr3) : null;
			}

			// Token: 0x06001B0B RID: 6923 RVA: 0x0000D896 File Offset: 0x0000BA96
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0006EBFC File Offset: 0x0006CDFC
			// (set) Token: 0x06001B0D RID: 6925 RVA: 0x0000D89F File Offset: 0x0000BA9F
			public unsafe static VolumeManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0006EC24 File Offset: 0x0006CE24
			// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0000D8B1 File Offset: 0x0000BAB1
			public unsafe static Func<ValueTuple<string, Type>, string> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeManager.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<string, Type>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeManager.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0006EC4C File Offset: 0x0006CE4C
			// (set) Token: 0x06001B11 RID: 6929 RVA: 0x0000D8C3 File Offset: 0x0000BAC3
			public unsafe static Func<Type, bool> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeManager.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeManager.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0006EC74 File Offset: 0x0006CE74
			// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0000D8D5 File Offset: 0x0000BAD5
			public unsafe static Predicate<Volume> __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeManager.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Volume>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeManager.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013B3 RID: 5043
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040013B4 RID: 5044
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040013B5 RID: 5045
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x040013B6 RID: 5046
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x040013B7 RID: 5047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013B8 RID: 5048
			private static readonly IntPtr NativeMethodInfoPtr__FilterVolumeComponentTypes_b__12_0_Internal_String_ValueTuple_2_String_Type_0;

			// Token: 0x040013B9 RID: 5049
			private static readonly IntPtr NativeMethodInfoPtr__ReloadBaseTypes_b__29_0_Internal_Boolean_Type_0;

			// Token: 0x040013BA RID: 5050
			private static readonly IntPtr NativeMethodInfoPtr__GetVolumes_b__42_0_Internal_Boolean_Volume_0;

			// Token: 0x040013BB RID: 5051
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__46_0_Internal_VolumeManager_0;
		}

		// Token: 0x02000209 RID: 521
		private sealed class MethodInfoStoreGeneric_IsComponentActiveInMask_Public_Boolean_LayerMask_0<T>
		{
			// Token: 0x040013BC RID: 5052
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VolumeManager.NativeMethodInfoPtr_IsComponentActiveInMask_Public_Boolean_LayerMask_0, Il2CppClassPointerStore<VolumeManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
