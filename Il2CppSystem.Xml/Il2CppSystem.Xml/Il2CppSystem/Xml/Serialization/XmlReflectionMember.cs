using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000DE RID: 222
	public class XmlReflectionMember : Object
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x0006E16C File Offset: 0x0006C36C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReflectionMember()
		{
			Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlReflectionMember");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr);
			XmlReflectionMember.NativeFieldInfoPtr_isReturnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, "isReturnValue");
			XmlReflectionMember.NativeFieldInfoPtr_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, "memberName");
			XmlReflectionMember.NativeFieldInfoPtr_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, "memberType");
			XmlReflectionMember.NativeFieldInfoPtr_xmlAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, "xmlAttributes");
			XmlReflectionMember.NativeFieldInfoPtr_declaringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, "declaringType");
			XmlReflectionMember.NativeMethodInfoPtr__ctor_Internal_Void_String_Type_XmlAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666543);
			XmlReflectionMember.NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666544);
			XmlReflectionMember.NativeMethodInfoPtr_get_MemberName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666545);
			XmlReflectionMember.NativeMethodInfoPtr_get_MemberType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666546);
			XmlReflectionMember.NativeMethodInfoPtr_get_XmlAttributes_Public_get_XmlAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666547);
			XmlReflectionMember.NativeMethodInfoPtr_get_DeclaringType_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666548);
			XmlReflectionMember.NativeMethodInfoPtr_set_DeclaringType_Internal_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666549);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0006E28C File Offset: 0x0006C48C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387000, RefRangeEnd = 387002, XrefRangeStart = 386996, XrefRangeEnd = 387000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReflectionMember(string name, Type type, XmlAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr__ctor_Internal_Void_String_Type_XmlAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0006E2FC File Offset: 0x0006C4FC
		public unsafe bool IsReturnValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0006E338 File Offset: 0x0006C538
		public unsafe string MemberName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_get_MemberName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0006E370 File Offset: 0x0006C570
		public unsafe Type MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_get_MemberType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0006E3B0 File Offset: 0x0006C5B0
		public unsafe XmlAttributes XmlAttributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387002, XrefRangeEnd = 387007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_get_XmlAttributes_Public_get_XmlAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0006E3F0 File Offset: 0x0006C5F0
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x0006E430 File Offset: 0x0006C630
		public unsafe Type DeclaringType
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_get_DeclaringType_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_set_DeclaringType_Internal_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00008B85 File Offset: 0x00006D85
		public XmlReflectionMember(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0006E474 File Offset: 0x0006C674
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x00008B8E File Offset: 0x00006D8E
		public unsafe bool isReturnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_isReturnValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_isReturnValue)) = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0006E49C File Offset: 0x0006C69C
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x00008BA9 File Offset: 0x00006DA9
		public unsafe string memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0006E4C4 File Offset: 0x0006C6C4
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00008BC8 File Offset: 0x00006DC8
		public unsafe Type memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_memberType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_memberType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0006E4F4 File Offset: 0x0006C6F4
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00008BE7 File Offset: 0x00006DE7
		public unsafe XmlAttributes xmlAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_xmlAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_xmlAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0006E524 File Offset: 0x0006C724
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00008C06 File Offset: 0x00006E06
		public unsafe Type declaringType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_declaringType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_declaringType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeFieldInfoPtr_isReturnValue;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeFieldInfoPtr_memberName;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeFieldInfoPtr_memberType;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeFieldInfoPtr_xmlAttributes;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeFieldInfoPtr_declaringType;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Type_XmlAttributes_0;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberName_Public_get_String_0;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_get_Type_0;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlAttributes_Public_get_XmlAttributes_0;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Internal_get_Type_0;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr_set_DeclaringType_Internal_set_Void_Type_0;
	}
}
