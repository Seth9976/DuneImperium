using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x0200006E RID: 110
	[Serializable]
	public class ReflectionSource : Object
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x0001CB38 File Offset: 0x0001AD38
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionSource()
		{
			Il2CppClassPointerStore<ReflectionSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "ReflectionSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionSource>.NativeClassPtr);
			ReflectionSource.NativeFieldInfoPtr_k_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionSource>.NativeClassPtr, "k_Empty");
			ReflectionSource.NativeFieldInfoPtr_m_TypeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionSource>.NativeClassPtr, "m_TypeCache");
			ReflectionSource.NativeMethodInfoPtr_get_TypeCache_Private_get_Dictionary_2_ValueTuple_2_Type_String_ValueTuple_2_FieldInfo_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSource>.NativeClassPtr, 100664263);
			ReflectionSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSource>.NativeClassPtr, 100664264);
			ReflectionSource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSource>.NativeClassPtr, 100664265);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0001CBCC File Offset: 0x0001ADCC
		public unsafe Dictionary<ValueTuple<Type, string>, ValueTuple<FieldInfo, MethodInfo>> TypeCache
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1072662, RefRangeEnd = 1072666, XrefRangeStart = 1072655, XrefRangeEnd = 1072662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSource.NativeMethodInfoPtr_get_TypeCache_Private_get_Dictionary_2_ValueTuple_2_Type_String_ValueTuple_2_FieldInfo_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<Type, string>, ValueTuple<FieldInfo, MethodInfo>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001CC0C File Offset: 0x0001AE0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1072674, RefRangeEnd = 1072675, XrefRangeStart = 1072666, XrefRangeEnd = 1072674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionSource(SmartFormatter formatter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001CC58 File Offset: 0x0001AE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072675, XrefRangeEnd = 1072782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00003F86 File Offset: 0x00002186
		public ReflectionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0001CCA8 File Offset: 0x0001AEA8
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00003F8F File Offset: 0x0000218F
		public unsafe static Il2CppReferenceArray<Object> k_Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionSource.NativeFieldInfoPtr_k_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionSource.NativeFieldInfoPtr_k_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001CCD0 File Offset: 0x0001AED0
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00003FA1 File Offset: 0x000021A1
		public unsafe Dictionary<ValueTuple<Type, string>, ValueTuple<FieldInfo, MethodInfo>> m_TypeCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionSource.NativeFieldInfoPtr_m_TypeCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<Type, string>, ValueTuple<FieldInfo, MethodInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionSource.NativeFieldInfoPtr_m_TypeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_k_Empty;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_m_TypeCache;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCache_Private_get_Dictionary_2_ValueTuple_2_Type_String_ValueTuple_2_FieldInfo_MethodInfo_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0;

		// Token: 0x02000149 RID: 329
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Extensions.ReflectionSource+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06000E9A RID: 3738 RVA: 0x0003F25C File Offset: 0x0003D45C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<ReflectionSource.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionSource>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionSource.__c__DisplayClass5_0>.NativeClassPtr);
				ReflectionSource.__c__DisplayClass5_0.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionSource.__c__DisplayClass5_0>.NativeClassPtr, "selector");
				ReflectionSource.__c__DisplayClass5_0.NativeFieldInfoPtr_selectorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionSource.__c__DisplayClass5_0>.NativeClassPtr, "selectorInfo");
				ReflectionSource.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSource.__c__DisplayClass5_0>.NativeClassPtr, 100664267);
				ReflectionSource.__c__DisplayClass5_0.NativeMethodInfoPtr__TryEvaluateSelector_b__0_Internal_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSource.__c__DisplayClass5_0>.NativeClassPtr, 100664268);
			}

			// Token: 0x06000E9B RID: 3739 RVA: 0x0003F2D8 File Offset: 0x0003D4D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionSource.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSource.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E9C RID: 3740 RVA: 0x0003F314 File Offset: 0x0003D514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072593, XrefRangeEnd = 1072655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryEvaluateSelector_b__0(MemberInfo m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSource.__c__DisplayClass5_0.NativeMethodInfoPtr__TryEvaluateSelector_b__0_Internal_Boolean_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000E9D RID: 3741 RVA: 0x0000820B File Offset: 0x0000640B
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0003F364 File Offset: 0x0003D564
			// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00008214 File Offset: 0x00006414
			public unsafe string selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionSource.__c__DisplayClass5_0.NativeFieldInfoPtr_selector);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionSource.__c__DisplayClass5_0.NativeFieldInfoPtr_selector), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0003F38C File Offset: 0x0003D58C
			// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00008233 File Offset: 0x00006433
			public unsafe ISelectorInfo selectorInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionSource.__c__DisplayClass5_0.NativeFieldInfoPtr_selectorInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectorInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionSource.__c__DisplayClass5_0.NativeFieldInfoPtr_selectorInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A07 RID: 2567
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000A08 RID: 2568
			private static readonly IntPtr NativeFieldInfoPtr_selectorInfo;

			// Token: 0x04000A09 RID: 2569
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A0A RID: 2570
			private static readonly IntPtr NativeMethodInfoPtr__TryEvaluateSelector_b__0_Internal_Boolean_MemberInfo_0;
		}
	}
}
