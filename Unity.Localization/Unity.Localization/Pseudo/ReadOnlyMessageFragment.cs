using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Pool;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000A4 RID: 164
	public class ReadOnlyMessageFragment : MessageFragment
	{
		// Token: 0x0600081C RID: 2076 RVA: 0x00028860 File Offset: 0x00026A60
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyMessageFragment()
		{
			Il2CppClassPointerStore<ReadOnlyMessageFragment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "ReadOnlyMessageFragment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyMessageFragment>.NativeClassPtr);
			ReadOnlyMessageFragment.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyMessageFragment>.NativeClassPtr, "Pool");
			ReadOnlyMessageFragment.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyMessageFragment>.NativeClassPtr, 100664739);
			ReadOnlyMessageFragment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyMessageFragment>.NativeClassPtr, 100664740);
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x000288CC File Offset: 0x00026ACC
		public unsafe string Text
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1017349, RefRangeEnd = 1017351, XrefRangeStart = 1017349, XrefRangeEnd = 1017351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyMessageFragment.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00028904 File Offset: 0x00026B04
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyMessageFragment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyMessageFragment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyMessageFragment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000051DF File Offset: 0x000033DF
		public ReadOnlyMessageFragment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00028940 File Offset: 0x00026B40
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x000051E8 File Offset: 0x000033E8
		public unsafe static ObjectPool<ReadOnlyMessageFragment> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReadOnlyMessageFragment.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<ReadOnlyMessageFragment>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReadOnlyMessageFragment.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000161 RID: 353
		[ObfuscatedName("UnityEngine.Localization.Pseudo.ReadOnlyMessageFragment+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F3C RID: 3900 RVA: 0x0004155C File Offset: 0x0003F75C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReadOnlyMessageFragment.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadOnlyMessageFragment>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyMessageFragment.__c>.NativeClassPtr);
				ReadOnlyMessageFragment.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyMessageFragment.__c>.NativeClassPtr, "<>9");
				ReadOnlyMessageFragment.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyMessageFragment.__c>.NativeClassPtr, 100664743);
				ReadOnlyMessageFragment.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_ReadOnlyMessageFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyMessageFragment.__c>.NativeClassPtr, 100664744);
			}

			// Token: 0x06000F3D RID: 3901 RVA: 0x000415C4 File Offset: 0x0003F7C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyMessageFragment.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyMessageFragment.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F3E RID: 3902 RVA: 0x00041600 File Offset: 0x0003F800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076061, XrefRangeEnd = 1076065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyMessageFragment __cctor_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyMessageFragment.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_ReadOnlyMessageFragment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyMessageFragment>(intPtr3) : null;
			}

			// Token: 0x06000F3F RID: 3903 RVA: 0x0000862B File Offset: 0x0000682B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700041C RID: 1052
			// (get) Token: 0x06000F40 RID: 3904 RVA: 0x00041640 File Offset: 0x0003F840
			// (set) Token: 0x06000F41 RID: 3905 RVA: 0x00008634 File Offset: 0x00006834
			public unsafe static ReadOnlyMessageFragment.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReadOnlyMessageFragment.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyMessageFragment.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReadOnlyMessageFragment.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A6D RID: 2669
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000A6E RID: 2670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A6F RID: 2671
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_ReadOnlyMessageFragment_0;
		}
	}
}
