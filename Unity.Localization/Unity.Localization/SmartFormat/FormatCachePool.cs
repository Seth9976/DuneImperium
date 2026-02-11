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
	// Token: 0x02000034 RID: 52
	public static class FormatCachePool : Object
	{
		// Token: 0x06000367 RID: 871 RVA: 0x00016A28 File Offset: 0x00014C28
		// Note: this type is marked as 'beforefieldinit'.
		static FormatCachePool()
		{
			Il2CppClassPointerStore<FormatCachePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "FormatCachePool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatCachePool>.NativeClassPtr);
			FormatCachePool.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatCachePool>.NativeClassPtr, "s_Pool");
			FormatCachePool.NativeMethodInfoPtr_Get_Public_Static_FormatCache_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCachePool>.NativeClassPtr, 100663897);
			FormatCachePool.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_FormatCache_Format_byref_FormatCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCachePool>.NativeClassPtr, 100663898);
			FormatCachePool.NativeMethodInfoPtr_Release_Public_Static_Void_FormatCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCachePool>.NativeClassPtr, 100663899);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00016AA8 File Offset: 0x00014CA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1068970, RefRangeEnd = 1068973, XrefRangeStart = 1068962, XrefRangeEnd = 1068970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FormatCache Get(Format format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCachePool.NativeMethodInfoPtr_Get_Public_Static_FormatCache_Format_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatCache>(intPtr3) : null;
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00016AEC File Offset: 0x00014CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068973, XrefRangeEnd = 1068981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PooledObject<FormatCache> Get(Format format, out FormatCache value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FormatCachePool.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_FormatCache_Format_byref_FormatCache_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new FormatCache(intPtr4));
			return new PooledObject<FormatCache>(intPtr2);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00016B4C File Offset: 0x00014D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1069016, RefRangeEnd = 1069018, XrefRangeStart = 1068981, XrefRangeEnd = 1069016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(FormatCache toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCachePool.NativeMethodInfoPtr_Release_Public_Static_Void_FormatCache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003316 File Offset: 0x00001516
		public FormatCachePool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00016B84 File Offset: 0x00014D84
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0000331F File Offset: 0x0000151F
		public unsafe static ObjectPool<FormatCache> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatCachePool.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<FormatCache>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatCachePool.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_FormatCache_Format_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_FormatCache_Format_byref_FormatCache_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_FormatCache_0;

		// Token: 0x0200012E RID: 302
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.FormatCachePool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D45 RID: 3397 RVA: 0x0003AFFC File Offset: 0x000391FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FormatCachePool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatCachePool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatCachePool.__c>.NativeClassPtr);
				FormatCachePool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatCachePool.__c>.NativeClassPtr, "<>9");
				FormatCachePool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCachePool.__c>.NativeClassPtr, 100663902);
				FormatCachePool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_FormatCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCachePool.__c>.NativeClassPtr, 100663903);
				FormatCachePool.__c.NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_FormatCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCachePool.__c>.NativeClassPtr, 100663904);
			}

			// Token: 0x06000D46 RID: 3398 RVA: 0x0003B078 File Offset: 0x00039278
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatCachePool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCachePool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D47 RID: 3399 RVA: 0x0003B0B4 File Offset: 0x000392B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068945, XrefRangeEnd = 1068949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FormatCache __cctor_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCachePool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_FormatCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatCache>(intPtr3) : null;
			}

			// Token: 0x06000D48 RID: 3400 RVA: 0x0003B0F4 File Offset: 0x000392F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068949, XrefRangeEnd = 1068962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__4_1(FormatCache fc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fc);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCachePool.__c.NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_FormatCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D49 RID: 3401 RVA: 0x0000791E File Offset: 0x00005B1E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06000D4A RID: 3402 RVA: 0x0003B138 File Offset: 0x00039338
			// (set) Token: 0x06000D4B RID: 3403 RVA: 0x00007927 File Offset: 0x00005B27
			public unsafe static FormatCachePool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormatCachePool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormatCachePool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormatCachePool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400093B RID: 2363
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400093C RID: 2364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400093D RID: 2365
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_FormatCache_0;

			// Token: 0x0400093E RID: 2366
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_FormatCache_0;
		}
	}
}
