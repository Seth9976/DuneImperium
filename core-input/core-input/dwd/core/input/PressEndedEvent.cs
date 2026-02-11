using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input
{
	// Token: 0x0200003D RID: 61
	public class PressEndedEvent : PressEvent
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x00003154 File Offset: 0x00001354
		// Note: this type is marked as 'beforefieldinit'.
		static PressEndedEvent()
		{
			Il2CppClassPointerStore<PressEndedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "PressEndedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressEndedEvent>.NativeClassPtr);
			PressEndedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressEndedEvent>.NativeClassPtr, 100663546);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000CB34 File Offset: 0x0000AD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120344, XrefRangeEnd = 1120352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressEndedEvent(Press press)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressEndedEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressEndedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000318D File Offset: 0x0000138D
		public PressEndedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_0;
	}
}
