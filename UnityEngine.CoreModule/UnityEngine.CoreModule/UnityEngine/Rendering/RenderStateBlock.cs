using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000243 RID: 579
	[StructLayout(2)]
	public struct RenderStateBlock
	{
		// Token: 0x060026DB RID: 9947 RVA: 0x000A4498 File Offset: 0x000A2698
		// Note: this type is marked as 'beforefieldinit'.
		static RenderStateBlock()
		{
			Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderStateBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr);
			RenderStateBlock.NativeFieldInfoPtr_m_BlendState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_BlendState");
			RenderStateBlock.NativeFieldInfoPtr_m_RasterState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_RasterState");
			RenderStateBlock.NativeFieldInfoPtr_m_DepthState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_DepthState");
			RenderStateBlock.NativeFieldInfoPtr_m_StencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_StencilState");
			RenderStateBlock.NativeFieldInfoPtr_m_StencilReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_StencilReference");
			RenderStateBlock.NativeFieldInfoPtr_m_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_Mask");
			RenderStateBlock.NativeMethodInfoPtr__ctor_Public_Void_RenderStateMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668273);
			RenderStateBlock.NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668274);
			RenderStateBlock.NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668275);
			RenderStateBlock.NativeMethodInfoPtr_get_depthState_Public_get_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668276);
			RenderStateBlock.NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668277);
			RenderStateBlock.NativeMethodInfoPtr_get_stencilState_Public_get_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668278);
			RenderStateBlock.NativeMethodInfoPtr_set_stencilState_Public_set_Void_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668279);
			RenderStateBlock.NativeMethodInfoPtr_get_stencilReference_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668280);
			RenderStateBlock.NativeMethodInfoPtr_set_stencilReference_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668281);
			RenderStateBlock.NativeMethodInfoPtr_get_mask_Public_get_RenderStateMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668282);
			RenderStateBlock.NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668283);
			RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668284);
			RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668285);
			RenderStateBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668286);
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x000A4658 File Offset: 0x000A2858
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 684345, RefRangeEnd = 684350, XrefRangeStart = 684332, XrefRangeEnd = 684345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderStateBlock(RenderStateMask mask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr__ctor_Public_Void_RenderStateMask_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x000A4938 File Offset: 0x000A2B38
		// (set) Token: 0x060026DD RID: 9949 RVA: 0x000A468C File Offset: 0x000A288C
		public unsafe BlendState blendState
		{
			get
			{
				return this.m_BlendState;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 684350, RefRangeEnd = 684351, XrefRangeStart = 684350, XrefRangeEnd = 684350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x000A4950 File Offset: 0x000A2B50
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x000A46C0 File Offset: 0x000A28C0
		public unsafe RasterState rasterState
		{
			get
			{
				return this.m_RasterState;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 684351, RefRangeEnd = 684352, XrefRangeStart = 684351, XrefRangeEnd = 684351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x000A46F4 File Offset: 0x000A28F4
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x000A4724 File Offset: 0x000A2924
		public unsafe DepthState depthState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 684352, RefRangeEnd = 684353, XrefRangeStart = 684352, XrefRangeEnd = 684352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_get_depthState_Public_get_DepthState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 684353, RefRangeEnd = 684356, XrefRangeStart = 684353, XrefRangeEnd = 684353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000A4758 File Offset: 0x000A2958
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x000A4788 File Offset: 0x000A2988
		public unsafe StencilState stencilState
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 684356, RefRangeEnd = 684358, XrefRangeStart = 684356, XrefRangeEnd = 684356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_get_stencilState_Public_get_StencilState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 684358, RefRangeEnd = 684364, XrefRangeStart = 684358, XrefRangeEnd = 684358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_stencilState_Public_set_Void_StencilState_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000A47BC File Offset: 0x000A29BC
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x000A47EC File Offset: 0x000A29EC
		public unsafe int stencilReference
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 345980, RefRangeEnd = 345981, XrefRangeStart = 345980, XrefRangeEnd = 345981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_get_stencilReference_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 345981, RefRangeEnd = 345986, XrefRangeStart = 345981, XrefRangeEnd = 345986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_stencilReference_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000A4820 File Offset: 0x000A2A20
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x000A4850 File Offset: 0x000A2A50
		public unsafe RenderStateMask mask
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 337731, RefRangeEnd = 337738, XrefRangeStart = 337731, XrefRangeEnd = 337738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_get_mask_Public_get_RenderStateMask_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 337738, RefRangeEnd = 337747, XrefRangeStart = 337738, XrefRangeEnd = 337747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x000A4884 File Offset: 0x000A2A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684370, RefRangeEnd = 684371, XrefRangeStart = 684364, XrefRangeEnd = 684370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RenderStateBlock other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x000A48C4 File Offset: 0x000A2AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684371, XrefRangeEnd = 684375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000A4908 File Offset: 0x000A2B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684375, XrefRangeEnd = 684385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0000F32C File Offset: 0x0000D52C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, ref this));
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000A4968 File Offset: 0x000A2B68
		public static bool operator ==(RenderStateBlock left, RenderStateBlock right)
		{
			return left.Equals(right);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000A4984 File Offset: 0x000A2B84
		public static bool operator !=(RenderStateBlock left, RenderStateBlock right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeFieldInfoPtr_m_RasterState;

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthState;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilState;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilReference;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeFieldInfoPtr_m_Mask;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderStateMask_0;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeMethodInfoPtr_get_depthState_Public_get_DepthState_0;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeMethodInfoPtr_get_stencilState_Public_get_StencilState_0;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeMethodInfoPtr_set_stencilState_Public_set_Void_StencilState_0;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeMethodInfoPtr_get_stencilReference_Public_get_Int32_0;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeMethodInfoPtr_set_stencilReference_Public_set_Void_Int32_0;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeMethodInfoPtr_get_mask_Public_get_RenderStateMask_0;

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040022BE RID: 8894
		[FieldOffset(0)]
		public BlendState m_BlendState;

		// Token: 0x040022BF RID: 8895
		[FieldOffset(68)]
		public RasterState m_RasterState;

		// Token: 0x040022C0 RID: 8896
		[FieldOffset(84)]
		public DepthState m_DepthState;

		// Token: 0x040022C1 RID: 8897
		[FieldOffset(86)]
		public StencilState m_StencilState;

		// Token: 0x040022C2 RID: 8898
		[FieldOffset(100)]
		public int m_StencilReference;

		// Token: 0x040022C3 RID: 8899
		[FieldOffset(104)]
		public RenderStateMask m_Mask;
	}
}
