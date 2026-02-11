using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000145 RID: 325
	public class TypeConverter : Object
	{
		// Token: 0x060013C2 RID: 5058 RVA: 0x000684A8 File Offset: 0x000666A8
		// Note: this type is marked as 'beforefieldinit'.
		static TypeConverter()
		{
			Il2CppClassPointerStore<TypeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "TypeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr);
			TypeConverter.NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "s_UseCompatibleTypeConverterBehavior");
			TypeConverter.NativeFieldInfoPtr_useCompatibleTypeConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "useCompatibleTypeConversion");
			TypeConverter.NativeMethodInfoPtr_get_UseCompatibleTypeConversion_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666162);
			TypeConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666163);
			TypeConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_New_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666164);
			TypeConverter.NativeMethodInfoPtr_CanConvertTo_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666165);
			TypeConverter.NativeMethodInfoPtr_CanConvertTo_Public_Virtual_New_Boolean_ITypeDescriptorContext_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666166);
			TypeConverter.NativeMethodInfoPtr_ConvertFrom_Public_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666167);
			TypeConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_New_Object_ITypeDescriptorContext_CultureInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666168);
			TypeConverter.NativeMethodInfoPtr_ConvertFromInvariantString_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666169);
			TypeConverter.NativeMethodInfoPtr_ConvertFromInvariantString_Public_Object_ITypeDescriptorContext_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666170);
			TypeConverter.NativeMethodInfoPtr_ConvertFromString_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666171);
			TypeConverter.NativeMethodInfoPtr_ConvertFromString_Public_Object_ITypeDescriptorContext_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666172);
			TypeConverter.NativeMethodInfoPtr_ConvertFromString_Public_Object_ITypeDescriptorContext_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666173);
			TypeConverter.NativeMethodInfoPtr_ConvertTo_Public_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666174);
			TypeConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_New_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666175);
			TypeConverter.NativeMethodInfoPtr_ConvertToInvariantString_Public_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666176);
			TypeConverter.NativeMethodInfoPtr_ConvertToInvariantString_Public_String_ITypeDescriptorContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666177);
			TypeConverter.NativeMethodInfoPtr_ConvertToString_Public_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666178);
			TypeConverter.NativeMethodInfoPtr_ConvertToString_Public_String_ITypeDescriptorContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666179);
			TypeConverter.NativeMethodInfoPtr_ConvertToString_Public_String_ITypeDescriptorContext_CultureInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666180);
			TypeConverter.NativeMethodInfoPtr_CreateInstance_Public_Object_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666181);
			TypeConverter.NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_Object_ITypeDescriptorContext_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666182);
			TypeConverter.NativeMethodInfoPtr_GetConvertFromException_Protected_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666183);
			TypeConverter.NativeMethodInfoPtr_GetConvertToException_Protected_Exception_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666184);
			TypeConverter.NativeMethodInfoPtr_GetCreateInstanceSupported_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666185);
			TypeConverter.NativeMethodInfoPtr_GetCreateInstanceSupported_Public_Virtual_New_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666186);
			TypeConverter.NativeMethodInfoPtr_GetProperties_Public_PropertyDescriptorCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666187);
			TypeConverter.NativeMethodInfoPtr_GetProperties_Public_PropertyDescriptorCollection_ITypeDescriptorContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666188);
			TypeConverter.NativeMethodInfoPtr_GetProperties_Public_Virtual_New_PropertyDescriptorCollection_ITypeDescriptorContext_Object_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666189);
			TypeConverter.NativeMethodInfoPtr_GetPropertiesSupported_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666190);
			TypeConverter.NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_New_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666191);
			TypeConverter.NativeMethodInfoPtr_GetStandardValues_Public_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666192);
			TypeConverter.NativeMethodInfoPtr_GetStandardValues_Public_Virtual_New_StandardValuesCollection_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666193);
			TypeConverter.NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666194);
			TypeConverter.NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_New_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666195);
			TypeConverter.NativeMethodInfoPtr_GetStandardValuesSupported_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666196);
			TypeConverter.NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_New_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666197);
			TypeConverter.NativeMethodInfoPtr_IsValid_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666198);
			TypeConverter.NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_ITypeDescriptorContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666199);
			TypeConverter.NativeMethodInfoPtr_SortProperties_Protected_PropertyDescriptorCollection_PropertyDescriptorCollection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666200);
			TypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100666201);
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00068820 File Offset: 0x00066A20
		public unsafe static bool UseCompatibleTypeConversion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463756, XrefRangeEnd = 463759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_get_UseCompatibleTypeConversion_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00068850 File Offset: 0x00066A50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 463759, RefRangeEnd = 463762, XrefRangeStart = 463759, XrefRangeEnd = 463759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanConvertFrom(Type sourceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x000688A0 File Offset: 0x00066AA0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 463769, RefRangeEnd = 463783, XrefRangeStart = 463762, XrefRangeEnd = 463769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_New_Boolean_ITypeDescriptorContext_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0006890C File Offset: 0x00066B0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 463783, RefRangeEnd = 463786, XrefRangeStart = 463783, XrefRangeEnd = 463783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanConvertTo(Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_CanConvertTo_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0006895C File Offset: 0x00066B5C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 463793, RefRangeEnd = 463808, XrefRangeStart = 463786, XrefRangeEnd = 463793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_CanConvertTo_Public_Virtual_New_Boolean_ITypeDescriptorContext_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x000689C8 File Offset: 0x00066BC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463812, RefRangeEnd = 463813, XrefRangeStart = 463808, XrefRangeEnd = 463812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConvertFrom(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertFrom_Public_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00068A18 File Offset: 0x00066C18
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 463817, RefRangeEnd = 463830, XrefRangeStart = 463813, XrefRangeEnd = 463817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_ConvertFrom_Public_Virtual_New_Object_ITypeDescriptorContext_CultureInfo_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00068A98 File Offset: 0x00066C98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463834, RefRangeEnd = 463836, XrefRangeStart = 463830, XrefRangeEnd = 463834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConvertFromInvariantString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertFromInvariantString_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00068AE8 File Offset: 0x00066CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463836, XrefRangeEnd = 463840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConvertFromInvariantString(ITypeDescriptorContext context, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertFromInvariantString_Public_Object_ITypeDescriptorContext_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00068B4C File Offset: 0x00066D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463840, RefRangeEnd = 463841, XrefRangeStart = 463840, XrefRangeEnd = 463840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConvertFromString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertFromString_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00068B9C File Offset: 0x00066D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463841, XrefRangeEnd = 463845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConvertFromString(ITypeDescriptorContext context, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertFromString_Public_Object_ITypeDescriptorContext_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00068C00 File Offset: 0x00066E00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 436549, RefRangeEnd = 436553, XrefRangeStart = 436549, XrefRangeEnd = 436553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertFromString_Public_Object_ITypeDescriptorContext_CultureInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00068C74 File Offset: 0x00066E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463845, RefRangeEnd = 463846, XrefRangeStart = 463845, XrefRangeEnd = 463845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConvertTo(Object value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertTo_Public_Object_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00068CD8 File Offset: 0x00066ED8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 463866, RefRangeEnd = 463873, XrefRangeStart = 463846, XrefRangeEnd = 463866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_New_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00068D6C File Offset: 0x00066F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463878, RefRangeEnd = 463879, XrefRangeStart = 463873, XrefRangeEnd = 463878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConvertToInvariantString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertToInvariantString_Public_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00068DB4 File Offset: 0x00066FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463884, RefRangeEnd = 463885, XrefRangeStart = 463879, XrefRangeEnd = 463884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConvertToInvariantString(ITypeDescriptorContext context, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertToInvariantString_Public_String_ITypeDescriptorContext_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00068E10 File Offset: 0x00067010
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 463897, RefRangeEnd = 463900, XrefRangeStart = 463885, XrefRangeEnd = 463897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConvertToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertToString_Public_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00068E58 File Offset: 0x00067058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463900, XrefRangeEnd = 463912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConvertToString(ITypeDescriptorContext context, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertToString_Public_String_ITypeDescriptorContext_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00068EB4 File Offset: 0x000670B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463920, RefRangeEnd = 463922, XrefRangeStart = 463912, XrefRangeEnd = 463920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_ConvertToString_Public_String_ITypeDescriptorContext_CultureInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00068F20 File Offset: 0x00067120
		[CallerCount(0)]
		public unsafe Object CreateInstance(IDictionary propertyValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyValues);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_CreateInstance_Public_Object_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00068F70 File Offset: 0x00067170
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyValues);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_Object_ITypeDescriptorContext_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00068FE0 File Offset: 0x000671E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463947, RefRangeEnd = 463948, XrefRangeStart = 463922, XrefRangeEnd = 463947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception GetConvertFromException(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_GetConvertFromException_Protected_Exception_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00069030 File Offset: 0x00067230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463948, XrefRangeEnd = 463978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception GetConvertToException(Object value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_GetConvertToException_Protected_Exception_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00069094 File Offset: 0x00067294
		[CallerCount(0)]
		public unsafe bool GetCreateInstanceSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_GetCreateInstanceSupported_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x000690D0 File Offset: 0x000672D0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_GetCreateInstanceSupported_Public_Virtual_New_Boolean_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00069128 File Offset: 0x00067328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463978, XrefRangeEnd = 463987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDescriptorCollection GetProperties(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_GetProperties_Public_PropertyDescriptorCollection_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00069178 File Offset: 0x00067378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463987, XrefRangeEnd = 463996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_GetProperties_Public_PropertyDescriptorCollection_ITypeDescriptorContext_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x000691DC File Offset: 0x000673DC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, Object value, Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_GetProperties_Public_Virtual_New_PropertyDescriptorCollection_ITypeDescriptorContext_Object_Il2CppReferenceArray_1_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0006925C File Offset: 0x0006745C
		[CallerCount(0)]
		public unsafe bool GetPropertiesSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_GetPropertiesSupported_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00069298 File Offset: 0x00067498
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_New_Boolean_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x000692F0 File Offset: 0x000674F0
		[CallerCount(0)]
		public unsafe ICollection GetStandardValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_GetStandardValues_Public_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00069330 File Offset: 0x00067530
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_GetStandardValues_Public_Virtual_New_StandardValuesCollection_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter.StandardValuesCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0006938C File Offset: 0x0006758C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463996, RefRangeEnd = 463998, XrefRangeStart = 463996, XrefRangeEnd = 463996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetStandardValuesExclusive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x000693C8 File Offset: 0x000675C8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_New_Boolean_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00069420 File Offset: 0x00067620
		[CallerCount(0)]
		public unsafe bool GetStandardValuesSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_GetStandardValuesSupported_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0006945C File Offset: 0x0006765C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_New_Boolean_ITypeDescriptorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x000694B4 File Offset: 0x000676B4
		[CallerCount(0)]
		public unsafe bool IsValid(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_IsValid_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00069504 File Offset: 0x00067704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464009, RefRangeEnd = 464010, XrefRangeStart = 463998, XrefRangeEnd = 464009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValid(ITypeDescriptorContext context, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_ITypeDescriptorContext_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00069570 File Offset: 0x00067770
		[CallerCount(0)]
		public unsafe PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, Il2CppStringArray names)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(props);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr_SortProperties_Protected_PropertyDescriptorCollection_PropertyDescriptorCollection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x000695D4 File Offset: 0x000677D4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00008F35 File Offset: 0x00007135
		public TypeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00069610 File Offset: 0x00067810
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x00008F3E File Offset: 0x0000713E
		public unsafe static string s_UseCompatibleTypeConverterBehavior
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeConverter.NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeConverter.NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00069630 File Offset: 0x00067830
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x00008F50 File Offset: 0x00007150
		public unsafe static bool useCompatibleTypeConversion
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeConverter.NativeFieldInfoPtr_useCompatibleTypeConversion, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeConverter.NativeFieldInfoPtr_useCompatibleTypeConversion, (void*)(&value));
			}
		}

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeFieldInfoPtr_useCompatibleTypeConversion;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCompatibleTypeConversion_Private_Static_get_Boolean_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertFrom_Public_Boolean_Type_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertFrom_Public_Virtual_New_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertTo_Public_Boolean_Type_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertTo_Public_Virtual_New_Boolean_ITypeDescriptorContext_Type_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFrom_Public_Object_Object_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFrom_Public_Virtual_New_Object_ITypeDescriptorContext_CultureInfo_Object_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromInvariantString_Public_Object_String_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromInvariantString_Public_Object_ITypeDescriptorContext_String_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromString_Public_Object_String_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromString_Public_Object_ITypeDescriptorContext_String_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromString_Public_Object_ITypeDescriptorContext_CultureInfo_String_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Object_Object_Type_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Virtual_New_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToInvariantString_Public_String_Object_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToInvariantString_Public_String_ITypeDescriptorContext_Object_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToString_Public_String_Object_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToString_Public_String_ITypeDescriptorContext_Object_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToString_Public_String_ITypeDescriptorContext_CultureInfo_Object_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Object_IDictionary_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_Object_ITypeDescriptorContext_IDictionary_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_GetConvertFromException_Protected_Exception_Object_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_GetConvertToException_Protected_Exception_Object_Type_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_GetCreateInstanceSupported_Public_Boolean_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_GetCreateInstanceSupported_Public_Virtual_New_Boolean_ITypeDescriptorContext_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_PropertyDescriptorCollection_Object_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_PropertyDescriptorCollection_ITypeDescriptorContext_Object_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_New_PropertyDescriptorCollection_ITypeDescriptorContext_Object_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesSupported_Public_Boolean_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_New_Boolean_ITypeDescriptorContext_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValues_Public_ICollection_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValues_Public_Virtual_New_StandardValuesCollection_ITypeDescriptorContext_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Boolean_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValuesExclusive_Public_Virtual_New_Boolean_ITypeDescriptorContext_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValuesSupported_Public_Boolean_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardValuesSupported_Public_Virtual_New_Boolean_ITypeDescriptorContext_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_Object_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_ITypeDescriptorContext_Object_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_SortProperties_Protected_PropertyDescriptorCollection_PropertyDescriptorCollection_Il2CppStringArray_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002E0 RID: 736
		public class SimplePropertyDescriptor : PropertyDescriptor
		{
			// Token: 0x06002C5B RID: 11355 RVA: 0x000C3530 File Offset: 0x000C1730
			// Note: this type is marked as 'beforefieldinit'.
			static SimplePropertyDescriptor()
			{
				Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "SimplePropertyDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr);
				TypeConverter.SimplePropertyDescriptor.NativeFieldInfoPtr_componentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr, "componentType");
				TypeConverter.SimplePropertyDescriptor.NativeFieldInfoPtr_propertyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr, "propertyType");
				TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_Type_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr, 100666202);
				TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_Type_String_Type_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr, 100666203);
				TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr, 100666204);
				TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr, 100666205);
				TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr, 100666206);
				TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr, 100666207);
				TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr, 100666208);
				TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr, 100666209);
			}

			// Token: 0x06002C5C RID: 11356 RVA: 0x000C3624 File Offset: 0x000C1824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463675, XrefRangeEnd = 463681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SimplePropertyDescriptor(Type componentType, string name, Type propertyType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_Type_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C5D RID: 11357 RVA: 0x000C3694 File Offset: 0x000C1894
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 463684, RefRangeEnd = 463686, XrefRangeStart = 463681, XrefRangeEnd = 463684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SimplePropertyDescriptor(Type componentType, string name, Type propertyType, Il2CppReferenceArray<Attribute> attributes)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeConverter.SimplePropertyDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyType);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_Type_String_Type_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DEC RID: 3564
			// (get) Token: 0x06002C5E RID: 11358 RVA: 0x000C3718 File Offset: 0x000C1918
			public unsafe override Type ComponentType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x17000DED RID: 3565
			// (get) Token: 0x06002C5F RID: 11359 RVA: 0x000C3764 File Offset: 0x000C1964
			public unsafe override bool IsReadOnly
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463686, XrefRangeEnd = 463692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000DEE RID: 3566
			// (get) Token: 0x06002C60 RID: 11360 RVA: 0x000C37AC File Offset: 0x000C19AC
			public unsafe override Type PropertyType
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06002C61 RID: 11361 RVA: 0x000C37F8 File Offset: 0x000C19F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463692, XrefRangeEnd = 463700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool CanResetValue(Object component)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C62 RID: 11362 RVA: 0x000C3850 File Offset: 0x000C1A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463700, XrefRangeEnd = 463708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void ResetValue(Object component)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C63 RID: 11363 RVA: 0x000C38A0 File Offset: 0x000C1AA0
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ShouldSerializeValue(Object component)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeConverter.SimplePropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C64 RID: 11364 RVA: 0x00013FF4 File Offset: 0x000121F4
			public SimplePropertyDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DEA RID: 3562
			// (get) Token: 0x06002C65 RID: 11365 RVA: 0x000C38F8 File Offset: 0x000C1AF8
			// (set) Token: 0x06002C66 RID: 11366 RVA: 0x00013FFD File Offset: 0x000121FD
			public unsafe Type componentType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeConverter.SimplePropertyDescriptor.NativeFieldInfoPtr_componentType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeConverter.SimplePropertyDescriptor.NativeFieldInfoPtr_componentType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DEB RID: 3563
			// (get) Token: 0x06002C67 RID: 11367 RVA: 0x000C3928 File Offset: 0x000C1B28
			// (set) Token: 0x06002C68 RID: 11368 RVA: 0x0001401C File Offset: 0x0001221C
			public unsafe Type propertyType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeConverter.SimplePropertyDescriptor.NativeFieldInfoPtr_propertyType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeConverter.SimplePropertyDescriptor.NativeFieldInfoPtr_propertyType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002305 RID: 8965
			private static readonly IntPtr NativeFieldInfoPtr_componentType;

			// Token: 0x04002306 RID: 8966
			private static readonly IntPtr NativeFieldInfoPtr_propertyType;

			// Token: 0x04002307 RID: 8967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_String_Type_0;

			// Token: 0x04002308 RID: 8968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_String_Type_Il2CppReferenceArray_1_Attribute_0;

			// Token: 0x04002309 RID: 8969
			private static readonly IntPtr NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0;

			// Token: 0x0400230A RID: 8970
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

			// Token: 0x0400230B RID: 8971
			private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0;

			// Token: 0x0400230C RID: 8972
			private static readonly IntPtr NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0;

			// Token: 0x0400230D RID: 8973
			private static readonly IntPtr NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0;

			// Token: 0x0400230E RID: 8974
			private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0;
		}

		// Token: 0x020002E1 RID: 737
		public class StandardValuesCollection : Object
		{
			// Token: 0x06002C69 RID: 11369 RVA: 0x000C3958 File Offset: 0x000C1B58
			// Note: this type is marked as 'beforefieldinit'.
			static StandardValuesCollection()
			{
				Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "StandardValuesCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr);
				TypeConverter.StandardValuesCollection.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, "values");
				TypeConverter.StandardValuesCollection.NativeFieldInfoPtr_valueArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, "valueArray");
				TypeConverter.StandardValuesCollection.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, 100666210);
				TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, 100666211);
				TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, 100666212);
				TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, 100666213);
				TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, 100666214);
				TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, 100666215);
				TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, 100666216);
				TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, 100666217);
				TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, 100666218);
				TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr, 100666219);
			}

			// Token: 0x06002C6A RID: 11370 RVA: 0x000C3A74 File Offset: 0x000C1C74
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 463717, RefRangeEnd = 463724, XrefRangeStart = 463708, XrefRangeEnd = 463717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StandardValuesCollection(ICollection values)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.StandardValuesCollection.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000DF1 RID: 3569
			// (get) Token: 0x06002C6B RID: 11371 RVA: 0x000C3AC0 File Offset: 0x000C1CC0
			public unsafe int Count
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 463729, RefRangeEnd = 463730, XrefRangeStart = 463724, XrefRangeEnd = 463729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000DF2 RID: 3570
			public unsafe Object this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463730, XrefRangeEnd = 463746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
			}

			// Token: 0x06002C6D RID: 11373 RVA: 0x000C3B48 File Offset: 0x000C1D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463746, XrefRangeEnd = 463749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Array array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C6E RID: 11374 RVA: 0x000C3B98 File Offset: 0x000C1D98
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 463753, RefRangeEnd = 463756, XrefRangeStart = 463749, XrefRangeEnd = 463753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x17000DF3 RID: 3571
			// (get) Token: 0x06002C6F RID: 11375 RVA: 0x000C3BD8 File Offset: 0x000C1DD8
			public unsafe virtual int System.Collections.ICollection.Count
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 463729, RefRangeEnd = 463730, XrefRangeStart = 463729, XrefRangeEnd = 463730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000DF4 RID: 3572
			// (get) Token: 0x06002C70 RID: 11376 RVA: 0x000C3C14 File Offset: 0x000C1E14
			public unsafe virtual bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000DF5 RID: 3573
			// (get) Token: 0x06002C71 RID: 11377 RVA: 0x000C3C50 File Offset: 0x000C1E50
			public unsafe virtual Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(74)]
				[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C72 RID: 11378 RVA: 0x000C3C90 File Offset: 0x000C1E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C73 RID: 11379 RVA: 0x000C3CE0 File Offset: 0x000C1EE0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 463753, RefRangeEnd = 463756, XrefRangeStart = 463753, XrefRangeEnd = 463756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.StandardValuesCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002C74 RID: 11380 RVA: 0x0001403B File Offset: 0x0001223B
			public StandardValuesCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DEF RID: 3567
			// (get) Token: 0x06002C75 RID: 11381 RVA: 0x000C3D20 File Offset: 0x000C1F20
			// (set) Token: 0x06002C76 RID: 11382 RVA: 0x00014044 File Offset: 0x00012244
			public unsafe ICollection values
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeConverter.StandardValuesCollection.NativeFieldInfoPtr_values);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeConverter.StandardValuesCollection.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF0 RID: 3568
			// (get) Token: 0x06002C77 RID: 11383 RVA: 0x000C3D50 File Offset: 0x000C1F50
			// (set) Token: 0x06002C78 RID: 11384 RVA: 0x00014063 File Offset: 0x00012263
			public unsafe Array valueArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeConverter.StandardValuesCollection.NativeFieldInfoPtr_valueArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeConverter.StandardValuesCollection.NativeFieldInfoPtr_valueArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400230F RID: 8975
			private static readonly IntPtr NativeFieldInfoPtr_values;

			// Token: 0x04002310 RID: 8976
			private static readonly IntPtr NativeFieldInfoPtr_valueArray;

			// Token: 0x04002311 RID: 8977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_0;

			// Token: 0x04002312 RID: 8978
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x04002313 RID: 8979
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0;

			// Token: 0x04002314 RID: 8980
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int32_0;

			// Token: 0x04002315 RID: 8981
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

			// Token: 0x04002316 RID: 8982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002317 RID: 8983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04002318 RID: 8984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002319 RID: 8985
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x0400231A RID: 8986
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
