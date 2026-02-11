using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000092 RID: 146
	public sealed class GetArrayItemInstruction : Instruction
	{
		// Token: 0x0600080B RID: 2059 RVA: 0x000345C4 File Offset: 0x000327C4
		// Note: this type is marked as 'beforefieldinit'.
		static GetArrayItemInstruction()
		{
			Il2CppClassPointerStore<GetArrayItemInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "GetArrayItemInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetArrayItemInstruction>.NativeClassPtr);
			GetArrayItemInstruction.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetArrayItemInstruction>.NativeClassPtr, "Instance");
			GetArrayItemInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetArrayItemInstruction>.NativeClassPtr, 100664860);
			GetArrayItemInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetArrayItemInstruction>.NativeClassPtr, 100664861);
			GetArrayItemInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetArrayItemInstruction>.NativeClassPtr, 100664862);
			GetArrayItemInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetArrayItemInstruction>.NativeClassPtr, 100664863);
			GetArrayItemInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetArrayItemInstruction>.NativeClassPtr, 100664864);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0003466C File Offset: 0x0003286C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetArrayItemInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetArrayItemInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetArrayItemInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x000346A8 File Offset: 0x000328A8
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetArrayItemInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x000346E4 File Offset: 0x000328E4
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetArrayItemInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00034720 File Offset: 0x00032920
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015660, XrefRangeEnd = 1015662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetArrayItemInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00034758 File Offset: 0x00032958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015662, XrefRangeEnd = 1015669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetArrayItemInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0000421A File Offset: 0x0000241A
		public GetArrayItemInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x000347A8 File Offset: 0x000329A8
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00004223 File Offset: 0x00002423
		public unsafe static GetArrayItemInstruction Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GetArrayItemInstruction.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetArrayItemInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetArrayItemInstruction.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
