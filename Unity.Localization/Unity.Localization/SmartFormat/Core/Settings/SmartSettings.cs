using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.SmartFormat.Core.Settings
{
	// Token: 0x02000077 RID: 119
	[Serializable]
	public class SmartSettings : Object
	{
		// Token: 0x06000567 RID: 1383 RVA: 0x0001DC50 File Offset: 0x0001BE50
		// Note: this type is marked as 'beforefieldinit'.
		static SmartSettings()
		{
			Il2CppClassPointerStore<SmartSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Settings", "SmartSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr);
			SmartSettings.NativeFieldInfoPtr_m_FormatErrorAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, "m_FormatErrorAction");
			SmartSettings.NativeFieldInfoPtr_m_ParseErrorAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, "m_ParseErrorAction");
			SmartSettings.NativeFieldInfoPtr_m_CaseSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, "m_CaseSensitivity");
			SmartSettings.NativeFieldInfoPtr_m_ConvertCharacterStringLiterals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, "m_ConvertCharacterStringLiterals");
			SmartSettings.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664308);
			SmartSettings.NativeMethodInfoPtr_get_FormatErrorAction_Public_get_ErrorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664309);
			SmartSettings.NativeMethodInfoPtr_set_FormatErrorAction_Public_set_Void_ErrorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664310);
			SmartSettings.NativeMethodInfoPtr_get_ParseErrorAction_Public_get_ErrorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664311);
			SmartSettings.NativeMethodInfoPtr_set_ParseErrorAction_Public_set_Void_ErrorAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664312);
			SmartSettings.NativeMethodInfoPtr_get_CaseSensitivity_Public_get_CaseSensitivityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664313);
			SmartSettings.NativeMethodInfoPtr_set_CaseSensitivity_Public_set_Void_CaseSensitivityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664314);
			SmartSettings.NativeMethodInfoPtr_get_ConvertCharacterStringLiterals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664315);
			SmartSettings.NativeMethodInfoPtr_set_ConvertCharacterStringLiterals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664316);
			SmartSettings.NativeMethodInfoPtr_GetCaseSensitivityComparer_Internal_IEqualityComparer_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664317);
			SmartSettings.NativeMethodInfoPtr_GetCaseSensitivityComparison_Internal_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr, 100664318);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0001DDAC File Offset: 0x0001BFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073195, RefRangeEnd = 1073196, XrefRangeStart = 1073194, XrefRangeEnd = 1073195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmartSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0001DDE8 File Offset: 0x0001BFE8
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0001DE24 File Offset: 0x0001C024
		public unsafe ErrorAction FormatErrorAction
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr_get_FormatErrorAction_Public_get_ErrorAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr_set_FormatErrorAction_Public_set_Void_ErrorAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0001DE64 File Offset: 0x0001C064
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0001DEA0 File Offset: 0x0001C0A0
		public unsafe ErrorAction ParseErrorAction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr_get_ParseErrorAction_Public_get_ErrorAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr_set_ParseErrorAction_Public_set_Void_ErrorAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0001DF1C File Offset: 0x0001C11C
		public unsafe CaseSensitivityType CaseSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr_get_CaseSensitivity_Public_get_CaseSensitivityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr_set_CaseSensitivity_Public_set_Void_CaseSensitivityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0001DF5C File Offset: 0x0001C15C
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0001DF98 File Offset: 0x0001C198
		public unsafe bool ConvertCharacterStringLiterals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr_get_ConvertCharacterStringLiterals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr_set_ConvertCharacterStringLiterals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001DFD8 File Offset: 0x0001C1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073196, XrefRangeEnd = 1073203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEqualityComparer<string> GetCaseSensitivityComparer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr_GetCaseSensitivityComparer_Internal_IEqualityComparer_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<string>>(intPtr3) : null;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001E018 File Offset: 0x0001C218
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1073203, RefRangeEnd = 1073206, XrefRangeStart = 1073203, XrefRangeEnd = 1073203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringComparison GetCaseSensitivityComparison()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartSettings.NativeMethodInfoPtr_GetCaseSensitivityComparison_Internal_StringComparison_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00004101 File Offset: 0x00002301
		public SmartSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001E054 File Offset: 0x0001C254
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x0000410A File Offset: 0x0000230A
		public unsafe ErrorAction m_FormatErrorAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartSettings.NativeFieldInfoPtr_m_FormatErrorAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartSettings.NativeFieldInfoPtr_m_FormatErrorAction)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001E07C File Offset: 0x0001C27C
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00004125 File Offset: 0x00002325
		public unsafe ErrorAction m_ParseErrorAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartSettings.NativeFieldInfoPtr_m_ParseErrorAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartSettings.NativeFieldInfoPtr_m_ParseErrorAction)) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0001E0A4 File Offset: 0x0001C2A4
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00004140 File Offset: 0x00002340
		public unsafe CaseSensitivityType m_CaseSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartSettings.NativeFieldInfoPtr_m_CaseSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartSettings.NativeFieldInfoPtr_m_CaseSensitivity)) = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001E0CC File Offset: 0x0001C2CC
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x0000415B File Offset: 0x0000235B
		public unsafe bool m_ConvertCharacterStringLiterals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartSettings.NativeFieldInfoPtr_m_ConvertCharacterStringLiterals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartSettings.NativeFieldInfoPtr_m_ConvertCharacterStringLiterals)) = value;
			}
		}

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_m_FormatErrorAction;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_m_ParseErrorAction;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_m_CaseSensitivity;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr_m_ConvertCharacterStringLiterals;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatErrorAction_Public_get_ErrorAction_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_set_FormatErrorAction_Public_set_Void_ErrorAction_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_get_ParseErrorAction_Public_get_ErrorAction_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_set_ParseErrorAction_Public_set_Void_ErrorAction_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_get_CaseSensitivity_Public_get_CaseSensitivityType_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_set_CaseSensitivity_Public_set_Void_CaseSensitivityType_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_get_ConvertCharacterStringLiterals_Public_get_Boolean_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_set_ConvertCharacterStringLiterals_Public_set_Void_Boolean_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_GetCaseSensitivityComparer_Internal_IEqualityComparer_1_String_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_GetCaseSensitivityComparison_Internal_StringComparison_0;
	}
}
