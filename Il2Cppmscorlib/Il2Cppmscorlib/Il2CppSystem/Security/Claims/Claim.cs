using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Claims
{
	// Token: 0x02000289 RID: 649
	[Serializable]
	public class Claim : Object
	{
		// Token: 0x0600299D RID: 10653 RVA: 0x000DE738 File Offset: 0x000DC938
		// Note: this type is marked as 'beforefieldinit'.
		static Claim()
		{
			Il2CppClassPointerStore<Claim>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Claims", "Claim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Claim>.NativeClassPtr);
			Claim.NativeFieldInfoPtr_m_issuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_issuer");
			Claim.NativeFieldInfoPtr_m_originalIssuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_originalIssuer");
			Claim.NativeFieldInfoPtr_m_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_type");
			Claim.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_value");
			Claim.NativeFieldInfoPtr_m_valueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_valueType");
			Claim.NativeFieldInfoPtr_m_userSerializationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_userSerializationData");
			Claim.NativeFieldInfoPtr_m_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_properties");
			Claim.NativeFieldInfoPtr_m_propertyLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_propertyLock");
			Claim.NativeFieldInfoPtr_m_subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_subject");
			Claim.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670097);
			Claim.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_ClaimsIdentity_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670098);
			Claim.NativeMethodInfoPtr__ctor_Protected_Void_Claim_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670099);
			Claim.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670100);
			Claim.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670101);
			Claim.NativeMethodInfoPtr_get_Subject_Public_get_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670102);
			Claim.NativeMethodInfoPtr_set_Subject_Internal_set_Void_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670103);
			Claim.NativeMethodInfoPtr_get_Type_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670104);
			Claim.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670105);
			Claim.NativeMethodInfoPtr_Clone_Public_Virtual_New_Claim_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670106);
			Claim.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670107);
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000DE8F8 File Offset: 0x000DCAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375827, XrefRangeEnd = 1375828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Claim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(issuer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalIssuer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000DE9A0 File Offset: 0x000DCBA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1375855, RefRangeEnd = 1375859, XrefRangeStart = 1375828, XrefRangeEnd = 1375855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Claim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(issuer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalIssuer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subject);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_ClaimsIdentity_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000DEA70 File Offset: 0x000DCC70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375908, RefRangeEnd = 1375909, XrefRangeStart = 1375859, XrefRangeEnd = 1375908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Claim(Claim other, ClaimsIdentity subject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Claim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr__ctor_Protected_Void_Claim_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x000DEAD0 File Offset: 0x000DCCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375909, XrefRangeEnd = 1375914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializedMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x000DEB18 File Offset: 0x000DCD18
		public unsafe IDictionary<string, string> Properties
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1375925, RefRangeEnd = 1375926, XrefRangeStart = 1375914, XrefRangeEnd = 1375925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x060029A3 RID: 10659 RVA: 0x000DEB58 File Offset: 0x000DCD58
		// (set) Token: 0x060029A4 RID: 10660 RVA: 0x000DEB98 File Offset: 0x000DCD98
		public unsafe ClaimsIdentity Subject
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Subject_Public_get_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_set_Subject_Internal_set_Void_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x000DEBDC File Offset: 0x000DCDDC
		public unsafe string Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Type_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x000DEC14 File Offset: 0x000DCE14
		public unsafe string Value
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000DEC4C File Offset: 0x000DCE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375926, XrefRangeEnd = 1375930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Claim Clone(ClaimsIdentity identity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Claim.NativeMethodInfoPtr_Clone_Public_Virtual_New_Claim_ClaimsIdentity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr3) : null;
			}
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000DECA8 File Offset: 0x000DCEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375930, XrefRangeEnd = 1375937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Claim.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x0000DBF7 File Offset: 0x0000BDF7
		public Claim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000DECEC File Offset: 0x000DCEEC
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x0000DC00 File Offset: 0x0000BE00
		public unsafe string m_issuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_issuer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_issuer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x000DED14 File Offset: 0x000DCF14
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x0000DC1F File Offset: 0x0000BE1F
		public unsafe string m_originalIssuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_originalIssuer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_originalIssuer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x000DED3C File Offset: 0x000DCF3C
		// (set) Token: 0x060029AF RID: 10671 RVA: 0x0000DC3E File Offset: 0x0000BE3E
		public unsafe string m_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x000DED64 File Offset: 0x000DCF64
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x0000DC5D File Offset: 0x0000BE5D
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x000DED8C File Offset: 0x000DCF8C
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		public unsafe string m_valueType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_valueType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_valueType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x000DEDB4 File Offset: 0x000DCFB4
		// (set) Token: 0x060029B5 RID: 10677 RVA: 0x0000DC9B File Offset: 0x0000BE9B
		public unsafe Il2CppStructArray<byte> m_userSerializationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_userSerializationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_userSerializationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x000DEDE4 File Offset: 0x000DCFE4
		// (set) Token: 0x060029B7 RID: 10679 RVA: 0x0000DCBA File Offset: 0x0000BEBA
		public unsafe Dictionary<string, string> m_properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x000DEE14 File Offset: 0x000DD014
		// (set) Token: 0x060029B9 RID: 10681 RVA: 0x0000DCD9 File Offset: 0x0000BED9
		public unsafe Object m_propertyLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_propertyLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_propertyLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x000DEE44 File Offset: 0x000DD044
		// (set) Token: 0x060029BB RID: 10683 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		public unsafe ClaimsIdentity m_subject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_subject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_subject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002388 RID: 9096
		private static readonly IntPtr NativeFieldInfoPtr_m_issuer;

		// Token: 0x04002389 RID: 9097
		private static readonly IntPtr NativeFieldInfoPtr_m_originalIssuer;

		// Token: 0x0400238A RID: 9098
		private static readonly IntPtr NativeFieldInfoPtr_m_type;

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeFieldInfoPtr_m_valueType;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeFieldInfoPtr_m_userSerializationData;

		// Token: 0x0400238E RID: 9102
		private static readonly IntPtr NativeFieldInfoPtr_m_properties;

		// Token: 0x0400238F RID: 9103
		private static readonly IntPtr NativeFieldInfoPtr_m_propertyLock;

		// Token: 0x04002390 RID: 9104
		private static readonly IntPtr NativeFieldInfoPtr_m_subject;

		// Token: 0x04002391 RID: 9105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_ClaimsIdentity_0;

		// Token: 0x04002392 RID: 9106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_ClaimsIdentity_String_String_0;

		// Token: 0x04002393 RID: 9107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Claim_ClaimsIdentity_0;

		// Token: 0x04002394 RID: 9108
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0;

		// Token: 0x04002395 RID: 9109
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_String_0;

		// Token: 0x04002396 RID: 9110
		private static readonly IntPtr NativeMethodInfoPtr_get_Subject_Public_get_ClaimsIdentity_0;

		// Token: 0x04002397 RID: 9111
		private static readonly IntPtr NativeMethodInfoPtr_set_Subject_Internal_set_Void_ClaimsIdentity_0;

		// Token: 0x04002398 RID: 9112
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_String_0;

		// Token: 0x04002399 RID: 9113
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x0400239A RID: 9114
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Claim_ClaimsIdentity_0;

		// Token: 0x0400239B RID: 9115
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
