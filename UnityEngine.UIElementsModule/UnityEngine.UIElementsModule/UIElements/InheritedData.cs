using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018A RID: 394
	public sealed class InheritedData : ValueType
	{
		// Token: 0x060020AA RID: 8362 RVA: 0x000944B4 File Offset: 0x000926B4
		// Note: this type is marked as 'beforefieldinit'.
		static InheritedData()
		{
			Il2CppClassPointerStore<InheritedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "InheritedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InheritedData>.NativeClassPtr);
			InheritedData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "color");
			InheritedData.NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "fontSize");
			InheritedData.NativeFieldInfoPtr_letterSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "letterSpacing");
			InheritedData.NativeFieldInfoPtr_textShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "textShadow");
			InheritedData.NativeFieldInfoPtr_unityFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "unityFont");
			InheritedData.NativeFieldInfoPtr_unityFontDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "unityFontDefinition");
			InheritedData.NativeFieldInfoPtr_unityFontStyleAndWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "unityFontStyleAndWeight");
			InheritedData.NativeFieldInfoPtr_unityParagraphSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "unityParagraphSpacing");
			InheritedData.NativeFieldInfoPtr_unityTextAlign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "unityTextAlign");
			InheritedData.NativeFieldInfoPtr_unityTextOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "unityTextOutlineColor");
			InheritedData.NativeFieldInfoPtr_unityTextOutlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "unityTextOutlineWidth");
			InheritedData.NativeFieldInfoPtr_visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "visibility");
			InheritedData.NativeFieldInfoPtr_whiteSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "whiteSpace");
			InheritedData.NativeFieldInfoPtr_wordSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "wordSpacing");
			InheritedData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_InheritedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, 100668156);
			InheritedData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_InheritedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, 100668157);
			InheritedData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InheritedData_InheritedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, 100668158);
			InheritedData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InheritedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, 100668159);
			InheritedData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, 100668160);
			InheritedData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, 100668161);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00094674 File Offset: 0x00092874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334025, RefRangeEnd = 334026, XrefRangeStart = 334025, XrefRangeEnd = 334025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InheritedData Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InheritedData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_InheritedData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new InheritedData(intPtr);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x000946B0 File Offset: 0x000928B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334026, XrefRangeEnd = 334027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ref InheritedData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InheritedData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_InheritedData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x000946F8 File Offset: 0x000928F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334038, RefRangeEnd = 334039, XrefRangeStart = 334027, XrefRangeEnd = 334038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InheritedData lhs, InheritedData rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InheritedData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InheritedData_InheritedData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00094758 File Offset: 0x00092958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334040, RefRangeEnd = 334041, XrefRangeStart = 334039, XrefRangeEnd = 334040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(InheritedData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InheritedData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InheritedData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x000947B0 File Offset: 0x000929B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334041, XrefRangeEnd = 334045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InheritedData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00094804 File Offset: 0x00092A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334059, RefRangeEnd = 334060, XrefRangeStart = 334045, XrefRangeEnd = 334059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InheritedData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0000DAA2 File Offset: 0x0000BCA2
		public InheritedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0000DAAB File Offset: 0x0000BCAB
		public InheritedData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InheritedData>.NativeClassPtr))
		{
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x00094848 File Offset: 0x00092A48
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x0000DABD File Offset: 0x0000BCBD
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x00094870 File Offset: 0x00092A70
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		public unsafe Length fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_fontSize)) = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x00094898 File Offset: 0x00092A98
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x0000DAF3 File Offset: 0x0000BCF3
		public unsafe Length letterSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_letterSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_letterSpacing)) = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x000948C0 File Offset: 0x00092AC0
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x0000DB0E File Offset: 0x0000BD0E
		public unsafe TextShadow textShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_textShadow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_textShadow)) = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x000948E8 File Offset: 0x00092AE8
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x0000DB29 File Offset: 0x0000BD29
		public unsafe Font unityFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x00094918 File Offset: 0x00092B18
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x0000DB48 File Offset: 0x0000BD48
		public FontDefinition unityFontDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityFontDefinition);
				return new FontDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityFontDefinition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x00094948 File Offset: 0x00092B48
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x0000DB76 File Offset: 0x0000BD76
		public unsafe FontStyle unityFontStyleAndWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityFontStyleAndWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityFontStyleAndWeight)) = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x00094970 File Offset: 0x00092B70
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x0000DB91 File Offset: 0x0000BD91
		public unsafe Length unityParagraphSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityParagraphSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityParagraphSpacing)) = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x00094998 File Offset: 0x00092B98
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x0000DBAC File Offset: 0x0000BDAC
		public unsafe TextAnchor unityTextAlign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityTextAlign);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityTextAlign)) = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x000949C0 File Offset: 0x00092BC0
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x0000DBC7 File Offset: 0x0000BDC7
		public unsafe Color unityTextOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityTextOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityTextOutlineColor)) = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x000949E8 File Offset: 0x00092BE8
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x0000DBE2 File Offset: 0x0000BDE2
		public unsafe float unityTextOutlineWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityTextOutlineWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityTextOutlineWidth)) = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x00094A10 File Offset: 0x00092C10
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x0000DBFD File Offset: 0x0000BDFD
		public unsafe Visibility visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_visibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_visibility)) = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x00094A38 File Offset: 0x00092C38
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x0000DC18 File Offset: 0x0000BE18
		public unsafe WhiteSpace whiteSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_whiteSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_whiteSpace)) = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x00094A60 File Offset: 0x00092C60
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x0000DC33 File Offset: 0x0000BE33
		public unsafe Length wordSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_wordSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_wordSpacing)) = value;
			}
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00094A88 File Offset: 0x00092C88
		public static bool operator !=(InheritedData lhs, InheritedData rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeFieldInfoPtr_fontSize;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeFieldInfoPtr_letterSpacing;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeFieldInfoPtr_textShadow;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeFieldInfoPtr_unityFont;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeFieldInfoPtr_unityFontDefinition;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeFieldInfoPtr_unityFontStyleAndWeight;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeFieldInfoPtr_unityParagraphSpacing;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeFieldInfoPtr_unityTextAlign;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeFieldInfoPtr_unityTextOutlineColor;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeFieldInfoPtr_unityTextOutlineWidth;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeFieldInfoPtr_visibility;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeFieldInfoPtr_whiteSpace;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeFieldInfoPtr_wordSpacing;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_InheritedData_0;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_InheritedData_0;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InheritedData_InheritedData_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InheritedData_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
