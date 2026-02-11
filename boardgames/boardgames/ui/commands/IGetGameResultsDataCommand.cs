using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.ui.commands
{
	// Token: 0x02000127 RID: 295
	public class IGetGameResultsDataCommand : FailableCommand
	{
		// Token: 0x06000F2D RID: 3885 RVA: 0x0003F304 File Offset: 0x0003D504
		// Note: this type is marked as 'beforefieldinit'.
		static IGetGameResultsDataCommand()
		{
			Il2CppClassPointerStore<IGetGameResultsDataCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui.commands", "IGetGameResultsDataCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IGetGameResultsDataCommand>.NativeClassPtr);
			IGetGameResultsDataCommand.NativeFieldInfoPtr__GameResults_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IGetGameResultsDataCommand>.NativeClassPtr, "<GameResults>k__BackingField");
			IGetGameResultsDataCommand.NativeMethodInfoPtr_get_GameResults_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGetGameResultsDataCommand>.NativeClassPtr, 100665458);
			IGetGameResultsDataCommand.NativeMethodInfoPtr_set_GameResults_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGetGameResultsDataCommand>.NativeClassPtr, 100665459);
			IGetGameResultsDataCommand.NativeMethodInfoPtr_GetResults_Public_Abstract_Virtual_New_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGetGameResultsDataCommand>.NativeClassPtr, 100665460);
			IGetGameResultsDataCommand.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGetGameResultsDataCommand>.NativeClassPtr, 100665461);
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x0003F398 File Offset: 0x0003D598
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x0003F3D0 File Offset: 0x0003D5D0
		public unsafe string GameResults
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IGetGameResultsDataCommand.NativeMethodInfoPtr_get_GameResults_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IGetGameResultsDataCommand.NativeMethodInfoPtr_set_GameResults_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0003F414 File Offset: 0x0003D614
		[CallerCount(0)]
		public unsafe virtual DBGGameResults GetResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGetGameResultsDataCommand.NativeMethodInfoPtr_GetResults_Public_Abstract_Virtual_New_DBGGameResults_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGGameResults>(intPtr3) : null;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0003F460 File Offset: 0x0003D660
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 498677, RefRangeEnd = 498693, XrefRangeStart = 498677, XrefRangeEnd = 498693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IGetGameResultsDataCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IGetGameResultsDataCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IGetGameResultsDataCommand.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0000914B File Offset: 0x0000734B
		public IGetGameResultsDataCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0003F49C File Offset: 0x0003D69C
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x00009154 File Offset: 0x00007354
		public unsafe string _GameResults_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IGetGameResultsDataCommand.NativeFieldInfoPtr__GameResults_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IGetGameResultsDataCommand.NativeFieldInfoPtr__GameResults_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeFieldInfoPtr__GameResults_k__BackingField;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_get_GameResults_Public_get_String_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_set_GameResults_Protected_set_Void_String_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_GetResults_Public_Abstract_Virtual_New_DBGGameResults_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
