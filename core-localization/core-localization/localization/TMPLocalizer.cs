using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.boardgames.src.localization;
using TMPro;
using UnityEngine;

namespace localization
{
	// Token: 0x0200000B RID: 11
	public class TMPLocalizer : MonoBehaviour
	{
		// Token: 0x0600004A RID: 74 RVA: 0x000033E8 File Offset: 0x000015E8
		// Note: this type is marked as 'beforefieldinit'.
		static TMPLocalizer()
		{
			Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-localization.dll", "localization", "TMPLocalizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr);
			TMPLocalizer.NativeFieldInfoPtr_locKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, "locKey");
			TMPLocalizer.NativeFieldInfoPtr_attemptedGetSubstitutor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, "attemptedGetSubstitutor");
			TMPLocalizer.NativeFieldInfoPtr_substitutor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, "substitutor");
			TMPLocalizer.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, "label");
			TMPLocalizer.NativeMethodInfoPtr_get_LocKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, 100663352);
			TMPLocalizer.NativeMethodInfoPtr_set_LocKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, 100663353);
			TMPLocalizer.NativeMethodInfoPtr_get_Substitutor_Private_get_ILocalizationSubstitutor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, 100663354);
			TMPLocalizer.NativeMethodInfoPtr_get_Label_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, 100663355);
			TMPLocalizer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, 100663356);
			TMPLocalizer.NativeMethodInfoPtr_localizeText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, 100663357);
			TMPLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr, 100663358);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000034F4 File Offset: 0x000016F4
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000352C File Offset: 0x0000172C
		public unsafe string LocKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPLocalizer.NativeMethodInfoPtr_get_LocKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1266646, RefRangeEnd = 1266650, XrefRangeStart = 1266644, XrefRangeEnd = 1266646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPLocalizer.NativeMethodInfoPtr_set_LocKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003570 File Offset: 0x00001770
		public unsafe ILocalizationSubstitutor Substitutor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266650, XrefRangeEnd = 1266661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPLocalizer.NativeMethodInfoPtr_get_Substitutor_Private_get_ILocalizationSubstitutor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILocalizationSubstitutor>(intPtr3) : null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000035B0 File Offset: 0x000017B0
		public unsafe TMP_Text Label
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1266669, RefRangeEnd = 1266670, XrefRangeStart = 1266661, XrefRangeEnd = 1266669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPLocalizer.NativeMethodInfoPtr_get_Label_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000035F0 File Offset: 0x000017F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266670, XrefRangeEnd = 1266671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPLocalizer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003624 File Offset: 0x00001824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1266704, RefRangeEnd = 1266706, XrefRangeStart = 1266671, XrefRangeEnd = 1266704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void localizeText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPLocalizer.NativeMethodInfoPtr_localizeText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003658 File Offset: 0x00001858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266706, XrefRangeEnd = 1266710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMPLocalizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMPLocalizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000223B File Offset: 0x0000043B
		public TMPLocalizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003694 File Offset: 0x00001894
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002244 File Offset: 0x00000444
		public unsafe string locKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPLocalizer.NativeFieldInfoPtr_locKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPLocalizer.NativeFieldInfoPtr_locKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000036BC File Offset: 0x000018BC
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002263 File Offset: 0x00000463
		public unsafe bool attemptedGetSubstitutor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPLocalizer.NativeFieldInfoPtr_attemptedGetSubstitutor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPLocalizer.NativeFieldInfoPtr_attemptedGetSubstitutor)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000036E4 File Offset: 0x000018E4
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000227E File Offset: 0x0000047E
		public unsafe ILocalizationSubstitutor substitutor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPLocalizer.NativeFieldInfoPtr_substitutor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILocalizationSubstitutor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPLocalizer.NativeFieldInfoPtr_substitutor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00003714 File Offset: 0x00001914
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000229D File Offset: 0x0000049D
		public unsafe TMP_Text label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPLocalizer.NativeFieldInfoPtr_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPLocalizer.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_locKey;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_attemptedGetSubstitutor;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_substitutor;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_LocKey_Public_get_String_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_set_LocKey_Public_set_Void_String_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_Substitutor_Private_get_ILocalizationSubstitutor_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_TMP_Text_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_localizeText_Private_Void_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
