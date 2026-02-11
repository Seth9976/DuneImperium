using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200029E RID: 670
	public class SerializedTakeControl : SerializedAction
	{
		// Token: 0x06001BD7 RID: 7127 RVA: 0x000C51C8 File Offset: 0x000C33C8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedTakeControl()
		{
			Il2CppClassPointerStore<SerializedTakeControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedTakeControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedTakeControl>.NativeClassPtr);
			SerializedTakeControl.NativeFieldInfoPtr_LogMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTakeControl>.NativeClassPtr, "LogMode");
			SerializedTakeControl.NativeFieldInfoPtr_LogTopLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTakeControl>.NativeClassPtr, "LogTopLevel");
			SerializedTakeControl.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTakeControl>.NativeClassPtr, 100668916);
			SerializedTakeControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTakeControl>.NativeClassPtr, 100668917);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x000C5248 File Offset: 0x000C3448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148144, XrefRangeEnd = 148148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedTakeControl.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x000C52A4 File Offset: 0x000C34A4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedTakeControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedTakeControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedTakeControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		public SerializedTakeControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x000C52E0 File Offset: 0x000C34E0
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x0000BDB1 File Offset: 0x00009FB1
		public unsafe ActionLogModes LogMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTakeControl.NativeFieldInfoPtr_LogMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTakeControl.NativeFieldInfoPtr_LogMode)) = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x000C5308 File Offset: 0x000C3508
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x0000BDCC File Offset: 0x00009FCC
		public unsafe bool LogTopLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTakeControl.NativeFieldInfoPtr_LogTopLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTakeControl.NativeFieldInfoPtr_LogTopLevel)) = value;
			}
		}

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeFieldInfoPtr_LogMode;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeFieldInfoPtr_LogTopLevel;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
