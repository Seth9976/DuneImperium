using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.utils
{
	// Token: 0x020000F2 RID: 242
	public static class DBGTimerUtils : Object
	{
		// Token: 0x06000A70 RID: 2672 RVA: 0x0000700B File Offset: 0x0000520B
		// Note: this type is marked as 'beforefieldinit'.
		static DBGTimerUtils()
		{
			Il2CppClassPointerStore<DBGTimerUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.utils", "DBGTimerUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTimerUtils>.NativeClassPtr);
			DBGTimerUtils.NativeMethodInfoPtr_GetTimerDisplayString_Public_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTimerUtils>.NativeClassPtr, 100664799);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0003E3F8 File Offset: 0x0003C5F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506754, RefRangeEnd = 506755, XrefRangeStart = 506725, XrefRangeEnd = 506754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTimerDisplayString(TimeSpan timer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTimerUtils.NativeMethodInfoPtr_GetTimerDisplayString_Public_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00007044 File Offset: 0x00005244
		public DBGTimerUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_GetTimerDisplayString_Public_Static_String_TimeSpan_0;
	}
}
