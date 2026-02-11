using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000026 RID: 38
	[Serializable]
	public sealed class Light2DBlendStyle : ValueType
	{
		// Token: 0x06000302 RID: 770 RVA: 0x0002059C File Offset: 0x0001E79C
		// Note: this type is marked as 'beforefieldinit'.
		static Light2DBlendStyle()
		{
			Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Light2DBlendStyle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr);
			Light2DBlendStyle.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, "name");
			Light2DBlendStyle.NativeFieldInfoPtr_maskTextureChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, "maskTextureChannel");
			Light2DBlendStyle.NativeFieldInfoPtr_blendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, "blendMode");
			Light2DBlendStyle.NativeFieldInfoPtr__isDirty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, "<isDirty>k__BackingField");
			Light2DBlendStyle.NativeFieldInfoPtr__hasRenderTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, "<hasRenderTarget>k__BackingField");
			Light2DBlendStyle.NativeFieldInfoPtr_renderTargetHandleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, "renderTargetHandleId");
			Light2DBlendStyle.NativeFieldInfoPtr_renderTargetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, "renderTargetHandle");
			Light2DBlendStyle.NativeMethodInfoPtr_get_blendFactors_Internal_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, 100663677);
			Light2DBlendStyle.NativeMethodInfoPtr_get_maskTextureChannelFilter_Internal_get_MaskChannelFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, 100663678);
			Light2DBlendStyle.NativeMethodInfoPtr_get_isDirty_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, 100663679);
			Light2DBlendStyle.NativeMethodInfoPtr_set_isDirty_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, 100663680);
			Light2DBlendStyle.NativeMethodInfoPtr_get_hasRenderTarget_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, 100663681);
			Light2DBlendStyle.NativeMethodInfoPtr_set_hasRenderTarget_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, 100663682);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000303 RID: 771 RVA: 0x000206D0 File Offset: 0x0001E8D0
		public unsafe Vector2 blendFactors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.NativeMethodInfoPtr_get_blendFactors_Internal_get_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00020714 File Offset: 0x0001E914
		public unsafe Light2DBlendStyle.MaskChannelFilter maskTextureChannelFilter
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 599699, RefRangeEnd = 599701, XrefRangeStart = 599699, XrefRangeEnd = 599699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.NativeMethodInfoPtr_get_maskTextureChannelFilter_Internal_get_MaskChannelFilter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00020758 File Offset: 0x0001E958
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0002079C File Offset: 0x0001E99C
		public unsafe bool isDirty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.NativeMethodInfoPtr_get_isDirty_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.NativeMethodInfoPtr_set_isDirty_Internal_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000307 RID: 775 RVA: 0x000207E0 File Offset: 0x0001E9E0
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00020824 File Offset: 0x0001EA24
		public unsafe bool hasRenderTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.NativeMethodInfoPtr_get_hasRenderTarget_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.NativeMethodInfoPtr_set_hasRenderTarget_Internal_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000034F0 File Offset: 0x000016F0
		public Light2DBlendStyle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000034F9 File Offset: 0x000016F9
		public Light2DBlendStyle()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr))
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00020868 File Offset: 0x0001EA68
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000350B File Offset: 0x0000170B
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00020890 File Offset: 0x0001EA90
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000352A File Offset: 0x0000172A
		public unsafe Light2DBlendStyle.TextureChannel maskTextureChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr_maskTextureChannel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr_maskTextureChannel)) = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600030F RID: 783 RVA: 0x000208B8 File Offset: 0x0001EAB8
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00003545 File Offset: 0x00001745
		public unsafe Light2DBlendStyle.BlendMode blendMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr_blendMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr_blendMode)) = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000208E0 File Offset: 0x0001EAE0
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00003560 File Offset: 0x00001760
		public unsafe bool _isDirty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr__isDirty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr__isDirty_k__BackingField)) = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00020908 File Offset: 0x0001EB08
		// (set) Token: 0x06000314 RID: 788 RVA: 0x0000357B File Offset: 0x0000177B
		public unsafe bool _hasRenderTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr__hasRenderTarget_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr__hasRenderTarget_k__BackingField)) = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00020930 File Offset: 0x0001EB30
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003596 File Offset: 0x00001796
		public unsafe int renderTargetHandleId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr_renderTargetHandleId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr_renderTargetHandleId)) = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00020958 File Offset: 0x0001EB58
		// (set) Token: 0x06000318 RID: 792 RVA: 0x000035B1 File Offset: 0x000017B1
		public unsafe RTHandle renderTargetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr_renderTargetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DBlendStyle.NativeFieldInfoPtr_renderTargetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_maskTextureChannel;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_blendMode;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr__isDirty_k__BackingField;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr__hasRenderTarget_k__BackingField;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_renderTargetHandleId;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_renderTargetHandle;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_blendFactors_Internal_get_Vector2_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_get_maskTextureChannelFilter_Internal_get_MaskChannelFilter_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_get_isDirty_Internal_get_Boolean_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_set_isDirty_Internal_set_Void_Boolean_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_get_hasRenderTarget_Internal_get_Boolean_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_set_hasRenderTarget_Internal_set_Void_Boolean_0;

		// Token: 0x02000155 RID: 341
		public enum TextureChannel
		{
			// Token: 0x040013E5 RID: 5093
			None,
			// Token: 0x040013E6 RID: 5094
			R,
			// Token: 0x040013E7 RID: 5095
			G,
			// Token: 0x040013E8 RID: 5096
			B,
			// Token: 0x040013E9 RID: 5097
			A,
			// Token: 0x040013EA RID: 5098
			OneMinusR,
			// Token: 0x040013EB RID: 5099
			OneMinusG,
			// Token: 0x040013EC RID: 5100
			OneMinusB,
			// Token: 0x040013ED RID: 5101
			OneMinusA
		}

		// Token: 0x02000156 RID: 342
		[StructLayout(2)]
		public struct MaskChannelFilter
		{
			// Token: 0x06001B6A RID: 7018 RVA: 0x000722E8 File Offset: 0x000704E8
			// Note: this type is marked as 'beforefieldinit'.
			static MaskChannelFilter()
			{
				Il2CppClassPointerStore<Light2DBlendStyle.MaskChannelFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, "MaskChannelFilter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light2DBlendStyle.MaskChannelFilter>.NativeClassPtr);
				Light2DBlendStyle.MaskChannelFilter.NativeFieldInfoPtr__mask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle.MaskChannelFilter>.NativeClassPtr, "<mask>k__BackingField");
				Light2DBlendStyle.MaskChannelFilter.NativeFieldInfoPtr__inverted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle.MaskChannelFilter>.NativeClassPtr, "<inverted>k__BackingField");
				Light2DBlendStyle.MaskChannelFilter.NativeMethodInfoPtr_get_mask_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle.MaskChannelFilter>.NativeClassPtr, 100663683);
				Light2DBlendStyle.MaskChannelFilter.NativeMethodInfoPtr_set_mask_Private_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle.MaskChannelFilter>.NativeClassPtr, 100663684);
				Light2DBlendStyle.MaskChannelFilter.NativeMethodInfoPtr_get_inverted_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle.MaskChannelFilter>.NativeClassPtr, 100663685);
				Light2DBlendStyle.MaskChannelFilter.NativeMethodInfoPtr_set_inverted_Private_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle.MaskChannelFilter>.NativeClassPtr, 100663686);
				Light2DBlendStyle.MaskChannelFilter.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBlendStyle.MaskChannelFilter>.NativeClassPtr, 100663687);
			}

			// Token: 0x170009DE RID: 2526
			// (get) Token: 0x06001B6B RID: 7019 RVA: 0x000723A0 File Offset: 0x000705A0
			// (set) Token: 0x06001B6C RID: 7020 RVA: 0x000723D0 File Offset: 0x000705D0
			public unsafe Vector4 mask
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.MaskChannelFilter.NativeMethodInfoPtr_get_mask_Public_get_Vector4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 557179, RefRangeEnd = 557192, XrefRangeStart = 557179, XrefRangeEnd = 557192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.MaskChannelFilter.NativeMethodInfoPtr_set_mask_Private_set_Void_Vector4_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170009DF RID: 2527
			// (get) Token: 0x06001B6D RID: 7021 RVA: 0x00072404 File Offset: 0x00070604
			// (set) Token: 0x06001B6E RID: 7022 RVA: 0x00072434 File Offset: 0x00070634
			public unsafe Vector4 inverted
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.MaskChannelFilter.NativeMethodInfoPtr_get_inverted_Public_get_Vector4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.MaskChannelFilter.NativeMethodInfoPtr_set_inverted_Private_set_Void_Vector4_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001B6F RID: 7023 RVA: 0x00072468 File Offset: 0x00070668
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 599697, RefRangeEnd = 599699, XrefRangeStart = 599697, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaskChannelFilter(Vector4 m, Vector4 i)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref m;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBlendStyle.MaskChannelFilter.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B70 RID: 7024 RVA: 0x0000F878 File Offset: 0x0000DA78
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Light2DBlendStyle.MaskChannelFilter>.NativeClassPtr, ref this));
			}

			// Token: 0x040013EE RID: 5102
			private static readonly IntPtr NativeFieldInfoPtr__mask_k__BackingField;

			// Token: 0x040013EF RID: 5103
			private static readonly IntPtr NativeFieldInfoPtr__inverted_k__BackingField;

			// Token: 0x040013F0 RID: 5104
			private static readonly IntPtr NativeMethodInfoPtr_get_mask_Public_get_Vector4_0;

			// Token: 0x040013F1 RID: 5105
			private static readonly IntPtr NativeMethodInfoPtr_set_mask_Private_set_Void_Vector4_0;

			// Token: 0x040013F2 RID: 5106
			private static readonly IntPtr NativeMethodInfoPtr_get_inverted_Public_get_Vector4_0;

			// Token: 0x040013F3 RID: 5107
			private static readonly IntPtr NativeMethodInfoPtr_set_inverted_Private_set_Void_Vector4_0;

			// Token: 0x040013F4 RID: 5108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_0;

			// Token: 0x040013F5 RID: 5109
			[FieldOffset(0)]
			public Vector4 _mask_k__BackingField;

			// Token: 0x040013F6 RID: 5110
			[FieldOffset(16)]
			public Vector4 _inverted_k__BackingField;
		}

		// Token: 0x02000157 RID: 343
		public enum BlendMode
		{
			// Token: 0x040013F8 RID: 5112
			Additive,
			// Token: 0x040013F9 RID: 5113
			Multiply,
			// Token: 0x040013FA RID: 5114
			Subtractive
		}

		// Token: 0x02000158 RID: 344
		[Serializable]
		[StructLayout(2)]
		public struct BlendFactors
		{
			// Token: 0x06001B71 RID: 7025 RVA: 0x000724A8 File Offset: 0x000706A8
			// Note: this type is marked as 'beforefieldinit'.
			static BlendFactors()
			{
				Il2CppClassPointerStore<Light2DBlendStyle.BlendFactors>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Light2DBlendStyle>.NativeClassPtr, "BlendFactors");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light2DBlendStyle.BlendFactors>.NativeClassPtr);
				Light2DBlendStyle.BlendFactors.NativeFieldInfoPtr_multiplicative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle.BlendFactors>.NativeClassPtr, "multiplicative");
				Light2DBlendStyle.BlendFactors.NativeFieldInfoPtr_additive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DBlendStyle.BlendFactors>.NativeClassPtr, "additive");
			}

			// Token: 0x06001B72 RID: 7026 RVA: 0x0000F88A File Offset: 0x0000DA8A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Light2DBlendStyle.BlendFactors>.NativeClassPtr, ref this));
			}

			// Token: 0x040013FB RID: 5115
			private static readonly IntPtr NativeFieldInfoPtr_multiplicative;

			// Token: 0x040013FC RID: 5116
			private static readonly IntPtr NativeFieldInfoPtr_additive;

			// Token: 0x040013FD RID: 5117
			[FieldOffset(0)]
			public float multiplicative;

			// Token: 0x040013FE RID: 5118
			[FieldOffset(4)]
			public float additive;
		}
	}
}
