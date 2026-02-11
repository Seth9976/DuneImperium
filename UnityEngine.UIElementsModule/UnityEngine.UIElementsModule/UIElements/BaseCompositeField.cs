using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003D RID: 61
	public class BaseCompositeField<TValueType, TField, TFieldValue> : BaseField<TValueType> where TField : TextValueField<TFieldValue>, new()
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x0002F444 File Offset: 0x0002D644
		// Note: this type is marked as 'beforefieldinit'.
		static BaseCompositeField()
		{
			Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseCompositeField`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TField>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFieldValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr);
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "m_Fields");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_ShouldUpdateDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "m_ShouldUpdateDisplay");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_ForceUpdateDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "m_ForceUpdateDisplay");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_PropertyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "m_PropertyIndex");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "ussClassName");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "labelUssClassName");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "inputUssClassName");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_spacerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "spacerUssClassName");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_multilineVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "multilineVariantUssClassName");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_fieldGroupUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "fieldGroupUssClassName");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_fieldUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "fieldUssClassName");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_firstFieldVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "firstFieldVariantUssClassName");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_twoLinesVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "twoLinesVariantUssClassName");
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_GetSpacer_Private_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, 100663992);
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_DescribeFields_Internal_Abstract_Virtual_New_Il2CppReferenceArray_1_FieldDescription_TValueType_TField_TFieldValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, 100663993);
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, 100663994);
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, 100663995);
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, 100663996);
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, 100663997);
			BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, 100663998);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0002F664 File Offset: 0x0002D864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288505, XrefRangeEnd = 288514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement GetSpacer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_GetSpacer_Private_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0002F6A4 File Offset: 0x0002D8A4
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription> DescribeFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_DescribeFields_Internal_Abstract_Virtual_New_Il2CppReferenceArray_1_FieldDescription_TValueType_TField_TFieldValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>>(intPtr3) : null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0002F6F0 File Offset: 0x0002D8F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288592, RefRangeEnd = 288594, XrefRangeStart = 288514, XrefRangeEnd = 288592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseCompositeField(string label, int fieldsByLine)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldsByLine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0002F74C File Offset: 0x0002D94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288594, XrefRangeEnd = 288597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0002F780 File Offset: 0x0002D980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288597, XrefRangeEnd = 288613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(TValueType newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValueType).IsValueType)
				{
					TValueType tvalueType = newValue;
					intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newValue;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0002F804 File Offset: 0x0002DA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288613, XrefRangeEnd = 288633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewDataReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0002F840 File Offset: 0x0002DA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288633, XrefRangeEnd = 288640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCompositeField<TValueType, TField, TFieldValue>.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000362A File Offset: 0x0000182A
		public BaseCompositeField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0002F87C File Offset: 0x0002DA7C
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00003633 File Offset: 0x00001833
		public unsafe List<TField> m_Fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_Fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_Fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0002F8AC File Offset: 0x0002DAAC
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00003652 File Offset: 0x00001852
		public unsafe bool m_ShouldUpdateDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_ShouldUpdateDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_ShouldUpdateDisplay)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0002F8D4 File Offset: 0x0002DAD4
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x0000366D File Offset: 0x0000186D
		public unsafe bool m_ForceUpdateDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_ForceUpdateDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_ForceUpdateDisplay)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0002F8FC File Offset: 0x0002DAFC
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00003688 File Offset: 0x00001888
		public unsafe int m_PropertyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_PropertyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_m_PropertyIndex)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0002F924 File Offset: 0x0002DB24
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x000036A3 File Offset: 0x000018A3
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0002F944 File Offset: 0x0002DB44
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x000036B5 File Offset: 0x000018B5
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0002F964 File Offset: 0x0002DB64
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x000036C7 File Offset: 0x000018C7
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0002F984 File Offset: 0x0002DB84
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x000036D9 File Offset: 0x000018D9
		public unsafe static string spacerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_spacerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_spacerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0002F9A4 File Offset: 0x0002DBA4
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x000036EB File Offset: 0x000018EB
		public unsafe static string multilineVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_multilineVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_multilineVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0002F9C4 File Offset: 0x0002DBC4
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x000036FD File Offset: 0x000018FD
		public unsafe static string fieldGroupUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_fieldGroupUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_fieldGroupUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0002F9E4 File Offset: 0x0002DBE4
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x0000370F File Offset: 0x0000190F
		public unsafe static string fieldUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_fieldUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_fieldUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0002FA04 File Offset: 0x0002DC04
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00003721 File Offset: 0x00001921
		public unsafe static string firstFieldVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_firstFieldVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_firstFieldVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0002FA24 File Offset: 0x0002DC24
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00003733 File Offset: 0x00001933
		public unsafe static string twoLinesVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_twoLinesVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseCompositeField<TValueType, TField, TFieldValue>.NativeFieldInfoPtr_twoLinesVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00003745 File Offset: 0x00001945
		public List<TField> fields
		{
			get
			{
				return this.m_Fields;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0000374D File Offset: 0x0000194D
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00003755 File Offset: 0x00001955
		public int propertyIndex
		{
			get
			{
				return this.m_PropertyIndex;
			}
			set
			{
				this.m_PropertyIndex = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0000375E File Offset: 0x0000195E
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00003766 File Offset: 0x00001966
		public bool forceUpdateDisplay
		{
			get
			{
				return this.m_ForceUpdateDisplay;
			}
			set
			{
				this.m_ForceUpdateDisplay = value;
			}
		}

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr_m_Fields;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldUpdateDisplay;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceUpdateDisplay;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyIndex;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_spacerUssClassName;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_multilineVariantUssClassName;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_fieldGroupUssClassName;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_fieldUssClassName;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_firstFieldVariantUssClassName;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_twoLinesVariantUssClassName;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_GetSpacer_Private_VisualElement_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_DescribeFields_Internal_Abstract_Virtual_New_Il2CppReferenceArray_1_FieldDescription_TValueType_TField_TFieldValue_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Private_Void_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x0200032F RID: 815
		public sealed class FieldDescription : ValueType
		{
			// Token: 0x0600358B RID: 13707 RVA: 0x000DDF20 File Offset: 0x000DC120
			// Note: this type is marked as 'beforefieldinit'.
			static FieldDescription()
			{
				Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "FieldDescription"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TField>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFieldValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr);
				BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr, "name");
				BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_ussName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr, "ussName");
				BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr, "read");
				BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_write = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr, "write");
				BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeMethodInfoPtr__ctor_Public_Void_String_String_Func_2_TValueType_TFieldValue_WriteDelegate_TValueType_TField_TFieldValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr, 100664000);
			}

			// Token: 0x0600358C RID: 13708 RVA: 0x000DE010 File Offset: 0x000DC210
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 288475, RefRangeEnd = 288497, XrefRangeStart = 288471, XrefRangeEnd = 288475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FieldDescription(string name, string ussName, Func<TValueType, TFieldValue> read, BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate write)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ussName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(read);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(write);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeMethodInfoPtr__ctor_Public_Void_String_String_Func_2_TValueType_TFieldValue_WriteDelegate_TValueType_TField_TFieldValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600358D RID: 13709 RVA: 0x00015C7F File Offset: 0x00013E7F
			public FieldDescription(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600358E RID: 13710 RVA: 0x00015C88 File Offset: 0x00013E88
			public FieldDescription()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr))
			{
			}

			// Token: 0x1700109E RID: 4254
			// (get) Token: 0x0600358F RID: 13711 RVA: 0x000DE098 File Offset: 0x000DC298
			// (set) Token: 0x06003590 RID: 13712 RVA: 0x00015C9A File Offset: 0x00013E9A
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700109F RID: 4255
			// (get) Token: 0x06003591 RID: 13713 RVA: 0x000DE0C0 File Offset: 0x000DC2C0
			// (set) Token: 0x06003592 RID: 13714 RVA: 0x00015CB9 File Offset: 0x00013EB9
			public unsafe string ussName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_ussName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_ussName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170010A0 RID: 4256
			// (get) Token: 0x06003593 RID: 13715 RVA: 0x000DE0E8 File Offset: 0x000DC2E8
			// (set) Token: 0x06003594 RID: 13716 RVA: 0x00015CD8 File Offset: 0x00013ED8
			public unsafe Func<TValueType, TFieldValue> read
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_read);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TValueType, TFieldValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_read), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A1 RID: 4257
			// (get) Token: 0x06003595 RID: 13717 RVA: 0x000DE118 File Offset: 0x000DC318
			// (set) Token: 0x06003596 RID: 13718 RVA: 0x00015CF7 File Offset: 0x00013EF7
			public unsafe BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate write
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_write);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.NativeFieldInfoPtr_write), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400267A RID: 9850
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400267B RID: 9851
			private static readonly IntPtr NativeFieldInfoPtr_ussName;

			// Token: 0x0400267C RID: 9852
			private static readonly IntPtr NativeFieldInfoPtr_read;

			// Token: 0x0400267D RID: 9853
			private static readonly IntPtr NativeFieldInfoPtr_write;

			// Token: 0x0400267E RID: 9854
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Func_2_TValueType_TFieldValue_WriteDelegate_TValueType_TField_TFieldValue_0;

			// Token: 0x02000585 RID: 1413
			public sealed class WriteDelegate : MulticastDelegate
			{
				// Token: 0x060042A7 RID: 17063 RVA: 0x001053EC File Offset: 0x001035EC
				// Note: this type is marked as 'beforefieldinit'.
				static WriteDelegate()
				{
					Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr, "WriteDelegate"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TField>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFieldValue>.NativeClassPtr))
					})).TypeHandle.value);
					BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate>.NativeClassPtr, 100664001);
					BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_TValueType_TFieldValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate>.NativeClassPtr, 100664002);
				}

				// Token: 0x060042A8 RID: 17064 RVA: 0x00105494 File Offset: 0x00103694
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 288458, RefRangeEnd = 288471, XrefRangeStart = 288454, XrefRangeEnd = 288458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe WriteDelegate(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042A9 RID: 17065 RVA: 0x001054F0 File Offset: 0x001036F0
				[CallerCount(0)]
				public unsafe void Invoke(ref TValueType val, TFieldValue fieldValue)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(val);
						ptr2 = &intPtr;
					}
					ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr2;
					if (!typeof(TFieldValue).IsValueType)
					{
						TFieldValue tfieldValue = fieldValue;
						intPtr2 = ((tfieldValue is string) ? IL2CPP.ManagedStringToIl2Cpp(tfieldValue as string) : IL2CPP.Il2CppObjectBaseToPtr(tfieldValue as Il2CppObjectBase));
					}
					else
					{
						intPtr2 = ref fieldValue;
					}
					ptr3 = intPtr2;
					IntPtr intPtr4;
					IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription.WriteDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_TValueType_TFieldValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
					Il2CppException.RaiseExceptionIfNecessary(intPtr4);
					IntPtr intPtr5 = intPtr;
					val = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValueType>(intPtr5, false, false));
				}

				// Token: 0x060042AA RID: 17066 RVA: 0x0001C77F File Offset: 0x0001A97F
				public WriteDelegate(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002EB0 RID: 11952
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002EB1 RID: 11953
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_TValueType_TFieldValue_0;
			}
		}

		// Token: 0x02000330 RID: 816
		[ObfuscatedName("UnityEngine.UIElements.BaseCompositeField`3+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Object
		{
			// Token: 0x06003597 RID: 13719 RVA: 0x000DE148 File Offset: 0x000DC348
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>>.NativeClassPtr, "<>c__DisplayClass24_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TField>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFieldValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0>.NativeClassPtr);
				BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0>.NativeClassPtr, "desc");
				BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0>.NativeClassPtr, "field");
				BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0>.NativeClassPtr, 100664003);
				BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeMethodInfoPtr___ctor_b__0_Internal_TFieldValue_TFieldValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0>.NativeClassPtr, 100664004);
				BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeMethodInfoPtr___ctor_b__1_Internal_Void_ChangeEvent_1_TFieldValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0>.NativeClassPtr, 100664005);
			}

			// Token: 0x06003598 RID: 13720 RVA: 0x000DE24C File Offset: 0x000DC44C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003599 RID: 13721 RVA: 0x000DE288 File Offset: 0x000DC488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288497, XrefRangeEnd = 288498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TFieldValue __ctor_b__0(TFieldValue newValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TFieldValue).IsValueType)
					{
						TFieldValue tfieldValue = newValue;
						intPtr = ((tfieldValue is string) ? IL2CPP.ManagedStringToIl2Cpp(tfieldValue as string) : IL2CPP.Il2CppObjectBaseToPtr(tfieldValue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref newValue;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeMethodInfoPtr___ctor_b__0_Internal_TFieldValue_TFieldValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TFieldValue>(intPtr2, false, true);
				}
			}

			// Token: 0x0600359A RID: 13722 RVA: 0x000DE308 File Offset: 0x000DC508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288498, XrefRangeEnd = 288505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__1(ChangeEvent<TFieldValue> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeMethodInfoPtr___ctor_b__1_Internal_Void_ChangeEvent_1_TFieldValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600359B RID: 13723 RVA: 0x00015D16 File Offset: 0x00013F16
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010A2 RID: 4258
			// (get) Token: 0x0600359C RID: 13724 RVA: 0x000DE34C File Offset: 0x000DC54C
			// (set) Token: 0x0600359D RID: 13725 RVA: 0x00015D1F File Offset: 0x00013F1F
			public BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription desc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeFieldInfoPtr_desc);
					return new BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeFieldInfoPtr_desc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BaseCompositeField<TValueType, TField, TFieldValue>.FieldDescription>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170010A3 RID: 4259
			// (get) Token: 0x0600359E RID: 13726 RVA: 0x000DE37C File Offset: 0x000DC57C
			// (set) Token: 0x0600359F RID: 13727 RVA: 0x000DE3A4 File Offset: 0x000DC5A4
			public unsafe TField field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeFieldInfoPtr_field);
					return IL2CPP.PointerToValueGeneric<TField>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeFieldInfoPtr_field);
					Type typeFromHandle = typeof(TField);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170010A4 RID: 4260
			// (get) Token: 0x060035A0 RID: 13728 RVA: 0x000DE44C File Offset: 0x000DC64C
			// (set) Token: 0x060035A1 RID: 13729 RVA: 0x00015D4D File Offset: 0x00013F4D
			public unsafe BaseCompositeField<TValueType, TField, TFieldValue> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<TValueType, TField, TFieldValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCompositeField<TValueType, TField, TFieldValue>.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400267F RID: 9855
			private static readonly IntPtr NativeFieldInfoPtr_desc;

			// Token: 0x04002680 RID: 9856
			private static readonly IntPtr NativeFieldInfoPtr_field;

			// Token: 0x04002681 RID: 9857
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002682 RID: 9858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002683 RID: 9859
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_TFieldValue_TFieldValue_0;

			// Token: 0x04002684 RID: 9860
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_Internal_Void_ChangeEvent_1_TFieldValue_0;
		}
	}
}
