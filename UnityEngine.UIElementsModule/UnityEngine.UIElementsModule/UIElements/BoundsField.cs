using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004A RID: 74
	public class BoundsField : BaseField<Bounds>
	{
		// Token: 0x06000747 RID: 1863 RVA: 0x000377B0 File Offset: 0x000359B0
		// Note: this type is marked as 'beforefieldinit'.
		static BoundsField()
		{
			Il2CppClassPointerStore<BoundsField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BoundsField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsField>.NativeClassPtr);
			BoundsField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, "ussClassName");
			BoundsField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, "labelUssClassName");
			BoundsField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, "inputUssClassName");
			BoundsField.NativeFieldInfoPtr_centerFieldUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, "centerFieldUssClassName");
			BoundsField.NativeFieldInfoPtr_extentsFieldUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, "extentsFieldUssClassName");
			BoundsField.NativeFieldInfoPtr_m_CenterField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, "m_CenterField");
			BoundsField.NativeFieldInfoPtr_m_ExtentsField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, "m_ExtentsField");
			BoundsField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, 100664292);
			BoundsField.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, 100664293);
			BoundsField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, 100664294);
			BoundsField.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, 100664295);
			BoundsField.NativeMethodInfoPtr___ctor_b__10_0_Private_Void_ChangeEvent_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, 100664297);
			BoundsField.NativeMethodInfoPtr___ctor_b__10_1_Private_Void_ChangeEvent_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, 100664298);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000378E4 File Offset: 0x00035AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291811, XrefRangeEnd = 291812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoundsField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00037920 File Offset: 0x00035B20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291881, RefRangeEnd = 291882, XrefRangeStart = 291812, XrefRangeEnd = 291881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoundsField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsField>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsField.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0003796C File Offset: 0x00035B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291882, XrefRangeEnd = 291890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(Bounds newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000379B8 File Offset: 0x00035BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291890, XrefRangeEnd = 291932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsField.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000379F4 File Offset: 0x00035BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291932, XrefRangeEnd = 291933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__10_0(ChangeEvent<Vector3> e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsField.NativeMethodInfoPtr___ctor_b__10_0_Private_Void_ChangeEvent_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00037A38 File Offset: 0x00035C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291933, XrefRangeEnd = 291934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__10_1(ChangeEvent<Vector3> e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsField.NativeMethodInfoPtr___ctor_b__10_1_Private_Void_ChangeEvent_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000047EF File Offset: 0x000029EF
		public BoundsField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00037A7C File Offset: 0x00035C7C
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x000047F8 File Offset: 0x000029F8
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00037A9C File Offset: 0x00035C9C
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x0000480A File Offset: 0x00002A0A
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00037ABC File Offset: 0x00035CBC
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x0000481C File Offset: 0x00002A1C
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00037ADC File Offset: 0x00035CDC
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x0000482E File Offset: 0x00002A2E
		public unsafe static string centerFieldUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsField.NativeFieldInfoPtr_centerFieldUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsField.NativeFieldInfoPtr_centerFieldUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00037AFC File Offset: 0x00035CFC
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00004840 File Offset: 0x00002A40
		public unsafe static string extentsFieldUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsField.NativeFieldInfoPtr_extentsFieldUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsField.NativeFieldInfoPtr_extentsFieldUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00037B1C File Offset: 0x00035D1C
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00004852 File Offset: 0x00002A52
		public unsafe Vector3Field m_CenterField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.NativeFieldInfoPtr_m_CenterField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3Field>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.NativeFieldInfoPtr_m_CenterField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00037B4C File Offset: 0x00035D4C
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00004871 File Offset: 0x00002A71
		public unsafe Vector3Field m_ExtentsField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.NativeFieldInfoPtr_m_ExtentsField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3Field>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.NativeFieldInfoPtr_m_ExtentsField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_centerFieldUssClassName;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_extentsFieldUssClassName;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_m_CenterField;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtentsField;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Bounds_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Private_Void_ChangeEvent_1_Vector3_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_1_Private_Void_ChangeEvent_1_Vector3_0;

		// Token: 0x02000341 RID: 833
		public new class UxmlFactory : UxmlFactory<BoundsField, BoundsField.UxmlTraits>
		{
			// Token: 0x0600362C RID: 13868 RVA: 0x00016201 File Offset: 0x00014401
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<BoundsField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsField.UxmlFactory>.NativeClassPtr);
				BoundsField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsField.UxmlFactory>.NativeClassPtr, 100664299);
			}

			// Token: 0x0600362D RID: 13869 RVA: 0x000DFF44 File Offset: 0x000DE144
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 291758, RefRangeEnd = 291759, XrefRangeStart = 291755, XrefRangeEnd = 291758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600362E RID: 13870 RVA: 0x00016235 File Offset: 0x00014435
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040026DC RID: 9948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000342 RID: 834
		public new class UxmlTraits : BaseField<Bounds>.UxmlTraits
		{
			// Token: 0x0600362F RID: 13871 RVA: 0x000DFF80 File Offset: 0x000DE180
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoundsField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr);
				BoundsField.UxmlTraits.NativeFieldInfoPtr_m_CenterXValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr, "m_CenterXValue");
				BoundsField.UxmlTraits.NativeFieldInfoPtr_m_CenterYValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr, "m_CenterYValue");
				BoundsField.UxmlTraits.NativeFieldInfoPtr_m_CenterZValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr, "m_CenterZValue");
				BoundsField.UxmlTraits.NativeFieldInfoPtr_m_ExtentsXValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr, "m_ExtentsXValue");
				BoundsField.UxmlTraits.NativeFieldInfoPtr_m_ExtentsYValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr, "m_ExtentsYValue");
				BoundsField.UxmlTraits.NativeFieldInfoPtr_m_ExtentsZValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr, "m_ExtentsZValue");
				BoundsField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr, 100664300);
				BoundsField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr, 100664301);
			}

			// Token: 0x06003630 RID: 13872 RVA: 0x000E004C File Offset: 0x000DE24C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291759, XrefRangeEnd = 291764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003631 RID: 13873 RVA: 0x000E00C4 File Offset: 0x000DE2C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291764, XrefRangeEnd = 291811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003632 RID: 13874 RVA: 0x0001623E File Offset: 0x0001443E
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010D0 RID: 4304
			// (get) Token: 0x06003633 RID: 13875 RVA: 0x000E0100 File Offset: 0x000DE300
			// (set) Token: 0x06003634 RID: 13876 RVA: 0x00016247 File Offset: 0x00014447
			public unsafe UxmlFloatAttributeDescription m_CenterXValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_CenterXValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_CenterXValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D1 RID: 4305
			// (get) Token: 0x06003635 RID: 13877 RVA: 0x000E0130 File Offset: 0x000DE330
			// (set) Token: 0x06003636 RID: 13878 RVA: 0x00016266 File Offset: 0x00014466
			public unsafe UxmlFloatAttributeDescription m_CenterYValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_CenterYValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_CenterYValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D2 RID: 4306
			// (get) Token: 0x06003637 RID: 13879 RVA: 0x000E0160 File Offset: 0x000DE360
			// (set) Token: 0x06003638 RID: 13880 RVA: 0x00016285 File Offset: 0x00014485
			public unsafe UxmlFloatAttributeDescription m_CenterZValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_CenterZValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_CenterZValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D3 RID: 4307
			// (get) Token: 0x06003639 RID: 13881 RVA: 0x000E0190 File Offset: 0x000DE390
			// (set) Token: 0x0600363A RID: 13882 RVA: 0x000162A4 File Offset: 0x000144A4
			public unsafe UxmlFloatAttributeDescription m_ExtentsXValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_ExtentsXValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_ExtentsXValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D4 RID: 4308
			// (get) Token: 0x0600363B RID: 13883 RVA: 0x000E01C0 File Offset: 0x000DE3C0
			// (set) Token: 0x0600363C RID: 13884 RVA: 0x000162C3 File Offset: 0x000144C3
			public unsafe UxmlFloatAttributeDescription m_ExtentsYValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_ExtentsYValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_ExtentsYValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D5 RID: 4309
			// (get) Token: 0x0600363D RID: 13885 RVA: 0x000E01F0 File Offset: 0x000DE3F0
			// (set) Token: 0x0600363E RID: 13886 RVA: 0x000162E2 File Offset: 0x000144E2
			public unsafe UxmlFloatAttributeDescription m_ExtentsZValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_ExtentsZValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsField.UxmlTraits.NativeFieldInfoPtr_m_ExtentsZValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040026DD RID: 9949
			private static readonly IntPtr NativeFieldInfoPtr_m_CenterXValue;

			// Token: 0x040026DE RID: 9950
			private static readonly IntPtr NativeFieldInfoPtr_m_CenterYValue;

			// Token: 0x040026DF RID: 9951
			private static readonly IntPtr NativeFieldInfoPtr_m_CenterZValue;

			// Token: 0x040026E0 RID: 9952
			private static readonly IntPtr NativeFieldInfoPtr_m_ExtentsXValue;

			// Token: 0x040026E1 RID: 9953
			private static readonly IntPtr NativeFieldInfoPtr_m_ExtentsYValue;

			// Token: 0x040026E2 RID: 9954
			private static readonly IntPtr NativeFieldInfoPtr_m_ExtentsZValue;

			// Token: 0x040026E3 RID: 9955
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040026E4 RID: 9956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
