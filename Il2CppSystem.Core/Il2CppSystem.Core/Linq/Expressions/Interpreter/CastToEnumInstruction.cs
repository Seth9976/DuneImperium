using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000102 RID: 258
	public sealed class CastToEnumInstruction : CastInstruction
	{
		// Token: 0x06000FB1 RID: 4017 RVA: 0x00052DA4 File Offset: 0x00050FA4
		// Note: this type is marked as 'beforefieldinit'.
		static CastToEnumInstruction()
		{
			Il2CppClassPointerStore<CastToEnumInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "CastToEnumInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastToEnumInstruction>.NativeClassPtr);
			CastToEnumInstruction.NativeFieldInfoPtr__t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastToEnumInstruction>.NativeClassPtr, "_t");
			CastToEnumInstruction.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastToEnumInstruction>.NativeClassPtr, 100666219);
			CastToEnumInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastToEnumInstruction>.NativeClassPtr, 100666220);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00052E10 File Offset: 0x00051010
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CastToEnumInstruction(Type t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastToEnumInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastToEnumInstruction.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00052E5C File Offset: 0x0005105C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026624, XrefRangeEnd = 1026631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastToEnumInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00006DFE File Offset: 0x00004FFE
		public CastToEnumInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00052EAC File Offset: 0x000510AC
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x00006E07 File Offset: 0x00005007
		public unsafe Type _t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastToEnumInstruction.NativeFieldInfoPtr__t);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastToEnumInstruction.NativeFieldInfoPtr__t), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr__t;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
