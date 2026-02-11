using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.matchmaking.messages.incoming
{
	// Token: 0x0200012D RID: 301
	public class MatchQueueEntered : NetworkMessageEvent
	{
		// Token: 0x060010F8 RID: 4344 RVA: 0x00056D28 File Offset: 0x00054F28
		// Note: this type is marked as 'beforefieldinit'.
		static MatchQueueEntered()
		{
			Il2CppClassPointerStore<MatchQueueEntered>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.matchmaking.messages.incoming", "MatchQueueEntered");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchQueueEntered>.NativeClassPtr);
			MatchQueueEntered.NativeFieldInfoPtr_EstimatedWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchQueueEntered>.NativeClassPtr, "EstimatedWaitTime");
			MatchQueueEntered.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchQueueEntered>.NativeClassPtr, 100665764);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00056D80 File Offset: 0x00054F80
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchQueueEntered()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchQueueEntered>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchQueueEntered.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00007EF0 File Offset: 0x000060F0
		public MatchQueueEntered(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x00056DBC File Offset: 0x00054FBC
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x00007EF9 File Offset: 0x000060F9
		public unsafe int EstimatedWaitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchQueueEntered.NativeFieldInfoPtr_EstimatedWaitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchQueueEntered.NativeFieldInfoPtr_EstimatedWaitTime)) = value;
			}
		}

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeFieldInfoPtr_EstimatedWaitTime;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
