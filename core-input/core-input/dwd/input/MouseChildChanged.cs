using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.input
{
	// Token: 0x02000021 RID: 33
	public class MouseChildChanged : MouseWithinChanged
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00002853 File Offset: 0x00000A53
		// Note: this type is marked as 'beforefieldinit'.
		static MouseChildChanged()
		{
			Il2CppClassPointerStore<MouseChildChanged>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.input", "MouseChildChanged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseChildChanged>.NativeClassPtr);
			MouseChildChanged.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseChildChanged>.NativeClassPtr, 100663443);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000A694 File Offset: 0x00008894
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseChildChanged(Transform originalSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseChildChanged>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseChildChanged.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000288C File Offset: 0x00000A8C
		public MouseChildChanged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;
	}
}
