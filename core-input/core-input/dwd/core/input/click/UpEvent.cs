using System;
using dwd.core.input.transforms;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.input.click
{
	// Token: 0x020000AA RID: 170
	public class UpEvent : TransformPressEvent
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x0000601F File Offset: 0x0000421F
		// Note: this type is marked as 'beforefieldinit'.
		static UpEvent()
		{
			Il2CppClassPointerStore<UpEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "UpEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpEvent>.NativeClassPtr);
			UpEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpEvent>.NativeClassPtr, 100664246);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0001FE44 File Offset: 0x0001E044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpEvent(Press press, Transform transform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00006058 File Offset: 0x00004258
		public UpEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0;
	}
}
