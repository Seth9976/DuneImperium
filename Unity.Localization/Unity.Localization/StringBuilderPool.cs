using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;
using UnityEngine.Pool;

namespace UnityEngine.Localization
{
	// Token: 0x0200001D RID: 29
	public static class StringBuilderPool : Object
	{
		// Token: 0x0600018E RID: 398 RVA: 0x0000EF48 File Offset: 0x0000D148
		// Note: this type is marked as 'beforefieldinit'.
		static StringBuilderPool()
		{
			Il2CppClassPointerStore<StringBuilderPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "StringBuilderPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuilderPool>.NativeClassPtr);
			StringBuilderPool.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilderPool>.NativeClassPtr, "s_Pool");
			StringBuilderPool.NativeMethodInfoPtr_Get_Public_Static_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderPool>.NativeClassPtr, 100663584);
			StringBuilderPool.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_StringBuilder_byref_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderPool>.NativeClassPtr, 100663585);
			StringBuilderPool.NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderPool>.NativeClassPtr, 100663586);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000EFC8 File Offset: 0x0000D1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066533, XrefRangeEnd = 1066541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderPool.NativeMethodInfoPtr_Get_Public_Static_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1066548, RefRangeEnd = 1066552, XrefRangeStart = 1066541, XrefRangeEnd = 1066548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PooledObject<StringBuilder> Get(out StringBuilder value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringBuilderPool.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_StringBuilder_byref_StringBuilder_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
				return new PooledObject<StringBuilder>(intPtr2);
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000F04C File Offset: 0x0000D24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066552, XrefRangeEnd = 1066587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(StringBuilder toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderPool.NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002A2B File Offset: 0x00000C2B
		public StringBuilderPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000F084 File Offset: 0x0000D284
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002A34 File Offset: 0x00000C34
		public unsafe static ObjectPool<StringBuilder> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilderPool.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<StringBuilder>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilderPool.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_StringBuilder_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_StringBuilder_byref_StringBuilder_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0;

		// Token: 0x0200011A RID: 282
		[ObfuscatedName("UnityEngine.Localization.StringBuilderPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D0D RID: 3341 RVA: 0x0003A2F4 File Offset: 0x000384F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StringBuilderPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StringBuilderPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuilderPool.__c>.NativeClassPtr);
				StringBuilderPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilderPool.__c>.NativeClassPtr, "<>9");
				StringBuilderPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderPool.__c>.NativeClassPtr, 100663589);
				StringBuilderPool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderPool.__c>.NativeClassPtr, 100663590);
				StringBuilderPool.__c.NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderPool.__c>.NativeClassPtr, 100663591);
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x0003A370 File Offset: 0x00038570
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilderPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D0F RID: 3343 RVA: 0x0003A3AC File Offset: 0x000385AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066527, XrefRangeEnd = 1066531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringBuilder __cctor_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderPool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}

			// Token: 0x06000D10 RID: 3344 RVA: 0x0003A3EC File Offset: 0x000385EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066531, XrefRangeEnd = 1066533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__4_1(StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderPool.__c.NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D11 RID: 3345 RVA: 0x00007835 File Offset: 0x00005A35
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000388 RID: 904
			// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0003A430 File Offset: 0x00038630
			// (set) Token: 0x06000D13 RID: 3347 RVA: 0x0000783E File Offset: 0x00005A3E
			public unsafe static StringBuilderPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StringBuilderPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilderPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StringBuilderPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400090C RID: 2316
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400090D RID: 2317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400090E RID: 2318
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_StringBuilder_0;

			// Token: 0x0400090F RID: 2319
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_StringBuilder_0;
		}
	}
}
