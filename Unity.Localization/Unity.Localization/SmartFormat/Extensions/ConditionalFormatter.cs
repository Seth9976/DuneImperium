using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000064 RID: 100
	[Serializable]
	public class ConditionalFormatter : FormatterBase
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x0001B020 File Offset: 0x00019220
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionalFormatter()
		{
			Il2CppClassPointerStore<ConditionalFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "ConditionalFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalFormatter>.NativeClassPtr);
			ConditionalFormatter.NativeFieldInfoPtr__complexConditionPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalFormatter>.NativeClassPtr, "_complexConditionPattern");
			ConditionalFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatter>.NativeClassPtr, 100664176);
			ConditionalFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatter>.NativeClassPtr, 100664177);
			ConditionalFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatter>.NativeClassPtr, 100664178);
			ConditionalFormatter.NativeMethodInfoPtr_TryEvaluateCondition_Private_Static_Boolean_Format_Decimal_byref_Boolean_byref_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatter>.NativeClassPtr, 100664179);
			ConditionalFormatter.NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatter>.NativeClassPtr, 100664180);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001B0C8 File Offset: 0x000192C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1071545, RefRangeEnd = 1071549, XrefRangeStart = 1071543, XrefRangeEnd = 1071545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0001B104 File Offset: 0x00019304
		public unsafe override Il2CppStringArray DefaultNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071549, XrefRangeEnd = 1071561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001B150 File Offset: 0x00019350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071561, XrefRangeEnd = 1071607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001B1A8 File Offset: 0x000193A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071687, RefRangeEnd = 1071688, XrefRangeStart = 1071607, XrefRangeEnd = 1071687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryEvaluateCondition(Format parameter, Decimal value, out bool conditionResult, out Format outputItem)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &conditionResult;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConditionalFormatter.NativeMethodInfoPtr_TryEvaluateCondition_Private_Static_Boolean_Format_Decimal_byref_Boolean_byref_Format_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputItem = ((intPtr4 == 0) ? null : new Format(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0001B228 File Offset: 0x00019428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071688, XrefRangeEnd = 1071715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalFormatter.NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00003DDE File Offset: 0x00001FDE
		public ConditionalFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0001B26C File Offset: 0x0001946C
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00003DE7 File Offset: 0x00001FE7
		public unsafe static Regex _complexConditionPattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConditionalFormatter.NativeFieldInfoPtr__complexConditionPattern, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConditionalFormatter.NativeFieldInfoPtr__complexConditionPattern, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeFieldInfoPtr__complexConditionPattern;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateCondition_Private_Static_Boolean_Format_Decimal_byref_Boolean_byref_Format_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0;
	}
}
