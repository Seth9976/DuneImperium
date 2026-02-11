using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.Immortality
{
	// Token: 0x020000BA RID: 186
	public class FirstStrikeMod : RulesModifier
	{
		// Token: 0x06000D23 RID: 3363 RVA: 0x0009575C File Offset: 0x0009395C
		// Note: this type is marked as 'beforefieldinit'.
		static FirstStrikeMod()
		{
			Il2CppClassPointerStore<FirstStrikeMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.Immortality", "FirstStrikeMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstStrikeMod>.NativeClassPtr);
			FirstStrikeMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstStrikeMod>.NativeClassPtr, "RuleModID");
			FirstStrikeMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstStrikeMod>.NativeClassPtr, 100665790);
			FirstStrikeMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstStrikeMod>.NativeClassPtr, 100665791);
			FirstStrikeMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstStrikeMod>.NativeClassPtr, 100665792);
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x000957DC File Offset: 0x000939DC
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FirstStrikeMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00095824 File Offset: 0x00093A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75177, XrefRangeEnd = 75193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FirstStrikeMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00095894 File Offset: 0x00093A94
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FirstStrikeMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirstStrikeMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstStrikeMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00007034 File Offset: 0x00005234
		public FirstStrikeMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000958D0 File Offset: 0x00093AD0
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x0000703D File Offset: 0x0000523D
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FirstStrikeMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FirstStrikeMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
