using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames
{
	// Token: 0x020000E5 RID: 229
	public class GameResultsDataParser : MonoBehaviour
	{
		// Token: 0x060009F4 RID: 2548 RVA: 0x0003CD10 File Offset: 0x0003AF10
		// Note: this type is marked as 'beforefieldinit'.
		static GameResultsDataParser()
		{
			Il2CppClassPointerStore<GameResultsDataParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames", "GameResultsDataParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsDataParser>.NativeClassPtr);
			GameResultsDataParser.NativeMethodInfoPtr_ParsePlayerData_Public_Virtual_New_GameResultsPlayerData_DBGGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsDataParser>.NativeClassPtr, 100664753);
			GameResultsDataParser.NativeMethodInfoPtr_FallbackPlayerData_Public_Static_GameResultsPlayerData_DBGGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsDataParser>.NativeClassPtr, 100664754);
			GameResultsDataParser.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsDataParser>.NativeClassPtr, 100664755);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0003CD7C File Offset: 0x0003AF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506464, XrefRangeEnd = 506468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameResultsPlayerData ParsePlayerData(DBGGameResultsEntry resultEntry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resultEntry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsDataParser.NativeMethodInfoPtr_ParsePlayerData_Public_Virtual_New_GameResultsPlayerData_DBGGameResultsEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameResultsPlayerData>(intPtr3) : null;
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0003CDD8 File Offset: 0x0003AFD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506472, RefRangeEnd = 506473, XrefRangeStart = 506468, XrefRangeEnd = 506472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameResultsPlayerData FallbackPlayerData(DBGGameResultsEntry resultEntry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resultEntry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsDataParser.NativeMethodInfoPtr_FallbackPlayerData_Public_Static_GameResultsPlayerData_DBGGameResultsEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameResultsPlayerData>(intPtr3) : null;
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0003CE1C File Offset: 0x0003B01C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameResultsDataParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsDataParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsDataParser.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00006BF6 File Offset: 0x00004DF6
		public GameResultsDataParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_ParsePlayerData_Public_Virtual_New_GameResultsPlayerData_DBGGameResultsEntry_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_FallbackPlayerData_Public_Static_GameResultsPlayerData_DBGGameResultsEntry_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
