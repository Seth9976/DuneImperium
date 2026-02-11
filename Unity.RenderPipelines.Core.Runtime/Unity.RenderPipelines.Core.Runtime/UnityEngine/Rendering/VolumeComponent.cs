using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x020000EB RID: 235
	[Serializable]
	public class VolumeComponent : ScriptableObject
	{
		// Token: 0x060010C3 RID: 4291 RVA: 0x0004CE74 File Offset: 0x0004B074
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeComponent()
		{
			Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VolumeComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr);
			VolumeComponent.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, "active");
			VolumeComponent.NativeFieldInfoPtr__displayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, "<displayName>k__BackingField");
			VolumeComponent.NativeFieldInfoPtr_parameterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, "parameterList");
			VolumeComponent.NativeFieldInfoPtr_m_ParameterReadOnlyCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, "m_ParameterReadOnlyCollection");
			VolumeComponent.NativeMethodInfoPtr_get_displayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665766);
			VolumeComponent.NativeMethodInfoPtr_set_displayName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665767);
			VolumeComponent.NativeMethodInfoPtr_get_parameters_Public_get_ReadOnlyCollection_1_VolumeParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665768);
			VolumeComponent.NativeMethodInfoPtr_FindParameters_Internal_Static_Void_Object_List_1_VolumeParameter_Func_2_FieldInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665769);
			VolumeComponent.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665770);
			VolumeComponent.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665771);
			VolumeComponent.NativeMethodInfoPtr_Override_Public_Virtual_New_Void_VolumeComponent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665772);
			VolumeComponent.NativeMethodInfoPtr_SetAllOverridesTo_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665773);
			VolumeComponent.NativeMethodInfoPtr_SetOverridesTo_Internal_Void_IEnumerable_1_VolumeParameter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665774);
			VolumeComponent.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665775);
			VolumeComponent.NativeMethodInfoPtr_AnyPropertiesIsOverridden_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665776);
			VolumeComponent.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665777);
			VolumeComponent.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665778);
			VolumeComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, 100665779);
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0004D00C File Offset: 0x0004B20C
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x0004D044 File Offset: 0x0004B244
		public unsafe string displayName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.NativeMethodInfoPtr_get_displayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.NativeMethodInfoPtr_set_displayName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x0004D088 File Offset: 0x0004B288
		public unsafe ReadOnlyCollection<VolumeParameter> parameters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 978074, RefRangeEnd = 978075, XrefRangeStart = 978070, XrefRangeEnd = 978074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.NativeMethodInfoPtr_get_parameters_Public_get_ReadOnlyCollection_1_VolumeParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<VolumeParameter>>(intPtr3) : null;
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0004D0C8 File Offset: 0x0004B2C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 978128, RefRangeEnd = 978130, XrefRangeStart = 978075, XrefRangeEnd = 978128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FindParameters(Object o, List<VolumeParameter> parameters, Func<FieldInfo, bool> filter = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.NativeMethodInfoPtr_FindParameters_Internal_Static_Void_Object_List_1_VolumeParameter_Func_2_FieldInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0004D124 File Offset: 0x0004B324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978130, XrefRangeEnd = 978158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeComponent.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0004D160 File Offset: 0x0004B360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978158, XrefRangeEnd = 978172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeComponent.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0004D19C File Offset: 0x0004B39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978172, XrefRangeEnd = 978179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Override(VolumeComponent state, float interpFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interpFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeComponent.NativeMethodInfoPtr_Override_Public_Virtual_New_Void_VolumeComponent_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0004D1F8 File Offset: 0x0004B3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978179, XrefRangeEnd = 978180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllOverridesTo(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.NativeMethodInfoPtr_SetAllOverridesTo_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0004D238 File Offset: 0x0004B438
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 978205, RefRangeEnd = 978208, XrefRangeStart = 978180, XrefRangeEnd = 978205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.NativeMethodInfoPtr_SetOverridesTo_Internal_Void_IEnumerable_1_VolumeParameter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0004D288 File Offset: 0x0004B488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978208, XrefRangeEnd = 978213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeComponent.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0004D2D0 File Offset: 0x0004B4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978213, XrefRangeEnd = 978218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyPropertiesIsOverridden()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.NativeMethodInfoPtr_AnyPropertiesIsOverridden_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0004D30C File Offset: 0x0004B50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978218, XrefRangeEnd = 978219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeComponent.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0004D348 File Offset: 0x0004B548
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 978226, RefRangeEnd = 978228, XrefRangeStart = 978219, XrefRangeEnd = 978226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0004D37C File Offset: 0x0004B57C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 978240, RefRangeEnd = 978257, XrefRangeStart = 978228, XrefRangeEnd = 978240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00008D68 File Offset: 0x00006F68
		public VolumeComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0004D3B8 File Offset: 0x0004B5B8
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x00008D71 File Offset: 0x00006F71
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponent.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponent.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0004D3E0 File Offset: 0x0004B5E0
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x00008D8C File Offset: 0x00006F8C
		public unsafe string _displayName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponent.NativeFieldInfoPtr__displayName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponent.NativeFieldInfoPtr__displayName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0004D408 File Offset: 0x0004B608
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x00008DAB File Offset: 0x00006FAB
		public unsafe List<VolumeParameter> parameterList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponent.NativeFieldInfoPtr_parameterList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeParameter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponent.NativeFieldInfoPtr_parameterList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0004D438 File Offset: 0x0004B638
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x00008DCA File Offset: 0x00006FCA
		public unsafe ReadOnlyCollection<VolumeParameter> m_ParameterReadOnlyCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponent.NativeFieldInfoPtr_m_ParameterReadOnlyCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<VolumeParameter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponent.NativeFieldInfoPtr_m_ParameterReadOnlyCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr__displayName_k__BackingField;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_parameterList;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr_m_ParameterReadOnlyCollection;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_get_displayName_Public_get_String_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_set_displayName_Protected_set_Void_String_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_get_parameters_Public_get_ReadOnlyCollection_1_VolumeParameter_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_FindParameters_Internal_Static_Void_Object_List_1_VolumeParameter_Func_2_FieldInfo_Boolean_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_Override_Public_Virtual_New_Void_VolumeComponent_Single_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_SetAllOverridesTo_Public_Void_Boolean_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_SetOverridesTo_Internal_Void_IEnumerable_1_VolumeParameter_Boolean_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_AnyPropertiesIsOverridden_Public_Boolean_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000206 RID: 518
		public sealed class Indent : PropertyAttribute
		{
			// Token: 0x06001AF8 RID: 6904 RVA: 0x0006E794 File Offset: 0x0006C994
			// Note: this type is marked as 'beforefieldinit'.
			static Indent()
			{
				Il2CppClassPointerStore<VolumeComponent.Indent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, "Indent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeComponent.Indent>.NativeClassPtr);
				VolumeComponent.Indent.NativeFieldInfoPtr_relativeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeComponent.Indent>.NativeClassPtr, "relativeAmount");
				VolumeComponent.Indent.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent.Indent>.NativeClassPtr, 100665780);
			}

			// Token: 0x06001AF9 RID: 6905 RVA: 0x0006E7E8 File Offset: 0x0006C9E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Indent(int relativeAmount = 1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeComponent.Indent>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref relativeAmount;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.Indent.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AFA RID: 6906 RVA: 0x0000D845 File Offset: 0x0000BA45
			public Indent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0006E830 File Offset: 0x0006CA30
			// (set) Token: 0x06001AFC RID: 6908 RVA: 0x0000D84E File Offset: 0x0000BA4E
			public unsafe int relativeAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponent.Indent.NativeFieldInfoPtr_relativeAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponent.Indent.NativeFieldInfoPtr_relativeAmount)) = value;
				}
			}

			// Token: 0x040013AD RID: 5037
			private static readonly IntPtr NativeFieldInfoPtr_relativeAmount;

			// Token: 0x040013AE RID: 5038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}

		// Token: 0x02000207 RID: 519
		[ObfuscatedName("UnityEngine.Rendering.VolumeComponent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AFD RID: 6909 RVA: 0x0006E858 File Offset: 0x0006CA58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeComponent.__c>.NativeClassPtr);
				VolumeComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeComponent.__c>.NativeClassPtr, "<>9");
				VolumeComponent.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeComponent.__c>.NativeClassPtr, "<>9__10_0");
				VolumeComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent.__c>.NativeClassPtr, 100665782);
				VolumeComponent.__c.NativeMethodInfoPtr__FindParameters_b__10_0_Internal_Int32_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponent.__c>.NativeClassPtr, 100665783);
			}

			// Token: 0x06001AFE RID: 6910 RVA: 0x0006E8D4 File Offset: 0x0006CAD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AFF RID: 6911 RVA: 0x0006E910 File Offset: 0x0006CB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _FindParameters_b__10_0(FieldInfo t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponent.__c.NativeMethodInfoPtr__FindParameters_b__10_0_Internal_Int32_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B00 RID: 6912 RVA: 0x0000D869 File Offset: 0x0000BA69
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x06001B01 RID: 6913 RVA: 0x0006E960 File Offset: 0x0006CB60
			// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0000D872 File Offset: 0x0000BA72
			public unsafe static VolumeComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0006E988 File Offset: 0x0006CB88
			// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0000D884 File Offset: 0x0000BA84
			public unsafe static Func<FieldInfo, int> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeComponent.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeComponent.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013AF RID: 5039
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040013B0 RID: 5040
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040013B1 RID: 5041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013B2 RID: 5042
			private static readonly IntPtr NativeMethodInfoPtr__FindParameters_b__10_0_Internal_Int32_FieldInfo_0;
		}
	}
}
