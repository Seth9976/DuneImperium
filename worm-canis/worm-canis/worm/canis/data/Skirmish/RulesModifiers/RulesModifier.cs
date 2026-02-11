using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers
{
	// Token: 0x0200009A RID: 154
	public class RulesModifier : Object
	{
		// Token: 0x06000C70 RID: 3184 RVA: 0x00092A10 File Offset: 0x00090C10
		// Note: this type is marked as 'beforefieldinit'.
		static RulesModifier()
		{
			Il2CppClassPointerStore<RulesModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers", "RulesModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RulesModifier>.NativeClassPtr);
			RulesModifier.NativeFieldInfoPtr_SkirmishPlayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesModifier>.NativeClassPtr, "SkirmishPlayerCount");
			RulesModifier.NativeMethodInfoPtr_get_RuleID_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifier>.NativeClassPtr, 100665665);
			RulesModifier.NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifier>.NativeClassPtr, 100665666);
			RulesModifier.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifier>.NativeClassPtr, 100665667);
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00092A90 File Offset: 0x00090C90
		public unsafe virtual int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RulesModifier.NativeMethodInfoPtr_get_RuleID_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00092AD8 File Offset: 0x00090CD8
		[CallerCount(0)]
		public unsafe virtual WormMatchInitData Apply(WormMatchInitData wormMatchInitData, CanisRandom random)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RulesModifier.NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00092B48 File Offset: 0x00090D48
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RulesModifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RulesModifier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifier.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00006E84 File Offset: 0x00005084
		public RulesModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00092B84 File Offset: 0x00090D84
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x00006E8D File Offset: 0x0000508D
		public unsafe static int SkirmishPlayerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RulesModifier.NativeFieldInfoPtr_SkirmishPlayerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RulesModifier.NativeFieldInfoPtr_SkirmishPlayerCount, (void*)(&value));
			}
		}

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishPlayerCount;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
