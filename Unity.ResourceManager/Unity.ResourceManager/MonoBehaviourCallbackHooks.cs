using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.Util;

// Token: 0x02000006 RID: 6
public class MonoBehaviourCallbackHooks : ComponentSingleton<MonoBehaviourCallbackHooks>
{
	// Token: 0x06000035 RID: 53 RVA: 0x00005BD4 File Offset: 0x00003DD4
	// Note: this type is marked as 'beforefieldinit'.
	static MonoBehaviourCallbackHooks()
	{
		Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "", "MonoBehaviourCallbackHooks");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr);
		MonoBehaviourCallbackHooks.NativeFieldInfoPtr_m_OnUpdateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr, "m_OnUpdateDelegate");
		MonoBehaviourCallbackHooks.NativeFieldInfoPtr_m_OnLateUpdateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr, "m_OnLateUpdateDelegate");
		MonoBehaviourCallbackHooks.NativeMethodInfoPtr_add_OnUpdateDelegate_Public_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr, 100663327);
		MonoBehaviourCallbackHooks.NativeMethodInfoPtr_remove_OnUpdateDelegate_Public_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr, 100663328);
		MonoBehaviourCallbackHooks.NativeMethodInfoPtr_add_OnLateUpdateDelegate_Internal_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr, 100663329);
		MonoBehaviourCallbackHooks.NativeMethodInfoPtr_remove_OnLateUpdateDelegate_Internal_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr, 100663330);
		MonoBehaviourCallbackHooks.NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr, 100663331);
		MonoBehaviourCallbackHooks.NativeMethodInfoPtr_Update_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr, 100663332);
		MonoBehaviourCallbackHooks.NativeMethodInfoPtr_LateUpdate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr, 100663333);
		MonoBehaviourCallbackHooks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr, 100663334);
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00005CCC File Offset: 0x00003ECC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135666, XrefRangeEnd = 1135676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnUpdateDelegate(Action<float> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourCallbackHooks.NativeMethodInfoPtr_add_OnUpdateDelegate_Public_add_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00005D10 File Offset: 0x00003F10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135676, XrefRangeEnd = 1135686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnUpdateDelegate(Action<float> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourCallbackHooks.NativeMethodInfoPtr_remove_OnUpdateDelegate_Public_rem_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00005D54 File Offset: 0x00003F54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135686, XrefRangeEnd = 1135696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnLateUpdateDelegate(Action<float> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourCallbackHooks.NativeMethodInfoPtr_add_OnLateUpdateDelegate_Internal_add_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00005D98 File Offset: 0x00003F98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135696, XrefRangeEnd = 1135706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnLateUpdateDelegate(Action<float> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourCallbackHooks.NativeMethodInfoPtr_remove_OnLateUpdateDelegate_Internal_rem_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00005DDC File Offset: 0x00003FDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135706, XrefRangeEnd = 1135708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetGameObjectName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBehaviourCallbackHooks.NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00005E20 File Offset: 0x00004020
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135708, XrefRangeEnd = 1135709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourCallbackHooks.NativeMethodInfoPtr_Update_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00005E54 File Offset: 0x00004054
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135709, XrefRangeEnd = 1135710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourCallbackHooks.NativeMethodInfoPtr_LateUpdate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00005E88 File Offset: 0x00004088
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135710, XrefRangeEnd = 1135713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBehaviourCallbackHooks()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviourCallbackHooks>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourCallbackHooks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x000021BB File Offset: 0x000003BB
	public MonoBehaviourCallbackHooks(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600003F RID: 63 RVA: 0x00005EC4 File Offset: 0x000040C4
	// (set) Token: 0x06000040 RID: 64 RVA: 0x000021C4 File Offset: 0x000003C4
	public unsafe Action<float> m_OnUpdateDelegate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourCallbackHooks.NativeFieldInfoPtr_m_OnUpdateDelegate);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourCallbackHooks.NativeFieldInfoPtr_m_OnUpdateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000041 RID: 65 RVA: 0x00005EF4 File Offset: 0x000040F4
	// (set) Token: 0x06000042 RID: 66 RVA: 0x000021E3 File Offset: 0x000003E3
	public unsafe Action<float> m_OnLateUpdateDelegate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourCallbackHooks.NativeFieldInfoPtr_m_OnLateUpdateDelegate);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourCallbackHooks.NativeFieldInfoPtr_m_OnLateUpdateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeFieldInfoPtr_m_OnUpdateDelegate;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeFieldInfoPtr_m_OnLateUpdateDelegate;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUpdateDelegate_Public_add_Void_Action_1_Single_0;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUpdateDelegate_Public_rem_Void_Action_1_Single_0;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeMethodInfoPtr_add_OnLateUpdateDelegate_Internal_add_Void_Action_1_Single_0;

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnLateUpdateDelegate_Internal_rem_Void_Action_1_Single_0;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_String_0;

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Void_0;

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Internal_Void_0;

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
