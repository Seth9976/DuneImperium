using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.skirmishScripts
{
	// Token: 0x0200004E RID: 78
	public class SkirmishRulesModifier : Object
	{
		// Token: 0x060004D8 RID: 1240 RVA: 0x0002C328 File Offset: 0x0002A528
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishRulesModifier()
		{
			Il2CppClassPointerStore<SkirmishRulesModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "SkirmishRulesModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishRulesModifier>.NativeClassPtr);
			SkirmishRulesModifier.NativeFieldInfoPtr_SkirmishPlayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishRulesModifier>.NativeClassPtr, "SkirmishPlayerCount");
			SkirmishRulesModifier.NativeMethodInfoPtr_get_RuleID_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifier>.NativeClassPtr, 100664275);
			SkirmishRulesModifier.NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_MatchInitData_MatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifier>.NativeClassPtr, 100664276);
			SkirmishRulesModifier.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifier>.NativeClassPtr, 100664277);
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0002C3A8 File Offset: 0x0002A5A8
		public unsafe virtual int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkirmishRulesModifier.NativeMethodInfoPtr_get_RuleID_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0002C3F0 File Offset: 0x0002A5F0
		[CallerCount(0)]
		public unsafe virtual MatchInitData Apply(MatchInitData matchInitData, CanisRandom random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchInitData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkirmishRulesModifier.NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_MatchInitData_MatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0002C460 File Offset: 0x0002A660
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishRulesModifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishRulesModifier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifier.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000425B File Offset: 0x0000245B
		public SkirmishRulesModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0002C49C File Offset: 0x0002A69C
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00004264 File Offset: 0x00002464
		public unsafe static int SkirmishPlayerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SkirmishRulesModifier.NativeFieldInfoPtr_SkirmishPlayerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishRulesModifier.NativeFieldInfoPtr_SkirmishPlayerCount, (void*)(&value));
			}
		}

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishPlayerCount;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_MatchInitData_MatchInitData_CanisRandom_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
