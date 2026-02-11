using System;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.abilities;

namespace worm.canis.entities
{
	// Token: 0x02000021 RID: 33
	public class WormActiveAbility : ActiveAbility<WormMatch, WormAbilityDefinition>
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x000746F8 File Offset: 0x000728F8
		// Note: this type is marked as 'beforefieldinit'.
		static WormActiveAbility()
		{
			Il2CppClassPointerStore<WormActiveAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormActiveAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormActiveAbility>.NativeClassPtr);
			WormActiveAbility.NativeMethodInfoPtr__ctor_Public_Void_WormAbilityDefinition_WormPlayer_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActiveAbility>.NativeClassPtr, 100663930);
			WormActiveAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActiveAbility>.NativeClassPtr, 100663931);
			WormActiveAbility.NativeMethodInfoPtr_GetWormPlayer_Public_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActiveAbility>.NativeClassPtr, 100663932);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00074764 File Offset: 0x00072964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34612, RefRangeEnd = 34613, XrefRangeStart = 34597, XrefRangeEnd = 34612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormActiveAbility(WormAbilityDefinition abilityDefinition, WormPlayer runningPlayer, WormMatch m, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormActiveAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runningPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActiveAbility.NativeMethodInfoPtr__ctor_Public_Void_WormAbilityDefinition_WormPlayer_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000747E8 File Offset: 0x000729E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34616, RefRangeEnd = 34617, XrefRangeStart = 34613, XrefRangeEnd = 34616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormActiveAbility(SerializedEntity se, WormMatch match, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormActiveAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActiveAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00074858 File Offset: 0x00072A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34619, RefRangeEnd = 34620, XrefRangeStart = 34617, XrefRangeEnd = 34619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayer GetWormPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActiveAbility.NativeMethodInfoPtr_GetWormPlayer_Public_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003508 File Offset: 0x00001708
		public WormActiveAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormAbilityDefinition_WormPlayer_WormMatch_String_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_GetWormPlayer_Public_WormPlayer_0;
	}
}
