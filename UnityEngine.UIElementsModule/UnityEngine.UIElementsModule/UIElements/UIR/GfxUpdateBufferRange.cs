using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000241 RID: 577
	[StructLayout(2)]
	public struct GfxUpdateBufferRange
	{
		// Token: 0x06002A87 RID: 10887 RVA: 0x000B902C File Offset: 0x000B722C
		// Note: this type is marked as 'beforefieldinit'.
		static GfxUpdateBufferRange()
		{
			Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "GfxUpdateBufferRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr);
			GfxUpdateBufferRange.NativeFieldInfoPtr_offsetFromWriteStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr, "offsetFromWriteStart");
			GfxUpdateBufferRange.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr, "size");
			GfxUpdateBufferRange.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr, "source");
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x0001124A File Offset: 0x0000F44A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeFieldInfoPtr_offsetFromWriteStart;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04001E44 RID: 7748
		[FieldOffset(0)]
		public uint offsetFromWriteStart;

		// Token: 0x04001E45 RID: 7749
		[FieldOffset(4)]
		public uint size;

		// Token: 0x04001E46 RID: 7750
		[FieldOffset(8)]
		public UIntPtr source;
	}
}
