using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000287 RID: 647
	public sealed class ImageSource : ValueType
	{
		// Token: 0x06003057 RID: 12375 RVA: 0x000CD300 File Offset: 0x000CB500
		// Note: this type is marked as 'beforefieldinit'.
		static ImageSource()
		{
			Il2CppClassPointerStore<ImageSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "ImageSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageSource>.NativeClassPtr);
			ImageSource.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, "texture");
			ImageSource.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, "sprite");
			ImageSource.NativeFieldInfoPtr_vectorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, "vectorImage");
			ImageSource.NativeFieldInfoPtr_renderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, "renderTexture");
			ImageSource.NativeMethodInfoPtr_IsNull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, 100670312);
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x000CD394 File Offset: 0x000CB594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357442, XrefRangeEnd = 357455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSource.NativeMethodInfoPtr_IsNull_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x00013C58 File Offset: 0x00011E58
		public ImageSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x00013C61 File Offset: 0x00011E61
		public ImageSource()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageSource>.NativeClassPtr))
		{
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x0600305B RID: 12379 RVA: 0x000CD3D8 File Offset: 0x000CB5D8
		// (set) Token: 0x0600305C RID: 12380 RVA: 0x00013C73 File Offset: 0x00011E73
		public unsafe Texture2D texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSource.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSource.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x0600305D RID: 12381 RVA: 0x000CD408 File Offset: 0x000CB608
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x00013C92 File Offset: 0x00011E92
		public unsafe Sprite sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSource.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSource.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x000CD438 File Offset: 0x000CB638
		// (set) Token: 0x06003060 RID: 12384 RVA: 0x00013CB1 File Offset: 0x00011EB1
		public unsafe VectorImage vectorImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSource.NativeFieldInfoPtr_vectorImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VectorImage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSource.NativeFieldInfoPtr_vectorImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06003061 RID: 12385 RVA: 0x000CD468 File Offset: 0x000CB668
		// (set) Token: 0x06003062 RID: 12386 RVA: 0x00013CD0 File Offset: 0x00011ED0
		public unsafe RenderTexture renderTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSource.NativeFieldInfoPtr_renderTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSource.NativeFieldInfoPtr_renderTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002347 RID: 9031
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x04002348 RID: 9032
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x04002349 RID: 9033
		private static readonly IntPtr NativeFieldInfoPtr_vectorImage;

		// Token: 0x0400234A RID: 9034
		private static readonly IntPtr NativeFieldInfoPtr_renderTexture;

		// Token: 0x0400234B RID: 9035
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Boolean_0;
	}
}
