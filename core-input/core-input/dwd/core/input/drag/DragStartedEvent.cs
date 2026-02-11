using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.input.drag
{
	// Token: 0x02000071 RID: 113
	public class DragStartedEvent : DragEvent
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x000047E8 File Offset: 0x000029E8
		// Note: this type is marked as 'beforefieldinit'.
		static DragStartedEvent()
		{
			Il2CppClassPointerStore<DragStartedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.drag", "DragStartedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragStartedEvent>.NativeClassPtr);
			DragStartedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragStartedEvent>.NativeClassPtr, 100663788);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00014654 File Offset: 0x00012854
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1122097, RefRangeEnd = 1122111, XrefRangeStart = 1122097, XrefRangeEnd = 1122111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragStartedEvent(Press press, Transform transform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragStartedEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragStartedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00004821 File Offset: 0x00002A21
		public DragStartedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0;
	}
}
