using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.data
{
	// Token: 0x0200019A RID: 410
	public class ValidStringsScriptableObject : ScriptableObject
	{
		// Token: 0x0600122F RID: 4655 RVA: 0x000578C8 File Offset: 0x00055AC8
		// Note: this type is marked as 'beforefieldinit'.
		static ValidStringsScriptableObject()
		{
			Il2CppClassPointerStore<ValidStringsScriptableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "ValidStringsScriptableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidStringsScriptableObject>.NativeClassPtr);
			ValidStringsScriptableObject.NativeFieldInfoPtr_validStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidStringsScriptableObject>.NativeClassPtr, "validStrings");
			ValidStringsScriptableObject.NativeMethodInfoPtr_get_ValidStrings_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidStringsScriptableObject>.NativeClassPtr, 100665841);
			ValidStringsScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidStringsScriptableObject>.NativeClassPtr, 100665842);
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00057934 File Offset: 0x00055B34
		public unsafe Il2CppStringArray ValidStrings
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidStringsScriptableObject.NativeMethodInfoPtr_get_ValidStrings_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00057974 File Offset: 0x00055B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515747, XrefRangeEnd = 515752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidStringsScriptableObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidStringsScriptableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidStringsScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		public ValidStringsScriptableObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x000579B0 File Offset: 0x00055BB0
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x0000AABD File Offset: 0x00008CBD
		public unsafe Il2CppStringArray validStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidStringsScriptableObject.NativeFieldInfoPtr_validStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidStringsScriptableObject.NativeFieldInfoPtr_validStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeFieldInfoPtr_validStrings;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidStrings_Public_get_Il2CppStringArray_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
