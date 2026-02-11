using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;

// Token: 0x02000006 RID: 6
public class ArchetypeCustomChoiceRequired : SelectionMessage
{
	// Token: 0x06000015 RID: 21 RVA: 0x000064D8 File Offset: 0x000046D8
	// Note: this type is marked as 'beforefieldinit'.
	static ArchetypeCustomChoiceRequired()
	{
		Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "", "ArchetypeCustomChoiceRequired");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr);
		ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_Buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr, "Buttons");
		ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_SourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr, "SourceEntity");
		ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr, "Kind");
		ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_SelectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr, "SelectionParams");
		ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr, "forced");
		ArchetypeCustomChoiceRequired.NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr, 100663303);
		ArchetypeCustomChoiceRequired.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr, 100663304);
		ArchetypeCustomChoiceRequired.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr, 100663305);
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000016 RID: 22 RVA: 0x000065A8 File Offset: 0x000047A8
	public unsafe virtual Dictionary<string, Object> Params
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceRequired.NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000065E8 File Offset: 0x000047E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193395, XrefRangeEnd = 1193424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceRequired.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000662C File Offset: 0x0000482C
	[CallerCount(114)]
	[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ArchetypeCustomChoiceRequired()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCustomChoiceRequired>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceRequired.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002106 File Offset: 0x00000306
	public ArchetypeCustomChoiceRequired(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600001A RID: 26 RVA: 0x00006668 File Offset: 0x00004868
	// (set) Token: 0x0600001B RID: 27 RVA: 0x0000210F File Offset: 0x0000030F
	public unsafe List<SerializableAttributes> Buttons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_Buttons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializableAttributes>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_Buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600001C RID: 28 RVA: 0x00006698 File Offset: 0x00004898
	// (set) Token: 0x0600001D RID: 29 RVA: 0x0000212E File Offset: 0x0000032E
	public unsafe EntityID SourceEntity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_SourceEntity);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_SourceEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600001E RID: 30 RVA: 0x000066C8 File Offset: 0x000048C8
	// (set) Token: 0x0600001F RID: 31 RVA: 0x0000214D File Offset: 0x0000034D
	public unsafe string Kind
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_Kind);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_Kind), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000020 RID: 32 RVA: 0x000066F0 File Offset: 0x000048F0
	// (set) Token: 0x06000021 RID: 33 RVA: 0x0000216C File Offset: 0x0000036C
	public unsafe Dictionary<string, Object> SelectionParams
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_SelectionParams);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_SelectionParams), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000022 RID: 34 RVA: 0x00006720 File Offset: 0x00004920
	// (set) Token: 0x06000023 RID: 35 RVA: 0x0000218B File Offset: 0x0000038B
	public Nullable<bool> forced
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_forced);
			return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceRequired.NativeFieldInfoPtr_forced), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeFieldInfoPtr_Buttons;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeFieldInfoPtr_SourceEntity;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeFieldInfoPtr_Kind;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeFieldInfoPtr_SelectionParams;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeFieldInfoPtr_forced;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
