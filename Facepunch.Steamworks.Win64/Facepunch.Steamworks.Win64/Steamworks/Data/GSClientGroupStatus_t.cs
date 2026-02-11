using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001AB RID: 427
	[StructLayout(2)]
	public struct GSClientGroupStatus_t
	{
		// Token: 0x0600150E RID: 5390 RVA: 0x0006BC38 File Offset: 0x00069E38
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientGroupStatus_t()
		{
			Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSClientGroupStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr);
			GSClientGroupStatus_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "SteamIDUser");
			GSClientGroupStatus_t.NativeFieldInfoPtr_SteamIDGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "SteamIDGroup");
			GSClientGroupStatus_t.NativeFieldInfoPtr_Member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "Member");
			GSClientGroupStatus_t.NativeFieldInfoPtr_Officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "Officer");
			GSClientGroupStatus_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "_datasize");
			GSClientGroupStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, 100667359);
			GSClientGroupStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, 100667360);
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x0006BCF4 File Offset: 0x00069EF4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951032, XrefRangeEnd = 951036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientGroupStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x0006BD24 File Offset: 0x00069F24
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientGroupStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00006DBD File Offset: 0x00004FBD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x0006BD54 File Offset: 0x00069F54
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x00006DCF File Offset: 0x00004FCF
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientGroupStatus_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientGroupStatus_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDGroup;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeFieldInfoPtr_Member;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeFieldInfoPtr_Officer;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001ABB RID: 6843
		[FieldOffset(0)]
		public ulong SteamIDUser;

		// Token: 0x04001ABC RID: 6844
		[FieldOffset(8)]
		public ulong SteamIDGroup;

		// Token: 0x04001ABD RID: 6845
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool Member;

		// Token: 0x04001ABE RID: 6846
		[FieldOffset(17)]
		[MarshalAs(4)]
		public bool Officer;
	}
}
