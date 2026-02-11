using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000D0 RID: 208
	public class ScriptableRendererData : ScriptableObject
	{
		// Token: 0x0600103C RID: 4156 RVA: 0x0004D68C File Offset: 0x0004B88C
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRendererData()
		{
			Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScriptableRendererData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr);
			ScriptableRendererData.NativeFieldInfoPtr__isInvalidated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, "<isInvalidated>k__BackingField");
			ScriptableRendererData.NativeFieldInfoPtr_debugShaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, "debugShaders");
			ScriptableRendererData.NativeFieldInfoPtr_m_RendererFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, "m_RendererFeatures");
			ScriptableRendererData.NativeFieldInfoPtr_m_RendererFeatureMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, "m_RendererFeatureMap");
			ScriptableRendererData.NativeFieldInfoPtr_m_UseNativeRenderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, "m_UseNativeRenderPass");
			ScriptableRendererData.NativeMethodInfoPtr_get_isInvalidated_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665350);
			ScriptableRendererData.NativeMethodInfoPtr_set_isInvalidated_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665351);
			ScriptableRendererData.NativeMethodInfoPtr_Create_Protected_Abstract_Virtual_New_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665352);
			ScriptableRendererData.NativeMethodInfoPtr_get_rendererFeatures_Public_get_List_1_ScriptableRendererFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665353);
			ScriptableRendererData.NativeMethodInfoPtr_SetDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665354);
			ScriptableRendererData.NativeMethodInfoPtr_InternalCreateRenderer_Internal_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665355);
			ScriptableRendererData.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665356);
			ScriptableRendererData.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665357);
			ScriptableRendererData.NativeMethodInfoPtr_get_useNativeRenderPass_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665358);
			ScriptableRendererData.NativeMethodInfoPtr_set_useNativeRenderPass_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665359);
			ScriptableRendererData.NativeMethodInfoPtr_TryGetRendererFeature_Internal_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665360);
			ScriptableRendererData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, 100665361);
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0004D810 File Offset: 0x0004BA10
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x0004D84C File Offset: 0x0004BA4C
		public unsafe bool isInvalidated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRendererData.NativeMethodInfoPtr_get_isInvalidated_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRendererData.NativeMethodInfoPtr_set_isInvalidated_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0004D88C File Offset: 0x0004BA8C
		[CallerCount(0)]
		public unsafe virtual ScriptableRenderer Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRendererData.NativeMethodInfoPtr_Create_Protected_Abstract_Virtual_New_ScriptableRenderer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr3) : null;
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0004D8D8 File Offset: 0x0004BAD8
		public unsafe List<ScriptableRendererFeature> rendererFeatures
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRendererData.NativeMethodInfoPtr_get_rendererFeatures_Public_get_List_1_ScriptableRendererFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ScriptableRendererFeature>>(intPtr3) : null;
			}
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0004D918 File Offset: 0x0004BB18
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 525020, RefRangeEnd = 525108, XrefRangeStart = 525020, XrefRangeEnd = 525108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRendererData.NativeMethodInfoPtr_SetDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0004D94C File Offset: 0x0004BB4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 616980, RefRangeEnd = 616982, XrefRangeStart = 616980, XrefRangeEnd = 616980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableRenderer InternalCreateRenderer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRendererData.NativeMethodInfoPtr_InternalCreateRenderer_Internal_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr3) : null;
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0004D98C File Offset: 0x0004BB8C
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 525020, RefRangeEnd = 525108, XrefRangeStart = 525020, XrefRangeEnd = 525108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRendererData.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0004D9C8 File Offset: 0x0004BBC8
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 525020, RefRangeEnd = 525108, XrefRangeStart = 525020, XrefRangeEnd = 525108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableRendererData.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x0004DA04 File Offset: 0x0004BC04
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x0004DA40 File Offset: 0x0004BC40
		public unsafe bool useNativeRenderPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRendererData.NativeMethodInfoPtr_get_useNativeRenderPass_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRendererData.NativeMethodInfoPtr_set_useNativeRenderPass_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0004DA80 File Offset: 0x0004BC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616982, XrefRangeEnd = 617009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetRendererFeature<T>(out T rendererFeature) where T : ScriptableRendererFeature
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref rendererFeature;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ScriptableRendererData.MethodInfoStoreGeneric_TryGetRendererFeature_Internal_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					rendererFeature = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0004DB0C File Offset: 0x0004BD0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 617024, RefRangeEnd = 617027, XrefRangeStart = 617009, XrefRangeEnd = 617024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableRendererData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRendererData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00009D42 File Offset: 0x00007F42
		public ScriptableRendererData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0004DB48 File Offset: 0x0004BD48
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x00009D4B File Offset: 0x00007F4B
		public unsafe bool _isInvalidated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.NativeFieldInfoPtr__isInvalidated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.NativeFieldInfoPtr__isInvalidated_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0004DB70 File Offset: 0x0004BD70
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x00009D66 File Offset: 0x00007F66
		public unsafe ScriptableRendererData.DebugShaderResources debugShaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.NativeFieldInfoPtr_debugShaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRendererData.DebugShaderResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.NativeFieldInfoPtr_debugShaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0004DBA0 File Offset: 0x0004BDA0
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x00009D85 File Offset: 0x00007F85
		public unsafe List<ScriptableRendererFeature> m_RendererFeatures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.NativeFieldInfoPtr_m_RendererFeatures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScriptableRendererFeature>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.NativeFieldInfoPtr_m_RendererFeatures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0004DBD0 File Offset: 0x0004BDD0
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x00009DA4 File Offset: 0x00007FA4
		public unsafe List<long> m_RendererFeatureMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.NativeFieldInfoPtr_m_RendererFeatureMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.NativeFieldInfoPtr_m_RendererFeatureMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0004DC00 File Offset: 0x0004BE00
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x00009DC3 File Offset: 0x00007FC3
		public unsafe bool m_UseNativeRenderPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.NativeFieldInfoPtr_m_UseNativeRenderPass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.NativeFieldInfoPtr_m_UseNativeRenderPass)) = value;
			}
		}

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr__isInvalidated_k__BackingField;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeFieldInfoPtr_debugShaders;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeFieldInfoPtr_m_RendererFeatures;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeFieldInfoPtr_m_RendererFeatureMap;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeFieldInfoPtr_m_UseNativeRenderPass;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_get_isInvalidated_Internal_get_Boolean_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_set_isInvalidated_Internal_set_Void_Boolean_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_Create_Protected_Abstract_Virtual_New_ScriptableRenderer_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_get_rendererFeatures_Public_get_List_1_ScriptableRendererFeature_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Public_Void_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateRenderer_Internal_ScriptableRenderer_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_get_useNativeRenderPass_Public_get_Boolean_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_set_useNativeRenderPass_Public_set_Void_Boolean_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_TryGetRendererFeature_Internal_Boolean_byref_T_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020001BC RID: 444
		[Serializable]
		public sealed class DebugShaderResources : Object
		{
			// Token: 0x06002002 RID: 8194 RVA: 0x0007D800 File Offset: 0x0007BA00
			// Note: this type is marked as 'beforefieldinit'.
			static DebugShaderResources()
			{
				Il2CppClassPointerStore<ScriptableRendererData.DebugShaderResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr, "DebugShaderResources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRendererData.DebugShaderResources>.NativeClassPtr);
				ScriptableRendererData.DebugShaderResources.NativeFieldInfoPtr_debugReplacementPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRendererData.DebugShaderResources>.NativeClassPtr, "debugReplacementPS");
				ScriptableRendererData.DebugShaderResources.NativeFieldInfoPtr_hdrDebugViewPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRendererData.DebugShaderResources>.NativeClassPtr, "hdrDebugViewPS");
				ScriptableRendererData.DebugShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRendererData.DebugShaderResources>.NativeClassPtr, 100665362);
			}

			// Token: 0x06002003 RID: 8195 RVA: 0x0007D868 File Offset: 0x0007BA68
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebugShaderResources()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRendererData.DebugShaderResources>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRendererData.DebugShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002004 RID: 8196 RVA: 0x00012562 File Offset: 0x00010762
			public DebugShaderResources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x06002005 RID: 8197 RVA: 0x0007D8A4 File Offset: 0x0007BAA4
			// (set) Token: 0x06002006 RID: 8198 RVA: 0x0001256B File Offset: 0x0001076B
			public unsafe Shader debugReplacementPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.DebugShaderResources.NativeFieldInfoPtr_debugReplacementPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.DebugShaderResources.NativeFieldInfoPtr_debugReplacementPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B89 RID: 2953
			// (get) Token: 0x06002007 RID: 8199 RVA: 0x0007D8D4 File Offset: 0x0007BAD4
			// (set) Token: 0x06002008 RID: 8200 RVA: 0x0001258A File Offset: 0x0001078A
			public unsafe Shader hdrDebugViewPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.DebugShaderResources.NativeFieldInfoPtr_hdrDebugViewPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRendererData.DebugShaderResources.NativeFieldInfoPtr_hdrDebugViewPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016C1 RID: 5825
			private static readonly IntPtr NativeFieldInfoPtr_debugReplacementPS;

			// Token: 0x040016C2 RID: 5826
			private static readonly IntPtr NativeFieldInfoPtr_hdrDebugViewPS;

			// Token: 0x040016C3 RID: 5827
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001BD RID: 445
		private sealed class MethodInfoStoreGeneric_TryGetRendererFeature_Internal_Boolean_byref_T_0<T>
		{
			// Token: 0x040016C4 RID: 5828
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ScriptableRendererData.NativeMethodInfoPtr_TryGetRendererFeature_Internal_Boolean_byref_T_0, Il2CppClassPointerStore<ScriptableRendererData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
