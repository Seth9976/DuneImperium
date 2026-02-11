using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000CF RID: 207
	public class ByRefUpdater : Object
	{
		// Token: 0x06000CDE RID: 3294 RVA: 0x00045154 File Offset: 0x00043354
		// Note: this type is marked as 'beforefieldinit'.
		static ByRefUpdater()
		{
			Il2CppClassPointerStore<ByRefUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ByRefUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByRefUpdater>.NativeClassPtr);
			ByRefUpdater.NativeFieldInfoPtr_ArgumentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByRefUpdater>.NativeClassPtr, "ArgumentIndex");
			ByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefUpdater>.NativeClassPtr, 100665643);
			ByRefUpdater.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_InterpretedFrame_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefUpdater>.NativeClassPtr, 100665644);
			ByRefUpdater.NativeMethodInfoPtr_UndefineTemps_Public_Virtual_New_Void_InstructionList_LocalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefUpdater>.NativeClassPtr, 100665645);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000451D4 File Offset: 0x000433D4
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByRefUpdater(int argumentIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByRefUpdater>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argumentIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0004521C File Offset: 0x0004341C
		[CallerCount(0)]
		public unsafe virtual void Update(InterpretedFrame frame, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByRefUpdater.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_InterpretedFrame_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0004527C File Offset: 0x0004347C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UndefineTemps(InstructionList instructions, LocalVariables locals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instructions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locals);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByRefUpdater.NativeMethodInfoPtr_UndefineTemps_Public_Virtual_New_Void_InstructionList_LocalVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00005E6A File Offset: 0x0000406A
		public ByRefUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x000452DC File Offset: 0x000434DC
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00005E73 File Offset: 0x00004073
		public unsafe int ArgumentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByRefUpdater.NativeFieldInfoPtr_ArgumentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByRefUpdater.NativeFieldInfoPtr_ArgumentIndex)) = value;
			}
		}

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeFieldInfoPtr_ArgumentIndex;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_InterpretedFrame_Object_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_UndefineTemps_Public_Virtual_New_Void_InstructionList_LocalVariables_0;
	}
}
