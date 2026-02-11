using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000005 RID: 5
public class AttributesReset : GameMessage
{
	// Token: 0x0600000F RID: 15 RVA: 0x000063BC File Offset: 0x000045BC
	// Note: this type is marked as 'beforefieldinit'.
	static AttributesReset()
	{
		Il2CppClassPointerStore<AttributesReset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "", "AttributesReset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributesReset>.NativeClassPtr);
		AttributesReset.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributesReset>.NativeClassPtr, "EntityID");
		AttributesReset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesReset>.NativeClassPtr, 100663301);
		AttributesReset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesReset>.NativeClassPtr, 100663302);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00006428 File Offset: 0x00004628
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193392, XrefRangeEnd = 1193395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesReset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000646C File Offset: 0x0000466C
	[CallerCount(114)]
	[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AttributesReset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributesReset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributesReset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000020DE File Offset: 0x000002DE
	public AttributesReset(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000013 RID: 19 RVA: 0x000064A8 File Offset: 0x000046A8
	// (set) Token: 0x06000014 RID: 20 RVA: 0x000020E7 File Offset: 0x000002E7
	public unsafe EntityID EntityID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributesReset.NativeFieldInfoPtr_EntityID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributesReset.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeFieldInfoPtr_EntityID;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
