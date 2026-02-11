using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000A8 RID: 168
	public sealed class EnterExceptionFilterInstruction : Instruction
	{
		// Token: 0x060008EB RID: 2283 RVA: 0x00037BBC File Offset: 0x00035DBC
		// Note: this type is marked as 'beforefieldinit'.
		static EnterExceptionFilterInstruction()
		{
			Il2CppClassPointerStore<EnterExceptionFilterInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "EnterExceptionFilterInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnterExceptionFilterInstruction>.NativeClassPtr);
			EnterExceptionFilterInstruction.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterExceptionFilterInstruction>.NativeClassPtr, "Instance");
			EnterExceptionFilterInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterExceptionFilterInstruction>.NativeClassPtr, 100664988);
			EnterExceptionFilterInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterExceptionFilterInstruction>.NativeClassPtr, 100664989);
			EnterExceptionFilterInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterExceptionFilterInstruction>.NativeClassPtr, 100664990);
			EnterExceptionFilterInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterExceptionFilterInstruction>.NativeClassPtr, 100664991);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00037C50 File Offset: 0x00035E50
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterExceptionFilterInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnterExceptionFilterInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterExceptionFilterInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00037C8C File Offset: 0x00035E8C
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016219, XrefRangeEnd = 1016221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterExceptionFilterInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00037CC4 File Offset: 0x00035EC4
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterExceptionFilterInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00037D00 File Offset: 0x00035F00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterExceptionFilterInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000045F4 File Offset: 0x000027F4
		public EnterExceptionFilterInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00037D50 File Offset: 0x00035F50
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x000045FD File Offset: 0x000027FD
		public unsafe static EnterExceptionFilterInstruction Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnterExceptionFilterInstruction.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnterExceptionFilterInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnterExceptionFilterInstruction.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
