using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200003D RID: 61
	[StructLayout(2)]
	public struct NativeArrayDispose
	{
		// Token: 0x06000236 RID: 566 RVA: 0x0001C09C File Offset: 0x0001A29C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayDispose()
		{
			Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayDispose");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr);
			NativeArrayDispose.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, "m_Buffer");
			NativeArrayDispose.NativeFieldInfoPtr_m_AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, "m_AllocatorLabel");
			NativeArrayDispose.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, 100663481);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001C108 File Offset: 0x0001A308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643775, RefRangeEnd = 643776, XrefRangeStart = 643773, XrefRangeEnd = 643775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayDispose.NativeMethodInfoPtr_Dispose_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000326D File Offset: 0x0000146D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, ref this));
		}

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocatorLabel;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x040001C1 RID: 449
		[FieldOffset(0)]
		public IntPtr m_Buffer;

		// Token: 0x040001C2 RID: 450
		[FieldOffset(8)]
		public Allocator m_AllocatorLabel;
	}
}
