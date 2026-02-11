using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Claims;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x02000285 RID: 645
	[Serializable]
	public class GenericPrincipal : ClaimsPrincipal
	{
		// Token: 0x0600296B RID: 10603 RVA: 0x000DDC6C File Offset: 0x000DBE6C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericPrincipal()
		{
			Il2CppClassPointerStore<GenericPrincipal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "GenericPrincipal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPrincipal>.NativeClassPtr);
			GenericPrincipal.NativeFieldInfoPtr_m_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrincipal>.NativeClassPtr, "m_identity");
			GenericPrincipal.NativeFieldInfoPtr_m_roles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrincipal>.NativeClassPtr, "m_roles");
			GenericPrincipal.NativeMethodInfoPtr__ctor_Public_Void_IIdentity_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrincipal>.NativeClassPtr, 100670073);
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x000DDCD8 File Offset: 0x000DBED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375680, RefRangeEnd = 1375681, XrefRangeStart = 1375658, XrefRangeEnd = 1375680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericPrincipal(IIdentity identity, Il2CppStringArray roles)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericPrincipal>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrincipal.NativeMethodInfoPtr__ctor_Public_Void_IIdentity_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		public GenericPrincipal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x000DDD38 File Offset: 0x000DBF38
		// (set) Token: 0x0600296F RID: 10607 RVA: 0x0000DAB5 File Offset: 0x0000BCB5
		public unsafe IIdentity m_identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrincipal.NativeFieldInfoPtr_m_identity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IIdentity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrincipal.NativeFieldInfoPtr_m_identity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x000DDD68 File Offset: 0x000DBF68
		// (set) Token: 0x06002971 RID: 10609 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
		public unsafe Il2CppStringArray m_roles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrincipal.NativeFieldInfoPtr_m_roles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrincipal.NativeFieldInfoPtr_m_roles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002362 RID: 9058
		private static readonly IntPtr NativeFieldInfoPtr_m_identity;

		// Token: 0x04002363 RID: 9059
		private static readonly IntPtr NativeFieldInfoPtr_m_roles;

		// Token: 0x04002364 RID: 9060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IIdentity_Il2CppStringArray_0;
	}
}
