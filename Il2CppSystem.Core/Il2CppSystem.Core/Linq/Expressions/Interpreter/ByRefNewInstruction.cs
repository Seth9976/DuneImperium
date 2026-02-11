using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000EE RID: 238
	public class ByRefNewInstruction : NewInstruction
	{
		// Token: 0x06000E60 RID: 3680 RVA: 0x0004F034 File Offset: 0x0004D234
		// Note: this type is marked as 'beforefieldinit'.
		static ByRefNewInstruction()
		{
			Il2CppClassPointerStore<ByRefNewInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ByRefNewInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByRefNewInstruction>.NativeClassPtr);
			ByRefNewInstruction.NativeFieldInfoPtr__byrefArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByRefNewInstruction>.NativeClassPtr, "_byrefArgs");
			ByRefNewInstruction.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Int32_Il2CppReferenceArray_1_ByRefUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefNewInstruction>.NativeClassPtr, 100665945);
			ByRefNewInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefNewInstruction>.NativeClassPtr, 100665946);
			ByRefNewInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Final_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefNewInstruction>.NativeClassPtr, 100665947);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0004F0B4 File Offset: 0x0004D2B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1015967, RefRangeEnd = 1015969, XrefRangeStart = 1015967, XrefRangeEnd = 1015969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByRefNewInstruction(ConstructorInfo target, int argumentCount, Il2CppReferenceArray<ByRefUpdater> byrefArgs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByRefNewInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byrefArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByRefNewInstruction.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Int32_Il2CppReferenceArray_1_ByRefUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0004F120 File Offset: 0x0004D320
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025232, XrefRangeEnd = 1025234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByRefNewInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0004F164 File Offset: 0x0004D364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025234, XrefRangeEnd = 1025241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByRefNewInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Final_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x000065E2 File Offset: 0x000047E2
		public ByRefNewInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0004F1B4 File Offset: 0x0004D3B4
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x000065EB File Offset: 0x000047EB
		public unsafe Il2CppReferenceArray<ByRefUpdater> _byrefArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByRefNewInstruction.NativeFieldInfoPtr__byrefArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ByRefUpdater>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByRefNewInstruction.NativeFieldInfoPtr__byrefArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeFieldInfoPtr__byrefArgs;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Int32_Il2CppReferenceArray_1_ByRefUpdater_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Final_Int32_InterpretedFrame_0;
	}
}
