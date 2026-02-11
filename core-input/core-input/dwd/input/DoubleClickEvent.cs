using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.input
{
	// Token: 0x0200001D RID: 29
	public class DoubleClickEvent : MouseClickEvent
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00002765 File Offset: 0x00000965
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleClickEvent()
		{
			Il2CppClassPointerStore<DoubleClickEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.input", "DoubleClickEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleClickEvent>.NativeClassPtr);
			DoubleClickEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleClickEvent>.NativeClassPtr, 100663438);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000A478 File Offset: 0x00008678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleClickEvent(Transform originalSource, MouseButton button)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleClickEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalSource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleClickEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000279E File Offset: 0x0000099E
		public DoubleClickEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0;
	}
}
