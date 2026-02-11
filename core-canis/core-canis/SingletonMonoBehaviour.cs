using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000018 RID: 24
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
	// Token: 0x060002B6 RID: 694 RVA: 0x0001D2FC File Offset: 0x0001B4FC
	// Note: this type is marked as 'beforefieldinit'.
	static SingletonMonoBehaviour()
	{
		Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "SingletonMonoBehaviour`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr);
		SingletonMonoBehaviour<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr, 100663663);
		SingletonMonoBehaviour<T>.NativeMethodInfoPtr_DoesInstanceExist_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr, 100663664);
		SingletonMonoBehaviour<T>.NativeMethodInfoPtr_ActivateSingletonInstance_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr, 100663665);
		SingletonMonoBehaviour<T>.NativeMethodInfoPtr_SetSingletonAutoCreate_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr, 100663666);
		SingletonMonoBehaviour<T>.NativeMethodInfoPtr_SetSingletonType_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr, 100663667);
		SingletonMonoBehaviour<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr, 100663668);
		SingletonMonoBehaviour<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr, 100663669);
		SingletonMonoBehaviour<T>.NativeMethodInfoPtr_get_isSingletonObject_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr, 100663670);
		SingletonMonoBehaviour<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr, 100663671);
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060002B7 RID: 695 RVA: 0x0001D41C File Offset: 0x0001B61C
	public unsafe static T Instance
	{
		[CallerCount(68)]
		[CachedScanResults(RefRangeStart = 853775, RefRangeEnd = 853843, XrefRangeStart = 853755, XrefRangeEnd = 853775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehaviour<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x0001D44C File Offset: 0x0001B64C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 853848, RefRangeEnd = 853852, XrefRangeStart = 853843, XrefRangeEnd = 853848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T DoesInstanceExist()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehaviour<T>.NativeMethodInfoPtr_DoesInstanceExist_Public_Static_T_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0001D47C File Offset: 0x0001B67C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853852, XrefRangeEnd = 853857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ActivateSingletonInstance()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehaviour<T>.NativeMethodInfoPtr_ActivateSingletonInstance_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002BA RID: 698 RVA: 0x0001D4A4 File Offset: 0x0001B6A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853857, XrefRangeEnd = 853865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSingletonAutoCreate(GameObject autoCreatePrefab)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(autoCreatePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehaviour<T>.NativeMethodInfoPtr_SetSingletonAutoCreate_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060002BB RID: 699 RVA: 0x0001D4DC File Offset: 0x0001B6DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853865, XrefRangeEnd = 853873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSingletonType(Type type)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehaviour<T>.NativeMethodInfoPtr_SetSingletonType_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060002BC RID: 700 RVA: 0x0001D514 File Offset: 0x0001B714
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853880, RefRangeEnd = 853881, XrefRangeStart = 853873, XrefRangeEnd = 853880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingletonMonoBehaviour<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002BD RID: 701 RVA: 0x0001D550 File Offset: 0x0001B750
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853884, RefRangeEnd = 853885, XrefRangeStart = 853881, XrefRangeEnd = 853884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingletonMonoBehaviour<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060002BE RID: 702 RVA: 0x0001D58C File Offset: 0x0001B78C
	public unsafe virtual bool isSingletonObject
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingletonMonoBehaviour<T>.NativeMethodInfoPtr_get_isSingletonObject_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060002BF RID: 703 RVA: 0x0001D5D4 File Offset: 0x0001B7D4
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SingletonMonoBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingletonMonoBehaviour<T>>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonMonoBehaviour<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00003255 File Offset: 0x00001455
	public SingletonMonoBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040001FA RID: 506
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

	// Token: 0x040001FB RID: 507
	private static readonly IntPtr NativeMethodInfoPtr_DoesInstanceExist_Public_Static_T_0;

	// Token: 0x040001FC RID: 508
	private static readonly IntPtr NativeMethodInfoPtr_ActivateSingletonInstance_Public_Static_Void_0;

	// Token: 0x040001FD RID: 509
	private static readonly IntPtr NativeMethodInfoPtr_SetSingletonAutoCreate_Public_Static_Void_GameObject_0;

	// Token: 0x040001FE RID: 510
	private static readonly IntPtr NativeMethodInfoPtr_SetSingletonType_Public_Static_Void_Type_0;

	// Token: 0x040001FF RID: 511
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

	// Token: 0x04000200 RID: 512
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

	// Token: 0x04000201 RID: 513
	private static readonly IntPtr NativeMethodInfoPtr_get_isSingletonObject_Public_Virtual_New_get_Boolean_0;

	// Token: 0x04000202 RID: 514
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}
