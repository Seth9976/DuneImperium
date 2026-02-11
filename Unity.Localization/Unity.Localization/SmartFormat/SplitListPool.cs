using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x02000039 RID: 57
	public static class SplitListPool : Object
	{
		// Token: 0x0600039C RID: 924 RVA: 0x00017964 File Offset: 0x00015B64
		// Note: this type is marked as 'beforefieldinit'.
		static SplitListPool()
		{
			Il2CppClassPointerStore<SplitListPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "SplitListPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplitListPool>.NativeClassPtr);
			SplitListPool.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplitListPool>.NativeClassPtr, "s_Pool");
			SplitListPool.NativeMethodInfoPtr_Get_Public_Static_SplitList_Format_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplitListPool>.NativeClassPtr, 100663955);
			SplitListPool.NativeMethodInfoPtr_Release_Public_Static_Void_SplitList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplitListPool>.NativeClassPtr, 100663956);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000179D0 File Offset: 0x00015BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1069537, RefRangeEnd = 1069538, XrefRangeStart = 1069529, XrefRangeEnd = 1069537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Format.SplitList Get(Format format, List<int> splits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(splits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplitListPool.NativeMethodInfoPtr_Get_Public_Static_SplitList_Format_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format.SplitList>(intPtr3) : null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00017A28 File Offset: 0x00015C28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1069573, RefRangeEnd = 1069574, XrefRangeStart = 1069538, XrefRangeEnd = 1069573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(Format.SplitList toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplitListPool.NativeMethodInfoPtr_Release_Public_Static_Void_SplitList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000033D3 File Offset: 0x000015D3
		public SplitListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00017A60 File Offset: 0x00015C60
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x000033DC File Offset: 0x000015DC
		public unsafe static ObjectPool<Format.SplitList> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SplitListPool.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<Format.SplitList>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SplitListPool.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_SplitList_Format_List_1_Int32_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_SplitList_0;

		// Token: 0x02000133 RID: 307
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.SplitListPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D6E RID: 3438 RVA: 0x0003B8F4 File Offset: 0x00039AF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SplitListPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplitListPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplitListPool.__c>.NativeClassPtr);
				SplitListPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplitListPool.__c>.NativeClassPtr, "<>9");
				SplitListPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplitListPool.__c>.NativeClassPtr, 100663959);
				SplitListPool.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_SplitList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplitListPool.__c>.NativeClassPtr, 100663960);
				SplitListPool.__c.NativeMethodInfoPtr___cctor_b__3_1_Internal_Void_SplitList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplitListPool.__c>.NativeClassPtr, 100663961);
			}

			// Token: 0x06000D6F RID: 3439 RVA: 0x0003B970 File Offset: 0x00039B70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplitListPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplitListPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D70 RID: 3440 RVA: 0x0003B9AC File Offset: 0x00039BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069523, XrefRangeEnd = 1069527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Format.SplitList __cctor_b__3_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplitListPool.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_SplitList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format.SplitList>(intPtr3) : null;
			}

			// Token: 0x06000D71 RID: 3441 RVA: 0x0003B9EC File Offset: 0x00039BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069527, XrefRangeEnd = 1069529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__3_1(Format.SplitList sl)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sl);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplitListPool.__c.NativeMethodInfoPtr___cctor_b__3_1_Internal_Void_SplitList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D72 RID: 3442 RVA: 0x000079A5 File Offset: 0x00005BA5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000399 RID: 921
			// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0003BA30 File Offset: 0x00039C30
			// (set) Token: 0x06000D74 RID: 3444 RVA: 0x000079AE File Offset: 0x00005BAE
			public unsafe static SplitListPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SplitListPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplitListPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SplitListPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000955 RID: 2389
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000956 RID: 2390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000957 RID: 2391
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__3_0_Internal_SplitList_0;

			// Token: 0x04000958 RID: 2392
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__3_1_Internal_Void_SplitList_0;
		}
	}
}
