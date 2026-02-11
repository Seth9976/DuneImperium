using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200010C RID: 268
	[Serializable]
	public class TextureParameter : VolumeParameter<Texture>
	{
		// Token: 0x060011EB RID: 4587 RVA: 0x000516CC File Offset: 0x0004F8CC
		// Note: this type is marked as 'beforefieldinit'.
		static TextureParameter()
		{
			Il2CppClassPointerStore<TextureParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "TextureParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr);
			TextureParameter.NativeFieldInfoPtr_dimension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr, "dimension");
			TextureParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr, 100665917);
			TextureParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_TextureDimension_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr, 100665918);
			TextureParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr, 100665919);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0005174C File Offset: 0x0004F94C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 979041, RefRangeEnd = 979043, XrefRangeStart = 979038, XrefRangeEnd = 979041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureParameter(Texture value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000517A8 File Offset: 0x0004F9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979043, XrefRangeEnd = 979046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureParameter(Texture value, TextureDimension dimension, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_TextureDimension_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00051810 File Offset: 0x0004FA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979046, XrefRangeEnd = 979057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00009498 File Offset: 0x00007698
		public TextureParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00051858 File Offset: 0x0004FA58
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x000094A1 File Offset: 0x000076A1
		public unsafe TextureDimension dimension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureParameter.NativeFieldInfoPtr_dimension);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureParameter.NativeFieldInfoPtr_dimension)) = value;
			}
		}

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeFieldInfoPtr_dimension;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_TextureDimension_Boolean_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
