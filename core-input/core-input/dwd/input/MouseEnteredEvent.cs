using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.input
{
	// Token: 0x0200001F RID: 31
	public class MouseEnteredEvent : MouseWithinChanged
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000027CF File Offset: 0x000009CF
		// Note: this type is marked as 'beforefieldinit'.
		static MouseEnteredEvent()
		{
			Il2CppClassPointerStore<MouseEnteredEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.input", "MouseEnteredEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseEnteredEvent>.NativeClassPtr);
			MouseEnteredEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEnteredEvent>.NativeClassPtr, 100663441);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000A5FC File Offset: 0x000087FC
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseEnteredEvent(Transform originalSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseEnteredEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEnteredEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002808 File Offset: 0x00000A08
		public MouseEnteredEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;
	}
}
