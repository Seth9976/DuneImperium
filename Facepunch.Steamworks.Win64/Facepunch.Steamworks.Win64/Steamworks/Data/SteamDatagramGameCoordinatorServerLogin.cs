using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001C5 RID: 453
	public sealed class SteamDatagramGameCoordinatorServerLogin : ValueType
	{
		// Token: 0x060016E7 RID: 5863 RVA: 0x00070BD0 File Offset: 0x0006EDD0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamDatagramGameCoordinatorServerLogin()
		{
			Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamDatagramGameCoordinatorServerLogin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr);
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_Dentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "Dentity");
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_Outing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "Outing");
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "AppID");
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "Time");
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_CbAppData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "CbAppData");
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_AppData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "AppData");
			SteamDatagramGameCoordinatorServerLogin.NativeMethodInfoPtr_AppDataUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, 100667484);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00070C8C File Offset: 0x0006EE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951414, XrefRangeEnd = 951418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AppDataUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamDatagramGameCoordinatorServerLogin.NativeMethodInfoPtr_AppDataUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00007AC5 File Offset: 0x00005CC5
		public SteamDatagramGameCoordinatorServerLogin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00007ACE File Offset: 0x00005CCE
		public SteamDatagramGameCoordinatorServerLogin()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr))
		{
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x00070CC8 File Offset: 0x0006EEC8
		// (set) Token: 0x060016EC RID: 5868 RVA: 0x00007AE0 File Offset: 0x00005CE0
		public unsafe NetIdentity Dentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_Dentity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_Dentity)) = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00070CF0 File Offset: 0x0006EEF0
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00007AFB File Offset: 0x00005CFB
		public SteamDatagramHostedAddress Outing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_Outing);
				return new SteamDatagramHostedAddress(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_Outing), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x00070D20 File Offset: 0x0006EF20
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x00007B29 File Offset: 0x00005D29
		public unsafe AppId AppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_AppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_AppID)) = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x00070D48 File Offset: 0x0006EF48
		// (set) Token: 0x060016F2 RID: 5874 RVA: 0x00007B44 File Offset: 0x00005D44
		public unsafe uint Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_Time)) = value;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x00070D70 File Offset: 0x0006EF70
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x00007B5F File Offset: 0x00005D5F
		public unsafe int CbAppData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_CbAppData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_CbAppData)) = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00070D98 File Offset: 0x0006EF98
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x00007B7A File Offset: 0x00005D7A
		public unsafe Il2CppStructArray<byte> AppData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_AppData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_AppData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeFieldInfoPtr_Dentity;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeFieldInfoPtr_Outing;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeFieldInfoPtr_Time;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeFieldInfoPtr_CbAppData;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeFieldInfoPtr_AppData;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_AppDataUTF8_Internal_String_0;
	}
}
