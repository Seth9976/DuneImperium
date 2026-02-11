using System;
using dwd.core.input.transforms;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.input.click
{
	// Token: 0x020000A6 RID: 166
	public class DownEvent : TransformPressEvent
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x00005F17 File Offset: 0x00004117
		// Note: this type is marked as 'beforefieldinit'.
		static DownEvent()
		{
			Il2CppClassPointerStore<DownEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "DownEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownEvent>.NativeClassPtr);
			DownEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownEvent>.NativeClassPtr, 100664242);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0001FCC4 File Offset: 0x0001DEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126670, XrefRangeEnd = 1126671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownEvent(Press press, Transform transform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00005F50 File Offset: 0x00004150
		public DownEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0;
	}
}
