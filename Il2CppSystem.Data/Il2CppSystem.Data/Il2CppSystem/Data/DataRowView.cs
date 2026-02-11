using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Data
{
	// Token: 0x0200003C RID: 60
	[DefaultMember("Item")]
	public class DataRowView : Object
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x00026724 File Offset: 0x00024924
		// Note: this type is marked as 'beforefieldinit'.
		static DataRowView()
		{
			Il2CppClassPointerStore<DataRowView>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataRowView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRowView>.NativeClassPtr);
			DataRowView.NativeFieldInfoPtr__dataView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, "_dataView");
			DataRowView.NativeFieldInfoPtr__row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, "_row");
			DataRowView.NativeFieldInfoPtr__delayBeginEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, "_delayBeginEdit");
			DataRowView.NativeFieldInfoPtr_s_zeroPropertyDescriptorCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, "s_zeroPropertyDescriptorCollection");
			DataRowView.NativeFieldInfoPtr_PropertyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, "PropertyChanged");
			DataRowView.NativeMethodInfoPtr__ctor_Internal_Void_DataView_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664457);
			DataRowView.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664458);
			DataRowView.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664459);
			DataRowView.NativeMethodInfoPtr_get_DataView_Public_get_DataView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664460);
			DataRowView.NativeMethodInfoPtr_get_RowVersionDefault_Private_get_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664461);
			DataRowView.NativeMethodInfoPtr_GetRecord_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664462);
			DataRowView.NativeMethodInfoPtr_HasRecord_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664463);
			DataRowView.NativeMethodInfoPtr_GetColumnValue_Internal_Object_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664464);
			DataRowView.NativeMethodInfoPtr_SetColumnValue_Internal_Void_DataColumn_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664465);
			DataRowView.NativeMethodInfoPtr_CreateChildView_Public_DataView_DataRelation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664466);
			DataRowView.NativeMethodInfoPtr_CreateChildView_Public_DataView_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664467);
			DataRowView.NativeMethodInfoPtr_get_Row_Public_get_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664468);
			DataRowView.NativeMethodInfoPtr_EndEdit_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664469);
			DataRowView.NativeMethodInfoPtr_get_IsNew_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664470);
			DataRowView.NativeMethodInfoPtr_RaisePropertyChangedEvent_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664471);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664472);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664473);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664474);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664475);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664476);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664477);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664478);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664479);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664480);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664481);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664482);
			DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowView>.NativeClassPtr, 100664483);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000269D4 File Offset: 0x00024BD4
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowView(DataView dataView, DataRow row)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRowView>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataView);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(row);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr__ctor_Internal_Void_DataView_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00026A34 File Offset: 0x00024C34
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRowView.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00026A8C File Offset: 0x00024C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901286, XrefRangeEnd = 901287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRowView.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00026AD4 File Offset: 0x00024CD4
		public unsafe DataView DataView
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_get_DataView_Public_get_DataView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataView>(intPtr3) : null;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00026B14 File Offset: 0x00024D14
		public unsafe DataRowVersion RowVersionDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_get_RowVersionDefault_Private_get_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00026B50 File Offset: 0x00024D50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901291, RefRangeEnd = 901292, XrefRangeStart = 901287, XrefRangeEnd = 901291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRecord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_GetRecord_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00026B8C File Offset: 0x00024D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901296, RefRangeEnd = 901297, XrefRangeStart = 901292, XrefRangeEnd = 901296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasRecord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_HasRecord_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00026BC8 File Offset: 0x00024DC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901313, RefRangeEnd = 901315, XrefRangeStart = 901297, XrefRangeEnd = 901313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetColumnValue(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_GetColumnValue_Internal_Object_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00026C18 File Offset: 0x00024E18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901323, RefRangeEnd = 901325, XrefRangeStart = 901315, XrefRangeEnd = 901323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColumnValue(DataColumn column, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_SetColumnValue_Internal_Void_DataColumn_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00026C6C File Offset: 0x00024E6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901345, RefRangeEnd = 901347, XrefRangeStart = 901325, XrefRangeEnd = 901345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataView CreateChildView(DataRelation relation, bool followParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref followParent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_CreateChildView_Public_DataView_DataRelation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataView>(intPtr3) : null;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00026CCC File Offset: 0x00024ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901347, XrefRangeEnd = 901348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataView CreateChildView(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_CreateChildView_Public_DataView_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataView>(intPtr3) : null;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00026D1C File Offset: 0x00024F1C
		public unsafe DataRow Row
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_get_Row_Public_get_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00026D5C File Offset: 0x00024F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901349, RefRangeEnd = 901350, XrefRangeStart = 901348, XrefRangeEnd = 901349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_EndEdit_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00026D90 File Offset: 0x00024F90
		public unsafe bool IsNew
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_get_IsNew_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00026DCC File Offset: 0x00024FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901354, RefRangeEnd = 901355, XrefRangeStart = 901350, XrefRangeEnd = 901354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaisePropertyChangedEvent(string propName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_RaisePropertyChangedEvent_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00026E10 File Offset: 0x00025010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901355, XrefRangeEnd = 901359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AttributeCollection System_ComponentModel_ICustomTypeDescriptor_GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00026E50 File Offset: 0x00025050
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_ComponentModel_ICustomTypeDescriptor_GetClassName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00026E88 File Offset: 0x00025088
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_ComponentModel_ICustomTypeDescriptor_GetComponentName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00026EC0 File Offset: 0x000250C0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeConverter System_ComponentModel_ICustomTypeDescriptor_GetConverter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00026F00 File Offset: 0x00025100
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventDescriptor System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00026F40 File Offset: 0x00025140
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptor System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00026F80 File Offset: 0x00025180
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ComponentModel_ICustomTypeDescriptor_GetEditor(Type editorBaseType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00026FD0 File Offset: 0x000251D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901359, XrefRangeEnd = 901363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00027010 File Offset: 0x00025210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901363, XrefRangeEnd = 901367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetEvents(Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00027060 File Offset: 0x00025260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901367, XrefRangeEnd = 901379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000270A0 File Offset: 0x000252A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901379, XrefRangeEnd = 901384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetProperties(Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000270F0 File Offset: 0x000252F0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner(PropertyDescriptor pd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowView.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00003FCB File Offset: 0x000021CB
		public DataRowView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00027140 File Offset: 0x00025340
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00003FD4 File Offset: 0x000021D4
		public unsafe DataView _dataView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowView.NativeFieldInfoPtr__dataView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowView.NativeFieldInfoPtr__dataView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00027170 File Offset: 0x00025370
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00003FF3 File Offset: 0x000021F3
		public unsafe DataRow _row
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowView.NativeFieldInfoPtr__row);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowView.NativeFieldInfoPtr__row), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x000271A0 File Offset: 0x000253A0
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00004012 File Offset: 0x00002212
		public unsafe bool _delayBeginEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowView.NativeFieldInfoPtr__delayBeginEdit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowView.NativeFieldInfoPtr__delayBeginEdit)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x000271C8 File Offset: 0x000253C8
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x0000402D File Offset: 0x0000222D
		public unsafe static PropertyDescriptorCollection s_zeroPropertyDescriptorCollection
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataRowView.NativeFieldInfoPtr_s_zeroPropertyDescriptorCollection, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataRowView.NativeFieldInfoPtr_s_zeroPropertyDescriptorCollection, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x000271F0 File Offset: 0x000253F0
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x0000403F File Offset: 0x0000223F
		public unsafe PropertyChangedEventHandler PropertyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowView.NativeFieldInfoPtr_PropertyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowView.NativeFieldInfoPtr_PropertyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr__dataView;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr__row;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr__delayBeginEdit;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_s_zeroPropertyDescriptorCollection;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_PropertyChanged;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataView_DataRow_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_get_DataView_Public_get_DataView_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_get_RowVersionDefault_Private_get_DataRowVersion_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_GetRecord_Internal_Int32_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_HasRecord_Internal_Boolean_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnValue_Internal_Object_DataColumn_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_SetColumnValue_Internal_Void_DataColumn_Object_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_CreateChildView_Public_DataView_DataRelation_Boolean_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_CreateChildView_Public_DataView_DataRelation_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_get_Row_Public_get_DataRow_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_EndEdit_Public_Virtual_Final_New_Void_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNew_Public_get_Boolean_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_RaisePropertyChangedEvent_Internal_Void_String_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0;
	}
}
