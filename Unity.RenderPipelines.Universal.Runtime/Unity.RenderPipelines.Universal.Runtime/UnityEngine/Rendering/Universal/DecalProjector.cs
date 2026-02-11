using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000067 RID: 103
	public class DecalProjector : MonoBehaviour
	{
		// Token: 0x060008A6 RID: 2214 RVA: 0x00033460 File Offset: 0x00031660
		// Note: this type is marked as 'beforefieldinit'.
		static DecalProjector()
		{
			Il2CppClassPointerStore<DecalProjector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalProjector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr);
			DecalProjector.NativeFieldInfoPtr_onDecalAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "onDecalAdd");
			DecalProjector.NativeFieldInfoPtr_onDecalRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "onDecalRemove");
			DecalProjector.NativeFieldInfoPtr_onDecalPropertyChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "onDecalPropertyChange");
			DecalProjector.NativeFieldInfoPtr_onAllDecalPropertyChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "onAllDecalPropertyChange");
			DecalProjector.NativeFieldInfoPtr_onDecalMaterialChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "onDecalMaterialChange");
			DecalProjector.NativeFieldInfoPtr__defaultMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "<defaultMaterial>k__BackingField");
			DecalProjector.NativeFieldInfoPtr__decalEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "<decalEntity>k__BackingField");
			DecalProjector.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_Material");
			DecalProjector.NativeFieldInfoPtr_m_DrawDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_DrawDistance");
			DecalProjector.NativeFieldInfoPtr_m_FadeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_FadeScale");
			DecalProjector.NativeFieldInfoPtr_m_StartAngleFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_StartAngleFade");
			DecalProjector.NativeFieldInfoPtr_m_EndAngleFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_EndAngleFade");
			DecalProjector.NativeFieldInfoPtr_m_UVScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_UVScale");
			DecalProjector.NativeFieldInfoPtr_m_UVBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_UVBias");
			DecalProjector.NativeFieldInfoPtr_m_DecalLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_DecalLayerMask");
			DecalProjector.NativeFieldInfoPtr_m_ScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_ScaleMode");
			DecalProjector.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_Offset");
			DecalProjector.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_Size");
			DecalProjector.NativeFieldInfoPtr_m_FadeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_FadeFactor");
			DecalProjector.NativeFieldInfoPtr_m_OldMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldMaterial");
			DecalProjector.NativeFieldInfoPtr_m_OldDrawDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldDrawDistance");
			DecalProjector.NativeFieldInfoPtr_m_OldFadeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldFadeScale");
			DecalProjector.NativeFieldInfoPtr_m_OldStartAngleFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldStartAngleFade");
			DecalProjector.NativeFieldInfoPtr_m_OldEndAngleFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldEndAngleFade");
			DecalProjector.NativeFieldInfoPtr_m_OldUVScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldUVScale");
			DecalProjector.NativeFieldInfoPtr_m_OldUVBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldUVBias");
			DecalProjector.NativeFieldInfoPtr_m_OldScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldScaleMode");
			DecalProjector.NativeFieldInfoPtr_m_OldOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldOffset");
			DecalProjector.NativeFieldInfoPtr_m_OldSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldSize");
			DecalProjector.NativeFieldInfoPtr_m_OldFadeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "m_OldFadeFactor");
			DecalProjector.NativeMethodInfoPtr_add_onDecalAdd_Internal_Static_add_Void_DecalProjectorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664484);
			DecalProjector.NativeMethodInfoPtr_remove_onDecalAdd_Internal_Static_rem_Void_DecalProjectorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664485);
			DecalProjector.NativeMethodInfoPtr_add_onDecalRemove_Internal_Static_add_Void_DecalProjectorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664486);
			DecalProjector.NativeMethodInfoPtr_remove_onDecalRemove_Internal_Static_rem_Void_DecalProjectorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664487);
			DecalProjector.NativeMethodInfoPtr_add_onDecalPropertyChange_Internal_Static_add_Void_DecalProjectorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664488);
			DecalProjector.NativeMethodInfoPtr_remove_onDecalPropertyChange_Internal_Static_rem_Void_DecalProjectorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664489);
			DecalProjector.NativeMethodInfoPtr_add_onAllDecalPropertyChange_Internal_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664490);
			DecalProjector.NativeMethodInfoPtr_remove_onAllDecalPropertyChange_Internal_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664491);
			DecalProjector.NativeMethodInfoPtr_add_onDecalMaterialChange_Internal_Static_add_Void_DecalProjectorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664492);
			DecalProjector.NativeMethodInfoPtr_remove_onDecalMaterialChange_Internal_Static_rem_Void_DecalProjectorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664493);
			DecalProjector.NativeMethodInfoPtr_get_defaultMaterial_Internal_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664494);
			DecalProjector.NativeMethodInfoPtr_set_defaultMaterial_Internal_Static_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664495);
			DecalProjector.NativeMethodInfoPtr_get_isSupported_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664496);
			DecalProjector.NativeMethodInfoPtr_get_decalEntity_Internal_get_DecalEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664497);
			DecalProjector.NativeMethodInfoPtr_set_decalEntity_Internal_set_Void_DecalEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664498);
			DecalProjector.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664499);
			DecalProjector.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664500);
			DecalProjector.NativeMethodInfoPtr_get_drawDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664501);
			DecalProjector.NativeMethodInfoPtr_set_drawDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664502);
			DecalProjector.NativeMethodInfoPtr_get_fadeScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664503);
			DecalProjector.NativeMethodInfoPtr_set_fadeScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664504);
			DecalProjector.NativeMethodInfoPtr_get_startAngleFade_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664505);
			DecalProjector.NativeMethodInfoPtr_set_startAngleFade_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664506);
			DecalProjector.NativeMethodInfoPtr_get_endAngleFade_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664507);
			DecalProjector.NativeMethodInfoPtr_set_endAngleFade_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664508);
			DecalProjector.NativeMethodInfoPtr_get_uvScale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664509);
			DecalProjector.NativeMethodInfoPtr_set_uvScale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664510);
			DecalProjector.NativeMethodInfoPtr_get_uvBias_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664511);
			DecalProjector.NativeMethodInfoPtr_set_uvBias_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664512);
			DecalProjector.NativeMethodInfoPtr_get_renderingLayerMask_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664513);
			DecalProjector.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664514);
			DecalProjector.NativeMethodInfoPtr_get_scaleMode_Public_get_DecalScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664515);
			DecalProjector.NativeMethodInfoPtr_set_scaleMode_Public_set_Void_DecalScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664516);
			DecalProjector.NativeMethodInfoPtr_get_pivot_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664517);
			DecalProjector.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664518);
			DecalProjector.NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664519);
			DecalProjector.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664520);
			DecalProjector.NativeMethodInfoPtr_get_fadeFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664521);
			DecalProjector.NativeMethodInfoPtr_set_fadeFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664522);
			DecalProjector.NativeMethodInfoPtr_get_effectiveScale_Internal_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664523);
			DecalProjector.NativeMethodInfoPtr_get_decalSize_Internal_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664524);
			DecalProjector.NativeMethodInfoPtr_get_decalOffset_Internal_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664525);
			DecalProjector.NativeMethodInfoPtr_get_uvScaleBias_Internal_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664526);
			DecalProjector.NativeMethodInfoPtr_InitMaterial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664527);
			DecalProjector.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664528);
			DecalProjector.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664529);
			DecalProjector.NativeMethodInfoPtr_OnValidate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664530);
			DecalProjector.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664531);
			DecalProjector.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664532);
			DecalProjector.NativeMethodInfoPtr_UpdateAllDecalProperties_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664533);
			DecalProjector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, 100664534);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00033AE4 File Offset: 0x00031CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606578, RefRangeEnd = 606579, XrefRangeStart = 606571, XrefRangeEnd = 606578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onDecalAdd(DecalProjector.DecalProjectorAction value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_add_onDecalAdd_Internal_Static_add_Void_DecalProjectorAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00033B1C File Offset: 0x00031D1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 606586, RefRangeEnd = 606589, XrefRangeStart = 606579, XrefRangeEnd = 606586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onDecalAdd(DecalProjector.DecalProjectorAction value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_remove_onDecalAdd_Internal_Static_rem_Void_DecalProjectorAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00033B54 File Offset: 0x00031D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606596, RefRangeEnd = 606597, XrefRangeStart = 606589, XrefRangeEnd = 606596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onDecalRemove(DecalProjector.DecalProjectorAction value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_add_onDecalRemove_Internal_Static_add_Void_DecalProjectorAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00033B8C File Offset: 0x00031D8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 606604, RefRangeEnd = 606607, XrefRangeStart = 606597, XrefRangeEnd = 606604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onDecalRemove(DecalProjector.DecalProjectorAction value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_remove_onDecalRemove_Internal_Static_rem_Void_DecalProjectorAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00033BC4 File Offset: 0x00031DC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606614, RefRangeEnd = 606615, XrefRangeStart = 606607, XrefRangeEnd = 606614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onDecalPropertyChange(DecalProjector.DecalProjectorAction value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_add_onDecalPropertyChange_Internal_Static_add_Void_DecalProjectorAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00033BFC File Offset: 0x00031DFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 606622, RefRangeEnd = 606625, XrefRangeStart = 606615, XrefRangeEnd = 606622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onDecalPropertyChange(DecalProjector.DecalProjectorAction value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_remove_onDecalPropertyChange_Internal_Static_rem_Void_DecalProjectorAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00033C34 File Offset: 0x00031E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606632, RefRangeEnd = 606633, XrefRangeStart = 606625, XrefRangeEnd = 606632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onAllDecalPropertyChange(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_add_onAllDecalPropertyChange_Internal_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00033C6C File Offset: 0x00031E6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 606640, RefRangeEnd = 606643, XrefRangeStart = 606633, XrefRangeEnd = 606640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onAllDecalPropertyChange(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_remove_onAllDecalPropertyChange_Internal_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00033CA4 File Offset: 0x00031EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606650, RefRangeEnd = 606651, XrefRangeStart = 606643, XrefRangeEnd = 606650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onDecalMaterialChange(DecalProjector.DecalProjectorAction value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_add_onDecalMaterialChange_Internal_Static_add_Void_DecalProjectorAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00033CDC File Offset: 0x00031EDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 606658, RefRangeEnd = 606661, XrefRangeStart = 606651, XrefRangeEnd = 606658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onDecalMaterialChange(DecalProjector.DecalProjectorAction value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_remove_onDecalMaterialChange_Internal_Static_rem_Void_DecalProjectorAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00033D14 File Offset: 0x00031F14
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00033D48 File Offset: 0x00031F48
		public unsafe static Material defaultMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606661, XrefRangeEnd = 606663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_defaultMaterial_Internal_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606663, XrefRangeEnd = 606667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_defaultMaterial_Internal_Static_set_Void_Material_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00033D80 File Offset: 0x00031F80
		public unsafe static bool isSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606667, XrefRangeEnd = 606669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_isSupported_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00033DB0 File Offset: 0x00031FB0
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00033DEC File Offset: 0x00031FEC
		public unsafe DecalEntity decalEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_decalEntity_Internal_get_DecalEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_decalEntity_Internal_set_Void_DecalEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00033E2C File Offset: 0x0003202C
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00033E6C File Offset: 0x0003206C
		public unsafe Material material
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606669, XrefRangeEnd = 606671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00033EB0 File Offset: 0x000320B0
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00033EEC File Offset: 0x000320EC
		public unsafe float drawDistance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318235, RefRangeEnd = 318236, XrefRangeStart = 318235, XrefRangeEnd = 318236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_drawDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606671, XrefRangeEnd = 606672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_drawDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00033F2C File Offset: 0x0003212C
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00033F68 File Offset: 0x00032168
		public unsafe float fadeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_fadeScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606672, XrefRangeEnd = 606674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_fadeScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00033FA8 File Offset: 0x000321A8
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00033FE4 File Offset: 0x000321E4
		public unsafe float startAngleFade
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_startAngleFade_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606674, XrefRangeEnd = 606676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_startAngleFade_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00034024 File Offset: 0x00032224
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00034060 File Offset: 0x00032260
		public unsafe float endAngleFade
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_endAngleFade_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606676, XrefRangeEnd = 606677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_endAngleFade_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x000340A0 File Offset: 0x000322A0
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x000340DC File Offset: 0x000322DC
		public unsafe Vector2 uvScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_uvScale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606677, XrefRangeEnd = 606678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_uvScale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0003411C File Offset: 0x0003231C
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00034158 File Offset: 0x00032358
		public unsafe Vector2 uvBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_uvBias_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606678, XrefRangeEnd = 606679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_uvBias_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00034198 File Offset: 0x00032398
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x000341D4 File Offset: 0x000323D4
		public unsafe uint renderingLayerMask
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_renderingLayerMask_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00034214 File Offset: 0x00032414
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00034250 File Offset: 0x00032450
		public unsafe DecalScaleMode scaleMode
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_scaleMode_Public_get_DecalScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606679, XrefRangeEnd = 606680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_scaleMode_Public_set_Void_DecalScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00034290 File Offset: 0x00032490
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x000342CC File Offset: 0x000324CC
		public unsafe Vector3 pivot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_pivot_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606680, XrefRangeEnd = 606681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0003430C File Offset: 0x0003250C
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00034348 File Offset: 0x00032548
		public unsafe Vector3 size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606681, XrefRangeEnd = 606682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00034388 File Offset: 0x00032588
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x000343C4 File Offset: 0x000325C4
		public unsafe float fadeFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_fadeFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606682, XrefRangeEnd = 606684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_set_fadeFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x00034404 File Offset: 0x00032604
		public unsafe Vector3 effectiveScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606684, XrefRangeEnd = 606686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_effectiveScale_Internal_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00034440 File Offset: 0x00032640
		public unsafe Vector3 decalSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 606686, RefRangeEnd = 606687, XrefRangeStart = 606686, XrefRangeEnd = 606686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_decalSize_Internal_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0003447C File Offset: 0x0003267C
		public unsafe Vector3 decalOffset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 606687, RefRangeEnd = 606688, XrefRangeStart = 606687, XrefRangeEnd = 606687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_decalOffset_Internal_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x000344B8 File Offset: 0x000326B8
		public unsafe Vector4 uvScaleBias
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 606688, RefRangeEnd = 606689, XrefRangeStart = 606688, XrefRangeEnd = 606688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_get_uvScaleBias_Internal_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000344F4 File Offset: 0x000326F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606689, XrefRangeEnd = 606693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_InitMaterial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00034528 File Offset: 0x00032728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606693, XrefRangeEnd = 606700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0003455C File Offset: 0x0003275C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606700, XrefRangeEnd = 606702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00034590 File Offset: 0x00032790
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 606711, RefRangeEnd = 606726, XrefRangeStart = 606702, XrefRangeEnd = 606711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_OnValidate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000345C4 File Offset: 0x000327C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606726, XrefRangeEnd = 606733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000345F8 File Offset: 0x000327F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606733, XrefRangeEnd = 606749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00034634 File Offset: 0x00032834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606751, RefRangeEnd = 606752, XrefRangeStart = 606749, XrefRangeEnd = 606751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateAllDecalProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr_UpdateAllDecalProperties_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0003465C File Offset: 0x0003285C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606752, XrefRangeEnd = 606753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalProjector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00005BF9 File Offset: 0x00003DF9
		public DecalProjector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00034698 File Offset: 0x00032898
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00005C02 File Offset: 0x00003E02
		public unsafe static DecalProjector.DecalProjectorAction onDecalAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalProjector.NativeFieldInfoPtr_onDecalAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector.DecalProjectorAction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalProjector.NativeFieldInfoPtr_onDecalAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x000346C0 File Offset: 0x000328C0
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00005C14 File Offset: 0x00003E14
		public unsafe static DecalProjector.DecalProjectorAction onDecalRemove
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalProjector.NativeFieldInfoPtr_onDecalRemove, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector.DecalProjectorAction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalProjector.NativeFieldInfoPtr_onDecalRemove, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x000346E8 File Offset: 0x000328E8
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00005C26 File Offset: 0x00003E26
		public unsafe static DecalProjector.DecalProjectorAction onDecalPropertyChange
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalProjector.NativeFieldInfoPtr_onDecalPropertyChange, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector.DecalProjectorAction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalProjector.NativeFieldInfoPtr_onDecalPropertyChange, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00034710 File Offset: 0x00032910
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00005C38 File Offset: 0x00003E38
		public unsafe static Action onAllDecalPropertyChange
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalProjector.NativeFieldInfoPtr_onAllDecalPropertyChange, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalProjector.NativeFieldInfoPtr_onAllDecalPropertyChange, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00034738 File Offset: 0x00032938
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00005C4A File Offset: 0x00003E4A
		public unsafe static DecalProjector.DecalProjectorAction onDecalMaterialChange
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalProjector.NativeFieldInfoPtr_onDecalMaterialChange, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector.DecalProjectorAction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalProjector.NativeFieldInfoPtr_onDecalMaterialChange, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00034760 File Offset: 0x00032960
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00005C5C File Offset: 0x00003E5C
		public unsafe static Material _defaultMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalProjector.NativeFieldInfoPtr__defaultMaterial_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalProjector.NativeFieldInfoPtr__defaultMaterial_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00034788 File Offset: 0x00032988
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00005C6E File Offset: 0x00003E6E
		public unsafe DecalEntity _decalEntity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr__decalEntity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr__decalEntity_k__BackingField)) = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x000347B0 File Offset: 0x000329B0
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00005C89 File Offset: 0x00003E89
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x000347E0 File Offset: 0x000329E0
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00005CA8 File Offset: 0x00003EA8
		public unsafe float m_DrawDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_DrawDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_DrawDistance)) = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00034808 File Offset: 0x00032A08
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00005CC3 File Offset: 0x00003EC3
		public unsafe float m_FadeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_FadeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_FadeScale)) = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00034830 File Offset: 0x00032A30
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00005CDE File Offset: 0x00003EDE
		public unsafe float m_StartAngleFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_StartAngleFade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_StartAngleFade)) = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00034858 File Offset: 0x00032A58
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00005CF9 File Offset: 0x00003EF9
		public unsafe float m_EndAngleFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_EndAngleFade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_EndAngleFade)) = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00034880 File Offset: 0x00032A80
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00005D14 File Offset: 0x00003F14
		public unsafe Vector2 m_UVScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_UVScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_UVScale)) = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x000348A8 File Offset: 0x00032AA8
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00005D2F File Offset: 0x00003F2F
		public unsafe Vector2 m_UVBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_UVBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_UVBias)) = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x000348D0 File Offset: 0x00032AD0
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00005D4A File Offset: 0x00003F4A
		public unsafe uint m_DecalLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_DecalLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_DecalLayerMask)) = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x000348F8 File Offset: 0x00032AF8
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00005D65 File Offset: 0x00003F65
		public unsafe DecalScaleMode m_ScaleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_ScaleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_ScaleMode)) = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00034920 File Offset: 0x00032B20
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00005D80 File Offset: 0x00003F80
		public unsafe Vector3 m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00034948 File Offset: 0x00032B48
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00005D9B File Offset: 0x00003F9B
		public unsafe Vector3 m_Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_Size)) = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00034970 File Offset: 0x00032B70
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00005DB6 File Offset: 0x00003FB6
		public unsafe float m_FadeFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_FadeFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_FadeFactor)) = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00034998 File Offset: 0x00032B98
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00005DD1 File Offset: 0x00003FD1
		public unsafe Material m_OldMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x000349C8 File Offset: 0x00032BC8
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x00005DF0 File Offset: 0x00003FF0
		public unsafe float m_OldDrawDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldDrawDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldDrawDistance)) = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x000349F0 File Offset: 0x00032BF0
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x00005E0B File Offset: 0x0000400B
		public unsafe float m_OldFadeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldFadeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldFadeScale)) = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x00034A18 File Offset: 0x00032C18
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x00005E26 File Offset: 0x00004026
		public unsafe float m_OldStartAngleFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldStartAngleFade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldStartAngleFade)) = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00034A40 File Offset: 0x00032C40
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x00005E41 File Offset: 0x00004041
		public unsafe float m_OldEndAngleFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldEndAngleFade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldEndAngleFade)) = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00034A68 File Offset: 0x00032C68
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x00005E5C File Offset: 0x0000405C
		public unsafe Vector2 m_OldUVScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldUVScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldUVScale)) = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x00034A90 File Offset: 0x00032C90
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x00005E77 File Offset: 0x00004077
		public unsafe Vector2 m_OldUVBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldUVBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldUVBias)) = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x00034AB8 File Offset: 0x00032CB8
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00005E92 File Offset: 0x00004092
		public unsafe DecalScaleMode m_OldScaleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldScaleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldScaleMode)) = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00034AE0 File Offset: 0x00032CE0
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00005EAD File Offset: 0x000040AD
		public unsafe Vector3 m_OldOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldOffset)) = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x00034B08 File Offset: 0x00032D08
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00005EC8 File Offset: 0x000040C8
		public unsafe Vector3 m_OldSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldSize)) = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00034B30 File Offset: 0x00032D30
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00005EE3 File Offset: 0x000040E3
		public unsafe float m_OldFadeFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldFadeFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalProjector.NativeFieldInfoPtr_m_OldFadeFactor)) = value;
			}
		}

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeFieldInfoPtr_onDecalAdd;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr_onDecalRemove;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeFieldInfoPtr_onDecalPropertyChange;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_onAllDecalPropertyChange;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr_onDecalMaterialChange;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeFieldInfoPtr__defaultMaterial_k__BackingField;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeFieldInfoPtr__decalEntity_k__BackingField;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawDistance;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr_m_FadeScale;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr_m_StartAngleFade;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeFieldInfoPtr_m_EndAngleFade;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeFieldInfoPtr_m_UVScale;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeFieldInfoPtr_m_UVBias;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalLayerMask;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaleMode;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_m_Size;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_m_FadeFactor;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_m_OldMaterial;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_m_OldDrawDistance;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_m_OldFadeScale;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_m_OldStartAngleFade;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr_m_OldEndAngleFade;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeFieldInfoPtr_m_OldUVScale;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeFieldInfoPtr_m_OldUVBias;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeFieldInfoPtr_m_OldScaleMode;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeFieldInfoPtr_m_OldOffset;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeFieldInfoPtr_m_OldSize;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeFieldInfoPtr_m_OldFadeFactor;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_add_onDecalAdd_Internal_Static_add_Void_DecalProjectorAction_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_remove_onDecalAdd_Internal_Static_rem_Void_DecalProjectorAction_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_add_onDecalRemove_Internal_Static_add_Void_DecalProjectorAction_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_remove_onDecalRemove_Internal_Static_rem_Void_DecalProjectorAction_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_add_onDecalPropertyChange_Internal_Static_add_Void_DecalProjectorAction_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_remove_onDecalPropertyChange_Internal_Static_rem_Void_DecalProjectorAction_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_add_onAllDecalPropertyChange_Internal_Static_add_Void_Action_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_remove_onAllDecalPropertyChange_Internal_Static_rem_Void_Action_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_add_onDecalMaterialChange_Internal_Static_add_Void_DecalProjectorAction_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_remove_onDecalMaterialChange_Internal_Static_rem_Void_DecalProjectorAction_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMaterial_Internal_Static_get_Material_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultMaterial_Internal_Static_set_Void_Material_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Internal_Static_get_Boolean_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_get_decalEntity_Internal_get_DecalEntity_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_set_decalEntity_Internal_set_Void_DecalEntity_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_set_Void_Material_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_get_drawDistance_Public_get_Single_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_set_drawDistance_Public_set_Void_Single_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeScale_Public_get_Single_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeScale_Public_set_Void_Single_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_get_startAngleFade_Public_get_Single_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_set_startAngleFade_Public_set_Void_Single_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_get_endAngleFade_Public_get_Single_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_set_endAngleFade_Public_set_Void_Single_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_get_uvScale_Public_get_Vector2_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_set_uvScale_Public_set_Void_Vector2_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_get_uvBias_Public_get_Vector2_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_set_uvBias_Public_set_Void_Vector2_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayerMask_Public_get_UInt32_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleMode_Public_get_DecalScaleMode_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleMode_Public_set_Void_DecalScaleMode_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector3_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector3_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeFactor_Public_get_Single_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeFactor_Public_set_Void_Single_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_get_effectiveScale_Internal_get_Vector3_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_get_decalSize_Internal_get_Vector3_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_get_decalOffset_Internal_get_Vector3_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_get_uvScaleBias_Internal_get_Vector4_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_InitMaterial_Private_Void_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Internal_Void_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAllDecalProperties_Internal_Static_Void_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200017D RID: 381
		public sealed class DecalProjectorAction : MulticastDelegate
		{
			// Token: 0x06001C9C RID: 7324 RVA: 0x000757F4 File Offset: 0x000739F4
			// Note: this type is marked as 'beforefieldinit'.
			static DecalProjectorAction()
			{
				Il2CppClassPointerStore<DecalProjector.DecalProjectorAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalProjector>.NativeClassPtr, "DecalProjectorAction");
				DecalProjector.DecalProjectorAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector.DecalProjectorAction>.NativeClassPtr, 100664535);
				DecalProjector.DecalProjectorAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector.DecalProjectorAction>.NativeClassPtr, 100664536);
				DecalProjector.DecalProjectorAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DecalProjector_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector.DecalProjectorAction>.NativeClassPtr, 100664537);
				DecalProjector.DecalProjectorAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalProjector.DecalProjectorAction>.NativeClassPtr, 100664538);
			}

			// Token: 0x06001C9D RID: 7325 RVA: 0x00075868 File Offset: 0x00073A68
			[CallerCount(431)]
			[CachedScanResults(RefRangeStart = 436687, RefRangeEnd = 437118, XrefRangeStart = 436687, XrefRangeEnd = 437118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecalProjectorAction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalProjector.DecalProjectorAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.DecalProjectorAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C9E RID: 7326 RVA: 0x000758C4 File Offset: 0x00073AC4
			[CallerCount(0)]
			public unsafe void Invoke(DecalProjector decalProjector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalProjector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.DecalProjectorAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DecalProjector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C9F RID: 7327 RVA: 0x00075908 File Offset: 0x00073B08
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(DecalProjector decalProjector, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalProjector);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.DecalProjectorAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DecalProjector_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001CA0 RID: 7328 RVA: 0x0007597C File Offset: 0x00073B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalProjector.DecalProjectorAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CA1 RID: 7329 RVA: 0x000103D8 File Offset: 0x0000E5D8
			public DecalProjectorAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CA2 RID: 7330 RVA: 0x000103E1 File Offset: 0x0000E5E1
			public static implicit operator DecalProjector.DecalProjectorAction(Action<DecalProjector> A_0)
			{
				return DelegateSupport.ConvertDelegate<DecalProjector.DecalProjectorAction>(A_0);
			}

			// Token: 0x06001CA3 RID: 7331 RVA: 0x000103E9 File Offset: 0x0000E5E9
			public static DecalProjector.DecalProjectorAction operator +(DecalProjector.DecalProjectorAction A_0, DecalProjector.DecalProjectorAction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DecalProjector.DecalProjectorAction>();
			}

			// Token: 0x06001CA4 RID: 7332 RVA: 0x000103F7 File Offset: 0x0000E5F7
			public static DecalProjector.DecalProjectorAction operator -(DecalProjector.DecalProjectorAction A_0, DecalProjector.DecalProjectorAction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DecalProjector.DecalProjectorAction>();
				}
				return delegate2;
			}

			// Token: 0x040014CC RID: 5324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040014CD RID: 5325
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DecalProjector_0;

			// Token: 0x040014CE RID: 5326
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DecalProjector_AsyncCallback_Object_0;

			// Token: 0x040014CF RID: 5327
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
