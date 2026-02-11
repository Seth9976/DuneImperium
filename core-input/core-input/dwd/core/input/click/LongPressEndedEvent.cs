using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.input.click
{
	// Token: 0x020000A7 RID: 167
	public class LongPressEndedEvent : LongPressEvent
	{
		// Token: 0x0600079C RID: 1948 RVA: 0x00005F59 File Offset: 0x00004159
		// Note: this type is marked as 'beforefieldinit'.
		static LongPressEndedEvent()
		{
			Il2CppClassPointerStore<LongPressEndedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "LongPressEndedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongPressEndedEvent>.NativeClassPtr);
			LongPressEndedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongPressEndedEvent>.NativeClassPtr, 100664243);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0001FD24 File Offset: 0x0001DF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongPressEndedEvent(Press press, Transform transform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongPressEndedEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongPressEndedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00005F92 File Offset: 0x00004192
		public LongPressEndedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0;
	}
}
