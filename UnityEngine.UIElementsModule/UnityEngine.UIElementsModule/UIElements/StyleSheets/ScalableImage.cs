using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000285 RID: 645
	[Serializable]
	public sealed class ScalableImage : ValueType
	{
		// Token: 0x06003048 RID: 12360 RVA: 0x000CD148 File Offset: 0x000CB348
		// Note: this type is marked as 'beforefieldinit'.
		static ScalableImage()
		{
			Il2CppClassPointerStore<ScalableImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "ScalableImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScalableImage>.NativeClassPtr);
			ScalableImage.NativeFieldInfoPtr_normalImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableImage>.NativeClassPtr, "normalImage");
			ScalableImage.NativeFieldInfoPtr_highResolutionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableImage>.NativeClassPtr, "highResolutionImage");
			ScalableImage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableImage>.NativeClassPtr, 100670311);
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x000CD1B4 File Offset: 0x000CB3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357412, XrefRangeEnd = 357442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableImage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x00013BAA File Offset: 0x00011DAA
		public ScalableImage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x00013BB3 File Offset: 0x00011DB3
		public ScalableImage()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScalableImage>.NativeClassPtr))
		{
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x000CD1F0 File Offset: 0x000CB3F0
		// (set) Token: 0x0600304D RID: 12365 RVA: 0x00013BC5 File Offset: 0x00011DC5
		public unsafe Texture2D normalImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableImage.NativeFieldInfoPtr_normalImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableImage.NativeFieldInfoPtr_normalImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x000CD220 File Offset: 0x000CB420
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x00013BE4 File Offset: 0x00011DE4
		public unsafe Texture2D highResolutionImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableImage.NativeFieldInfoPtr_highResolutionImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableImage.NativeFieldInfoPtr_highResolutionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002342 RID: 9026
		private static readonly IntPtr NativeFieldInfoPtr_normalImage;

		// Token: 0x04002343 RID: 9027
		private static readonly IntPtr NativeFieldInfoPtr_highResolutionImage;

		// Token: 0x04002344 RID: 9028
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
