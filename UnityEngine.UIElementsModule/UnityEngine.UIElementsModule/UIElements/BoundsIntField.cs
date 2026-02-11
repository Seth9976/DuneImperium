using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004B RID: 75
	public class BoundsIntField : BaseField<BoundsInt>
	{
		// Token: 0x0600075D RID: 1885 RVA: 0x00037B7C File Offset: 0x00035D7C
		// Note: this type is marked as 'beforefieldinit'.
		static BoundsIntField()
		{
			Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BoundsIntField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr);
			BoundsIntField.NativeFieldInfoPtr_m_PositionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, "m_PositionField");
			BoundsIntField.NativeFieldInfoPtr_m_SizeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, "m_SizeField");
			BoundsIntField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, "ussClassName");
			BoundsIntField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, "labelUssClassName");
			BoundsIntField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, "inputUssClassName");
			BoundsIntField.NativeFieldInfoPtr_positionUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, "positionUssClassName");
			BoundsIntField.NativeFieldInfoPtr_sizeUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, "sizeUssClassName");
			BoundsIntField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, 100664302);
			BoundsIntField.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, 100664303);
			BoundsIntField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_BoundsInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, 100664304);
			BoundsIntField.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, 100664305);
			BoundsIntField.NativeMethodInfoPtr___ctor_b__10_0_Private_Void_ChangeEvent_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, 100664307);
			BoundsIntField.NativeMethodInfoPtr___ctor_b__10_1_Private_Void_ChangeEvent_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, 100664308);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00037CB0 File Offset: 0x00035EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291990, XrefRangeEnd = 291991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoundsIntField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsIntField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00037CEC File Offset: 0x00035EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292060, RefRangeEnd = 292061, XrefRangeStart = 291991, XrefRangeEnd = 292060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoundsIntField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsIntField.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00037D38 File Offset: 0x00035F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292061, XrefRangeEnd = 292069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(BoundsInt newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsIntField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_BoundsInt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00037D84 File Offset: 0x00035F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292069, XrefRangeEnd = 292111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsIntField.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00037DC0 File Offset: 0x00035FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292111, XrefRangeEnd = 292112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__10_0(ChangeEvent<Vector3Int> e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsIntField.NativeMethodInfoPtr___ctor_b__10_0_Private_Void_ChangeEvent_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00037E04 File Offset: 0x00036004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292112, XrefRangeEnd = 292113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__10_1(ChangeEvent<Vector3Int> e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsIntField.NativeMethodInfoPtr___ctor_b__10_1_Private_Void_ChangeEvent_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00004890 File Offset: 0x00002A90
		public BoundsIntField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00037E48 File Offset: 0x00036048
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00004899 File Offset: 0x00002A99
		public unsafe Vector3IntField m_PositionField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.NativeFieldInfoPtr_m_PositionField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3IntField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.NativeFieldInfoPtr_m_PositionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00037E78 File Offset: 0x00036078
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x000048B8 File Offset: 0x00002AB8
		public unsafe Vector3IntField m_SizeField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.NativeFieldInfoPtr_m_SizeField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3IntField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.NativeFieldInfoPtr_m_SizeField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00037EA8 File Offset: 0x000360A8
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x000048D7 File Offset: 0x00002AD7
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsIntField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsIntField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00037EC8 File Offset: 0x000360C8
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x000048E9 File Offset: 0x00002AE9
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsIntField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsIntField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00037EE8 File Offset: 0x000360E8
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x000048FB File Offset: 0x00002AFB
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsIntField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsIntField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00037F08 File Offset: 0x00036108
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x0000490D File Offset: 0x00002B0D
		public unsafe static string positionUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsIntField.NativeFieldInfoPtr_positionUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsIntField.NativeFieldInfoPtr_positionUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00037F28 File Offset: 0x00036128
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x0000491F File Offset: 0x00002B1F
		public unsafe static string sizeUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsIntField.NativeFieldInfoPtr_sizeUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsIntField.NativeFieldInfoPtr_sizeUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_m_PositionField;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_m_SizeField;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_positionUssClassName;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_sizeUssClassName;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_BoundsInt_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Private_Void_ChangeEvent_1_Vector3Int_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_1_Private_Void_ChangeEvent_1_Vector3Int_0;

		// Token: 0x02000343 RID: 835
		public new class UxmlFactory : UxmlFactory<BoundsIntField, BoundsIntField.UxmlTraits>
		{
			// Token: 0x0600363F RID: 13887 RVA: 0x00016301 File Offset: 0x00014501
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<BoundsIntField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsIntField.UxmlFactory>.NativeClassPtr);
				BoundsIntField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntField.UxmlFactory>.NativeClassPtr, 100664309);
			}

			// Token: 0x06003640 RID: 13888 RVA: 0x000E0220 File Offset: 0x000DE420
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 291937, RefRangeEnd = 291938, XrefRangeStart = 291934, XrefRangeEnd = 291937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsIntField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsIntField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003641 RID: 13889 RVA: 0x00016335 File Offset: 0x00014535
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040026E5 RID: 9957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000344 RID: 836
		public new class UxmlTraits : BaseField<BoundsInt>.UxmlTraits
		{
			// Token: 0x06003642 RID: 13890 RVA: 0x000E025C File Offset: 0x000DE45C
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoundsIntField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr);
				BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_PositionXValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr, "m_PositionXValue");
				BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_PositionYValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr, "m_PositionYValue");
				BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_PositionZValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr, "m_PositionZValue");
				BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_SizeXValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr, "m_SizeXValue");
				BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_SizeYValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr, "m_SizeYValue");
				BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_SizeZValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr, "m_SizeZValue");
				BoundsIntField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr, 100664310);
				BoundsIntField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr, 100664311);
			}

			// Token: 0x06003643 RID: 13891 RVA: 0x000E0328 File Offset: 0x000DE528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291938, XrefRangeEnd = 291943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsIntField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003644 RID: 13892 RVA: 0x000E03A0 File Offset: 0x000DE5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291943, XrefRangeEnd = 291990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsIntField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsIntField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003645 RID: 13893 RVA: 0x0001633E File Offset: 0x0001453E
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010D6 RID: 4310
			// (get) Token: 0x06003646 RID: 13894 RVA: 0x000E03DC File Offset: 0x000DE5DC
			// (set) Token: 0x06003647 RID: 13895 RVA: 0x00016347 File Offset: 0x00014547
			public unsafe UxmlIntAttributeDescription m_PositionXValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_PositionXValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_PositionXValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D7 RID: 4311
			// (get) Token: 0x06003648 RID: 13896 RVA: 0x000E040C File Offset: 0x000DE60C
			// (set) Token: 0x06003649 RID: 13897 RVA: 0x00016366 File Offset: 0x00014566
			public unsafe UxmlIntAttributeDescription m_PositionYValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_PositionYValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_PositionYValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D8 RID: 4312
			// (get) Token: 0x0600364A RID: 13898 RVA: 0x000E043C File Offset: 0x000DE63C
			// (set) Token: 0x0600364B RID: 13899 RVA: 0x00016385 File Offset: 0x00014585
			public unsafe UxmlIntAttributeDescription m_PositionZValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_PositionZValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_PositionZValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D9 RID: 4313
			// (get) Token: 0x0600364C RID: 13900 RVA: 0x000E046C File Offset: 0x000DE66C
			// (set) Token: 0x0600364D RID: 13901 RVA: 0x000163A4 File Offset: 0x000145A4
			public unsafe UxmlIntAttributeDescription m_SizeXValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_SizeXValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_SizeXValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010DA RID: 4314
			// (get) Token: 0x0600364E RID: 13902 RVA: 0x000E049C File Offset: 0x000DE69C
			// (set) Token: 0x0600364F RID: 13903 RVA: 0x000163C3 File Offset: 0x000145C3
			public unsafe UxmlIntAttributeDescription m_SizeYValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_SizeYValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_SizeYValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010DB RID: 4315
			// (get) Token: 0x06003650 RID: 13904 RVA: 0x000E04CC File Offset: 0x000DE6CC
			// (set) Token: 0x06003651 RID: 13905 RVA: 0x000163E2 File Offset: 0x000145E2
			public unsafe UxmlIntAttributeDescription m_SizeZValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_SizeZValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsIntField.UxmlTraits.NativeFieldInfoPtr_m_SizeZValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040026E6 RID: 9958
			private static readonly IntPtr NativeFieldInfoPtr_m_PositionXValue;

			// Token: 0x040026E7 RID: 9959
			private static readonly IntPtr NativeFieldInfoPtr_m_PositionYValue;

			// Token: 0x040026E8 RID: 9960
			private static readonly IntPtr NativeFieldInfoPtr_m_PositionZValue;

			// Token: 0x040026E9 RID: 9961
			private static readonly IntPtr NativeFieldInfoPtr_m_SizeXValue;

			// Token: 0x040026EA RID: 9962
			private static readonly IntPtr NativeFieldInfoPtr_m_SizeYValue;

			// Token: 0x040026EB RID: 9963
			private static readonly IntPtr NativeFieldInfoPtr_m_SizeZValue;

			// Token: 0x040026EC RID: 9964
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040026ED RID: 9965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
