using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000E8 RID: 232
	public sealed class DesignerCategoryAttribute : Attribute
	{
		// Token: 0x06000F4A RID: 3914 RVA: 0x00055B78 File Offset: 0x00053D78
		// Note: this type is marked as 'beforefieldinit'.
		static DesignerCategoryAttribute()
		{
			Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DesignerCategoryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr);
			DesignerCategoryAttribute.NativeFieldInfoPtr_Component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, "Component");
			DesignerCategoryAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, "Default");
			DesignerCategoryAttribute.NativeFieldInfoPtr_Form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, "Form");
			DesignerCategoryAttribute.NativeFieldInfoPtr_Generic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, "Generic");
			DesignerCategoryAttribute.NativeFieldInfoPtr__Category_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, "<Category>k__BackingField");
			DesignerCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100665510);
			DesignerCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100665511);
			DesignerCategoryAttribute.NativeMethodInfoPtr_get_Category_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100665512);
			DesignerCategoryAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100665513);
			DesignerCategoryAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100665514);
			DesignerCategoryAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100665515);
			DesignerCategoryAttribute.NativeMethodInfoPtr_get_TypeId_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100665516);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00055C98 File Offset: 0x00053E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456251, XrefRangeEnd = 456255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesignerCategoryAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00055CD4 File Offset: 0x00053ED4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesignerCategoryAttribute(string category)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00055D20 File Offset: 0x00053F20
		public unsafe string Category
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr_get_Category_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00055D58 File Offset: 0x00053F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456255, XrefRangeEnd = 456258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00055DA8 File Offset: 0x00053FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00055DE4 File Offset: 0x00053FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456258, XrefRangeEnd = 456301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00055E20 File Offset: 0x00054020
		public unsafe override Object TypeId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456301, XrefRangeEnd = 456304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr_get_TypeId_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00007871 File Offset: 0x00005A71
		public DesignerCategoryAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00055E60 File Offset: 0x00054060
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x0000787A File Offset: 0x00005A7A
		public unsafe static DesignerCategoryAttribute Component
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Component, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerCategoryAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Component, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00055E88 File Offset: 0x00054088
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x0000788C File Offset: 0x00005A8C
		public unsafe static DesignerCategoryAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerCategoryAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00055EB0 File Offset: 0x000540B0
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x0000789E File Offset: 0x00005A9E
		public unsafe static DesignerCategoryAttribute Form
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Form, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerCategoryAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Form, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00055ED8 File Offset: 0x000540D8
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x000078B0 File Offset: 0x00005AB0
		public unsafe static DesignerCategoryAttribute Generic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Generic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerCategoryAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Generic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00055F00 File Offset: 0x00054100
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x000078C2 File Offset: 0x00005AC2
		public unsafe string _Category_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerCategoryAttribute.NativeFieldInfoPtr__Category_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerCategoryAttribute.NativeFieldInfoPtr__Category_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeFieldInfoPtr_Component;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeFieldInfoPtr_Form;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeFieldInfoPtr_Generic;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeFieldInfoPtr__Category_k__BackingField;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_get_Category_Public_get_String_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeId_Public_Virtual_get_Object_0;
	}
}
