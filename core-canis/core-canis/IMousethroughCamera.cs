using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200004A RID: 74
public class IMousethroughCamera : Il2CppObjectBase
{
	// Token: 0x060005A8 RID: 1448 RVA: 0x0002A014 File Offset: 0x00028214
	// Note: this type is marked as 'beforefieldinit'.
	static IMousethroughCamera()
	{
		Il2CppClassPointerStore<IMousethroughCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "IMousethroughCamera");
		IMousethroughCamera.NativeMethodInfoPtr_GetMousethroughHits_Public_Abstract_Virtual_New_Il2CppStructArray_1_RaycastHit_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMousethroughCamera>.NativeClassPtr, 100664136);
		IMousethroughCamera.NativeMethodInfoPtr_GetBestHit_Public_Abstract_Virtual_New_Nullable_1_RaycastHit_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMousethroughCamera>.NativeClassPtr, 100664137);
		IMousethroughCamera.NativeMethodInfoPtr_get_VirtualParent_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMousethroughCamera>.NativeClassPtr, 100664138);
		IMousethroughCamera.NativeMethodInfoPtr_get_Camera_Public_Abstract_Virtual_New_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMousethroughCamera>.NativeClassPtr, 100664139);
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x0002A08C File Offset: 0x0002828C
	[CallerCount(0)]
	public unsafe virtual Il2CppStructArray<RaycastHit> GetMousethroughHits(Vector3 screenPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref screenPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMousethroughCamera.NativeMethodInfoPtr_GetMousethroughHits_Public_Abstract_Virtual_New_Il2CppStructArray_1_RaycastHit_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x0002A0E4 File Offset: 0x000282E4
	[CallerCount(0)]
	public unsafe virtual Nullable<RaycastHit> GetBestHit(Vector3 screenPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref screenPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMousethroughCamera.NativeMethodInfoPtr_GetBestHit_Public_Abstract_Virtual_New_Nullable_1_RaycastHit_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<RaycastHit>(intPtr);
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x060005AB RID: 1451 RVA: 0x0002A134 File Offset: 0x00028334
	public unsafe virtual Transform VirtualParent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMousethroughCamera.NativeMethodInfoPtr_get_VirtualParent_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x060005AC RID: 1452 RVA: 0x0002A180 File Offset: 0x00028380
	public unsafe virtual Camera Camera
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMousethroughCamera.NativeMethodInfoPtr_get_Camera_Public_Abstract_Virtual_New_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
		}
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x00003FB3 File Offset: 0x000021B3
	public IMousethroughCamera(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000438 RID: 1080
	private static readonly IntPtr NativeMethodInfoPtr_GetMousethroughHits_Public_Abstract_Virtual_New_Il2CppStructArray_1_RaycastHit_Vector3_0;

	// Token: 0x04000439 RID: 1081
	private static readonly IntPtr NativeMethodInfoPtr_GetBestHit_Public_Abstract_Virtual_New_Nullable_1_RaycastHit_Vector3_0;

	// Token: 0x0400043A RID: 1082
	private static readonly IntPtr NativeMethodInfoPtr_get_VirtualParent_Public_Abstract_Virtual_New_get_Transform_0;

	// Token: 0x0400043B RID: 1083
	private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Public_Abstract_Virtual_New_get_Camera_0;
}
