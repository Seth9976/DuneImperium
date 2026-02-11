using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000AC RID: 172
	public class PseudoLocale : Locale
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x0002A418 File Offset: 0x00028618
		// Note: this type is marked as 'beforefieldinit'.
		static PseudoLocale()
		{
			Il2CppClassPointerStore<PseudoLocale>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "PseudoLocale");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PseudoLocale>.NativeClassPtr);
			PseudoLocale.NativeFieldInfoPtr_m_Methods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PseudoLocale>.NativeClassPtr, "m_Methods");
			PseudoLocale.NativeMethodInfoPtr_get_Methods_Public_get_List_1_IPseudoLocalizationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PseudoLocale>.NativeClassPtr, 100664820);
			PseudoLocale.NativeMethodInfoPtr_CreatePseudoLocale_Public_Static_PseudoLocale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PseudoLocale>.NativeClassPtr, 100664821);
			PseudoLocale.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PseudoLocale>.NativeClassPtr, 100664822);
			PseudoLocale.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PseudoLocale>.NativeClassPtr, 100664823);
			PseudoLocale.NativeMethodInfoPtr_GetPseudoString_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PseudoLocale>.NativeClassPtr, 100664824);
			PseudoLocale.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PseudoLocale>.NativeClassPtr, 100664825);
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x0002A4D4 File Offset: 0x000286D4
		public unsafe List<IPseudoLocalizationMethod> Methods
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PseudoLocale.NativeMethodInfoPtr_get_Methods_Public_get_List_1_IPseudoLocalizationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IPseudoLocalizationMethod>>(intPtr3) : null;
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0002A514 File Offset: 0x00028714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076870, XrefRangeEnd = 1076876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PseudoLocale CreatePseudoLocale()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PseudoLocale.NativeMethodInfoPtr_CreatePseudoLocale_Public_Static_PseudoLocale_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PseudoLocale>(intPtr3) : null;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0002A548 File Offset: 0x00028748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076876, XrefRangeEnd = 1076929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PseudoLocale()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PseudoLocale>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PseudoLocale.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0002A584 File Offset: 0x00028784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076929, XrefRangeEnd = 1076946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PseudoLocale.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0002A5B8 File Offset: 0x000287B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076946, XrefRangeEnd = 1076968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetPseudoString(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PseudoLocale.NativeMethodInfoPtr_GetPseudoString_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0002A60C File Offset: 0x0002880C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076968, XrefRangeEnd = 1076974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PseudoLocale.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0000541F File Offset: 0x0000361F
		public PseudoLocale(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0002A650 File Offset: 0x00028850
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00005428 File Offset: 0x00003628
		public unsafe List<IPseudoLocalizationMethod> m_Methods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PseudoLocale.NativeFieldInfoPtr_m_Methods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IPseudoLocalizationMethod>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PseudoLocale.NativeFieldInfoPtr_m_Methods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeFieldInfoPtr_m_Methods;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Public_get_List_1_IPseudoLocalizationMethod_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_CreatePseudoLocale_Public_Static_PseudoLocale_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoString_Public_Virtual_New_String_String_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
