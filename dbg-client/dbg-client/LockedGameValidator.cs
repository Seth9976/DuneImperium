using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000015 RID: 21
public class LockedGameValidator : VersionedSubscriber<PendingGameData>
{
	// Token: 0x060000C6 RID: 198 RVA: 0x0001FF34 File Offset: 0x0001E134
	// Note: this type is marked as 'beforefieldinit'.
	static LockedGameValidator()
	{
		Il2CppClassPointerStore<LockedGameValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "LockedGameValidator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockedGameValidator>.NativeClassPtr);
		LockedGameValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockedGameValidator>.NativeClassPtr, "<Valid>k__BackingField");
		LockedGameValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedGameValidator>.NativeClassPtr, 100663443);
		LockedGameValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedGameValidator>.NativeClassPtr, 100663444);
		LockedGameValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedGameValidator>.NativeClassPtr, 100663445);
		LockedGameValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedGameValidator>.NativeClassPtr, 100663446);
		LockedGameValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedGameValidator>.NativeClassPtr, 100663447);
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000C7 RID: 199 RVA: 0x0001FFDC File Offset: 0x0001E1DC
	// (set) Token: 0x060000C8 RID: 200 RVA: 0x00020018 File Offset: 0x0001E218
	public unsafe virtual bool Valid
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockedGameValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockedGameValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00020058 File Offset: 0x0001E258
	[CallerCount(0)]
	public unsafe virtual bool Validate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockedGameValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00020094 File Offset: 0x0001E294
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496009, XrefRangeEnd = 496010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void dirtyUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LockedGameValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x000200D0 File Offset: 0x0001E2D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496010, XrefRangeEnd = 496013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LockedGameValidator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockedGameValidator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockedGameValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002567 File Offset: 0x00000767
	public LockedGameValidator(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000CD RID: 205 RVA: 0x0002010C File Offset: 0x0001E30C
	// (set) Token: 0x060000CE RID: 206 RVA: 0x00002570 File Offset: 0x00000770
	public unsafe bool _Valid_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockedGameValidator.NativeFieldInfoPtr__Valid_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockedGameValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
		}
	}

	// Token: 0x0400007A RID: 122
	private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

	// Token: 0x0400007B RID: 123
	private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x0400007C RID: 124
	private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x0400007D RID: 125
	private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Boolean_0;

	// Token: 0x0400007E RID: 126
	private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

	// Token: 0x0400007F RID: 127
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
