using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000FC RID: 252
	public sealed class CreateDelegateInstruction : Instruction
	{
		// Token: 0x06000F52 RID: 3922 RVA: 0x00051B70 File Offset: 0x0004FD70
		// Note: this type is marked as 'beforefieldinit'.
		static CreateDelegateInstruction()
		{
			Il2CppClassPointerStore<CreateDelegateInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "CreateDelegateInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateDelegateInstruction>.NativeClassPtr);
			CreateDelegateInstruction.NativeFieldInfoPtr__creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDelegateInstruction>.NativeClassPtr, "_creator");
			CreateDelegateInstruction.NativeMethodInfoPtr__ctor_Internal_Void_LightDelegateCreator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDelegateInstruction>.NativeClassPtr, 100666159);
			CreateDelegateInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDelegateInstruction>.NativeClassPtr, 100666160);
			CreateDelegateInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDelegateInstruction>.NativeClassPtr, 100666161);
			CreateDelegateInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDelegateInstruction>.NativeClassPtr, 100666162);
			CreateDelegateInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDelegateInstruction>.NativeClassPtr, 100666163);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00051C18 File Offset: 0x0004FE18
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateDelegateInstruction(LightDelegateCreator delegateCreator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateDelegateInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateCreator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateDelegateInstruction.NativeMethodInfoPtr__ctor_Internal_Void_LightDelegateCreator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00051C64 File Offset: 0x0004FE64
		public unsafe override int ConsumedStack
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026446, XrefRangeEnd = 1026448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateDelegateInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00051CA0 File Offset: 0x0004FEA0
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateDelegateInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x00051CDC File Offset: 0x0004FEDC
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026448, XrefRangeEnd = 1026450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateDelegateInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00051D14 File Offset: 0x0004FF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026450, XrefRangeEnd = 1026454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateDelegateInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00006BDF File Offset: 0x00004DDF
		public CreateDelegateInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00051D64 File Offset: 0x0004FF64
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x00006BE8 File Offset: 0x00004DE8
		public unsafe LightDelegateCreator _creator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateDelegateInstruction.NativeFieldInfoPtr__creator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightDelegateCreator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateDelegateInstruction.NativeFieldInfoPtr__creator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeFieldInfoPtr__creator;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LightDelegateCreator_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
