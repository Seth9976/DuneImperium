using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule
{
	// Token: 0x02000089 RID: 137
	public class EventsForSelectionState : MonoBehaviour
	{
		// Token: 0x060005FC RID: 1532 RVA: 0x00019CF8 File Offset: 0x00017EF8
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForSelectionState()
		{
			Il2CppClassPointerStore<EventsForSelectionState>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "EventsForSelectionState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForSelectionState>.NativeClassPtr);
			EventsForSelectionState.NativeFieldInfoPtr_onSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSelectionState>.NativeClassPtr, "onSelect");
			EventsForSelectionState.NativeFieldInfoPtr_onDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSelectionState>.NativeClassPtr, "onDeselect");
			EventsForSelectionState.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSelectionState>.NativeClassPtr, 100664038);
			EventsForSelectionState.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSelectionState>.NativeClassPtr, 100664039);
			EventsForSelectionState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSelectionState>.NativeClassPtr, 100664040);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00019D8C File Offset: 0x00017F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSelectionState.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00019DD0 File Offset: 0x00017FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125034, XrefRangeEnd = 1125036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSelectionState.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00019E14 File Offset: 0x00018014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125036, XrefRangeEnd = 1125046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForSelectionState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForSelectionState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSelectionState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000547D File Offset: 0x0000367D
		public EventsForSelectionState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00019E50 File Offset: 0x00018050
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00005486 File Offset: 0x00003686
		public unsafe UnityEvent onSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSelectionState.NativeFieldInfoPtr_onSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSelectionState.NativeFieldInfoPtr_onSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00019E80 File Offset: 0x00018080
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x000054A5 File Offset: 0x000036A5
		public unsafe UnityEvent onDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSelectionState.NativeFieldInfoPtr_onDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSelectionState.NativeFieldInfoPtr_onDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_onSelect;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_onDeselect;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
