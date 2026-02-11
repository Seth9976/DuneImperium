using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000234 RID: 564
	[StructLayout(2)]
	public struct FilteringSettings
	{
		// Token: 0x060025E3 RID: 9699 RVA: 0x000A1478 File Offset: 0x0009F678
		// Note: this type is marked as 'beforefieldinit'.
		static FilteringSettings()
		{
			Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "FilteringSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr);
			FilteringSettings.NativeFieldInfoPtr_m_RenderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_RenderQueueRange");
			FilteringSettings.NativeFieldInfoPtr_m_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_LayerMask");
			FilteringSettings.NativeFieldInfoPtr_m_RenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_RenderingLayerMask");
			FilteringSettings.NativeFieldInfoPtr_m_ExcludeMotionVectorObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_ExcludeMotionVectorObjects");
			FilteringSettings.NativeFieldInfoPtr_m_SortingLayerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_SortingLayerRange");
			FilteringSettings.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668169);
			FilteringSettings.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668170);
			FilteringSettings.NativeMethodInfoPtr_get_renderQueueRange_Public_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668171);
			FilteringSettings.NativeMethodInfoPtr_set_renderQueueRange_Public_set_Void_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668172);
			FilteringSettings.NativeMethodInfoPtr_set_layerMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668173);
			FilteringSettings.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668174);
			FilteringSettings.NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668175);
			FilteringSettings.NativeMethodInfoPtr_set_sortingLayerRange_Public_set_Void_SortingLayerRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668176);
			FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668177);
			FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668178);
			FilteringSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668179);
			FilteringSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668180);
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000A15FC File Offset: 0x0009F7FC
		public unsafe static FilteringSettings defaultValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 683723, RefRangeEnd = 683725, XrefRangeStart = 683716, XrefRangeEnd = 683723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_FilteringSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x000A162C File Offset: 0x0009F82C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 683731, RefRangeEnd = 683743, XrefRangeStart = 683725, XrefRangeEnd = 683731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilteringSettings(Nullable<RenderQueueRange> renderQueueRange = null, int layerMask = -1, uint renderingLayerMask = 4294967295U, int excludeMotionVectorObjects = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderQueueRange));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderingLayerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref excludeMotionVectorObjects;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x000A1694 File Offset: 0x0009F894
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x000A16C4 File Offset: 0x0009F8C4
		public unsafe RenderQueueRange renderQueueRange
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_get_renderQueueRange_Public_get_RenderQueueRange_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_renderQueueRange_Public_set_Void_RenderQueueRange_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x000A18C8 File Offset: 0x0009FAC8
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x000A16F8 File Offset: 0x0009F8F8
		public unsafe int layerMask
		{
			get
			{
				return this.m_LayerMask;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_layerMask_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x000A18E0 File Offset: 0x0009FAE0
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x000A172C File Offset: 0x0009F92C
		public unsafe uint renderingLayerMask
		{
			get
			{
				return this.m_RenderingLayerMask;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 310309, RefRangeEnd = 310312, XrefRangeStart = 310309, XrefRangeEnd = 310312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x000A18F8 File Offset: 0x0009FAF8
		// (set) Token: 0x060025EA RID: 9706 RVA: 0x000A1760 File Offset: 0x0009F960
		public unsafe bool excludeMotionVectorObjects
		{
			get
			{
				return this.m_ExcludeMotionVectorObjects != 0;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000A1914 File Offset: 0x0009FB14
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x000A1794 File Offset: 0x0009F994
		public unsafe SortingLayerRange sortingLayerRange
		{
			get
			{
				return this.m_SortingLayerRange;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_sortingLayerRange_Public_set_Void_SortingLayerRange_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x000A17C8 File Offset: 0x0009F9C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683746, RefRangeEnd = 683748, XrefRangeStart = 683743, XrefRangeEnd = 683746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FilteringSettings other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x000A1808 File Offset: 0x0009FA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683748, XrefRangeEnd = 683752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x000A184C File Offset: 0x0009FA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683752, XrefRangeEnd = 683755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x000A187C File Offset: 0x0009FA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683755, XrefRangeEnd = 683756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FilteringSettings left, FilteringSettings right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x0000EDD5 File Offset: 0x0000CFD5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000A192C File Offset: 0x0009FB2C
		public static bool operator !=(FilteringSettings left, FilteringSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderQueueRange;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeFieldInfoPtr_m_LayerMask;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderingLayerMask;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeFieldInfoPtr_m_ExcludeMotionVectorObjects;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingLayerRange;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_FilteringSettings_0;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeMethodInfoPtr_get_renderQueueRange_Public_get_RenderQueueRange_0;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeMethodInfoPtr_set_renderQueueRange_Public_set_Void_RenderQueueRange_0;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeMethodInfoPtr_set_layerMask_Public_set_Void_Int32_0;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerRange_Public_set_Void_SortingLayerRange_0;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0;

		// Token: 0x040021F1 RID: 8689
		[FieldOffset(0)]
		public RenderQueueRange m_RenderQueueRange;

		// Token: 0x040021F2 RID: 8690
		[FieldOffset(8)]
		public int m_LayerMask;

		// Token: 0x040021F3 RID: 8691
		[FieldOffset(12)]
		public uint m_RenderingLayerMask;

		// Token: 0x040021F4 RID: 8692
		[FieldOffset(16)]
		public int m_ExcludeMotionVectorObjects;

		// Token: 0x040021F5 RID: 8693
		[FieldOffset(20)]
		public SortingLayerRange m_SortingLayerRange;
	}
}
