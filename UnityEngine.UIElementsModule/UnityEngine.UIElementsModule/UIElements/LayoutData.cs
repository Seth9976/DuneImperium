using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018B RID: 395
	[StructLayout(2)]
	public struct LayoutData
	{
		// Token: 0x060020D0 RID: 8400 RVA: 0x00094AA4 File Offset: 0x00092CA4
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutData()
		{
			Il2CppClassPointerStore<LayoutData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "LayoutData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutData>.NativeClassPtr);
			LayoutData.NativeFieldInfoPtr_alignContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "alignContent");
			LayoutData.NativeFieldInfoPtr_alignItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "alignItems");
			LayoutData.NativeFieldInfoPtr_alignSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "alignSelf");
			LayoutData.NativeFieldInfoPtr_borderBottomWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "borderBottomWidth");
			LayoutData.NativeFieldInfoPtr_borderLeftWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "borderLeftWidth");
			LayoutData.NativeFieldInfoPtr_borderRightWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "borderRightWidth");
			LayoutData.NativeFieldInfoPtr_borderTopWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "borderTopWidth");
			LayoutData.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "bottom");
			LayoutData.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "display");
			LayoutData.NativeFieldInfoPtr_flexBasis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "flexBasis");
			LayoutData.NativeFieldInfoPtr_flexDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "flexDirection");
			LayoutData.NativeFieldInfoPtr_flexGrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "flexGrow");
			LayoutData.NativeFieldInfoPtr_flexShrink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "flexShrink");
			LayoutData.NativeFieldInfoPtr_flexWrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "flexWrap");
			LayoutData.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "height");
			LayoutData.NativeFieldInfoPtr_justifyContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "justifyContent");
			LayoutData.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "left");
			LayoutData.NativeFieldInfoPtr_marginBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "marginBottom");
			LayoutData.NativeFieldInfoPtr_marginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "marginLeft");
			LayoutData.NativeFieldInfoPtr_marginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "marginRight");
			LayoutData.NativeFieldInfoPtr_marginTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "marginTop");
			LayoutData.NativeFieldInfoPtr_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "maxHeight");
			LayoutData.NativeFieldInfoPtr_maxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "maxWidth");
			LayoutData.NativeFieldInfoPtr_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "minHeight");
			LayoutData.NativeFieldInfoPtr_minWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "minWidth");
			LayoutData.NativeFieldInfoPtr_paddingBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "paddingBottom");
			LayoutData.NativeFieldInfoPtr_paddingLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "paddingLeft");
			LayoutData.NativeFieldInfoPtr_paddingRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "paddingRight");
			LayoutData.NativeFieldInfoPtr_paddingTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "paddingTop");
			LayoutData.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "position");
			LayoutData.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "right");
			LayoutData.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "top");
			LayoutData.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, "width");
			LayoutData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_LayoutData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, 100668162);
			LayoutData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_LayoutData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, 100668163);
			LayoutData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LayoutData_LayoutData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, 100668164);
			LayoutData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LayoutData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, 100668165);
			LayoutData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, 100668166);
			LayoutData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, 100668167);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00094DE0 File Offset: 0x00092FE0
		[CallerCount(0)]
		public unsafe LayoutData Copy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_LayoutData_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00094E10 File Offset: 0x00093010
		[CallerCount(0)]
		public unsafe void CopyFrom(ref LayoutData other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_LayoutData_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00094E44 File Offset: 0x00093044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334060, RefRangeEnd = 334061, XrefRangeStart = 334060, XrefRangeEnd = 334060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(LayoutData lhs, LayoutData rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LayoutData_LayoutData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00094E90 File Offset: 0x00093090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334062, RefRangeEnd = 334063, XrefRangeStart = 334061, XrefRangeEnd = 334062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LayoutData other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LayoutData_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00094ED0 File Offset: 0x000930D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334063, XrefRangeEnd = 334067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00094F14 File Offset: 0x00093114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334067, XrefRangeEnd = 334092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x0000DC4E File Offset: 0x0000BE4E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LayoutData>.NativeClassPtr, ref this));
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00094F44 File Offset: 0x00093144
		public static bool operator !=(LayoutData lhs, LayoutData rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeFieldInfoPtr_alignContent;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeFieldInfoPtr_alignItems;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeFieldInfoPtr_alignSelf;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeFieldInfoPtr_borderBottomWidth;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeFieldInfoPtr_borderLeftWidth;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeFieldInfoPtr_borderRightWidth;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeFieldInfoPtr_borderTopWidth;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeFieldInfoPtr_bottom;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeFieldInfoPtr_flexBasis;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeFieldInfoPtr_flexDirection;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeFieldInfoPtr_flexGrow;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeFieldInfoPtr_flexShrink;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeFieldInfoPtr_flexWrap;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeFieldInfoPtr_justifyContent;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeFieldInfoPtr_marginBottom;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeFieldInfoPtr_marginLeft;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeFieldInfoPtr_marginRight;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeFieldInfoPtr_marginTop;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeFieldInfoPtr_maxHeight;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeFieldInfoPtr_maxWidth;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeFieldInfoPtr_minHeight;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeFieldInfoPtr_minWidth;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeFieldInfoPtr_paddingBottom;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeFieldInfoPtr_paddingLeft;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_paddingRight;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeFieldInfoPtr_paddingTop;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_LayoutData_0;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_LayoutData_0;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LayoutData_LayoutData_0;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LayoutData_0;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040016E7 RID: 5863
		[FieldOffset(0)]
		public Align alignContent;

		// Token: 0x040016E8 RID: 5864
		[FieldOffset(4)]
		public Align alignItems;

		// Token: 0x040016E9 RID: 5865
		[FieldOffset(8)]
		public Align alignSelf;

		// Token: 0x040016EA RID: 5866
		[FieldOffset(12)]
		public float borderBottomWidth;

		// Token: 0x040016EB RID: 5867
		[FieldOffset(16)]
		public float borderLeftWidth;

		// Token: 0x040016EC RID: 5868
		[FieldOffset(20)]
		public float borderRightWidth;

		// Token: 0x040016ED RID: 5869
		[FieldOffset(24)]
		public float borderTopWidth;

		// Token: 0x040016EE RID: 5870
		[FieldOffset(28)]
		public Length bottom;

		// Token: 0x040016EF RID: 5871
		[FieldOffset(36)]
		public DisplayStyle display;

		// Token: 0x040016F0 RID: 5872
		[FieldOffset(40)]
		public Length flexBasis;

		// Token: 0x040016F1 RID: 5873
		[FieldOffset(48)]
		public FlexDirection flexDirection;

		// Token: 0x040016F2 RID: 5874
		[FieldOffset(52)]
		public float flexGrow;

		// Token: 0x040016F3 RID: 5875
		[FieldOffset(56)]
		public float flexShrink;

		// Token: 0x040016F4 RID: 5876
		[FieldOffset(60)]
		public Wrap flexWrap;

		// Token: 0x040016F5 RID: 5877
		[FieldOffset(64)]
		public Length height;

		// Token: 0x040016F6 RID: 5878
		[FieldOffset(72)]
		public Justify justifyContent;

		// Token: 0x040016F7 RID: 5879
		[FieldOffset(76)]
		public Length left;

		// Token: 0x040016F8 RID: 5880
		[FieldOffset(84)]
		public Length marginBottom;

		// Token: 0x040016F9 RID: 5881
		[FieldOffset(92)]
		public Length marginLeft;

		// Token: 0x040016FA RID: 5882
		[FieldOffset(100)]
		public Length marginRight;

		// Token: 0x040016FB RID: 5883
		[FieldOffset(108)]
		public Length marginTop;

		// Token: 0x040016FC RID: 5884
		[FieldOffset(116)]
		public Length maxHeight;

		// Token: 0x040016FD RID: 5885
		[FieldOffset(124)]
		public Length maxWidth;

		// Token: 0x040016FE RID: 5886
		[FieldOffset(132)]
		public Length minHeight;

		// Token: 0x040016FF RID: 5887
		[FieldOffset(140)]
		public Length minWidth;

		// Token: 0x04001700 RID: 5888
		[FieldOffset(148)]
		public Length paddingBottom;

		// Token: 0x04001701 RID: 5889
		[FieldOffset(156)]
		public Length paddingLeft;

		// Token: 0x04001702 RID: 5890
		[FieldOffset(164)]
		public Length paddingRight;

		// Token: 0x04001703 RID: 5891
		[FieldOffset(172)]
		public Length paddingTop;

		// Token: 0x04001704 RID: 5892
		[FieldOffset(180)]
		public Position position;

		// Token: 0x04001705 RID: 5893
		[FieldOffset(184)]
		public Length right;

		// Token: 0x04001706 RID: 5894
		[FieldOffset(192)]
		public Length top;

		// Token: 0x04001707 RID: 5895
		[FieldOffset(200)]
		public Length width;
	}
}
