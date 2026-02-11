using System;
using Canis;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000259 RID: 601
	public class RemoveCustomAbility : HandleCustomAbility
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x000BD76C File Offset: 0x000BB96C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveCustomAbility()
		{
			Il2CppClassPointerStore<RemoveCustomAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "RemoveCustomAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveCustomAbility>.NativeClassPtr);
			RemoveCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_AbilityID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveCustomAbility>.NativeClassPtr, 100668061);
			RemoveCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveCustomAbility>.NativeClassPtr, 100668062);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000BD7C4 File Offset: 0x000BB9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138370, XrefRangeEnd = 138371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveCustomAbility(AbilityID abilityID, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveCustomAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_AbilityID_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x000BD824 File Offset: 0x000BBA24
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 138374, RefRangeEnd = 138392, XrefRangeStart = 138371, XrefRangeEnd = 138374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveCustomAbility(AbilityDefinition abilityDefinition, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveCustomAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0000B234 File Offset: 0x00009434
		public RemoveCustomAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AbilityID_Match_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_Match_0;
	}
}
