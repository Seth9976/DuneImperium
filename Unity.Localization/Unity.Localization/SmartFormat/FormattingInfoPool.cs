using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Formatting;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x02000037 RID: 55
	public static class FormattingInfoPool : Object
	{
		// Token: 0x0600038E RID: 910 RVA: 0x00017600 File Offset: 0x00015800
		// Note: this type is marked as 'beforefieldinit'.
		static FormattingInfoPool()
		{
			Il2CppClassPointerStore<FormattingInfoPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "FormattingInfoPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattingInfoPool>.NativeClassPtr);
			FormattingInfoPool.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingInfoPool>.NativeClassPtr, "s_Pool");
			FormattingInfoPool.NativeMethodInfoPtr_Get_Public_Static_FormattingInfo_FormatDetails_Format_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfoPool>.NativeClassPtr, 100663939);
			FormattingInfoPool.NativeMethodInfoPtr_Get_Public_Static_FormattingInfo_FormattingInfo_FormatDetails_Format_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfoPool>.NativeClassPtr, 100663940);
			FormattingInfoPool.NativeMethodInfoPtr_Get_Public_Static_FormattingInfo_FormattingInfo_FormatDetails_Placeholder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfoPool>.NativeClassPtr, 100663941);
			FormattingInfoPool.NativeMethodInfoPtr_Release_Public_Static_Void_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfoPool>.NativeClassPtr, 100663942);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00017694 File Offset: 0x00015894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069409, XrefRangeEnd = 1069417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FormattingInfo Get(FormatDetails formatDetails, Format format, Object currentValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatDetails);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfoPool.NativeMethodInfoPtr_Get_Public_Static_FormattingInfo_FormatDetails_Format_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattingInfo>(intPtr3) : null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000176FC File Offset: 0x000158FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1069425, RefRangeEnd = 1069427, XrefRangeStart = 1069417, XrefRangeEnd = 1069425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FormattingInfo Get(FormattingInfo parent, FormatDetails formatDetails, Format format, Object currentValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatDetails);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfoPool.NativeMethodInfoPtr_Get_Public_Static_FormattingInfo_FormattingInfo_FormatDetails_Format_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattingInfo>(intPtr3) : null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00017778 File Offset: 0x00015978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1069435, RefRangeEnd = 1069436, XrefRangeStart = 1069427, XrefRangeEnd = 1069435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FormattingInfo Get(FormattingInfo parent, FormatDetails formatDetails, Placeholder placeholder, Object currentValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatDetails);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(placeholder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfoPool.NativeMethodInfoPtr_Get_Public_Static_FormattingInfo_FormattingInfo_FormatDetails_Placeholder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattingInfo>(intPtr3) : null;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000177F4 File Offset: 0x000159F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1069471, RefRangeEnd = 1069472, XrefRangeStart = 1069436, XrefRangeEnd = 1069471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(FormattingInfo toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfoPool.NativeMethodInfoPtr_Release_Public_Static_Void_FormattingInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000339D File Offset: 0x0000159D
		public FormattingInfoPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0001782C File Offset: 0x00015A2C
		// (set) Token: 0x06000395 RID: 917 RVA: 0x000033A6 File Offset: 0x000015A6
		public unsafe static ObjectPool<FormattingInfo> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormattingInfoPool.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<FormattingInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormattingInfoPool.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_FormattingInfo_FormatDetails_Format_Object_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_FormattingInfo_FormattingInfo_FormatDetails_Format_Object_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_FormattingInfo_FormattingInfo_FormatDetails_Placeholder_Object_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_FormattingInfo_0;

		// Token: 0x02000131 RID: 305
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.FormattingInfoPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D60 RID: 3424 RVA: 0x0003B62C File Offset: 0x0003982C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FormattingInfoPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormattingInfoPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattingInfoPool.__c>.NativeClassPtr);
				FormattingInfoPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingInfoPool.__c>.NativeClassPtr, "<>9");
				FormattingInfoPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfoPool.__c>.NativeClassPtr, 100663945);
				FormattingInfoPool.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfoPool.__c>.NativeClassPtr, 100663946);
				FormattingInfoPool.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfoPool.__c>.NativeClassPtr, 100663947);
			}

			// Token: 0x06000D61 RID: 3425 RVA: 0x0003B6A8 File Offset: 0x000398A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormattingInfoPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfoPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D62 RID: 3426 RVA: 0x0003B6E4 File Offset: 0x000398E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069403, XrefRangeEnd = 1069407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FormattingInfo __cctor_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfoPool.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_FormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattingInfo>(intPtr3) : null;
			}

			// Token: 0x06000D63 RID: 3427 RVA: 0x0003B724 File Offset: 0x00039924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069407, XrefRangeEnd = 1069409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__5_1(FormattingInfo fi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fi);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfoPool.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_FormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D64 RID: 3428 RVA: 0x0000796F File Offset: 0x00005B6F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x06000D65 RID: 3429 RVA: 0x0003B768 File Offset: 0x00039968
			// (set) Token: 0x06000D66 RID: 3430 RVA: 0x00007978 File Offset: 0x00005B78
			public unsafe static FormattingInfoPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormattingInfoPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormattingInfoPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormattingInfoPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400094D RID: 2381
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400094E RID: 2382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400094F RID: 2383
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_FormattingInfo_0;

			// Token: 0x04000950 RID: 2384
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_FormattingInfo_0;
		}
	}
}
