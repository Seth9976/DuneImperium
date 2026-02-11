using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Utilities;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000071 RID: 113
	[Serializable]
	public class TimeFormatter : FormatterBase
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x0001D568 File Offset: 0x0001B768
		// Note: this type is marked as 'beforefieldinit'.
		static TimeFormatter()
		{
			Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "TimeFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr);
			TimeFormatter.NativeFieldInfoPtr_m_DefaultFormatOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr, "m_DefaultFormatOptions");
			TimeFormatter.NativeFieldInfoPtr_m_DefaultTwoLetterIsoLanguageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr, "m_DefaultTwoLetterIsoLanguageName");
			TimeFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr, 100664291);
			TimeFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr, 100664292);
			TimeFormatter.NativeMethodInfoPtr_get_DefaultFormatOptions_Public_get_TimeSpanFormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr, 100664293);
			TimeFormatter.NativeMethodInfoPtr_set_DefaultFormatOptions_Public_set_Void_TimeSpanFormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr, 100664294);
			TimeFormatter.NativeMethodInfoPtr_get_DefaultTwoLetterISOLanguageName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr, 100664295);
			TimeFormatter.NativeMethodInfoPtr_set_DefaultTwoLetterISOLanguageName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr, 100664296);
			TimeFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr, 100664297);
			TimeFormatter.NativeMethodInfoPtr_GetTimeTextInfo_Private_TimeTextInfo_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr, 100664298);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0001D660 File Offset: 0x0001B860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1072943, RefRangeEnd = 1072944, XrefRangeStart = 1072930, XrefRangeEnd = 1072943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0001D69C File Offset: 0x0001B89C
		public unsafe override Il2CppStringArray DefaultNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072944, XrefRangeEnd = 1072959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0001D724 File Offset: 0x0001B924
		public unsafe TimeSpanFormatOptions DefaultFormatOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeFormatter.NativeMethodInfoPtr_get_DefaultFormatOptions_Public_get_TimeSpanFormatOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeFormatter.NativeMethodInfoPtr_set_DefaultFormatOptions_Public_set_Void_TimeSpanFormatOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0001D764 File Offset: 0x0001B964
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0001D79C File Offset: 0x0001B99C
		public unsafe string DefaultTwoLetterISOLanguageName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeFormatter.NativeMethodInfoPtr_get_DefaultTwoLetterISOLanguageName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072959, XrefRangeEnd = 1072972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeFormatter.NativeMethodInfoPtr_set_DefaultTwoLetterISOLanguageName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0001D7E0 File Offset: 0x0001B9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072972, XrefRangeEnd = 1073059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0001D838 File Offset: 0x0001BA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073059, XrefRangeEnd = 1073078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeTextInfo GetTimeTextInfo(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeFormatter.NativeMethodInfoPtr_GetTimeTextInfo_Private_TimeTextInfo_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeTextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00004084 File Offset: 0x00002284
		public TimeFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x0001D888 File Offset: 0x0001BA88
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x0000408D File Offset: 0x0000228D
		public unsafe TimeSpanFormatOptions m_DefaultFormatOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeFormatter.NativeFieldInfoPtr_m_DefaultFormatOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeFormatter.NativeFieldInfoPtr_m_DefaultFormatOptions)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x000040A8 File Offset: 0x000022A8
		public unsafe string m_DefaultTwoLetterIsoLanguageName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeFormatter.NativeFieldInfoPtr_m_DefaultTwoLetterIsoLanguageName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeFormatter.NativeFieldInfoPtr_m_DefaultTwoLetterIsoLanguageName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultFormatOptions;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultTwoLetterIsoLanguageName;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultFormatOptions_Public_get_TimeSpanFormatOptions_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultFormatOptions_Public_set_Void_TimeSpanFormatOptions_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultTwoLetterISOLanguageName_Public_get_String_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultTwoLetterISOLanguageName_Public_set_Void_String_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeTextInfo_Private_TimeTextInfo_IFormatProvider_0;
	}
}
