using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using InControl;

// Token: 0x02000004 RID: 4
public class GameActions : PlayerActionSet
{
	// Token: 0x06000029 RID: 41 RVA: 0x00003518 File Offset: 0x00001718
	// Note: this type is marked as 'beforefieldinit'.
	static GameActions()
	{
		Il2CppClassPointerStore<GameActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "", "GameActions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameActions>.NativeClassPtr);
		GameActions.NativeFieldInfoPtr_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameActions>.NativeClassPtr, "Up");
		GameActions.NativeFieldInfoPtr_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameActions>.NativeClassPtr, "Down");
		GameActions.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameActions>.NativeClassPtr, "Left");
		GameActions.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameActions>.NativeClassPtr, "Right");
		GameActions.NativeFieldInfoPtr_Move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameActions>.NativeClassPtr, "Move");
		GameActions.NativeFieldInfoPtr_Attack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameActions>.NativeClassPtr, "Attack");
		GameActions.NativeFieldInfoPtr_Defend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameActions>.NativeClassPtr, "Defend");
		GameActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameActions>.NativeClassPtr, 100663327);
		GameActions.NativeMethodInfoPtr_CreateWithDefaultBindings_Public_Static_GameActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameActions>.NativeClassPtr, 100663328);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000035FC File Offset: 0x000017FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251181, XrefRangeEnd = 1251208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameActions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameActions>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00003638 File Offset: 0x00001838
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251257, RefRangeEnd = 1251258, XrefRangeStart = 1251208, XrefRangeEnd = 1251257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameActions CreateWithDefaultBindings()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameActions.NativeMethodInfoPtr_CreateWithDefaultBindings_Public_Static_GameActions_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameActions>(intPtr3) : null;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002179 File Offset: 0x00000379
	public GameActions(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600002D RID: 45 RVA: 0x0000366C File Offset: 0x0000186C
	// (set) Token: 0x0600002E RID: 46 RVA: 0x00002182 File Offset: 0x00000382
	public unsafe PlayerAction Up
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Up);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Up), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600002F RID: 47 RVA: 0x0000369C File Offset: 0x0000189C
	// (set) Token: 0x06000030 RID: 48 RVA: 0x000021A1 File Offset: 0x000003A1
	public unsafe PlayerAction Down
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Down);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Down), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000031 RID: 49 RVA: 0x000036CC File Offset: 0x000018CC
	// (set) Token: 0x06000032 RID: 50 RVA: 0x000021C0 File Offset: 0x000003C0
	public unsafe PlayerAction Left
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Left);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Left), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000033 RID: 51 RVA: 0x000036FC File Offset: 0x000018FC
	// (set) Token: 0x06000034 RID: 52 RVA: 0x000021DF File Offset: 0x000003DF
	public unsafe PlayerAction Right
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Right);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Right), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000035 RID: 53 RVA: 0x0000372C File Offset: 0x0000192C
	// (set) Token: 0x06000036 RID: 54 RVA: 0x000021FE File Offset: 0x000003FE
	public unsafe PlayerTwoAxisAction Move
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Move);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTwoAxisAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Move), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000037 RID: 55 RVA: 0x0000375C File Offset: 0x0000195C
	// (set) Token: 0x06000038 RID: 56 RVA: 0x0000221D File Offset: 0x0000041D
	public unsafe PlayerAction Attack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Attack);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Attack), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000039 RID: 57 RVA: 0x0000378C File Offset: 0x0000198C
	// (set) Token: 0x0600003A RID: 58 RVA: 0x0000223C File Offset: 0x0000043C
	public unsafe PlayerAction Defend
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Defend);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameActions.NativeFieldInfoPtr_Defend), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeFieldInfoPtr_Up;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeFieldInfoPtr_Down;

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeFieldInfoPtr_Left;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeFieldInfoPtr_Right;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeFieldInfoPtr_Move;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeFieldInfoPtr_Attack;

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeFieldInfoPtr_Defend;

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeMethodInfoPtr_CreateWithDefaultBindings_Public_Static_GameActions_0;
}
