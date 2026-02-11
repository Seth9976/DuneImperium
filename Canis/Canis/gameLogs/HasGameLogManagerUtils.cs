using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.gameLogs
{
	// Token: 0x020000A9 RID: 169
	public static class HasGameLogManagerUtils : Object
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x0000522B File Offset: 0x0000342B
		// Note: this type is marked as 'beforefieldinit'.
		static HasGameLogManagerUtils()
		{
			Il2CppClassPointerStore<HasGameLogManagerUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "HasGameLogManagerUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasGameLogManagerUtils>.NativeClassPtr);
			HasGameLogManagerUtils.NativeMethodInfoPtr_AddGameLog_Public_Static_Action_IHasGameLogManager_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasGameLogManagerUtils>.NativeClassPtr, 100664931);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00039CC0 File Offset: 0x00037EC0
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 558873, RefRangeEnd = 558969, XrefRangeStart = 558868, XrefRangeEnd = 558873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action AddGameLog(this IHasGameLogManager hasManager, GameLogBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasGameLogManagerUtils.NativeMethodInfoPtr_AddGameLog_Public_Static_Action_IHasGameLogManager_GameLogBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00005264 File Offset: 0x00003464
		public HasGameLogManagerUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_AddGameLog_Public_Static_Action_IHasGameLogManager_GameLogBuilder_0;
	}
}
