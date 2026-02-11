using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.utils
{
	// Token: 0x0200010B RID: 267
	public sealed class AutoDetectQuality : MonoBehaviour
	{
		// Token: 0x06000CE3 RID: 3299 RVA: 0x0003A074 File Offset: 0x00038274
		// Note: this type is marked as 'beforefieldinit'.
		static AutoDetectQuality()
		{
			Il2CppClassPointerStore<AutoDetectQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.utils", "AutoDetectQuality");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoDetectQuality>.NativeClassPtr);
			AutoDetectQuality.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDetectQuality>.NativeClassPtr, 100665320);
			AutoDetectQuality.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDetectQuality>.NativeClassPtr, 100665321);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0003A0CC File Offset: 0x000382CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996213, XrefRangeEnd = 996221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDetectQuality.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0003A100 File Offset: 0x00038300
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoDetectQuality()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoDetectQuality>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDetectQuality.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00007E8C File Offset: 0x0000608C
		public AutoDetectQuality(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
