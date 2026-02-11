using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus.src.util
{
	// Token: 0x020000EA RID: 234
	public class GLClearImmediate : MonoBehaviour
	{
		// Token: 0x06000B5C RID: 2908 RVA: 0x000355B0 File Offset: 0x000337B0
		// Note: this type is marked as 'beforefieldinit'.
		static GLClearImmediate()
		{
			Il2CppClassPointerStore<GLClearImmediate>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.util", "GLClearImmediate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GLClearImmediate>.NativeClassPtr);
			GLClearImmediate.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLClearImmediate>.NativeClassPtr, 100665114);
			GLClearImmediate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLClearImmediate>.NativeClassPtr, 100665115);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00035608 File Offset: 0x00033808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994667, XrefRangeEnd = 994672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLClearImmediate.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0003563C File Offset: 0x0003383C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GLClearImmediate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GLClearImmediate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLClearImmediate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x000072B9 File Offset: 0x000054B9
		public GLClearImmediate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
