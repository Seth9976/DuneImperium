using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input
{
	// Token: 0x0200003F RID: 63
	public class PressStartedEvent : PressEvent
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x000031BE File Offset: 0x000013BE
		// Note: this type is marked as 'beforefieldinit'.
		static PressStartedEvent()
		{
			Il2CppClassPointerStore<PressStartedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "PressStartedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressStartedEvent>.NativeClassPtr);
			PressStartedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartedEvent>.NativeClassPtr, 100663550);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000CD00 File Offset: 0x0000AF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressStartedEvent(Press press)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressStartedEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000031F7 File Offset: 0x000013F7
		public PressStartedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_0;
	}
}
