using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x02000038 RID: 56
	public static class ParsingErrorsPool : Object
	{
		// Token: 0x06000396 RID: 918 RVA: 0x00017854 File Offset: 0x00015A54
		// Note: this type is marked as 'beforefieldinit'.
		static ParsingErrorsPool()
		{
			Il2CppClassPointerStore<ParsingErrorsPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "ParsingErrorsPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsingErrorsPool>.NativeClassPtr);
			ParsingErrorsPool.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrorsPool>.NativeClassPtr, "s_Pool");
			ParsingErrorsPool.NativeMethodInfoPtr_Get_Public_Static_ParsingErrors_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrorsPool>.NativeClassPtr, 100663948);
			ParsingErrorsPool.NativeMethodInfoPtr_Release_Public_Static_Void_ParsingErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrorsPool>.NativeClassPtr, 100663949);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000178C0 File Offset: 0x00015AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1069486, RefRangeEnd = 1069487, XrefRangeStart = 1069478, XrefRangeEnd = 1069486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParsingErrors Get(Format format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrorsPool.NativeMethodInfoPtr_Get_Public_Static_ParsingErrors_Format_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParsingErrors>(intPtr3) : null;
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00017904 File Offset: 0x00015B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1069522, RefRangeEnd = 1069523, XrefRangeStart = 1069487, XrefRangeEnd = 1069522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(ParsingErrors toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrorsPool.NativeMethodInfoPtr_Release_Public_Static_Void_ParsingErrors_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000033B8 File Offset: 0x000015B8
		public ParsingErrorsPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0001793C File Offset: 0x00015B3C
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000033C1 File Offset: 0x000015C1
		public unsafe static ObjectPool<ParsingErrors> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParsingErrorsPool.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<ParsingErrors>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParsingErrorsPool.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_ParsingErrors_Format_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_ParsingErrors_0;

		// Token: 0x02000132 RID: 306
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.ParsingErrorsPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D67 RID: 3431 RVA: 0x0003B790 File Offset: 0x00039990
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ParsingErrorsPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParsingErrorsPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsingErrorsPool.__c>.NativeClassPtr);
				ParsingErrorsPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrorsPool.__c>.NativeClassPtr, "<>9");
				ParsingErrorsPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrorsPool.__c>.NativeClassPtr, 100663952);
				ParsingErrorsPool.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_ParsingErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrorsPool.__c>.NativeClassPtr, 100663953);
				ParsingErrorsPool.__c.NativeMethodInfoPtr___cctor_b__3_1_Internal_Void_ParsingErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrorsPool.__c>.NativeClassPtr, 100663954);
			}

			// Token: 0x06000D68 RID: 3432 RVA: 0x0003B80C File Offset: 0x00039A0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsingErrorsPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrorsPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D69 RID: 3433 RVA: 0x0003B848 File Offset: 0x00039A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069472, XrefRangeEnd = 1069476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParsingErrors __cctor_b__3_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrorsPool.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_ParsingErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParsingErrors>(intPtr3) : null;
			}

			// Token: 0x06000D6A RID: 3434 RVA: 0x0003B888 File Offset: 0x00039A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069476, XrefRangeEnd = 1069478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__3_1(ParsingErrors pe)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pe);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrorsPool.__c.NativeMethodInfoPtr___cctor_b__3_1_Internal_Void_ParsingErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D6B RID: 3435 RVA: 0x0000798A File Offset: 0x00005B8A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0003B8CC File Offset: 0x00039ACC
			// (set) Token: 0x06000D6D RID: 3437 RVA: 0x00007993 File Offset: 0x00005B93
			public unsafe static ParsingErrorsPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParsingErrorsPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParsingErrorsPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParsingErrorsPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000951 RID: 2385
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000952 RID: 2386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000953 RID: 2387
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__3_0_Internal_ParsingErrors_0;

			// Token: 0x04000954 RID: 2388
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__3_1_Internal_Void_ParsingErrors_0;
		}
	}
}
