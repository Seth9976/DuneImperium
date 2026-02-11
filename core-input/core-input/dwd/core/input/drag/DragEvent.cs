using System;
using dwd.core.input.transforms;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.input.drag
{
	// Token: 0x02000070 RID: 112
	public class DragEvent : TransformPressEvent
	{
		// Token: 0x06000456 RID: 1110 RVA: 0x000047A6 File Offset: 0x000029A6
		// Note: this type is marked as 'beforefieldinit'.
		static DragEvent()
		{
			Il2CppClassPointerStore<DragEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.drag", "DragEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragEvent>.NativeClassPtr);
			DragEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEvent>.NativeClassPtr, 100663787);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000145F4 File Offset: 0x000127F4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1122097, RefRangeEnd = 1122111, XrefRangeStart = 1122097, XrefRangeEnd = 1122111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragEvent(Press press, Transform transform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000047DF File Offset: 0x000029DF
		public DragEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0;
	}
}
