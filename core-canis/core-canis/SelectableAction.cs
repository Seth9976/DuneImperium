using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000019 RID: 25
public class SelectableAction : Object
{
	// Token: 0x060002C1 RID: 705 RVA: 0x0001D610 File Offset: 0x0001B810
	// Note: this type is marked as 'beforefieldinit'.
	static SelectableAction()
	{
		Il2CppClassPointerStore<SelectableAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "SelectableAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableAction>.NativeClassPtr);
		SelectableAction.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableAction>.NativeClassPtr, "GameID");
		SelectableAction.NativeFieldInfoPtr_ActionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableAction>.NativeClassPtr, "ActionID");
		SelectableAction.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableAction>.NativeClassPtr, "Description");
		SelectableAction.NativeFieldInfoPtr_SelectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableAction>.NativeClassPtr, "SelectionType");
		SelectableAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableAction>.NativeClassPtr, 100663672);
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x0001D6A4 File Offset: 0x0001B8A4
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SelectableAction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableAction>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0000325E File Offset: 0x0000145E
	public SelectableAction(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060002C4 RID: 708 RVA: 0x0001D6E0 File Offset: 0x0001B8E0
	// (set) Token: 0x060002C5 RID: 709 RVA: 0x00003267 File Offset: 0x00001467
	public unsafe GameID GameID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableAction.NativeFieldInfoPtr_GameID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableAction.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060002C6 RID: 710 RVA: 0x0001D710 File Offset: 0x0001B910
	// (set) Token: 0x060002C7 RID: 711 RVA: 0x00003286 File Offset: 0x00001486
	public unsafe AbilityID ActionID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableAction.NativeFieldInfoPtr_ActionID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableAction.NativeFieldInfoPtr_ActionID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060002C8 RID: 712 RVA: 0x0001D740 File Offset: 0x0001B940
	// (set) Token: 0x060002C9 RID: 713 RVA: 0x000032A5 File Offset: 0x000014A5
	public unsafe string Description
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableAction.NativeFieldInfoPtr_Description);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableAction.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060002CA RID: 714 RVA: 0x0001D768 File Offset: 0x0001B968
	// (set) Token: 0x060002CB RID: 715 RVA: 0x000032C4 File Offset: 0x000014C4
	public unsafe string SelectionType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableAction.NativeFieldInfoPtr_SelectionType);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableAction.NativeFieldInfoPtr_SelectionType), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000203 RID: 515
	private static readonly IntPtr NativeFieldInfoPtr_GameID;

	// Token: 0x04000204 RID: 516
	private static readonly IntPtr NativeFieldInfoPtr_ActionID;

	// Token: 0x04000205 RID: 517
	private static readonly IntPtr NativeFieldInfoPtr_Description;

	// Token: 0x04000206 RID: 518
	private static readonly IntPtr NativeFieldInfoPtr_SelectionType;

	// Token: 0x04000207 RID: 519
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
