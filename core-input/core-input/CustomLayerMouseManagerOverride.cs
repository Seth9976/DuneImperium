using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class CustomLayerMouseManagerOverride : MonoBehaviour
{
	// Token: 0x0600000F RID: 15 RVA: 0x00007408 File Offset: 0x00005608
	// Note: this type is marked as 'beforefieldinit'.
	static CustomLayerMouseManagerOverride()
	{
		Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "", "CustomLayerMouseManagerOverride");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr);
		CustomLayerMouseManagerOverride.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr, "cam");
		CustomLayerMouseManagerOverride.NativeFieldInfoPtr_layersToInclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr, "layersToInclude");
		CustomLayerMouseManagerOverride.NativeMethodInfoPtr_GetHits_Public_Virtual_New_Void_Vector3_List_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr, 100663301);
		CustomLayerMouseManagerOverride.NativeMethodInfoPtr_useLayerMask_Protected_Void_Vector3_List_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr, 100663302);
		CustomLayerMouseManagerOverride.NativeMethodInfoPtr_GetBestHit_Public_Virtual_New_Nullable_1_CameraRaycastHit_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr, 100663303);
		CustomLayerMouseManagerOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr, 100663304);
		CustomLayerMouseManagerOverride.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr, 100663305);
		CustomLayerMouseManagerOverride.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr, 100663306);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000074D8 File Offset: 0x000056D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118973, XrefRangeEnd = 1118978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomLayerMouseManagerOverride.NativeMethodInfoPtr_GetHits_Public_Virtual_New_Void_Vector3_List_1_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00007534 File Offset: 0x00005734
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void useLayerMask(Vector3 screenPosition, List<RaycastHit> hits)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLayerMouseManagerOverride.NativeMethodInfoPtr_useLayerMask_Protected_Void_Vector3_List_1_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00007584 File Offset: 0x00005784
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118978, XrefRangeEnd = 1118987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Nullable<CameraRaycastHit> GetBestHit(Vector3 screenPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref screenPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomLayerMouseManagerOverride.NativeMethodInfoPtr_GetBestHit_Public_Virtual_New_Nullable_1_CameraRaycastHit_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<CameraRaycastHit>(intPtr);
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000075D4 File Offset: 0x000057D4
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomLayerMouseManagerOverride()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomLayerMouseManagerOverride>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLayerMouseManagerOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00007610 File Offset: 0x00005810
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual GameObject IGameObject_get_gameObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLayerMouseManagerOverride.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00007650 File Offset: 0x00005850
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Transform IGameObject_get_transform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLayerMouseManagerOverride.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000020DE File Offset: 0x000002DE
	public CustomLayerMouseManagerOverride(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000017 RID: 23 RVA: 0x00007690 File Offset: 0x00005890
	// (set) Token: 0x06000018 RID: 24 RVA: 0x000020E7 File Offset: 0x000002E7
	public unsafe Camera cam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLayerMouseManagerOverride.NativeFieldInfoPtr_cam);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLayerMouseManagerOverride.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000019 RID: 25 RVA: 0x000076C0 File Offset: 0x000058C0
	// (set) Token: 0x0600001A RID: 26 RVA: 0x00002106 File Offset: 0x00000306
	public unsafe LayerMask layersToInclude
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLayerMouseManagerOverride.NativeFieldInfoPtr_layersToInclude);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLayerMouseManagerOverride.NativeFieldInfoPtr_layersToInclude)) = value;
		}
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeFieldInfoPtr_cam;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeFieldInfoPtr_layersToInclude;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr_GetHits_Public_Virtual_New_Void_Vector3_List_1_RaycastHit_0;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_useLayerMask_Protected_Void_Vector3_List_1_RaycastHit_0;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr_GetBestHit_Public_Virtual_New_Nullable_1_CameraRaycastHit_Vector3_0;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0;
}
