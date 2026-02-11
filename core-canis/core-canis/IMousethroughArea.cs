using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000049 RID: 73
public class IMousethroughArea : Il2CppObjectBase
{
	// Token: 0x060005A2 RID: 1442 RVA: 0x00029E4C File Offset: 0x0002804C
	// Note: this type is marked as 'beforefieldinit'.
	static IMousethroughArea()
	{
		Il2CppClassPointerStore<IMousethroughArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "IMousethroughArea");
		IMousethroughArea.NativeMethodInfoPtr_GetMousethroughHits_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_CameraRaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMousethroughArea>.NativeClassPtr, 100664132);
		IMousethroughArea.NativeMethodInfoPtr_GetBestHit_Public_Abstract_Virtual_New_Nullable_1_CameraRaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMousethroughArea>.NativeClassPtr, 100664133);
		IMousethroughArea.NativeMethodInfoPtr_MousethroughScreenToLocalPoint_Public_Abstract_Virtual_New_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMousethroughArea>.NativeClassPtr, 100664134);
		IMousethroughArea.NativeMethodInfoPtr_MousethroughScreenToGlobalPoint_Public_Abstract_Virtual_New_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMousethroughArea>.NativeClassPtr, 100664135);
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00029EC4 File Offset: 0x000280C4
	[CallerCount(0)]
	public unsafe virtual Il2CppReferenceArray<CameraRaycastHit> GetMousethroughHits(RaycastHit hit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMousethroughArea.NativeMethodInfoPtr_GetMousethroughHits_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_CameraRaycastHit_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CameraRaycastHit>>(intPtr3) : null;
		}
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00029F1C File Offset: 0x0002811C
	[CallerCount(0)]
	public unsafe virtual Nullable<CameraRaycastHit> GetBestHit(RaycastHit hit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMousethroughArea.NativeMethodInfoPtr_GetBestHit_Public_Abstract_Virtual_New_Nullable_1_CameraRaycastHit_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<CameraRaycastHit>(intPtr);
		}
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x00029F6C File Offset: 0x0002816C
	[CallerCount(0)]
	public unsafe virtual Vector3 MousethroughScreenToLocalPoint(Vector2 screenPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref screenPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMousethroughArea.NativeMethodInfoPtr_MousethroughScreenToLocalPoint_Public_Abstract_Virtual_New_Vector3_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x00029FC0 File Offset: 0x000281C0
	[CallerCount(0)]
	public unsafe virtual Vector3 MousethroughScreenToGlobalPoint(Vector2 screenPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref screenPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMousethroughArea.NativeMethodInfoPtr_MousethroughScreenToGlobalPoint_Public_Abstract_Virtual_New_Vector3_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00003FAA File Offset: 0x000021AA
	public IMousethroughArea(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000434 RID: 1076
	private static readonly IntPtr NativeMethodInfoPtr_GetMousethroughHits_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_CameraRaycastHit_RaycastHit_0;

	// Token: 0x04000435 RID: 1077
	private static readonly IntPtr NativeMethodInfoPtr_GetBestHit_Public_Abstract_Virtual_New_Nullable_1_CameraRaycastHit_RaycastHit_0;

	// Token: 0x04000436 RID: 1078
	private static readonly IntPtr NativeMethodInfoPtr_MousethroughScreenToLocalPoint_Public_Abstract_Virtual_New_Vector3_Vector2_0;

	// Token: 0x04000437 RID: 1079
	private static readonly IntPtr NativeMethodInfoPtr_MousethroughScreenToGlobalPoint_Public_Abstract_Virtual_New_Vector3_Vector2_0;
}
