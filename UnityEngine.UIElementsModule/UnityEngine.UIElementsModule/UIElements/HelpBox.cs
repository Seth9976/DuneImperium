using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000061 RID: 97
	public class HelpBox : VisualElement
	{
		// Token: 0x060008D4 RID: 2260 RVA: 0x0003C50C File Offset: 0x0003A70C
		// Note: this type is marked as 'beforefieldinit'.
		static HelpBox()
		{
			Il2CppClassPointerStore<HelpBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "HelpBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpBox>.NativeClassPtr);
			HelpBox.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "ussClassName");
			HelpBox.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "labelUssClassName");
			HelpBox.NativeFieldInfoPtr_iconUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "iconUssClassName");
			HelpBox.NativeFieldInfoPtr_iconInfoUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "iconInfoUssClassName");
			HelpBox.NativeFieldInfoPtr_iconwarningUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "iconwarningUssClassName");
			HelpBox.NativeFieldInfoPtr_iconErrorUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "iconErrorUssClassName");
			HelpBox.NativeFieldInfoPtr_m_HelpBoxMessageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "m_HelpBoxMessageType");
			HelpBox.NativeFieldInfoPtr_m_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "m_Icon");
			HelpBox.NativeFieldInfoPtr_m_IconClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "m_IconClass");
			HelpBox.NativeFieldInfoPtr_m_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "m_Label");
			HelpBox.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, 100664577);
			HelpBox.NativeMethodInfoPtr_set_messageType_Public_set_Void_HelpBoxMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, 100664578);
			HelpBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, 100664579);
			HelpBox.NativeMethodInfoPtr__ctor_Public_Void_String_HelpBoxMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, 100664580);
			HelpBox.NativeMethodInfoPtr_GetIconClass_Private_String_HelpBoxMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, 100664581);
			HelpBox.NativeMethodInfoPtr_UpdateIcon_Private_Void_HelpBoxMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, 100664582);
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0003C98C File Offset: 0x0003AB8C
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x0003C67C File Offset: 0x0003A87C
		public unsafe string text
		{
			get
			{
				return this.m_Label.text;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295223, RefRangeEnd = 295224, XrefRangeStart = 295222, XrefRangeEnd = 295223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpBox.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0003C9AC File Offset: 0x0003ABAC
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x0003C6C0 File Offset: 0x0003A8C0
		public unsafe HelpBoxMessageType messageType
		{
			get
			{
				return this.m_HelpBoxMessageType;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295225, RefRangeEnd = 295226, XrefRangeStart = 295224, XrefRangeEnd = 295225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpBox.NativeMethodInfoPtr_set_messageType_Public_set_Void_HelpBoxMessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0003C700 File Offset: 0x0003A900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295226, XrefRangeEnd = 295253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpBox()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpBox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0003C73C File Offset: 0x0003A93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295253, XrefRangeEnd = 295278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpBox(string text, HelpBoxMessageType messageType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpBox>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpBox.NativeMethodInfoPtr__ctor_Public_Void_String_HelpBoxMessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0003C798 File Offset: 0x0003A998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295278, XrefRangeEnd = 295279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetIconClass(HelpBoxMessageType messageType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpBox.NativeMethodInfoPtr_GetIconClass_Private_String_HelpBoxMessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0003C7DC File Offset: 0x0003A9DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295298, RefRangeEnd = 295301, XrefRangeStart = 295279, XrefRangeEnd = 295298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIcon(HelpBoxMessageType messageType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpBox.NativeMethodInfoPtr_UpdateIcon_Private_Void_HelpBoxMessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000051A5 File Offset: 0x000033A5
		public HelpBox(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0003C81C File Offset: 0x0003AA1C
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x000051AE File Offset: 0x000033AE
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HelpBox.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HelpBox.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0003C83C File Offset: 0x0003AA3C
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x000051C0 File Offset: 0x000033C0
		public unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HelpBox.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HelpBox.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0003C85C File Offset: 0x0003AA5C
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x000051D2 File Offset: 0x000033D2
		public unsafe static string iconUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HelpBox.NativeFieldInfoPtr_iconUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HelpBox.NativeFieldInfoPtr_iconUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0003C87C File Offset: 0x0003AA7C
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x000051E4 File Offset: 0x000033E4
		public unsafe static string iconInfoUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HelpBox.NativeFieldInfoPtr_iconInfoUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HelpBox.NativeFieldInfoPtr_iconInfoUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0003C89C File Offset: 0x0003AA9C
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x000051F6 File Offset: 0x000033F6
		public unsafe static string iconwarningUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HelpBox.NativeFieldInfoPtr_iconwarningUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HelpBox.NativeFieldInfoPtr_iconwarningUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0003C8BC File Offset: 0x0003AABC
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00005208 File Offset: 0x00003408
		public unsafe static string iconErrorUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HelpBox.NativeFieldInfoPtr_iconErrorUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HelpBox.NativeFieldInfoPtr_iconErrorUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0003C8DC File Offset: 0x0003AADC
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x0000521A File Offset: 0x0000341A
		public unsafe HelpBoxMessageType m_HelpBoxMessageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.NativeFieldInfoPtr_m_HelpBoxMessageType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.NativeFieldInfoPtr_m_HelpBoxMessageType)) = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0003C904 File Offset: 0x0003AB04
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00005235 File Offset: 0x00003435
		public unsafe VisualElement m_Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.NativeFieldInfoPtr_m_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.NativeFieldInfoPtr_m_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0003C934 File Offset: 0x0003AB34
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00005254 File Offset: 0x00003454
		public unsafe string m_IconClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.NativeFieldInfoPtr_m_IconClass);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.NativeFieldInfoPtr_m_IconClass), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0003C95C File Offset: 0x0003AB5C
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00005273 File Offset: 0x00003473
		public unsafe Label m_Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.NativeFieldInfoPtr_m_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Label>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.NativeFieldInfoPtr_m_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr_iconUssClassName;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeFieldInfoPtr_iconInfoUssClassName;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeFieldInfoPtr_iconwarningUssClassName;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeFieldInfoPtr_iconErrorUssClassName;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeFieldInfoPtr_m_HelpBoxMessageType;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeFieldInfoPtr_m_Icon;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr_m_IconClass;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeFieldInfoPtr_m_Label;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_set_messageType_Public_set_Void_HelpBoxMessageType_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_HelpBoxMessageType_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_GetIconClass_Private_String_HelpBoxMessageType_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIcon_Private_Void_HelpBoxMessageType_0;

		// Token: 0x0200037E RID: 894
		public new class UxmlFactory : UxmlFactory<HelpBox, HelpBox.UxmlTraits>
		{
			// Token: 0x060037D5 RID: 14293 RVA: 0x0001723B File Offset: 0x0001543B
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<HelpBox.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpBox.UxmlFactory>.NativeClassPtr);
				HelpBox.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBox.UxmlFactory>.NativeClassPtr, 100664584);
			}

			// Token: 0x060037D6 RID: 14294 RVA: 0x000E47F8 File Offset: 0x000E29F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295173, RefRangeEnd = 295174, XrefRangeStart = 295170, XrefRangeEnd = 295173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpBox.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpBox.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037D7 RID: 14295 RVA: 0x0001726F File Offset: 0x0001546F
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040027BB RID: 10171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200037F RID: 895
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x060037D8 RID: 14296 RVA: 0x000E4834 File Offset: 0x000E2A34
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<HelpBox.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HelpBox>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpBox.UxmlTraits>.NativeClassPtr);
				HelpBox.UxmlTraits.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox.UxmlTraits>.NativeClassPtr, "m_Text");
				HelpBox.UxmlTraits.NativeFieldInfoPtr_m_MessageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBox.UxmlTraits>.NativeClassPtr, "m_MessageType");
				HelpBox.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBox.UxmlTraits>.NativeClassPtr, 100664585);
				HelpBox.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBox.UxmlTraits>.NativeClassPtr, 100664586);
			}

			// Token: 0x060037D9 RID: 14297 RVA: 0x000E48B0 File Offset: 0x000E2AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295174, XrefRangeEnd = 295201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HelpBox.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037DA RID: 14298 RVA: 0x000E4928 File Offset: 0x000E2B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295201, XrefRangeEnd = 295222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpBox.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpBox.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037DB RID: 14299 RVA: 0x00017278 File Offset: 0x00015478
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700113A RID: 4410
			// (get) Token: 0x060037DC RID: 14300 RVA: 0x000E4964 File Offset: 0x000E2B64
			// (set) Token: 0x060037DD RID: 14301 RVA: 0x00017281 File Offset: 0x00015481
			public unsafe UxmlStringAttributeDescription m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.UxmlTraits.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.UxmlTraits.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700113B RID: 4411
			// (get) Token: 0x060037DE RID: 14302 RVA: 0x000E4994 File Offset: 0x000E2B94
			// (set) Token: 0x060037DF RID: 14303 RVA: 0x000172A0 File Offset: 0x000154A0
			public unsafe UxmlEnumAttributeDescription<HelpBoxMessageType> m_MessageType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.UxmlTraits.NativeFieldInfoPtr_m_MessageType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<HelpBoxMessageType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBox.UxmlTraits.NativeFieldInfoPtr_m_MessageType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027BC RID: 10172
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x040027BD RID: 10173
			private static readonly IntPtr NativeFieldInfoPtr_m_MessageType;

			// Token: 0x040027BE RID: 10174
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040027BF RID: 10175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
