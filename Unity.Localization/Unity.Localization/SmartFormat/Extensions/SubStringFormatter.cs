using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x0200006F RID: 111
	[Serializable]
	public class SubStringFormatter : FormatterBase
	{
		// Token: 0x06000527 RID: 1319 RVA: 0x0001CD00 File Offset: 0x0001AF00
		// Note: this type is marked as 'beforefieldinit'.
		static SubStringFormatter()
		{
			Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "SubStringFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr);
			SubStringFormatter.NativeFieldInfoPtr_m_ParameterDelimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, "m_ParameterDelimiter");
			SubStringFormatter.NativeFieldInfoPtr_m_NullDisplayString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, "m_NullDisplayString");
			SubStringFormatter.NativeFieldInfoPtr_m_OutOfRangeBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, "m_OutOfRangeBehavior");
			SubStringFormatter.NativeMethodInfoPtr_get_OutOfRangeBehavior_Public_get_SubStringOutOfRangeBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, 100664269);
			SubStringFormatter.NativeMethodInfoPtr_set_OutOfRangeBehavior_Public_set_Void_SubStringOutOfRangeBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, 100664270);
			SubStringFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, 100664271);
			SubStringFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, 100664272);
			SubStringFormatter.NativeMethodInfoPtr_get_ParameterDelimiter_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, 100664273);
			SubStringFormatter.NativeMethodInfoPtr_set_ParameterDelimiter_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, 100664274);
			SubStringFormatter.NativeMethodInfoPtr_get_NullDisplayString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, 100664275);
			SubStringFormatter.NativeMethodInfoPtr_set_NullDisplayString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, 100664276);
			SubStringFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr, 100664277);
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0001CE20 File Offset: 0x0001B020
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x0001CE5C File Offset: 0x0001B05C
		public unsafe SubStringFormatter.SubStringOutOfRangeBehavior OutOfRangeBehavior
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubStringFormatter.NativeMethodInfoPtr_get_OutOfRangeBehavior_Public_get_SubStringOutOfRangeBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubStringFormatter.NativeMethodInfoPtr_set_OutOfRangeBehavior_Public_set_Void_SubStringOutOfRangeBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0001CE9C File Offset: 0x0001B09C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1072788, RefRangeEnd = 1072789, XrefRangeStart = 1072782, XrefRangeEnd = 1072788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubStringFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubStringFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubStringFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0001CED8 File Offset: 0x0001B0D8
		public unsafe override Il2CppStringArray DefaultNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072789, XrefRangeEnd = 1072795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubStringFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0001CF24 File Offset: 0x0001B124
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x0001CF60 File Offset: 0x0001B160
		public unsafe char ParameterDelimiter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubStringFormatter.NativeMethodInfoPtr_get_ParameterDelimiter_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubStringFormatter.NativeMethodInfoPtr_set_ParameterDelimiter_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0001CFA0 File Offset: 0x0001B1A0
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x0001CFD8 File Offset: 0x0001B1D8
		public unsafe string NullDisplayString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubStringFormatter.NativeMethodInfoPtr_get_NullDisplayString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubStringFormatter.NativeMethodInfoPtr_set_NullDisplayString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0001D01C File Offset: 0x0001B21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072795, XrefRangeEnd = 1072815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubStringFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00003FC0 File Offset: 0x000021C0
		public SubStringFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0001D074 File Offset: 0x0001B274
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00003FC9 File Offset: 0x000021C9
		public unsafe char m_ParameterDelimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubStringFormatter.NativeFieldInfoPtr_m_ParameterDelimiter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubStringFormatter.NativeFieldInfoPtr_m_ParameterDelimiter)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0001D09C File Offset: 0x0001B29C
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00003FE4 File Offset: 0x000021E4
		public unsafe string m_NullDisplayString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubStringFormatter.NativeFieldInfoPtr_m_NullDisplayString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubStringFormatter.NativeFieldInfoPtr_m_NullDisplayString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00004003 File Offset: 0x00002203
		public unsafe SubStringFormatter.SubStringOutOfRangeBehavior m_OutOfRangeBehavior
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubStringFormatter.NativeFieldInfoPtr_m_OutOfRangeBehavior);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubStringFormatter.NativeFieldInfoPtr_m_OutOfRangeBehavior)) = value;
			}
		}

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_m_ParameterDelimiter;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_m_NullDisplayString;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_m_OutOfRangeBehavior;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_get_OutOfRangeBehavior_Public_get_SubStringOutOfRangeBehavior_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_set_OutOfRangeBehavior_Public_set_Void_SubStringOutOfRangeBehavior_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterDelimiter_Public_get_Char_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_set_ParameterDelimiter_Public_set_Void_Char_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_get_NullDisplayString_Public_get_String_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_set_NullDisplayString_Public_set_Void_String_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0;

		// Token: 0x0200014A RID: 330
		public enum SubStringOutOfRangeBehavior
		{
			// Token: 0x04000A0C RID: 2572
			ReturnEmptyString,
			// Token: 0x04000A0D RID: 2573
			ReturnStartIndexToEndOfString,
			// Token: 0x04000A0E RID: 2574
			ThrowException
		}
	}
}
