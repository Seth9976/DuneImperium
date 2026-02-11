using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace dwd.canis.lib.canis.dbg_client.behaviours
{
	// Token: 0x02000065 RID: 101
	public class EventsOnMouseover : MonoBehaviour
	{
		// Token: 0x060003C4 RID: 964 RVA: 0x000296F0 File Offset: 0x000278F0
		// Note: this type is marked as 'beforefieldinit'.
		static EventsOnMouseover()
		{
			Il2CppClassPointerStore<EventsOnMouseover>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.behaviours", "EventsOnMouseover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsOnMouseover>.NativeClassPtr);
			EventsOnMouseover.NativeFieldInfoPtr_bubbleUpEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsOnMouseover>.NativeClassPtr, "bubbleUpEvents");
			EventsOnMouseover.NativeFieldInfoPtr_eventsForMouseover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsOnMouseover>.NativeClassPtr, "eventsForMouseover");
			EventsOnMouseover.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnMouseover>.NativeClassPtr, 100663883);
			EventsOnMouseover.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnMouseover>.NativeClassPtr, 100663884);
			EventsOnMouseover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnMouseover>.NativeClassPtr, 100663885);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00029784 File Offset: 0x00027984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500005, XrefRangeEnd = 500019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnMouseover.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000297C8 File Offset: 0x000279C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500019, XrefRangeEnd = 500033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnMouseover.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0002980C File Offset: 0x00027A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500033, XrefRangeEnd = 500039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsOnMouseover()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsOnMouseover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnMouseover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00003A87 File Offset: 0x00001C87
		public EventsOnMouseover(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00029848 File Offset: 0x00027A48
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00003A90 File Offset: 0x00001C90
		public unsafe bool bubbleUpEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnMouseover.NativeFieldInfoPtr_bubbleUpEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnMouseover.NativeFieldInfoPtr_bubbleUpEvents)) = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00029870 File Offset: 0x00027A70
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00003AAB File Offset: 0x00001CAB
		public unsafe BoolUnityEvents eventsForMouseover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnMouseover.NativeFieldInfoPtr_eventsForMouseover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnMouseover.NativeFieldInfoPtr_eventsForMouseover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_bubbleUpEvents;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_eventsForMouseover;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
