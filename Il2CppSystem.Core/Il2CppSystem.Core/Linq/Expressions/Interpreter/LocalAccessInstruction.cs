using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000D8 RID: 216
	public class LocalAccessInstruction : Instruction
	{
		// Token: 0x06000D74 RID: 3444 RVA: 0x0004BD3C File Offset: 0x00049F3C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalAccessInstruction()
		{
			Il2CppClassPointerStore<LocalAccessInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LocalAccessInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalAccessInstruction>.NativeClassPtr);
			LocalAccessInstruction.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAccessInstruction>.NativeClassPtr, "_index");
			LocalAccessInstruction.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalAccessInstruction>.NativeClassPtr, 100665750);
			LocalAccessInstruction.NativeMethodInfoPtr_ToDebugString_Public_Virtual_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalAccessInstruction>.NativeClassPtr, 100665751);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0004BDA8 File Offset: 0x00049FA8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalAccessInstruction(int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalAccessInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalAccessInstruction.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0004BDF0 File Offset: 0x00049FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024588, XrefRangeEnd = 1024611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToDebugString(int instructionIndex, Object cookie, Func<int, int> labelIndexer, IReadOnlyList<Object> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instructionIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(labelIndexer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalAccessInstruction.NativeMethodInfoPtr_ToDebugString_Public_Virtual_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0000614F File Offset: 0x0000434F
		public LocalAccessInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0004BE78 File Offset: 0x0004A078
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00006158 File Offset: 0x00004358
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalAccessInstruction.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalAccessInstruction.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_ToDebugString_Public_Virtual_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0;
	}
}
