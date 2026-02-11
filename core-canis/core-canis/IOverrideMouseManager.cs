using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200004B RID: 75
public class IOverrideMouseManager : Il2CppObjectBase
{
	// Token: 0x060005AE RID: 1454 RVA: 0x0002A1CC File Offset: 0x000283CC
	// Note: this type is marked as 'beforefieldinit'.
	static IOverrideMouseManager()
	{
		Il2CppClassPointerStore<IOverrideMouseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "IOverrideMouseManager");
		IOverrideMouseManager.NativeMethodInfoPtr_GetHits_Public_Abstract_Virtual_New_Void_Vector3_List_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOverrideMouseManager>.NativeClassPtr, 100664140);
		IOverrideMouseManager.NativeMethodInfoPtr_GetBestHit_Public_Abstract_Virtual_New_Nullable_1_CameraRaycastHit_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOverrideMouseManager>.NativeClassPtr, 100664141);
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x0002A21C File Offset: 0x0002841C
	[CallerCount(0)]
	public unsafe virtual void GetHits(Vector3 screenPosition, List<RaycastHit> hits)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref screenPosition;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOverrideMouseManager.NativeMethodInfoPtr_GetHits_Public_Abstract_Virtual_New_Void_Vector3_List_1_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x0002A278 File Offset: 0x00028478
	[CallerCount(0)]
	public unsafe virtual Nullable<CameraRaycastHit> GetBestHit(Vector3 screenPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref screenPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOverrideMouseManager.NativeMethodInfoPtr_GetBestHit_Public_Abstract_Virtual_New_Nullable_1_CameraRaycastHit_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<CameraRaycastHit>(intPtr);
		}
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00003FBC File Offset: 0x000021BC
	public IOverrideMouseManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400043C RID: 1084
	private static readonly IntPtr NativeMethodInfoPtr_GetHits_Public_Abstract_Virtual_New_Void_Vector3_List_1_RaycastHit_0;

	// Token: 0x0400043D RID: 1085
	private static readonly IntPtr NativeMethodInfoPtr_GetBestHit_Public_Abstract_Virtual_New_Nullable_1_CameraRaycastHit_Vector3_0;
}
