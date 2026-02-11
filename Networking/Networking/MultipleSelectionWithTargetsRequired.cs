using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;

// Token: 0x02000007 RID: 7
public class MultipleSelectionWithTargetsRequired : SelectionMessage
{
	// Token: 0x06000024 RID: 36 RVA: 0x00006750 File Offset: 0x00004950
	// Note: this type is marked as 'beforefieldinit'.
	static MultipleSelectionWithTargetsRequired()
	{
		Il2CppClassPointerStore<MultipleSelectionWithTargetsRequired>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "", "MultipleSelectionWithTargetsRequired");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleSelectionWithTargetsRequired>.NativeClassPtr);
		MultipleSelectionWithTargetsRequired.NativeFieldInfoPtr_ForcedTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsRequired>.NativeClassPtr, "ForcedTargets");
		MultipleSelectionWithTargetsRequired.NativeFieldInfoPtr_TargetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsRequired>.NativeClassPtr, "TargetMap");
		MultipleSelectionWithTargetsRequired.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsRequired>.NativeClassPtr, "Forced");
		MultipleSelectionWithTargetsRequired.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsRequired>.NativeClassPtr, 100663306);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000067D0 File Offset: 0x000049D0
	[CallerCount(114)]
	[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MultipleSelectionWithTargetsRequired()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleSelectionWithTargetsRequired>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsRequired.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000021B9 File Offset: 0x000003B9
	public MultipleSelectionWithTargetsRequired(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000027 RID: 39 RVA: 0x0000680C File Offset: 0x00004A0C
	// (set) Token: 0x06000028 RID: 40 RVA: 0x000021C2 File Offset: 0x000003C2
	public unsafe Il2CppReferenceArray<EntityID> ForcedTargets
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsRequired.NativeFieldInfoPtr_ForcedTargets);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityID>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsRequired.NativeFieldInfoPtr_ForcedTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000029 RID: 41 RVA: 0x0000683C File Offset: 0x00004A3C
	// (set) Token: 0x0600002A RID: 42 RVA: 0x000021E1 File Offset: 0x000003E1
	public unsafe Dictionary<EntityID, MultipleTargetInformation> TargetMap
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsRequired.NativeFieldInfoPtr_TargetMap);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, MultipleTargetInformation>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsRequired.NativeFieldInfoPtr_TargetMap), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600002B RID: 43 RVA: 0x0000686C File Offset: 0x00004A6C
	// (set) Token: 0x0600002C RID: 44 RVA: 0x00002200 File Offset: 0x00000400
	public unsafe bool Forced
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsRequired.NativeFieldInfoPtr_Forced);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsRequired.NativeFieldInfoPtr_Forced)) = value;
		}
	}

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeFieldInfoPtr_ForcedTargets;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeFieldInfoPtr_TargetMap;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeFieldInfoPtr_Forced;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
