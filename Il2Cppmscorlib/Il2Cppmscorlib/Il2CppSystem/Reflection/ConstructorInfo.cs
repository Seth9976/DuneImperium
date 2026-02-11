using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000406 RID: 1030
	[Serializable]
	public class ConstructorInfo : MethodBase
	{
		// Token: 0x06003BBB RID: 15291 RVA: 0x0011E760 File Offset: 0x0011C960
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructorInfo()
		{
			Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ConstructorInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr);
			ConstructorInfo.NativeFieldInfoPtr_ConstructorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, "ConstructorName");
			ConstructorInfo.NativeFieldInfoPtr_TypeConstructorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, "TypeConstructorName");
			ConstructorInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100672192);
			ConstructorInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100672193);
			ConstructorInfo.NativeMethodInfoPtr_Invoke_Public_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100672194);
			ConstructorInfo.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100672195);
			ConstructorInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100672196);
			ConstructorInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100672197);
			ConstructorInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100672198);
			ConstructorInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100672199);
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x0011E858 File Offset: 0x0011CA58
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructorInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06003BBD RID: 15293 RVA: 0x0011E894 File Offset: 0x0011CA94
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructorInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x0011E8DC File Offset: 0x0011CADC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1398075, RefRangeEnd = 1398103, XrefRangeStart = 1398075, XrefRangeEnd = 1398075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Invoke(Il2CppReferenceArray<Object> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorInfo.NativeMethodInfoPtr_Invoke_Public_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x0011E92C File Offset: 0x0011CB2C
		[CallerCount(0)]
		public unsafe virtual Object Invoke(BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> parameters, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invokeAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructorInfo.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x0011E9BC File Offset: 0x0011CBBC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructorInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x0011EA14 File Offset: 0x0011CC14
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructorInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x0011EA5C File Offset: 0x0011CC5C
		[CallerCount(239)]
		[CachedScanResults(RefRangeStart = 1347122, RefRangeEnd = 1347361, XrefRangeStart = 1347122, XrefRangeEnd = 1347361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ConstructorInfo left, ConstructorInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x0011EAB0 File Offset: 0x0011CCB0
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1398106, RefRangeEnd = 1398135, XrefRangeStart = 1398103, XrefRangeEnd = 1398106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ConstructorInfo left, ConstructorInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00016424 File Offset: 0x00014624
		public ConstructorInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x0011EB04 File Offset: 0x0011CD04
		// (set) Token: 0x06003BC6 RID: 15302 RVA: 0x0001642D File Offset: 0x0001462D
		public unsafe static string ConstructorName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConstructorInfo.NativeFieldInfoPtr_ConstructorName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstructorInfo.NativeFieldInfoPtr_ConstructorName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x0011EB24 File Offset: 0x0011CD24
		// (set) Token: 0x06003BC8 RID: 15304 RVA: 0x0001643F File Offset: 0x0001463F
		public unsafe static string TypeConstructorName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConstructorInfo.NativeFieldInfoPtr_TypeConstructorName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstructorInfo.NativeFieldInfoPtr_TypeConstructorName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003058 RID: 12376
		private static readonly IntPtr NativeFieldInfoPtr_ConstructorName;

		// Token: 0x04003059 RID: 12377
		private static readonly IntPtr NativeFieldInfoPtr_TypeConstructorName;

		// Token: 0x0400305A RID: 12378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400305B RID: 12379
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x0400305C RID: 12380
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400305D RID: 12381
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x0400305E RID: 12382
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400305F RID: 12383
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003060 RID: 12384
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0;

		// Token: 0x04003061 RID: 12385
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0;
	}
}
