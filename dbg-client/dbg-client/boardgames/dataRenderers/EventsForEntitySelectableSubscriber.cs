using System;
using boardgames.match.selection;
using dwd.core.data;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace boardgames.dataRenderers
{
	// Token: 0x02000146 RID: 326
	public class EventsForEntitySelectableSubscriber : VersionedSubscriber<SelectedData<EntityComponent>>
	{
		// Token: 0x06000EE0 RID: 3808 RVA: 0x0004D01C File Offset: 0x0004B21C
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForEntitySelectableSubscriber()
		{
			Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "EventsForEntitySelectableSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr);
			EventsForEntitySelectableSubscriber.NativeFieldInfoPtr_onSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr, "onSelectable");
			EventsForEntitySelectableSubscriber.NativeFieldInfoPtr_onNotSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr, "onNotSelectable");
			EventsForEntitySelectableSubscriber.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr, "selectionResponder");
			EventsForEntitySelectableSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr, 100665461);
			EventsForEntitySelectableSubscriber.NativeMethodInfoPtr_get_version_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr, 100665462);
			EventsForEntitySelectableSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr, 100665463);
			EventsForEntitySelectableSubscriber.NativeMethodInfoPtr_Event_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr, 100665464);
			EventsForEntitySelectableSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr, 100665465);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0004D0EC File Offset: 0x0004B2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512730, XrefRangeEnd = 512734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForEntitySelectableSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0004D128 File Offset: 0x0004B328
		public unsafe override ulong version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512734, XrefRangeEnd = 512737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForEntitySelectableSubscriber.NativeMethodInfoPtr_get_version_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0004D170 File Offset: 0x0004B370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512737, XrefRangeEnd = 512740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForEntitySelectableSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0004D1AC File Offset: 0x0004B3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512740, XrefRangeEnd = 512742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEntitySelectableSubscriber.NativeMethodInfoPtr_Event_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0004D1E0 File Offset: 0x0004B3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512742, XrefRangeEnd = 512754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForEntitySelectableSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForEntitySelectableSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEntitySelectableSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00009294 File Offset: 0x00007494
		public EventsForEntitySelectableSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0004D21C File Offset: 0x0004B41C
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x0000929D File Offset: 0x0000749D
		public unsafe UnityEvent onSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEntitySelectableSubscriber.NativeFieldInfoPtr_onSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEntitySelectableSubscriber.NativeFieldInfoPtr_onSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0004D24C File Offset: 0x0004B44C
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x000092BC File Offset: 0x000074BC
		public unsafe UnityEvent onNotSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEntitySelectableSubscriber.NativeFieldInfoPtr_onNotSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEntitySelectableSubscriber.NativeFieldInfoPtr_onNotSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0004D27C File Offset: 0x0004B47C
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x000092DB File Offset: 0x000074DB
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEntitySelectableSubscriber.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEntitySelectableSubscriber.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeFieldInfoPtr_onSelectable;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr_onNotSelectable;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Protected_Virtual_get_UInt64_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_Event_Select_Public_Void_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
