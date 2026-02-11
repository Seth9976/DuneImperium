using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000F5 RID: 245
	public sealed class RuntimeVariables : Object
	{
		// Token: 0x06000EFF RID: 3839 RVA: 0x00050AF0 File Offset: 0x0004ECF0
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeVariables()
		{
			Il2CppClassPointerStore<RuntimeVariables>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "RuntimeVariables");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeVariables>.NativeClassPtr);
			RuntimeVariables.NativeFieldInfoPtr__boxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeVariables>.NativeClassPtr, "_boxes");
			RuntimeVariables.NativeMethodInfoPtr__ctor_Private_Void_Il2CppReferenceArray_1_IStrongBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeVariables>.NativeClassPtr, 100666098);
			RuntimeVariables.NativeMethodInfoPtr_Create_Internal_Static_IRuntimeVariables_Il2CppReferenceArray_1_IStrongBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeVariables>.NativeClassPtr, 100666099);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00050B5C File Offset: 0x0004ED5C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeVariables(Il2CppReferenceArray<IStrongBox> boxes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeVariables>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeVariables.NativeMethodInfoPtr__ctor_Private_Void_Il2CppReferenceArray_1_IStrongBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00050BA8 File Offset: 0x0004EDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026312, XrefRangeEnd = 1026317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IRuntimeVariables Create(Il2CppReferenceArray<IStrongBox> boxes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeVariables.NativeMethodInfoPtr_Create_Internal_Static_IRuntimeVariables_Il2CppReferenceArray_1_IStrongBox_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRuntimeVariables>(intPtr3) : null;
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00006A27 File Offset: 0x00004C27
		public RuntimeVariables(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00050BEC File Offset: 0x0004EDEC
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00006A30 File Offset: 0x00004C30
		public unsafe Il2CppReferenceArray<IStrongBox> _boxes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeVariables.NativeFieldInfoPtr__boxes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IStrongBox>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeVariables.NativeFieldInfoPtr__boxes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeFieldInfoPtr__boxes;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppReferenceArray_1_IStrongBox_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_IRuntimeVariables_Il2CppReferenceArray_1_IStrongBox_0;
	}
}
