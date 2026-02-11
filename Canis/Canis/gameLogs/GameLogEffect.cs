using System;
using Canis.messages.effect;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.gameLogs
{
	// Token: 0x020000A0 RID: 160
	public class GameLogEffect : EffectMessage
	{
		// Token: 0x060007CF RID: 1999 RVA: 0x00039090 File Offset: 0x00037290
		// Note: this type is marked as 'beforefieldinit'.
		static GameLogEffect()
		{
			Il2CppClassPointerStore<GameLogEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "GameLogEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogEffect>.NativeClassPtr);
			GameLogEffect.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogEffect>.NativeClassPtr, "log");
			GameLogEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogEffect>.NativeClassPtr, 100664885);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000390E8 File Offset: 0x000372E8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000050C6 File Offset: 0x000032C6
		public GameLogEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00039124 File Offset: 0x00037324
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x000050CF File Offset: 0x000032CF
		public unsafe SerializedGameLog log
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogEffect.NativeFieldInfoPtr_log);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogEffect.NativeFieldInfoPtr_log), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_log;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
