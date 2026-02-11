using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002A5 RID: 677
	public class LeaderboardButtonBehaviour : MonoBehaviour
	{
		// Token: 0x0600203D RID: 8253 RVA: 0x00089120 File Offset: 0x00087320
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardButtonBehaviour()
		{
			Il2CppClassPointerStore<LeaderboardButtonBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "LeaderboardButtonBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardButtonBehaviour>.NativeClassPtr);
			LeaderboardButtonBehaviour.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardButtonBehaviour>.NativeClassPtr, "running");
			LeaderboardButtonBehaviour.NativeMethodInfoPtr_Event_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardButtonBehaviour>.NativeClassPtr, 100668654);
			LeaderboardButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardButtonBehaviour>.NativeClassPtr, 100668655);
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0008918C File Offset: 0x0008738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542199, XrefRangeEnd = 542205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardButtonBehaviour.NativeMethodInfoPtr_Event_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x000891C0 File Offset: 0x000873C0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaderboardButtonBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardButtonBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00010EA7 File Offset: 0x0000F0A7
		public LeaderboardButtonBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x000891FC File Offset: 0x000873FC
		// (set) Token: 0x06002042 RID: 8258 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		public unsafe Command running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardButtonBehaviour.NativeFieldInfoPtr_running);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardButtonBehaviour.NativeFieldInfoPtr_running), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_Event_Show_Public_Void_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
