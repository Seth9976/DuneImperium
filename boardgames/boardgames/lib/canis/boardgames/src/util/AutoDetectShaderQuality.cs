using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lib.canis.boardgames.src.util
{
	// Token: 0x02000034 RID: 52
	public class AutoDetectShaderQuality : MonoBehaviour
	{
		// Token: 0x06000236 RID: 566 RVA: 0x000180FC File Offset: 0x000162FC
		// Note: this type is marked as 'beforefieldinit'.
		static AutoDetectShaderQuality()
		{
			Il2CppClassPointerStore<AutoDetectShaderQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.util", "AutoDetectShaderQuality");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoDetectShaderQuality>.NativeClassPtr);
			AutoDetectShaderQuality.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDetectShaderQuality>.NativeClassPtr, 100663715);
			AutoDetectShaderQuality.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDetectShaderQuality>.NativeClassPtr, 100663716);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00018154 File Offset: 0x00016354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984761, XrefRangeEnd = 984780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDetectShaderQuality.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00018188 File Offset: 0x00016388
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoDetectShaderQuality()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoDetectShaderQuality>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDetectShaderQuality.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002F62 File Offset: 0x00001162
		public AutoDetectShaderQuality(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
