using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.match.selection
{
	// Token: 0x0200026F RID: 623
	public class EventsForDBGSelectionResponderState : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06001CFF RID: 7423 RVA: 0x0007DAAC File Offset: 0x0007BCAC
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForDBGSelectionResponderState()
		{
			Il2CppClassPointerStore<EventsForDBGSelectionResponderState>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "EventsForDBGSelectionResponderState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForDBGSelectionResponderState>.NativeClassPtr);
			EventsForDBGSelectionResponderState.NativeFieldInfoPtr_mayCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForDBGSelectionResponderState>.NativeClassPtr, "mayCancel");
			EventsForDBGSelectionResponderState.NativeFieldInfoPtr_mayAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForDBGSelectionResponderState>.NativeClassPtr, "mayAdvance");
			EventsForDBGSelectionResponderState.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForDBGSelectionResponderState>.NativeClassPtr, 100668059);
			EventsForDBGSelectionResponderState.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForDBGSelectionResponderState>.NativeClassPtr, 100668060);
			EventsForDBGSelectionResponderState.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForDBGSelectionResponderState>.NativeClassPtr, 100668061);
			EventsForDBGSelectionResponderState.NativeMethodInfoPtr_Event_Advance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForDBGSelectionResponderState>.NativeClassPtr, 100668062);
			EventsForDBGSelectionResponderState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForDBGSelectionResponderState>.NativeClassPtr, 100668063);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x0007DB68 File Offset: 0x0007BD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536271, XrefRangeEnd = 536277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForDBGSelectionResponderState.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0007DBA4 File Offset: 0x0007BDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536277, XrefRangeEnd = 536283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForDBGSelectionResponderState.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x0007DBE0 File Offset: 0x0007BDE0
		[CallerCount(0)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForDBGSelectionResponderState.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x0007DC14 File Offset: 0x0007BE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Advance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForDBGSelectionResponderState.NativeMethodInfoPtr_Event_Advance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x0007DC48 File Offset: 0x0007BE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536283, XrefRangeEnd = 536295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForDBGSelectionResponderState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForDBGSelectionResponderState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForDBGSelectionResponderState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0000F742 File Offset: 0x0000D942
		public EventsForDBGSelectionResponderState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x0007DC84 File Offset: 0x0007BE84
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0000F74B File Offset: 0x0000D94B
		public unsafe BoolUnityEvents mayCancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDBGSelectionResponderState.NativeFieldInfoPtr_mayCancel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDBGSelectionResponderState.NativeFieldInfoPtr_mayCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0007DCB4 File Offset: 0x0007BEB4
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x0000F76A File Offset: 0x0000D96A
		public unsafe BoolUnityEvents mayAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDBGSelectionResponderState.NativeFieldInfoPtr_mayAdvance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForDBGSelectionResponderState.NativeFieldInfoPtr_mayAdvance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeFieldInfoPtr_mayCancel;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeFieldInfoPtr_mayAdvance;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_Event_Advance_Public_Void_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
