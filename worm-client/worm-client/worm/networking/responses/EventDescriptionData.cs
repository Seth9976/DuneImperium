using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.networking.responses
{
	// Token: 0x02000068 RID: 104
	public class EventDescriptionData : Object
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x00025554 File Offset: 0x00023754
		// Note: this type is marked as 'beforefieldinit'.
		static EventDescriptionData()
		{
			Il2CppClassPointerStore<EventDescriptionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventDescriptionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDescriptionData>.NativeClassPtr);
			EventDescriptionData.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptionData>.NativeClassPtr, "title");
			EventDescriptionData.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptionData>.NativeClassPtr, "description");
			EventDescriptionData.NativeFieldInfoPtr_shortDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptionData>.NativeClassPtr, "shortDescription");
			EventDescriptionData.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptionData>.NativeClassPtr, "image");
			EventDescriptionData.NativeFieldInfoPtr_backgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptionData>.NativeClassPtr, "backgroundImage");
			EventDescriptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptionData>.NativeClassPtr, 100663936);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000255FC File Offset: 0x000237FC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDescriptionData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDescriptionData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003C9B File Offset: 0x00001E9B
		public EventDescriptionData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00025638 File Offset: 0x00023838
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00003CA4 File Offset: 0x00001EA4
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptionData.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptionData.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00025660 File Offset: 0x00023860
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003CC3 File Offset: 0x00001EC3
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptionData.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptionData.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00025688 File Offset: 0x00023888
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003CE2 File Offset: 0x00001EE2
		public unsafe string shortDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptionData.NativeFieldInfoPtr_shortDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptionData.NativeFieldInfoPtr_shortDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x000256B0 File Offset: 0x000238B0
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00003D01 File Offset: 0x00001F01
		public unsafe string image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptionData.NativeFieldInfoPtr_image);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptionData.NativeFieldInfoPtr_image), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x000256D8 File Offset: 0x000238D8
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00003D20 File Offset: 0x00001F20
		public unsafe string backgroundImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptionData.NativeFieldInfoPtr_backgroundImage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptionData.NativeFieldInfoPtr_backgroundImage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_shortDescription;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr_backgroundImage;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
