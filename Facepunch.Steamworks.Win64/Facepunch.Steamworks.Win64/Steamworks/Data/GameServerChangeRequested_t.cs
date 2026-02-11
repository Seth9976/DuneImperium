using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000F1 RID: 241
	public sealed class GameServerChangeRequested_t : ValueType
	{
		// Token: 0x06000F10 RID: 3856 RVA: 0x0005C29C File Offset: 0x0005A49C
		// Note: this type is marked as 'beforefieldinit'.
		static GameServerChangeRequested_t()
		{
			Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GameServerChangeRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr);
			GameServerChangeRequested_t.NativeFieldInfoPtr_Server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, "Server");
			GameServerChangeRequested_t.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, "Password");
			GameServerChangeRequested_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, "_datasize");
			GameServerChangeRequested_t.NativeMethodInfoPtr_ServerUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, 100666779);
			GameServerChangeRequested_t.NativeMethodInfoPtr_PasswordUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, 100666780);
			GameServerChangeRequested_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, 100666781);
			GameServerChangeRequested_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, 100666782);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0005C358 File Offset: 0x0005A558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950191, RefRangeEnd = 950192, XrefRangeStart = 950187, XrefRangeEnd = 950191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ServerUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServerChangeRequested_t.NativeMethodInfoPtr_ServerUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0005C394 File Offset: 0x0005A594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950196, RefRangeEnd = 950197, XrefRangeStart = 950192, XrefRangeEnd = 950196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PasswordUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServerChangeRequested_t.NativeMethodInfoPtr_PasswordUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0005C3D0 File Offset: 0x0005A5D0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950197, XrefRangeEnd = 950201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServerChangeRequested_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x0005C414 File Offset: 0x0005A614
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServerChangeRequested_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0000414B File Offset: 0x0000234B
		public GameServerChangeRequested_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00004154 File Offset: 0x00002354
		public GameServerChangeRequested_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0005C458 File Offset: 0x0005A658
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00004166 File Offset: 0x00002366
		public unsafe Il2CppStructArray<byte> Server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_Server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_Server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0005C488 File Offset: 0x0005A688
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00004185 File Offset: 0x00002385
		public unsafe Il2CppStructArray<byte> Password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_Password);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_Password), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0005C4B8 File Offset: 0x0005A6B8
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x000041A4 File Offset: 0x000023A4
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameServerChangeRequested_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameServerChangeRequested_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeFieldInfoPtr_Server;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeFieldInfoPtr_Password;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_ServerUTF8_Internal_String_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_PasswordUTF8_Internal_String_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
