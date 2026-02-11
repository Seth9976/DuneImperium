using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.ui
{
	// Token: 0x0200011F RID: 287
	public class EventsForEvenSiblingIndex : MonoBehaviour
	{
		// Token: 0x06000ED7 RID: 3799 RVA: 0x0003E148 File Offset: 0x0003C348
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForEvenSiblingIndex()
		{
			Il2CppClassPointerStore<EventsForEvenSiblingIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "EventsForEvenSiblingIndex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForEvenSiblingIndex>.NativeClassPtr);
			EventsForEvenSiblingIndex.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEvenSiblingIndex>.NativeClassPtr, "events");
			EventsForEvenSiblingIndex.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEvenSiblingIndex>.NativeClassPtr, 100665409);
			EventsForEvenSiblingIndex.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEvenSiblingIndex>.NativeClassPtr, 100665410);
			EventsForEvenSiblingIndex.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEvenSiblingIndex>.NativeClassPtr, 100665411);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0003E1C8 File Offset: 0x0003C3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996799, XrefRangeEnd = 996803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEvenSiblingIndex.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0003E1FC File Offset: 0x0003C3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEvenSiblingIndex.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0003E230 File Offset: 0x0003C430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996803, XrefRangeEnd = 996809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForEvenSiblingIndex()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForEvenSiblingIndex>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEvenSiblingIndex.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00008F4A File Offset: 0x0000714A
		public EventsForEvenSiblingIndex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0003E26C File Offset: 0x0003C46C
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x00008F53 File Offset: 0x00007153
		public unsafe BoolUnityEvents events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEvenSiblingIndex.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEvenSiblingIndex.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
