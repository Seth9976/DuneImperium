using System;
using Canis;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000258 RID: 600
	public class AddCustomAbility : HandleCustomAbility
	{
		// Token: 0x060019DA RID: 6618 RVA: 0x000BD654 File Offset: 0x000BB854
		// Note: this type is marked as 'beforefieldinit'.
		static AddCustomAbility()
		{
			Il2CppClassPointerStore<AddCustomAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "AddCustomAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddCustomAbility>.NativeClassPtr);
			AddCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_AbilityID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddCustomAbility>.NativeClassPtr, 100668059);
			AddCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddCustomAbility>.NativeClassPtr, 100668060);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x000BD6AC File Offset: 0x000BB8AC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 138339, RefRangeEnd = 138367, XrefRangeStart = 138338, XrefRangeEnd = 138339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddCustomAbility(AbilityID abilityID, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddCustomAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_AbilityID_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000BD70C File Offset: 0x000BB90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138367, XrefRangeEnd = 138370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddCustomAbility(AbilityDefinition abilityDefinition, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddCustomAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0000B22B File Offset: 0x0000942B
		public AddCustomAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AbilityID_Match_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_Match_0;
	}
}
