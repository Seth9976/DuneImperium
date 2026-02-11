using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000415 RID: 1045
	[Serializable]
	public class MemberInfo : Object
	{
		// Token: 0x06003C29 RID: 15401 RVA: 0x00120610 File Offset: 0x0011E810
		// Note: this type is marked as 'beforefieldinit'.
		static MemberInfo()
		{
			Il2CppClassPointerStore<MemberInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MemberInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr);
			MemberInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672266);
			MemberInfo.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672267);
			MemberInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672268);
			MemberInfo.NativeMethodInfoPtr_get_DeclaringType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672269);
			MemberInfo.NativeMethodInfoPtr_get_ReflectedType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672270);
			MemberInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_New_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672271);
			MemberInfo.NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672272);
			MemberInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672273);
			MemberInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672274);
			MemberInfo.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_New_IList_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672275);
			MemberInfo.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672276);
			MemberInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672277);
			MemberInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672278);
			MemberInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MemberInfo_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672279);
			MemberInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MemberInfo_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100672280);
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x0012076C File Offset: 0x0011E96C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06003C2B RID: 15403 RVA: 0x001207A8 File Offset: 0x0011E9A8
		public unsafe virtual MemberTypes MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06003C2C RID: 15404 RVA: 0x001207F0 File Offset: 0x0011E9F0
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06003C2D RID: 15405 RVA: 0x00120834 File Offset: 0x0011EA34
		public unsafe virtual Type DeclaringType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_DeclaringType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06003C2E RID: 15406 RVA: 0x00120880 File Offset: 0x0011EA80
		public unsafe virtual Type ReflectedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_ReflectedType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06003C2F RID: 15407 RVA: 0x001208CC File Offset: 0x0011EACC
		public unsafe virtual Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398534, XrefRangeEnd = 1398544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_New_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x00120918 File Offset: 0x0011EB18
		[CallerCount(0)]
		public unsafe virtual bool IsDefined(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x00120980 File Offset: 0x0011EB80
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x001209D8 File Offset: 0x0011EBD8
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x00120A44 File Offset: 0x0011EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398544, XrefRangeEnd = 1398547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_New_IList_1_CustomAttributeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x00120A90 File Offset: 0x0011EC90
		public unsafe virtual int MetadataToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398547, XrefRangeEnd = 1398552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00120AD8 File Offset: 0x0011ECD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x00120B30 File Offset: 0x0011ED30
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x00120B78 File Offset: 0x0011ED78
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1398568, RefRangeEnd = 1398593, XrefRangeStart = 1398552, XrefRangeEnd = 1398568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(MemberInfo left, MemberInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MemberInfo_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x00120BCC File Offset: 0x0011EDCC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1398594, RefRangeEnd = 1398607, XrefRangeStart = 1398593, XrefRangeEnd = 1398594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(MemberInfo left, MemberInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MemberInfo_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x000165D1 File Offset: 0x000147D1
		public MemberInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040030CD RID: 12493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040030CE RID: 12494
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_MemberTypes_0;

		// Token: 0x040030CF RID: 12495
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040030D0 RID: 12496
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x040030D1 RID: 12497
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x040030D2 RID: 12498
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_New_get_Module_0;

		// Token: 0x040030D3 RID: 12499
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0;

		// Token: 0x040030D4 RID: 12500
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x040030D5 RID: 12501
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x040030D6 RID: 12502
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_New_IList_1_CustomAttributeData_0;

		// Token: 0x040030D7 RID: 12503
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_New_get_Int32_0;

		// Token: 0x040030D8 RID: 12504
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040030D9 RID: 12505
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040030DA RID: 12506
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MemberInfo_MemberInfo_0;

		// Token: 0x040030DB RID: 12507
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MemberInfo_MemberInfo_0;
	}
}
