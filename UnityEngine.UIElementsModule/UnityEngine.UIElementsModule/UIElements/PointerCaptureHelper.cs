using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000163 RID: 355
	public static class PointerCaptureHelper : Object
	{
		// Token: 0x06001A47 RID: 6727 RVA: 0x00079E44 File Offset: 0x00078044
		// Note: this type is marked as 'beforefieldinit'.
		static PointerCaptureHelper()
		{
			Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerCaptureHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr);
			PointerCaptureHelper.NativeMethodInfoPtr_GetStateFor_Private_Static_PointerDispatchState_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100667133);
			PointerCaptureHelper.NativeMethodInfoPtr_HasPointerCapture_Public_Static_Boolean_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100667134);
			PointerCaptureHelper.NativeMethodInfoPtr_CapturePointer_Public_Static_Void_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100667135);
			PointerCaptureHelper.NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100667136);
			PointerCaptureHelper.NativeMethodInfoPtr_GetCapturingElement_Public_Static_IEventHandler_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100667137);
			PointerCaptureHelper.NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100667138);
			PointerCaptureHelper.NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100667139);
			PointerCaptureHelper.NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100667140);
			PointerCaptureHelper.NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Internal_Static_Boolean_IPanel_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100667141);
			PointerCaptureHelper.NativeMethodInfoPtr_ProcessPointerCapture_Internal_Static_Void_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100667142);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00079F3C File Offset: 0x0007813C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 321814, RefRangeEnd = 321817, XrefRangeStart = 321807, XrefRangeEnd = 321814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PointerDispatchState GetStateFor(IEventHandler handler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_GetStateFor_Private_Static_PointerDispatchState_IEventHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerDispatchState>(intPtr3) : null;
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00079F80 File Offset: 0x00078180
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 321818, RefRangeEnd = 321825, XrefRangeStart = 321817, XrefRangeEnd = 321818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasPointerCapture(this IEventHandler handler, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_HasPointerCapture_Public_Static_Boolean_IEventHandler_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00079FD0 File Offset: 0x000781D0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 321839, RefRangeEnd = 321847, XrefRangeStart = 321825, XrefRangeEnd = 321839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CapturePointer(this IEventHandler handler, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_CapturePointer_Public_Static_Void_IEventHandler_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0007A014 File Offset: 0x00078214
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 321849, RefRangeEnd = 321864, XrefRangeStart = 321847, XrefRangeEnd = 321849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleasePointer(this IEventHandler handler, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IEventHandler_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0007A058 File Offset: 0x00078258
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 321867, RefRangeEnd = 321872, XrefRangeStart = 321864, XrefRangeEnd = 321867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEventHandler GetCapturingElement(this IPanel panel, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_GetCapturingElement_Public_Static_IEventHandler_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0007A0AC File Offset: 0x000782AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 321876, RefRangeEnd = 321880, XrefRangeStart = 321872, XrefRangeEnd = 321876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleasePointer(this IPanel panel, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0007A0F0 File Offset: 0x000782F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321883, RefRangeEnd = 321885, XrefRangeStart = 321880, XrefRangeEnd = 321883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateCompatibilityMouseEvents(this IPanel panel, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0007A134 File Offset: 0x00078334
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 321888, RefRangeEnd = 321894, XrefRangeStart = 321885, XrefRangeEnd = 321888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreventCompatibilityMouseEvents(this IPanel panel, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0007A178 File Offset: 0x00078378
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 321910, RefRangeEnd = 321915, XrefRangeStart = 321894, XrefRangeEnd = 321910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldSendCompatibilityMouseEvents(this IPanel panel, IPointerEvent evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Internal_Static_Boolean_IPanel_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0007A1CC File Offset: 0x000783CC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 321919, RefRangeEnd = 321929, XrefRangeStart = 321915, XrefRangeEnd = 321919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessPointerCapture(this IPanel panel, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_ProcessPointerCapture_Internal_Static_Void_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0000BF49 File Offset: 0x0000A149
		public PointerCaptureHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0000BF52 File Offset: 0x0000A152
		public static void ResetPointerDispatchState(IPanel panel)
		{
			if (panel != null)
			{
				EventDispatcher dispatcher = panel.dispatcher;
				if (dispatcher != null)
				{
					dispatcher.pointerState.Reset();
				}
			}
		}

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_GetStateFor_Private_Static_PointerDispatchState_IEventHandler_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_HasPointerCapture_Public_Static_Boolean_IEventHandler_Int32_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_CapturePointer_Public_Static_Void_IEventHandler_Int32_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IEventHandler_Int32_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_GetCapturingElement_Public_Static_IEventHandler_IPanel_Int32_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IPanel_Int32_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Internal_Static_Boolean_IPanel_IPointerEvent_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPointerCapture_Internal_Static_Void_IPanel_Int32_0;
	}
}
