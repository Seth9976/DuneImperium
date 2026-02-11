using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.input
{
	// Token: 0x02000020 RID: 32
	public class MouseExitedEvent : MouseWithinChanged
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00002811 File Offset: 0x00000A11
		// Note: this type is marked as 'beforefieldinit'.
		static MouseExitedEvent()
		{
			Il2CppClassPointerStore<MouseExitedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.input", "MouseExitedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseExitedEvent>.NativeClassPtr);
			MouseExitedEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseExitedEvent>.NativeClassPtr, 100663442);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000A648 File Offset: 0x00008848
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseExitedEvent(Transform originalSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseExitedEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseExitedEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000284A File Offset: 0x00000A4A
		public MouseExitedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;
	}
}
