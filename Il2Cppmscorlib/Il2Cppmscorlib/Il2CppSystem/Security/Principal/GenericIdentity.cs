using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Security.Claims;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x02000281 RID: 641
	[Serializable]
	public class GenericIdentity : ClaimsIdentity
	{
		// Token: 0x06002957 RID: 10583 RVA: 0x000DD810 File Offset: 0x000DBA10
		// Note: this type is marked as 'beforefieldinit'.
		static GenericIdentity()
		{
			Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "GenericIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr);
			GenericIdentity.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr, "m_name");
			GenericIdentity.NativeFieldInfoPtr_m_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr, "m_type");
			GenericIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr, 100670063);
			GenericIdentity.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr, 100670064);
			GenericIdentity.NativeMethodInfoPtr__ctor_Protected_Void_GenericIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr, 100670065);
			GenericIdentity.NativeMethodInfoPtr_Clone_Public_Virtual_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr, 100670066);
			GenericIdentity.NativeMethodInfoPtr_get_Claims_Public_Virtual_get_IEnumerable_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr, 100670067);
			GenericIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr, 100670068);
			GenericIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr, 100670069);
			GenericIdentity.NativeMethodInfoPtr_AddNameClaim_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr, 100670070);
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x000DD908 File Offset: 0x000DBB08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1375628, RefRangeEnd = 1375630, XrefRangeStart = 1375614, XrefRangeEnd = 1375628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericIdentity(string name, string type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000DD968 File Offset: 0x000DBB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375630, XrefRangeEnd = 1375631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericIdentity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericIdentity.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000DD9A4 File Offset: 0x000DBBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375631, XrefRangeEnd = 1375635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericIdentity(GenericIdentity identity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericIdentity>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericIdentity.NativeMethodInfoPtr__ctor_Protected_Void_GenericIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x000DD9F0 File Offset: 0x000DBBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375635, XrefRangeEnd = 1375641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ClaimsIdentity Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericIdentity.NativeMethodInfoPtr_Clone_Public_Virtual_ClaimsIdentity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000DDA3C File Offset: 0x000DBC3C
		public unsafe override IEnumerable<Claim> Claims
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375641, XrefRangeEnd = 1375647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericIdentity.NativeMethodInfoPtr_get_Claims_Public_Virtual_get_IEnumerable_1_Claim_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Claim>>(intPtr3) : null;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x000DDA88 File Offset: 0x000DBC88
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000DDACC File Offset: 0x000DBCCC
		public unsafe override string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x000DDB10 File Offset: 0x000DBD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375647, XrefRangeEnd = 1375658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNameClaim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericIdentity.NativeMethodInfoPtr_AddNameClaim_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0000DA38 File Offset: 0x0000BC38
		public GenericIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002961 RID: 10593 RVA: 0x000DDB44 File Offset: 0x000DBD44
		// (set) Token: 0x06002962 RID: 10594 RVA: 0x0000DA41 File Offset: 0x0000BC41
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericIdentity.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericIdentity.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002963 RID: 10595 RVA: 0x000DDB6C File Offset: 0x000DBD6C
		// (set) Token: 0x06002964 RID: 10596 RVA: 0x0000DA60 File Offset: 0x0000BC60
		public unsafe string m_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericIdentity.NativeFieldInfoPtr_m_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericIdentity.NativeFieldInfoPtr_m_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002350 RID: 9040
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04002351 RID: 9041
		private static readonly IntPtr NativeFieldInfoPtr_m_type;

		// Token: 0x04002352 RID: 9042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04002353 RID: 9043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002354 RID: 9044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_GenericIdentity_0;

		// Token: 0x04002355 RID: 9045
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_ClaimsIdentity_0;

		// Token: 0x04002356 RID: 9046
		private static readonly IntPtr NativeMethodInfoPtr_get_Claims_Public_Virtual_get_IEnumerable_1_Claim_0;

		// Token: 0x04002357 RID: 9047
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04002358 RID: 9048
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_get_String_0;

		// Token: 0x04002359 RID: 9049
		private static readonly IntPtr NativeMethodInfoPtr_AddNameClaim_Private_Void_0;
	}
}
