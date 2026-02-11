using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x0200007E RID: 126
	public class VolumeDebugSettings<T> : Object where T : MonoBehaviour
	{
		// Token: 0x0600084F RID: 2127 RVA: 0x0002C980 File Offset: 0x0002AB80
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeDebugSettings()
		{
			Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VolumeDebugSettings`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr);
			VolumeDebugSettings<T>.NativeFieldInfoPtr__selectedComponent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "<selectedComponent>k__BackingField");
			VolumeDebugSettings<T>.NativeFieldInfoPtr_m_SelectedCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "m_SelectedCamera");
			VolumeDebugSettings<T>.NativeFieldInfoPtr_m_SelectedCameraIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "m_SelectedCameraIndex");
			VolumeDebugSettings<T>.NativeFieldInfoPtr_m_CamerasArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "m_CamerasArray");
			VolumeDebugSettings<T>.NativeFieldInfoPtr_m_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "m_Cameras");
			VolumeDebugSettings<T>.NativeFieldInfoPtr_s_ComponentPathAndType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "s_ComponentPathAndType");
			VolumeDebugSettings<T>.NativeFieldInfoPtr_weights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "weights");
			VolumeDebugSettings<T>.NativeFieldInfoPtr_volumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "volumes");
			VolumeDebugSettings<T>.NativeFieldInfoPtr_savedStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "savedStates");
			VolumeDebugSettings<T>.NativeFieldInfoPtr_s_ComponentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "s_ComponentTypes");
			VolumeDebugSettings<T>.NativeFieldInfoPtr__additionalCameraDatas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "<additionalCameraDatas>k__BackingField");
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedComponent_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664605);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_set_selectedComponent_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664606);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedCamera_Public_Virtual_Final_New_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664607);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedCameraIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664608);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_set_selectedCameraIndex_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664609);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_cameras_Public_Virtual_Final_New_get_IEnumerable_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664610);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedCameraVolumeStack_Public_Abstract_Virtual_New_get_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664611);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedCameraLayerMask_Public_Abstract_Virtual_New_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664612);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedCameraPosition_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664613);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedComponentType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664614);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_set_selectedComponentType_Public_Virtual_Final_New_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664615);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_volumeComponentsPathAndType_Public_Virtual_Final_New_get_List_1_ValueTuple_2_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664616);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_targetRenderPipeline_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664617);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_GetParameter_Internal_VolumeParameter_VolumeComponent_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664618);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_GetParameter_Internal_VolumeParameter_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664619);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_GetParameter_Internal_VolumeParameter_Volume_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664620);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_ComputeWeight_Private_Single_Volume_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664621);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_GetVolumes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664622);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_GetStates_Private_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664623);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_ChangedStates_Private_Boolean_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664624);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_RefreshVolumes_Public_Virtual_Final_New_Boolean_Il2CppReferenceArray_1_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664625);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_GetVolumeWeight_Public_Virtual_Final_New_Single_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664626);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_VolumeHasInfluence_Public_Virtual_Final_New_Boolean_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664627);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_componentTypes_Public_Static_get_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664628);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_ComponentDisplayName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664629);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_get_additionalCameraDatas_Protected_Static_get_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664630);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_set_additionalCameraDatas_Private_Static_set_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664631);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_RegisterCamera_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664632);
			VolumeDebugSettings<T>.NativeMethodInfoPtr_UnRegisterCamera_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664633);
			VolumeDebugSettings<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, 100664634);
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x0002CD20 File Offset: 0x0002AF20
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		public unsafe virtual int selectedComponent
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedComponent_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_set_selectedComponent_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0002CD9C File Offset: 0x0002AF9C
		public unsafe virtual Camera selectedCamera
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedCamera_Public_Virtual_Final_New_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x0002CDDC File Offset: 0x0002AFDC
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x0002CE18 File Offset: 0x0002B018
		public unsafe virtual int selectedCameraIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedCameraIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965535, XrefRangeEnd = 965550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_set_selectedCameraIndex_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0002CE58 File Offset: 0x0002B058
		public unsafe virtual IEnumerable<Camera> cameras
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 965576, RefRangeEnd = 965579, XrefRangeStart = 965550, XrefRangeEnd = 965576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_get_cameras_Public_Virtual_Final_New_get_IEnumerable_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Camera>>(intPtr3) : null;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x0002CE98 File Offset: 0x0002B098
		public unsafe virtual VolumeStack selectedCameraVolumeStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedCameraVolumeStack_Public_Abstract_Virtual_New_get_VolumeStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeStack>(intPtr3) : null;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0002CEE4 File Offset: 0x0002B0E4
		public unsafe virtual LayerMask selectedCameraLayerMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedCameraLayerMask_Public_Abstract_Virtual_New_get_LayerMask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x0002CF2C File Offset: 0x0002B12C
		public unsafe virtual Vector3 selectedCameraPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedCameraPosition_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0002CF74 File Offset: 0x0002B174
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x0002CFB4 File Offset: 0x0002B1B4
		public unsafe virtual Type selectedComponentType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965579, XrefRangeEnd = 965583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_get_selectedComponentType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965583, XrefRangeEnd = 965595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_set_selectedComponentType_Public_Virtual_Final_New_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0002CFF8 File Offset: 0x0002B1F8
		public unsafe virtual List<ValueTuple<string, Type>> volumeComponentsPathAndType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 965607, RefRangeEnd = 965609, XrefRangeStart = 965595, XrefRangeEnd = 965607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_get_volumeComponentsPathAndType_Public_Virtual_Final_New_get_List_1_ValueTuple_2_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, Type>>>(intPtr3) : null;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0002D038 File Offset: 0x0002B238
		public unsafe virtual Type targetRenderPipeline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeDebugSettings<T>.NativeMethodInfoPtr_get_targetRenderPipeline_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0002D084 File Offset: 0x0002B284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965609, XrefRangeEnd = 965611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeParameter GetParameter(VolumeComponent component, FieldInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_GetParameter_Internal_VolumeParameter_VolumeComponent_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeParameter>(intPtr3) : null;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0002D0E8 File Offset: 0x0002B2E8
		[CallerCount(0)]
		public unsafe VolumeParameter GetParameter(FieldInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_GetParameter_Internal_VolumeParameter_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeParameter>(intPtr3) : null;
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0002D138 File Offset: 0x0002B338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965611, XrefRangeEnd = 965620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeParameter GetParameter(Volume volume, FieldInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_GetParameter_Internal_VolumeParameter_Volume_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeParameter>(intPtr3) : null;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0002D19C File Offset: 0x0002B39C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 965646, RefRangeEnd = 965649, XrefRangeStart = 965620, XrefRangeEnd = 965646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ComputeWeight(Volume volume, Vector3 triggerPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggerPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_ComputeWeight_Private_Single_Volume_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0002D1F8 File Offset: 0x0002B3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965649, XrefRangeEnd = 965677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Volume> GetVolumes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_GetVolumes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Volume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Volume>>(intPtr3) : null;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0002D238 File Offset: 0x0002B438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 965711, RefRangeEnd = 965713, XrefRangeStart = 965677, XrefRangeEnd = 965711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppObjectBase GetStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_GetStates_Private_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr3) : null;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0002D278 File Offset: 0x0002B478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965713, XrefRangeEnd = 965719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ChangedStates(Il2CppObjectBase newStates)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_ChangedStates_Private_Boolean_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0002D2C8 File Offset: 0x0002B4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965719, XrefRangeEnd = 965746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool RefreshVolumes(Il2CppReferenceArray<Volume> newVolumes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVolumes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_RefreshVolumes_Public_Virtual_Final_New_Boolean_Il2CppReferenceArray_1_Volume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0002D318 File Offset: 0x0002B518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965746, XrefRangeEnd = 965747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetVolumeWeight(Volume volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_GetVolumeWeight_Public_Virtual_Final_New_Single_Volume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0002D368 File Offset: 0x0002B568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965747, XrefRangeEnd = 965748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool VolumeHasInfluence(Volume volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_VolumeHasInfluence_Public_Virtual_Final_New_Boolean_Volume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0002D3B8 File Offset: 0x0002B5B8
		public unsafe static List<Type> componentTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965748, XrefRangeEnd = 965840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_get_componentTypes_Public_Static_get_List_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0002D3EC File Offset: 0x0002B5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 965851, RefRangeEnd = 965852, XrefRangeStart = 965840, XrefRangeEnd = 965851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ComponentDisplayName(Type component)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_ComponentDisplayName_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0002D428 File Offset: 0x0002B628
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x0002D45C File Offset: 0x0002B65C
		public unsafe static List<T> additionalCameraDatas
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965852, XrefRangeEnd = 965856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_get_additionalCameraDatas_Protected_Static_get_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965856, XrefRangeEnd = 965864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_set_additionalCameraDatas_Private_Static_set_Void_List_1_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0002D494 File Offset: 0x0002B694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965864, XrefRangeEnd = 965878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCamera(T additionalCamera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = additionalCamera;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref additionalCamera;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_RegisterCamera_Public_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0002D500 File Offset: 0x0002B700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965878, XrefRangeEnd = 965892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterCamera(T additionalCamera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = additionalCamera;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref additionalCamera;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr_UnRegisterCamera_Public_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0002D56C File Offset: 0x0002B76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 965900, RefRangeEnd = 965902, XrefRangeStart = 965892, XrefRangeEnd = 965900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeDebugSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000054C0 File Offset: 0x000036C0
		public VolumeDebugSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0002D5A8 File Offset: 0x0002B7A8
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x000054C9 File Offset: 0x000036C9
		public unsafe int _selectedComponent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr__selectedComponent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr__selectedComponent_k__BackingField)) = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x000054E4 File Offset: 0x000036E4
		public unsafe Camera m_SelectedCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_m_SelectedCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_m_SelectedCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0002D600 File Offset: 0x0002B800
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00005503 File Offset: 0x00003703
		public unsafe int m_SelectedCameraIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_m_SelectedCameraIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_m_SelectedCameraIndex)) = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0002D628 File Offset: 0x0002B828
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x0000551E File Offset: 0x0000371E
		public unsafe Il2CppReferenceArray<Camera> m_CamerasArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_m_CamerasArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_m_CamerasArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0002D658 File Offset: 0x0002B858
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x0000553D File Offset: 0x0000373D
		public unsafe List<Camera> m_Cameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_m_Cameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_m_Cameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0002D688 File Offset: 0x0002B888
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x0000555C File Offset: 0x0000375C
		public unsafe static List<ValueTuple<string, Type>> s_ComponentPathAndType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumeDebugSettings<T>.NativeFieldInfoPtr_s_ComponentPathAndType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, Type>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumeDebugSettings<T>.NativeFieldInfoPtr_s_ComponentPathAndType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0002D6B0 File Offset: 0x0002B8B0
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x0000556E File Offset: 0x0000376E
		public unsafe Il2CppStructArray<float> weights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_weights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_weights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0002D6E0 File Offset: 0x0002B8E0
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x0000558D File Offset: 0x0000378D
		public unsafe Il2CppReferenceArray<Volume> volumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_volumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Volume>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_volumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x0002D710 File Offset: 0x0002B910
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x000055AC File Offset: 0x000037AC
		public unsafe Il2CppObjectBase savedStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_savedStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.NativeFieldInfoPtr_savedStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x0002D740 File Offset: 0x0002B940
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x000055CB File Offset: 0x000037CB
		public unsafe static List<Type> s_ComponentTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumeDebugSettings<T>.NativeFieldInfoPtr_s_ComponentTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumeDebugSettings<T>.NativeFieldInfoPtr_s_ComponentTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0002D768 File Offset: 0x0002B968
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x000055DD File Offset: 0x000037DD
		public unsafe static List<T> _additionalCameraDatas_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumeDebugSettings<T>.NativeFieldInfoPtr__additionalCameraDatas_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumeDebugSettings<T>.NativeFieldInfoPtr__additionalCameraDatas_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeFieldInfoPtr__selectedComponent_k__BackingField;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedCamera;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedCameraIndex;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeFieldInfoPtr_m_CamerasArray;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeFieldInfoPtr_m_Cameras;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_s_ComponentPathAndType;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeFieldInfoPtr_weights;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeFieldInfoPtr_volumes;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_savedStates;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_s_ComponentTypes;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr__additionalCameraDatas_k__BackingField;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedComponent_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedComponent_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCamera_Public_Virtual_Final_New_get_Camera_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedCameraIndex_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_get_cameras_Public_Virtual_Final_New_get_IEnumerable_1_Camera_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraVolumeStack_Public_Abstract_Virtual_New_get_VolumeStack_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraLayerMask_Public_Abstract_Virtual_New_get_LayerMask_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraPosition_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedComponentType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedComponentType_Public_Virtual_Final_New_set_Void_Type_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeComponentsPathAndType_Public_Virtual_Final_New_get_List_1_ValueTuple_2_String_Type_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_get_targetRenderPipeline_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_GetParameter_Internal_VolumeParameter_VolumeComponent_FieldInfo_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_GetParameter_Internal_VolumeParameter_FieldInfo_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_GetParameter_Internal_VolumeParameter_Volume_FieldInfo_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_ComputeWeight_Private_Single_Volume_Vector3_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_GetVolumes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Volume_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_GetStates_Private_Il2CppObjectBase_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_ChangedStates_Private_Boolean_Il2CppObjectBase_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVolumes_Public_Virtual_Final_New_Boolean_Il2CppReferenceArray_1_Volume_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_GetVolumeWeight_Public_Virtual_Final_New_Single_Volume_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_VolumeHasInfluence_Public_Virtual_Final_New_Boolean_Volume_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_get_componentTypes_Public_Static_get_List_1_Type_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_ComponentDisplayName_Public_Static_String_Type_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_get_additionalCameraDatas_Protected_Static_get_List_1_T_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_set_additionalCameraDatas_Private_Static_set_Void_List_1_T_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCamera_Public_Static_Void_T_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterCamera_Public_Static_Void_T_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020001B8 RID: 440
		[ObfuscatedName("UnityEngine.Rendering.VolumeDebugSettings`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600184F RID: 6223 RVA: 0x00067228 File Offset: 0x00065428
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr);
				VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, "<>9");
				VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, "<>9__35_0");
				VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, "<>9__37_0");
				VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, "<>9__44_0");
				VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__44_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, "<>9__44_1");
				VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__44_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, "<>9__44_2");
				VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, 100664637);
				VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__GetVolumes_b__35_0_Internal_Boolean_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, 100664638);
				VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__GetStates_b__37_0_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, 100664639);
				VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__get_componentTypes_b__44_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, 100664640);
				VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__get_componentTypes_b__44_1_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, 100664641);
				VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__get_componentTypes_b__44_2_Internal_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr, 100664642);
			}

			// Token: 0x06001850 RID: 6224 RVA: 0x00067380 File Offset: 0x00065580
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001851 RID: 6225 RVA: 0x000673BC File Offset: 0x000655BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965495, XrefRangeEnd = 965509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetVolumes_b__35_0(Volume v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__GetVolumes_b__35_0_Internal_Boolean_Volume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001852 RID: 6226 RVA: 0x0006740C File Offset: 0x0006560C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965509, XrefRangeEnd = 965516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetStates_b__37_0(FieldInfo t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__GetStates_b__37_0_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001853 RID: 6227 RVA: 0x0006745C File Offset: 0x0006565C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965516, XrefRangeEnd = 965522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_componentTypes_b__44_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__get_componentTypes_b__44_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001854 RID: 6228 RVA: 0x000674AC File Offset: 0x000656AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965522, XrefRangeEnd = 965528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_componentTypes_b__44_1(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__get_componentTypes_b__44_1_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001855 RID: 6229 RVA: 0x000674FC File Offset: 0x000656FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965528, XrefRangeEnd = 965531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _get_componentTypes_b__44_2(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.__c.NativeMethodInfoPtr__get_componentTypes_b__44_2_Internal_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001856 RID: 6230 RVA: 0x0000C165 File Offset: 0x0000A365
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D5 RID: 1749
			// (get) Token: 0x06001857 RID: 6231 RVA: 0x00067544 File Offset: 0x00065744
			// (set) Token: 0x06001858 RID: 6232 RVA: 0x0000C16E File Offset: 0x0000A36E
			public unsafe static VolumeDebugSettings<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeDebugSettings<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D6 RID: 1750
			// (get) Token: 0x06001859 RID: 6233 RVA: 0x0006756C File Offset: 0x0006576C
			// (set) Token: 0x0600185A RID: 6234 RVA: 0x0000C180 File Offset: 0x0000A380
			public unsafe static Func<Volume, bool> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Volume, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D7 RID: 1751
			// (get) Token: 0x0600185B RID: 6235 RVA: 0x00067594 File Offset: 0x00065794
			// (set) Token: 0x0600185C RID: 6236 RVA: 0x0000C192 File Offset: 0x0000A392
			public unsafe static Func<FieldInfo, bool> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D8 RID: 1752
			// (get) Token: 0x0600185D RID: 6237 RVA: 0x000675BC File Offset: 0x000657BC
			// (set) Token: 0x0600185E RID: 6238 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
			public unsafe static Func<Type, bool> __9__44_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__44_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D9 RID: 1753
			// (get) Token: 0x0600185F RID: 6239 RVA: 0x000675E4 File Offset: 0x000657E4
			// (set) Token: 0x06001860 RID: 6240 RVA: 0x0000C1B6 File Offset: 0x0000A3B6
			public unsafe static Func<Type, bool> __9__44_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__44_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__44_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x06001861 RID: 6241 RVA: 0x0006760C File Offset: 0x0006580C
			// (set) Token: 0x06001862 RID: 6242 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
			public unsafe static Func<Type, string> __9__44_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__44_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeDebugSettings<T>.__c.NativeFieldInfoPtr___9__44_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001198 RID: 4504
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001199 RID: 4505
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x0400119A RID: 4506
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x0400119B RID: 4507
			private static readonly IntPtr NativeFieldInfoPtr___9__44_0;

			// Token: 0x0400119C RID: 4508
			private static readonly IntPtr NativeFieldInfoPtr___9__44_1;

			// Token: 0x0400119D RID: 4509
			private static readonly IntPtr NativeFieldInfoPtr___9__44_2;

			// Token: 0x0400119E RID: 4510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400119F RID: 4511
			private static readonly IntPtr NativeMethodInfoPtr__GetVolumes_b__35_0_Internal_Boolean_Volume_0;

			// Token: 0x040011A0 RID: 4512
			private static readonly IntPtr NativeMethodInfoPtr__GetStates_b__37_0_Internal_Boolean_FieldInfo_0;

			// Token: 0x040011A1 RID: 4513
			private static readonly IntPtr NativeMethodInfoPtr__get_componentTypes_b__44_0_Internal_Boolean_Type_0;

			// Token: 0x040011A2 RID: 4514
			private static readonly IntPtr NativeMethodInfoPtr__get_componentTypes_b__44_1_Internal_Boolean_Type_0;

			// Token: 0x040011A3 RID: 4515
			private static readonly IntPtr NativeMethodInfoPtr__get_componentTypes_b__44_2_Internal_String_Type_0;
		}

		// Token: 0x020001B9 RID: 441
		[ObfuscatedName("UnityEngine.Rendering.VolumeDebugSettings`1+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Object
		{
			// Token: 0x06001863 RID: 6243 RVA: 0x00067634 File Offset: 0x00065834
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<VolumeDebugSettings<T>.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeDebugSettings<T>>.NativeClassPtr, "<>c__DisplayClass23_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c__DisplayClass23_0>.NativeClassPtr);
				VolumeDebugSettings<T>.__c__DisplayClass23_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c__DisplayClass23_0>.NativeClassPtr, "value");
				VolumeDebugSettings<T>.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c__DisplayClass23_0>.NativeClassPtr, 100664643);
				VolumeDebugSettings<T>.__c__DisplayClass23_0.NativeMethodInfoPtr__set_selectedComponentType_b__0_Internal_Boolean_ValueTuple_2_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c__DisplayClass23_0>.NativeClassPtr, 100664644);
			}

			// Token: 0x06001864 RID: 6244 RVA: 0x000676D8 File Offset: 0x000658D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeDebugSettings<T>.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001865 RID: 6245 RVA: 0x00067714 File Offset: 0x00065914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965531, XrefRangeEnd = 965535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _set_selectedComponentType_b__0(ValueTuple<string, Type> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(t));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeDebugSettings<T>.__c__DisplayClass23_0.NativeMethodInfoPtr__set_selectedComponentType_b__0_Internal_Boolean_ValueTuple_2_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001866 RID: 6246 RVA: 0x0000C1DA File Offset: 0x0000A3DA
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x06001867 RID: 6247 RVA: 0x00067768 File Offset: 0x00065968
			// (set) Token: 0x06001868 RID: 6248 RVA: 0x0000C1E3 File Offset: 0x0000A3E3
			public unsafe Type value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.__c__DisplayClass23_0.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeDebugSettings<T>.__c__DisplayClass23_0.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011A4 RID: 4516
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040011A5 RID: 4517
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011A6 RID: 4518
			private static readonly IntPtr NativeMethodInfoPtr__set_selectedComponentType_b__0_Internal_Boolean_ValueTuple_2_String_Type_0;
		}
	}
}
