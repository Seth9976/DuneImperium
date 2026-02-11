using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Security.Claims
{
	// Token: 0x0200028A RID: 650
	[Serializable]
	public class ClaimsIdentity : Object
	{
		// Token: 0x060029BC RID: 10684 RVA: 0x000DEE74 File Offset: 0x000DD074
		// Note: this type is marked as 'beforefieldinit'.
		static ClaimsIdentity()
		{
			Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Claims", "ClaimsIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr);
			ClaimsIdentity.NativeFieldInfoPtr_m_userSerializationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_userSerializationData");
			ClaimsIdentity.NativeFieldInfoPtr_m_instanceClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_instanceClaims");
			ClaimsIdentity.NativeFieldInfoPtr_m_externalClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_externalClaims");
			ClaimsIdentity.NativeFieldInfoPtr_m_nameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_nameType");
			ClaimsIdentity.NativeFieldInfoPtr_m_roleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_roleType");
			ClaimsIdentity.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_version");
			ClaimsIdentity.NativeFieldInfoPtr_m_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_actor");
			ClaimsIdentity.NativeFieldInfoPtr_m_authenticationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_authenticationType");
			ClaimsIdentity.NativeFieldInfoPtr_m_bootstrapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_bootstrapContext");
			ClaimsIdentity.NativeFieldInfoPtr_m_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_label");
			ClaimsIdentity.NativeFieldInfoPtr_m_serializedNameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_serializedNameType");
			ClaimsIdentity.NativeFieldInfoPtr_m_serializedRoleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_serializedRoleType");
			ClaimsIdentity.NativeFieldInfoPtr_m_serializedClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_serializedClaims");
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670108);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670109);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IIdentity_IEnumerable_1_Claim_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670110);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Internal_Void_IIdentity_IEnumerable_1_Claim_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670111);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Protected_Void_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670112);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670113);
			ClaimsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670114);
			ClaimsIdentity.NativeMethodInfoPtr_get_Actor_Public_get_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670115);
			ClaimsIdentity.NativeMethodInfoPtr_set_Actor_Public_set_Void_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670116);
			ClaimsIdentity.NativeMethodInfoPtr_get_Claims_Public_Virtual_New_get_IEnumerable_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670117);
			ClaimsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670118);
			ClaimsIdentity.NativeMethodInfoPtr_get_NameClaimType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670119);
			ClaimsIdentity.NativeMethodInfoPtr_Clone_Public_Virtual_New_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670120);
			ClaimsIdentity.NativeMethodInfoPtr_AddClaim_Public_Virtual_New_Void_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670121);
			ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaims_Private_Void_IEnumerable_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670122);
			ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaim_Private_Void_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670123);
			ClaimsIdentity.NativeMethodInfoPtr_FindFirst_Public_Virtual_New_Claim_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670124);
			ClaimsIdentity.NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670125);
			ClaimsIdentity.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670126);
			ClaimsIdentity.NativeMethodInfoPtr_OnDeserializingMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670127);
			ClaimsIdentity.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670128);
			ClaimsIdentity.NativeMethodInfoPtr_DeserializeClaims_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670129);
			ClaimsIdentity.NativeMethodInfoPtr_SerializeClaims_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670130);
			ClaimsIdentity.NativeMethodInfoPtr_IsCircular_Private_Boolean_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670131);
			ClaimsIdentity.NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670132);
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x000DF19C File Offset: 0x000DD39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000DF1D8 File Offset: 0x000DD3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375987, XrefRangeEnd = 1375988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(IEnumerable<Claim> claims)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000DF224 File Offset: 0x000DD424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375988, XrefRangeEnd = 1375989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(claims);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authenticationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(roleType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IIdentity_IEnumerable_1_Claim_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000DF2BC File Offset: 0x000DD4BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1376077, RefRangeEnd = 1376086, XrefRangeStart = 1375989, XrefRangeEnd = 1376077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(claims);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authenticationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(roleType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkAuthType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Internal_Void_IIdentity_IEnumerable_1_Claim_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000DF360 File Offset: 0x000DD560
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1376133, RefRangeEnd = 1376136, XrefRangeStart = 1376086, XrefRangeEnd = 1376133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(ClaimsIdentity other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Protected_Void_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000DF3AC File Offset: 0x000DD5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376136, XrefRangeEnd = 1376164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x000DF410 File Offset: 0x000DD610
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000DF454 File Offset: 0x000DD654
		// (set) Token: 0x060029C5 RID: 10693 RVA: 0x000DF494 File Offset: 0x000DD694
		public unsafe ClaimsIdentity Actor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_get_Actor_Public_get_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1376174, RefRangeEnd = 1376175, XrefRangeStart = 1376164, XrefRangeEnd = 1376174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_set_Actor_Public_set_Void_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x000DF4D8 File Offset: 0x000DD6D8
		public unsafe virtual IEnumerable<Claim> Claims
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_get_Claims_Public_Virtual_New_get_IEnumerable_1_Claim_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Claim>>(intPtr3) : null;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x000DF524 File Offset: 0x000DD724
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000DF568 File Offset: 0x000DD768
		public unsafe string NameClaimType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_get_NameClaimType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000DF5A0 File Offset: 0x000DD7A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1376188, RefRangeEnd = 1376190, XrefRangeStart = 1376175, XrefRangeEnd = 1376188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ClaimsIdentity Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_Clone_Public_Virtual_New_ClaimsIdentity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000DF5EC File Offset: 0x000DD7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376190, XrefRangeEnd = 1376202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddClaim(Claim claim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_AddClaim_Public_Virtual_New_Void_Claim_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000DF63C File Offset: 0x000DD83C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1376225, RefRangeEnd = 1376228, XrefRangeStart = 1376202, XrefRangeEnd = 1376225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SafeAddClaims(IEnumerable<Claim> claims)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaims_Private_Void_IEnumerable_1_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000DF680 File Offset: 0x000DD880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376228, XrefRangeEnd = 1376234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SafeAddClaim(Claim claim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaim_Private_Void_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x000DF6C4 File Offset: 0x000DD8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376234, XrefRangeEnd = 1376247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Claim FindFirst(string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_FindFirst_Public_Virtual_New_Claim_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr3) : null;
			}
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000DF720 File Offset: 0x000DD920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376247, XrefRangeEnd = 1376254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializingMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000DF768 File Offset: 0x000DD968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376254, XrefRangeEnd = 1376268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializedMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000DF7B0 File Offset: 0x000DD9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376268, XrefRangeEnd = 1376285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializingMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_OnDeserializingMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000DF7F8 File Offset: 0x000DD9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376285, XrefRangeEnd = 1376343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000DF85C File Offset: 0x000DDA5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1376380, RefRangeEnd = 1376382, XrefRangeStart = 1376343, XrefRangeEnd = 1376380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeClaims(string serializedClaims)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serializedClaims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_DeserializeClaims_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000DF8A0 File Offset: 0x000DDAA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1376401, RefRangeEnd = 1376403, XrefRangeStart = 1376382, XrefRangeEnd = 1376401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SerializeClaims()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_SerializeClaims_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000DF8D8 File Offset: 0x000DDAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376403, XrefRangeEnd = 1376404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCircular(ClaimsIdentity subject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_IsCircular_Private_Boolean_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x000DF928 File Offset: 0x000DDB28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1376500, RefRangeEnd = 1376501, XrefRangeStart = 1376404, XrefRangeEnd = 1376500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deserialize(SerializationInfo info, StreamingContext context, bool useContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x0000DD17 File Offset: 0x0000BF17
		public ClaimsIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000DF990 File Offset: 0x000DDB90
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x0000DD20 File Offset: 0x0000BF20
		public unsafe Il2CppStructArray<byte> m_userSerializationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_userSerializationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_userSerializationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000DF9C0 File Offset: 0x000DDBC0
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x0000DD3F File Offset: 0x0000BF3F
		public unsafe List<Claim> m_instanceClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_instanceClaims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Claim>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_instanceClaims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x000DF9F0 File Offset: 0x000DDBF0
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x0000DD5E File Offset: 0x0000BF5E
		public unsafe Collection<IEnumerable<Claim>> m_externalClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_externalClaims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collection<IEnumerable<Claim>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_externalClaims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x000DFA20 File Offset: 0x000DDC20
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x0000DD7D File Offset: 0x0000BF7D
		public unsafe string m_nameType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_nameType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_nameType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x000DFA48 File Offset: 0x000DDC48
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x0000DD9C File Offset: 0x0000BF9C
		public unsafe string m_roleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_roleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_roleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x000DFA70 File Offset: 0x000DDC70
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x0000DDBB File Offset: 0x0000BFBB
		public unsafe string m_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x000DFA98 File Offset: 0x000DDC98
		// (set) Token: 0x060029E4 RID: 10724 RVA: 0x0000DDDA File Offset: 0x0000BFDA
		public unsafe ClaimsIdentity m_actor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_actor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_actor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x000DFAC8 File Offset: 0x000DDCC8
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x0000DDF9 File Offset: 0x0000BFF9
		public unsafe string m_authenticationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_authenticationType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_authenticationType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x000DFAF0 File Offset: 0x000DDCF0
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x0000DE18 File Offset: 0x0000C018
		public unsafe Object m_bootstrapContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_bootstrapContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_bootstrapContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x000DFB20 File Offset: 0x000DDD20
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x0000DE37 File Offset: 0x0000C037
		public unsafe string m_label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x000DFB48 File Offset: 0x000DDD48
		// (set) Token: 0x060029EC RID: 10732 RVA: 0x0000DE56 File Offset: 0x0000C056
		public unsafe string m_serializedNameType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedNameType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedNameType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x000DFB70 File Offset: 0x000DDD70
		// (set) Token: 0x060029EE RID: 10734 RVA: 0x0000DE75 File Offset: 0x0000C075
		public unsafe string m_serializedRoleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedRoleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedRoleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x000DFB98 File Offset: 0x000DDD98
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x0000DE94 File Offset: 0x0000C094
		public unsafe string m_serializedClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedClaims);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedClaims), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400239C RID: 9116
		private static readonly IntPtr NativeFieldInfoPtr_m_userSerializationData;

		// Token: 0x0400239D RID: 9117
		private static readonly IntPtr NativeFieldInfoPtr_m_instanceClaims;

		// Token: 0x0400239E RID: 9118
		private static readonly IntPtr NativeFieldInfoPtr_m_externalClaims;

		// Token: 0x0400239F RID: 9119
		private static readonly IntPtr NativeFieldInfoPtr_m_nameType;

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeFieldInfoPtr_m_roleType;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeFieldInfoPtr_m_actor;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeFieldInfoPtr_m_authenticationType;

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeFieldInfoPtr_m_bootstrapContext;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeFieldInfoPtr_m_label;

		// Token: 0x040023A6 RID: 9126
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedNameType;

		// Token: 0x040023A7 RID: 9127
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedRoleType;

		// Token: 0x040023A8 RID: 9128
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedClaims;

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Claim_0;

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IIdentity_IEnumerable_1_Claim_String_String_String_0;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IIdentity_IEnumerable_1_Claim_String_String_String_Boolean_0;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ClaimsIdentity_0;

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040023AF RID: 9135
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_New_get_String_0;

		// Token: 0x040023B0 RID: 9136
		private static readonly IntPtr NativeMethodInfoPtr_get_Actor_Public_get_ClaimsIdentity_0;

		// Token: 0x040023B1 RID: 9137
		private static readonly IntPtr NativeMethodInfoPtr_set_Actor_Public_set_Void_ClaimsIdentity_0;

		// Token: 0x040023B2 RID: 9138
		private static readonly IntPtr NativeMethodInfoPtr_get_Claims_Public_Virtual_New_get_IEnumerable_1_Claim_0;

		// Token: 0x040023B3 RID: 9139
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x040023B4 RID: 9140
		private static readonly IntPtr NativeMethodInfoPtr_get_NameClaimType_Public_get_String_0;

		// Token: 0x040023B5 RID: 9141
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_ClaimsIdentity_0;

		// Token: 0x040023B6 RID: 9142
		private static readonly IntPtr NativeMethodInfoPtr_AddClaim_Public_Virtual_New_Void_Claim_0;

		// Token: 0x040023B7 RID: 9143
		private static readonly IntPtr NativeMethodInfoPtr_SafeAddClaims_Private_Void_IEnumerable_1_Claim_0;

		// Token: 0x040023B8 RID: 9144
		private static readonly IntPtr NativeMethodInfoPtr_SafeAddClaim_Private_Void_Claim_0;

		// Token: 0x040023B9 RID: 9145
		private static readonly IntPtr NativeMethodInfoPtr_FindFirst_Public_Virtual_New_Claim_String_0;

		// Token: 0x040023BA RID: 9146
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0;

		// Token: 0x040023BB RID: 9147
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0;

		// Token: 0x040023BC RID: 9148
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializingMethod_Private_Void_StreamingContext_0;

		// Token: 0x040023BD RID: 9149
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040023BE RID: 9150
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeClaims_Private_Void_String_0;

		// Token: 0x040023BF RID: 9151
		private static readonly IntPtr NativeMethodInfoPtr_SerializeClaims_Private_String_0;

		// Token: 0x040023C0 RID: 9152
		private static readonly IntPtr NativeMethodInfoPtr_IsCircular_Private_Boolean_ClaimsIdentity_0;

		// Token: 0x040023C1 RID: 9153
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_Boolean_0;

		// Token: 0x02000665 RID: 1637
		[ObfuscatedName("System.Security.Claims.ClaimsIdentity+<get_Claims>d__51")]
		public sealed class _get_Claims_d__51 : Object
		{
			// Token: 0x06005B00 RID: 23296 RVA: 0x0019EA44 File Offset: 0x0019CC44
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Claims_d__51()
			{
				Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "<get_Claims>d__51");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr);
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>1__state");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>2__current");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>l__initialThreadId");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>4__this");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<i>5__2");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>7__wrap2");
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670133);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670134);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670135);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670136);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Security_Claims_Claim__get_Current_Private_Virtual_Final_New_get_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670137);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670138);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670139);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670140);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670141);
			}

			// Token: 0x06005B01 RID: 23297 RVA: 0x0019EB9C File Offset: 0x0019CD9C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Claims_d__51(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B02 RID: 23298 RVA: 0x0019EBE4 File Offset: 0x0019CDE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375937, XrefRangeEnd = 1375942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B03 RID: 23299 RVA: 0x0019EC18 File Offset: 0x0019CE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375942, XrefRangeEnd = 1375977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005B04 RID: 23300 RVA: 0x0019EC54 File Offset: 0x0019CE54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375977, XrefRangeEnd = 1375980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001755 RID: 5973
			// (get) Token: 0x06005B05 RID: 23301 RVA: 0x0019EC88 File Offset: 0x0019CE88
			public unsafe Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Security_Claims_Claim__get_Current_Private_Virtual_Final_New_get_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr3) : null;
				}
			}

			// Token: 0x06005B06 RID: 23302 RVA: 0x0019ECC8 File Offset: 0x0019CEC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375980, XrefRangeEnd = 1375985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001756 RID: 5974
			// (get) Token: 0x06005B07 RID: 23303 RVA: 0x0019ECFC File Offset: 0x0019CEFC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B08 RID: 23304 RVA: 0x0019ED3C File Offset: 0x0019CF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375985, XrefRangeEnd = 1375987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Claim> System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Claim>>(intPtr3) : null;
			}

			// Token: 0x06005B09 RID: 23305 RVA: 0x0019ED7C File Offset: 0x0019CF7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005B0A RID: 23306 RVA: 0x00020EE1 File Offset: 0x0001F0E1
			public _get_Claims_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700174F RID: 5967
			// (get) Token: 0x06005B0B RID: 23307 RVA: 0x0019EDBC File Offset: 0x0019CFBC
			// (set) Token: 0x06005B0C RID: 23308 RVA: 0x00020EEA File Offset: 0x0001F0EA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001750 RID: 5968
			// (get) Token: 0x06005B0D RID: 23309 RVA: 0x0019EDE4 File Offset: 0x0019CFE4
			// (set) Token: 0x06005B0E RID: 23310 RVA: 0x00020F05 File Offset: 0x0001F105
			public unsafe Claim __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001751 RID: 5969
			// (get) Token: 0x06005B0F RID: 23311 RVA: 0x0019EE14 File Offset: 0x0019D014
			// (set) Token: 0x06005B10 RID: 23312 RVA: 0x00020F24 File Offset: 0x0001F124
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001752 RID: 5970
			// (get) Token: 0x06005B11 RID: 23313 RVA: 0x0019EE3C File Offset: 0x0019D03C
			// (set) Token: 0x06005B12 RID: 23314 RVA: 0x00020F3F File Offset: 0x0001F13F
			public unsafe ClaimsIdentity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001753 RID: 5971
			// (get) Token: 0x06005B13 RID: 23315 RVA: 0x0019EE6C File Offset: 0x0019D06C
			// (set) Token: 0x06005B14 RID: 23316 RVA: 0x00020F5E File Offset: 0x0001F15E
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x17001754 RID: 5972
			// (get) Token: 0x06005B15 RID: 23317 RVA: 0x0019EE94 File Offset: 0x0019D094
			// (set) Token: 0x06005B16 RID: 23318 RVA: 0x00020F79 File Offset: 0x0001F179
			public unsafe IEnumerator<Claim> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Claim>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A40 RID: 19008
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004A41 RID: 19009
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004A42 RID: 19010
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004A43 RID: 19011
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004A44 RID: 19012
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04004A45 RID: 19013
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04004A46 RID: 19014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004A47 RID: 19015
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004A48 RID: 19016
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004A49 RID: 19017
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004A4A RID: 19018
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Security_Claims_Claim__get_Current_Private_Virtual_Final_New_get_Claim_0;

			// Token: 0x04004A4B RID: 19019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004A4C RID: 19020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004A4D RID: 19021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Claim_0;

			// Token: 0x04004A4E RID: 19022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
