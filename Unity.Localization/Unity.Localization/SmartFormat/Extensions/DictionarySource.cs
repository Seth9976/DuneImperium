using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000067 RID: 103
	[Serializable]
	public class DictionarySource : Object
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x0001B4D4 File Offset: 0x000196D4
		// Note: this type is marked as 'beforefieldinit'.
		static DictionarySource()
		{
			Il2CppClassPointerStore<DictionarySource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "DictionarySource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionarySource>.NativeClassPtr);
			DictionarySource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionarySource>.NativeClassPtr, 100664187);
			DictionarySource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionarySource>.NativeClassPtr, 100664188);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0001B52C File Offset: 0x0001972C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071788, RefRangeEnd = 1071789, XrefRangeStart = 1071780, XrefRangeEnd = 1071788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictionarySource(SmartFormatter formatter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionarySource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionarySource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0001B578 File Offset: 0x00019778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071789, XrefRangeEnd = 1071845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionarySource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00003E0B File Offset: 0x0000200B
		public DictionarySource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0;

		// Token: 0x02000143 RID: 323
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Extensions.DictionarySource+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06000E5E RID: 3678 RVA: 0x0003E7C4 File Offset: 0x0003C9C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DictionarySource.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictionarySource>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionarySource.__c__DisplayClass1_0>.NativeClassPtr);
				DictionarySource.__c__DisplayClass1_0.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionarySource.__c__DisplayClass1_0>.NativeClassPtr, "selector");
				DictionarySource.__c__DisplayClass1_0.NativeFieldInfoPtr_selectorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionarySource.__c__DisplayClass1_0>.NativeClassPtr, "selectorInfo");
				DictionarySource.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionarySource.__c__DisplayClass1_0>.NativeClassPtr, 100664189);
				DictionarySource.__c__DisplayClass1_0.NativeMethodInfoPtr__TryEvaluateSelector_b__0_Internal_Boolean_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionarySource.__c__DisplayClass1_0>.NativeClassPtr, 100664190);
			}

			// Token: 0x06000E5F RID: 3679 RVA: 0x0003E840 File Offset: 0x0003CA40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionarySource.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionarySource.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E60 RID: 3680 RVA: 0x0003E87C File Offset: 0x0003CA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071773, XrefRangeEnd = 1071780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryEvaluateSelector_b__0(KeyValuePair<string, Object> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionarySource.__c__DisplayClass1_0.NativeMethodInfoPtr__TryEvaluateSelector_b__0_Internal_Boolean_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000E61 RID: 3681 RVA: 0x00007FDB File Offset: 0x000061DB
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003DE RID: 990
			// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0003E8D0 File Offset: 0x0003CAD0
			// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00007FE4 File Offset: 0x000061E4
			public unsafe string selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionarySource.__c__DisplayClass1_0.NativeFieldInfoPtr_selector);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionarySource.__c__DisplayClass1_0.NativeFieldInfoPtr_selector), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170003DF RID: 991
			// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0003E8F8 File Offset: 0x0003CAF8
			// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00008003 File Offset: 0x00006203
			public unsafe ISelectorInfo selectorInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionarySource.__c__DisplayClass1_0.NativeFieldInfoPtr_selectorInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectorInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionarySource.__c__DisplayClass1_0.NativeFieldInfoPtr_selectorInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009E5 RID: 2533
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x040009E6 RID: 2534
			private static readonly IntPtr NativeFieldInfoPtr_selectorInfo;

			// Token: 0x040009E7 RID: 2535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009E8 RID: 2536
			private static readonly IntPtr NativeMethodInfoPtr__TryEvaluateSelector_b__0_Internal_Boolean_KeyValuePair_2_String_Object_0;
		}
	}
}
