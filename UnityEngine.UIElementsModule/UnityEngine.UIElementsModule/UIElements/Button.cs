using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004D RID: 77
	public class Button : TextElement
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x00037FFC File Offset: 0x000361FC
		// Note: this type is marked as 'beforefieldinit'.
		static Button()
		{
			Il2CppClassPointerStore<Button>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Button");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button>.NativeClassPtr);
			Button.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "ussClassName");
			Button.NativeFieldInfoPtr_m_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "m_Clickable");
			Button.NativeFieldInfoPtr_NonEmptyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "NonEmptyString");
			Button.NativeMethodInfoPtr_get_clickable_Public_get_Clickable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100664315);
			Button.NativeMethodInfoPtr_set_clickable_Public_set_Void_Clickable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100664316);
			Button.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100664317);
			Button.NativeMethodInfoPtr__ctor_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100664318);
			Button.NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100664319);
			Button.NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100664320);
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000380E0 File Offset: 0x000362E0
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00038120 File Offset: 0x00036320
		public unsafe Clickable clickable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_get_clickable_Public_get_Clickable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292132, XrefRangeEnd = 292136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_set_clickable_Public_set_Void_Clickable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00038164 File Offset: 0x00036364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292136, XrefRangeEnd = 292162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Button()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000381A0 File Offset: 0x000363A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292162, XrefRangeEnd = 292188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Button(Action clickEvent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clickEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr__ctor_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000381EC File Offset: 0x000363EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292188, XrefRangeEnd = 292204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00038230 File Offset: 0x00036430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292204, XrefRangeEnd = 292210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desiredWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Button.NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0000494C File Offset: 0x00002B4C
		public Button(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x000382B0 File Offset: 0x000364B0
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00004955 File Offset: 0x00002B55
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Button.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Button.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x000382D0 File Offset: 0x000364D0
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00004967 File Offset: 0x00002B67
		public unsafe Clickable m_Clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_m_Clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_m_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00038300 File Offset: 0x00036500
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00004986 File Offset: 0x00002B86
		public unsafe static string NonEmptyString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Button.NativeFieldInfoPtr_NonEmptyString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Button.NativeFieldInfoPtr_NonEmptyString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00004998 File Offset: 0x00002B98
		public void add_onClick(Action value)
		{
			this.add_clicked(value);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000049A3 File Offset: 0x00002BA3
		public void remove_onClick(Action value)
		{
			this.remove_clicked(value);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00038320 File Offset: 0x00036520
		public void add_clicked(Action value)
		{
			bool flag = this.m_Clickable == null;
			if (flag)
			{
				this.clickable = new Clickable(value);
			}
			else
			{
				this.m_Clickable.add_clicked(value);
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0003835C File Offset: 0x0003655C
		public void remove_clicked(Action value)
		{
			bool flag = this.m_Clickable != null;
			if (flag)
			{
				this.m_Clickable.remove_clicked(value);
			}
		}

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_m_Clickable;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_NonEmptyString;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_get_clickable_Public_get_Clickable_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_set_clickable_Public_set_Void_Clickable_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0;

		// Token: 0x02000346 RID: 838
		public new class UxmlFactory : UxmlFactory<Button, Button.UxmlTraits>
		{
			// Token: 0x06003655 RID: 13909 RVA: 0x0001643E File Offset: 0x0001463E
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Button.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Button>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button.UxmlFactory>.NativeClassPtr);
				Button.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button.UxmlFactory>.NativeClassPtr, 100664322);
			}

			// Token: 0x06003656 RID: 13910 RVA: 0x000E0538 File Offset: 0x000DE738
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292129, RefRangeEnd = 292130, XrefRangeStart = 292126, XrefRangeEnd = 292129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003657 RID: 13911 RVA: 0x00016472 File Offset: 0x00014672
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040026EF RID: 9967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000347 RID: 839
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x06003658 RID: 13912 RVA: 0x0001647B File Offset: 0x0001467B
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Button.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Button>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button.UxmlTraits>.NativeClassPtr);
				Button.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button.UxmlTraits>.NativeClassPtr, 100664323);
			}

			// Token: 0x06003659 RID: 13913 RVA: 0x000E0574 File Offset: 0x000DE774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292130, XrefRangeEnd = 292132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600365A RID: 13914 RVA: 0x000164AF File Offset: 0x000146AF
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040026F0 RID: 9968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
