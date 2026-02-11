using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using offlineChallenges;

namespace zen.src.challenges.definitions
{
	// Token: 0x02000086 RID: 134
	public class ComplexChallenge : ChallengeDefinition
	{
		// Token: 0x060006B2 RID: 1714 RVA: 0x00025CF4 File Offset: 0x00023EF4
		// Note: this type is marked as 'beforefieldinit'.
		static ComplexChallenge()
		{
			Il2CppClassPointerStore<ComplexChallenge>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.challenges.definitions", "ComplexChallenge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComplexChallenge>.NativeClassPtr);
			ComplexChallenge.NativeFieldInfoPtr_complexEventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComplexChallenge>.NativeClassPtr, "complexEventID");
			ComplexChallenge.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComplexChallenge>.NativeClassPtr, "name");
			ComplexChallenge.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComplexChallenge>.NativeClassPtr, "icon");
			ComplexChallenge.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComplexChallenge>.NativeClassPtr, 100664392);
			ComplexChallenge.NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComplexChallenge>.NativeClassPtr, 100664393);
			ComplexChallenge.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComplexChallenge>.NativeClassPtr, 100664394);
			ComplexChallenge.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComplexChallenge>.NativeClassPtr, 100664395);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00025DB0 File Offset: 0x00023FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989222, XrefRangeEnd = 989225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComplexChallenge(int id, int complexID, string name, string icon, int amount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComplexChallenge>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complexID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(icon);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComplexChallenge.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00025E38 File Offset: 0x00024038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989225, XrefRangeEnd = 989228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int scoreEvent(OfflineChallenges.Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComplexChallenge.NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00025E90 File Offset: 0x00024090
		public unsafe override string Name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComplexChallenge.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00025ED4 File Offset: 0x000240D4
		public unsafe override string Icon
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989228, XrefRangeEnd = 989231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComplexChallenge.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000501B File Offset: 0x0000321B
		public ComplexChallenge(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00025F18 File Offset: 0x00024118
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00005024 File Offset: 0x00003224
		public unsafe int complexEventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComplexChallenge.NativeFieldInfoPtr_complexEventID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComplexChallenge.NativeFieldInfoPtr_complexEventID)) = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00025F40 File Offset: 0x00024140
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x0000503F File Offset: 0x0000323F
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComplexChallenge.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComplexChallenge.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00025F68 File Offset: 0x00024168
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x0000505E File Offset: 0x0000325E
		public unsafe string icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComplexChallenge.NativeFieldInfoPtr_icon);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComplexChallenge.NativeFieldInfoPtr_icon), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_complexEventID;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr_icon;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_String_Int32_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_get_Icon_Public_Virtual_get_String_0;
	}
}
