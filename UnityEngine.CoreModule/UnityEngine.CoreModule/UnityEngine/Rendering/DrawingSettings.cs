using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000232 RID: 562
	[StructLayout(2)]
	public struct DrawingSettings
	{
		// Token: 0x060025C3 RID: 9667 RVA: 0x000A0C80 File Offset: 0x0009EE80
		// Note: this type is marked as 'beforefieldinit'.
		static DrawingSettings()
		{
			Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "DrawingSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr);
			DrawingSettings.NativeFieldInfoPtr_maxShaderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "maxShaderPasses");
			DrawingSettings.NativeFieldInfoPtr_m_SortingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_SortingSettings");
			DrawingSettings.NativeFieldInfoPtr_shaderPassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "shaderPassNames");
			DrawingSettings.NativeFieldInfoPtr_m_PerObjectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_PerObjectData");
			DrawingSettings.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_Flags");
			DrawingSettings.NativeFieldInfoPtr_m_OverrideShaderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideShaderID");
			DrawingSettings.NativeFieldInfoPtr_m_OverrideShaderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideShaderPassIndex");
			DrawingSettings.NativeFieldInfoPtr_m_OverrideMaterialInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideMaterialInstanceId");
			DrawingSettings.NativeFieldInfoPtr_m_OverrideMaterialPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideMaterialPassIndex");
			DrawingSettings.NativeFieldInfoPtr_m_fallbackMaterialInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_fallbackMaterialInstanceId");
			DrawingSettings.NativeFieldInfoPtr_m_MainLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_MainLightIndex");
			DrawingSettings.NativeFieldInfoPtr_m_UseSrpBatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_UseSrpBatcher");
			DrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668150);
			DrawingSettings.NativeMethodInfoPtr_get_sortingSettings_Public_get_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668151);
			DrawingSettings.NativeMethodInfoPtr_set_sortingSettings_Public_set_Void_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668152);
			DrawingSettings.NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668153);
			DrawingSettings.NativeMethodInfoPtr_set_enableDynamicBatching_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668154);
			DrawingSettings.NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668155);
			DrawingSettings.NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668156);
			DrawingSettings.NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668157);
			DrawingSettings.NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668158);
			DrawingSettings.NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668159);
			DrawingSettings.NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668160);
			DrawingSettings.NativeMethodInfoPtr_set_mainLightIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668161);
			DrawingSettings.NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668162);
			DrawingSettings.NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668163);
			DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668164);
			DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668165);
			DrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668166);
			DrawingSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668167);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000A0F08 File Offset: 0x0009F108
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 683654, RefRangeEnd = 683658, XrefRangeStart = 683649, XrefRangeEnd = 683654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawingSettings(ShaderTagId shaderPassName, SortingSettings sortingSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shaderPassName;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortingSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x000A0F48 File Offset: 0x0009F148
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x000A0F78 File Offset: 0x0009F178
		public unsafe SortingSettings sortingSettings
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 683658, RefRangeEnd = 683660, XrefRangeStart = 683658, XrefRangeEnd = 683658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_get_sortingSettings_Public_get_SortingSettings_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 683660, RefRangeEnd = 683663, XrefRangeStart = 683660, XrefRangeEnd = 683660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_sortingSettings_Public_set_Void_SortingSettings_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x000A1328 File Offset: 0x0009F528
		// (set) Token: 0x060025C7 RID: 9671 RVA: 0x000A0FAC File Offset: 0x0009F1AC
		public unsafe PerObjectData perObjectData
		{
			get
			{
				return this.m_PerObjectData;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 315964, RefRangeEnd = 315969, XrefRangeStart = 315964, XrefRangeEnd = 315969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000A1340 File Offset: 0x0009F540
		// (set) Token: 0x060025C8 RID: 9672 RVA: 0x000A0FE0 File Offset: 0x0009F1E0
		public unsafe bool enableDynamicBatching
		{
			get
			{
				return (this.m_Flags & DrawRendererFlags.EnableDynamicBatching) > DrawRendererFlags.None;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 683663, RefRangeEnd = 683665, XrefRangeStart = 683663, XrefRangeEnd = 683663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_enableDynamicBatching_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x000A1360 File Offset: 0x0009F560
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x000A1014 File Offset: 0x0009F214
		public unsafe bool enableInstancing
		{
			get
			{
				return (this.m_Flags & DrawRendererFlags.EnableInstancing) > DrawRendererFlags.None;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 683665, RefRangeEnd = 683667, XrefRangeStart = 683665, XrefRangeEnd = 683665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x000A1380 File Offset: 0x0009F580
		// (set) Token: 0x060025CA RID: 9674 RVA: 0x000A1048 File Offset: 0x0009F248
		public unsafe Material overrideMaterial
		{
			get
			{
				return (this.m_OverrideMaterialInstanceId != 0) ? Object.FindObjectFromInstanceID(this.m_OverrideMaterialInstanceId).TryCast<Material>() : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 683668, RefRangeEnd = 683671, XrefRangeStart = 683667, XrefRangeEnd = 683668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x000A13B0 File Offset: 0x0009F5B0
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x000A1080 File Offset: 0x0009F280
		public unsafe Shader overrideShader
		{
			get
			{
				return (this.m_OverrideShaderID != 0) ? Object.FindObjectFromInstanceID(this.m_OverrideShaderID).TryCast<Shader>() : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683672, RefRangeEnd = 683673, XrefRangeStart = 683671, XrefRangeEnd = 683672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x000A13E0 File Offset: 0x0009F5E0
		// (set) Token: 0x060025CC RID: 9676 RVA: 0x000A10B8 File Offset: 0x0009F2B8
		public unsafe int overrideMaterialPassIndex
		{
			get
			{
				return this.m_OverrideMaterialPassIndex;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 315969, RefRangeEnd = 315972, XrefRangeStart = 315969, XrefRangeEnd = 315972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x000A13F8 File Offset: 0x0009F5F8
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x000A10EC File Offset: 0x0009F2EC
		public unsafe int overrideShaderPassIndex
		{
			get
			{
				return this.m_OverrideShaderPassIndex;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 314559, RefRangeEnd = 314560, XrefRangeStart = 314559, XrefRangeEnd = 314560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000A1410 File Offset: 0x0009F610
		// (set) Token: 0x060025CE RID: 9678 RVA: 0x000A1120 File Offset: 0x0009F320
		public unsafe Material fallbackMaterial
		{
			get
			{
				return (this.m_fallbackMaterialInstanceId != 0) ? Object.FindObjectFromInstanceID(this.m_fallbackMaterialInstanceId).TryCast<Material>() : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683674, RefRangeEnd = 683675, XrefRangeStart = 683673, XrefRangeEnd = 683674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x000A1440 File Offset: 0x0009F640
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x000A1158 File Offset: 0x0009F358
		public unsafe int mainLightIndex
		{
			get
			{
				return this.m_MainLightIndex;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683675, RefRangeEnd = 683676, XrefRangeStart = 683675, XrefRangeEnd = 683675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_mainLightIndex_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x000A118C File Offset: 0x0009F38C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683680, RefRangeEnd = 683682, XrefRangeStart = 683676, XrefRangeEnd = 683680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderTagId GetShaderPassName(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x000A11CC File Offset: 0x0009F3CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 683686, RefRangeEnd = 683692, XrefRangeStart = 683682, XrefRangeEnd = 683686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderPassName(int index, ShaderTagId shaderPassName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPassName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x000A120C File Offset: 0x0009F40C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 683702, RefRangeEnd = 683705, XrefRangeStart = 683692, XrefRangeEnd = 683702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DrawingSettings other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x000A124C File Offset: 0x0009F44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683705, XrefRangeEnd = 683711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x000A1290 File Offset: 0x0009F490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683711, XrefRangeEnd = 683712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x000A12C0 File Offset: 0x0009F4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683712, XrefRangeEnd = 683716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(DrawingSettings left, DrawingSettings right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x0000EDB5 File Offset: 0x0000CFB5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x000A130C File Offset: 0x0009F50C
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x0000EDC7 File Offset: 0x0000CFC7
		public unsafe static int maxShaderPasses
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DrawingSettings.NativeFieldInfoPtr_maxShaderPasses, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DrawingSettings.NativeFieldInfoPtr_maxShaderPasses, (void*)(&value));
			}
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000A1458 File Offset: 0x0009F658
		public static bool operator !=(DrawingSettings left, DrawingSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeFieldInfoPtr_maxShaderPasses;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingSettings;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeFieldInfoPtr_shaderPassNames;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeFieldInfoPtr_m_PerObjectData;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideShaderID;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideShaderPassIndex;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideMaterialInstanceId;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideMaterialPassIndex;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterialInstanceId;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeFieldInfoPtr_m_MainLightIndex;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeFieldInfoPtr_m_UseSrpBatcher;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingSettings_Public_get_SortingSettings_0;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingSettings_Public_set_Void_SortingSettings_0;

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeMethodInfoPtr_set_enableDynamicBatching_Public_set_Void_Boolean_0;

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0;

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0;

		// Token: 0x040021C7 RID: 8647
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0;

		// Token: 0x040021C8 RID: 8648
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0;

		// Token: 0x040021C9 RID: 8649
		private static readonly IntPtr NativeMethodInfoPtr_set_mainLightIndex_Public_set_Void_Int32_0;

		// Token: 0x040021CA RID: 8650
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0;

		// Token: 0x040021CB RID: 8651
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0;

		// Token: 0x040021CC RID: 8652
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0;

		// Token: 0x040021CD RID: 8653
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0;

		// Token: 0x040021D0 RID: 8656
		[FieldOffset(0)]
		public SortingSettings m_SortingSettings;

		// Token: 0x040021D1 RID: 8657
		[FieldOffset(96)]
		public DrawingSettings._shaderPassNames_e__FixedBuffer shaderPassNames;

		// Token: 0x040021D2 RID: 8658
		[FieldOffset(160)]
		public PerObjectData m_PerObjectData;

		// Token: 0x040021D3 RID: 8659
		[FieldOffset(164)]
		public DrawRendererFlags m_Flags;

		// Token: 0x040021D4 RID: 8660
		[FieldOffset(168)]
		public int m_OverrideShaderID;

		// Token: 0x040021D5 RID: 8661
		[FieldOffset(172)]
		public int m_OverrideShaderPassIndex;

		// Token: 0x040021D6 RID: 8662
		[FieldOffset(176)]
		public int m_OverrideMaterialInstanceId;

		// Token: 0x040021D7 RID: 8663
		[FieldOffset(180)]
		public int m_OverrideMaterialPassIndex;

		// Token: 0x040021D8 RID: 8664
		[FieldOffset(184)]
		public int m_fallbackMaterialInstanceId;

		// Token: 0x040021D9 RID: 8665
		[FieldOffset(188)]
		public int m_MainLightIndex;

		// Token: 0x040021DA RID: 8666
		[FieldOffset(192)]
		public int m_UseSrpBatcher;

		// Token: 0x040021DB RID: 8667
		public const int kMaxShaderPasses = 16;

		// Token: 0x020009DB RID: 2523
		[ObfuscatedName("UnityEngine.Rendering.DrawingSettings+<shaderPassNames>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _shaderPassNames_e__FixedBuffer
		{
			// Token: 0x06003CD3 RID: 15571 RVA: 0x0001669C File Offset: 0x0001489C
			// Note: this type is marked as 'beforefieldinit'.
			static _shaderPassNames_e__FixedBuffer()
			{
				Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "<shaderPassNames>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr);
				DrawingSettings._shaderPassNames_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003CD4 RID: 15572 RVA: 0x000166D0 File Offset: 0x000148D0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002D2D RID: 11565
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002D2E RID: 11566
			[FieldOffset(0)]
			public int FixedElementField;
		}
	}
}
