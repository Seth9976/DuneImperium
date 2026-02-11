using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace boardgames.datarenderers
{
	// Token: 0x02000170 RID: 368
	public class EventsForDailyChallengeBadgeRenderer : Subscriber<DailyChallengeBadgeData>
	{
		// Token: 0x06001058 RID: 4184 RVA: 0x000512B8 File Offset: 0x0004F4B8
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForDailyChallengeBadgeRenderer()
		{
			Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "EventsForDailyChallengeBadgeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer>.NativeClassPtr);
			EventsForDailyChallengeBadgeRenderer.NativeFieldInfoPtr_pairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer>.NativeClassPtr, "pairs");
			EventsForDailyChallengeBadgeRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer>.NativeClassPtr, 100665590);
			EventsForDailyChallengeBadgeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer>.NativeClassPtr, 100665591);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00051324 File Offset: 0x0004F524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513981, XrefRangeEnd = 513986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForDailyChallengeBadgeRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00051360 File Offset: 0x0004F560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513986, XrefRangeEnd = 513993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForDailyChallengeBadgeRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForDailyChallengeBadgeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00009EF8 File Offset: 0x000080F8
		public EventsForDailyChallengeBadgeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0005139C File Offset: 0x0004F59C
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x00009F01 File Offset: 0x00008101
		public unsafe Il2CppReferenceArray<EventsForDailyChallengeBadgeRenderer.StringEventPair> pairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDailyChallengeBadgeRenderer.NativeFieldInfoPtr_pairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventsForDailyChallengeBadgeRenderer.StringEventPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDailyChallengeBadgeRenderer.NativeFieldInfoPtr_pairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr_pairs;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000370 RID: 880
		[Serializable]
		public class StringEventPair : Object
		{
			// Token: 0x06002970 RID: 10608 RVA: 0x000A47D4 File Offset: 0x000A29D4
			// Note: this type is marked as 'beforefieldinit'.
			static StringEventPair()
			{
				Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer.StringEventPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer>.NativeClassPtr, "StringEventPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer.StringEventPair>.NativeClassPtr);
				EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeFieldInfoPtr_OnBadgeUnityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer.StringEventPair>.NativeClassPtr, "OnBadgeUnityEvent");
				EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeFieldInfoPtr_OnNotBadgeUnityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer.StringEventPair>.NativeClassPtr, "OnNotBadgeUnityEvent");
				EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeFieldInfoPtr_Badge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer.StringEventPair>.NativeClassPtr, "Badge");
				EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer.StringEventPair>.NativeClassPtr, 100665592);
			}

			// Token: 0x06002971 RID: 10609 RVA: 0x000A4850 File Offset: 0x000A2A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513977, XrefRangeEnd = 513981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringEventPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForDailyChallengeBadgeRenderer.StringEventPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002972 RID: 10610 RVA: 0x00015649 File Offset: 0x00013849
			public StringEventPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA7 RID: 2983
			// (get) Token: 0x06002973 RID: 10611 RVA: 0x000A488C File Offset: 0x000A2A8C
			// (set) Token: 0x06002974 RID: 10612 RVA: 0x00015652 File Offset: 0x00013852
			public unsafe UnityEvent OnBadgeUnityEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeFieldInfoPtr_OnBadgeUnityEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeFieldInfoPtr_OnBadgeUnityEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA8 RID: 2984
			// (get) Token: 0x06002975 RID: 10613 RVA: 0x000A48BC File Offset: 0x000A2ABC
			// (set) Token: 0x06002976 RID: 10614 RVA: 0x00015671 File Offset: 0x00013871
			public unsafe UnityEvent OnNotBadgeUnityEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeFieldInfoPtr_OnNotBadgeUnityEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeFieldInfoPtr_OnNotBadgeUnityEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA9 RID: 2985
			// (get) Token: 0x06002977 RID: 10615 RVA: 0x000A48EC File Offset: 0x000A2AEC
			// (set) Token: 0x06002978 RID: 10616 RVA: 0x00015690 File Offset: 0x00013890
			public unsafe string Badge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeFieldInfoPtr_Badge);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDailyChallengeBadgeRenderer.StringEventPair.NativeFieldInfoPtr_Badge), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040019E3 RID: 6627
			private static readonly IntPtr NativeFieldInfoPtr_OnBadgeUnityEvent;

			// Token: 0x040019E4 RID: 6628
			private static readonly IntPtr NativeFieldInfoPtr_OnNotBadgeUnityEvent;

			// Token: 0x040019E5 RID: 6629
			private static readonly IntPtr NativeFieldInfoPtr_Badge;

			// Token: 0x040019E6 RID: 6630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
