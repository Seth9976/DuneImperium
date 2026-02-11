using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using offlineChallenges;

namespace zen.src.challenges.definitions
{
	// Token: 0x02000087 RID: 135
	public class GeneralChallenge : BaseChallengeDefinition
	{
		// Token: 0x060006BE RID: 1726 RVA: 0x00025F90 File Offset: 0x00024190
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralChallenge()
		{
			Il2CppClassPointerStore<GeneralChallenge>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.challenges.definitions", "GeneralChallenge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralChallenge>.NativeClassPtr);
			GeneralChallenge.NativeFieldInfoPtr_generalEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralChallenge>.NativeClassPtr, "generalEvent");
			GeneralChallenge.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralChallenge>.NativeClassPtr, 100664396);
			GeneralChallenge.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralChallenge>.NativeClassPtr, 100664397);
			GeneralChallenge.NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralChallenge>.NativeClassPtr, 100664398);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00026010 File Offset: 0x00024210
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 989233, RefRangeEnd = 989276, XrefRangeStart = 989231, XrefRangeEnd = 989233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralChallenge(int id, string locKey, string icon, string generalEvent, int amount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralChallenge>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(icon);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(generalEvent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralChallenge.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0002609C File Offset: 0x0002429C
		public unsafe override string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralChallenge.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000260E0 File Offset: 0x000242E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989276, XrefRangeEnd = 989280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int scoreEvent(OfflineChallenges.Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralChallenge.NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000507D File Offset: 0x0000327D
		public GeneralChallenge(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00026138 File Offset: 0x00024338
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00005086 File Offset: 0x00003286
		public unsafe string generalEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralChallenge.NativeFieldInfoPtr_generalEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralChallenge.NativeFieldInfoPtr_generalEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr_generalEvent;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_String_Int32_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0;
	}
}
