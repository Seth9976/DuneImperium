using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018C RID: 396
	public sealed class RareData : ValueType
	{
		// Token: 0x060020D9 RID: 8409 RVA: 0x00094F60 File Offset: 0x00093160
		// Note: this type is marked as 'beforefieldinit'.
		static RareData()
		{
			Il2CppClassPointerStore<RareData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RareData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RareData>.NativeClassPtr);
			RareData.NativeFieldInfoPtr_cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RareData>.NativeClassPtr, "cursor");
			RareData.NativeFieldInfoPtr_textOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RareData>.NativeClassPtr, "textOverflow");
			RareData.NativeFieldInfoPtr_unityBackgroundImageTintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RareData>.NativeClassPtr, "unityBackgroundImageTintColor");
			RareData.NativeFieldInfoPtr_unityOverflowClipBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RareData>.NativeClassPtr, "unityOverflowClipBox");
			RareData.NativeFieldInfoPtr_unitySliceBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RareData>.NativeClassPtr, "unitySliceBottom");
			RareData.NativeFieldInfoPtr_unitySliceLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RareData>.NativeClassPtr, "unitySliceLeft");
			RareData.NativeFieldInfoPtr_unitySliceRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RareData>.NativeClassPtr, "unitySliceRight");
			RareData.NativeFieldInfoPtr_unitySliceScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RareData>.NativeClassPtr, "unitySliceScale");
			RareData.NativeFieldInfoPtr_unitySliceTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RareData>.NativeClassPtr, "unitySliceTop");
			RareData.NativeFieldInfoPtr_unityTextOverflowPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RareData>.NativeClassPtr, "unityTextOverflowPosition");
			RareData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_RareData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RareData>.NativeClassPtr, 100668168);
			RareData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_RareData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RareData>.NativeClassPtr, 100668169);
			RareData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RareData_RareData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RareData>.NativeClassPtr, 100668170);
			RareData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RareData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RareData>.NativeClassPtr, 100668171);
			RareData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RareData>.NativeClassPtr, 100668172);
			RareData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RareData>.NativeClassPtr, 100668173);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000950D0 File Offset: 0x000932D0
		[CallerCount(0)]
		public unsafe RareData Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RareData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_RareData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RareData(intPtr);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0009510C File Offset: 0x0009330C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334092, XrefRangeEnd = 334093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ref RareData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RareData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_RareData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00095154 File Offset: 0x00093354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334093, XrefRangeEnd = 334095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RareData lhs, RareData rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RareData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RareData_RareData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x000951B4 File Offset: 0x000933B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334097, RefRangeEnd = 334098, XrefRangeStart = 334095, XrefRangeEnd = 334097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RareData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RareData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RareData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x0009520C File Offset: 0x0009340C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334098, XrefRangeEnd = 334102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RareData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00095260 File Offset: 0x00093460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334102, XrefRangeEnd = 334105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RareData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x0000DC60 File Offset: 0x0000BE60
		public RareData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x0000DC69 File Offset: 0x0000BE69
		public RareData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RareData>.NativeClassPtr))
		{
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x000952A4 File Offset: 0x000934A4
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x0000DC7B File Offset: 0x0000BE7B
		public Cursor cursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_cursor);
				return new Cursor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cursor>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_cursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Cursor>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x000952D4 File Offset: 0x000934D4
		// (set) Token: 0x060020E5 RID: 8421 RVA: 0x0000DCA9 File Offset: 0x0000BEA9
		public unsafe TextOverflow textOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_textOverflow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_textOverflow)) = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x000952FC File Offset: 0x000934FC
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x0000DCC4 File Offset: 0x0000BEC4
		public unsafe Color unityBackgroundImageTintColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unityBackgroundImageTintColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unityBackgroundImageTintColor)) = value;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x00095324 File Offset: 0x00093524
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x0000DCDF File Offset: 0x0000BEDF
		public unsafe OverflowClipBox unityOverflowClipBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unityOverflowClipBox);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unityOverflowClipBox)) = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x0009534C File Offset: 0x0009354C
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x0000DCFA File Offset: 0x0000BEFA
		public unsafe int unitySliceBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unitySliceBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unitySliceBottom)) = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x00095374 File Offset: 0x00093574
		// (set) Token: 0x060020ED RID: 8429 RVA: 0x0000DD15 File Offset: 0x0000BF15
		public unsafe int unitySliceLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unitySliceLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unitySliceLeft)) = value;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x0009539C File Offset: 0x0009359C
		// (set) Token: 0x060020EF RID: 8431 RVA: 0x0000DD30 File Offset: 0x0000BF30
		public unsafe int unitySliceRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unitySliceRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unitySliceRight)) = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x000953C4 File Offset: 0x000935C4
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x0000DD4B File Offset: 0x0000BF4B
		public unsafe float unitySliceScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unitySliceScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unitySliceScale)) = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x000953EC File Offset: 0x000935EC
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x0000DD66 File Offset: 0x0000BF66
		public unsafe int unitySliceTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unitySliceTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unitySliceTop)) = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x00095414 File Offset: 0x00093614
		// (set) Token: 0x060020F5 RID: 8437 RVA: 0x0000DD81 File Offset: 0x0000BF81
		public unsafe TextOverflowPosition unityTextOverflowPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unityTextOverflowPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RareData.NativeFieldInfoPtr_unityTextOverflowPosition)) = value;
			}
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x0009543C File Offset: 0x0009363C
		public static bool operator !=(RareData lhs, RareData rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_cursor;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr_textOverflow;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeFieldInfoPtr_unityBackgroundImageTintColor;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeFieldInfoPtr_unityOverflowClipBox;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeFieldInfoPtr_unitySliceBottom;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeFieldInfoPtr_unitySliceLeft;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeFieldInfoPtr_unitySliceRight;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeFieldInfoPtr_unitySliceScale;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeFieldInfoPtr_unitySliceTop;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeFieldInfoPtr_unityTextOverflowPosition;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_RareData_0;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_RareData_0;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RareData_RareData_0;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RareData_0;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
