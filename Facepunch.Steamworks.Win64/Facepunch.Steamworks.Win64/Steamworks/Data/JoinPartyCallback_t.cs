using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200011E RID: 286
	public sealed class JoinPartyCallback_t : ValueType
	{
		// Token: 0x06001038 RID: 4152 RVA: 0x0005F834 File Offset: 0x0005DA34
		// Note: this type is marked as 'beforefieldinit'.
		static JoinPartyCallback_t()
		{
			Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "JoinPartyCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr);
			JoinPartyCallback_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, "Result");
			JoinPartyCallback_t.NativeFieldInfoPtr_BeaconID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, "BeaconID");
			JoinPartyCallback_t.NativeFieldInfoPtr_SteamIDBeaconOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, "SteamIDBeaconOwner");
			JoinPartyCallback_t.NativeFieldInfoPtr_ConnectString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, "ConnectString");
			JoinPartyCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, "_datasize");
			JoinPartyCallback_t.NativeMethodInfoPtr_ConnectStringUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, 100666918);
			JoinPartyCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, 100666919);
			JoinPartyCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, 100666920);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0005F904 File Offset: 0x0005DB04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950391, RefRangeEnd = 950392, XrefRangeStart = 950387, XrefRangeEnd = 950391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConnectStringUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinPartyCallback_t.NativeMethodInfoPtr_ConnectStringUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0005F940 File Offset: 0x0005DB40
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950392, XrefRangeEnd = 950396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinPartyCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0005F984 File Offset: 0x0005DB84
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinPartyCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00004816 File Offset: 0x00002A16
		public JoinPartyCallback_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0000481F File Offset: 0x00002A1F
		public JoinPartyCallback_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr))
		{
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x0005F9C8 File Offset: 0x0005DBC8
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x00004831 File Offset: 0x00002A31
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0005F9F0 File Offset: 0x0005DBF0
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x0000484C File Offset: 0x00002A4C
		public unsafe ulong BeaconID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_BeaconID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_BeaconID)) = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0005FA18 File Offset: 0x0005DC18
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00004867 File Offset: 0x00002A67
		public unsafe ulong SteamIDBeaconOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_SteamIDBeaconOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_SteamIDBeaconOwner)) = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0005FA40 File Offset: 0x0005DC40
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x00004882 File Offset: 0x00002A82
		public unsafe Il2CppStructArray<byte> ConnectString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_ConnectString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_ConnectString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0005FA70 File Offset: 0x0005DC70
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x000048A1 File Offset: 0x00002AA1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(JoinPartyCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JoinPartyCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeFieldInfoPtr_BeaconID;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDBeaconOwner;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeFieldInfoPtr_ConnectString;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_ConnectStringUTF8_Internal_String_0;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
