using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.Immortality
{
	// Token: 0x020000B5 RID: 181
	public class CorruptedHallMod : RulesModifier
	{
		// Token: 0x06000D00 RID: 3328 RVA: 0x00094F8C File Offset: 0x0009318C
		// Note: this type is marked as 'beforefieldinit'.
		static CorruptedHallMod()
		{
			Il2CppClassPointerStore<CorruptedHallMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.Immortality", "CorruptedHallMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CorruptedHallMod>.NativeClassPtr);
			CorruptedHallMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorruptedHallMod>.NativeClassPtr, "RuleModID");
			CorruptedHallMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorruptedHallMod>.NativeClassPtr, 100665765);
			CorruptedHallMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorruptedHallMod>.NativeClassPtr, 100665766);
			CorruptedHallMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorruptedHallMod>.NativeClassPtr, 100665767);
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0009500C File Offset: 0x0009320C
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CorruptedHallMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00095054 File Offset: 0x00093254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74954, XrefRangeEnd = 74970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CorruptedHallMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000950C4 File Offset: 0x000932C4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CorruptedHallMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CorruptedHallMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorruptedHallMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00006FC1 File Offset: 0x000051C1
		public CorruptedHallMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00095100 File Offset: 0x00093300
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00006FCA File Offset: 0x000051CA
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CorruptedHallMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CorruptedHallMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
