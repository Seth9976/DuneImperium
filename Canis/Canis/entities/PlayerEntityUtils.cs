using System;
using Canis.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000EF RID: 239
	public static class PlayerEntityUtils : Object
	{
		// Token: 0x06000AA0 RID: 2720 RVA: 0x00005DD5 File Offset: 0x00003FD5
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEntityUtils()
		{
			Il2CppClassPointerStore<PlayerEntityUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "PlayerEntityUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEntityUtils>.NativeClassPtr);
			PlayerEntityUtils.NativeMethodInfoPtr_PendingSelections_Public_Static_IReadOnlyCollection_1_PendingSelection_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntityUtils>.NativeClassPtr, 100665603);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00046CA8 File Offset: 0x00044EA8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 567341, RefRangeEnd = 567366, XrefRangeStart = 567325, XrefRangeEnd = 567341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IReadOnlyCollection<PendingSelection> PendingSelections(this PlayerEntity player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntityUtils.NativeMethodInfoPtr_PendingSelections_Public_Static_IReadOnlyCollection_1_PendingSelection_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<PendingSelection>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00005E0E File Offset: 0x0000400E
		public PlayerEntityUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_PendingSelections_Public_Static_IReadOnlyCollection_1_PendingSelection_PlayerEntity_0;
	}
}
