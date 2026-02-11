using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.Immortality
{
	// Token: 0x020000B7 RID: 183
	public class EnhancedFamilyAtomicsMod : RulesModifier
	{
		// Token: 0x06000D0E RID: 3342 RVA: 0x000952AC File Offset: 0x000934AC
		// Note: this type is marked as 'beforefieldinit'.
		static EnhancedFamilyAtomicsMod()
		{
			Il2CppClassPointerStore<EnhancedFamilyAtomicsMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.Immortality", "EnhancedFamilyAtomicsMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnhancedFamilyAtomicsMod>.NativeClassPtr);
			EnhancedFamilyAtomicsMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnhancedFamilyAtomicsMod>.NativeClassPtr, "RuleModID");
			EnhancedFamilyAtomicsMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedFamilyAtomicsMod>.NativeClassPtr, 100665775);
			EnhancedFamilyAtomicsMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedFamilyAtomicsMod>.NativeClassPtr, 100665776);
			EnhancedFamilyAtomicsMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedFamilyAtomicsMod>.NativeClassPtr, 100665777);
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0009532C File Offset: 0x0009352C
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnhancedFamilyAtomicsMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00095374 File Offset: 0x00093574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75056, XrefRangeEnd = 75072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnhancedFamilyAtomicsMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x000953E4 File Offset: 0x000935E4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnhancedFamilyAtomicsMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnhancedFamilyAtomicsMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnhancedFamilyAtomicsMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00006FEF File Offset: 0x000051EF
		public EnhancedFamilyAtomicsMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x00095420 File Offset: 0x00093620
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00006FF8 File Offset: 0x000051F8
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EnhancedFamilyAtomicsMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnhancedFamilyAtomicsMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
