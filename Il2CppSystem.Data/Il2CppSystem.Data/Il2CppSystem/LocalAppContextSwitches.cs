using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000006 RID: 6
	public static class LocalAppContextSwitches : Object
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00008644 File Offset: 0x00006844
		// Note: this type is marked as 'beforefieldinit'.
		static LocalAppContextSwitches()
		{
			Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System", "LocalAppContextSwitches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr);
			LocalAppContextSwitches.NativeFieldInfoPtr_s_allowArbitraryTypeInstantiation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr, "s_allowArbitraryTypeInstantiation");
			LocalAppContextSwitches.NativeMethodInfoPtr_get_AllowArbitraryTypeInstantiation_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr, 100663304);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000869C File Offset: 0x0000689C
		public unsafe static bool AllowArbitraryTypeInstantiation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886986, XrefRangeEnd = 886991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalAppContextSwitches.NativeMethodInfoPtr_get_AllowArbitraryTypeInstantiation_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E7 File Offset: 0x000002E7
		public LocalAppContextSwitches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000086CC File Offset: 0x000068CC
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe static int s_allowArbitraryTypeInstantiation
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LocalAppContextSwitches.NativeFieldInfoPtr_s_allowArbitraryTypeInstantiation, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalAppContextSwitches.NativeFieldInfoPtr_s_allowArbitraryTypeInstantiation, (void*)(&value));
			}
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_s_allowArbitraryTypeInstantiation;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowArbitraryTypeInstantiation_Public_Static_get_Boolean_0;
	}
}
