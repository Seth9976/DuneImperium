using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.input
{
	// Token: 0x02000018 RID: 24
	public class MouseDownEvent : MouseButtonEvent
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00002624 File Offset: 0x00000824
		// Note: this type is marked as 'beforefieldinit'.
		static MouseDownEvent()
		{
			Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.input", "MouseDownEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr);
			MouseDownEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100663432);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000A1A4 File Offset: 0x000083A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119926, XrefRangeEnd = 1119928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseDownEvent(Transform originalSource, MouseButton button)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalSource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000265D File Offset: 0x0000085D
		public MouseDownEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0;
	}
}
