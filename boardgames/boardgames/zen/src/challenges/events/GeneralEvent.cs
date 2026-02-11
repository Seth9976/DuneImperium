using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using offlineChallenges;

namespace zen.src.challenges.events
{
	// Token: 0x02000084 RID: 132
	public class GeneralEvent : OfflineChallenges.Event
	{
		// Token: 0x060006A2 RID: 1698 RVA: 0x00025A00 File Offset: 0x00023C00
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralEvent()
		{
			Il2CppClassPointerStore<GeneralEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.challenges.events", "GeneralEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralEvent>.NativeClassPtr);
			GeneralEvent.NativeFieldInfoPtr_generalEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralEvent>.NativeClassPtr, "generalEvent");
			GeneralEvent.NativeFieldInfoPtr_playerGained = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralEvent>.NativeClassPtr, "playerGained");
			GeneralEvent.NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEvent>.NativeClassPtr, 100664388);
			GeneralEvent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEvent>.NativeClassPtr, 100664389);
			GeneralEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralEvent>.NativeClassPtr, 100664390);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00025A94 File Offset: 0x00023C94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 989206, RefRangeEnd = 989208, XrefRangeStart = 989196, XrefRangeEnd = 989206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralEvent(string evt, AccountID accountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralEvent.NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00025AF4 File Offset: 0x00023CF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 989210, RefRangeEnd = 989216, XrefRangeStart = 989208, XrefRangeEnd = 989210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralEvent(string evt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralEvent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00025B40 File Offset: 0x00023D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989216, XrefRangeEnd = 989222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00004F95 File Offset: 0x00003195
		public GeneralEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00025B84 File Offset: 0x00023D84
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00004F9E File Offset: 0x0000319E
		public unsafe string generalEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralEvent.NativeFieldInfoPtr_generalEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralEvent.NativeFieldInfoPtr_generalEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00025BAC File Offset: 0x00023DAC
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00004FBD File Offset: 0x000031BD
		public unsafe bool playerGained
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralEvent.NativeFieldInfoPtr_playerGained);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralEvent.NativeFieldInfoPtr_playerGained)) = value;
			}
		}

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_generalEvent;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_playerGained;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
