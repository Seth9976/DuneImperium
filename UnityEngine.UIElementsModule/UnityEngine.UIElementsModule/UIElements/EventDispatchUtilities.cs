using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E7 RID: 231
	public static class EventDispatchUtilities : Object
	{
		// Token: 0x0600135F RID: 4959 RVA: 0x00061070 File Offset: 0x0005F270
		// Note: this type is marked as 'beforefieldinit'.
		static EventDispatchUtilities()
		{
			Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDispatchUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr);
			EventDispatchUtilities.NativeMethodInfoPtr_PropagateEvent_Public_Static_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr, 100666044);
			EventDispatchUtilities.NativeMethodInfoPtr_HandleEventAcrossPropagationPath_Private_Static_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr, 100666045);
			EventDispatchUtilities.NativeMethodInfoPtr_PropagateToIMGUIContainer_Internal_Static_Void_VisualElement_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr, 100666046);
			EventDispatchUtilities.NativeMethodInfoPtr_ExecuteDefaultAction_Public_Static_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatchUtilities>.NativeClassPtr, 100666047);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000610F0 File Offset: 0x0005F2F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 313965, RefRangeEnd = 313973, XrefRangeStart = 313954, XrefRangeEnd = 313965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PropagateEvent(EventBase evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatchUtilities.NativeMethodInfoPtr_PropagateEvent_Public_Static_Void_EventBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00061128 File Offset: 0x0005F328
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314051, RefRangeEnd = 314053, XrefRangeStart = 313973, XrefRangeEnd = 314051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleEventAcrossPropagationPath(EventBase evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatchUtilities.NativeMethodInfoPtr_HandleEventAcrossPropagationPath_Private_Static_Void_EventBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00061160 File Offset: 0x0005F360
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 314101, RefRangeEnd = 314107, XrefRangeStart = 314053, XrefRangeEnd = 314101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PropagateToIMGUIContainer(VisualElement root, EventBase evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatchUtilities.NativeMethodInfoPtr_PropagateToIMGUIContainer_Internal_Static_Void_VisualElement_EventBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x000611A8 File Offset: 0x0005F3A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314114, RefRangeEnd = 314116, XrefRangeStart = 314107, XrefRangeEnd = 314114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteDefaultAction(EventBase evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatchUtilities.NativeMethodInfoPtr_ExecuteDefaultAction_Public_Static_Void_EventBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000097A6 File Offset: 0x000079A6
		public EventDispatchUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_PropagateEvent_Public_Static_Void_EventBase_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_HandleEventAcrossPropagationPath_Private_Static_Void_EventBase_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_PropagateToIMGUIContainer_Internal_Static_Void_VisualElement_EventBase_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Public_Static_Void_EventBase_0;
	}
}
