using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000D1 RID: 209
	public static class ActiveAbilityStates : Object
	{
		// Token: 0x060009A2 RID: 2466 RVA: 0x000423A8 File Offset: 0x000405A8
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveAbilityStates()
		{
			Il2CppClassPointerStore<ActiveAbilityStates>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "ActiveAbilityStates");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAbilityStates>.NativeClassPtr);
			ActiveAbilityStates.NativeFieldInfoPtr_Targeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbilityStates>.NativeClassPtr, "Targeting");
			ActiveAbilityStates.NativeFieldInfoPtr_Costing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbilityStates>.NativeClassPtr, "Costing");
			ActiveAbilityStates.NativeFieldInfoPtr_Executing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbilityStates>.NativeClassPtr, "Executing");
			ActiveAbilityStates.NativeMethodInfoPtr_ToReadable_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbilityStates>.NativeClassPtr, 100665334);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00042428 File Offset: 0x00040628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564506, XrefRangeEnd = 564511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToReadable(int state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbilityStates.NativeMethodInfoPtr_ToReadable_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000059A4 File Offset: 0x00003BA4
		public ActiveAbilityStates(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00042460 File Offset: 0x00040660
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x000059AD File Offset: 0x00003BAD
		public unsafe static int Targeting
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ActiveAbilityStates.NativeFieldInfoPtr_Targeting, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActiveAbilityStates.NativeFieldInfoPtr_Targeting, (void*)(&value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0004247C File Offset: 0x0004067C
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x000059BB File Offset: 0x00003BBB
		public unsafe static int Costing
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ActiveAbilityStates.NativeFieldInfoPtr_Costing, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActiveAbilityStates.NativeFieldInfoPtr_Costing, (void*)(&value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00042498 File Offset: 0x00040698
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x000059C9 File Offset: 0x00003BC9
		public unsafe static int Executing
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ActiveAbilityStates.NativeFieldInfoPtr_Executing, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActiveAbilityStates.NativeFieldInfoPtr_Executing, (void*)(&value));
			}
		}

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeFieldInfoPtr_Targeting;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeFieldInfoPtr_Costing;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr_Executing;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_ToReadable_Public_Static_String_Int32_0;
	}
}
