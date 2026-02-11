using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000B4 RID: 180
	public class FieldInstruction : Instruction
	{
		// Token: 0x060009C3 RID: 2499 RVA: 0x0003A1FC File Offset: 0x000383FC
		// Note: this type is marked as 'beforefieldinit'.
		static FieldInstruction()
		{
			Il2CppClassPointerStore<FieldInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "FieldInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldInstruction>.NativeClassPtr);
			FieldInstruction.NativeFieldInfoPtr__field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldInstruction>.NativeClassPtr, "_field");
			FieldInstruction.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInstruction>.NativeClassPtr, 100665151);
			FieldInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInstruction>.NativeClassPtr, 100665152);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0003A268 File Offset: 0x00038468
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldInstruction(FieldInfo field)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInstruction.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0003A2B4 File Offset: 0x000384B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016972, XrefRangeEnd = 1016978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00004B6E File Offset: 0x00002D6E
		public FieldInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0003A2F8 File Offset: 0x000384F8
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00004B77 File Offset: 0x00002D77
		public unsafe FieldInfo _field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldInstruction.NativeFieldInfoPtr__field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldInstruction.NativeFieldInfoPtr__field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeFieldInfoPtr__field;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
