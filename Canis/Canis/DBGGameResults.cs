using System;
using Canis;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000007 RID: 7
public class DBGGameResults : GameMessage
{
	// Token: 0x06000032 RID: 50 RVA: 0x0001A420 File Offset: 0x00018620
	// Note: this type is marked as 'beforefieldinit'.
	static DBGGameResults()
	{
		Il2CppClassPointerStore<DBGGameResults>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "", "DBGGameResults");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGGameResults>.NativeClassPtr);
		DBGGameResults.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameResults>.NativeClassPtr, "saveData");
		DBGGameResults.NativeMethodInfoPtr_get_baseResults_Public_Abstract_Virtual_New_get_IEnumerable_1_DBGGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameResults>.NativeClassPtr, 100663304);
		DBGGameResults.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameResults>.NativeClassPtr, 100663305);
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000033 RID: 51 RVA: 0x0001A48C File Offset: 0x0001868C
	public unsafe virtual IEnumerable<DBGGameResultsEntry> baseResults
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGGameResults.NativeMethodInfoPtr_get_baseResults_Public_Abstract_Virtual_New_get_IEnumerable_1_DBGGameResultsEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DBGGameResultsEntry>>(intPtr3) : null;
		}
	}

	// Token: 0x06000034 RID: 52 RVA: 0x0001A4D8 File Offset: 0x000186D8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542957, XrefRangeEnd = 542958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DBGGameResults()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGGameResults>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGGameResults.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x000021EC File Offset: 0x000003EC
	public DBGGameResults(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000036 RID: 54 RVA: 0x0001A514 File Offset: 0x00018714
	// (set) Token: 0x06000037 RID: 55 RVA: 0x000021F5 File Offset: 0x000003F5
	public unsafe SaveData saveData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResults.NativeFieldInfoPtr_saveData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameResults.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeFieldInfoPtr_saveData;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeMethodInfoPtr_get_baseResults_Public_Abstract_Virtual_New_get_IEnumerable_1_DBGGameResultsEntry_0;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}
