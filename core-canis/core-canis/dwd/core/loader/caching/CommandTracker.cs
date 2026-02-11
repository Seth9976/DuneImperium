using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.loader.caching
{
	// Token: 0x02000186 RID: 390
	public class CommandTracker : Object
	{
		// Token: 0x0600162B RID: 5675 RVA: 0x0006D21C File Offset: 0x0006B41C
		// Note: this type is marked as 'beforefieldinit'.
		static CommandTracker()
		{
			Il2CppClassPointerStore<CommandTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "CommandTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandTracker>.NativeClassPtr);
			CommandTracker.NativeFieldInfoPtr_killed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandTracker>.NativeClassPtr, "killed");
			CommandTracker.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandTracker>.NativeClassPtr, "command");
			CommandTracker.NativeFieldInfoPtr_sourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandTracker>.NativeClassPtr, "sourceName");
			CommandTracker.NativeMethodInfoPtr__ctor_Public_Void_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandTracker>.NativeClassPtr, 100666699);
			CommandTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandTracker>.NativeClassPtr, 100666700);
			CommandTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandTracker>.NativeClassPtr, 100666701);
			CommandTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandTracker>.NativeClassPtr, 100666702);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0006D2D8 File Offset: 0x0006B4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878185, XrefRangeEnd = 878194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandTracker(Command command)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandTracker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandTracker.NativeMethodInfoPtr__ctor_Public_Void_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0006D324 File Offset: 0x0006B524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878194, XrefRangeEnd = 878196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StillAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0006D360 File Offset: 0x0006B560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878196, XrefRangeEnd = 878199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0006D398 File Offset: 0x0006B598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00009AD0 File Offset: 0x00007CD0
		public CommandTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x0006D3CC File Offset: 0x0006B5CC
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x00009AD9 File Offset: 0x00007CD9
		public unsafe bool killed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandTracker.NativeFieldInfoPtr_killed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandTracker.NativeFieldInfoPtr_killed)) = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x0006D3F4 File Offset: 0x0006B5F4
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x00009AF4 File Offset: 0x00007CF4
		public unsafe WeakReference command
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandTracker.NativeFieldInfoPtr_command);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandTracker.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x0006D424 File Offset: 0x0006B624
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x00009B13 File Offset: 0x00007D13
		public unsafe string sourceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandTracker.NativeFieldInfoPtr_sourceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandTracker.NativeFieldInfoPtr_sourceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeFieldInfoPtr_killed;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeFieldInfoPtr_command;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeFieldInfoPtr_sourceName;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Command_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0;
	}
}
