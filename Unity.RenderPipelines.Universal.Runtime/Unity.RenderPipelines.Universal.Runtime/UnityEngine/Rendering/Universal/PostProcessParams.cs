using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000B9 RID: 185
	public sealed class PostProcessParams : ValueType
	{
		// Token: 0x06000EB0 RID: 3760 RVA: 0x000482AC File Offset: 0x000464AC
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessParams()
		{
			Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PostProcessParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr);
			PostProcessParams.NativeFieldInfoPtr_blitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr, "blitMaterial");
			PostProcessParams.NativeFieldInfoPtr_requestHDRFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr, "requestHDRFormat");
			PostProcessParams.NativeMethodInfoPtr_Create_Public_Static_PostProcessParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr, 100665180);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00048318 File Offset: 0x00046518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 614439, RefRangeEnd = 614441, XrefRangeStart = 614438, XrefRangeEnd = 614439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PostProcessParams Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessParams.NativeMethodInfoPtr_Create_Public_Static_PostProcessParams_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PostProcessParams(intPtr);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000090CC File Offset: 0x000072CC
		public PostProcessParams(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000090D5 File Offset: 0x000072D5
		public PostProcessParams()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr))
		{
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00048344 File Offset: 0x00046544
		// (set) Token: 0x06000EB5 RID: 3765 RVA: 0x000090E7 File Offset: 0x000072E7
		public unsafe Material blitMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessParams.NativeFieldInfoPtr_blitMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessParams.NativeFieldInfoPtr_blitMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x00048374 File Offset: 0x00046574
		// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x00009106 File Offset: 0x00007306
		public unsafe GraphicsFormat requestHDRFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessParams.NativeFieldInfoPtr_requestHDRFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessParams.NativeFieldInfoPtr_requestHDRFormat)) = value;
			}
		}

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeFieldInfoPtr_blitMaterial;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeFieldInfoPtr_requestHDRFormat;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PostProcessParams_0;
	}
}
