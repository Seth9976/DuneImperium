using System;
using dwd.core.input.transforms;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.input.click
{
	// Token: 0x020000A8 RID: 168
	public class LongPressEvent : TransformPressEvent
	{
		// Token: 0x0600079F RID: 1951 RVA: 0x00005F9B File Offset: 0x0000419B
		// Note: this type is marked as 'beforefieldinit'.
		static LongPressEvent()
		{
			Il2CppClassPointerStore<LongPressEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "LongPressEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongPressEvent>.NativeClassPtr);
			LongPressEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongPressEvent>.NativeClassPtr, 100664244);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0001FD84 File Offset: 0x0001DF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongPressEvent(Press press, Transform transform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongPressEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongPressEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00005FD4 File Offset: 0x000041D4
		public LongPressEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0;
	}
}
