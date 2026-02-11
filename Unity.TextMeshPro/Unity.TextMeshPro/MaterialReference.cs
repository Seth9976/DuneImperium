using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200000A RID: 10
	public sealed class MaterialReference : ValueType
	{
		// Token: 0x06000059 RID: 89 RVA: 0x0000B4EC File Offset: 0x000096EC
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialReference()
		{
			Il2CppClassPointerStore<MaterialReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "MaterialReference");
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
			MaterialReference.NativeMethodInfoPtr__ctor_Public_Void_Int32_TMP_FontAsset_TMP_SpriteAsset_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, 100663338);
			MaterialReference.NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppReferenceArray_1_MaterialReference_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, 100663339);
			MaterialReference.NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_TMP_FontAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, 100663340);
			MaterialReference.NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_TMP_SpriteAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr, 100663341);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000B620 File Offset: 0x00009820
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1032630, RefRangeEnd = 1032633, XrefRangeStart = 1032624, XrefRangeEnd = 1032630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReference.NativeMethodInfoPtr__ctor_Public_Void_Int32_TMP_FontAsset_TMP_SpriteAsset_Material_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000B6B4 File Offset: 0x000098B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032633, XrefRangeEnd = 1032640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains(Il2CppReferenceArray<MaterialReference> materialReferences, TMP_FontAsset fontAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materialReferences);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReference.NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppReferenceArray_1_MaterialReference_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000B708 File Offset: 0x00009908
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1032658, RefRangeEnd = 1032668, XrefRangeStart = 1032640, XrefRangeEnd = 1032658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref Il2CppReferenceArray<MaterialReference> materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReference.NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_TMP_FontAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			materialReferences = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MaterialReference>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000B798 File Offset: 0x00009998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1032685, RefRangeEnd = 1032687, XrefRangeStart = 1032668, XrefRangeEnd = 1032685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref Il2CppReferenceArray<MaterialReference> materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReference.NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_TMP_SpriteAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			materialReferences = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MaterialReference>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002299 File Offset: 0x00000499
		public MaterialReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000022A2 File Offset: 0x000004A2
		public MaterialReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialReference>.NativeClassPtr))
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000B828 File Offset: 0x00009A28
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000022B4 File Offset: 0x000004B4
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000B850 File Offset: 0x00009A50
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000022CF File Offset: 0x000004CF
		public unsafe TMP_FontAsset fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000B880 File Offset: 0x00009A80
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000022EE File Offset: 0x000004EE
		public unsafe TMP_SpriteAsset spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReference.NativeFieldInfoPtr_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000230D File Offset: 0x0000050D
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000232C File Offset: 0x0000052C
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000B908 File Offset: 0x00009B08
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002347 File Offset: 0x00000547
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

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000B930 File Offset: 0x00009B30
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002362 File Offset: 0x00000562
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000B960 File Offset: 0x00009B60
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002381 File Offset: 0x00000581
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000B988 File Offset: 0x00009B88
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000239C File Offset: 0x0000059C
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

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_spriteAsset;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_isDefaultMaterial;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_isFallbackMaterial;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_fallbackMaterial;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_referenceCount;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TMP_FontAsset_TMP_SpriteAsset_Material_Single_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppReferenceArray_1_MaterialReference_TMP_FontAsset_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_TMP_FontAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_AddMaterialReference_Public_Static_Int32_Material_TMP_SpriteAsset_byref_Il2CppReferenceArray_1_MaterialReference_Dictionary_2_Int32_Int32_0;
	}
}
