using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Networking.notification
{
	// Token: 0x02000092 RID: 146
	public class PushNotificationDeviceData : Object
	{
		// Token: 0x060004CC RID: 1228 RVA: 0x000130B8 File Offset: 0x000112B8
		// Note: this type is marked as 'beforefieldinit'.
		static PushNotificationDeviceData()
		{
			Il2CppClassPointerStore<PushNotificationDeviceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.notification", "PushNotificationDeviceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PushNotificationDeviceData>.NativeClassPtr);
			PushNotificationDeviceData.NativeFieldInfoPtr_EndpointArn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PushNotificationDeviceData>.NativeClassPtr, "EndpointArn");
			PushNotificationDeviceData.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PushNotificationDeviceData>.NativeClassPtr, "AccountID");
			PushNotificationDeviceData.NativeFieldInfoPtr_DeviceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PushNotificationDeviceData>.NativeClassPtr, "DeviceType");
			PushNotificationDeviceData.NativeFieldInfoPtr_DeviceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PushNotificationDeviceData>.NativeClassPtr, "DeviceID");
			PushNotificationDeviceData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PushNotificationDeviceData>.NativeClassPtr, 100663620);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0001314C File Offset: 0x0001134C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PushNotificationDeviceData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PushNotificationDeviceData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PushNotificationDeviceData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00004E47 File Offset: 0x00003047
		public PushNotificationDeviceData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00013188 File Offset: 0x00011388
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00004E50 File Offset: 0x00003050
		public unsafe string EndpointArn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PushNotificationDeviceData.NativeFieldInfoPtr_EndpointArn);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PushNotificationDeviceData.NativeFieldInfoPtr_EndpointArn), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000131B0 File Offset: 0x000113B0
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00004E6F File Offset: 0x0000306F
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PushNotificationDeviceData.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PushNotificationDeviceData.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x000131E0 File Offset: 0x000113E0
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00004E8E File Offset: 0x0000308E
		public unsafe string DeviceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PushNotificationDeviceData.NativeFieldInfoPtr_DeviceType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PushNotificationDeviceData.NativeFieldInfoPtr_DeviceType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00013208 File Offset: 0x00011408
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00004EAD File Offset: 0x000030AD
		public unsafe string DeviceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PushNotificationDeviceData.NativeFieldInfoPtr_DeviceID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PushNotificationDeviceData.NativeFieldInfoPtr_DeviceID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_EndpointArn;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_DeviceType;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_DeviceID;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
