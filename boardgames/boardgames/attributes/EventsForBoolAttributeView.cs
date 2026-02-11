using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.attributes
{
	// Token: 0x02000166 RID: 358
	public class EventsForBoolAttributeView : AttributeView
	{
		// Token: 0x06001220 RID: 4640 RVA: 0x00048BD0 File Offset: 0x00046DD0
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForBoolAttributeView()
		{
			Il2CppClassPointerStore<EventsForBoolAttributeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "EventsForBoolAttributeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForBoolAttributeView>.NativeClassPtr);
			EventsForBoolAttributeView.NativeFieldInfoPtr_nullIsFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForBoolAttributeView>.NativeClassPtr, "nullIsFalse");
			EventsForBoolAttributeView.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForBoolAttributeView>.NativeClassPtr, "events");
			EventsForBoolAttributeView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForBoolAttributeView>.NativeClassPtr, 100665948);
			EventsForBoolAttributeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForBoolAttributeView>.NativeClassPtr, 100665949);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00048C50 File Offset: 0x00046E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000645, XrefRangeEnd = 1000657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForBoolAttributeView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00048C8C File Offset: 0x00046E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000657, XrefRangeEnd = 1000660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForBoolAttributeView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForBoolAttributeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForBoolAttributeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0000A786 File Offset: 0x00008986
		public EventsForBoolAttributeView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00048CC8 File Offset: 0x00046EC8
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x0000A78F File Offset: 0x0000898F
		public unsafe bool nullIsFalse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolAttributeView.NativeFieldInfoPtr_nullIsFalse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolAttributeView.NativeFieldInfoPtr_nullIsFalse)) = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x00048CF0 File Offset: 0x00046EF0
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x0000A7AA File Offset: 0x000089AA
		public unsafe BoolUnityEvents events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolAttributeView.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolAttributeView.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeFieldInfoPtr_nullIsFalse;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
