using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000EF RID: 239
	[StructLayout(2)]
	public struct PersonaStateChange_t
	{
		// Token: 0x06000F04 RID: 3844 RVA: 0x0005C090 File Offset: 0x0005A290
		// Note: this type is marked as 'beforefieldinit'.
		static PersonaStateChange_t()
		{
			Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "PersonaStateChange_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr);
			PersonaStateChange_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, "SteamID");
			PersonaStateChange_t.NativeFieldInfoPtr_ChangeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, "ChangeFlags");
			PersonaStateChange_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, "_datasize");
			PersonaStateChange_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, 100666773);
			PersonaStateChange_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, 100666774);
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x0005C124 File Offset: 0x0005A324
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950179, XrefRangeEnd = 950183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersonaStateChange_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0005C154 File Offset: 0x0005A354
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersonaStateChange_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0000410B File Offset: 0x0000230B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0005C184 File Offset: 0x0005A384
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x0000411D File Offset: 0x0000231D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PersonaStateChange_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PersonaStateChange_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeFieldInfoPtr_ChangeFlags;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001538 RID: 5432
		[FieldOffset(0)]
		public ulong SteamID;

		// Token: 0x04001539 RID: 5433
		[FieldOffset(8)]
		public int ChangeFlags;
	}
}
