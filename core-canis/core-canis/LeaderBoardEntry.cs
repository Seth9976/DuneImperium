using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200001A RID: 26
public class LeaderBoardEntry : Object
{
	// Token: 0x060002CC RID: 716 RVA: 0x0001D790 File Offset: 0x0001B990
	// Note: this type is marked as 'beforefieldinit'.
	static LeaderBoardEntry()
	{
		Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "LeaderBoardEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr);
		LeaderBoardEntry.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr, "AccountID");
		LeaderBoardEntry.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr, "Username");
		LeaderBoardEntry.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr, "Rank");
		LeaderBoardEntry.NativeFieldInfoPtr_DisplayRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr, "DisplayRank");
		LeaderBoardEntry.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr, "Score");
		LeaderBoardEntry.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr, "Region");
		LeaderBoardEntry.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr, "movement");
		LeaderBoardEntry.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr, "Attributes");
		LeaderBoardEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr, 100663673);
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0001D874 File Offset: 0x0001BA74
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeaderBoardEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderBoardEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderBoardEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002CE RID: 718 RVA: 0x000032E3 File Offset: 0x000014E3
	public LeaderBoardEntry(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x060002CF RID: 719 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
	// (set) Token: 0x060002D0 RID: 720 RVA: 0x000032EC File Offset: 0x000014EC
	public unsafe AccountID AccountID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_AccountID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060002D1 RID: 721 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
	// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000330B File Offset: 0x0000150B
	public unsafe string Username
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_Username);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x060002D3 RID: 723 RVA: 0x0001D908 File Offset: 0x0001BB08
	// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000332A File Offset: 0x0000152A
	public unsafe int Rank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_Rank);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_Rank)) = value;
		}
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x060002D5 RID: 725 RVA: 0x0001D930 File Offset: 0x0001BB30
	// (set) Token: 0x060002D6 RID: 726 RVA: 0x00003345 File Offset: 0x00001545
	public unsafe string DisplayRank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_DisplayRank);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_DisplayRank), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x060002D7 RID: 727 RVA: 0x0001D958 File Offset: 0x0001BB58
	// (set) Token: 0x060002D8 RID: 728 RVA: 0x00003364 File Offset: 0x00001564
	public unsafe double Score
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_Score);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_Score)) = value;
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x060002D9 RID: 729 RVA: 0x0001D980 File Offset: 0x0001BB80
	// (set) Token: 0x060002DA RID: 730 RVA: 0x0000337F File Offset: 0x0000157F
	public unsafe string Region
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_Region);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_Region), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060002DB RID: 731 RVA: 0x0001D9A8 File Offset: 0x0001BBA8
	// (set) Token: 0x060002DC RID: 732 RVA: 0x0000339E File Offset: 0x0000159E
	public unsafe int movement
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_movement);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_movement)) = value;
		}
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060002DD RID: 733 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
	// (set) Token: 0x060002DE RID: 734 RVA: 0x000033B9 File Offset: 0x000015B9
	public unsafe Dictionary<string, string> Attributes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_Attributes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardEntry.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000208 RID: 520
	private static readonly IntPtr NativeFieldInfoPtr_AccountID;

	// Token: 0x04000209 RID: 521
	private static readonly IntPtr NativeFieldInfoPtr_Username;

	// Token: 0x0400020A RID: 522
	private static readonly IntPtr NativeFieldInfoPtr_Rank;

	// Token: 0x0400020B RID: 523
	private static readonly IntPtr NativeFieldInfoPtr_DisplayRank;

	// Token: 0x0400020C RID: 524
	private static readonly IntPtr NativeFieldInfoPtr_Score;

	// Token: 0x0400020D RID: 525
	private static readonly IntPtr NativeFieldInfoPtr_Region;

	// Token: 0x0400020E RID: 526
	private static readonly IntPtr NativeFieldInfoPtr_movement;

	// Token: 0x0400020F RID: 527
	private static readonly IntPtr NativeFieldInfoPtr_Attributes;

	// Token: 0x04000210 RID: 528
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
