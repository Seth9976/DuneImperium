using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000008 RID: 8
	public class MaterialReferenceManager : global::Il2CppSystem.Object
	{
		// Token: 0x06000030 RID: 48 RVA: 0x0000AA14 File Offset: 0x00008C14
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialReferenceManager()
		{
			Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "MaterialReferenceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr);
			MaterialReferenceManager.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "s_Instance");
			MaterialReferenceManager.NativeFieldInfoPtr_m_FontMaterialReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_FontMaterialReferenceLookup");
			MaterialReferenceManager.NativeFieldInfoPtr_m_FontAssetReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_FontAssetReferenceLookup");
			MaterialReferenceManager.NativeFieldInfoPtr_m_SpriteAssetReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_SpriteAssetReferenceLookup");
			MaterialReferenceManager.NativeFieldInfoPtr_m_ColorGradientReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_ColorGradientReferenceLookup");
			MaterialReferenceManager.NativeMethodInfoPtr_get_instance_Public_Static_get_MaterialReferenceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663316);
			MaterialReferenceManager.NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663317);
			MaterialReferenceManager.NativeMethodInfoPtr_AddFontAssetInternal_Private_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663318);
			MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663319);
			MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663320);
			MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_Int32_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663321);
			MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_Int32_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663322);
			MaterialReferenceManager.NativeMethodInfoPtr_AddFontMaterial_Public_Static_Void_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663323);
			MaterialReferenceManager.NativeMethodInfoPtr_AddFontMaterialInternal_Private_Void_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663324);
			MaterialReferenceManager.NativeMethodInfoPtr_AddColorGradientPreset_Public_Static_Void_Int32_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663325);
			MaterialReferenceManager.NativeMethodInfoPtr_AddColorGradientPreset_Internal_Private_Void_Int32_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663326);
			MaterialReferenceManager.NativeMethodInfoPtr_Contains_Public_Boolean_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663327);
			MaterialReferenceManager.NativeMethodInfoPtr_Contains_Public_Boolean_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663328);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663329);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetFontAssetInternal_Private_Boolean_Int32_byref_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663330);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetSpriteAsset_Public_Static_Boolean_Int32_byref_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663331);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetSpriteAssetInternal_Private_Boolean_Int32_byref_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663332);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetColorGradientPreset_Public_Static_Boolean_Int32_byref_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663333);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetColorGradientPresetInternal_Private_Boolean_Int32_byref_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663334);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetMaterial_Public_Static_Boolean_Int32_byref_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663335);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetMaterialInternal_Private_Boolean_Int32_byref_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663336);
			MaterialReferenceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663337);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000AC60 File Offset: 0x00008E60
		public unsafe static MaterialReferenceManager instance
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1032455, RefRangeEnd = 1032464, XrefRangeStart = 1032419, XrefRangeEnd = 1032455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_get_instance_Public_Static_get_MaterialReferenceManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MaterialReferenceManager>(intPtr3) : null;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000AC94 File Offset: 0x00008E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032464, XrefRangeEnd = 1032474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFontAsset(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000ACCC File Offset: 0x00008ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032474, XrefRangeEnd = 1032483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFontAssetInternal(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddFontAssetInternal_Private_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000AD10 File Offset: 0x00008F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032483, XrefRangeEnd = 1032493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSpriteAsset(TMP_SpriteAsset spriteAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000AD48 File Offset: 0x00008F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032493, XrefRangeEnd = 1032502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000AD8C File Offset: 0x00008F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032502, XrefRangeEnd = 1032512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_Int32_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032512, XrefRangeEnd = 1032521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_Int32_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000AE20 File Offset: 0x00009020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032521, XrefRangeEnd = 1032526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFontMaterial(int hashCode, Material material)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddFontMaterial_Public_Static_Void_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000AE64 File Offset: 0x00009064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032526, XrefRangeEnd = 1032530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFontMaterialInternal(int hashCode, Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddFontMaterialInternal_Private_Void_Int32_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000AEB4 File Offset: 0x000090B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032530, XrefRangeEnd = 1032537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddColorGradientPreset_Public_Static_Void_Int32_TMP_ColorGradient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000AEF8 File Offset: 0x000090F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032537, XrefRangeEnd = 1032543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddColorGradientPreset_Internal_Private_Void_Int32_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000AF48 File Offset: 0x00009148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032543, XrefRangeEnd = 1032547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(TMP_FontAsset font)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_Contains_Public_Boolean_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000AF98 File Offset: 0x00009198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032547, XrefRangeEnd = 1032551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(TMP_SpriteAsset sprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_Contains_Public_Boolean_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000AFE8 File Offset: 0x000091E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032551, XrefRangeEnd = 1032557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fontAsset = ((intPtr4 == 0) ? null : new TMP_FontAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000B048 File Offset: 0x00009248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032557, XrefRangeEnd = 1032562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetFontAssetInternal_Private_Boolean_Int32_byref_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fontAsset = ((intPtr4 == 0) ? null : new TMP_FontAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000B0B4 File Offset: 0x000092B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032562, XrefRangeEnd = 1032568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetSpriteAsset_Public_Static_Boolean_Int32_byref_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			spriteAsset = ((intPtr4 == 0) ? null : new TMP_SpriteAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000B114 File Offset: 0x00009314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032568, XrefRangeEnd = 1032573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetSpriteAssetInternal_Private_Boolean_Int32_byref_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			spriteAsset = ((intPtr4 == 0) ? null : new TMP_SpriteAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000B180 File Offset: 0x00009380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032573, XrefRangeEnd = 1032579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetColorGradientPreset_Public_Static_Boolean_Int32_byref_TMP_ColorGradient_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			gradientPreset = ((intPtr4 == 0) ? null : new TMP_ColorGradient(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000B1E0 File Offset: 0x000093E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032579, XrefRangeEnd = 1032584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetColorGradientPresetInternal_Private_Boolean_Int32_byref_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			gradientPreset = ((intPtr4 == 0) ? null : new TMP_ColorGradient(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000B24C File Offset: 0x0000944C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032584, XrefRangeEnd = 1032590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetMaterial(int hashCode, out Material material)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetMaterial_Public_Static_Boolean_Int32_byref_Material_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			material = ((intPtr4 == 0) ? null : new Material(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000B2AC File Offset: 0x000094AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032590, XrefRangeEnd = 1032595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetMaterialInternal(int hashCode, out Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetMaterialInternal_Private_Boolean_Int32_byref_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			material = ((intPtr4 == 0) ? null : new Material(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000B318 File Offset: 0x00009518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032595, XrefRangeEnd = 1032624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialReferenceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000021AD File Offset: 0x000003AD
		public MaterialReferenceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000B354 File Offset: 0x00009554
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000021B6 File Offset: 0x000003B6
		public unsafe static MaterialReferenceManager s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialReferenceManager.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialReferenceManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialReferenceManager.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000B37C File Offset: 0x0000957C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000021C8 File Offset: 0x000003C8
		public unsafe Dictionary<int, Material> m_FontMaterialReferenceLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_FontMaterialReferenceLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_FontMaterialReferenceLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000B3AC File Offset: 0x000095AC
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000021E7 File Offset: 0x000003E7
		public unsafe Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_FontAssetReferenceLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_FontAssetReferenceLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000B3DC File Offset: 0x000095DC
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002206 File Offset: 0x00000406
		public unsafe Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_SpriteAssetReferenceLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TMP_SpriteAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_SpriteAssetReferenceLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000B40C File Offset: 0x0000960C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002225 File Offset: 0x00000425
		public unsafe Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_ColorGradientReferenceLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TMP_ColorGradient>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_ColorGradientReferenceLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_m_FontMaterialReferenceLookup;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_m_FontAssetReferenceLookup;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteAssetReferenceLookup;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradientReferenceLookup;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_MaterialReferenceManager_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_AddFontAssetInternal_Private_Void_TMP_FontAsset_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_TMP_SpriteAsset_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_TMP_SpriteAsset_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_Int32_TMP_SpriteAsset_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_Int32_TMP_SpriteAsset_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_AddFontMaterial_Public_Static_Void_Int32_Material_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_AddFontMaterialInternal_Private_Void_Int32_Material_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_AddColorGradientPreset_Public_Static_Void_Int32_TMP_ColorGradient_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_AddColorGradientPreset_Internal_Private_Void_Int32_TMP_ColorGradient_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_TMP_FontAsset_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_TMP_SpriteAsset_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_TMP_FontAsset_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFontAssetInternal_Private_Boolean_Int32_byref_TMP_FontAsset_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSpriteAsset_Public_Static_Boolean_Int32_byref_TMP_SpriteAsset_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSpriteAssetInternal_Private_Boolean_Int32_byref_TMP_SpriteAsset_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_TryGetColorGradientPreset_Public_Static_Boolean_Int32_byref_TMP_ColorGradient_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_TryGetColorGradientPresetInternal_Private_Boolean_Int32_byref_TMP_ColorGradient_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_TryGetMaterial_Public_Static_Boolean_Int32_byref_Material_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_TryGetMaterialInternal_Private_Boolean_Int32_byref_Material_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
