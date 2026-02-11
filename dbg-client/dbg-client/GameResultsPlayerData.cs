using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x0200000C RID: 12
public class GameResultsPlayerData : DataComponent
{
	// Token: 0x06000051 RID: 81 RVA: 0x0001E690 File Offset: 0x0001C890
	// Note: this type is marked as 'beforefieldinit'.
	static GameResultsPlayerData()
	{
		Il2CppClassPointerStore<GameResultsPlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "GameResultsPlayerData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsPlayerData>.NativeClassPtr);
		GameResultsPlayerData.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPlayerData>.NativeClassPtr, "playerName");
		GameResultsPlayerData.NativeFieldInfoPtr_didWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPlayerData>.NativeClassPtr, "didWin");
		GameResultsPlayerData.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPlayerData>.NativeClassPtr, "accountID");
		GameResultsPlayerData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPlayerData>.NativeClassPtr, 100663361);
		GameResultsPlayerData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPlayerData>.NativeClassPtr, 100663362);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0001E724 File Offset: 0x0001C924
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 495286, RefRangeEnd = 495289, XrefRangeStart = 495283, XrefRangeEnd = 495286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameResultsPlayerData(string playerName, bool didWin, AccountID accountID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsPlayerData>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref didWin;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPlayerData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000053 RID: 83 RVA: 0x0001E790 File Offset: 0x0001C990
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495289, XrefRangeEnd = 495295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsPlayerData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002230 File Offset: 0x00000430
	public GameResultsPlayerData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000055 RID: 85 RVA: 0x0001E7D4 File Offset: 0x0001C9D4
	// (set) Token: 0x06000056 RID: 86 RVA: 0x00002239 File Offset: 0x00000439
	public unsafe string playerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPlayerData.NativeFieldInfoPtr_playerName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPlayerData.NativeFieldInfoPtr_playerName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000057 RID: 87 RVA: 0x0001E7FC File Offset: 0x0001C9FC
	// (set) Token: 0x06000058 RID: 88 RVA: 0x00002258 File Offset: 0x00000458
	public unsafe bool didWin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPlayerData.NativeFieldInfoPtr_didWin);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPlayerData.NativeFieldInfoPtr_didWin)) = value;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000059 RID: 89 RVA: 0x0001E824 File Offset: 0x0001CA24
	// (set) Token: 0x0600005A RID: 90 RVA: 0x00002273 File Offset: 0x00000473
	public unsafe AccountID accountID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPlayerData.NativeFieldInfoPtr_accountID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPlayerData.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeFieldInfoPtr_playerName;

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeFieldInfoPtr_didWin;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeFieldInfoPtr_accountID;

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_AccountID_0;

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
