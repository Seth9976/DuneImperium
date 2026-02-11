using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.RiseOfIx
{
	// Token: 0x020000B1 RID: 177
	public class TheWeirdingWayMod : RulesModifier
	{
		// Token: 0x06000CE8 RID: 3304 RVA: 0x000949AC File Offset: 0x00092BAC
		// Note: this type is marked as 'beforefieldinit'.
		static TheWeirdingWayMod()
		{
			Il2CppClassPointerStore<TheWeirdingWayMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.RiseOfIx", "TheWeirdingWayMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheWeirdingWayMod>.NativeClassPtr);
			TheWeirdingWayMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheWeirdingWayMod>.NativeClassPtr, "RuleModID");
			TheWeirdingWayMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheWeirdingWayMod>.NativeClassPtr, 100665753);
			TheWeirdingWayMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheWeirdingWayMod>.NativeClassPtr, 100665754);
			TheWeirdingWayMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheWeirdingWayMod>.NativeClassPtr, 100665755);
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00094A2C File Offset: 0x00092C2C
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TheWeirdingWayMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00094A74 File Offset: 0x00092C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74849, XrefRangeEnd = 74865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TheWeirdingWayMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00094AE4 File Offset: 0x00092CE4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TheWeirdingWayMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TheWeirdingWayMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TheWeirdingWayMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00006F81 File Offset: 0x00005181
		public TheWeirdingWayMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x00094B20 File Offset: 0x00092D20
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00006F8A File Offset: 0x0000518A
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TheWeirdingWayMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TheWeirdingWayMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
