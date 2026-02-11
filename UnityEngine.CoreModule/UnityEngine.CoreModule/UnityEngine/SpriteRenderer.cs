using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace UnityEngine
{
	// Token: 0x0200017B RID: 379
	public sealed class SpriteRenderer : Renderer
	{
		// Token: 0x06001CA2 RID: 7330 RVA: 0x00083874 File Offset: 0x00081A74
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteRenderer()
		{
			Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpriteRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr);
			SpriteRenderer.NativeFieldInfoPtr_m_SpriteChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, "m_SpriteChangeEvent");
			SpriteRenderer.NativeMethodInfoPtr_RegisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667287);
			SpriteRenderer.NativeMethodInfoPtr_UnregisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667288);
			SpriteRenderer.NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667289);
			SpriteRenderer.NativeMethodInfoPtr_get_shouldSupportTiling_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667290);
			SpriteRenderer.NativeMethodInfoPtr_get_hasSpriteChangeEvents_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667291);
			SpriteRenderer.NativeMethodInfoPtr_set_hasSpriteChangeEvents_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667292);
			SpriteRenderer.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667293);
			SpriteRenderer.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667294);
			SpriteRenderer.NativeMethodInfoPtr_get_drawMode_Public_get_SpriteDrawMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667295);
			SpriteRenderer.NativeMethodInfoPtr_set_drawMode_Public_set_Void_SpriteDrawMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667296);
			SpriteRenderer.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667297);
			SpriteRenderer.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667298);
			SpriteRenderer.NativeMethodInfoPtr_get_adaptiveModeThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667299);
			SpriteRenderer.NativeMethodInfoPtr_set_adaptiveModeThreshold_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667300);
			SpriteRenderer.NativeMethodInfoPtr_get_tileMode_Public_get_SpriteTileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667301);
			SpriteRenderer.NativeMethodInfoPtr_set_tileMode_Public_set_Void_SpriteTileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667302);
			SpriteRenderer.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667303);
			SpriteRenderer.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667304);
			SpriteRenderer.NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667305);
			SpriteRenderer.NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667306);
			SpriteRenderer.NativeMethodInfoPtr_get_flipX_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667307);
			SpriteRenderer.NativeMethodInfoPtr_set_flipX_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667308);
			SpriteRenderer.NativeMethodInfoPtr_get_flipY_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667309);
			SpriteRenderer.NativeMethodInfoPtr_set_flipY_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667310);
			SpriteRenderer.NativeMethodInfoPtr_get_spriteSortPoint_Public_get_SpriteSortPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667311);
			SpriteRenderer.NativeMethodInfoPtr_set_spriteSortPoint_Public_set_Void_SpriteSortPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667312);
			SpriteRenderer.NativeMethodInfoPtr_GetCurrentMeshDataPtr_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667313);
			SpriteRenderer.NativeMethodInfoPtr_GetCurrentMeshData_Internal_MeshDataArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667314);
			SpriteRenderer.NativeMethodInfoPtr_Internal_GetSpriteBounds_Internal_Bounds_SpriteDrawMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667315);
			SpriteRenderer.NativeMethodInfoPtr_GetSecondaryTextureProperties_Internal_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667316);
			SpriteRenderer.NativeMethodInfoPtr_GetSpriteBounds_Internal_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667317);
			SpriteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667318);
			SpriteRenderer.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667319);
			SpriteRenderer.NativeMethodInfoPtr_set_size_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667320);
			SpriteRenderer.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667321);
			SpriteRenderer.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667322);
			SpriteRenderer.NativeMethodInfoPtr_Internal_GetSpriteBounds_Injected_Private_Void_SpriteDrawMode_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100667323);
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00083B9C File Offset: 0x00081D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676985, XrefRangeEnd = 676998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSpriteChangeCallback(UnityEngine.Events.UnityAction<SpriteRenderer> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_RegisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00083BE0 File Offset: 0x00081DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 676998, XrefRangeEnd = 677004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterSpriteChangeCallback(UnityEngine.Events.UnityAction<SpriteRenderer> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_UnregisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00083C24 File Offset: 0x00081E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677004, XrefRangeEnd = 677011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeSpriteChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00083C58 File Offset: 0x00081E58
		public unsafe bool shouldSupportTiling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677011, XrefRangeEnd = 677013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_shouldSupportTiling_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x00083C94 File Offset: 0x00081E94
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x00083CD0 File Offset: 0x00081ED0
		public unsafe bool hasSpriteChangeEvents
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677013, XrefRangeEnd = 677015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_hasSpriteChangeEvents_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677015, XrefRangeEnd = 677017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_hasSpriteChangeEvents_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00083D10 File Offset: 0x00081F10
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x00083D50 File Offset: 0x00081F50
		public unsafe Sprite sprite
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 677019, RefRangeEnd = 677027, XrefRangeStart = 677017, XrefRangeEnd = 677019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 677029, RefRangeEnd = 677040, XrefRangeStart = 677027, XrefRangeEnd = 677029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x00083D94 File Offset: 0x00081F94
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x00083DD0 File Offset: 0x00081FD0
		public unsafe SpriteDrawMode drawMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677040, XrefRangeEnd = 677042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_drawMode_Public_get_SpriteDrawMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677042, XrefRangeEnd = 677044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_drawMode_Public_set_Void_SpriteDrawMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x00083E10 File Offset: 0x00082010
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x00083E4C File Offset: 0x0008204C
		public unsafe Vector2 size
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677044, XrefRangeEnd = 677046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677046, XrefRangeEnd = 677048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x00083E8C File Offset: 0x0008208C
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x00083EC8 File Offset: 0x000820C8
		public unsafe float adaptiveModeThreshold
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677048, XrefRangeEnd = 677050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_adaptiveModeThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677050, XrefRangeEnd = 677052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_adaptiveModeThreshold_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x00083F08 File Offset: 0x00082108
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x00083F44 File Offset: 0x00082144
		public unsafe SpriteTileMode tileMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677052, XrefRangeEnd = 677054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_tileMode_Public_get_SpriteTileMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677054, XrefRangeEnd = 677056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_tileMode_Public_set_Void_SpriteTileMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x00083F84 File Offset: 0x00082184
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x00083FC0 File Offset: 0x000821C0
		public unsafe Color color
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 677058, RefRangeEnd = 677060, XrefRangeStart = 677056, XrefRangeEnd = 677058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 677062, RefRangeEnd = 677066, XrefRangeStart = 677060, XrefRangeEnd = 677062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x00084000 File Offset: 0x00082200
		// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x0008403C File Offset: 0x0008223C
		public unsafe SpriteMaskInteraction maskInteraction
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677066, XrefRangeEnd = 677068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677068, XrefRangeEnd = 677070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x0008407C File Offset: 0x0008227C
		// (set) Token: 0x06001CB8 RID: 7352 RVA: 0x000840B8 File Offset: 0x000822B8
		public unsafe bool flipX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677070, XrefRangeEnd = 677072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_flipX_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677072, XrefRangeEnd = 677074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_flipX_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x000840F8 File Offset: 0x000822F8
		// (set) Token: 0x06001CBA RID: 7354 RVA: 0x00084134 File Offset: 0x00082334
		public unsafe bool flipY
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677074, XrefRangeEnd = 677076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_flipY_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677076, XrefRangeEnd = 677078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_flipY_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00084174 File Offset: 0x00082374
		// (set) Token: 0x06001CBC RID: 7356 RVA: 0x000841B0 File Offset: 0x000823B0
		public unsafe SpriteSortPoint spriteSortPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677078, XrefRangeEnd = 677080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_spriteSortPoint_Public_get_SpriteSortPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677080, XrefRangeEnd = 677082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_spriteSortPoint_Public_set_Void_SpriteSortPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x000841F0 File Offset: 0x000823F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677082, XrefRangeEnd = 677084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetCurrentMeshDataPtr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_GetCurrentMeshDataPtr_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0008422C File Offset: 0x0008242C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677084, XrefRangeEnd = 677088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh.MeshDataArray GetCurrentMeshData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_GetCurrentMeshData_Internal_MeshDataArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00084268 File Offset: 0x00082468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677088, XrefRangeEnd = 677090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds Internal_GetSpriteBounds(SpriteDrawMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_Internal_GetSpriteBounds_Internal_Bounds_SpriteDrawMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x000842B4 File Offset: 0x000824B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677090, XrefRangeEnd = 677092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSecondaryTextureProperties(MaterialPropertyBlock mbp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mbp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_GetSecondaryTextureProperties_Internal_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x000842F8 File Offset: 0x000824F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677092, XrefRangeEnd = 677096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetSpriteBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_GetSpriteBounds_Internal_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00084334 File Offset: 0x00082534
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00084370 File Offset: 0x00082570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677096, XrefRangeEnd = 677098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_size_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x000843B0 File Offset: 0x000825B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677098, XrefRangeEnd = 677100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_size_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_size_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x000843F0 File Offset: 0x000825F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677100, XrefRangeEnd = 677102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_color_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00084430 File Offset: 0x00082630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677102, XrefRangeEnd = 677104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_color_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00084470 File Offset: 0x00082670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677104, XrefRangeEnd = 677106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_GetSpriteBounds_Injected(SpriteDrawMode mode, out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_Internal_GetSpriteBounds_Injected_Private_Void_SpriteDrawMode_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0000AC7F File Offset: 0x00008E7F
		public SpriteRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x000844BC File Offset: 0x000826BC
		// (set) Token: 0x06001CCA RID: 7370 RVA: 0x0000AC88 File Offset: 0x00008E88
		public unsafe UnityEngine.Events.UnityEvent<SpriteRenderer> m_SpriteChangeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRenderer.NativeFieldInfoPtr_m_SpriteChangeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityEvent<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRenderer.NativeFieldInfoPtr_m_SpriteChangeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteChangeEvent;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldSupportTiling_Internal_get_Boolean_0;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSpriteChangeEvents_Internal_get_Boolean_0;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeMethodInfoPtr_set_hasSpriteChangeEvents_Internal_set_Void_Boolean_0;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_get_drawMode_Public_get_SpriteDrawMode_0;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_set_drawMode_Public_set_Void_SpriteDrawMode_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_get_adaptiveModeThreshold_Public_get_Single_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_set_adaptiveModeThreshold_Public_set_Void_Single_0;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr_get_tileMode_Public_get_SpriteTileMode_0;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeMethodInfoPtr_set_tileMode_Public_set_Void_SpriteTileMode_0;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeMethodInfoPtr_get_flipX_Public_get_Boolean_0;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeMethodInfoPtr_set_flipX_Public_set_Void_Boolean_0;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr_get_flipY_Public_get_Boolean_0;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_set_flipY_Public_set_Void_Boolean_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteSortPoint_Public_get_SpriteSortPoint_0;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteSortPoint_Public_set_Void_SpriteSortPoint_0;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentMeshDataPtr_Private_IntPtr_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentMeshData_Internal_MeshDataArray_0;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetSpriteBounds_Internal_Bounds_SpriteDrawMode_0;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTextureProperties_Internal_Void_MaterialPropertyBlock_0;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteBounds_Internal_Bounds_0;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetSpriteBounds_Injected_Private_Void_SpriteDrawMode_byref_Bounds_0;
	}
}
