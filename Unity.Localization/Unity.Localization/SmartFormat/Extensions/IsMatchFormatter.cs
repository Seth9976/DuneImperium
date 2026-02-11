using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000069 RID: 105
	[Serializable]
	public class IsMatchFormatter : FormatterBase
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x0001B614 File Offset: 0x00019814
		// Note: this type is marked as 'beforefieldinit'.
		static IsMatchFormatter()
		{
			Il2CppClassPointerStore<IsMatchFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "IsMatchFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsMatchFormatter>.NativeClassPtr);
			IsMatchFormatter.NativeFieldInfoPtr__RegexOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsMatchFormatter>.NativeClassPtr, "<RegexOptions>k__BackingField");
			IsMatchFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsMatchFormatter>.NativeClassPtr, 100664192);
			IsMatchFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsMatchFormatter>.NativeClassPtr, 100664193);
			IsMatchFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsMatchFormatter>.NativeClassPtr, 100664194);
			IsMatchFormatter.NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsMatchFormatter>.NativeClassPtr, 100664195);
			IsMatchFormatter.NativeMethodInfoPtr_get_RegexOptions_Public_get_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsMatchFormatter>.NativeClassPtr, 100664196);
			IsMatchFormatter.NativeMethodInfoPtr_set_RegexOptions_Public_set_Void_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsMatchFormatter>.NativeClassPtr, 100664197);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0001B6D0 File Offset: 0x000198D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1071545, RefRangeEnd = 1071549, XrefRangeStart = 1071545, XrefRangeEnd = 1071549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IsMatchFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsMatchFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsMatchFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0001B70C File Offset: 0x0001990C
		public unsafe override Il2CppStringArray DefaultNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071865, XrefRangeEnd = 1071871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IsMatchFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0001B758 File Offset: 0x00019958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071871, XrefRangeEnd = 1071900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IsMatchFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0001B7B0 File Offset: 0x000199B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071900, XrefRangeEnd = 1071923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsMatchFormatter.NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0001B7F4 File Offset: 0x000199F4
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x0001B830 File Offset: 0x00019A30
		public unsafe RegexOptions RegexOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsMatchFormatter.NativeMethodInfoPtr_get_RegexOptions_Public_get_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsMatchFormatter.NativeMethodInfoPtr_set_RegexOptions_Public_set_Void_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00003E56 File Offset: 0x00002056
		public IsMatchFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0001B870 File Offset: 0x00019A70
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00003E5F File Offset: 0x0000205F
		public unsafe RegexOptions _RegexOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsMatchFormatter.NativeFieldInfoPtr__RegexOptions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsMatchFormatter.NativeFieldInfoPtr__RegexOptions_k__BackingField)) = value;
			}
		}

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr__RegexOptions_k__BackingField;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_get_RegexOptions_Public_get_RegexOptions_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_set_RegexOptions_Public_set_Void_RegexOptions_0;
	}
}
