using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x02000457 RID: 1111
	public class ILGenerator : Object
	{
		// Token: 0x06004100 RID: 16640 RVA: 0x00137C64 File Offset: 0x00135E64
		// Note: this type is marked as 'beforefieldinit'.
		static ILGenerator()
		{
			Il2CppClassPointerStore<ILGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "ILGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr);
			ILGenerator.NativeMethodInfoPtr_get_ILOffset_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673137);
			ILGenerator.NativeMethodInfoPtr_BeginExceptionBlock_Public_Virtual_New_Label_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673138);
			ILGenerator.NativeMethodInfoPtr_BeginFinallyBlock_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673139);
			ILGenerator.NativeMethodInfoPtr_DeclareLocal_Public_Virtual_New_LocalBuilder_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673140);
			ILGenerator.NativeMethodInfoPtr_DefineLabel_Public_Virtual_New_Label_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673141);
			ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673142);
			ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673143);
			ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673144);
			ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_Label_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673145);
			ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_LocalBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673146);
			ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673147);
			ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673148);
			ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673149);
			ILGenerator.NativeMethodInfoPtr_EndExceptionBlock_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673150);
			ILGenerator.NativeMethodInfoPtr_MarkLabel_Public_Virtual_New_Void_Label_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr, 100673151);
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x00137DC0 File Offset: 0x00135FC0
		public unsafe virtual int ILOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402787, XrefRangeEnd = 1402792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_get_ILOffset_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x00137E08 File Offset: 0x00136008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402792, XrefRangeEnd = 1402797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Label BeginExceptionBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_BeginExceptionBlock_Public_Virtual_New_Label_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x00137E50 File Offset: 0x00136050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402797, XrefRangeEnd = 1402802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginFinallyBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_BeginFinallyBlock_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00137E8C File Offset: 0x0013608C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402802, XrefRangeEnd = 1402807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LocalBuilder DeclareLocal(Type localType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_DeclareLocal_Public_Virtual_New_LocalBuilder_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00137EE8 File Offset: 0x001360E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402807, XrefRangeEnd = 1402812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Label DefineLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_DefineLabel_Public_Virtual_New_Label_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00137F30 File Offset: 0x00136130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402812, XrefRangeEnd = 1402817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Emit(OpCode opcode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00137F7C File Offset: 0x0013617C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402817, XrefRangeEnd = 1402822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Emit(OpCode opcode, int arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00137FD4 File Offset: 0x001361D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402822, XrefRangeEnd = 1402827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Emit(OpCode opcode, ConstructorInfo con)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(con);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_ConstructorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x00138030 File Offset: 0x00136230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402827, XrefRangeEnd = 1402832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Emit(OpCode opcode, Label label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref label;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_Label_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00138088 File Offset: 0x00136288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402832, XrefRangeEnd = 1402837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Emit(OpCode opcode, LocalBuilder local)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(local);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_LocalBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x001380E4 File Offset: 0x001362E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402837, XrefRangeEnd = 1402842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Emit(OpCode opcode, FieldInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_FieldInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x00138140 File Offset: 0x00136340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402842, XrefRangeEnd = 1402847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Emit(OpCode opcode, MethodInfo meth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meth);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x0013819C File Offset: 0x0013639C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402847, XrefRangeEnd = 1402852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Emit(OpCode opcode, Type cls)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cls);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x001381F8 File Offset: 0x001363F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402852, XrefRangeEnd = 1402857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndExceptionBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_EndExceptionBlock_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x00138234 File Offset: 0x00136434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402857, XrefRangeEnd = 1402862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MarkLabel(Label loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILGenerator.NativeMethodInfoPtr_MarkLabel_Public_Virtual_New_Void_Label_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x00017815 File Offset: 0x00015A15
		public ILGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003586 RID: 13702
		private static readonly IntPtr NativeMethodInfoPtr_get_ILOffset_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003587 RID: 13703
		private static readonly IntPtr NativeMethodInfoPtr_BeginExceptionBlock_Public_Virtual_New_Label_0;

		// Token: 0x04003588 RID: 13704
		private static readonly IntPtr NativeMethodInfoPtr_BeginFinallyBlock_Public_Virtual_New_Void_0;

		// Token: 0x04003589 RID: 13705
		private static readonly IntPtr NativeMethodInfoPtr_DeclareLocal_Public_Virtual_New_LocalBuilder_Type_0;

		// Token: 0x0400358A RID: 13706
		private static readonly IntPtr NativeMethodInfoPtr_DefineLabel_Public_Virtual_New_Label_0;

		// Token: 0x0400358B RID: 13707
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_0;

		// Token: 0x0400358C RID: 13708
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_Int32_0;

		// Token: 0x0400358D RID: 13709
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_ConstructorInfo_0;

		// Token: 0x0400358E RID: 13710
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_Label_0;

		// Token: 0x0400358F RID: 13711
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_LocalBuilder_0;

		// Token: 0x04003590 RID: 13712
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_FieldInfo_0;

		// Token: 0x04003591 RID: 13713
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_MethodInfo_0;

		// Token: 0x04003592 RID: 13714
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Virtual_New_Void_OpCode_Type_0;

		// Token: 0x04003593 RID: 13715
		private static readonly IntPtr NativeMethodInfoPtr_EndExceptionBlock_Public_Virtual_New_Void_0;

		// Token: 0x04003594 RID: 13716
		private static readonly IntPtr NativeMethodInfoPtr_MarkLabel_Public_Virtual_New_Void_Label_0;
	}
}
