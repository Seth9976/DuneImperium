using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000F2 RID: 242
	public class NumericConvertInstruction : Instruction
	{
		// Token: 0x06000EC0 RID: 3776 RVA: 0x0004FF8C File Offset: 0x0004E18C
		// Note: this type is marked as 'beforefieldinit'.
		static NumericConvertInstruction()
		{
			Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "NumericConvertInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr);
			NumericConvertInstruction.NativeFieldInfoPtr__from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, "_from");
			NumericConvertInstruction.NativeFieldInfoPtr__to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, "_to");
			NumericConvertInstruction.NativeFieldInfoPtr__isLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, "_isLiftedToNull");
			NumericConvertInstruction.NativeMethodInfoPtr__ctor_Protected_Void_TypeCode_TypeCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, 100666030);
			NumericConvertInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Final_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, 100666031);
			NumericConvertInstruction.NativeMethodInfoPtr_Convert_Protected_Abstract_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, 100666032);
			NumericConvertInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, 100666033);
			NumericConvertInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, 100666034);
			NumericConvertInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, 100666035);
			NumericConvertInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, 100666036);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00050084 File Offset: 0x0004E284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1025779, RefRangeEnd = 1025781, XrefRangeStart = 1025779, XrefRangeEnd = 1025781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumericConvertInstruction(TypeCode from, TypeCode to, bool isLiftedToNull)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLiftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.NativeMethodInfoPtr__ctor_Protected_Void_TypeCode_TypeCode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x000500E8 File Offset: 0x0004E2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026057, XrefRangeEnd = 1026065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Final_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00050138 File Offset: 0x0004E338
		[CallerCount(0)]
		public unsafe virtual Object Convert(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumericConvertInstruction.NativeMethodInfoPtr_Convert_Protected_Abstract_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00050194 File Offset: 0x0004E394
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026065, XrefRangeEnd = 1026067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumericConvertInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x000501D8 File Offset: 0x0004E3D8
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumericConvertInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00050220 File Offset: 0x0004E420
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumericConvertInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00050268 File Offset: 0x0004E468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026067, XrefRangeEnd = 1026088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumericConvertInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00006889 File Offset: 0x00004A89
		public NumericConvertInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x000502AC File Offset: 0x0004E4AC
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x00006892 File Offset: 0x00004A92
		public unsafe TypeCode _from
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericConvertInstruction.NativeFieldInfoPtr__from);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericConvertInstruction.NativeFieldInfoPtr__from)) = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x000502D4 File Offset: 0x0004E4D4
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x000068AD File Offset: 0x00004AAD
		public unsafe TypeCode _to
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericConvertInstruction.NativeFieldInfoPtr__to);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericConvertInstruction.NativeFieldInfoPtr__to)) = value;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x000502FC File Offset: 0x0004E4FC
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x000068C8 File Offset: 0x00004AC8
		public unsafe bool _isLiftedToNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericConvertInstruction.NativeFieldInfoPtr__isLiftedToNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericConvertInstruction.NativeFieldInfoPtr__isLiftedToNull)) = value;
			}
		}

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeFieldInfoPtr__from;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeFieldInfoPtr__to;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeFieldInfoPtr__isLiftedToNull;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_TypeCode_TypeCode_Boolean_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Final_Int32_InterpretedFrame_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Abstract_Virtual_New_Object_Object_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020002FF RID: 767
		public sealed class Unchecked : NumericConvertInstruction
		{
			// Token: 0x06001A60 RID: 6752 RVA: 0x0007E4F4 File Offset: 0x0007C6F4
			// Note: this type is marked as 'beforefieldinit'.
			static Unchecked()
			{
				Il2CppClassPointerStore<NumericConvertInstruction.Unchecked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, "Unchecked");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericConvertInstruction.Unchecked>.NativeClassPtr);
				NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Unchecked>.NativeClassPtr, 100666037);
				NumericConvertInstruction.Unchecked.NativeMethodInfoPtr__ctor_Public_Void_TypeCode_TypeCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Unchecked>.NativeClassPtr, 100666038);
				NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_Convert_Protected_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Unchecked>.NativeClassPtr, 100666039);
				NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_ConvertInt32_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Unchecked>.NativeClassPtr, 100666040);
				NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_ConvertInt64_Private_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Unchecked>.NativeClassPtr, 100666041);
				NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_ConvertUInt64_Private_Object_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Unchecked>.NativeClassPtr, 100666042);
				NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_ConvertDouble_Private_Object_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Unchecked>.NativeClassPtr, 100666043);
			}

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x06001A61 RID: 6753 RVA: 0x0007E5AC File Offset: 0x0007C7AC
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025776, XrefRangeEnd = 1025778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001A62 RID: 6754 RVA: 0x0007E5E4 File Offset: 0x0007C7E4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1025779, RefRangeEnd = 1025781, XrefRangeStart = 1025778, XrefRangeEnd = 1025779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Unchecked(TypeCode from, TypeCode to, bool isLiftedToNull)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumericConvertInstruction.Unchecked>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref from;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLiftedToNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Unchecked.NativeMethodInfoPtr__ctor_Public_Void_TypeCode_TypeCode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A63 RID: 6755 RVA: 0x0007E648 File Offset: 0x0007C848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025781, XrefRangeEnd = 1025844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Convert(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_Convert_Protected_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A64 RID: 6756 RVA: 0x0007E698 File Offset: 0x0007C898
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1025859, RefRangeEnd = 1025860, XrefRangeStart = 1025844, XrefRangeEnd = 1025859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ConvertInt32(int obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_ConvertInt32_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A65 RID: 6757 RVA: 0x0007E6E4 File Offset: 0x0007C8E4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1025874, RefRangeEnd = 1025876, XrefRangeStart = 1025860, XrefRangeEnd = 1025874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ConvertInt64(long obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_ConvertInt64_Private_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A66 RID: 6758 RVA: 0x0007E730 File Offset: 0x0007C930
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1025890, RefRangeEnd = 1025891, XrefRangeStart = 1025876, XrefRangeEnd = 1025890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ConvertUInt64(ulong obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_ConvertUInt64_Private_Object_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A67 RID: 6759 RVA: 0x0007E77C File Offset: 0x0007C97C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1025905, RefRangeEnd = 1025907, XrefRangeStart = 1025891, XrefRangeEnd = 1025905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ConvertDouble(double obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Unchecked.NativeMethodInfoPtr_ConvertDouble_Private_Object_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A68 RID: 6760 RVA: 0x0000A37B File Offset: 0x0000857B
			public Unchecked(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011F1 RID: 4593
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

			// Token: 0x040011F2 RID: 4594
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TypeCode_TypeCode_Boolean_0;

			// Token: 0x040011F3 RID: 4595
			private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Object_Object_0;

			// Token: 0x040011F4 RID: 4596
			private static readonly IntPtr NativeMethodInfoPtr_ConvertInt32_Private_Object_Int32_0;

			// Token: 0x040011F5 RID: 4597
			private static readonly IntPtr NativeMethodInfoPtr_ConvertInt64_Private_Object_Int64_0;

			// Token: 0x040011F6 RID: 4598
			private static readonly IntPtr NativeMethodInfoPtr_ConvertUInt64_Private_Object_UInt64_0;

			// Token: 0x040011F7 RID: 4599
			private static readonly IntPtr NativeMethodInfoPtr_ConvertDouble_Private_Object_Double_0;
		}

		// Token: 0x02000300 RID: 768
		public sealed class Checked : NumericConvertInstruction
		{
			// Token: 0x06001A69 RID: 6761 RVA: 0x0007E7C8 File Offset: 0x0007C9C8
			// Note: this type is marked as 'beforefieldinit'.
			static Checked()
			{
				Il2CppClassPointerStore<NumericConvertInstruction.Checked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, "Checked");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericConvertInstruction.Checked>.NativeClassPtr);
				NumericConvertInstruction.Checked.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Checked>.NativeClassPtr, 100666044);
				NumericConvertInstruction.Checked.NativeMethodInfoPtr__ctor_Public_Void_TypeCode_TypeCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Checked>.NativeClassPtr, 100666045);
				NumericConvertInstruction.Checked.NativeMethodInfoPtr_Convert_Protected_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Checked>.NativeClassPtr, 100666046);
				NumericConvertInstruction.Checked.NativeMethodInfoPtr_ConvertInt32_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Checked>.NativeClassPtr, 100666047);
				NumericConvertInstruction.Checked.NativeMethodInfoPtr_ConvertInt64_Private_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Checked>.NativeClassPtr, 100666048);
				NumericConvertInstruction.Checked.NativeMethodInfoPtr_ConvertUInt64_Private_Object_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Checked>.NativeClassPtr, 100666049);
				NumericConvertInstruction.Checked.NativeMethodInfoPtr_ConvertDouble_Private_Object_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.Checked>.NativeClassPtr, 100666050);
			}

			// Token: 0x170006D1 RID: 1745
			// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0007E880 File Offset: 0x0007CA80
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025907, XrefRangeEnd = 1025909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Checked.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001A6B RID: 6763 RVA: 0x0007E8B8 File Offset: 0x0007CAB8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1025779, RefRangeEnd = 1025781, XrefRangeStart = 1025779, XrefRangeEnd = 1025781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Checked(TypeCode from, TypeCode to, bool isLiftedToNull)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumericConvertInstruction.Checked>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref from;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLiftedToNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Checked.NativeMethodInfoPtr__ctor_Public_Void_TypeCode_TypeCode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A6C RID: 6764 RVA: 0x0007E91C File Offset: 0x0007CB1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025909, XrefRangeEnd = 1025972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Convert(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Checked.NativeMethodInfoPtr_Convert_Protected_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A6D RID: 6765 RVA: 0x0007E96C File Offset: 0x0007CB6C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1025988, RefRangeEnd = 1025989, XrefRangeStart = 1025972, XrefRangeEnd = 1025988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ConvertInt32(int obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Checked.NativeMethodInfoPtr_ConvertInt32_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A6E RID: 6766 RVA: 0x0007E9B8 File Offset: 0x0007CBB8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1026004, RefRangeEnd = 1026006, XrefRangeStart = 1025989, XrefRangeEnd = 1026004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ConvertInt64(long obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Checked.NativeMethodInfoPtr_ConvertInt64_Private_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A6F RID: 6767 RVA: 0x0007EA04 File Offset: 0x0007CC04
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1026021, RefRangeEnd = 1026022, XrefRangeStart = 1026006, XrefRangeEnd = 1026021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ConvertUInt64(ulong obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Checked.NativeMethodInfoPtr_ConvertUInt64_Private_Object_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A70 RID: 6768 RVA: 0x0007EA50 File Offset: 0x0007CC50
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1026037, RefRangeEnd = 1026039, XrefRangeStart = 1026022, XrefRangeEnd = 1026037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ConvertDouble(double obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.Checked.NativeMethodInfoPtr_ConvertDouble_Private_Object_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A71 RID: 6769 RVA: 0x0000A384 File Offset: 0x00008584
			public Checked(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011F8 RID: 4600
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

			// Token: 0x040011F9 RID: 4601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TypeCode_TypeCode_Boolean_0;

			// Token: 0x040011FA RID: 4602
			private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Object_Object_0;

			// Token: 0x040011FB RID: 4603
			private static readonly IntPtr NativeMethodInfoPtr_ConvertInt32_Private_Object_Int32_0;

			// Token: 0x040011FC RID: 4604
			private static readonly IntPtr NativeMethodInfoPtr_ConvertInt64_Private_Object_Int64_0;

			// Token: 0x040011FD RID: 4605
			private static readonly IntPtr NativeMethodInfoPtr_ConvertUInt64_Private_Object_UInt64_0;

			// Token: 0x040011FE RID: 4606
			private static readonly IntPtr NativeMethodInfoPtr_ConvertDouble_Private_Object_Double_0;
		}

		// Token: 0x02000301 RID: 769
		public sealed class ToUnderlying : NumericConvertInstruction
		{
			// Token: 0x06001A72 RID: 6770 RVA: 0x0007EA9C File Offset: 0x0007CC9C
			// Note: this type is marked as 'beforefieldinit'.
			static ToUnderlying()
			{
				Il2CppClassPointerStore<NumericConvertInstruction.ToUnderlying>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NumericConvertInstruction>.NativeClassPtr, "ToUnderlying");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericConvertInstruction.ToUnderlying>.NativeClassPtr);
				NumericConvertInstruction.ToUnderlying.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.ToUnderlying>.NativeClassPtr, 100666051);
				NumericConvertInstruction.ToUnderlying.NativeMethodInfoPtr__ctor_Public_Void_TypeCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.ToUnderlying>.NativeClassPtr, 100666052);
				NumericConvertInstruction.ToUnderlying.NativeMethodInfoPtr_Convert_Protected_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericConvertInstruction.ToUnderlying>.NativeClassPtr, 100666053);
			}

			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x06001A73 RID: 6771 RVA: 0x0007EB04 File Offset: 0x0007CD04
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026039, XrefRangeEnd = 1026041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.ToUnderlying.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001A74 RID: 6772 RVA: 0x0007EB3C File Offset: 0x0007CD3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1026042, RefRangeEnd = 1026043, XrefRangeStart = 1026041, XrefRangeEnd = 1026042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToUnderlying(TypeCode to, bool isLiftedToNull)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumericConvertInstruction.ToUnderlying>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref to;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLiftedToNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.ToUnderlying.NativeMethodInfoPtr__ctor_Public_Void_TypeCode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A75 RID: 6773 RVA: 0x0007EB94 File Offset: 0x0007CD94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026043, XrefRangeEnd = 1026057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Convert(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericConvertInstruction.ToUnderlying.NativeMethodInfoPtr_Convert_Protected_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A76 RID: 6774 RVA: 0x0000A38D File Offset: 0x0000858D
			public ToUnderlying(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011FF RID: 4607
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

			// Token: 0x04001200 RID: 4608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TypeCode_Boolean_0;

			// Token: 0x04001201 RID: 4609
			private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Object_Object_0;
		}
	}
}
