using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D7 RID: 215
	public class EventCallbackListPool : Object
	{
		// Token: 0x060012A5 RID: 4773 RVA: 0x0005EA3C File Offset: 0x0005CC3C
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackListPool()
		{
			Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackListPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr);
			EventCallbackListPool.NativeFieldInfoPtr_m_Stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr, "m_Stack");
			EventCallbackListPool.NativeMethodInfoPtr_Get_Public_EventCallbackList_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr, 100665946);
			EventCallbackListPool.NativeMethodInfoPtr_Release_Public_Void_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr, 100665947);
			EventCallbackListPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr, 100665948);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0005EABC File Offset: 0x0005CCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313259, XrefRangeEnd = 313265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackList Get(EventCallbackList initializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackListPool.NativeMethodInfoPtr_Get_Public_EventCallbackList_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr3) : null;
			}
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0005EB0C File Offset: 0x0005CD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313265, XrefRangeEnd = 313271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(EventCallbackList element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackListPool.NativeMethodInfoPtr_Release_Public_Void_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0005EB50 File Offset: 0x0005CD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313271, XrefRangeEnd = 313279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackListPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackListPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00009335 File Offset: 0x00007535
		public EventCallbackListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x0005EB8C File Offset: 0x0005CD8C
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x0000933E File Offset: 0x0000753E
		public unsafe Stack<EventCallbackList> m_Stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackListPool.NativeFieldInfoPtr_m_Stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<EventCallbackList>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackListPool.NativeFieldInfoPtr_m_Stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeFieldInfoPtr_m_Stack;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_EventCallbackList_EventCallbackList_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_EventCallbackList_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
