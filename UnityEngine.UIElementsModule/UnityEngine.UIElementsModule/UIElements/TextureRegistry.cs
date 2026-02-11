using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000173 RID: 371
	public class TextureRegistry : Object
	{
		// Token: 0x06001B88 RID: 7048 RVA: 0x0007E084 File Offset: 0x0007C284
		// Note: this type is marked as 'beforefieldinit'.
		static TextureRegistry()
		{
			Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextureRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr);
			TextureRegistry.NativeFieldInfoPtr_m_Textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "m_Textures");
			TextureRegistry.NativeFieldInfoPtr_m_TextureToId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "m_TextureToId");
			TextureRegistry.NativeFieldInfoPtr_m_FreeIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "m_FreeIds");
			TextureRegistry.NativeFieldInfoPtr_maxTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "maxTextures");
			TextureRegistry.NativeFieldInfoPtr__instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "<instance>k__BackingField");
			TextureRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_TextureRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, 100667300);
			TextureRegistry.NativeMethodInfoPtr_GetTexture_Public_Texture_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, 100667301);
			TextureRegistry.NativeMethodInfoPtr_AllocAndAcquireDynamic_Public_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, 100667302);
			TextureRegistry.NativeMethodInfoPtr_UpdateDynamic_Public_Void_TextureId_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, 100667303);
			TextureRegistry.NativeMethodInfoPtr_AllocAndAcquire_Private_TextureId_Texture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, 100667304);
			TextureRegistry.NativeMethodInfoPtr_Acquire_Public_TextureId_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, 100667305);
			TextureRegistry.NativeMethodInfoPtr_Release_Public_Void_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, 100667306);
			TextureRegistry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, 100667307);
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x0007E1B8 File Offset: 0x0007C3B8
		public unsafe static TextureRegistry instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323157, XrefRangeEnd = 323161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_TextureRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextureRegistry>(intPtr3) : null;
			}
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0007E1EC File Offset: 0x0007C3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323176, RefRangeEnd = 323177, XrefRangeStart = 323161, XrefRangeEnd = 323176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTexture(TextureId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureRegistry.NativeMethodInfoPtr_GetTexture_Public_Texture_TextureId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0007E238 File Offset: 0x0007C438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323177, XrefRangeEnd = 323178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureId AllocAndAcquireDynamic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureRegistry.NativeMethodInfoPtr_AllocAndAcquireDynamic_Public_TextureId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0007E274 File Offset: 0x0007C474
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 323200, RefRangeEnd = 323203, XrefRangeStart = 323178, XrefRangeEnd = 323200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDynamic(TextureId id, Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureRegistry.NativeMethodInfoPtr_UpdateDynamic_Public_Void_TextureId_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0007E2C4 File Offset: 0x0007C4C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 323242, RefRangeEnd = 323245, XrefRangeStart = 323203, XrefRangeEnd = 323242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureId AllocAndAcquire(Texture texture, bool dynamic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dynamic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureRegistry.NativeMethodInfoPtr_AllocAndAcquire_Private_TextureId_Texture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0007E320 File Offset: 0x0007C520
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 323253, RefRangeEnd = 323257, XrefRangeStart = 323245, XrefRangeEnd = 323253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureId Acquire(Texture tex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureRegistry.NativeMethodInfoPtr_Acquire_Public_TextureId_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0007E370 File Offset: 0x0007C570
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 323284, RefRangeEnd = 323287, XrefRangeStart = 323257, XrefRangeEnd = 323284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(TextureId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureRegistry.NativeMethodInfoPtr_Release_Public_Void_TextureId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0007E3B0 File Offset: 0x0007C5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323287, XrefRangeEnd = 323309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureRegistry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0000C7BF File Offset: 0x0000A9BF
		public TextureRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0007E3EC File Offset: 0x0007C5EC
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		public unsafe List<TextureRegistry.TextureInfo> m_Textures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_Textures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextureRegistry.TextureInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_Textures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x0007E41C File Offset: 0x0007C61C
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x0000C7E7 File Offset: 0x0000A9E7
		public unsafe Dictionary<Texture, TextureId> m_TextureToId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_TextureToId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Texture, TextureId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_TextureToId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x0007E44C File Offset: 0x0007C64C
		// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0000C806 File Offset: 0x0000AA06
		public unsafe Stack<TextureId> m_FreeIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_FreeIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<TextureId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_FreeIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x0007E47C File Offset: 0x0007C67C
		// (set) Token: 0x06001B99 RID: 7065 RVA: 0x0000C825 File Offset: 0x0000AA25
		public unsafe static int maxTextures
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextureRegistry.NativeFieldInfoPtr_maxTextures, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureRegistry.NativeFieldInfoPtr_maxTextures, (void*)(&value));
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x0007E498 File Offset: 0x0007C698
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0000C833 File Offset: 0x0000AA33
		public unsafe static TextureRegistry _instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureRegistry.NativeFieldInfoPtr__instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureRegistry.NativeFieldInfoPtr__instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0000C845 File Offset: 0x0000AA45
		public void Acquire(TextureId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0007E4C0 File Offset: 0x0007C6C0
		public TextureId TextureToId(Texture texture)
		{
			TextureId textureId;
			bool flag = this.m_TextureToId.TryGetValue(texture, out textureId);
			TextureId textureId2;
			if (flag)
			{
				textureId2 = textureId;
			}
			else
			{
				textureId2 = TextureId.invalid;
			}
			return textureId2;
		}

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeFieldInfoPtr_m_Textures;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeFieldInfoPtr_m_TextureToId;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeFieldInfoPtr_m_FreeIds;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeFieldInfoPtr_maxTextures;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr__instance_k__BackingField;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TextureRegistry_0;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_TextureId_0;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_AllocAndAcquireDynamic_Public_TextureId_0;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDynamic_Public_Void_TextureId_Texture_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_AllocAndAcquire_Private_TextureId_Texture_Boolean_0;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_TextureId_Texture_0;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_TextureId_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000498 RID: 1176
		public sealed class TextureInfo : ValueType
		{
			// Token: 0x06003D0C RID: 15628 RVA: 0x000F3B70 File Offset: 0x000F1D70
			// Note: this type is marked as 'beforefieldinit'.
			static TextureInfo()
			{
				Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "TextureInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr);
				TextureRegistry.TextureInfo.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr, "texture");
				TextureRegistry.TextureInfo.NativeFieldInfoPtr_dynamic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr, "dynamic");
				TextureRegistry.TextureInfo.NativeFieldInfoPtr_refCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr, "refCount");
			}

			// Token: 0x06003D0D RID: 15629 RVA: 0x00019B8D File Offset: 0x00017D8D
			public TextureInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003D0E RID: 15630 RVA: 0x00019B96 File Offset: 0x00017D96
			public TextureInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr))
			{
			}

			// Token: 0x1700127F RID: 4735
			// (get) Token: 0x06003D0F RID: 15631 RVA: 0x000F3BD8 File Offset: 0x000F1DD8
			// (set) Token: 0x06003D10 RID: 15632 RVA: 0x00019BA8 File Offset: 0x00017DA8
			public unsafe Texture texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_texture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001280 RID: 4736
			// (get) Token: 0x06003D11 RID: 15633 RVA: 0x000F3C08 File Offset: 0x000F1E08
			// (set) Token: 0x06003D12 RID: 15634 RVA: 0x00019BC7 File Offset: 0x00017DC7
			public unsafe bool dynamic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_dynamic);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_dynamic)) = value;
				}
			}

			// Token: 0x17001281 RID: 4737
			// (get) Token: 0x06003D13 RID: 15635 RVA: 0x000F3C30 File Offset: 0x000F1E30
			// (set) Token: 0x06003D14 RID: 15636 RVA: 0x00019BE2 File Offset: 0x00017DE2
			public unsafe int refCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_refCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_refCount)) = value;
				}
			}

			// Token: 0x04002B21 RID: 11041
			private static readonly IntPtr NativeFieldInfoPtr_texture;

			// Token: 0x04002B22 RID: 11042
			private static readonly IntPtr NativeFieldInfoPtr_dynamic;

			// Token: 0x04002B23 RID: 11043
			private static readonly IntPtr NativeFieldInfoPtr_refCount;
		}
	}
}
