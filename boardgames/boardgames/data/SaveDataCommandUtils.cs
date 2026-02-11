using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.data
{
	// Token: 0x02000145 RID: 325
	public static class SaveDataCommandUtils : Object
	{
		// Token: 0x060010A8 RID: 4264 RVA: 0x000443AC File Offset: 0x000425AC
		// Note: this type is marked as 'beforefieldinit'.
		static SaveDataCommandUtils()
		{
			Il2CppClassPointerStore<SaveDataCommandUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "SaveDataCommandUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveDataCommandUtils>.NativeClassPtr);
			SaveDataCommandUtils.NativeFieldInfoPtr_NotFoundErrorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveDataCommandUtils>.NativeClassPtr, "NotFoundErrorCode");
			SaveDataCommandUtils.NativeMethodInfoPtr_IsNotFound_Public_Static_Boolean_IDeleteDataCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDataCommandUtils>.NativeClassPtr, 100665728);
			SaveDataCommandUtils.NativeMethodInfoPtr_IsNotFound_Public_Static_Boolean_ILoadDataCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDataCommandUtils>.NativeClassPtr, 100665729);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00044418 File Offset: 0x00042618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999421, XrefRangeEnd = 999424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNotFound(this IDeleteDataCommand command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDataCommandUtils.NativeMethodInfoPtr_IsNotFound_Public_Static_Boolean_IDeleteDataCommand_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0004445C File Offset: 0x0004265C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 999427, RefRangeEnd = 999428, XrefRangeStart = 999424, XrefRangeEnd = 999427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNotFound(this ILoadDataCommand command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDataCommandUtils.NativeMethodInfoPtr_IsNotFound_Public_Static_Boolean_ILoadDataCommand_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00009BAC File Offset: 0x00007DAC
		public SaveDataCommandUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x000444A0 File Offset: 0x000426A0
		// (set) Token: 0x060010AD RID: 4269 RVA: 0x00009BB5 File Offset: 0x00007DB5
		public unsafe static int NotFoundErrorCode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SaveDataCommandUtils.NativeFieldInfoPtr_NotFoundErrorCode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveDataCommandUtils.NativeFieldInfoPtr_NotFoundErrorCode, (void*)(&value));
			}
		}

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeFieldInfoPtr_NotFoundErrorCode;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_IsNotFound_Public_Static_Boolean_IDeleteDataCommand_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_IsNotFound_Public_Static_Boolean_ILoadDataCommand_0;
	}
}
