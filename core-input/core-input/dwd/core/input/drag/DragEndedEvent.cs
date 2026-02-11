using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.input.drag
{
	// Token: 0x0200006F RID: 111
	public class DragEndedEvent : DragEvent
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x00004764 File Offset: 0x00002964
		// Note: this type is marked as 'beforefieldinit'.
		static DragEndedEvent()
		{
			Il2CppClassPointerStore<DragEndedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.drag", "DragEndedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragEndedEvent>.NativeClassPtr);
			DragEndedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEndedEvent>.NativeClassPtr, 100663786);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00014594 File Offset: 0x00012794
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1122097, RefRangeEnd = 1122111, XrefRangeStart = 1122097, XrefRangeEnd = 1122111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragEndedEvent(Press press, Transform transform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragEndedEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEndedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000479D File Offset: 0x0000299D
		public DragEndedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0;
	}
}
