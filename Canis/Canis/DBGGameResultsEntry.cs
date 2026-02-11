using System;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000008 RID: 8
public class DBGGameResultsEntry : Object
{
	// Token: 0x06000038 RID: 56 RVA: 0x0001A544 File Offset: 0x00018744
	// Note: this type is marked as 'beforefieldinit'.
	static DBGGameResultsEntry()
	{
		Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "", "DBGGameResultsEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr);
		DBGGameResultsEntry.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr, "AccountID");
		DBGGameResultsEntry.NativeFieldInfoPtr_PlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr, "PlayerName");
		DBGGameResultsEntry.NativeFieldInfoPtr_Winner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr, "Winner");
		DBGGameResultsEntry.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr, "Position");
		DBGGameResultsEntry.NativeFieldInfoPtr_ReplacedByAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr, "ReplacedByAI");
		DBGGameResultsEntry.NativeFieldInfoPtr_StartedAsAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr, "StartedAsAI");
		DBGGameResultsEntry.NativeMethodInfoPtr_get_key_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr, 100663306);
		DBGGameResultsEntry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr, 100663307);
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000039 RID: 57 RVA: 0x0001A614 File Offset: 0x00018814
	public unsafe virtual string key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542962, XrefRangeEnd = 542966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGGameResultsEntry.NativeMethodInfoPtr_get_key_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0001A658 File Offset: 0x00018858
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DBGGameResultsEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGGameResultsEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGGameResultsEntry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002214 File Offset: 0x00000414
	public DBGGameResultsEntry(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600003C RID: 60 RVA: 0x0001A694 File Offset: 0x00018894
	// (set) Token: 0x0600003D RID: 61 RVA: 0x0000221D File Offset: 0x0000041D
	public unsafe AccountID AccountID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_AccountID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x0600003E RID: 62 RVA: 0x0001A6C4 File Offset: 0x000188C4
	// (set) Token: 0x0600003F RID: 63 RVA: 0x0000223C File Offset: 0x0000043C
	public unsafe LocalizableText PlayerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_PlayerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_PlayerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000040 RID: 64 RVA: 0x0001A6F4 File Offset: 0x000188F4
	// (set) Token: 0x06000041 RID: 65 RVA: 0x0000225B File Offset: 0x0000045B
	public unsafe bool Winner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_Winner);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_Winner)) = value;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000042 RID: 66 RVA: 0x0001A71C File Offset: 0x0001891C
	// (set) Token: 0x06000043 RID: 67 RVA: 0x00002276 File Offset: 0x00000476
	public unsafe int Position
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_Position);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_Position)) = value;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000044 RID: 68 RVA: 0x0001A744 File Offset: 0x00018944
	// (set) Token: 0x06000045 RID: 69 RVA: 0x00002291 File Offset: 0x00000491
	public unsafe bool ReplacedByAI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_ReplacedByAI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_ReplacedByAI)) = value;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000046 RID: 70 RVA: 0x0001A76C File Offset: 0x0001896C
	// (set) Token: 0x06000047 RID: 71 RVA: 0x000022AC File Offset: 0x000004AC
	public unsafe bool StartedAsAI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_StartedAsAI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResultsEntry.NativeFieldInfoPtr_StartedAsAI)) = value;
		}
	}

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeFieldInfoPtr_AccountID;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeFieldInfoPtr_PlayerName;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeFieldInfoPtr_Winner;

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeFieldInfoPtr_Position;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeFieldInfoPtr_ReplacedByAI;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeFieldInfoPtr_StartedAsAI;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeMethodInfoPtr_get_key_Public_Virtual_New_get_String_0;

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}
