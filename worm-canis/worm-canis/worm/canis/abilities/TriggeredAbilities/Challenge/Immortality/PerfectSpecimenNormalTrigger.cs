using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.TriggeredAbilities.Challenge.Immortality
{
	// Token: 0x020003A6 RID: 934
	public class PerfectSpecimenNormalTrigger : PerfectSpecimenTrigger
	{
		// Token: 0x06002703 RID: 9987 RVA: 0x000F6C74 File Offset: 0x000F4E74
		// Note: this type is marked as 'beforefieldinit'.
		static PerfectSpecimenNormalTrigger()
		{
			Il2CppClassPointerStore<PerfectSpecimenNormalTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge.Immortality", "PerfectSpecimenNormalTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerfectSpecimenNormalTrigger>.NativeClassPtr);
			PerfectSpecimenNormalTrigger.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerfectSpecimenNormalTrigger>.NativeClassPtr, "AbilityName");
			PerfectSpecimenNormalTrigger.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerfectSpecimenNormalTrigger>.NativeClassPtr, "AbilityID");
			PerfectSpecimenNormalTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerfectSpecimenNormalTrigger>.NativeClassPtr, 100674431);
			PerfectSpecimenNormalTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerfectSpecimenNormalTrigger>.NativeClassPtr, 100674432);
			PerfectSpecimenNormalTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerfectSpecimenNormalTrigger>.NativeClassPtr, 100674433);
			PerfectSpecimenNormalTrigger.NativeMethodInfoPtr_get_Specimens_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerfectSpecimenNormalTrigger>.NativeClassPtr, 100674434);
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000F6D1C File Offset: 0x000F4F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194651, XrefRangeEnd = 194655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PerfectSpecimenNormalTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000F6D68 File Offset: 0x000F4F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194655, XrefRangeEnd = 194658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerfectSpecimenNormalTrigger(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerfectSpecimenNormalTrigger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerfectSpecimenNormalTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000F6DB4 File Offset: 0x000F4FB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerfectSpecimenNormalTrigger(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerfectSpecimenNormalTrigger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerfectSpecimenNormalTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x000F6E24 File Offset: 0x000F5024
		public unsafe override int Specimens
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PerfectSpecimenNormalTrigger.NativeMethodInfoPtr_get_Specimens_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x0000EDEA File Offset: 0x0000CFEA
		public PerfectSpecimenNormalTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x000F6E6C File Offset: 0x000F506C
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x0000EDF3 File Offset: 0x0000CFF3
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PerfectSpecimenNormalTrigger.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PerfectSpecimenNormalTrigger.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x000F6E8C File Offset: 0x000F508C
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x0000EE05 File Offset: 0x0000D005
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PerfectSpecimenNormalTrigger.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PerfectSpecimenNormalTrigger.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeMethodInfoPtr_get_Specimens_Protected_Virtual_get_Int32_0;
	}
}
