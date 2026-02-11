using System;
using boardgames.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000018 RID: 24
public static class MatchHistoryBridge : Object
{
	// Token: 0x060000C9 RID: 201 RVA: 0x00002507 File Offset: 0x00000707
	// Note: this type is marked as 'beforefieldinit'.
	static MatchHistoryBridge()
	{
		Il2CppClassPointerStore<MatchHistoryBridge>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "MatchHistoryBridge");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistoryBridge>.NativeClassPtr);
		MatchHistoryBridge.NativeMethodInfoPtr_LogOfflineMatchHistoryMessage_Public_Static_Void_DBGGameResults_GameOptionsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryBridge>.NativeClassPtr, 100663452);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00013280 File Offset: 0x00011480
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982859, RefRangeEnd = 982860, XrefRangeStart = 982823, XrefRangeEnd = 982859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogOfflineMatchHistoryMessage(DBGGameResults gameResults, GameOptionsData gameOptionsData)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameResults);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameOptionsData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryBridge.NativeMethodInfoPtr_LogOfflineMatchHistoryMessage_Public_Static_Void_DBGGameResults_GameOptionsData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002540 File Offset: 0x00000740
	public MatchHistoryBridge(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000087 RID: 135
	private static readonly IntPtr NativeMethodInfoPtr_LogOfflineMatchHistoryMessage_Public_Static_Void_DBGGameResults_GameOptionsData_0;
}
