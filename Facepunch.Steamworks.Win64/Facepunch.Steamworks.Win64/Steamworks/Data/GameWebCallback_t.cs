using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000EB RID: 235
	public sealed class GameWebCallback_t : ValueType
	{
		// Token: 0x06000EE4 RID: 3812 RVA: 0x0005BA74 File Offset: 0x00059C74
		// Note: this type is marked as 'beforefieldinit'.
		static GameWebCallback_t()
		{
			Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GameWebCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr);
			GameWebCallback_t.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, "URL");
			GameWebCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, "_datasize");
			GameWebCallback_t.NativeMethodInfoPtr_URLUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, 100666759);
			GameWebCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, 100666760);
			GameWebCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, 100666761);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0005BB08 File Offset: 0x00059D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950157, RefRangeEnd = 950158, XrefRangeStart = 950153, XrefRangeEnd = 950157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string URLUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameWebCallback_t.NativeMethodInfoPtr_URLUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0005BB44 File Offset: 0x00059D44
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950158, XrefRangeEnd = 950162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameWebCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0005BB88 File Offset: 0x00059D88
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameWebCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0000403B File Offset: 0x0000223B
		public GameWebCallback_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00004044 File Offset: 0x00002244
		public GameWebCallback_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0005BBCC File Offset: 0x00059DCC
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00004056 File Offset: 0x00002256
		public unsafe Il2CppStructArray<byte> URL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameWebCallback_t.NativeFieldInfoPtr_URL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameWebCallback_t.NativeFieldInfoPtr_URL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0005BBFC File Offset: 0x00059DFC
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00004075 File Offset: 0x00002275
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameWebCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameWebCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeFieldInfoPtr_URL;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeMethodInfoPtr_URLUTF8_Internal_String_0;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
