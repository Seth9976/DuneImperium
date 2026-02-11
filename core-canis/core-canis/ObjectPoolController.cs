using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000011 RID: 17
public static class ObjectPoolController : global::Il2CppSystem.Object
{
	// Token: 0x06000266 RID: 614 RVA: 0x0001C080 File Offset: 0x0001A280
	// Note: this type is marked as 'beforefieldinit'.
	static ObjectPoolController()
	{
		Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "ObjectPoolController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr);
		ObjectPoolController.NativeFieldInfoPtr__isDuringPreload_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, "<isDuringPreload>k__BackingField");
		ObjectPoolController.NativeFieldInfoPtr__globalSerialNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, "_globalSerialNumber");
		ObjectPoolController.NativeFieldInfoPtr__isDuringInstantiate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, "_isDuringInstantiate");
		ObjectPoolController.NativeFieldInfoPtr__pools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, "_pools");
		ObjectPoolController.NativeMethodInfoPtr_get_isDuringPreload_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, 100663607);
		ObjectPoolController.NativeMethodInfoPtr_set_isDuringPreload_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, 100663608);
		ObjectPoolController.NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, 100663609);
		ObjectPoolController.NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, 100663610);
		ObjectPoolController.NativeMethodInfoPtr_InstantiateWithoutPool_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, 100663611);
		ObjectPoolController.NativeMethodInfoPtr_InstantiateWithoutPool_Public_Static_GameObject_GameObject_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, 100663612);
		ObjectPoolController.NativeMethodInfoPtr_Destroy_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, 100663613);
		ObjectPoolController.NativeMethodInfoPtr_Preload_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, 100663614);
		ObjectPoolController.NativeMethodInfoPtr__GetPool_Internal_Static_ObjectPool_PoolableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, 100663615);
		ObjectPoolController.NativeMethodInfoPtr__DetachChildrenAndDestroy_Private_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, 100663616);
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000267 RID: 615 RVA: 0x0001C1C8 File Offset: 0x0001A3C8
	// (set) Token: 0x06000268 RID: 616 RVA: 0x0001C1F8 File Offset: 0x0001A3F8
	public unsafe static bool isDuringPreload
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853142, XrefRangeEnd = 853146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.NativeMethodInfoPtr_get_isDuringPreload_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853146, XrefRangeEnd = 853150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.NativeMethodInfoPtr_set_isDuringPreload_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000269 RID: 617 RVA: 0x0001C22C File Offset: 0x0001A42C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853150, XrefRangeEnd = 853174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject Instantiate(GameObject prefab)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x0600026A RID: 618 RVA: 0x0001C270 File Offset: 0x0001A470
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853199, RefRangeEnd = 853200, XrefRangeStart = 853174, XrefRangeEnd = 853199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject Instantiate(GameObject prefab, Vector3 position, Quaternion quaternion)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quaternion;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853200, XrefRangeEnd = 853206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject InstantiateWithoutPool(GameObject prefab)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.NativeMethodInfoPtr_InstantiateWithoutPool_Public_Static_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0001C314 File Offset: 0x0001A514
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 853227, RefRangeEnd = 853232, XrefRangeStart = 853206, XrefRangeEnd = 853227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject InstantiateWithoutPool(GameObject prefab, Vector3 position, Quaternion quaternion)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quaternion;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.NativeMethodInfoPtr_InstantiateWithoutPool_Public_Static_GameObject_GameObject_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0001C374 File Offset: 0x0001A574
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 853257, RefRangeEnd = 853260, XrefRangeStart = 853232, XrefRangeEnd = 853257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(GameObject obj)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.NativeMethodInfoPtr_Destroy_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0001C3AC File Offset: 0x0001A5AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853302, RefRangeEnd = 853303, XrefRangeStart = 853260, XrefRangeEnd = 853302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Preload(GameObject prefab)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.NativeMethodInfoPtr_Preload_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0001C3E4 File Offset: 0x0001A5E4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 853325, RefRangeEnd = 853328, XrefRangeStart = 853303, XrefRangeEnd = 853325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ObjectPoolController.ObjectPool _GetPool(PoolableObject prefabPoolComponent)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefabPoolComponent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.NativeMethodInfoPtr__GetPool_Internal_Static_ObjectPool_PoolableObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectPoolController.ObjectPool>(intPtr3) : null;
		}
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0001C428 File Offset: 0x0001A628
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853328, XrefRangeEnd = 853347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _DetachChildrenAndDestroy(Transform transform)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.NativeMethodInfoPtr__DetachChildrenAndDestroy_Private_Static_Void_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000271 RID: 625 RVA: 0x000030BA File Offset: 0x000012BA
	public ObjectPoolController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000272 RID: 626 RVA: 0x0001C460 File Offset: 0x0001A660
	// (set) Token: 0x06000273 RID: 627 RVA: 0x000030C3 File Offset: 0x000012C3
	public unsafe static bool _isDuringPreload_k__BackingField
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(ObjectPoolController.NativeFieldInfoPtr__isDuringPreload_k__BackingField, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ObjectPoolController.NativeFieldInfoPtr__isDuringPreload_k__BackingField, (void*)(&value));
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000274 RID: 628 RVA: 0x0001C47C File Offset: 0x0001A67C
	// (set) Token: 0x06000275 RID: 629 RVA: 0x000030D1 File Offset: 0x000012D1
	public unsafe static int _globalSerialNumber
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(ObjectPoolController.NativeFieldInfoPtr__globalSerialNumber, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ObjectPoolController.NativeFieldInfoPtr__globalSerialNumber, (void*)(&value));
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000276 RID: 630 RVA: 0x0001C498 File Offset: 0x0001A698
	// (set) Token: 0x06000277 RID: 631 RVA: 0x000030DF File Offset: 0x000012DF
	public unsafe static bool _isDuringInstantiate
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(ObjectPoolController.NativeFieldInfoPtr__isDuringInstantiate, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ObjectPoolController.NativeFieldInfoPtr__isDuringInstantiate, (void*)(&value));
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000278 RID: 632 RVA: 0x0001C4B4 File Offset: 0x0001A6B4
	// (set) Token: 0x06000279 RID: 633 RVA: 0x000030ED File Offset: 0x000012ED
	public unsafe static Dictionary<GameObject, ObjectPoolController.ObjectPool> _pools
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ObjectPoolController.NativeFieldInfoPtr__pools, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, ObjectPoolController.ObjectPool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ObjectPoolController.NativeFieldInfoPtr__pools, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040001C7 RID: 455
	private static readonly IntPtr NativeFieldInfoPtr__isDuringPreload_k__BackingField;

	// Token: 0x040001C8 RID: 456
	private static readonly IntPtr NativeFieldInfoPtr__globalSerialNumber;

	// Token: 0x040001C9 RID: 457
	private static readonly IntPtr NativeFieldInfoPtr__isDuringInstantiate;

	// Token: 0x040001CA RID: 458
	private static readonly IntPtr NativeFieldInfoPtr__pools;

	// Token: 0x040001CB RID: 459
	private static readonly IntPtr NativeMethodInfoPtr_get_isDuringPreload_Public_Static_get_Boolean_0;

	// Token: 0x040001CC RID: 460
	private static readonly IntPtr NativeMethodInfoPtr_set_isDuringPreload_Private_Static_set_Void_Boolean_0;

	// Token: 0x040001CD RID: 461
	private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_0;

	// Token: 0x040001CE RID: 462
	private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_Vector3_Quaternion_0;

	// Token: 0x040001CF RID: 463
	private static readonly IntPtr NativeMethodInfoPtr_InstantiateWithoutPool_Public_Static_GameObject_GameObject_0;

	// Token: 0x040001D0 RID: 464
	private static readonly IntPtr NativeMethodInfoPtr_InstantiateWithoutPool_Public_Static_GameObject_GameObject_Vector3_Quaternion_0;

	// Token: 0x040001D1 RID: 465
	private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_GameObject_0;

	// Token: 0x040001D2 RID: 466
	private static readonly IntPtr NativeMethodInfoPtr_Preload_Public_Static_Void_GameObject_0;

	// Token: 0x040001D3 RID: 467
	private static readonly IntPtr NativeMethodInfoPtr__GetPool_Internal_Static_ObjectPool_PoolableObject_0;

	// Token: 0x040001D4 RID: 468
	private static readonly IntPtr NativeMethodInfoPtr__DetachChildrenAndDestroy_Private_Static_Void_Transform_0;

	// Token: 0x02000234 RID: 564
	public class ObjectPool : global::Il2CppSystem.Object
	{
		// Token: 0x06001E64 RID: 7780 RVA: 0x0008AF3C File Offset: 0x0008913C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPool()
		{
			Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectPoolController>.NativeClassPtr, "ObjectPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr);
			ObjectPoolController.ObjectPool.NativeFieldInfoPtr__pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, "_pool");
			ObjectPoolController.ObjectPool.NativeFieldInfoPtr__prefabPoolObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, "_prefabPoolObj");
			ObjectPoolController.ObjectPool.NativeFieldInfoPtr__poolParentDummy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, "_poolParentDummy");
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr_get_poolParentDummy_Internal_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663618);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__ValidatePoolParentDummy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663619);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__ctor_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663620);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__ValidatePooledObjectDataContainer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663621);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr_Remove_Internal_Void_PoolableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663622);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr_GetObjectCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663623);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr_GetPooledInstance_Internal_GameObject_Nullable_1_Vector3_Nullable_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663624);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr_PreloadInstance_Internal_PoolableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663625);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__NewPooledInstance_Private_PoolableObject_Nullable_1_Vector3_Nullable_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663626);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__SetAllAvailable_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663627);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__GetAllObjects_Internal_Il2CppReferenceArray_1_PoolableObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663628);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__SetAvailable_Internal_Void_PoolableObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663629);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__SetActive_Private_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663630);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__GetActive_Private_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663631);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__SetActiveAndSendMessages_Private_Void_GameObject_PoolableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663632);
			ObjectPoolController.ObjectPool.NativeMethodInfoPtr__RecursivelySetInactiveAndSendMessages_Private_Void_GameObject_PoolableObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr, 100663633);
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x0008B0E4 File Offset: 0x000892E4
		public unsafe Transform poolParentDummy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852890, XrefRangeEnd = 852891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr_get_poolParentDummy_Internal_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0008B124 File Offset: 0x00089324
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 852909, RefRangeEnd = 852914, XrefRangeStart = 852891, XrefRangeEnd = 852909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ValidatePoolParentDummy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__ValidatePoolParentDummy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x0008B158 File Offset: 0x00089358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852914, XrefRangeEnd = 852920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPool(GameObject prefab)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPoolController.ObjectPool>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__ctor_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x0008B1A4 File Offset: 0x000893A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 852928, RefRangeEnd = 852931, XrefRangeStart = 852920, XrefRangeEnd = 852928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ValidatePooledObjectDataContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__ValidatePooledObjectDataContainer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x0008B1D8 File Offset: 0x000893D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852931, XrefRangeEnd = 852935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(PoolableObject poolObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poolObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr_Remove_Internal_Void_PoolableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0008B21C File Offset: 0x0008941C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852935, XrefRangeEnd = 852936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetObjectCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr_GetObjectCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0008B258 File Offset: 0x00089458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 852972, RefRangeEnd = 852974, XrefRangeStart = 852936, XrefRangeEnd = 852972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetPooledInstance(Nullable<Vector3> position, Nullable<Quaternion> rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(position));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rotation));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr_GetPooledInstance_Internal_GameObject_Nullable_1_Vector3_Nullable_1_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0008B2C4 File Offset: 0x000894C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852974, XrefRangeEnd = 852982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoolableObject PreloadInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr_PreloadInstance_Internal_PoolableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoolableObject>(intPtr3) : null;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0008B304 File Offset: 0x00089504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 853025, RefRangeEnd = 853027, XrefRangeStart = 852982, XrefRangeEnd = 853025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoolableObject _NewPooledInstance(Nullable<Vector3> position, Nullable<Quaternion> rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(position));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rotation));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__NewPooledInstance_Private_PoolableObject_Nullable_1_Vector3_Nullable_1_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoolableObject>(intPtr3) : null;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0008B370 File Offset: 0x00089570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853027, XrefRangeEnd = 853046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SetAllAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__SetAllAvailable_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0008B3AC File Offset: 0x000895AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853046, XrefRangeEnd = 853076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<PoolableObject> _GetAllObjects(bool includeInactiveObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactiveObjects;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__GetAllObjects_Internal_Il2CppReferenceArray_1_PoolableObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PoolableObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0008B3F8 File Offset: 0x000895F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 853090, RefRangeEnd = 853093, XrefRangeStart = 853076, XrefRangeEnd = 853090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetAvailable(PoolableObject poolObj, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poolObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__SetAvailable_Internal_Void_PoolableObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0008B448 File Offset: 0x00089648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853093, XrefRangeEnd = 853095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetActive(GameObject obj, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__SetActive_Private_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0008B498 File Offset: 0x00089698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853095, XrefRangeEnd = 853097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetActive(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__GetActive_Private_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0008B4E8 File Offset: 0x000896E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853097, XrefRangeEnd = 853108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetActiveAndSendMessages(GameObject obj, PoolableObject parentPoolObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentPoolObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__SetActiveAndSendMessages_Private_Void_GameObject_PoolableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0008B53C File Offset: 0x0008973C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 853138, RefRangeEnd = 853142, XrefRangeStart = 853108, XrefRangeEnd = 853138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RecursivelySetInactiveAndSendMessages(GameObject obj, PoolableObject parentPoolObj, bool recursiveCall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentPoolObj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursiveCall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPoolController.ObjectPool.NativeMethodInfoPtr__RecursivelySetInactiveAndSendMessages_Private_Void_GameObject_PoolableObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0000D074 File Offset: 0x0000B274
		public ObjectPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x0008B5A0 File Offset: 0x000897A0
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x0000D07D File Offset: 0x0000B27D
		public unsafe HashSet_Flash<PoolableObject> _pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPoolController.ObjectPool.NativeFieldInfoPtr__pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet_Flash<PoolableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPoolController.ObjectPool.NativeFieldInfoPtr__pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x0008B5D0 File Offset: 0x000897D0
		// (set) Token: 0x06001E79 RID: 7801 RVA: 0x0000D09C File Offset: 0x0000B29C
		public unsafe PoolableObject _prefabPoolObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPoolController.ObjectPool.NativeFieldInfoPtr__prefabPoolObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPoolController.ObjectPool.NativeFieldInfoPtr__prefabPoolObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x0008B600 File Offset: 0x00089800
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x0000D0BB File Offset: 0x0000B2BB
		public unsafe Transform _poolParentDummy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPoolController.ObjectPool.NativeFieldInfoPtr__poolParentDummy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPoolController.ObjectPool.NativeFieldInfoPtr__poolParentDummy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeFieldInfoPtr__pool;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeFieldInfoPtr__prefabPoolObj;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeFieldInfoPtr__poolParentDummy;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_get_poolParentDummy_Internal_get_Transform_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr__ValidatePoolParentDummy_Private_Void_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr__ValidatePooledObjectDataContainer_Private_Void_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_PoolableObject_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectCount_Internal_Int32_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_GetPooledInstance_Internal_GameObject_Nullable_1_Vector3_Nullable_1_Quaternion_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_PreloadInstance_Internal_PoolableObject_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr__NewPooledInstance_Private_PoolableObject_Nullable_1_Vector3_Nullable_1_Quaternion_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr__SetAllAvailable_Internal_Int32_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr__GetAllObjects_Internal_Il2CppReferenceArray_1_PoolableObject_Boolean_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr__SetAvailable_Internal_Void_PoolableObject_Boolean_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr__SetActive_Private_Void_GameObject_Boolean_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr__GetActive_Private_Boolean_GameObject_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr__SetActiveAndSendMessages_Private_Void_GameObject_PoolableObject_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr__RecursivelySetInactiveAndSendMessages_Private_Void_GameObject_PoolableObject_Boolean_0;
	}
}
