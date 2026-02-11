using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000AA RID: 170
	public sealed class EnterExceptionHandlerInstruction : Instruction
	{
		// Token: 0x060008FB RID: 2299 RVA: 0x00037F34 File Offset: 0x00036134
		// Note: this type is marked as 'beforefieldinit'.
		static EnterExceptionHandlerInstruction()
		{
			Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "EnterExceptionHandlerInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr);
			EnterExceptionHandlerInstruction.NativeFieldInfoPtr_Void = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr, "Void");
			EnterExceptionHandlerInstruction.NativeFieldInfoPtr_NonVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr, "NonVoid");
			EnterExceptionHandlerInstruction.NativeFieldInfoPtr__hasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr, "_hasValue");
			EnterExceptionHandlerInstruction.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr, 100664998);
			EnterExceptionHandlerInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr, 100664999);
			EnterExceptionHandlerInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr, 100665000);
			EnterExceptionHandlerInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr, 100665001);
			EnterExceptionHandlerInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr, 100665002);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00038004 File Offset: 0x00036204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterExceptionHandlerInstruction(bool hasValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnterExceptionHandlerInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterExceptionHandlerInstruction.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0003804C File Offset: 0x0003624C
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016223, XrefRangeEnd = 1016225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterExceptionHandlerInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00038084 File Offset: 0x00036284
		public unsafe override int ConsumedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterExceptionHandlerInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x000380C0 File Offset: 0x000362C0
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterExceptionHandlerInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000380FC File Offset: 0x000362FC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterExceptionHandlerInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0000462A File Offset: 0x0000282A
		public EnterExceptionHandlerInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0003814C File Offset: 0x0003634C
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00004633 File Offset: 0x00002833
		public unsafe static EnterExceptionHandlerInstruction Void
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnterExceptionHandlerInstruction.NativeFieldInfoPtr_Void, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnterExceptionHandlerInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnterExceptionHandlerInstruction.NativeFieldInfoPtr_Void, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00038174 File Offset: 0x00036374
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00004645 File Offset: 0x00002845
		public unsafe static EnterExceptionHandlerInstruction NonVoid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnterExceptionHandlerInstruction.NativeFieldInfoPtr_NonVoid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnterExceptionHandlerInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnterExceptionHandlerInstruction.NativeFieldInfoPtr_NonVoid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0003819C File Offset: 0x0003639C
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00004657 File Offset: 0x00002857
		public unsafe bool _hasValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterExceptionHandlerInstruction.NativeFieldInfoPtr__hasValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterExceptionHandlerInstruction.NativeFieldInfoPtr__hasValue)) = value;
			}
		}

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr_Void;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr_NonVoid;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr__hasValue;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
