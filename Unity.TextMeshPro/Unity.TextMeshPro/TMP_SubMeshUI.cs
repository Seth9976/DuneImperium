using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200005A RID: 90
	public class TMP_SubMeshUI : MaskableGraphic
	{
		// Token: 0x06000A2C RID: 2604 RVA: 0x0002B350 File Offset: 0x00029550
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SubMeshUI()
		{
			Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SubMeshUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr);
			TMP_SubMeshUI.NativeFieldInfoPtr_m_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_fontAsset");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_spriteAsset");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_material");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_sharedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_sharedMaterial");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_fallbackMaterial");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackSourceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_fallbackSourceMaterial");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_isDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_isDefaultMaterial");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_padding");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_mesh");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_TextComponent");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_isRegisteredForEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_isRegisteredForEvents");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_materialDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_materialDirty");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_materialReferenceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_materialReferenceIndex");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_RootCanvasTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_RootCanvasTransform");
			TMP_SubMeshUI.NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664434);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664435);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664436);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664437);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664438);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664439);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664440);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664441);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664442);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_fallbackMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664443);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664444);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_fallbackSourceMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664445);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_fallbackSourceMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664446);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664447);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_isDefaultMaterial_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664448);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_isDefaultMaterial_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664449);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_padding_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664450);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_padding_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664451);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664452);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664453);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664454);
			TMP_SubMeshUI.NativeMethodInfoPtr_AddSubTextObject_Public_Static_TMP_SubMeshUI_TextMeshProUGUI_MaterialReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664455);
			TMP_SubMeshUI.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664456);
			TMP_SubMeshUI.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664457);
			TMP_SubMeshUI.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664458);
			TMP_SubMeshUI.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664459);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664460);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664461);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664462);
			TMP_SubMeshUI.NativeMethodInfoPtr_UpdateMeshPadding_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664463);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664464);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664465);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664466);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664467);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetPivotDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664468);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetRootCanvasTransform_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664469);
			TMP_SubMeshUI.NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664470);
			TMP_SubMeshUI.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664471);
			TMP_SubMeshUI.NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664472);
			TMP_SubMeshUI.NativeMethodInfoPtr_RefreshMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664473);
			TMP_SubMeshUI.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664474);
			TMP_SubMeshUI.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664475);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664476);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetMaterial_Private_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664477);
			TMP_SubMeshUI.NativeMethodInfoPtr_CreateMaterialInstance_Private_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664478);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664479);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetSharedMaterial_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664480);
			TMP_SubMeshUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664481);
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0002B858 File Offset: 0x00029A58
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0002B898 File Offset: 0x00029A98
		public unsafe TMP_FontAsset fontAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0002B8DC File Offset: 0x00029ADC
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0002B91C File Offset: 0x00029B1C
		public unsafe TMP_SpriteAsset spriteAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0002B960 File Offset: 0x00029B60
		public unsafe override Texture mainTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046914, XrefRangeEnd = 1046919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0002B9AC File Offset: 0x00029BAC
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x0002B9F8 File Offset: 0x00029BF8
		public unsafe override Material material
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046919, XrefRangeEnd = 1046939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046939, XrefRangeEnd = 1046948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0002BA48 File Offset: 0x00029C48
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x0002BA88 File Offset: 0x00029C88
		public unsafe Material sharedMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1046951, RefRangeEnd = 1046953, XrefRangeStart = 1046948, XrefRangeEnd = 1046951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0002BACC File Offset: 0x00029CCC
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x0002BB0C File Offset: 0x00029D0C
		public unsafe Material fallbackMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_fallbackMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1046974, RefRangeEnd = 1046975, XrefRangeStart = 1046953, XrefRangeEnd = 1046974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0002BB50 File Offset: 0x00029D50
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x0002BB90 File Offset: 0x00029D90
		public unsafe Material fallbackSourceMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_fallbackSourceMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_fallbackSourceMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x0002BBD4 File Offset: 0x00029DD4
		public unsafe override Material materialForRendering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046975, XrefRangeEnd = 1046979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0002BC20 File Offset: 0x00029E20
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0002BC5C File Offset: 0x00029E5C
		public unsafe bool isDefaultMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_isDefaultMaterial_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_isDefaultMaterial_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0002BC9C File Offset: 0x00029E9C
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x0002BCD8 File Offset: 0x00029ED8
		public unsafe float padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_padding_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_padding_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0002BD18 File Offset: 0x00029F18
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0002BD58 File Offset: 0x00029F58
		public unsafe Mesh mesh
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1046989, RefRangeEnd = 1047001, XrefRangeStart = 1046979, XrefRangeEnd = 1046989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0002BD9C File Offset: 0x00029F9C
		public unsafe TMP_Text textComponent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047001, XrefRangeEnd = 1047009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002BDDC File Offset: 0x00029FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1047066, RefRangeEnd = 1047067, XrefRangeStart = 1047009, XrefRangeEnd = 1047066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(materialReference));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_AddSubTextObject_Public_Static_TMP_SubMeshUI_TextMeshProUGUI_MaterialReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SubMeshUI>(intPtr3) : null;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002BE38 File Offset: 0x0002A038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047067, XrefRangeEnd = 1047069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002BE74 File Offset: 0x0002A074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047069, XrefRangeEnd = 1047079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047079, XrefRangeEnd = 1047104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002BEEC File Offset: 0x0002A0EC
		[CallerCount(0)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002BF28 File Offset: 0x0002A128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047104, XrefRangeEnd = 1047115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Material GetModifiedMaterial(Material baseMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002BF84 File Offset: 0x0002A184
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1047120, RefRangeEnd = 1047127, XrefRangeStart = 1047115, XrefRangeEnd = 1047120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPaddingForMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002BFC0 File Offset: 0x0002A1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047127, XrefRangeEnd = 1047132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPaddingForMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002C010 File Offset: 0x0002A210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1047136, RefRangeEnd = 1047137, XrefRangeStart = 1047132, XrefRangeEnd = 1047136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isExtraPadding;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUsingBold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_UpdateMeshPadding_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002C05C File Offset: 0x0002A25C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetAllDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0002C098 File Offset: 0x0002A298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047137, XrefRangeEnd = 1047142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVerticesDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002C0D4 File Offset: 0x0002A2D4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0002C110 File Offset: 0x0002A310
		[CallerCount(0)]
		public unsafe override void SetMaterialDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0002C14C File Offset: 0x0002A34C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1047146, RefRangeEnd = 1047148, XrefRangeStart = 1047142, XrefRangeEnd = 1047146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPivotDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_SetPivotDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002C180 File Offset: 0x0002A380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047148, XrefRangeEnd = 1047156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetRootCanvasTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetRootCanvasTransform_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cull(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0002C218 File Offset: 0x0002A418
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0002C254 File Offset: 0x0002A454
		[CallerCount(0)]
		public unsafe override void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0002C2A0 File Offset: 0x0002A4A0
		[CallerCount(0)]
		public unsafe void RefreshMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_RefreshMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0002C2D4 File Offset: 0x0002A4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047156, XrefRangeEnd = 1047183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0002C310 File Offset: 0x0002A510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecalculateClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0002C34C File Offset: 0x0002A54C
		[CallerCount(0)]
		public unsafe Material GetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0002C38C File Offset: 0x0002A58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047183, XrefRangeEnd = 1047203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetMaterial_Private_Material_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0002C3DC File Offset: 0x0002A5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047203, XrefRangeEnd = 1047214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material CreateMaterialInstance(Material source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_CreateMaterialInstance_Private_Material_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0002C42C File Offset: 0x0002A62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047214, XrefRangeEnd = 1047217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetSharedMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0002C46C File Offset: 0x0002A66C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1046951, RefRangeEnd = 1046953, XrefRangeStart = 1046951, XrefRangeEnd = 1046953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSharedMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_SetSharedMaterial_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0002C4B0 File Offset: 0x0002A6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SubMeshUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00006B33 File Offset: 0x00004D33
		public TMP_SubMeshUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0002C4EC File Offset: 0x0002A6EC
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00006B3C File Offset: 0x00004D3C
		public unsafe TMP_FontAsset m_fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0002C51C File Offset: 0x0002A71C
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00006B5B File Offset: 0x00004D5B
		public unsafe TMP_SpriteAsset m_spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0002C54C File Offset: 0x0002A74C
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00006B7A File Offset: 0x00004D7A
		public unsafe Material m_material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0002C57C File Offset: 0x0002A77C
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00006B99 File Offset: 0x00004D99
		public unsafe Material m_sharedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_sharedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_sharedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0002C5AC File Offset: 0x0002A7AC
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00006BB8 File Offset: 0x00004DB8
		public unsafe Material m_fallbackMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0002C5DC File Offset: 0x0002A7DC
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00006BD7 File Offset: 0x00004DD7
		public unsafe Material m_fallbackSourceMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackSourceMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackSourceMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0002C60C File Offset: 0x0002A80C
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00006BF6 File Offset: 0x00004DF6
		public unsafe bool m_isDefaultMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_isDefaultMaterial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_isDefaultMaterial)) = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0002C634 File Offset: 0x0002A834
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00006C11 File Offset: 0x00004E11
		public unsafe float m_padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_padding)) = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0002C65C File Offset: 0x0002A85C
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00006C2C File Offset: 0x00004E2C
		public unsafe Mesh m_mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0002C68C File Offset: 0x0002A88C
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00006C4B File Offset: 0x00004E4B
		public unsafe TextMeshProUGUI m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0002C6BC File Offset: 0x0002A8BC
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00006C6A File Offset: 0x00004E6A
		public unsafe bool m_isRegisteredForEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_isRegisteredForEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_isRegisteredForEvents)) = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002C6E4 File Offset: 0x0002A8E4
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00006C85 File Offset: 0x00004E85
		public unsafe bool m_materialDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_materialDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_materialDirty)) = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0002C70C File Offset: 0x0002A90C
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00006CA0 File Offset: 0x00004EA0
		public unsafe int m_materialReferenceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_materialReferenceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_materialReferenceIndex)) = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0002C734 File Offset: 0x0002A934
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00006CBB File Offset: 0x00004EBB
		public unsafe Transform m_RootCanvasTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_RootCanvasTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_RootCanvasTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeFieldInfoPtr_m_fontAsset;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAsset;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr_m_material;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_m_sharedMaterial;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterial;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackSourceMaterial;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultMaterial;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeFieldInfoPtr_m_padding;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeFieldInfoPtr_m_mesh;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeFieldInfoPtr_m_isRegisteredForEvents;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeFieldInfoPtr_m_materialDirty;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferenceIndex;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeFieldInfoPtr_m_RootCanvasTransform;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackMaterial_Public_get_Material_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackSourceMaterial_Public_get_Material_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackSourceMaterial_Public_set_Void_Material_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultMaterial_Public_get_Boolean_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_set_isDefaultMaterial_Public_set_Void_Boolean_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_Single_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_set_padding_Public_set_Void_Single_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_AddSubTextObject_Public_Static_TMP_SubMeshUI_TextMeshProUGUI_MaterialReference_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_Material_Material_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_Material_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMeshPadding_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_SetPivotDirty_Public_Void_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_GetRootCanvasTransform_Private_Transform_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_RefreshMaterial_Public_Void_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_Void_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_Material_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_CreateMaterialInstance_Private_Material_Material_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterial_Private_Void_Material_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
