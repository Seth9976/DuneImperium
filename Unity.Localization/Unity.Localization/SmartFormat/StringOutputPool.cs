using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Output;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x0200003A RID: 58
	public static class StringOutputPool : Object
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x00017A88 File Offset: 0x00015C88
		// Note: this type is marked as 'beforefieldinit'.
		static StringOutputPool()
		{
			Il2CppClassPointerStore<StringOutputPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "StringOutputPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringOutputPool>.NativeClassPtr);
			StringOutputPool.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOutputPool>.NativeClassPtr, "s_Pool");
			StringOutputPool.NativeMethodInfoPtr_Get_Public_Static_StringOutput_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutputPool>.NativeClassPtr, 100663962);
			StringOutputPool.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_StringOutput_Int32_byref_StringOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutputPool>.NativeClassPtr, 100663963);
			StringOutputPool.NativeMethodInfoPtr_Release_Public_Static_Void_StringOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutputPool>.NativeClassPtr, 100663964);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00017B08 File Offset: 0x00015D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069580, XrefRangeEnd = 1069588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringOutput Get(int capacity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutputPool.NativeMethodInfoPtr_Get_Public_Static_StringOutput_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringOutput>(intPtr3) : null;
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00017B48 File Offset: 0x00015D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069588, XrefRangeEnd = 1069596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PooledObject<StringOutput> Get(int capacity, out StringOutput value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringOutputPool.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_StringOutput_Int32_byref_StringOutput_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new StringOutput(intPtr4));
			return new PooledObject<StringOutput>(intPtr2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00017BA4 File Offset: 0x00015DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069596, XrefRangeEnd = 1069631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(StringOutput toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutputPool.NativeMethodInfoPtr_Release_Public_Static_Void_StringOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000033EE File Offset: 0x000015EE
		public StringOutputPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00017BDC File Offset: 0x00015DDC
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x000033F7 File Offset: 0x000015F7
		public unsafe static ObjectPool<StringOutput> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringOutputPool.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<StringOutput>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringOutputPool.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_StringOutput_Int32_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_StringOutput_Int32_byref_StringOutput_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_StringOutput_0;

		// Token: 0x02000134 RID: 308
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.StringOutputPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D75 RID: 3445 RVA: 0x0003BA58 File Offset: 0x00039C58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StringOutputPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StringOutputPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringOutputPool.__c>.NativeClassPtr);
				StringOutputPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOutputPool.__c>.NativeClassPtr, "<>9");
				StringOutputPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutputPool.__c>.NativeClassPtr, 100663967);
				StringOutputPool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_StringOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutputPool.__c>.NativeClassPtr, 100663968);
				StringOutputPool.__c.NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_StringOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutputPool.__c>.NativeClassPtr, 100663969);
			}

			// Token: 0x06000D76 RID: 3446 RVA: 0x0003BAD4 File Offset: 0x00039CD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringOutputPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutputPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D77 RID: 3447 RVA: 0x0003BB10 File Offset: 0x00039D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069574, XrefRangeEnd = 1069578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringOutput __cctor_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutputPool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_StringOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringOutput>(intPtr3) : null;
			}

			// Token: 0x06000D78 RID: 3448 RVA: 0x0003BB50 File Offset: 0x00039D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069578, XrefRangeEnd = 1069580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__4_1(StringOutput so)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(so);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutputPool.__c.NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_StringOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D79 RID: 3449 RVA: 0x000079C0 File Offset: 0x00005BC0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700039A RID: 922
			// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0003BB94 File Offset: 0x00039D94
			// (set) Token: 0x06000D7B RID: 3451 RVA: 0x000079C9 File Offset: 0x00005BC9
			public unsafe static StringOutputPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StringOutputPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringOutputPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StringOutputPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000959 RID: 2393
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400095A RID: 2394
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400095B RID: 2395
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_StringOutput_0;

			// Token: 0x0400095C RID: 2396
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_1_Internal_Void_StringOutput_0;
		}
	}
}
