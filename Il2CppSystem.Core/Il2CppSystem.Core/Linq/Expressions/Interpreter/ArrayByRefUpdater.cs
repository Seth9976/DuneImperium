using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000D1 RID: 209
	public sealed class ArrayByRefUpdater : ByRefUpdater
	{
		// Token: 0x06000CEB RID: 3307 RVA: 0x00045450 File Offset: 0x00043650
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayByRefUpdater()
		{
			Il2CppClassPointerStore<ArrayByRefUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ArrayByRefUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayByRefUpdater>.NativeClassPtr);
			ArrayByRefUpdater.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayByRefUpdater>.NativeClassPtr, "_array");
			ArrayByRefUpdater.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayByRefUpdater>.NativeClassPtr, "_index");
			ArrayByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_LocalDefinition_LocalDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayByRefUpdater>.NativeClassPtr, 100665648);
			ArrayByRefUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayByRefUpdater>.NativeClassPtr, 100665649);
			ArrayByRefUpdater.NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayByRefUpdater>.NativeClassPtr, 100665650);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000454E4 File Offset: 0x000436E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1022379, RefRangeEnd = 1022380, XrefRangeStart = 1022376, XrefRangeEnd = 1022379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayByRefUpdater(LocalDefinition array, LocalDefinition index, int argumentIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayByRefUpdater>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(index));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_LocalDefinition_LocalDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0004555C File Offset: 0x0004375C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022380, XrefRangeEnd = 1022392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(InterpretedFrame frame, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayByRefUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000455B0 File Offset: 0x000437B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022392, XrefRangeEnd = 1022396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UndefineTemps(InstructionList instructions, LocalVariables locals)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayByRefUpdater.NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00005EB6 File Offset: 0x000040B6
		public ArrayByRefUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00045604 File Offset: 0x00043804
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00005EBF File Offset: 0x000040BF
		public LocalDefinition _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayByRefUpdater.NativeFieldInfoPtr__array);
				return new LocalDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayByRefUpdater.NativeFieldInfoPtr__array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x00045634 File Offset: 0x00043834
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00005EED File Offset: 0x000040ED
		public LocalDefinition _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayByRefUpdater.NativeFieldInfoPtr__index);
				return new LocalDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayByRefUpdater.NativeFieldInfoPtr__index), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalDefinition_LocalDefinition_Int32_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0;
	}
}
