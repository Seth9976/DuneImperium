using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using InControl;

// Token: 0x02000005 RID: 5
public class MenuActions : PlayerActionSet
{
	// Token: 0x0600003B RID: 59 RVA: 0x000037BC File Offset: 0x000019BC
	// Note: this type is marked as 'beforefieldinit'.
	static MenuActions()
	{
		Il2CppClassPointerStore<MenuActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "", "MenuActions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuActions>.NativeClassPtr);
		MenuActions.NativeFieldInfoPtr_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuActions>.NativeClassPtr, "Up");
		MenuActions.NativeFieldInfoPtr_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuActions>.NativeClassPtr, "Down");
		MenuActions.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuActions>.NativeClassPtr, "Left");
		MenuActions.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuActions>.NativeClassPtr, "Right");
		MenuActions.NativeFieldInfoPtr_Move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuActions>.NativeClassPtr, "Move");
		MenuActions.NativeFieldInfoPtr_Submit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuActions>.NativeClassPtr, "Submit");
		MenuActions.NativeFieldInfoPtr_Cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuActions>.NativeClassPtr, "Cancel");
		MenuActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuActions>.NativeClassPtr, 100663329);
		MenuActions.NativeMethodInfoPtr_CreateWithDefaultBindings_Public_Static_MenuActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuActions>.NativeClassPtr, 100663330);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000038A0 File Offset: 0x00001AA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251258, XrefRangeEnd = 1251285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MenuActions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuActions>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000038DC File Offset: 0x00001ADC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251347, RefRangeEnd = 1251348, XrefRangeStart = 1251285, XrefRangeEnd = 1251347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MenuActions CreateWithDefaultBindings()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuActions.NativeMethodInfoPtr_CreateWithDefaultBindings_Public_Static_MenuActions_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<MenuActions>(intPtr3) : null;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x0000225B File Offset: 0x0000045B
	public MenuActions(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600003F RID: 63 RVA: 0x00003910 File Offset: 0x00001B10
	// (set) Token: 0x06000040 RID: 64 RVA: 0x00002264 File Offset: 0x00000464
	public unsafe PlayerAction Up
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Up);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Up), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000041 RID: 65 RVA: 0x00003940 File Offset: 0x00001B40
	// (set) Token: 0x06000042 RID: 66 RVA: 0x00002283 File Offset: 0x00000483
	public unsafe PlayerAction Down
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Down);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Down), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000043 RID: 67 RVA: 0x00003970 File Offset: 0x00001B70
	// (set) Token: 0x06000044 RID: 68 RVA: 0x000022A2 File Offset: 0x000004A2
	public unsafe PlayerAction Left
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Left);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Left), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000045 RID: 69 RVA: 0x000039A0 File Offset: 0x00001BA0
	// (set) Token: 0x06000046 RID: 70 RVA: 0x000022C1 File Offset: 0x000004C1
	public unsafe PlayerAction Right
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Right);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Right), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000047 RID: 71 RVA: 0x000039D0 File Offset: 0x00001BD0
	// (set) Token: 0x06000048 RID: 72 RVA: 0x000022E0 File Offset: 0x000004E0
	public unsafe PlayerTwoAxisAction Move
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Move);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTwoAxisAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Move), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000049 RID: 73 RVA: 0x00003A00 File Offset: 0x00001C00
	// (set) Token: 0x0600004A RID: 74 RVA: 0x000022FF File Offset: 0x000004FF
	public unsafe PlayerAction Submit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Submit);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Submit), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600004B RID: 75 RVA: 0x00003A30 File Offset: 0x00001C30
	// (set) Token: 0x0600004C RID: 76 RVA: 0x0000231E File Offset: 0x0000051E
	public unsafe PlayerAction Cancel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Cancel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuActions.NativeFieldInfoPtr_Cancel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeFieldInfoPtr_Up;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeFieldInfoPtr_Down;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeFieldInfoPtr_Left;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeFieldInfoPtr_Right;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeFieldInfoPtr_Move;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeFieldInfoPtr_Submit;

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeFieldInfoPtr_Cancel;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeMethodInfoPtr_CreateWithDefaultBindings_Public_Static_MenuActions_0;
}
