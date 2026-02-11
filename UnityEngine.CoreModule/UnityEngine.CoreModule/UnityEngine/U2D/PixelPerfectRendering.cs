using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x02000185 RID: 389
	public static class PixelPerfectRendering : Object
	{
		// Token: 0x06001D1C RID: 7452 RVA: 0x00086070 File Offset: 0x00084270
		// Note: this type is marked as 'beforefieldinit'.
		static PixelPerfectRendering()
		{
			Il2CppClassPointerStore<PixelPerfectRendering>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "PixelPerfectRendering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PixelPerfectRendering>.NativeClassPtr);
			PixelPerfectRendering.NativeMethodInfoPtr_set_pixelSnapSpacing_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectRendering>.NativeClassPtr, 100667390);
			PixelPerfectRendering.get_pixelSnapSpacingDelegateField = IL2CPP.ResolveICall<PixelPerfectRendering.get_pixelSnapSpacingDelegate>("UnityEngine.U2D.PixelPerfectRendering::get_pixelSnapSpacing");
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x0000AD66 File Offset: 0x00008F66
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x000860C4 File Offset: 0x000842C4
		public unsafe static float pixelSnapSpacing
		{
			get
			{
				return PixelPerfectRendering.get_pixelSnapSpacingDelegateField();
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 677448, RefRangeEnd = 677450, XrefRangeStart = 677446, XrefRangeEnd = 677448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectRendering.NativeMethodInfoPtr_set_pixelSnapSpacing_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0000AD5D File Offset: 0x00008F5D
		public PixelPerfectRendering(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelSnapSpacing_Public_Static_set_Void_Single_0;

		// Token: 0x040019E5 RID: 6629
		private static readonly PixelPerfectRendering.get_pixelSnapSpacingDelegate get_pixelSnapSpacingDelegateField;

		// Token: 0x02000800 RID: 2048
		// (Invoke) Token: 0x060038B2 RID: 14514
		private delegate float get_pixelSnapSpacingDelegate();
	}
}
