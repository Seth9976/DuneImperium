using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018F RID: 399
	public sealed class VisualData : ValueType
	{
		// Token: 0x06002112 RID: 8466 RVA: 0x00095A78 File Offset: 0x00093C78
		// Note: this type is marked as 'beforefieldinit'.
		static VisualData()
		{
			Il2CppClassPointerStore<VisualData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualData>.NativeClassPtr);
			VisualData.NativeFieldInfoPtr_backgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "backgroundColor");
			VisualData.NativeFieldInfoPtr_backgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "backgroundImage");
			VisualData.NativeFieldInfoPtr_backgroundPositionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "backgroundPositionX");
			VisualData.NativeFieldInfoPtr_backgroundPositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "backgroundPositionY");
			VisualData.NativeFieldInfoPtr_backgroundRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "backgroundRepeat");
			VisualData.NativeFieldInfoPtr_backgroundSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "backgroundSize");
			VisualData.NativeFieldInfoPtr_borderBottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "borderBottomColor");
			VisualData.NativeFieldInfoPtr_borderBottomLeftRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "borderBottomLeftRadius");
			VisualData.NativeFieldInfoPtr_borderBottomRightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "borderBottomRightRadius");
			VisualData.NativeFieldInfoPtr_borderLeftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "borderLeftColor");
			VisualData.NativeFieldInfoPtr_borderRightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "borderRightColor");
			VisualData.NativeFieldInfoPtr_borderTopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "borderTopColor");
			VisualData.NativeFieldInfoPtr_borderTopLeftRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "borderTopLeftRadius");
			VisualData.NativeFieldInfoPtr_borderTopRightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "borderTopRightRadius");
			VisualData.NativeFieldInfoPtr_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "opacity");
			VisualData.NativeFieldInfoPtr_overflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualData>.NativeClassPtr, "overflow");
			VisualData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_VisualData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualData>.NativeClassPtr, 100668186);
			VisualData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_VisualData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualData>.NativeClassPtr, 100668187);
			VisualData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_VisualData_VisualData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualData>.NativeClassPtr, 100668188);
			VisualData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisualData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualData>.NativeClassPtr, 100668189);
			VisualData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualData>.NativeClassPtr, 100668190);
			VisualData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualData>.NativeClassPtr, 100668191);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00095C60 File Offset: 0x00093E60
		[CallerCount(0)]
		public unsafe VisualData Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_VisualData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new VisualData(intPtr);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00095C9C File Offset: 0x00093E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334174, XrefRangeEnd = 334175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ref VisualData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_VisualData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00095CE4 File Offset: 0x00093EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334181, RefRangeEnd = 334182, XrefRangeStart = 334175, XrefRangeEnd = 334181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(VisualData lhs, VisualData rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_VisualData_VisualData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00095D44 File Offset: 0x00093F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334183, RefRangeEnd = 334184, XrefRangeStart = 334182, XrefRangeEnd = 334183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(VisualData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisualData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00095D9C File Offset: 0x00093F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334184, XrefRangeEnd = 334188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00095DF0 File Offset: 0x00093FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334188, XrefRangeEnd = 334203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0000DE45 File Offset: 0x0000C045
		public VisualData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0000DE4E File Offset: 0x0000C04E
		public VisualData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualData>.NativeClassPtr))
		{
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x00095E34 File Offset: 0x00094034
		// (set) Token: 0x0600211C RID: 8476 RVA: 0x0000DE60 File Offset: 0x0000C060
		public unsafe Color backgroundColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundColor)) = value;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x00095E5C File Offset: 0x0009405C
		// (set) Token: 0x0600211E RID: 8478 RVA: 0x0000DE7B File Offset: 0x0000C07B
		public Background backgroundImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundImage);
				return new Background(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Background>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundImage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Background>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x00095E8C File Offset: 0x0009408C
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x0000DEA9 File Offset: 0x0000C0A9
		public unsafe BackgroundPosition backgroundPositionX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundPositionX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundPositionX)) = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x00095EB4 File Offset: 0x000940B4
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x0000DEC4 File Offset: 0x0000C0C4
		public unsafe BackgroundPosition backgroundPositionY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundPositionY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundPositionY)) = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x00095EDC File Offset: 0x000940DC
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x0000DEDF File Offset: 0x0000C0DF
		public unsafe BackgroundRepeat backgroundRepeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundRepeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundRepeat)) = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x00095F04 File Offset: 0x00094104
		// (set) Token: 0x06002126 RID: 8486 RVA: 0x0000DEFA File Offset: 0x0000C0FA
		public unsafe BackgroundSize backgroundSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_backgroundSize)) = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x00095F2C File Offset: 0x0009412C
		// (set) Token: 0x06002128 RID: 8488 RVA: 0x0000DF15 File Offset: 0x0000C115
		public unsafe Color borderBottomColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderBottomColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderBottomColor)) = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x00095F54 File Offset: 0x00094154
		// (set) Token: 0x0600212A RID: 8490 RVA: 0x0000DF30 File Offset: 0x0000C130
		public unsafe Length borderBottomLeftRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderBottomLeftRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderBottomLeftRadius)) = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x00095F7C File Offset: 0x0009417C
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x0000DF4B File Offset: 0x0000C14B
		public unsafe Length borderBottomRightRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderBottomRightRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderBottomRightRadius)) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x00095FA4 File Offset: 0x000941A4
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x0000DF66 File Offset: 0x0000C166
		public unsafe Color borderLeftColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderLeftColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderLeftColor)) = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x00095FCC File Offset: 0x000941CC
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x0000DF81 File Offset: 0x0000C181
		public unsafe Color borderRightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderRightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderRightColor)) = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x00095FF4 File Offset: 0x000941F4
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x0000DF9C File Offset: 0x0000C19C
		public unsafe Color borderTopColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderTopColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderTopColor)) = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x0009601C File Offset: 0x0009421C
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x0000DFB7 File Offset: 0x0000C1B7
		public unsafe Length borderTopLeftRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderTopLeftRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderTopLeftRadius)) = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x00096044 File Offset: 0x00094244
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x0000DFD2 File Offset: 0x0000C1D2
		public unsafe Length borderTopRightRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderTopRightRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_borderTopRightRadius)) = value;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x0009606C File Offset: 0x0009426C
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x0000DFED File Offset: 0x0000C1ED
		public unsafe float opacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_opacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_opacity)) = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x00096094 File Offset: 0x00094294
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x0000E008 File Offset: 0x0000C208
		public unsafe OverflowInternal overflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_overflow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualData.NativeFieldInfoPtr_overflow)) = value;
			}
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x000960BC File Offset: 0x000942BC
		public static bool operator !=(VisualData lhs, VisualData rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeFieldInfoPtr_backgroundColor;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeFieldInfoPtr_backgroundImage;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeFieldInfoPtr_backgroundPositionX;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeFieldInfoPtr_backgroundPositionY;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeFieldInfoPtr_backgroundRepeat;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeFieldInfoPtr_backgroundSize;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeFieldInfoPtr_borderBottomColor;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeFieldInfoPtr_borderBottomLeftRadius;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeFieldInfoPtr_borderBottomRightRadius;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeFieldInfoPtr_borderLeftColor;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeFieldInfoPtr_borderRightColor;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeFieldInfoPtr_borderTopColor;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeFieldInfoPtr_borderTopLeftRadius;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeFieldInfoPtr_borderTopRightRadius;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeFieldInfoPtr_opacity;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeFieldInfoPtr_overflow;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_VisualData_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_VisualData_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_VisualData_VisualData_0;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisualData_0;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
