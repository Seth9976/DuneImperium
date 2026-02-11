using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000164 RID: 356
	public class PointerDispatchState : Object
	{
		// Token: 0x06001A54 RID: 6740 RVA: 0x0007A210 File Offset: 0x00078410
		// Note: this type is marked as 'beforefieldinit'.
		static PointerDispatchState()
		{
			Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerDispatchState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr);
			PointerDispatchState.NativeFieldInfoPtr_m_PendingPointerCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, "m_PendingPointerCapture");
			PointerDispatchState.NativeFieldInfoPtr_m_PointerCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, "m_PointerCapture");
			PointerDispatchState.NativeFieldInfoPtr_m_ShouldSendCompatibilityMouseEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, "m_ShouldSendCompatibilityMouseEvents");
			PointerDispatchState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667143);
			PointerDispatchState.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667144);
			PointerDispatchState.NativeMethodInfoPtr_GetCapturingElement_Public_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667145);
			PointerDispatchState.NativeMethodInfoPtr_HasPointerCapture_Public_Boolean_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667146);
			PointerDispatchState.NativeMethodInfoPtr_CapturePointer_Public_Void_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667147);
			PointerDispatchState.NativeMethodInfoPtr_ReleasePointer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667148);
			PointerDispatchState.NativeMethodInfoPtr_ReleasePointer_Public_Void_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667149);
			PointerDispatchState.NativeMethodInfoPtr_ProcessPointerCapture_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667150);
			PointerDispatchState.NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667151);
			PointerDispatchState.NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667152);
			PointerDispatchState.NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Public_Boolean_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100667153);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0007A358 File Offset: 0x00078558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321950, RefRangeEnd = 321951, XrefRangeStart = 321929, XrefRangeEnd = 321950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerDispatchState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0007A394 File Offset: 0x00078594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321951, XrefRangeEnd = 321954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0007A3C8 File Offset: 0x000785C8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 312068, RefRangeEnd = 312079, XrefRangeStart = 312068, XrefRangeEnd = 312079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEventHandler GetCapturingElement(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_GetCapturingElement_Public_IEventHandler_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0007A414 File Offset: 0x00078614
		[CallerCount(0)]
		public unsafe bool HasPointerCapture(IEventHandler handler, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_HasPointerCapture_Public_Boolean_IEventHandler_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0007A470 File Offset: 0x00078670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321954, XrefRangeEnd = 321971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CapturePointer(IEventHandler handler, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_CapturePointer_Public_Void_IEventHandler_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0007A4C0 File Offset: 0x000786C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321971, XrefRangeEnd = 321974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePointer(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_ReleasePointer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0007A500 File Offset: 0x00078700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321974, XrefRangeEnd = 321975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePointer(IEventHandler handler, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_ReleasePointer_Public_Void_IEventHandler_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0007A550 File Offset: 0x00078750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322026, RefRangeEnd = 322027, XrefRangeStart = 321975, XrefRangeEnd = 322026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPointerCapture(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_ProcessPointerCapture_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0007A590 File Offset: 0x00078790
		[CallerCount(0)]
		public unsafe void ActivateCompatibilityMouseEvents(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0007A5D0 File Offset: 0x000787D0
		[CallerCount(0)]
		public unsafe void PreventCompatibilityMouseEvents(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0007A610 File Offset: 0x00078810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322027, XrefRangeEnd = 322034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Public_Boolean_IPointerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0000BF71 File Offset: 0x0000A171
		public PointerDispatchState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x0007A660 File Offset: 0x00078860
		// (set) Token: 0x06001A62 RID: 6754 RVA: 0x0000BF7A File Offset: 0x0000A17A
		public unsafe Il2CppReferenceArray<IEventHandler> m_PendingPointerCapture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_PendingPointerCapture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEventHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_PendingPointerCapture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x0007A690 File Offset: 0x00078890
		// (set) Token: 0x06001A64 RID: 6756 RVA: 0x0000BF99 File Offset: 0x0000A199
		public unsafe Il2CppReferenceArray<IEventHandler> m_PointerCapture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_PointerCapture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEventHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_PointerCapture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x0007A6C0 File Offset: 0x000788C0
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		public unsafe Il2CppStructArray<bool> m_ShouldSendCompatibilityMouseEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_ShouldSendCompatibilityMouseEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_ShouldSendCompatibilityMouseEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeFieldInfoPtr_m_PendingPointerCapture;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerCapture;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldSendCompatibilityMouseEvents;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_GetCapturingElement_Public_IEventHandler_Int32_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_HasPointerCapture_Public_Boolean_IEventHandler_Int32_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_CapturePointer_Public_Void_IEventHandler_Int32_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Void_Int32_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Void_IEventHandler_Int32_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPointerCapture_Public_Void_Int32_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Public_Void_Int32_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Public_Void_Int32_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Public_Boolean_IPointerEvent_0;
	}
}
