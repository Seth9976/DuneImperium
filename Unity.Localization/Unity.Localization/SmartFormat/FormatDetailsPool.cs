using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Formatting;
using UnityEngine.Localization.SmartFormat.Core.Output;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x02000035 RID: 53
	public static class FormatDetailsPool : Object
	{
		// Token: 0x0600036E RID: 878 RVA: 0x00016BAC File Offset: 0x00014DAC
		// Note: this type is marked as 'beforefieldinit'.
		static FormatDetailsPool()
		{
			Il2CppClassPointerStore<FormatDetailsPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "FormatDetailsPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatDetailsPool>.NativeClassPtr);
			FormatDetailsPool.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDetailsPool>.NativeClassPtr, "s_Pool");
			FormatDetailsPool.NativeMethodInfoPtr_Get_Public_Static_FormatDetails_SmartFormatter_Format_IList_1_Object_FormatCache_IFormatProvider_IOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetailsPool>.NativeClassPtr, 100663905);
			FormatDetailsPool.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_FormatDetails_SmartFormatter_Format_Il2CppReferenceArray_1_Object_FormatCache_IFormatProvider_IOutput_byref_FormatDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetailsPool>.NativeClassPtr, 100663906);
			FormatDetailsPool.NativeMethodInfoPtr_Release_Public_Static_Void_FormatDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetailsPool>.NativeClassPtr, 100663907);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00016C2C File Offset: 0x00014E2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1069032, RefRangeEnd = 1069036, XrefRangeStart = 1069024, XrefRangeEnd = 1069032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FormatDetails Get(SmartFormatter formatter, Format originalFormat, IList<Object> originalArgs, FormatCache formatCache, IFormatProvider provider, IOutput output)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalFormat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalArgs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatCache);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetailsPool.NativeMethodInfoPtr_Get_Public_Static_FormatDetails_SmartFormatter_Format_IList_1_Object_FormatCache_IFormatProvider_IOutput_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatDetails>(intPtr3) : null;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00016CCC File Offset: 0x00014ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069036, XrefRangeEnd = 1069044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PooledObject<FormatDetails> Get(SmartFormatter formatter, Format originalFormat, Il2CppReferenceArray<Object> originalArgs, FormatCache formatCache, IFormatProvider provider, IOutput output, out FormatDetails value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalFormat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalArgs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatCache);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FormatDetailsPool.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_FormatDetails_SmartFormatter_Format_Il2CppReferenceArray_1_Object_FormatCache_IFormatProvider_IOutput_byref_FormatDetails_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new FormatDetails(intPtr4));
			return new PooledObject<FormatDetails>(intPtr2);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00016D88 File Offset: 0x00014F88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1069079, RefRangeEnd = 1069083, XrefRangeStart = 1069044, XrefRangeEnd = 1069079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(FormatDetails toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetailsPool.NativeMethodInfoPtr_Release_Public_Static_Void_FormatDetails_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00003331 File Offset: 0x00001531
		public FormatDetailsPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00016DC0 File Offset: 0x00014FC0
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0000333A File Offset: 0x0000153A
		public unsafe static ObjectPool<FormatDetails> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatDetailsPool.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<FormatDetails>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatDetailsPool.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_FormatDetails_SmartFormatter_Format_IList_1_Object_FormatCache_IFormatProvider_IOutput_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_FormatDetails_SmartFormatter_Format_Il2CppReferenceArray_1_Object_FormatCache_IFormatProvider_IOutput_byref_FormatDetails_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_FormatDetails_0;

		// Token: 0x0200012F RID: 303
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.FormatDetailsPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D4C RID: 3404 RVA: 0x0003B160 File Offset: 0x00039360
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FormatDetailsPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatDetailsPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatDetailsPool.__c>.NativeClassPtr);
				FormatDetailsPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDetailsPool.__c>.NativeClassPtr, "<>9");
				FormatDetailsPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetailsPool.__c>.NativeClassPtr, 100663910);
				FormatDetailsPool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_FormatDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetailsPool.__c>.NativeClassPtr, 100663911);
				FormatDetailsPool.__c.NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_FormatDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetailsPool.__c>.NativeClassPtr, 100663912);
			}

			// Token: 0x06000D4D RID: 3405 RVA: 0x0003B1DC File Offset: 0x000393DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatDetailsPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetailsPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D4E RID: 3406 RVA: 0x0003B218 File Offset: 0x00039418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069018, XrefRangeEnd = 1069022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FormatDetails __cctor_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetailsPool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_FormatDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatDetails>(intPtr3) : null;
			}

			// Token: 0x06000D4F RID: 3407 RVA: 0x0003B258 File Offset: 0x00039458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069022, XrefRangeEnd = 1069024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__4_1(FormatDetails fd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetailsPool.__c.NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_FormatDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D50 RID: 3408 RVA: 0x00007939 File Offset: 0x00005B39
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0003B29C File Offset: 0x0003949C
			// (set) Token: 0x06000D52 RID: 3410 RVA: 0x00007942 File Offset: 0x00005B42
			public unsafe static FormatDetailsPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormatDetailsPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormatDetailsPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormatDetailsPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400093F RID: 2367
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000940 RID: 2368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000941 RID: 2369
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_FormatDetails_0;

			// Token: 0x04000942 RID: 2370
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_FormatDetails_0;
		}
	}
}
