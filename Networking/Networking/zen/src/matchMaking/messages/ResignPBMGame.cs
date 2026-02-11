using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace zen.src.matchMaking.messages
{
	// Token: 0x0200000D RID: 13
	public class ResignPBMGame : Object
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00007318 File Offset: 0x00005518
		// Note: this type is marked as 'beforefieldinit'.
		static ResignPBMGame()
		{
			Il2CppClassPointerStore<ResignPBMGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "zen.src.matchMaking.messages", "ResignPBMGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResignPBMGame>.NativeClassPtr);
			ResignPBMGame.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignPBMGame>.NativeClassPtr, "gameID");
			ResignPBMGame.NativeMethodInfoPtr__ctor_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignPBMGame>.NativeClassPtr, 100663324);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007370 File Offset: 0x00005570
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResignPBMGame(GameID gameID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResignPBMGame>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignPBMGame.NativeMethodInfoPtr__ctor_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000023FE File Offset: 0x000005FE
		public ResignPBMGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000073BC File Offset: 0x000055BC
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002407 File Offset: 0x00000607
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignPBMGame.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignPBMGame.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_0;
	}
}
