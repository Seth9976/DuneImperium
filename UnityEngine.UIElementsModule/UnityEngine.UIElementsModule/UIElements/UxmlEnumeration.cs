using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000213 RID: 531
	public class UxmlEnumeration : UxmlTypeRestriction
	{
		// Token: 0x0600285D RID: 10333 RVA: 0x000B156C File Offset: 0x000AF76C
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlEnumeration()
		{
			Il2CppClassPointerStore<UxmlEnumeration>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlEnumeration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlEnumeration>.NativeClassPtr);
			UxmlEnumeration.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlEnumeration>.NativeClassPtr, "m_Values");
			UxmlEnumeration.NativeMethodInfoPtr_get_values_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumeration>.NativeClassPtr, 100669355);
			UxmlEnumeration.NativeMethodInfoPtr_set_values_Public_set_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumeration>.NativeClassPtr, 100669356);
			UxmlEnumeration.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_UxmlTypeRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumeration>.NativeClassPtr, 100669357);
			UxmlEnumeration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlEnumeration>.NativeClassPtr, 100669358);
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x000B1600 File Offset: 0x000AF800
		// (set) Token: 0x0600285F RID: 10335 RVA: 0x000B1640 File Offset: 0x000AF840
		public unsafe IEnumerable<string> values
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlEnumeration.NativeMethodInfoPtr_get_values_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 344358, RefRangeEnd = 344359, XrefRangeStart = 344354, XrefRangeEnd = 344358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlEnumeration.NativeMethodInfoPtr_set_values_Public_set_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000B1684 File Offset: 0x000AF884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344359, XrefRangeEnd = 344376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(UxmlTypeRestriction other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlEnumeration.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_UxmlTypeRestriction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000B16DC File Offset: 0x000AF8DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344384, RefRangeEnd = 344385, XrefRangeStart = 344376, XrefRangeEnd = 344384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlEnumeration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlEnumeration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlEnumeration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00010494 File Offset: 0x0000E694
		public UxmlEnumeration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x000B1718 File Offset: 0x000AF918
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x0001049D File Offset: 0x0000E69D
		public unsafe List<string> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlEnumeration.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlEnumeration.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeMethodInfoPtr_get_values_Public_get_IEnumerable_1_String_0;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeMethodInfoPtr_set_values_Public_set_Void_IEnumerable_1_String_0;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_UxmlTypeRestriction_0;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
