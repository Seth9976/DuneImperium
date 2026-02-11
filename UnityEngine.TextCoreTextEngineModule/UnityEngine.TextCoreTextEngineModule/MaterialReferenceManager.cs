using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000010 RID: 16
	public class MaterialReferenceManager : Object
	{
		// Token: 0x06000190 RID: 400 RVA: 0x0000BA80 File Offset: 0x00009C80
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialReferenceManager()
		{
			Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "MaterialReferenceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr);
			MaterialReferenceManager.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "s_Instance");
			MaterialReferenceManager.NativeFieldInfoPtr_m_FontMaterialReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_FontMaterialReferenceLookup");
			MaterialReferenceManager.NativeFieldInfoPtr_m_FontAssetReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_FontAssetReferenceLookup");
			MaterialReferenceManager.NativeFieldInfoPtr_m_SpriteAssetReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_SpriteAssetReferenceLookup");
			MaterialReferenceManager.NativeFieldInfoPtr_m_ColorGradientReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_ColorGradientReferenceLookup");
			MaterialReferenceManager.NativeMethodInfoPtr_get_instance_Public_Static_get_MaterialReferenceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663454);
			MaterialReferenceManager.NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663455);
			MaterialReferenceManager.NativeMethodInfoPtr_AddFontAssetInternal_Private_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663456);
			MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_Int32_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663457);
			MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_Int32_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663458);
			MaterialReferenceManager.NativeMethodInfoPtr_AddFontMaterial_Public_Static_Void_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663459);
			MaterialReferenceManager.NativeMethodInfoPtr_AddFontMaterialInternal_Private_Void_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663460);
			MaterialReferenceManager.NativeMethodInfoPtr_AddColorGradientPreset_Public_Static_Void_Int32_TextColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663461);
			MaterialReferenceManager.NativeMethodInfoPtr_AddColorGradientPreset_Internal_Private_Void_Int32_TextColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663462);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663463);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetFontAssetInternal_Private_Boolean_Int32_byref_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663464);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetSpriteAsset_Public_Static_Boolean_Int32_byref_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663465);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetSpriteAssetInternal_Private_Boolean_Int32_byref_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663466);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetColorGradientPreset_Public_Static_Boolean_Int32_byref_TextColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663467);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetColorGradientPresetInternal_Private_Boolean_Int32_byref_TextColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663468);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetMaterial_Public_Static_Boolean_Int32_byref_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663469);
			MaterialReferenceManager.NativeMethodInfoPtr_TryGetMaterialInternal_Private_Boolean_Int32_byref_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663470);
			MaterialReferenceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663471);
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000BC7C File Offset: 0x00009E7C
		public unsafe static MaterialReferenceManager instance
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1100415, RefRangeEnd = 1100423, XrefRangeStart = 1100379, XrefRangeEnd = 1100415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000192 RID: 402 RVA: 0x0000BCB0 File Offset: 0x00009EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100423, XrefRangeEnd = 1100443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFontAsset(FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100443, XrefRangeEnd = 1100462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFontAssetInternal(FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddFontAssetInternal_Private_Void_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000BD2C File Offset: 0x00009F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100462, XrefRangeEnd = 1100472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_Int32_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000BD70 File Offset: 0x00009F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100472, XrefRangeEnd = 1100481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_Int32_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1100486, RefRangeEnd = 1100487, XrefRangeStart = 1100481, XrefRangeEnd = 1100486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000197 RID: 407 RVA: 0x0000BE04 File Offset: 0x0000A004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100487, XrefRangeEnd = 1100491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000198 RID: 408 RVA: 0x0000BE54 File Offset: 0x0000A054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100491, XrefRangeEnd = 1100498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddColorGradientPreset_Public_Static_Void_Int32_TextColorGradient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000BE98 File Offset: 0x0000A098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100498, XrefRangeEnd = 1100504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_AddColorGradientPreset_Internal_Private_Void_Int32_TextColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100504, XrefRangeEnd = 1100510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_FontAsset_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fontAsset = ((intPtr4 == 0) ? null : new FontAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000BF48 File Offset: 0x0000A148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100510, XrefRangeEnd = 1100515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetFontAssetInternal_Private_Boolean_Int32_byref_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fontAsset = ((intPtr4 == 0) ? null : new FontAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100515, XrefRangeEnd = 1100521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetSpriteAsset_Public_Static_Boolean_Int32_byref_SpriteAsset_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			spriteAsset = ((intPtr4 == 0) ? null : new SpriteAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000C014 File Offset: 0x0000A214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100521, XrefRangeEnd = 1100526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetSpriteAssetInternal_Private_Boolean_Int32_byref_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			spriteAsset = ((intPtr4 == 0) ? null : new SpriteAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000C080 File Offset: 0x0000A280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100526, XrefRangeEnd = 1100532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetColorGradientPreset_Public_Static_Boolean_Int32_byref_TextColorGradient_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			gradientPreset = ((intPtr4 == 0) ? null : new TextColorGradient(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000C0E0 File Offset: 0x0000A2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100532, XrefRangeEnd = 1100537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr_TryGetColorGradientPresetInternal_Private_Boolean_Int32_byref_TextColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			gradientPreset = ((intPtr4 == 0) ? null : new TextColorGradient(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000C14C File Offset: 0x0000A34C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1100543, RefRangeEnd = 1100544, XrefRangeStart = 1100537, XrefRangeEnd = 1100543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001A1 RID: 417 RVA: 0x0000C1AC File Offset: 0x0000A3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100544, XrefRangeEnd = 1100549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001A2 RID: 418 RVA: 0x0000C218 File Offset: 0x0000A418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100549, XrefRangeEnd = 1100578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialReferenceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialReferenceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002CB6 File Offset: 0x00000EB6
		public MaterialReferenceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000C254 File Offset: 0x0000A454
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002CBF File Offset: 0x00000EBF
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000C27C File Offset: 0x0000A47C
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002CD1 File Offset: 0x00000ED1
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000C2AC File Offset: 0x0000A4AC
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public unsafe Dictionary<int, FontAsset> m_FontAssetReferenceLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_FontAssetReferenceLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_FontAssetReferenceLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002D0F File Offset: 0x00000F0F
		public unsafe Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_SpriteAssetReferenceLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SpriteAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_SpriteAssetReferenceLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000C30C File Offset: 0x0000A50C
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002D2E File Offset: 0x00000F2E
		public unsafe Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_ColorGradientReferenceLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TextColorGradient>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialReferenceManager.NativeFieldInfoPtr_m_ColorGradientReferenceLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002D4D File Offset: 0x00000F4D
		public static void AddSpriteAsset(SpriteAsset spriteAsset)
		{
			MaterialReferenceManager.instance.AddSpriteAssetInternal(spriteAsset);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000C33C File Offset: 0x0000A53C
		public void AddSpriteAssetInternal(SpriteAsset spriteAsset)
		{
			bool flag = this.m_SpriteAssetReferenceLookup.ContainsKey(spriteAsset.hashCode);
			if (!flag)
			{
				this.m_SpriteAssetReferenceLookup.Add(spriteAsset.hashCode, spriteAsset);
				this.m_FontMaterialReferenceLookup.Add(spriteAsset.hashCode, spriteAsset.material);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000C38C File Offset: 0x0000A58C
		public bool Contains(FontAsset font)
		{
			return this.m_FontAssetReferenceLookup.ContainsKey(font.hashCode);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		public bool Contains(SpriteAsset sprite)
		{
			return this.m_FontAssetReferenceLookup.ContainsKey(sprite.hashCode);
		}

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_m_FontMaterialReferenceLookup;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_m_FontAssetReferenceLookup;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteAssetReferenceLookup;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradientReferenceLookup;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_MaterialReferenceManager_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_FontAsset_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_AddFontAssetInternal_Private_Void_FontAsset_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_Int32_SpriteAsset_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_Int32_SpriteAsset_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_AddFontMaterial_Public_Static_Void_Int32_Material_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_AddFontMaterialInternal_Private_Void_Int32_Material_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_AddColorGradientPreset_Public_Static_Void_Int32_TextColorGradient_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_AddColorGradientPreset_Internal_Private_Void_Int32_TextColorGradient_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_FontAsset_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFontAssetInternal_Private_Boolean_Int32_byref_FontAsset_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSpriteAsset_Public_Static_Boolean_Int32_byref_SpriteAsset_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSpriteAssetInternal_Private_Boolean_Int32_byref_SpriteAsset_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_TryGetColorGradientPreset_Public_Static_Boolean_Int32_byref_TextColorGradient_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_TryGetColorGradientPresetInternal_Private_Boolean_Int32_byref_TextColorGradient_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_TryGetMaterial_Public_Static_Boolean_Int32_byref_Material_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_TryGetMaterialInternal_Private_Boolean_Int32_byref_Material_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
