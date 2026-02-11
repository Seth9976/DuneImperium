using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.ui
{
	// Token: 0x02000120 RID: 288
	public class EventsForHasChildren : MonoBehaviour
	{
		// Token: 0x06000EDE RID: 3806 RVA: 0x0003E29C File Offset: 0x0003C49C
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForHasChildren()
		{
			Il2CppClassPointerStore<EventsForHasChildren>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "EventsForHasChildren");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForHasChildren>.NativeClassPtr);
			EventsForHasChildren.NativeFieldInfoPtr_childCountThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForHasChildren>.NativeClassPtr, "childCountThreshold");
			EventsForHasChildren.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForHasChildren>.NativeClassPtr, "events");
			EventsForHasChildren.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForHasChildren>.NativeClassPtr, 100665412);
			EventsForHasChildren.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForHasChildren>.NativeClassPtr, 100665413);
			EventsForHasChildren.NativeMethodInfoPtr_CheckAndTriggerEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForHasChildren>.NativeClassPtr, 100665414);
			EventsForHasChildren.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForHasChildren>.NativeClassPtr, 100665415);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0003E344 File Offset: 0x0003C544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996809, XrefRangeEnd = 996813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForHasChildren.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0003E378 File Offset: 0x0003C578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForHasChildren.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0003E3AC File Offset: 0x0003C5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAndTriggerEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForHasChildren.NativeMethodInfoPtr_CheckAndTriggerEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0003E3E0 File Offset: 0x0003C5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996813, XrefRangeEnd = 996819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForHasChildren()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForHasChildren>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForHasChildren.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00008F72 File Offset: 0x00007172
		public EventsForHasChildren(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0003E41C File Offset: 0x0003C61C
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00008F7B File Offset: 0x0000717B
		public unsafe int childCountThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForHasChildren.NativeFieldInfoPtr_childCountThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForHasChildren.NativeFieldInfoPtr_childCountThreshold)) = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0003E444 File Offset: 0x0003C644
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x00008F96 File Offset: 0x00007196
		public unsafe BoolUnityEvents events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForHasChildren.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForHasChildren.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeFieldInfoPtr_childCountThreshold;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_CheckAndTriggerEvents_Private_Void_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
