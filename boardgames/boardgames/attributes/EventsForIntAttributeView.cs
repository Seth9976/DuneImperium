using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace boardgames.attributes
{
	// Token: 0x02000167 RID: 359
	public class EventsForIntAttributeView : AttributeView
	{
		// Token: 0x06001228 RID: 4648 RVA: 0x00048D20 File Offset: 0x00046F20
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForIntAttributeView()
		{
			Il2CppClassPointerStore<EventsForIntAttributeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "EventsForIntAttributeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForIntAttributeView>.NativeClassPtr);
			EventsForIntAttributeView.NativeFieldInfoPtr_onValueEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForIntAttributeView>.NativeClassPtr, "onValueEvents");
			EventsForIntAttributeView.NativeFieldInfoPtr_onNoMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForIntAttributeView>.NativeClassPtr, "onNoMatches");
			EventsForIntAttributeView.NativeFieldInfoPtr_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForIntAttributeView>.NativeClassPtr, "onValueChanged");
			EventsForIntAttributeView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForIntAttributeView>.NativeClassPtr, 100665950);
			EventsForIntAttributeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForIntAttributeView>.NativeClassPtr, 100665951);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00048DB4 File Offset: 0x00046FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000666, XrefRangeEnd = 1000684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForIntAttributeView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00048DF0 File Offset: 0x00046FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000684, XrefRangeEnd = 1000703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForIntAttributeView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForIntAttributeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForIntAttributeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0000A7C9 File Offset: 0x000089C9
		public EventsForIntAttributeView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00048E2C File Offset: 0x0004702C
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x0000A7D2 File Offset: 0x000089D2
		public unsafe Il2CppReferenceArray<EventsForIntAttributeView.ValueEvents> onValueEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntAttributeView.NativeFieldInfoPtr_onValueEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventsForIntAttributeView.ValueEvents>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntAttributeView.NativeFieldInfoPtr_onValueEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00048E5C File Offset: 0x0004705C
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x0000A7F1 File Offset: 0x000089F1
		public unsafe UnityEvent onNoMatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntAttributeView.NativeFieldInfoPtr_onNoMatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntAttributeView.NativeFieldInfoPtr_onNoMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00048E8C File Offset: 0x0004708C
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x0000A810 File Offset: 0x00008A10
		public unsafe UnityEvent<int> onValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntAttributeView.NativeFieldInfoPtr_onValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntAttributeView.NativeFieldInfoPtr_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeFieldInfoPtr_onValueEvents;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeFieldInfoPtr_onNoMatches;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeFieldInfoPtr_onValueChanged;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000283 RID: 643
		[Serializable]
		public class ValueEvents : Object
		{
			// Token: 0x06001DC0 RID: 7616 RVA: 0x0006CCE4 File Offset: 0x0006AEE4
			// Note: this type is marked as 'beforefieldinit'.
			static ValueEvents()
			{
				Il2CppClassPointerStore<EventsForIntAttributeView.ValueEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventsForIntAttributeView>.NativeClassPtr, "ValueEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForIntAttributeView.ValueEvents>.NativeClassPtr);
				EventsForIntAttributeView.ValueEvents.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForIntAttributeView.ValueEvents>.NativeClassPtr, "value");
				EventsForIntAttributeView.ValueEvents.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForIntAttributeView.ValueEvents>.NativeClassPtr, "events");
				EventsForIntAttributeView.ValueEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForIntAttributeView.ValueEvents>.NativeClassPtr, 100665952);
			}

			// Token: 0x06001DC1 RID: 7617 RVA: 0x0006CD4C File Offset: 0x0006AF4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000660, XrefRangeEnd = 1000666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueEvents()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForIntAttributeView.ValueEvents>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForIntAttributeView.ValueEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DC2 RID: 7618 RVA: 0x00010004 File Offset: 0x0000E204
			public ValueEvents(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008E4 RID: 2276
			// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0006CD88 File Offset: 0x0006AF88
			// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x0001000D File Offset: 0x0000E20D
			public unsafe int value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntAttributeView.ValueEvents.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntAttributeView.ValueEvents.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x170008E5 RID: 2277
			// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x0006CDB0 File Offset: 0x0006AFB0
			// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00010028 File Offset: 0x0000E228
			public unsafe BoolUnityEvents events
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntAttributeView.ValueEvents.NativeFieldInfoPtr_events);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntAttributeView.ValueEvents.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400121B RID: 4635
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400121C RID: 4636
			private static readonly IntPtr NativeFieldInfoPtr_events;

			// Token: 0x0400121D RID: 4637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
