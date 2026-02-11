using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200007B RID: 123
	public class UnitPathGroupOverride : MonoBehaviour
	{
		// Token: 0x06000750 RID: 1872 RVA: 0x000219C0 File Offset: 0x0001FBC0
		// Note: this type is marked as 'beforefieldinit'.
		static UnitPathGroupOverride()
		{
			Il2CppClassPointerStore<UnitPathGroupOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "UnitPathGroupOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitPathGroupOverride>.NativeClassPtr);
			UnitPathGroupOverride.NativeFieldInfoPtr_keysToOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPathGroupOverride>.NativeClassPtr, "keysToOverride");
			UnitPathGroupOverride.NativeMethodInfoPtr_AttemptOverrideKey_Public_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPathGroupOverride>.NativeClassPtr, 100664288);
			UnitPathGroupOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPathGroupOverride>.NativeClassPtr, 100664289);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00021A2C File Offset: 0x0001FC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114229, XrefRangeEnd = 1114242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AttemptOverrideKey(string key, out string overrideKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitPathGroupOverride.NativeMethodInfoPtr_AttemptOverrideKey_Public_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			overrideKey = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00021AA0 File Offset: 0x0001FCA0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitPathGroupOverride()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitPathGroupOverride>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPathGroupOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x000059ED File Offset: 0x00003BED
		public UnitPathGroupOverride(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00021ADC File Offset: 0x0001FCDC
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x000059F6 File Offset: 0x00003BF6
		public unsafe List<PathKeyOverride> keysToOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroupOverride.NativeFieldInfoPtr_keysToOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathKeyOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroupOverride.NativeFieldInfoPtr_keysToOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeFieldInfoPtr_keysToOverride;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_AttemptOverrideKey_Public_Virtual_New_Boolean_String_byref_String_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
