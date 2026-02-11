using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Google.Apis.Util
{
	// Token: 0x0200000E RID: 14
	public static class UriPatcher : Object
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000222A File Offset: 0x0000042A
		// Note: this type is marked as 'beforefieldinit'.
		static UriPatcher()
		{
			Il2CppClassPointerStore<UriPatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Util", "UriPatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriPatcher>.NativeClassPtr);
			UriPatcher.NativeMethodInfoPtr_PatchUriQuirks_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriPatcher>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005900 File Offset: 0x00003B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209997, XrefRangeEnd = 1210061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PatchUriQuirks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriPatcher.NativeMethodInfoPtr_PatchUriQuirks_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002263 File Offset: 0x00000463
		public UriPatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_PatchUriQuirks_Public_Static_Void_0;

		// Token: 0x02000042 RID: 66
		[ObfuscatedName("Google.Apis.Util.UriPatcher+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x060002B9 RID: 697 RVA: 0x0000DED8 File Offset: 0x0000C0D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<UriPatcher.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UriPatcher>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriPatcher.__c__DisplayClass0_0>.NativeClassPtr);
				UriPatcher.__c__DisplayClass0_0.NativeFieldInfoPtr_uriParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriPatcher.__c__DisplayClass0_0>.NativeClassPtr, "uriParser");
				UriPatcher.__c__DisplayClass0_0.NativeFieldInfoPtr_setUpdatableFlagsMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriPatcher.__c__DisplayClass0_0>.NativeClassPtr, "setUpdatableFlagsMethod");
				UriPatcher.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriPatcher.__c__DisplayClass0_0>.NativeClassPtr, 100663345);
				UriPatcher.__c__DisplayClass0_0.NativeMethodInfoPtr__PatchUriQuirks_b__0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriPatcher.__c__DisplayClass0_0>.NativeClassPtr, 100663346);
			}

			// Token: 0x060002BA RID: 698 RVA: 0x0000DF54 File Offset: 0x0000C154
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriPatcher.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriPatcher.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002BB RID: 699 RVA: 0x0000DF90 File Offset: 0x0000C190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209987, XrefRangeEnd = 1209997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PatchUriQuirks_b__0(string fieldName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriPatcher.__c__DisplayClass0_0.NativeMethodInfoPtr__PatchUriQuirks_b__0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002BC RID: 700 RVA: 0x000031E3 File Offset: 0x000013E3
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x060002BD RID: 701 RVA: 0x0000DFD4 File Offset: 0x0000C1D4
			// (set) Token: 0x060002BE RID: 702 RVA: 0x000031EC File Offset: 0x000013EC
			public unsafe Type uriParser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriPatcher.__c__DisplayClass0_0.NativeFieldInfoPtr_uriParser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriPatcher.__c__DisplayClass0_0.NativeFieldInfoPtr_uriParser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060002BF RID: 703 RVA: 0x0000E004 File Offset: 0x0000C204
			// (set) Token: 0x060002C0 RID: 704 RVA: 0x0000320B File Offset: 0x0000140B
			public unsafe MethodInfo setUpdatableFlagsMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriPatcher.__c__DisplayClass0_0.NativeFieldInfoPtr_setUpdatableFlagsMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriPatcher.__c__DisplayClass0_0.NativeFieldInfoPtr_setUpdatableFlagsMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001CF RID: 463
			private static readonly IntPtr NativeFieldInfoPtr_uriParser;

			// Token: 0x040001D0 RID: 464
			private static readonly IntPtr NativeFieldInfoPtr_setUpdatableFlagsMethod;

			// Token: 0x040001D1 RID: 465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001D2 RID: 466
			private static readonly IntPtr NativeMethodInfoPtr__PatchUriQuirks_b__0_Internal_Void_String_0;
		}
	}
}
