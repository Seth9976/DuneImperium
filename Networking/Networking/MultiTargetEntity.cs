using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000009 RID: 9
public class MultiTargetEntity : Object
{
	// Token: 0x0600003E RID: 62 RVA: 0x00006AD8 File Offset: 0x00004CD8
	// Note: this type is marked as 'beforefieldinit'.
	static MultiTargetEntity()
	{
		Il2CppClassPointerStore<MultiTargetEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "", "MultiTargetEntity");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiTargetEntity>.NativeClassPtr);
		MultiTargetEntity.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTargetEntity>.NativeClassPtr, "Entity");
		MultiTargetEntity.NativeFieldInfoPtr_NoDupe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTargetEntity>.NativeClassPtr, "NoDupe");
		MultiTargetEntity.NativeFieldInfoPtr_PickFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTargetEntity>.NativeClassPtr, "PickFirst");
		MultiTargetEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTargetEntity>.NativeClassPtr, 100663308);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00006B58 File Offset: 0x00004D58
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MultiTargetEntity()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiTargetEntity>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiTargetEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x000022F1 File Offset: 0x000004F1
	public MultiTargetEntity(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000041 RID: 65 RVA: 0x00006B94 File Offset: 0x00004D94
	// (set) Token: 0x06000042 RID: 66 RVA: 0x000022FA File Offset: 0x000004FA
	public unsafe EntityID Entity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTargetEntity.NativeFieldInfoPtr_Entity);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTargetEntity.NativeFieldInfoPtr_Entity), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000043 RID: 67 RVA: 0x00006BC4 File Offset: 0x00004DC4
	// (set) Token: 0x06000044 RID: 68 RVA: 0x00002319 File Offset: 0x00000519
	public unsafe bool NoDupe
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTargetEntity.NativeFieldInfoPtr_NoDupe);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTargetEntity.NativeFieldInfoPtr_NoDupe)) = value;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000045 RID: 69 RVA: 0x00006BEC File Offset: 0x00004DEC
	// (set) Token: 0x06000046 RID: 70 RVA: 0x00002334 File Offset: 0x00000534
	public unsafe bool PickFirst
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTargetEntity.NativeFieldInfoPtr_PickFirst);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTargetEntity.NativeFieldInfoPtr_PickFirst)) = value;
		}
	}

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeFieldInfoPtr_Entity;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeFieldInfoPtr_NoDupe;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeFieldInfoPtr_PickFirst;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
