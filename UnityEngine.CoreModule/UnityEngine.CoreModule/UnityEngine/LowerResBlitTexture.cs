using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000169 RID: 361
	public class LowerResBlitTexture : Object
	{
		// Token: 0x06001A8C RID: 6796 RVA: 0x0000A6FA File Offset: 0x000088FA
		// Note: this type is marked as 'beforefieldinit'.
		static LowerResBlitTexture()
		{
			Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LowerResBlitTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr);
			LowerResBlitTexture.NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr, 100666947);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0007B810 File Offset: 0x00079A10
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LowerResBlitTextureDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowerResBlitTexture.NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0000A733 File Offset: 0x00008933
		public LowerResBlitTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0;
	}
}
