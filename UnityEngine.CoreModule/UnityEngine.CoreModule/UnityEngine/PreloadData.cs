using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200016A RID: 362
	public class PreloadData : Object
	{
		// Token: 0x06001A8F RID: 6799 RVA: 0x0000A73C File Offset: 0x0000893C
		// Note: this type is marked as 'beforefieldinit'.
		static PreloadData()
		{
			Il2CppClassPointerStore<PreloadData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PreloadData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadData>.NativeClassPtr);
			PreloadData.NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadData>.NativeClassPtr, 100666948);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0007B844 File Offset: 0x00079A44
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreloadDataDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadData.NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0000A775 File Offset: 0x00008975
		public PreloadData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0;
	}
}
