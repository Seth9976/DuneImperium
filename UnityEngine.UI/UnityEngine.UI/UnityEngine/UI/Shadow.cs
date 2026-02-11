using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000045 RID: 69
	public class Shadow : BaseMeshEffect
	{
		// Token: 0x06000837 RID: 2103 RVA: 0x00027254 File Offset: 0x00025454
		// Note: this type is marked as 'beforefieldinit'.
		static Shadow()
		{
			Il2CppClassPointerStore<Shadow>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Shadow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shadow>.NativeClassPtr);
			Shadow.NativeFieldInfoPtr_m_EffectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadow>.NativeClassPtr, "m_EffectColor");
			Shadow.NativeFieldInfoPtr_m_EffectDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadow>.NativeClassPtr, "m_EffectDistance");
			Shadow.NativeFieldInfoPtr_m_UseGraphicAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadow>.NativeClassPtr, "m_UseGraphicAlpha");
			Shadow.NativeFieldInfoPtr_kMaxEffectDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadow>.NativeClassPtr, "kMaxEffectDistance");
			Shadow.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664633);
			Shadow.NativeMethodInfoPtr_get_effectColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664634);
			Shadow.NativeMethodInfoPtr_set_effectColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664635);
			Shadow.NativeMethodInfoPtr_get_effectDistance_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664636);
			Shadow.NativeMethodInfoPtr_set_effectDistance_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664637);
			Shadow.NativeMethodInfoPtr_get_useGraphicAlpha_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664638);
			Shadow.NativeMethodInfoPtr_set_useGraphicAlpha_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664639);
			Shadow.NativeMethodInfoPtr_ApplyShadowZeroAlloc_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664640);
			Shadow.NativeMethodInfoPtr_ApplyShadow_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664641);
			Shadow.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664642);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0002739C File Offset: 0x0002559C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093965, RefRangeEnd = 1093966, XrefRangeStart = 1093964, XrefRangeEnd = 1093965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shadow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shadow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x000273D8 File Offset: 0x000255D8
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00027414 File Offset: 0x00025614
		public unsafe Color effectColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_get_effectColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093966, XrefRangeEnd = 1093972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_set_effectColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00027454 File Offset: 0x00025654
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00027490 File Offset: 0x00025690
		public unsafe Vector2 effectDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_get_effectDistance_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093972, XrefRangeEnd = 1093980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_set_effectDistance_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x000274D0 File Offset: 0x000256D0
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x0002750C File Offset: 0x0002570C
		public unsafe bool useGraphicAlpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_get_useGraphicAlpha_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093980, XrefRangeEnd = 1093986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_set_useGraphicAlpha_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0002754C File Offset: 0x0002574C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1094005, RefRangeEnd = 1094011, XrefRangeStart = 1093986, XrefRangeEnd = 1094005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_ApplyShadowZeroAlloc_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000275D4 File Offset: 0x000257D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094011, XrefRangeEnd = 1094012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_ApplyShadow_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0002765C File Offset: 0x0002585C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094012, XrefRangeEnd = 1094027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shadow.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00004D52 File Offset: 0x00002F52
		public Shadow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x000276AC File Offset: 0x000258AC
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00004D5B File Offset: 0x00002F5B
		public unsafe Color m_EffectColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_EffectColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_EffectColor)) = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000276D4 File Offset: 0x000258D4
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00004D76 File Offset: 0x00002F76
		public unsafe Vector2 m_EffectDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_EffectDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_EffectDistance)) = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000276FC File Offset: 0x000258FC
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x00004D91 File Offset: 0x00002F91
		public unsafe bool m_UseGraphicAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_UseGraphicAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_UseGraphicAlpha)) = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00027724 File Offset: 0x00025924
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00004DAC File Offset: 0x00002FAC
		public unsafe static float kMaxEffectDistance
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Shadow.NativeFieldInfoPtr_kMaxEffectDistance, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shadow.NativeFieldInfoPtr_kMaxEffectDistance, (void*)(&value));
			}
		}

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectColor;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectDistance;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr_m_UseGraphicAlpha;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr_kMaxEffectDistance;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_get_effectColor_Public_get_Color_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_set_effectColor_Public_set_Void_Color_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_get_effectDistance_Public_get_Vector2_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_set_effectDistance_Public_set_Void_Vector2_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_get_useGraphicAlpha_Public_get_Boolean_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_set_useGraphicAlpha_Public_set_Void_Boolean_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShadowZeroAlloc_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShadow_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;
	}
}
