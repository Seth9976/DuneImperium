using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000091 RID: 145
	public sealed class NewArrayBoundsInstruction : Instruction
	{
		// Token: 0x06000800 RID: 2048 RVA: 0x00034354 File Offset: 0x00032554
		// Note: this type is marked as 'beforefieldinit'.
		static NewArrayBoundsInstruction()
		{
			Il2CppClassPointerStore<NewArrayBoundsInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "NewArrayBoundsInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewArrayBoundsInstruction>.NativeClassPtr);
			NewArrayBoundsInstruction.NativeFieldInfoPtr__elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewArrayBoundsInstruction>.NativeClassPtr, "_elementType");
			NewArrayBoundsInstruction.NativeFieldInfoPtr__rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewArrayBoundsInstruction>.NativeClassPtr, "_rank");
			NewArrayBoundsInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayBoundsInstruction>.NativeClassPtr, 100664855);
			NewArrayBoundsInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayBoundsInstruction>.NativeClassPtr, 100664856);
			NewArrayBoundsInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayBoundsInstruction>.NativeClassPtr, 100664857);
			NewArrayBoundsInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayBoundsInstruction>.NativeClassPtr, 100664858);
			NewArrayBoundsInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayBoundsInstruction>.NativeClassPtr, 100664859);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00034410 File Offset: 0x00032610
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 660727, RefRangeEnd = 660732, XrefRangeStart = 660727, XrefRangeEnd = 660732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewArrayBoundsInstruction(Type elementType, int rank)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewArrayBoundsInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayBoundsInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0003446C File Offset: 0x0003266C
		public unsafe override int ConsumedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayBoundsInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x000344A8 File Offset: 0x000326A8
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayBoundsInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x000344E4 File Offset: 0x000326E4
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015649, XrefRangeEnd = 1015651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayBoundsInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0003451C File Offset: 0x0003271C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015651, XrefRangeEnd = 1015660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayBoundsInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000041D7 File Offset: 0x000023D7
		public NewArrayBoundsInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x0003456C File Offset: 0x0003276C
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x000041E0 File Offset: 0x000023E0
		public unsafe Type _elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayBoundsInstruction.NativeFieldInfoPtr__elementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayBoundsInstruction.NativeFieldInfoPtr__elementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x0003459C File Offset: 0x0003279C
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x000041FF File Offset: 0x000023FF
		public unsafe int _rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayBoundsInstruction.NativeFieldInfoPtr__rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayBoundsInstruction.NativeFieldInfoPtr__rank)) = value;
			}
		}

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr__elementType;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeFieldInfoPtr__rank;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_Int32_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
