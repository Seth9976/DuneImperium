using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.ranked.networking.responses
{
	// Token: 0x02000014 RID: 20
	public class RankedQueueJoined : NetworkMessageEvent
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00004BD0 File Offset: 0x00002DD0
		// Note: this type is marked as 'beforefieldinit'.
		static RankedQueueJoined()
		{
			Il2CppClassPointerStore<RankedQueueJoined>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.responses", "RankedQueueJoined");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedQueueJoined>.NativeClassPtr);
			RankedQueueJoined.NativeFieldInfoPtr_WaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedQueueJoined>.NativeClassPtr, "WaitTime");
			RankedQueueJoined.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedQueueJoined>.NativeClassPtr, 100663325);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004C28 File Offset: 0x00002E28
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedQueueJoined()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedQueueJoined>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedQueueJoined.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000025C6 File Offset: 0x000007C6
		public RankedQueueJoined(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00004C64 File Offset: 0x00002E64
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000025CF File Offset: 0x000007CF
		public unsafe long WaitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueJoined.NativeFieldInfoPtr_WaitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueJoined.NativeFieldInfoPtr_WaitTime)) = value;
			}
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_WaitTime;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
