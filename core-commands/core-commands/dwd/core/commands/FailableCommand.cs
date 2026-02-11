using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.commands
{
	// Token: 0x0200002E RID: 46
	public class FailableCommand : Command
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x0000BD7C File Offset: 0x00009F7C
		// Note: this type is marked as 'beforefieldinit'.
		static FailableCommand()
		{
			Il2CppClassPointerStore<FailableCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "FailableCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FailableCommand>.NativeClassPtr);
			FailableCommand.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailableCommand>.NativeClassPtr, "status");
			FailableCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableCommand>.NativeClassPtr, 100663791);
			FailableCommand.NativeMethodInfoPtr_SetStatus_Protected_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableCommand>.NativeClassPtr, 100663792);
			FailableCommand.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableCommand>.NativeClassPtr, 100663793);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000BDFC File Offset: 0x00009FFC
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000BE34 File Offset: 0x0000A034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatus(ErrorInfo newStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newStatus));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableCommand.NativeMethodInfoPtr_SetStatus_Protected_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000BE7C File Offset: 0x0000A07C
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 1209546, RefRangeEnd = 1209604, XrefRangeStart = 1209536, XrefRangeEnd = 1209546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FailableCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FailableCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableCommand.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002BF0 File Offset: 0x00000DF0
		public FailableCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002BF9 File Offset: 0x00000DF9
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableCommand.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableCommand.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_SetStatus_Protected_Void_ErrorInfo_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
