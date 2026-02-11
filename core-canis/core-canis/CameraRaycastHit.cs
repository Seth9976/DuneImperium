using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000058 RID: 88
public sealed class CameraRaycastHit : ValueType
{
	// Token: 0x06000660 RID: 1632 RVA: 0x0002D66C File Offset: 0x0002B86C
	// Note: this type is marked as 'beforefieldinit'.
	static CameraRaycastHit()
	{
		Il2CppClassPointerStore<CameraRaycastHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "CameraRaycastHit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRaycastHit>.NativeClassPtr);
		CameraRaycastHit.NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRaycastHit>.NativeClassPtr, "Camera");
		CameraRaycastHit.NativeFieldInfoPtr_Hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRaycastHit>.NativeClassPtr, "Hit");
		CameraRaycastHit.NativeMethodInfoPtr__ctor_Public_Void_Camera_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHit>.NativeClassPtr, 100664265);
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x0002D6D8 File Offset: 0x0002B8D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859582, XrefRangeEnd = 859583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraRaycastHit(Camera camera, RaycastHit hit)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraRaycastHit>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hit;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHit.NativeMethodInfoPtr__ctor_Public_Void_Camera_RaycastHit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00004197 File Offset: 0x00002397
	public CameraRaycastHit(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x000041A0 File Offset: 0x000023A0
	public CameraRaycastHit()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraRaycastHit>.NativeClassPtr))
	{
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06000664 RID: 1636 RVA: 0x0002D738 File Offset: 0x0002B938
	// (set) Token: 0x06000665 RID: 1637 RVA: 0x000041B2 File Offset: 0x000023B2
	public unsafe Camera Camera
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRaycastHit.NativeFieldInfoPtr_Camera);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRaycastHit.NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06000666 RID: 1638 RVA: 0x0002D768 File Offset: 0x0002B968
	// (set) Token: 0x06000667 RID: 1639 RVA: 0x000041D1 File Offset: 0x000023D1
	public unsafe RaycastHit Hit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRaycastHit.NativeFieldInfoPtr_Hit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRaycastHit.NativeFieldInfoPtr_Hit)) = value;
		}
	}

	// Token: 0x040004CA RID: 1226
	private static readonly IntPtr NativeFieldInfoPtr_Camera;

	// Token: 0x040004CB RID: 1227
	private static readonly IntPtr NativeFieldInfoPtr_Hit;

	// Token: 0x040004CC RID: 1228
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_RaycastHit_0;
}
