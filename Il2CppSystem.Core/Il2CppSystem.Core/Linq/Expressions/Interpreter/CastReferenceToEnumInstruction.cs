using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000103 RID: 259
	public sealed class CastReferenceToEnumInstruction : CastInstruction
	{
		// Token: 0x06000FB7 RID: 4023 RVA: 0x00052EDC File Offset: 0x000510DC
		// Note: this type is marked as 'beforefieldinit'.
		static CastReferenceToEnumInstruction()
		{
			Il2CppClassPointerStore<CastReferenceToEnumInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "CastReferenceToEnumInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastReferenceToEnumInstruction>.NativeClassPtr);
			CastReferenceToEnumInstruction.NativeFieldInfoPtr__t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastReferenceToEnumInstruction>.NativeClassPtr, "_t");
			CastReferenceToEnumInstruction.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastReferenceToEnumInstruction>.NativeClassPtr, 100666221);
			CastReferenceToEnumInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastReferenceToEnumInstruction>.NativeClassPtr, 100666222);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00052F48 File Offset: 0x00051148
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CastReferenceToEnumInstruction(Type t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastReferenceToEnumInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastReferenceToEnumInstruction.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00052F94 File Offset: 0x00051194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026631, XrefRangeEnd = 1026707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastReferenceToEnumInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00006E26 File Offset: 0x00005026
		public CastReferenceToEnumInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00052FE4 File Offset: 0x000511E4
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x00006E2F File Offset: 0x0000502F
		public unsafe Type _t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastReferenceToEnumInstruction.NativeFieldInfoPtr__t);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastReferenceToEnumInstruction.NativeFieldInfoPtr__t), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr__t;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
