using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI;

// Token: 0x02000006 RID: 6
[Serializable]
public class DirectionalNavigationData : Object
{
	// Token: 0x0600001B RID: 27 RVA: 0x000076E8 File Offset: 0x000058E8
	// Note: this type is marked as 'beforefieldinit'.
	static DirectionalNavigationData()
	{
		Il2CppClassPointerStore<DirectionalNavigationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "", "DirectionalNavigationData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalNavigationData>.NativeClassPtr);
		DirectionalNavigationData.NativeFieldInfoPtr_TargetSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalNavigationData>.NativeClassPtr, "TargetSelectables");
		DirectionalNavigationData.NativeFieldInfoPtr_FallbackToAutomaticSearchBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalNavigationData>.NativeClassPtr, "FallbackToAutomaticSearchBehaviour");
		DirectionalNavigationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalNavigationData>.NativeClassPtr, 100663307);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00007754 File Offset: 0x00005954
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 500517, RefRangeEnd = 500518, XrefRangeStart = 500517, XrefRangeEnd = 500518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DirectionalNavigationData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectionalNavigationData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectionalNavigationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002121 File Offset: 0x00000321
	public DirectionalNavigationData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600001E RID: 30 RVA: 0x00007790 File Offset: 0x00005990
	// (set) Token: 0x0600001F RID: 31 RVA: 0x0000212A File Offset: 0x0000032A
	public unsafe List<Selectable> TargetSelectables
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectionalNavigationData.NativeFieldInfoPtr_TargetSelectables);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Selectable>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectionalNavigationData.NativeFieldInfoPtr_TargetSelectables), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000020 RID: 32 RVA: 0x000077C0 File Offset: 0x000059C0
	// (set) Token: 0x06000021 RID: 33 RVA: 0x00002149 File Offset: 0x00000349
	public unsafe bool FallbackToAutomaticSearchBehaviour
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectionalNavigationData.NativeFieldInfoPtr_FallbackToAutomaticSearchBehaviour);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectionalNavigationData.NativeFieldInfoPtr_FallbackToAutomaticSearchBehaviour)) = value;
		}
	}

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeFieldInfoPtr_TargetSelectables;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeFieldInfoPtr_FallbackToAutomaticSearchBehaviour;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
