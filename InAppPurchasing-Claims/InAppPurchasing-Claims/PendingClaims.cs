using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace iap.claims
{
	// Token: 0x02000009 RID: 9
	public class PendingClaims : Object
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00003DF0 File Offset: 0x00001FF0
		// Note: this type is marked as 'beforefieldinit'.
		static PendingClaims()
		{
			Il2CppClassPointerStore<PendingClaims>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Claims.dll", "iap.claims", "PendingClaims");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingClaims>.NativeClassPtr);
			PendingClaims.NativeFieldInfoPtr_Claims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingClaims>.NativeClassPtr, "Claims");
			PendingClaims.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingClaims>.NativeClassPtr, 100663346);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003E48 File Offset: 0x00002048
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PendingClaims()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingClaims>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingClaims.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000023EB File Offset: 0x000005EB
		public PendingClaims(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003E84 File Offset: 0x00002084
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000023F4 File Offset: 0x000005F4
		public unsafe Dictionary<string, List<ArchetypeID>> Claims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingClaims.NativeFieldInfoPtr_Claims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingClaims.NativeFieldInfoPtr_Claims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_Claims;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
