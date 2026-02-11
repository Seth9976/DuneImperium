using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Claims
{
	// Token: 0x0200028B RID: 651
	[Serializable]
	public class ClaimsPrincipal : Object
	{
		// Token: 0x060029F1 RID: 10737 RVA: 0x000DFBC0 File Offset: 0x000DDDC0
		// Note: this type is marked as 'beforefieldinit'.
		static ClaimsPrincipal()
		{
			Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Claims", "ClaimsPrincipal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr);
			ClaimsPrincipal.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, "m_version");
			ClaimsPrincipal.NativeFieldInfoPtr_m_serializedClaimsIdentities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, "m_serializedClaimsIdentities");
			ClaimsPrincipal.NativeFieldInfoPtr_m_identities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, "m_identities");
			ClaimsPrincipal.NativeFieldInfoPtr_s_identitySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, "s_identitySelector");
			ClaimsPrincipal.NativeFieldInfoPtr_s_principalSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, "s_principalSelector");
			ClaimsPrincipal.NativeMethodInfoPtr_SelectPrimaryIdentity_Private_Static_ClaimsIdentity_IEnumerable_1_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, 100670142);
			ClaimsPrincipal.NativeMethodInfoPtr_get_ClaimsPrincipalSelector_Public_Static_get_Func_1_ClaimsPrincipal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, 100670143);
			ClaimsPrincipal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, 100670144);
			ClaimsPrincipal.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, 100670145);
			ClaimsPrincipal.NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, 100670146);
			ClaimsPrincipal.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, 100670147);
			ClaimsPrincipal.NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, 100670148);
			ClaimsPrincipal.NativeMethodInfoPtr_DeserializeIdentities_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, 100670149);
			ClaimsPrincipal.NativeMethodInfoPtr_SerializeIdentities_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr, 100670150);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000DFD08 File Offset: 0x000DDF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376501, XrefRangeEnd = 1376523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClaimsIdentity SelectPrimaryIdentity(IEnumerable<ClaimsIdentity> identities)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsPrincipal.NativeMethodInfoPtr_SelectPrimaryIdentity_Private_Static_ClaimsIdentity_IEnumerable_1_ClaimsIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000DFD4C File Offset: 0x000DDF4C
		public unsafe static Func<ClaimsPrincipal> ClaimsPrincipalSelector
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376523, XrefRangeEnd = 1376527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsPrincipal.NativeMethodInfoPtr_get_ClaimsPrincipalSelector_Public_Static_get_Func_1_ClaimsPrincipal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ClaimsPrincipal>>(intPtr3) : null;
			}
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000DFD80 File Offset: 0x000DDF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376527, XrefRangeEnd = 1376539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsPrincipal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsPrincipal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000DFDBC File Offset: 0x000DDFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376539, XrefRangeEnd = 1376568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsPrincipal(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsPrincipal>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsPrincipal.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000DFE20 File Offset: 0x000DE020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376568, XrefRangeEnd = 1376573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializingMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsPrincipal.NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000DFE68 File Offset: 0x000DE068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376573, XrefRangeEnd = 1376578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializedMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsPrincipal.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000DFEB0 File Offset: 0x000DE0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376578, XrefRangeEnd = 1376595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deserialize(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsPrincipal.NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000DFF0C File Offset: 0x000DE10C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1376660, RefRangeEnd = 1376663, XrefRangeStart = 1376595, XrefRangeEnd = 1376660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeIdentities(string identities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(identities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsPrincipal.NativeMethodInfoPtr_DeserializeIdentities_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000DFF50 File Offset: 0x000DE150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1376752, RefRangeEnd = 1376753, XrefRangeStart = 1376663, XrefRangeEnd = 1376752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SerializeIdentities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsPrincipal.NativeMethodInfoPtr_SerializeIdentities_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x0000DEB3 File Offset: 0x0000C0B3
		public ClaimsPrincipal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x000DFF88 File Offset: 0x000DE188
		// (set) Token: 0x060029FD RID: 10749 RVA: 0x0000DEBC File Offset: 0x0000C0BC
		public unsafe string m_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsPrincipal.NativeFieldInfoPtr_m_version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsPrincipal.NativeFieldInfoPtr_m_version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x000DFFB0 File Offset: 0x000DE1B0
		// (set) Token: 0x060029FF RID: 10751 RVA: 0x0000DEDB File Offset: 0x0000C0DB
		public unsafe string m_serializedClaimsIdentities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsPrincipal.NativeFieldInfoPtr_m_serializedClaimsIdentities);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsPrincipal.NativeFieldInfoPtr_m_serializedClaimsIdentities), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x000DFFD8 File Offset: 0x000DE1D8
		// (set) Token: 0x06002A01 RID: 10753 RVA: 0x0000DEFA File Offset: 0x0000C0FA
		public unsafe List<ClaimsIdentity> m_identities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsPrincipal.NativeFieldInfoPtr_m_identities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClaimsIdentity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsPrincipal.NativeFieldInfoPtr_m_identities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x000E0008 File Offset: 0x000DE208
		// (set) Token: 0x06002A03 RID: 10755 RVA: 0x0000DF19 File Offset: 0x0000C119
		public unsafe static Func<IEnumerable<ClaimsIdentity>, ClaimsIdentity> s_identitySelector
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClaimsPrincipal.NativeFieldInfoPtr_s_identitySelector, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<ClaimsIdentity>, ClaimsIdentity>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClaimsPrincipal.NativeFieldInfoPtr_s_identitySelector, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x000E0030 File Offset: 0x000DE230
		// (set) Token: 0x06002A05 RID: 10757 RVA: 0x0000DF2B File Offset: 0x0000C12B
		public unsafe static Func<ClaimsPrincipal> s_principalSelector
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClaimsPrincipal.NativeFieldInfoPtr_s_principalSelector, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ClaimsPrincipal>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClaimsPrincipal.NativeFieldInfoPtr_s_principalSelector, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023C2 RID: 9154
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x040023C3 RID: 9155
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedClaimsIdentities;

		// Token: 0x040023C4 RID: 9156
		private static readonly IntPtr NativeFieldInfoPtr_m_identities;

		// Token: 0x040023C5 RID: 9157
		private static readonly IntPtr NativeFieldInfoPtr_s_identitySelector;

		// Token: 0x040023C6 RID: 9158
		private static readonly IntPtr NativeFieldInfoPtr_s_principalSelector;

		// Token: 0x040023C7 RID: 9159
		private static readonly IntPtr NativeMethodInfoPtr_SelectPrimaryIdentity_Private_Static_ClaimsIdentity_IEnumerable_1_ClaimsIdentity_0;

		// Token: 0x040023C8 RID: 9160
		private static readonly IntPtr NativeMethodInfoPtr_get_ClaimsPrincipalSelector_Public_Static_get_Func_1_ClaimsPrincipal_0;

		// Token: 0x040023C9 RID: 9161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023CA RID: 9162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040023CB RID: 9163
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0;

		// Token: 0x040023CC RID: 9164
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0;

		// Token: 0x040023CD RID: 9165
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040023CE RID: 9166
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeIdentities_Private_Void_String_0;

		// Token: 0x040023CF RID: 9167
		private static readonly IntPtr NativeMethodInfoPtr_SerializeIdentities_Private_String_0;
	}
}
