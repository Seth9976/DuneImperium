using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000083 RID: 131
	public class RepeatButton : TextElement
	{
		// Token: 0x06000D02 RID: 3330 RVA: 0x0004AD44 File Offset: 0x00048F44
		// Note: this type is marked as 'beforefieldinit'.
		static RepeatButton()
		{
			Il2CppClassPointerStore<RepeatButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RepeatButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr);
			RepeatButton.NativeFieldInfoPtr_m_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr, "m_Clickable");
			RepeatButton.NativeFieldInfoPtr_m_AcceptClicksIfDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr, "m_AcceptClicksIfDisabled");
			RepeatButton.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr, "ussClassName");
			RepeatButton.NativeMethodInfoPtr_set_acceptClicksIfDisabled_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr, 100665167);
			RepeatButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr, 100665168);
			RepeatButton.NativeMethodInfoPtr__ctor_Public_Void_Action_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr, 100665169);
			RepeatButton.NativeMethodInfoPtr_SetAction_Public_Void_Action_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr, 100665170);
			RepeatButton.NativeMethodInfoPtr_AddAction_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr, 100665171);
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00006DD3 File Offset: 0x00004FD3
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x0004AE14 File Offset: 0x00049014
		public unsafe bool acceptClicksIfDisabled
		{
			get
			{
				return this.m_AcceptClicksIfDisabled;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303394, XrefRangeEnd = 303395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepeatButton.NativeMethodInfoPtr_set_acceptClicksIfDisabled_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0004AE54 File Offset: 0x00049054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303395, XrefRangeEnd = 303404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RepeatButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepeatButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0004AE90 File Offset: 0x00049090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303414, RefRangeEnd = 303416, XrefRangeStart = 303404, XrefRangeEnd = 303414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RepeatButton(Action clickEvent, long delay, long interval)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clickEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepeatButton.NativeMethodInfoPtr__ctor_Public_Void_Action_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0004AEF8 File Offset: 0x000490F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303430, RefRangeEnd = 303432, XrefRangeStart = 303416, XrefRangeEnd = 303430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAction(Action clickEvent, long delay, long interval)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clickEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepeatButton.NativeMethodInfoPtr_SetAction_Public_Void_Action_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0004AF58 File Offset: 0x00049158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303432, XrefRangeEnd = 303434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAction(Action clickEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clickEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepeatButton.NativeMethodInfoPtr_AddAction_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00006D7E File Offset: 0x00004F7E
		public RepeatButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x0004AF9C File Offset: 0x0004919C
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x00006D87 File Offset: 0x00004F87
		public unsafe Clickable m_Clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatButton.NativeFieldInfoPtr_m_Clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatButton.NativeFieldInfoPtr_m_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0004AFCC File Offset: 0x000491CC
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00006DA6 File Offset: 0x00004FA6
		public unsafe bool m_AcceptClicksIfDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatButton.NativeFieldInfoPtr_m_AcceptClicksIfDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatButton.NativeFieldInfoPtr_m_AcceptClicksIfDisabled)) = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0004AFF4 File Offset: 0x000491F4
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00006DC1 File Offset: 0x00004FC1
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RepeatButton.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RepeatButton.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_m_Clickable;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr_m_AcceptClicksIfDisabled;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_set_acceptClicksIfDisabled_Internal_set_Void_Boolean_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_Int64_Int64_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_SetAction_Public_Void_Action_Int64_Int64_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_AddAction_Internal_Void_Action_0;

		// Token: 0x020003B9 RID: 953
		public new class UxmlFactory : UxmlFactory<RepeatButton, RepeatButton.UxmlTraits>
		{
			// Token: 0x06003941 RID: 14657 RVA: 0x00018046 File Offset: 0x00016246
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<RepeatButton.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepeatButton.UxmlFactory>.NativeClassPtr);
				RepeatButton.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatButton.UxmlFactory>.NativeClassPtr, 100665173);
			}

			// Token: 0x06003942 RID: 14658 RVA: 0x000E8CEC File Offset: 0x000E6EEC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 303370, RefRangeEnd = 303371, XrefRangeStart = 303367, XrefRangeEnd = 303370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeatButton.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepeatButton.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003943 RID: 14659 RVA: 0x0001807A File Offset: 0x0001627A
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002887 RID: 10375
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003BA RID: 954
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x06003944 RID: 14660 RVA: 0x000E8D28 File Offset: 0x000E6F28
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<RepeatButton.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepeatButton>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepeatButton.UxmlTraits>.NativeClassPtr);
				RepeatButton.UxmlTraits.NativeFieldInfoPtr_m_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatButton.UxmlTraits>.NativeClassPtr, "m_Delay");
				RepeatButton.UxmlTraits.NativeFieldInfoPtr_m_Interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatButton.UxmlTraits>.NativeClassPtr, "m_Interval");
				RepeatButton.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatButton.UxmlTraits>.NativeClassPtr, 100665174);
				RepeatButton.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatButton.UxmlTraits>.NativeClassPtr, 100665175);
			}

			// Token: 0x06003945 RID: 14661 RVA: 0x000E8DA4 File Offset: 0x000E6FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303371, XrefRangeEnd = 303377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RepeatButton.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003946 RID: 14662 RVA: 0x000E8E1C File Offset: 0x000E701C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303377, XrefRangeEnd = 303394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeatButton.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepeatButton.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003947 RID: 14663 RVA: 0x00018083 File Offset: 0x00016283
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001196 RID: 4502
			// (get) Token: 0x06003948 RID: 14664 RVA: 0x000E8E58 File Offset: 0x000E7058
			// (set) Token: 0x06003949 RID: 14665 RVA: 0x0001808C File Offset: 0x0001628C
			public unsafe UxmlLongAttributeDescription m_Delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatButton.UxmlTraits.NativeFieldInfoPtr_m_Delay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlLongAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatButton.UxmlTraits.NativeFieldInfoPtr_m_Delay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001197 RID: 4503
			// (get) Token: 0x0600394A RID: 14666 RVA: 0x000E8E88 File Offset: 0x000E7088
			// (set) Token: 0x0600394B RID: 14667 RVA: 0x000180AB File Offset: 0x000162AB
			public unsafe UxmlLongAttributeDescription m_Interval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatButton.UxmlTraits.NativeFieldInfoPtr_m_Interval);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlLongAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatButton.UxmlTraits.NativeFieldInfoPtr_m_Interval), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002888 RID: 10376
			private static readonly IntPtr NativeFieldInfoPtr_m_Delay;

			// Token: 0x04002889 RID: 10377
			private static readonly IntPtr NativeFieldInfoPtr_m_Interval;

			// Token: 0x0400288A RID: 10378
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x0400288B RID: 10379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
