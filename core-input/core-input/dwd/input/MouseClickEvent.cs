using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.input
{
	// Token: 0x0200001C RID: 28
	public class MouseClickEvent : MouseUpEvent
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00002723 File Offset: 0x00000923
		// Note: this type is marked as 'beforefieldinit'.
		static MouseClickEvent()
		{
			Il2CppClassPointerStore<MouseClickEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.input", "MouseClickEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseClickEvent>.NativeClassPtr);
			MouseClickEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseClickEvent>.NativeClassPtr, 100663437);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000A41C File Offset: 0x0000861C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseClickEvent(Transform originalSource, MouseButton button)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseClickEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalSource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseClickEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000275C File Offset: 0x0000095C
		public MouseClickEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0;
	}
}
