using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Unity.Properties
{
	// Token: 0x0200000C RID: 12
	public sealed class PropertyMember : ValueType
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000043FC File Offset: 0x000025FC
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyMember()
		{
			Il2CppClassPointerStore<PropertyMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "PropertyMember");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyMember>.NativeClassPtr);
			PropertyMember.NativeFieldInfoPtr_m_PropertyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMember>.NativeClassPtr, "m_PropertyInfo");
			PropertyMember.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMember>.NativeClassPtr, "<Name>k__BackingField");
			PropertyMember.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMember>.NativeClassPtr, 100663321);
			PropertyMember.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMember>.NativeClassPtr, 100663322);
			PropertyMember.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMember>.NativeClassPtr, 100663323);
			PropertyMember.NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMember>.NativeClassPtr, 100663324);
			PropertyMember.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_New_IEnumerable_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMember>.NativeClassPtr, 100663325);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000044B8 File Offset: 0x000026B8
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMember.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000044F4 File Offset: 0x000026F4
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMember.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00004538 File Offset: 0x00002738
		public unsafe Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230636, XrefRangeEnd = 1230637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMember.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000457C File Offset: 0x0000277C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230630, RefRangeEnd = 1230632, XrefRangeStart = 1230630, XrefRangeEnd = 1230632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyMember(PropertyInfo propertyInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyMember>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMember.NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000045CC File Offset: 0x000027CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Attribute> GetCustomAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMember.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_New_IEnumerable_1_Attribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Attribute>>(intPtr3) : null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000226D File Offset: 0x0000046D
		public PropertyMember(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002276 File Offset: 0x00000476
		public PropertyMember()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyMember>.NativeClassPtr))
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00004610 File Offset: 0x00002810
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002288 File Offset: 0x00000488
		public unsafe PropertyInfo m_PropertyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMember.NativeFieldInfoPtr_m_PropertyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMember.NativeFieldInfoPtr_m_PropertyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00004640 File Offset: 0x00002840
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000022A7 File Offset: 0x000004A7
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMember.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMember.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000022C6 File Offset: 0x000004C6
		public Object GetValue(Object obj)
		{
			return this.m_PropertyInfo.GetValue(obj);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000022D4 File Offset: 0x000004D4
		public void SetValue(Object obj, Object value)
		{
			this.m_PropertyInfo.SetValue(obj, value);
		}

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyInfo;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_New_IEnumerable_1_Attribute_0;
	}
}
