using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000113 RID: 275
	[Serializable]
	public sealed class ConsoleCancelEventArgs : EventArgs
	{
		// Token: 0x06001258 RID: 4696 RVA: 0x0007E1BC File Offset: 0x0007C3BC
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleCancelEventArgs()
		{
			Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleCancelEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr);
			ConsoleCancelEventArgs.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, "_type");
			ConsoleCancelEventArgs.NativeFieldInfoPtr__Cancel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, "<Cancel>k__BackingField");
			ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100666492);
			ConsoleCancelEventArgs.NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100666493);
			ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100666494);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0007E250 File Offset: 0x0007C450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1333703, RefRangeEnd = 1333704, XrefRangeStart = 1333699, XrefRangeEnd = 1333703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleCancelEventArgs(ConsoleSpecialKey type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x0007E298 File Offset: 0x0007C498
		public unsafe bool Cancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventArgs.NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0007E2D4 File Offset: 0x0007C4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333704, XrefRangeEnd = 1333707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleCancelEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00006123 File Offset: 0x00004323
		public ConsoleCancelEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x0007E310 File Offset: 0x0007C510
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x0000612C File Offset: 0x0000432C
		public unsafe ConsoleSpecialKey _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x0007E338 File Offset: 0x0007C538
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x00006147 File Offset: 0x00004347
		public unsafe bool _Cancel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__Cancel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__Cancel_k__BackingField)) = value;
			}
		}

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeFieldInfoPtr__Cancel_k__BackingField;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
