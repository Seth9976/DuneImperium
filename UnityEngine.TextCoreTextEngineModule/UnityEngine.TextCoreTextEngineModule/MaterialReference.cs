using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200000F RID: 15
	public sealed class MaterialReference : ValueType
	{
		// Token: 0x06000177 RID: 375 RVA: 0x0000B624 File Offset: 0x00009824
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialReference()
		{
			Il2CppClassPointerStore<MaterialReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "MaterialReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr);
			MaterialReference.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, "index");
			MaterialReference.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, "fontAsset");
			MaterialReference.NativeFieldInfoPtr_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, "spriteAsset");
			MaterialReference.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, "material");
			MaterialReference.NativeFieldInfoPtr_isDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, "isDefaultMaterial");
			MaterialReference.NativeFieldInfoPtr_isFallbackMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, "isFallbackMaterial");
			MaterialReference.NativeFieldInfoPtr_fallbackMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, "fallbackMaterial");
			MaterialReference.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, "padding");
			MaterialReference.NativeFieldInfoPtr_referenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, "referenceCount");
			MaterialReference.NativeMethodInfoPtr__ctor_Public_Void_Int32_FontAsset_SpriteAsset_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, 100663451);
			MaterialReference.NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_FontAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, 100663452);
			MaterialReference.NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_SpriteAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, 100663453);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000B744 File Offset: 0x00009944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1100333, RefRangeEnd = 1100336, XrefRangeStart = 1100327, XrefRangeEnd = 1100333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialReference(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReference.NativeMethodInfoPtr__ctor_Public_Void_Int32_FontAsset_SpriteAsset_Material_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1100354, RefRangeEnd = 1100361, XrefRangeStart = 1100336, XrefRangeEnd = 1100354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddMaterialReference(Material material, FontAsset fontAsset, ref Il2CppReferenceArray<MaterialReference> materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(materialReferences);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(materialReferenceIndexLookup);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReference.NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_FontAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			materialReferences = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MaterialReference>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000B868 File Offset: 0x00009A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1100378, RefRangeEnd = 1100379, XrefRangeStart = 1100361, XrefRangeEnd = 1100378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref Il2CppReferenceArray<MaterialReference> materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(materialReferences);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(materialReferenceIndexLookup);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReference.NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_SpriteAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			materialReferences = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MaterialReference>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002B8B File Offset: 0x00000D8B
		public MaterialReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002B94 File Offset: 0x00000D94
		public MaterialReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr))
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002BA6 File Offset: 0x00000DA6
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000B920 File Offset: 0x00009B20
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002BC1 File Offset: 0x00000DC1
		public unsafe FontAsset fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000B950 File Offset: 0x00009B50
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public unsafe SpriteAsset spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000B980 File Offset: 0x00009B80
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002BFF File Offset: 0x00000DFF
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000B9B0 File Offset: 0x00009BB0
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002C1E File Offset: 0x00000E1E
		public unsafe bool isDefaultMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_isDefaultMaterial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_isDefaultMaterial)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000B9D8 File Offset: 0x00009BD8
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002C39 File Offset: 0x00000E39
		public unsafe bool isFallbackMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_isFallbackMaterial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_isFallbackMaterial)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000BA00 File Offset: 0x00009C00
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002C54 File Offset: 0x00000E54
		public unsafe Material fallbackMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_fallbackMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_fallbackMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000BA30 File Offset: 0x00009C30
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002C73 File Offset: 0x00000E73
		public unsafe float padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_padding)) = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000BA58 File Offset: 0x00009C58
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002C8E File Offset: 0x00000E8E
		public unsafe int referenceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_referenceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_referenceCount)) = value;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002CA9 File Offset: 0x00000EA9
		public static bool Contains(Il2CppReferenceArray<MaterialReference> materialReferences, FontAsset fontAsset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeFieldInfoPtr_spriteAsset;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr_isDefaultMaterial;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_isFallbackMaterial;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr_fallbackMaterial;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_referenceCount;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_FontAsset_SpriteAsset_Material_Single_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_FontAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_SpriteAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0;
	}
}
