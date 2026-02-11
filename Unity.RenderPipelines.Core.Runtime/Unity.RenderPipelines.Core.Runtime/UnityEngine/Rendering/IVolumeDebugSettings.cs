using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000074 RID: 116
	public class IVolumeDebugSettings : Il2CppObjectBase
	{
		// Token: 0x060007BF RID: 1983 RVA: 0x0002A8D4 File Offset: 0x00028AD4
		// Note: this type is marked as 'beforefieldinit'.
		static IVolumeDebugSettings()
		{
			Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IVolumeDebugSettings");
			IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedComponent_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664530);
			IVolumeDebugSettings.NativeMethodInfoPtr_set_selectedComponent_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664531);
			IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCamera_Public_Abstract_Virtual_New_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664532);
			IVolumeDebugSettings.NativeMethodInfoPtr_get_cameras_Public_Abstract_Virtual_New_get_IEnumerable_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664533);
			IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664534);
			IVolumeDebugSettings.NativeMethodInfoPtr_set_selectedCameraIndex_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664535);
			IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraVolumeStack_Public_Abstract_Virtual_New_get_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664536);
			IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraLayerMask_Public_Abstract_Virtual_New_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664537);
			IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraPosition_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664538);
			IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedComponentType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664539);
			IVolumeDebugSettings.NativeMethodInfoPtr_set_selectedComponentType_Public_Abstract_Virtual_New_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664540);
			IVolumeDebugSettings.NativeMethodInfoPtr_GetVolumes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664541);
			IVolumeDebugSettings.NativeMethodInfoPtr_VolumeHasInfluence_Public_Abstract_Virtual_New_Boolean_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664542);
			IVolumeDebugSettings.NativeMethodInfoPtr_RefreshVolumes_Public_Abstract_Virtual_New_Boolean_Il2CppReferenceArray_1_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664543);
			IVolumeDebugSettings.NativeMethodInfoPtr_GetVolumeWeight_Public_Abstract_Virtual_New_Single_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings>.NativeClassPtr, 100664544);
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0002AA28 File Offset: 0x00028C28
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x0002AA70 File Offset: 0x00028C70
		public unsafe virtual int selectedComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedComponent_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_set_selectedComponent_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0002AABC File Offset: 0x00028CBC
		public unsafe virtual Camera selectedCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCamera_Public_Abstract_Virtual_New_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x0002AB08 File Offset: 0x00028D08
		public unsafe virtual IEnumerable<Camera> cameras
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_get_cameras_Public_Abstract_Virtual_New_get_IEnumerable_1_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Camera>>(intPtr3) : null;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0002AB54 File Offset: 0x00028D54
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0002AB9C File Offset: 0x00028D9C
		public unsafe virtual int selectedCameraIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_set_selectedCameraIndex_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0002ABE8 File Offset: 0x00028DE8
		public unsafe virtual VolumeStack selectedCameraVolumeStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraVolumeStack_Public_Abstract_Virtual_New_get_VolumeStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeStack>(intPtr3) : null;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x0002AC34 File Offset: 0x00028E34
		public unsafe virtual LayerMask selectedCameraLayerMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraLayerMask_Public_Abstract_Virtual_New_get_LayerMask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0002AC7C File Offset: 0x00028E7C
		public unsafe virtual Vector3 selectedCameraPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraPosition_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0002ACC4 File Offset: 0x00028EC4
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x0002AD10 File Offset: 0x00028F10
		public unsafe virtual Type selectedComponentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_get_selectedComponentType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_set_selectedComponentType_Public_Abstract_Virtual_New_set_Void_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0002AD60 File Offset: 0x00028F60
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Volume> GetVolumes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_GetVolumes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Volume_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Volume>>(intPtr3) : null;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0002ADAC File Offset: 0x00028FAC
		[CallerCount(0)]
		public unsafe virtual bool VolumeHasInfluence(Volume volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_VolumeHasInfluence_Public_Abstract_Virtual_New_Boolean_Volume_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0002AE04 File Offset: 0x00029004
		[CallerCount(0)]
		public unsafe virtual bool RefreshVolumes(Il2CppReferenceArray<Volume> newVolumes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVolumes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_RefreshVolumes_Public_Abstract_Virtual_New_Boolean_Il2CppReferenceArray_1_Volume_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0002AE5C File Offset: 0x0002905C
		[CallerCount(0)]
		public unsafe virtual float GetVolumeWeight(Volume volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings.NativeMethodInfoPtr_GetVolumeWeight_Public_Abstract_Virtual_New_Single_Volume_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0000518B File Offset: 0x0000338B
		public IVolumeDebugSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedComponent_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedComponent_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCamera_Public_Abstract_Virtual_New_get_Camera_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_get_cameras_Public_Abstract_Virtual_New_get_IEnumerable_1_Camera_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedCameraIndex_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraVolumeStack_Public_Abstract_Virtual_New_get_VolumeStack_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraLayerMask_Public_Abstract_Virtual_New_get_LayerMask_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraPosition_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedComponentType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedComponentType_Public_Abstract_Virtual_New_set_Void_Type_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_GetVolumes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Volume_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_VolumeHasInfluence_Public_Abstract_Virtual_New_Boolean_Volume_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVolumes_Public_Abstract_Virtual_New_Boolean_Il2CppReferenceArray_1_Volume_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_GetVolumeWeight_Public_Abstract_Virtual_New_Single_Volume_0;
	}
}
