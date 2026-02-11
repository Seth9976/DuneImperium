using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Utilities;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x0200006D RID: 109
	public class CustomPluralRuleProvider : Object
	{
		// Token: 0x06000517 RID: 1303 RVA: 0x0001C9AC File Offset: 0x0001ABAC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomPluralRuleProvider()
		{
			Il2CppClassPointerStore<CustomPluralRuleProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "CustomPluralRuleProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomPluralRuleProvider>.NativeClassPtr);
			CustomPluralRuleProvider.NativeFieldInfoPtr__pluralRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPluralRuleProvider>.NativeClassPtr, "_pluralRule");
			CustomPluralRuleProvider.NativeMethodInfoPtr__ctor_Public_Void_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPluralRuleProvider>.NativeClassPtr, 100664260);
			CustomPluralRuleProvider.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPluralRuleProvider>.NativeClassPtr, 100664261);
			CustomPluralRuleProvider.NativeMethodInfoPtr_GetPluralRule_Public_PluralRuleDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPluralRuleProvider>.NativeClassPtr, 100664262);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001CA2C File Offset: 0x0001AC2C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomPluralRuleProvider(PluralRules.PluralRuleDelegate pluralRule)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomPluralRuleProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pluralRule);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomPluralRuleProvider.NativeMethodInfoPtr__ctor_Public_Void_PluralRuleDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001CA78 File Offset: 0x0001AC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072586, XrefRangeEnd = 1072593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomPluralRuleProvider.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001CAC8 File Offset: 0x0001ACC8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PluralRules.PluralRuleDelegate GetPluralRule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomPluralRuleProvider.NativeMethodInfoPtr_GetPluralRule_Public_PluralRuleDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00003F5E File Offset: 0x0000215E
		public CustomPluralRuleProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0001CB08 File Offset: 0x0001AD08
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00003F67 File Offset: 0x00002167
		public unsafe PluralRules.PluralRuleDelegate _pluralRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPluralRuleProvider.NativeFieldInfoPtr__pluralRule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPluralRuleProvider.NativeFieldInfoPtr__pluralRule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr__pluralRule;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PluralRuleDelegate_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_GetPluralRule_Public_PluralRuleDelegate_0;
	}
}
