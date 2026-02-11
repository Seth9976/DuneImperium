using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000014 RID: 20
public class SetObjectActive : GameMessage
{
	// Token: 0x060000AD RID: 173 RVA: 0x00012D3C File Offset: 0x00010F3C
	// Note: this type is marked as 'beforefieldinit'.
	static SetObjectActive()
	{
		Il2CppClassPointerStore<SetObjectActive>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "SetObjectActive");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetObjectActive>.NativeClassPtr);
		SetObjectActive.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjectActive>.NativeClassPtr, "id");
		SetObjectActive.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjectActive>.NativeClassPtr, "active");
		SetObjectActive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActive>.NativeClassPtr, 100663436);
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00012DA8 File Offset: 0x00010FA8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SetObjectActive()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetObjectActive>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002454 File Offset: 0x00000654
	public SetObjectActive(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060000B0 RID: 176 RVA: 0x00012DE4 File Offset: 0x00010FE4
	// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000245D File Offset: 0x0000065D
	public unsafe string id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActive.NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActive.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x00012E0C File Offset: 0x0001100C
	// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000247C File Offset: 0x0000067C
	public unsafe bool active
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActive.NativeFieldInfoPtr_active);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActive.NativeFieldInfoPtr_active)) = value;
		}
	}

	// Token: 0x04000078 RID: 120
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x04000079 RID: 121
	private static readonly IntPtr NativeFieldInfoPtr_active;

	// Token: 0x0400007A RID: 122
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
