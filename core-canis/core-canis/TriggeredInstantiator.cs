using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

// Token: 0x02000051 RID: 81
public class TriggeredInstantiator : MonoBehaviour
{
	// Token: 0x0600062B RID: 1579 RVA: 0x0002CB7C File Offset: 0x0002AD7C
	// Note: this type is marked as 'beforefieldinit'.
	static TriggeredInstantiator()
	{
		Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "TriggeredInstantiator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr);
		TriggeredInstantiator.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, "Prefab");
		TriggeredInstantiator.NativeFieldInfoPtr_ZeroOutTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, "ZeroOutTransform");
		TriggeredInstantiator.NativeFieldInfoPtr_siblingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, "siblingIndex");
		TriggeredInstantiator.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, "instance");
		TriggeredInstantiator.NativeMethodInfoPtr_GetPrefab_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664242);
		TriggeredInstantiator.NativeMethodInfoPtr_get_Instantiated_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664243);
		TriggeredInstantiator.NativeMethodInfoPtr_AnimationInstantiate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664244);
		TriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664245);
		TriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664246);
		TriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664247);
		TriggeredInstantiator.NativeMethodInfoPtr_configureInstance_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664248);
		TriggeredInstantiator.NativeMethodInfoPtr_cleanupInstance_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664249);
		TriggeredInstantiator.NativeMethodInfoPtr_DestroyInstance_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664250);
		TriggeredInstantiator.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664251);
		TriggeredInstantiator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664252);
		TriggeredInstantiator.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664253);
		TriggeredInstantiator.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr, 100664254);
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x0002CD00 File Offset: 0x0002AF00
	[CallerCount(0)]
	public unsafe GameObject GetPrefab()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.NativeMethodInfoPtr_GetPrefab_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x0600062D RID: 1581 RVA: 0x0002CD40 File Offset: 0x0002AF40
	public unsafe virtual bool Instantiated
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859439, XrefRangeEnd = 859443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.NativeMethodInfoPtr_get_Instantiated_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x0002CD7C File Offset: 0x0002AF7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859443, XrefRangeEnd = 859456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimationInstantiate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.NativeMethodInfoPtr_AnimationInstantiate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x0002CDB0 File Offset: 0x0002AFB0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859468, RefRangeEnd = 859469, XrefRangeStart = 859456, XrefRangeEnd = 859468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual GameObject Instantiate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0002CDF0 File Offset: 0x0002AFF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859482, RefRangeEnd = 859483, XrefRangeStart = 859469, XrefRangeEnd = 859482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual T Instantiate<T>() where T : class
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.MethodInfoStoreGeneric_Instantiate_Public_Virtual_Final_New_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x0002CE2C File Offset: 0x0002B02C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859483, XrefRangeEnd = 859495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Instantiate<T>(out T component) where T : class
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref component;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.MethodInfoStoreGeneric_Instantiate_Public_Virtual_Final_New_Void_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
		}
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x0002CEAC File Offset: 0x0002B0AC
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void configureInstance(GameObject created)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(created);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriggeredInstantiator.NativeMethodInfoPtr_configureInstance_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x0002CEFC File Offset: 0x0002B0FC
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void cleanupInstance(GameObject destroyed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destroyed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriggeredInstantiator.NativeMethodInfoPtr_cleanupInstance_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x0002CF4C File Offset: 0x0002B14C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859495, XrefRangeEnd = 859503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void DestroyInstance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.NativeMethodInfoPtr_DestroyInstance_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x0002CF80 File Offset: 0x0002B180
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859503, XrefRangeEnd = 859520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmosSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0002CFB4 File Offset: 0x0002B1B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859520, XrefRangeEnd = 859521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TriggeredInstantiator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x0002CFF0 File Offset: 0x0002B1F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual GameObject IGameObject_get_gameObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x0002D030 File Offset: 0x0002B230
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Transform IGameObject_get_transform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredInstantiator.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00004063 File Offset: 0x00002263
	public TriggeredInstantiator(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x0600063A RID: 1594 RVA: 0x0002D070 File Offset: 0x0002B270
	// (set) Token: 0x0600063B RID: 1595 RVA: 0x0000406C File Offset: 0x0000226C
	public unsafe GameObject Prefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredInstantiator.NativeFieldInfoPtr_Prefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredInstantiator.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x0600063C RID: 1596 RVA: 0x0002D0A0 File Offset: 0x0002B2A0
	// (set) Token: 0x0600063D RID: 1597 RVA: 0x0000408B File Offset: 0x0000228B
	public unsafe bool ZeroOutTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredInstantiator.NativeFieldInfoPtr_ZeroOutTransform);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredInstantiator.NativeFieldInfoPtr_ZeroOutTransform)) = value;
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x0600063E RID: 1598 RVA: 0x0002D0C8 File Offset: 0x0002B2C8
	// (set) Token: 0x0600063F RID: 1599 RVA: 0x000040A6 File Offset: 0x000022A6
	public unsafe int siblingIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredInstantiator.NativeFieldInfoPtr_siblingIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredInstantiator.NativeFieldInfoPtr_siblingIndex)) = value;
		}
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06000640 RID: 1600 RVA: 0x0002D0F0 File Offset: 0x0002B2F0
	// (set) Token: 0x06000641 RID: 1601 RVA: 0x000040C1 File Offset: 0x000022C1
	public unsafe GameObject instance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredInstantiator.NativeFieldInfoPtr_instance);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredInstantiator.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040004AC RID: 1196
	private static readonly IntPtr NativeFieldInfoPtr_Prefab;

	// Token: 0x040004AD RID: 1197
	private static readonly IntPtr NativeFieldInfoPtr_ZeroOutTransform;

	// Token: 0x040004AE RID: 1198
	private static readonly IntPtr NativeFieldInfoPtr_siblingIndex;

	// Token: 0x040004AF RID: 1199
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x040004B0 RID: 1200
	private static readonly IntPtr NativeMethodInfoPtr_GetPrefab_Public_GameObject_0;

	// Token: 0x040004B1 RID: 1201
	private static readonly IntPtr NativeMethodInfoPtr_get_Instantiated_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x040004B2 RID: 1202
	private static readonly IntPtr NativeMethodInfoPtr_AnimationInstantiate_Public_Void_0;

	// Token: 0x040004B3 RID: 1203
	private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_GameObject_0;

	// Token: 0x040004B4 RID: 1204
	private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_T_0;

	// Token: 0x040004B5 RID: 1205
	private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_Void_byref_T_0;

	// Token: 0x040004B6 RID: 1206
	private static readonly IntPtr NativeMethodInfoPtr_configureInstance_Protected_Virtual_New_Void_GameObject_0;

	// Token: 0x040004B7 RID: 1207
	private static readonly IntPtr NativeMethodInfoPtr_cleanupInstance_Protected_Virtual_New_Void_GameObject_0;

	// Token: 0x040004B8 RID: 1208
	private static readonly IntPtr NativeMethodInfoPtr_DestroyInstance_Public_Virtual_Final_New_Void_0;

	// Token: 0x040004B9 RID: 1209
	private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

	// Token: 0x040004BA RID: 1210
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040004BB RID: 1211
	private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0;

	// Token: 0x040004BC RID: 1212
	private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0;

	// Token: 0x02000278 RID: 632
	private sealed class MethodInfoStoreGeneric_Instantiate_Public_Virtual_Final_New_T_0<T>
	{
		// Token: 0x04001591 RID: 5521
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_T_0, Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000279 RID: 633
	private sealed class MethodInfoStoreGeneric_Instantiate_Public_Virtual_Final_New_Void_byref_T_0<T>
	{
		// Token: 0x04001592 RID: 5522
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_Void_byref_T_0, Il2CppClassPointerStore<TriggeredInstantiator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
