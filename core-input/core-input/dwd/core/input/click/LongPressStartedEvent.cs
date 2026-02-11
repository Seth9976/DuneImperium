using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.input.click
{
	// Token: 0x020000A9 RID: 169
	public class LongPressStartedEvent : LongPressEvent
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x00005FDD File Offset: 0x000041DD
		// Note: this type is marked as 'beforefieldinit'.
		static LongPressStartedEvent()
		{
			Il2CppClassPointerStore<LongPressStartedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "LongPressStartedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongPressStartedEvent>.NativeClassPtr);
			LongPressStartedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongPressStartedEvent>.NativeClassPtr, 100664245);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001FDE4 File Offset: 0x0001DFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongPressStartedEvent(Press press, Transform transform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongPressStartedEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongPressStartedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00006016 File Offset: 0x00004216
		public LongPressStartedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0;
	}
}
