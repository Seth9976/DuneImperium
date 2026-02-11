using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200040D RID: 1037
	[Serializable]
	public class FieldInfo : MemberInfo
	{
		// Token: 0x06003BE8 RID: 15336 RVA: 0x0011F468 File Offset: 0x0011D668
		// Note: this type is marked as 'beforefieldinit'.
		static FieldInfo()
		{
			Il2CppClassPointerStore<FieldInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "FieldInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr);
			FieldInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672224);
			FieldInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672225);
			FieldInfo.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_FieldAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672226);
			FieldInfo.NativeMethodInfoPtr_get_FieldType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672227);
			FieldInfo.NativeMethodInfoPtr_get_IsInitOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672228);
			FieldInfo.NativeMethodInfoPtr_get_IsLiteral_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672229);
			FieldInfo.NativeMethodInfoPtr_get_IsNotSerialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672230);
			FieldInfo.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672231);
			FieldInfo.NativeMethodInfoPtr_get_IsPrivate_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672232);
			FieldInfo.NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672233);
			FieldInfo.NativeMethodInfoPtr_get_FieldHandle_Public_Abstract_Virtual_New_get_RuntimeFieldHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672234);
			FieldInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672235);
			FieldInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672236);
			FieldInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FieldInfo_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672237);
			FieldInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FieldInfo_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672238);
			FieldInfo.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672239);
			FieldInfo.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672240);
			FieldInfo.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672241);
			FieldInfo.NativeMethodInfoPtr_SetValueDirect_Public_Virtual_New_Void_TypedReference_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672242);
			FieldInfo.NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672243);
			FieldInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_FieldInfo_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672244);
			FieldInfo.NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672245);
			FieldInfo.NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672246);
			FieldInfo.NativeMethodInfoPtr_GetFieldOffset_Internal_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672247);
			FieldInfo.NativeMethodInfoPtr_get_marshal_info_Private_MarshalAsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672248);
			FieldInfo.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672249);
			FieldInfo.NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Il2CppReferenceArray_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100672250);
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x0011F6B4 File Offset: 0x0011D8B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06003BEA RID: 15338 RVA: 0x0011F6F0 File Offset: 0x0011D8F0
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x0011F738 File Offset: 0x0011D938
		public unsafe virtual FieldAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_FieldAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06003BEC RID: 15340 RVA: 0x0011F780 File Offset: 0x0011D980
		public unsafe virtual Type FieldType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_get_FieldType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x0011F7CC File Offset: 0x0011D9CC
		public unsafe virtual bool IsInitOnly
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1398313, RefRangeEnd = 1398320, XrefRangeStart = 1398313, XrefRangeEnd = 1398313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_IsInitOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06003BEE RID: 15342 RVA: 0x0011F808 File Offset: 0x0011DA08
		public unsafe virtual bool IsLiteral
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1398320, RefRangeEnd = 1398326, XrefRangeStart = 1398320, XrefRangeEnd = 1398320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_IsLiteral_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06003BEF RID: 15343 RVA: 0x0011F844 File Offset: 0x0011DA44
		public unsafe virtual bool IsNotSerialized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1398326, RefRangeEnd = 1398327, XrefRangeStart = 1398326, XrefRangeEnd = 1398326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_IsNotSerialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x0011F880 File Offset: 0x0011DA80
		public unsafe virtual bool IsStatic
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1398327, RefRangeEnd = 1398337, XrefRangeStart = 1398327, XrefRangeEnd = 1398327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x0011F8BC File Offset: 0x0011DABC
		public unsafe virtual bool IsPrivate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1398337, RefRangeEnd = 1398338, XrefRangeStart = 1398337, XrefRangeEnd = 1398337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_IsPrivate_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x0011F8F8 File Offset: 0x0011DAF8
		public unsafe virtual bool IsPublic
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1398338, RefRangeEnd = 1398343, XrefRangeStart = 1398338, XrefRangeEnd = 1398338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x0011F934 File Offset: 0x0011DB34
		public unsafe virtual RuntimeFieldHandle FieldHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_get_FieldHandle_Public_Abstract_Virtual_New_get_RuntimeFieldHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x0011F97C File Offset: 0x0011DB7C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x0011F9D4 File Offset: 0x0011DBD4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x0011FA1C File Offset: 0x0011DC1C
		[CallerCount(239)]
		[CachedScanResults(RefRangeStart = 1347122, RefRangeEnd = 1347361, XrefRangeStart = 1347122, XrefRangeEnd = 1347361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FieldInfo left, FieldInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FieldInfo_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x0011FA70 File Offset: 0x0011DC70
		[CallerCount(154)]
		[CachedScanResults(RefRangeStart = 1398150, RefRangeEnd = 1398304, XrefRangeStart = 1398150, XrefRangeEnd = 1398304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(FieldInfo left, FieldInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FieldInfo_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x0011FAC4 File Offset: 0x0011DCC4
		[CallerCount(0)]
		public unsafe virtual Object GetValue(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x0011FB20 File Offset: 0x0011DD20
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1398347, RefRangeEnd = 1398358, XrefRangeStart = 1398343, XrefRangeEnd = 1398347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValue(Object obj, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x0011FB74 File Offset: 0x0011DD74
		[CallerCount(0)]
		public unsafe virtual void SetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x0011FC08 File Offset: 0x0011DE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398358, XrefRangeEnd = 1398364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValueDirect(TypedReference obj, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_SetValueDirect_Public_Virtual_New_Void_TypedReference_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x0011FC64 File Offset: 0x0011DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398364, XrefRangeEnd = 1398370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRawConstantValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x0011FCB0 File Offset: 0x0011DEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398370, XrefRangeEnd = 1398371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref field_handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type_handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_FieldInfo_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x0011FD00 File Offset: 0x0011DF00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1398379, RefRangeEnd = 1398382, XrefRangeStart = 1398371, XrefRangeEnd = 1398379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x0011FD40 File Offset: 0x0011DF40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1398384, RefRangeEnd = 1398385, XrefRangeStart = 1398382, XrefRangeEnd = 1398384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declaringType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x0011FD90 File Offset: 0x0011DF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398385, XrefRangeEnd = 1398391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetFieldOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_GetFieldOffset_Internal_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x0011FDD8 File Offset: 0x0011DFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalAsAttribute get_marshal_info()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_marshal_info_Private_MarshalAsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalAsAttribute>(intPtr3) : null;
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x0011FE18 File Offset: 0x0011E018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1398411, RefRangeEnd = 1398412, XrefRangeStart = 1398391, XrefRangeEnd = 1398411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetPseudoCustomAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x0011FE58 File Offset: 0x0011E058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1398495, RefRangeEnd = 1398496, XrefRangeStart = 1398412, XrefRangeEnd = 1398495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<CustomAttributeData> GetPseudoCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Il2CppReferenceArray_1_CustomAttributeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x000164AA File Offset: 0x000146AA
		public FieldInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003097 RID: 12439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003098 RID: 12440
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x04003099 RID: 12441
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_FieldAttributes_0;

		// Token: 0x0400309A RID: 12442
		private static readonly IntPtr NativeMethodInfoPtr_get_FieldType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x0400309B RID: 12443
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInitOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400309C RID: 12444
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLiteral_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400309D RID: 12445
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotSerialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400309E RID: 12446
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400309F RID: 12447
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPrivate_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040030A0 RID: 12448
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040030A1 RID: 12449
		private static readonly IntPtr NativeMethodInfoPtr_get_FieldHandle_Public_Abstract_Virtual_New_get_RuntimeFieldHandle_0;

		// Token: 0x040030A2 RID: 12450
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040030A3 RID: 12451
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040030A4 RID: 12452
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FieldInfo_FieldInfo_0;

		// Token: 0x040030A5 RID: 12453
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FieldInfo_FieldInfo_0;

		// Token: 0x040030A6 RID: 12454
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0;

		// Token: 0x040030A7 RID: 12455
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x040030A8 RID: 12456
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_CultureInfo_0;

		// Token: 0x040030A9 RID: 12457
		private static readonly IntPtr NativeMethodInfoPtr_SetValueDirect_Public_Virtual_New_Void_TypedReference_Object_0;

		// Token: 0x040030AA RID: 12458
		private static readonly IntPtr NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_New_Object_0;

		// Token: 0x040030AB RID: 12459
		private static readonly IntPtr NativeMethodInfoPtr_internal_from_handle_type_Private_Static_FieldInfo_IntPtr_IntPtr_0;

		// Token: 0x040030AC RID: 12460
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_0;

		// Token: 0x040030AD RID: 12461
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_RuntimeTypeHandle_0;

		// Token: 0x040030AE RID: 12462
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldOffset_Internal_Virtual_New_Int32_0;

		// Token: 0x040030AF RID: 12463
		private static readonly IntPtr NativeMethodInfoPtr_get_marshal_info_Private_MarshalAsAttribute_0;

		// Token: 0x040030B0 RID: 12464
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040030B1 RID: 12465
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Il2CppReferenceArray_1_CustomAttributeData_0;
	}
}
