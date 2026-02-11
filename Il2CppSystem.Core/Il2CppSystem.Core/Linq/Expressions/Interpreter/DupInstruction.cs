using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000F9 RID: 249
	public sealed class DupInstruction : Instruction
	{
		// Token: 0x06000F20 RID: 3872 RVA: 0x0005129C File Offset: 0x0004F49C
		// Note: this type is marked as 'beforefieldinit'.
		static DupInstruction()
		{
			Il2CppClassPointerStore<DupInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "DupInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DupInstruction>.NativeClassPtr);
			DupInstruction.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DupInstruction>.NativeClassPtr, "Instance");
			DupInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DupInstruction>.NativeClassPtr, 100666116);
			DupInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DupInstruction>.NativeClassPtr, 100666117);
			DupInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DupInstruction>.NativeClassPtr, 100666118);
			DupInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DupInstruction>.NativeClassPtr, 100666119);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00051330 File Offset: 0x0004F530
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DupInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DupInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DupInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0005136C File Offset: 0x0004F56C
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DupInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x000513A8 File Offset: 0x0004F5A8
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026355, XrefRangeEnd = 1026357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DupInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x000513E0 File Offset: 0x0004F5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026357, XrefRangeEnd = 1026358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DupInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00006AB6 File Offset: 0x00004CB6
		public DupInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00051430 File Offset: 0x0004F630
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x00006ABF File Offset: 0x00004CBF
		public unsafe static DupInstruction Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DupInstruction.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DupInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DupInstruction.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
