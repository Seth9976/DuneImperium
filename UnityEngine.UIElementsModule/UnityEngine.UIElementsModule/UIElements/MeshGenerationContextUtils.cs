using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016E RID: 366
	public static class MeshGenerationContextUtils : Object
	{
		// Token: 0x06001B03 RID: 6915 RVA: 0x0007C780 File Offset: 0x0007A980
		// Note: this type is marked as 'beforefieldinit'.
		static MeshGenerationContextUtils()
		{
			Il2CppClassPointerStore<MeshGenerationContextUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MeshGenerationContextUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerationContextUtils>.NativeClassPtr);
			MeshGenerationContextUtils.NativeMethodInfoPtr_Rectangle_Public_Static_Void_MeshGenerationContext_RectangleParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils>.NativeClassPtr, 100667241);
			MeshGenerationContextUtils.NativeMethodInfoPtr_Text_Public_Static_Void_MeshGenerationContext_TextElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils>.NativeClassPtr, 100667242);
			MeshGenerationContextUtils.NativeMethodInfoPtr_ConvertBorderRadiusPercentToPoints_Private_Static_Vector2_Vector2_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils>.NativeClassPtr, 100667243);
			MeshGenerationContextUtils.NativeMethodInfoPtr_GetVisualElementRadii_Public_Static_Void_VisualElement_byref_Vector2_byref_Vector2_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils>.NativeClassPtr, 100667244);
			MeshGenerationContextUtils.NativeMethodInfoPtr_AdjustBackgroundSizeForBorders_Public_Static_Void_VisualElement_byref_RectangleParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils>.NativeClassPtr, 100667245);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0007C814 File Offset: 0x0007AA14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322778, RefRangeEnd = 322781, XrefRangeStart = 322775, XrefRangeEnd = 322778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Rectangle(this MeshGenerationContext mgc, MeshGenerationContextUtils.RectangleParams rectParams)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rectParams));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.NativeMethodInfoPtr_Rectangle_Public_Static_Void_MeshGenerationContext_RectangleParams_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0007C864 File Offset: 0x0007AA64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322785, RefRangeEnd = 322786, XrefRangeStart = 322781, XrefRangeEnd = 322785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Text(this MeshGenerationContext mgc, TextElement te)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(te);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.NativeMethodInfoPtr_Text_Public_Static_Void_MeshGenerationContext_TextElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0007C8AC File Offset: 0x0007AAAC
		[CallerCount(0)]
		public unsafe static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref borderRectSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.NativeMethodInfoPtr_ConvertBorderRadiusPercentToPoints_Private_Static_Vector2_Vector2_Length_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0007C8F8 File Offset: 0x0007AAF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 322797, RefRangeEnd = 322801, XrefRangeStart = 322786, XrefRangeEnd = 322797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &topLeft;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bottomLeft;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &topRight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bottomRight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.NativeMethodInfoPtr_GetVisualElementRadii_Public_Static_Void_VisualElement_byref_Vector2_byref_Vector2_byref_Vector2_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0007C968 File Offset: 0x0007AB68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322821, RefRangeEnd = 322823, XrefRangeStart = 322801, XrefRangeEnd = 322821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref MeshGenerationContextUtils.RectangleParams rectParams)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visualElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(rectParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.NativeMethodInfoPtr_AdjustBackgroundSizeForBorders_Public_Static_Void_VisualElement_byref_RectangleParams_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0000C47B File Offset: 0x0000A67B
		public MeshGenerationContextUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0000C484 File Offset: 0x0000A684
		public static void Border(MeshGenerationContext mgc, MeshGenerationContextUtils.BorderParams borderParams)
		{
			mgc.painter.DrawBorder(borderParams);
		}

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr_Rectangle_Public_Static_Void_MeshGenerationContext_RectangleParams_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr_Text_Public_Static_Void_MeshGenerationContext_TextElement_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_ConvertBorderRadiusPercentToPoints_Private_Static_Vector2_Vector2_Length_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr_GetVisualElementRadii_Public_Static_Void_VisualElement_byref_Vector2_byref_Vector2_byref_Vector2_byref_Vector2_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_AdjustBackgroundSizeForBorders_Public_Static_Void_VisualElement_byref_RectangleParams_0;

		// Token: 0x02000495 RID: 1173
		public sealed class BorderParams : ValueType
		{
			// Token: 0x06003C97 RID: 15511 RVA: 0x000F2988 File Offset: 0x000F0B88
			// Note: this type is marked as 'beforefieldinit'.
			static BorderParams()
			{
				Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshGenerationContextUtils>.NativeClassPtr, "BorderParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr);
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "rect");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_playmodeTintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "playmodeTintColor");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_leftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "leftColor");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "topColor");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "rightColor");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "bottomColor");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_leftWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "leftWidth");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "topWidth");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rightWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "rightWidth");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "bottomWidth");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topLeftRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "topLeftRadius");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topRightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "topRightRadius");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomRightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "bottomRightRadius");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomLeftRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "bottomLeftRadius");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "material");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_leftColorPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "leftColorPage");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topColorPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "topColorPage");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rightColorPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "rightColorPage");
				MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomColorPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, "bottomColorPage");
				MeshGenerationContextUtils.BorderParams.NativeMethodInfoPtr_ToNativeParams_Internal_NativeBorderParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr, 100667246);
			}

			// Token: 0x06003C98 RID: 15512 RVA: 0x000F2B44 File Offset: 0x000F0D44
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322639, RefRangeEnd = 322641, XrefRangeStart = 322639, XrefRangeEnd = 322639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshBuilderNative.NativeBorderParams ToNativeParams()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.BorderParams.NativeMethodInfoPtr_ToNativeParams_Internal_NativeBorderParams_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003C99 RID: 15513 RVA: 0x00019618 File Offset: 0x00017818
			public BorderParams(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003C9A RID: 15514 RVA: 0x00019621 File Offset: 0x00017821
			public BorderParams()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerationContextUtils.BorderParams>.NativeClassPtr))
			{
			}

			// Token: 0x1700124E RID: 4686
			// (get) Token: 0x06003C9B RID: 15515 RVA: 0x000F2B88 File Offset: 0x000F0D88
			// (set) Token: 0x06003C9C RID: 15516 RVA: 0x00019633 File Offset: 0x00017833
			public unsafe Rect rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rect)) = value;
				}
			}

			// Token: 0x1700124F RID: 4687
			// (get) Token: 0x06003C9D RID: 15517 RVA: 0x000F2BB0 File Offset: 0x000F0DB0
			// (set) Token: 0x06003C9E RID: 15518 RVA: 0x0001964E File Offset: 0x0001784E
			public unsafe Color playmodeTintColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_playmodeTintColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_playmodeTintColor)) = value;
				}
			}

			// Token: 0x17001250 RID: 4688
			// (get) Token: 0x06003C9F RID: 15519 RVA: 0x000F2BD8 File Offset: 0x000F0DD8
			// (set) Token: 0x06003CA0 RID: 15520 RVA: 0x00019669 File Offset: 0x00017869
			public unsafe Color leftColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_leftColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_leftColor)) = value;
				}
			}

			// Token: 0x17001251 RID: 4689
			// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x000F2C00 File Offset: 0x000F0E00
			// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x00019684 File Offset: 0x00017884
			public unsafe Color topColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topColor)) = value;
				}
			}

			// Token: 0x17001252 RID: 4690
			// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x000F2C28 File Offset: 0x000F0E28
			// (set) Token: 0x06003CA4 RID: 15524 RVA: 0x0001969F File Offset: 0x0001789F
			public unsafe Color rightColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rightColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rightColor)) = value;
				}
			}

			// Token: 0x17001253 RID: 4691
			// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x000F2C50 File Offset: 0x000F0E50
			// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x000196BA File Offset: 0x000178BA
			public unsafe Color bottomColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomColor)) = value;
				}
			}

			// Token: 0x17001254 RID: 4692
			// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x000F2C78 File Offset: 0x000F0E78
			// (set) Token: 0x06003CA8 RID: 15528 RVA: 0x000196D5 File Offset: 0x000178D5
			public unsafe float leftWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_leftWidth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_leftWidth)) = value;
				}
			}

			// Token: 0x17001255 RID: 4693
			// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x000F2CA0 File Offset: 0x000F0EA0
			// (set) Token: 0x06003CAA RID: 15530 RVA: 0x000196F0 File Offset: 0x000178F0
			public unsafe float topWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topWidth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topWidth)) = value;
				}
			}

			// Token: 0x17001256 RID: 4694
			// (get) Token: 0x06003CAB RID: 15531 RVA: 0x000F2CC8 File Offset: 0x000F0EC8
			// (set) Token: 0x06003CAC RID: 15532 RVA: 0x0001970B File Offset: 0x0001790B
			public unsafe float rightWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rightWidth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rightWidth)) = value;
				}
			}

			// Token: 0x17001257 RID: 4695
			// (get) Token: 0x06003CAD RID: 15533 RVA: 0x000F2CF0 File Offset: 0x000F0EF0
			// (set) Token: 0x06003CAE RID: 15534 RVA: 0x00019726 File Offset: 0x00017926
			public unsafe float bottomWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomWidth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomWidth)) = value;
				}
			}

			// Token: 0x17001258 RID: 4696
			// (get) Token: 0x06003CAF RID: 15535 RVA: 0x000F2D18 File Offset: 0x000F0F18
			// (set) Token: 0x06003CB0 RID: 15536 RVA: 0x00019741 File Offset: 0x00017941
			public unsafe Vector2 topLeftRadius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topLeftRadius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topLeftRadius)) = value;
				}
			}

			// Token: 0x17001259 RID: 4697
			// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x000F2D40 File Offset: 0x000F0F40
			// (set) Token: 0x06003CB2 RID: 15538 RVA: 0x0001975C File Offset: 0x0001795C
			public unsafe Vector2 topRightRadius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topRightRadius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topRightRadius)) = value;
				}
			}

			// Token: 0x1700125A RID: 4698
			// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x000F2D68 File Offset: 0x000F0F68
			// (set) Token: 0x06003CB4 RID: 15540 RVA: 0x00019777 File Offset: 0x00017977
			public unsafe Vector2 bottomRightRadius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomRightRadius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomRightRadius)) = value;
				}
			}

			// Token: 0x1700125B RID: 4699
			// (get) Token: 0x06003CB5 RID: 15541 RVA: 0x000F2D90 File Offset: 0x000F0F90
			// (set) Token: 0x06003CB6 RID: 15542 RVA: 0x00019792 File Offset: 0x00017992
			public unsafe Vector2 bottomLeftRadius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomLeftRadius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomLeftRadius)) = value;
				}
			}

			// Token: 0x1700125C RID: 4700
			// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x000F2DB8 File Offset: 0x000F0FB8
			// (set) Token: 0x06003CB8 RID: 15544 RVA: 0x000197AD File Offset: 0x000179AD
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700125D RID: 4701
			// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x000F2DE8 File Offset: 0x000F0FE8
			// (set) Token: 0x06003CBA RID: 15546 RVA: 0x000197CC File Offset: 0x000179CC
			public unsafe ColorPage leftColorPage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_leftColorPage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_leftColorPage)) = value;
				}
			}

			// Token: 0x1700125E RID: 4702
			// (get) Token: 0x06003CBB RID: 15547 RVA: 0x000F2E10 File Offset: 0x000F1010
			// (set) Token: 0x06003CBC RID: 15548 RVA: 0x000197E7 File Offset: 0x000179E7
			public unsafe ColorPage topColorPage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topColorPage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_topColorPage)) = value;
				}
			}

			// Token: 0x1700125F RID: 4703
			// (get) Token: 0x06003CBD RID: 15549 RVA: 0x000F2E38 File Offset: 0x000F1038
			// (set) Token: 0x06003CBE RID: 15550 RVA: 0x00019802 File Offset: 0x00017A02
			public unsafe ColorPage rightColorPage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rightColorPage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_rightColorPage)) = value;
				}
			}

			// Token: 0x17001260 RID: 4704
			// (get) Token: 0x06003CBF RID: 15551 RVA: 0x000F2E60 File Offset: 0x000F1060
			// (set) Token: 0x06003CC0 RID: 15552 RVA: 0x0001981D File Offset: 0x00017A1D
			public unsafe ColorPage bottomColorPage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomColorPage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.BorderParams.NativeFieldInfoPtr_bottomColorPage)) = value;
				}
			}

			// Token: 0x04002ADF RID: 10975
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x04002AE0 RID: 10976
			private static readonly IntPtr NativeFieldInfoPtr_playmodeTintColor;

			// Token: 0x04002AE1 RID: 10977
			private static readonly IntPtr NativeFieldInfoPtr_leftColor;

			// Token: 0x04002AE2 RID: 10978
			private static readonly IntPtr NativeFieldInfoPtr_topColor;

			// Token: 0x04002AE3 RID: 10979
			private static readonly IntPtr NativeFieldInfoPtr_rightColor;

			// Token: 0x04002AE4 RID: 10980
			private static readonly IntPtr NativeFieldInfoPtr_bottomColor;

			// Token: 0x04002AE5 RID: 10981
			private static readonly IntPtr NativeFieldInfoPtr_leftWidth;

			// Token: 0x04002AE6 RID: 10982
			private static readonly IntPtr NativeFieldInfoPtr_topWidth;

			// Token: 0x04002AE7 RID: 10983
			private static readonly IntPtr NativeFieldInfoPtr_rightWidth;

			// Token: 0x04002AE8 RID: 10984
			private static readonly IntPtr NativeFieldInfoPtr_bottomWidth;

			// Token: 0x04002AE9 RID: 10985
			private static readonly IntPtr NativeFieldInfoPtr_topLeftRadius;

			// Token: 0x04002AEA RID: 10986
			private static readonly IntPtr NativeFieldInfoPtr_topRightRadius;

			// Token: 0x04002AEB RID: 10987
			private static readonly IntPtr NativeFieldInfoPtr_bottomRightRadius;

			// Token: 0x04002AEC RID: 10988
			private static readonly IntPtr NativeFieldInfoPtr_bottomLeftRadius;

			// Token: 0x04002AED RID: 10989
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04002AEE RID: 10990
			private static readonly IntPtr NativeFieldInfoPtr_leftColorPage;

			// Token: 0x04002AEF RID: 10991
			private static readonly IntPtr NativeFieldInfoPtr_topColorPage;

			// Token: 0x04002AF0 RID: 10992
			private static readonly IntPtr NativeFieldInfoPtr_rightColorPage;

			// Token: 0x04002AF1 RID: 10993
			private static readonly IntPtr NativeFieldInfoPtr_bottomColorPage;

			// Token: 0x04002AF2 RID: 10994
			private static readonly IntPtr NativeMethodInfoPtr_ToNativeParams_Internal_NativeBorderParams_0;
		}

		// Token: 0x02000496 RID: 1174
		public sealed class RectangleParams : ValueType
		{
			// Token: 0x06003CC1 RID: 15553 RVA: 0x000F2E88 File Offset: 0x000F1088
			// Note: this type is marked as 'beforefieldinit'.
			static RectangleParams()
			{
				Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshGenerationContextUtils>.NativeClassPtr, "RectangleParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr);
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "rect");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "uv");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "color");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_subRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "subRect");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundRepeatRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "backgroundRepeatRect");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundPositionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "backgroundPositionX");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundPositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "backgroundPositionY");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "backgroundRepeat");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "backgroundSize");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "texture");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "sprite");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_vectorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "vectorImage");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "material");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_scaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "scaleMode");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_playmodeTintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "playmodeTintColor");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_topLeftRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "topLeftRadius");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_topRightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "topRightRadius");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_bottomRightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "bottomRightRadius");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_bottomLeftRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "bottomLeftRadius");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_contentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "contentSize");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_textureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "textureSize");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_leftSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "leftSlice");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_topSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "topSlice");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_rightSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "rightSlice");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_bottomSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "bottomSlice");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_sliceScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "sliceScale");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_spriteGeomRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "spriteGeomRect");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_rectInset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "rectInset");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_colorPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "colorPage");
				MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_meshFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, "meshFlags");
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_AdjustUVsForScaleMode_Private_Static_Void_Rect_Rect_Texture_ScaleMode_byref_Rect_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667247);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_AdjustSpriteUVsForScaleMode_Private_Static_Void_Rect_Rect_Rect_Sprite_ScaleMode_byref_Rect_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667248);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_RectIntersection_Internal_Static_Rect_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667249);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_ComputeGeomRect_Private_Static_Rect_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667250);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_ComputeUVRect_Private_Static_Rect_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667251);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_ApplyPackingRotation_Private_Static_Rect_Rect_SpritePackingRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667252);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_MakeTextured_Public_Static_RectangleParams_Rect_Rect_Texture_ScaleMode_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667253);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_MakeSprite_Public_Static_RectangleParams_Rect_Rect_Sprite_ScaleMode_ContextType_Boolean_byref_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667254);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_MakeVectorTextured_Public_Static_RectangleParams_Rect_Rect_VectorImage_ScaleMode_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667255);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_HasRadius_Internal_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667256);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_HasSlices_Internal_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667257);
				MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_ToNativeParams_Internal_NativeRectParams_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr, 100667258);
			}

			// Token: 0x06003CC2 RID: 15554 RVA: 0x000F31FC File Offset: 0x000F13FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322644, RefRangeEnd = 322645, XrefRangeStart = 322641, XrefRangeEnd = 322644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref rect;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rectOut;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &uvOut;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_AdjustUVsForScaleMode_Private_Static_Void_Rect_Rect_Texture_ScaleMode_byref_Rect_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CC3 RID: 15555 RVA: 0x000F327C File Offset: 0x000F147C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322659, RefRangeEnd = 322660, XrefRangeStart = 322645, XrefRangeEnd = 322659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref containerRect;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcRect;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spriteGeomRect;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rectOut;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &uvOut;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_AdjustSpriteUVsForScaleMode_Private_Static_Void_Rect_Rect_Rect_Sprite_ScaleMode_byref_Rect_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CC4 RID: 15556 RVA: 0x000F3308 File Offset: 0x000F1508
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322663, RefRangeEnd = 322664, XrefRangeStart = 322660, XrefRangeEnd = 322663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Rect RectIntersection(Rect a, Rect b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_RectIntersection_Internal_Static_Rect_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003CC5 RID: 15557 RVA: 0x000F3354 File Offset: 0x000F1554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322664, XrefRangeEnd = 322666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Rect ComputeGeomRect(Sprite sprite)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_ComputeGeomRect_Private_Static_Rect_Sprite_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003CC6 RID: 15558 RVA: 0x000F3398 File Offset: 0x000F1598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322666, XrefRangeEnd = 322668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Rect ComputeUVRect(Sprite sprite)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_ComputeUVRect_Private_Static_Rect_Sprite_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003CC7 RID: 15559 RVA: 0x000F33DC File Offset: 0x000F15DC
			[CallerCount(0)]
			public unsafe static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref uv;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_ApplyPackingRotation_Private_Static_Rect_Rect_SpritePackingRotation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003CC8 RID: 15560 RVA: 0x000F3428 File Offset: 0x000F1628
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 322677, RefRangeEnd = 322680, XrefRangeStart = 322668, XrefRangeEnd = 322677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static MeshGenerationContextUtils.RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, ContextType panelContext)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref rect;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_MakeTextured_Public_Static_RectangleParams_Rect_Rect_Texture_ScaleMode_ContextType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MeshGenerationContextUtils.RectangleParams(intPtr);
			}

			// Token: 0x06003CC9 RID: 15561 RVA: 0x000F349C File Offset: 0x000F169C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322757, RefRangeEnd = 322759, XrefRangeStart = 322680, XrefRangeEnd = 322757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static MeshGenerationContextUtils.RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, ContextType panelContext, bool hasRadius, ref Vector4 slices, bool useForRepeat = false)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref containerRect;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subRect;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelContext;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasRadius;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &slices;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useForRepeat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_MakeSprite_Public_Static_RectangleParams_Rect_Rect_Sprite_ScaleMode_ContextType_Boolean_byref_Vector4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MeshGenerationContextUtils.RectangleParams(intPtr);
			}

			// Token: 0x06003CCA RID: 15562 RVA: 0x000F353C File Offset: 0x000F173C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322768, RefRangeEnd = 322770, XrefRangeStart = 322759, XrefRangeEnd = 322768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static MeshGenerationContextUtils.RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, ContextType panelContext)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref rect;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vectorImage);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref panelContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_MakeVectorTextured_Public_Static_RectangleParams_Rect_Rect_VectorImage_ScaleMode_ContextType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MeshGenerationContextUtils.RectangleParams(intPtr);
			}

			// Token: 0x06003CCB RID: 15563 RVA: 0x000F35B0 File Offset: 0x000F17B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322770, RefRangeEnd = 322771, XrefRangeStart = 322770, XrefRangeEnd = 322770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool HasRadius(float epsilon)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref epsilon;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_HasRadius_Internal_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003CCC RID: 15564 RVA: 0x000F3600 File Offset: 0x000F1800
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322771, RefRangeEnd = 322772, XrefRangeStart = 322771, XrefRangeEnd = 322771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool HasSlices(float epsilon)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref epsilon;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_HasSlices_Internal_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003CCD RID: 15565 RVA: 0x000F3650 File Offset: 0x000F1850
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322773, RefRangeEnd = 322775, XrefRangeStart = 322772, XrefRangeEnd = 322773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshBuilderNative.NativeRectParams ToNativeParams(Rect uvRegion)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref uvRegion;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContextUtils.RectangleParams.NativeMethodInfoPtr_ToNativeParams_Internal_NativeRectParams_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003CCE RID: 15566 RVA: 0x00019838 File Offset: 0x00017A38
			public RectangleParams(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003CCF RID: 15567 RVA: 0x00019841 File Offset: 0x00017A41
			public RectangleParams()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerationContextUtils.RectangleParams>.NativeClassPtr))
			{
			}

			// Token: 0x17001261 RID: 4705
			// (get) Token: 0x06003CD0 RID: 15568 RVA: 0x000F36A0 File Offset: 0x000F18A0
			// (set) Token: 0x06003CD1 RID: 15569 RVA: 0x00019853 File Offset: 0x00017A53
			public unsafe Rect rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_rect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_rect)) = value;
				}
			}

			// Token: 0x17001262 RID: 4706
			// (get) Token: 0x06003CD2 RID: 15570 RVA: 0x000F36C8 File Offset: 0x000F18C8
			// (set) Token: 0x06003CD3 RID: 15571 RVA: 0x0001986E File Offset: 0x00017A6E
			public unsafe Rect uv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_uv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_uv)) = value;
				}
			}

			// Token: 0x17001263 RID: 4707
			// (get) Token: 0x06003CD4 RID: 15572 RVA: 0x000F36F0 File Offset: 0x000F18F0
			// (set) Token: 0x06003CD5 RID: 15573 RVA: 0x00019889 File Offset: 0x00017A89
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17001264 RID: 4708
			// (get) Token: 0x06003CD6 RID: 15574 RVA: 0x000F3718 File Offset: 0x000F1918
			// (set) Token: 0x06003CD7 RID: 15575 RVA: 0x000198A4 File Offset: 0x00017AA4
			public unsafe Rect subRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_subRect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_subRect)) = value;
				}
			}

			// Token: 0x17001265 RID: 4709
			// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x000F3740 File Offset: 0x000F1940
			// (set) Token: 0x06003CD9 RID: 15577 RVA: 0x000198BF File Offset: 0x00017ABF
			public unsafe Rect backgroundRepeatRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundRepeatRect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundRepeatRect)) = value;
				}
			}

			// Token: 0x17001266 RID: 4710
			// (get) Token: 0x06003CDA RID: 15578 RVA: 0x000F3768 File Offset: 0x000F1968
			// (set) Token: 0x06003CDB RID: 15579 RVA: 0x000198DA File Offset: 0x00017ADA
			public unsafe BackgroundPosition backgroundPositionX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundPositionX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundPositionX)) = value;
				}
			}

			// Token: 0x17001267 RID: 4711
			// (get) Token: 0x06003CDC RID: 15580 RVA: 0x000F3790 File Offset: 0x000F1990
			// (set) Token: 0x06003CDD RID: 15581 RVA: 0x000198F5 File Offset: 0x00017AF5
			public unsafe BackgroundPosition backgroundPositionY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundPositionY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundPositionY)) = value;
				}
			}

			// Token: 0x17001268 RID: 4712
			// (get) Token: 0x06003CDE RID: 15582 RVA: 0x000F37B8 File Offset: 0x000F19B8
			// (set) Token: 0x06003CDF RID: 15583 RVA: 0x00019910 File Offset: 0x00017B10
			public unsafe BackgroundRepeat backgroundRepeat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundRepeat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundRepeat)) = value;
				}
			}

			// Token: 0x17001269 RID: 4713
			// (get) Token: 0x06003CE0 RID: 15584 RVA: 0x000F37E0 File Offset: 0x000F19E0
			// (set) Token: 0x06003CE1 RID: 15585 RVA: 0x0001992B File Offset: 0x00017B2B
			public unsafe BackgroundSize backgroundSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_backgroundSize)) = value;
				}
			}

			// Token: 0x1700126A RID: 4714
			// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x000F3808 File Offset: 0x000F1A08
			// (set) Token: 0x06003CE3 RID: 15587 RVA: 0x00019946 File Offset: 0x00017B46
			public unsafe Texture texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_texture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126B RID: 4715
			// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x000F3838 File Offset: 0x000F1A38
			// (set) Token: 0x06003CE5 RID: 15589 RVA: 0x00019965 File Offset: 0x00017B65
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126C RID: 4716
			// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x000F3868 File Offset: 0x000F1A68
			// (set) Token: 0x06003CE7 RID: 15591 RVA: 0x00019984 File Offset: 0x00017B84
			public unsafe VectorImage vectorImage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_vectorImage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VectorImage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_vectorImage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126D RID: 4717
			// (get) Token: 0x06003CE8 RID: 15592 RVA: 0x000F3898 File Offset: 0x000F1A98
			// (set) Token: 0x06003CE9 RID: 15593 RVA: 0x000199A3 File Offset: 0x00017BA3
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126E RID: 4718
			// (get) Token: 0x06003CEA RID: 15594 RVA: 0x000F38C8 File Offset: 0x000F1AC8
			// (set) Token: 0x06003CEB RID: 15595 RVA: 0x000199C2 File Offset: 0x00017BC2
			public unsafe ScaleMode scaleMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_scaleMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_scaleMode)) = value;
				}
			}

			// Token: 0x1700126F RID: 4719
			// (get) Token: 0x06003CEC RID: 15596 RVA: 0x000F38F0 File Offset: 0x000F1AF0
			// (set) Token: 0x06003CED RID: 15597 RVA: 0x000199DD File Offset: 0x00017BDD
			public unsafe Color playmodeTintColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_playmodeTintColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_playmodeTintColor)) = value;
				}
			}

			// Token: 0x17001270 RID: 4720
			// (get) Token: 0x06003CEE RID: 15598 RVA: 0x000F3918 File Offset: 0x000F1B18
			// (set) Token: 0x06003CEF RID: 15599 RVA: 0x000199F8 File Offset: 0x00017BF8
			public unsafe Vector2 topLeftRadius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_topLeftRadius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_topLeftRadius)) = value;
				}
			}

			// Token: 0x17001271 RID: 4721
			// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x000F3940 File Offset: 0x000F1B40
			// (set) Token: 0x06003CF1 RID: 15601 RVA: 0x00019A13 File Offset: 0x00017C13
			public unsafe Vector2 topRightRadius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_topRightRadius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_topRightRadius)) = value;
				}
			}

			// Token: 0x17001272 RID: 4722
			// (get) Token: 0x06003CF2 RID: 15602 RVA: 0x000F3968 File Offset: 0x000F1B68
			// (set) Token: 0x06003CF3 RID: 15603 RVA: 0x00019A2E File Offset: 0x00017C2E
			public unsafe Vector2 bottomRightRadius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_bottomRightRadius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_bottomRightRadius)) = value;
				}
			}

			// Token: 0x17001273 RID: 4723
			// (get) Token: 0x06003CF4 RID: 15604 RVA: 0x000F3990 File Offset: 0x000F1B90
			// (set) Token: 0x06003CF5 RID: 15605 RVA: 0x00019A49 File Offset: 0x00017C49
			public unsafe Vector2 bottomLeftRadius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_bottomLeftRadius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_bottomLeftRadius)) = value;
				}
			}

			// Token: 0x17001274 RID: 4724
			// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x000F39B8 File Offset: 0x000F1BB8
			// (set) Token: 0x06003CF7 RID: 15607 RVA: 0x00019A64 File Offset: 0x00017C64
			public unsafe Vector2 contentSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_contentSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_contentSize)) = value;
				}
			}

			// Token: 0x17001275 RID: 4725
			// (get) Token: 0x06003CF8 RID: 15608 RVA: 0x000F39E0 File Offset: 0x000F1BE0
			// (set) Token: 0x06003CF9 RID: 15609 RVA: 0x00019A7F File Offset: 0x00017C7F
			public unsafe Vector2 textureSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_textureSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_textureSize)) = value;
				}
			}

			// Token: 0x17001276 RID: 4726
			// (get) Token: 0x06003CFA RID: 15610 RVA: 0x000F3A08 File Offset: 0x000F1C08
			// (set) Token: 0x06003CFB RID: 15611 RVA: 0x00019A9A File Offset: 0x00017C9A
			public unsafe int leftSlice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_leftSlice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_leftSlice)) = value;
				}
			}

			// Token: 0x17001277 RID: 4727
			// (get) Token: 0x06003CFC RID: 15612 RVA: 0x000F3A30 File Offset: 0x000F1C30
			// (set) Token: 0x06003CFD RID: 15613 RVA: 0x00019AB5 File Offset: 0x00017CB5
			public unsafe int topSlice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_topSlice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_topSlice)) = value;
				}
			}

			// Token: 0x17001278 RID: 4728
			// (get) Token: 0x06003CFE RID: 15614 RVA: 0x000F3A58 File Offset: 0x000F1C58
			// (set) Token: 0x06003CFF RID: 15615 RVA: 0x00019AD0 File Offset: 0x00017CD0
			public unsafe int rightSlice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_rightSlice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_rightSlice)) = value;
				}
			}

			// Token: 0x17001279 RID: 4729
			// (get) Token: 0x06003D00 RID: 15616 RVA: 0x000F3A80 File Offset: 0x000F1C80
			// (set) Token: 0x06003D01 RID: 15617 RVA: 0x00019AEB File Offset: 0x00017CEB
			public unsafe int bottomSlice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_bottomSlice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_bottomSlice)) = value;
				}
			}

			// Token: 0x1700127A RID: 4730
			// (get) Token: 0x06003D02 RID: 15618 RVA: 0x000F3AA8 File Offset: 0x000F1CA8
			// (set) Token: 0x06003D03 RID: 15619 RVA: 0x00019B06 File Offset: 0x00017D06
			public unsafe float sliceScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_sliceScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_sliceScale)) = value;
				}
			}

			// Token: 0x1700127B RID: 4731
			// (get) Token: 0x06003D04 RID: 15620 RVA: 0x000F3AD0 File Offset: 0x000F1CD0
			// (set) Token: 0x06003D05 RID: 15621 RVA: 0x00019B21 File Offset: 0x00017D21
			public unsafe Rect spriteGeomRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_spriteGeomRect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_spriteGeomRect)) = value;
				}
			}

			// Token: 0x1700127C RID: 4732
			// (get) Token: 0x06003D06 RID: 15622 RVA: 0x000F3AF8 File Offset: 0x000F1CF8
			// (set) Token: 0x06003D07 RID: 15623 RVA: 0x00019B3C File Offset: 0x00017D3C
			public unsafe Vector4 rectInset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_rectInset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_rectInset)) = value;
				}
			}

			// Token: 0x1700127D RID: 4733
			// (get) Token: 0x06003D08 RID: 15624 RVA: 0x000F3B20 File Offset: 0x000F1D20
			// (set) Token: 0x06003D09 RID: 15625 RVA: 0x00019B57 File Offset: 0x00017D57
			public unsafe ColorPage colorPage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_colorPage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_colorPage)) = value;
				}
			}

			// Token: 0x1700127E RID: 4734
			// (get) Token: 0x06003D0A RID: 15626 RVA: 0x000F3B48 File Offset: 0x000F1D48
			// (set) Token: 0x06003D0B RID: 15627 RVA: 0x00019B72 File Offset: 0x00017D72
			public unsafe MeshGenerationContext.MeshFlags meshFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_meshFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContextUtils.RectangleParams.NativeFieldInfoPtr_meshFlags)) = value;
				}
			}

			// Token: 0x04002AF3 RID: 10995
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x04002AF4 RID: 10996
			private static readonly IntPtr NativeFieldInfoPtr_uv;

			// Token: 0x04002AF5 RID: 10997
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04002AF6 RID: 10998
			private static readonly IntPtr NativeFieldInfoPtr_subRect;

			// Token: 0x04002AF7 RID: 10999
			private static readonly IntPtr NativeFieldInfoPtr_backgroundRepeatRect;

			// Token: 0x04002AF8 RID: 11000
			private static readonly IntPtr NativeFieldInfoPtr_backgroundPositionX;

			// Token: 0x04002AF9 RID: 11001
			private static readonly IntPtr NativeFieldInfoPtr_backgroundPositionY;

			// Token: 0x04002AFA RID: 11002
			private static readonly IntPtr NativeFieldInfoPtr_backgroundRepeat;

			// Token: 0x04002AFB RID: 11003
			private static readonly IntPtr NativeFieldInfoPtr_backgroundSize;

			// Token: 0x04002AFC RID: 11004
			private static readonly IntPtr NativeFieldInfoPtr_texture;

			// Token: 0x04002AFD RID: 11005
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x04002AFE RID: 11006
			private static readonly IntPtr NativeFieldInfoPtr_vectorImage;

			// Token: 0x04002AFF RID: 11007
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04002B00 RID: 11008
			private static readonly IntPtr NativeFieldInfoPtr_scaleMode;

			// Token: 0x04002B01 RID: 11009
			private static readonly IntPtr NativeFieldInfoPtr_playmodeTintColor;

			// Token: 0x04002B02 RID: 11010
			private static readonly IntPtr NativeFieldInfoPtr_topLeftRadius;

			// Token: 0x04002B03 RID: 11011
			private static readonly IntPtr NativeFieldInfoPtr_topRightRadius;

			// Token: 0x04002B04 RID: 11012
			private static readonly IntPtr NativeFieldInfoPtr_bottomRightRadius;

			// Token: 0x04002B05 RID: 11013
			private static readonly IntPtr NativeFieldInfoPtr_bottomLeftRadius;

			// Token: 0x04002B06 RID: 11014
			private static readonly IntPtr NativeFieldInfoPtr_contentSize;

			// Token: 0x04002B07 RID: 11015
			private static readonly IntPtr NativeFieldInfoPtr_textureSize;

			// Token: 0x04002B08 RID: 11016
			private static readonly IntPtr NativeFieldInfoPtr_leftSlice;

			// Token: 0x04002B09 RID: 11017
			private static readonly IntPtr NativeFieldInfoPtr_topSlice;

			// Token: 0x04002B0A RID: 11018
			private static readonly IntPtr NativeFieldInfoPtr_rightSlice;

			// Token: 0x04002B0B RID: 11019
			private static readonly IntPtr NativeFieldInfoPtr_bottomSlice;

			// Token: 0x04002B0C RID: 11020
			private static readonly IntPtr NativeFieldInfoPtr_sliceScale;

			// Token: 0x04002B0D RID: 11021
			private static readonly IntPtr NativeFieldInfoPtr_spriteGeomRect;

			// Token: 0x04002B0E RID: 11022
			private static readonly IntPtr NativeFieldInfoPtr_rectInset;

			// Token: 0x04002B0F RID: 11023
			private static readonly IntPtr NativeFieldInfoPtr_colorPage;

			// Token: 0x04002B10 RID: 11024
			private static readonly IntPtr NativeFieldInfoPtr_meshFlags;

			// Token: 0x04002B11 RID: 11025
			private static readonly IntPtr NativeMethodInfoPtr_AdjustUVsForScaleMode_Private_Static_Void_Rect_Rect_Texture_ScaleMode_byref_Rect_byref_Rect_0;

			// Token: 0x04002B12 RID: 11026
			private static readonly IntPtr NativeMethodInfoPtr_AdjustSpriteUVsForScaleMode_Private_Static_Void_Rect_Rect_Rect_Sprite_ScaleMode_byref_Rect_byref_Rect_0;

			// Token: 0x04002B13 RID: 11027
			private static readonly IntPtr NativeMethodInfoPtr_RectIntersection_Internal_Static_Rect_Rect_Rect_0;

			// Token: 0x04002B14 RID: 11028
			private static readonly IntPtr NativeMethodInfoPtr_ComputeGeomRect_Private_Static_Rect_Sprite_0;

			// Token: 0x04002B15 RID: 11029
			private static readonly IntPtr NativeMethodInfoPtr_ComputeUVRect_Private_Static_Rect_Sprite_0;

			// Token: 0x04002B16 RID: 11030
			private static readonly IntPtr NativeMethodInfoPtr_ApplyPackingRotation_Private_Static_Rect_Rect_SpritePackingRotation_0;

			// Token: 0x04002B17 RID: 11031
			private static readonly IntPtr NativeMethodInfoPtr_MakeTextured_Public_Static_RectangleParams_Rect_Rect_Texture_ScaleMode_ContextType_0;

			// Token: 0x04002B18 RID: 11032
			private static readonly IntPtr NativeMethodInfoPtr_MakeSprite_Public_Static_RectangleParams_Rect_Rect_Sprite_ScaleMode_ContextType_Boolean_byref_Vector4_Boolean_0;

			// Token: 0x04002B19 RID: 11033
			private static readonly IntPtr NativeMethodInfoPtr_MakeVectorTextured_Public_Static_RectangleParams_Rect_Rect_VectorImage_ScaleMode_ContextType_0;

			// Token: 0x04002B1A RID: 11034
			private static readonly IntPtr NativeMethodInfoPtr_HasRadius_Internal_Boolean_Single_0;

			// Token: 0x04002B1B RID: 11035
			private static readonly IntPtr NativeMethodInfoPtr_HasSlices_Internal_Boolean_Single_0;

			// Token: 0x04002B1C RID: 11036
			private static readonly IntPtr NativeMethodInfoPtr_ToNativeParams_Internal_NativeRectParams_Rect_0;
		}
	}
}
