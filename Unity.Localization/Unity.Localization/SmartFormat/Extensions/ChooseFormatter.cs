using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000063 RID: 99
	[Serializable]
	public class ChooseFormatter : FormatterBase
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x0001AD20 File Offset: 0x00018F20
		// Note: this type is marked as 'beforefieldinit'.
		static ChooseFormatter()
		{
			Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "ChooseFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr);
			ChooseFormatter.NativeFieldInfoPtr_m_SplitChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr, "m_SplitChar");
			ChooseFormatter.NativeMethodInfoPtr_get_SplitChar_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr, 100664169);
			ChooseFormatter.NativeMethodInfoPtr_set_SplitChar_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr, 100664170);
			ChooseFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr, 100664171);
			ChooseFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr, 100664172);
			ChooseFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr, 100664173);
			ChooseFormatter.NativeMethodInfoPtr_DetermineChosenFormat_Private_Static_Format_IFormattingInfo_IList_1_Format_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr, 100664174);
			ChooseFormatter.NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr, 100664175);
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0001ADF0 File Offset: 0x00018FF0
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x0001AE2C File Offset: 0x0001902C
		public unsafe char SplitChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseFormatter.NativeMethodInfoPtr_get_SplitChar_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseFormatter.NativeMethodInfoPtr_set_SplitChar_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0001AE6C File Offset: 0x0001906C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071466, RefRangeEnd = 1071467, XrefRangeStart = 1071464, XrefRangeEnd = 1071466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChooseFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0001AEA8 File Offset: 0x000190A8
		public unsafe override Il2CppStringArray DefaultNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071467, XrefRangeEnd = 1071476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChooseFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0001AEF4 File Offset: 0x000190F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071476, XrefRangeEnd = 1071497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChooseFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001AF4C File Offset: 0x0001914C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071518, RefRangeEnd = 1071519, XrefRangeStart = 1071497, XrefRangeEnd = 1071518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Format DetermineChosenFormat(IFormattingInfo formattingInfo, IList<Format> choiceFormats, Il2CppStringArray chooseOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choiceFormats);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chooseOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseFormatter.NativeMethodInfoPtr_DetermineChosenFormat_Private_Static_Format_IFormattingInfo_IList_1_Format_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0001AFB4 File Offset: 0x000191B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071519, XrefRangeEnd = 1071543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseFormatter.NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00003DBA File Offset: 0x00001FBA
		public ChooseFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0001AFF8 File Offset: 0x000191F8
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00003DC3 File Offset: 0x00001FC3
		public unsafe char m_SplitChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseFormatter.NativeFieldInfoPtr_m_SplitChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseFormatter.NativeFieldInfoPtr_m_SplitChar)) = value;
			}
		}

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr_m_SplitChar;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_get_SplitChar_Public_get_Char_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_set_SplitChar_Public_set_Void_Char_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_DetermineChosenFormat_Private_Static_Format_IFormattingInfo_IList_1_Format_Il2CppStringArray_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0;
	}
}
