using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000075 RID: 117
	public class RevealDetailedEntityListTargetInformation : EntityListTargetInformation
	{
		// Token: 0x060003DF RID: 991 RVA: 0x00010254 File Offset: 0x0000E454
		// Note: this type is marked as 'beforefieldinit'.
		static RevealDetailedEntityListTargetInformation()
		{
			Il2CppClassPointerStore<RevealDetailedEntityListTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "RevealDetailedEntityListTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealDetailedEntityListTargetInformation>.NativeClassPtr);
			RevealDetailedEntityListTargetInformation.NativeFieldInfoPtr_UndoTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealDetailedEntityListTargetInformation>.NativeClassPtr, "UndoTarget");
			RevealDetailedEntityListTargetInformation.NativeFieldInfoPtr_RevealEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealDetailedEntityListTargetInformation>.NativeClassPtr, "RevealEntities");
			RevealDetailedEntityListTargetInformation.NativeFieldInfoPtr_ValidTargetCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealDetailedEntityListTargetInformation>.NativeClassPtr, "ValidTargetCounts");
			RevealDetailedEntityListTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealDetailedEntityListTargetInformation>.NativeClassPtr, 100663538);
			RevealDetailedEntityListTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealDetailedEntityListTargetInformation>.NativeClassPtr, 100663539);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000102E8 File Offset: 0x0000E4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194406, XrefRangeEnd = 1194415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RevealDetailedEntityListTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0001032C File Offset: 0x0000E52C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevealDetailedEntityListTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealDetailedEntityListTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealDetailedEntityListTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000046B9 File Offset: 0x000028B9
		public RevealDetailedEntityListTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00010368 File Offset: 0x0000E568
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000046C2 File Offset: 0x000028C2
		public unsafe EntityID UndoTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealDetailedEntityListTargetInformation.NativeFieldInfoPtr_UndoTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealDetailedEntityListTargetInformation.NativeFieldInfoPtr_UndoTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00010398 File Offset: 0x0000E598
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000046E1 File Offset: 0x000028E1
		public unsafe Il2CppReferenceArray<SerializedEntity> RevealEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealDetailedEntityListTargetInformation.NativeFieldInfoPtr_RevealEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealDetailedEntityListTargetInformation.NativeFieldInfoPtr_RevealEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000103C8 File Offset: 0x0000E5C8
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00004700 File Offset: 0x00002900
		public unsafe Dictionary<EntityID, int> ValidTargetCounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealDetailedEntityListTargetInformation.NativeFieldInfoPtr_ValidTargetCounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealDetailedEntityListTargetInformation.NativeFieldInfoPtr_ValidTargetCounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_UndoTarget;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_RevealEntities;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_ValidTargetCounts;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
