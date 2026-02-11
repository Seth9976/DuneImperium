using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.gameLogs
{
	// Token: 0x0200009F RID: 159
	public static class GameLogBuilderExtensions : Object
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x00005084 File Offset: 0x00003284
		// Note: this type is marked as 'beforefieldinit'.
		static GameLogBuilderExtensions()
		{
			Il2CppClassPointerStore<GameLogBuilderExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "GameLogBuilderExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogBuilderExtensions>.NativeClassPtr);
			GameLogBuilderExtensions.NativeMethodInfoPtr_Add_Public_Static_Action_GameLogBuilder_IHasGameLogManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilderExtensions>.NativeClassPtr, 100664884);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00039038 File Offset: 0x00037238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558521, XrefRangeEnd = 558526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action Add(this GameLogBuilder gameLogBuilder, IHasGameLogManager hasLogManager)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hasLogManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilderExtensions.NativeMethodInfoPtr_Add_Public_Static_Action_GameLogBuilder_IHasGameLogManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000050BD File Offset: 0x000032BD
		public GameLogBuilderExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Action_GameLogBuilder_IHasGameLogManager_0;
	}
}
