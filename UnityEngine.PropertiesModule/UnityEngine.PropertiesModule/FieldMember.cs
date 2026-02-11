using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Unity.Properties
{
	// Token: 0x0200000B RID: 11
	public sealed class FieldMember : ValueType
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00004190 File Offset: 0x00002390
		// Note: this type is marked as 'beforefieldinit'.
		static FieldMember()
		{
			Il2CppClassPointerStore<FieldMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "FieldMember");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldMember>.NativeClassPtr);
			FieldMember.NativeFieldInfoPtr_m_FieldInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMember>.NativeClassPtr, "m_FieldInfo");
			FieldMember.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMember>.NativeClassPtr, "<Name>k__BackingField");
			FieldMember.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMember>.NativeClassPtr, 100663316);
			FieldMember.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMember>.NativeClassPtr, 100663317);
			FieldMember.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMember>.NativeClassPtr, 100663318);
			FieldMember.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMember>.NativeClassPtr, 100663319);
			FieldMember.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_New_IEnumerable_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMember>.NativeClassPtr, 100663320);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000424C File Offset: 0x0000244C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230630, RefRangeEnd = 1230632, XrefRangeStart = 1230627, XrefRangeEnd = 1230630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldMember(FieldInfo fieldInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMember>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMember.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000429C File Offset: 0x0000249C
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMember.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000042D8 File Offset: 0x000024D8
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230632, XrefRangeEnd = 1230634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMember.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000431C File Offset: 0x0000251C
		public unsafe Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230634, XrefRangeEnd = 1230635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMember.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004360 File Offset: 0x00002560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230635, XrefRangeEnd = 1230636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Attribute> GetCustomAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMember.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_New_IEnumerable_1_Attribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Attribute>>(intPtr3) : null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021F6 File Offset: 0x000003F6
		public FieldMember(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021FF File Offset: 0x000003FF
		public FieldMember()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMember>.NativeClassPtr))
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000043A4 File Offset: 0x000025A4
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002211 File Offset: 0x00000411
		public unsafe FieldInfo m_FieldInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMember.NativeFieldInfoPtr_m_FieldInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMember.NativeFieldInfoPtr_m_FieldInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000043D4 File Offset: 0x000025D4
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002230 File Offset: 0x00000430
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMember.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMember.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000224F File Offset: 0x0000044F
		public Object GetValue(Object obj)
		{
			return this.m_FieldInfo.GetValue(obj);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000225D File Offset: 0x0000045D
		public void SetValue(Object obj, Object value)
		{
			this.m_FieldInfo.SetValue(obj, value);
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_m_FieldInfo;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Final_New_IEnumerable_1_Attribute_0;
	}
}
