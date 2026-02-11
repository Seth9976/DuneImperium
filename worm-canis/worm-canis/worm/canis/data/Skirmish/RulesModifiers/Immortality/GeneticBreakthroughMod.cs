using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.Immortality
{
	// Token: 0x020000BC RID: 188
	public class GeneticBreakthroughMod : RulesModifier
	{
		// Token: 0x06000D31 RID: 3377 RVA: 0x00095A7C File Offset: 0x00093C7C
		// Note: this type is marked as 'beforefieldinit'.
		static GeneticBreakthroughMod()
		{
			Il2CppClassPointerStore<GeneticBreakthroughMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.Immortality", "GeneticBreakthroughMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneticBreakthroughMod>.NativeClassPtr);
			GeneticBreakthroughMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneticBreakthroughMod>.NativeClassPtr, "RuleModID");
			GeneticBreakthroughMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneticBreakthroughMod>.NativeClassPtr, 100665796);
			GeneticBreakthroughMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneticBreakthroughMod>.NativeClassPtr, 100665797);
			GeneticBreakthroughMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneticBreakthroughMod>.NativeClassPtr, 100665798);
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00095AFC File Offset: 0x00093CFC
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneticBreakthroughMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00095B44 File Offset: 0x00093D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormMatchInitData Apply(WormMatchInitData wormMatchInitData, CanisRandom random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatchInitData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneticBreakthroughMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00095BB4 File Offset: 0x00093DB4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneticBreakthroughMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneticBreakthroughMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneticBreakthroughMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00007062 File Offset: 0x00005262
		public GeneticBreakthroughMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00095BF0 File Offset: 0x00093DF0
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x0000706B File Offset: 0x0000526B
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GeneticBreakthroughMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GeneticBreakthroughMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
