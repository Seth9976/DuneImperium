using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005E RID: 94
	public class GroupBox : BindableElement
	{
		// Token: 0x060008B2 RID: 2226 RVA: 0x0003BDFC File Offset: 0x00039FFC
		// Note: this type is marked as 'beforefieldinit'.
		static GroupBox()
		{
			Il2CppClassPointerStore<GroupBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "GroupBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupBox>.NativeClassPtr);
			GroupBox.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupBox>.NativeClassPtr, "ussClassName");
			GroupBox.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupBox>.NativeClassPtr, "labelUssClassName");
			GroupBox.NativeFieldInfoPtr_m_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupBox>.NativeClassPtr, "m_TitleLabel");
			GroupBox.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBox>.NativeClassPtr, 100664550);
			GroupBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBox>.NativeClassPtr, 100664551);
			GroupBox.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBox>.NativeClassPtr, 100664552);
			GroupBox.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionAdded_Private_Virtual_Final_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBox>.NativeClassPtr, 100664553);
			GroupBox.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionRemoved_Private_Virtual_Final_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBox>.NativeClassPtr, 100664554);
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00005145 File Offset: 0x00003345
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x0003BECC File Offset: 0x0003A0CC
		public unsafe string text
		{
			get
			{
				Label titleLabel = this.m_TitleLabel;
				return (titleLabel != null) ? titleLabel.text : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295016, RefRangeEnd = 295019, XrefRangeStart = 295002, XrefRangeEnd = 295016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupBox.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0003BF10 File Offset: 0x0003A110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295019, XrefRangeEnd = 295026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupBox()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupBox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0003BF4C File Offset: 0x0003A14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295026, XrefRangeEnd = 295033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupBox(string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupBox>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupBox.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0003BF98 File Offset: 0x0003A198
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_IGroupBox_OnOptionAdded(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupBox.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionAdded_Private_Virtual_Final_New_Void_IGroupBoxOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0003BFDC File Offset: 0x0003A1DC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_IGroupBox_OnOptionRemoved(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupBox.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionRemoved_Private_Virtual_Final_New_Void_IGroupBoxOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000050F1 File Offset: 0x000032F1
		public GroupBox(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0003C020 File Offset: 0x0003A220
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x000050FA File Offset: 0x000032FA
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GroupBox.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GroupBox.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0003C040 File Offset: 0x0003A240
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x0000510C File Offset: 0x0000330C
		public unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GroupBox.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GroupBox.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0003C060 File Offset: 0x0003A260
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x0000511E File Offset: 0x0000331E
		public unsafe Label m_TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupBox.NativeFieldInfoPtr_m_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Label>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupBox.NativeFieldInfoPtr_m_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0000513D File Offset: 0x0000333D
		public Label titleLabel
		{
			get
			{
				return this.m_TitleLabel;
			}
		}

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr_m_TitleLabel;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionAdded_Private_Virtual_Final_New_Void_IGroupBoxOption_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionRemoved_Private_Virtual_Final_New_Void_IGroupBoxOption_0;

		// Token: 0x02000379 RID: 889
		public new class UxmlFactory : UxmlFactory<GroupBox, GroupBox.UxmlTraits>
		{
			// Token: 0x060037BF RID: 14271 RVA: 0x00017153 File Offset: 0x00015353
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<GroupBox.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GroupBox>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupBox.UxmlFactory>.NativeClassPtr);
				GroupBox.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBox.UxmlFactory>.NativeClassPtr, 100664556);
			}

			// Token: 0x060037C0 RID: 14272 RVA: 0x000E4404 File Offset: 0x000E2604
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 294985, RefRangeEnd = 294986, XrefRangeStart = 294982, XrefRangeEnd = 294985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupBox.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupBox.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037C1 RID: 14273 RVA: 0x00017187 File Offset: 0x00015387
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040027B0 RID: 10160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200037A RID: 890
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x060037C2 RID: 14274 RVA: 0x000E4440 File Offset: 0x000E2640
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<GroupBox.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GroupBox>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupBox.UxmlTraits>.NativeClassPtr);
				GroupBox.UxmlTraits.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupBox.UxmlTraits>.NativeClassPtr, "m_Text");
				GroupBox.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBox.UxmlTraits>.NativeClassPtr, 100664557);
				GroupBox.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupBox.UxmlTraits>.NativeClassPtr, 100664558);
			}

			// Token: 0x060037C3 RID: 14275 RVA: 0x000E44A8 File Offset: 0x000E26A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294986, XrefRangeEnd = 294992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupBox.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037C4 RID: 14276 RVA: 0x000E4520 File Offset: 0x000E2720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294992, XrefRangeEnd = 295002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupBox.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupBox.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037C5 RID: 14277 RVA: 0x00017190 File Offset: 0x00015390
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001138 RID: 4408
			// (get) Token: 0x060037C6 RID: 14278 RVA: 0x000E455C File Offset: 0x000E275C
			// (set) Token: 0x060037C7 RID: 14279 RVA: 0x00017199 File Offset: 0x00015399
			public unsafe UxmlStringAttributeDescription m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupBox.UxmlTraits.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupBox.UxmlTraits.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027B1 RID: 10161
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x040027B2 RID: 10162
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040027B3 RID: 10163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
