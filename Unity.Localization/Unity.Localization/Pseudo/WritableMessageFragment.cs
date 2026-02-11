using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Pool;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000A3 RID: 163
	public class WritableMessageFragment : MessageFragment
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x00028700 File Offset: 0x00026900
		// Note: this type is marked as 'beforefieldinit'.
		static WritableMessageFragment()
		{
			Il2CppClassPointerStore<WritableMessageFragment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "WritableMessageFragment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WritableMessageFragment>.NativeClassPtr);
			WritableMessageFragment.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WritableMessageFragment>.NativeClassPtr, "Pool");
			WritableMessageFragment.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WritableMessageFragment>.NativeClassPtr, 100664732);
			WritableMessageFragment.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WritableMessageFragment>.NativeClassPtr, 100664733);
			WritableMessageFragment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WritableMessageFragment>.NativeClassPtr, 100664734);
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00028780 File Offset: 0x00026980
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x000287B8 File Offset: 0x000269B8
		public unsafe string Text
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1017349, RefRangeEnd = 1017351, XrefRangeStart = 1017349, XrefRangeEnd = 1017351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WritableMessageFragment.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1076059, RefRangeEnd = 1076061, XrefRangeStart = 1076056, XrefRangeEnd = 1076059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WritableMessageFragment.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000287FC File Offset: 0x000269FC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WritableMessageFragment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WritableMessageFragment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WritableMessageFragment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000051C4 File Offset: 0x000033C4
		public WritableMessageFragment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00028838 File Offset: 0x00026A38
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x000051CD File Offset: 0x000033CD
		public unsafe static ObjectPool<WritableMessageFragment> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WritableMessageFragment.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<WritableMessageFragment>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WritableMessageFragment.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000160 RID: 352
		[ObfuscatedName("UnityEngine.Localization.Pseudo.WritableMessageFragment+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F36 RID: 3894 RVA: 0x00041450 File Offset: 0x0003F650
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WritableMessageFragment.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WritableMessageFragment>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WritableMessageFragment.__c>.NativeClassPtr);
				WritableMessageFragment.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WritableMessageFragment.__c>.NativeClassPtr, "<>9");
				WritableMessageFragment.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WritableMessageFragment.__c>.NativeClassPtr, 100664737);
				WritableMessageFragment.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_WritableMessageFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WritableMessageFragment.__c>.NativeClassPtr, 100664738);
			}

			// Token: 0x06000F37 RID: 3895 RVA: 0x000414B8 File Offset: 0x0003F6B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WritableMessageFragment.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WritableMessageFragment.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F38 RID: 3896 RVA: 0x000414F4 File Offset: 0x0003F6F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076052, XrefRangeEnd = 1076056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WritableMessageFragment __cctor_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WritableMessageFragment.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_WritableMessageFragment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WritableMessageFragment>(intPtr3) : null;
			}

			// Token: 0x06000F39 RID: 3897 RVA: 0x00008610 File Offset: 0x00006810
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700041B RID: 1051
			// (get) Token: 0x06000F3A RID: 3898 RVA: 0x00041534 File Offset: 0x0003F734
			// (set) Token: 0x06000F3B RID: 3899 RVA: 0x00008619 File Offset: 0x00006819
			public unsafe static WritableMessageFragment.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WritableMessageFragment.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WritableMessageFragment.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WritableMessageFragment.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A6A RID: 2666
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000A6B RID: 2667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A6C RID: 2668
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_WritableMessageFragment_0;
		}
	}
}
