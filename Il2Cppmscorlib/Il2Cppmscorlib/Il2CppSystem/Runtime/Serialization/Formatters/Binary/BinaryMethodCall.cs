using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000353 RID: 851
	public sealed class BinaryMethodCall : Object
	{
		// Token: 0x060032EB RID: 13035 RVA: 0x00100B3C File Offset: 0x000FED3C
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryMethodCall()
		{
			Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryMethodCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr);
			BinaryMethodCall.NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "methodName");
			BinaryMethodCall.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "typeName");
			BinaryMethodCall.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "args");
			BinaryMethodCall.NativeFieldInfoPtr_callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "callContext");
			BinaryMethodCall.NativeFieldInfoPtr_argTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "argTypes");
			BinaryMethodCall.NativeFieldInfoPtr_bArgsPrimitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "bArgsPrimitive");
			BinaryMethodCall.NativeFieldInfoPtr_messageEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "messageEnum");
			BinaryMethodCall.NativeMethodInfoPtr_Write_Internal_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, 100671248);
			BinaryMethodCall.NativeMethodInfoPtr_Dump_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, 100671249);
			BinaryMethodCall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, 100671250);
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x00100C34 File Offset: 0x000FEE34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387238, RefRangeEnd = 1387239, XrefRangeStart = 1387221, XrefRangeEnd = 1387238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodCall.NativeMethodInfoPtr_Write_Internal_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x00100C78 File Offset: 0x000FEE78
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodCall.NativeMethodInfoPtr_Dump_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x00100CAC File Offset: 0x000FEEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387239, XrefRangeEnd = 1387240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryMethodCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodCall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x00011AE6 File Offset: 0x0000FCE6
		public BinaryMethodCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x00100CE8 File Offset: 0x000FEEE8
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x00011AEF File Offset: 0x0000FCEF
		public unsafe string methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x00100D10 File Offset: 0x000FEF10
		// (set) Token: 0x060032F3 RID: 13043 RVA: 0x00011B0E File Offset: 0x0000FD0E
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x00100D38 File Offset: 0x000FEF38
		// (set) Token: 0x060032F5 RID: 13045 RVA: 0x00011B2D File Offset: 0x0000FD2D
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x00100D68 File Offset: 0x000FEF68
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x00011B4C File Offset: 0x0000FD4C
		public unsafe Object callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x00100D98 File Offset: 0x000FEF98
		// (set) Token: 0x060032F9 RID: 13049 RVA: 0x00011B6B File Offset: 0x0000FD6B
		public unsafe Il2CppReferenceArray<Type> argTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_argTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_argTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060032FA RID: 13050 RVA: 0x00100DC8 File Offset: 0x000FEFC8
		// (set) Token: 0x060032FB RID: 13051 RVA: 0x00011B8A File Offset: 0x0000FD8A
		public unsafe bool bArgsPrimitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_bArgsPrimitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_bArgsPrimitive)) = value;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x00100DF0 File Offset: 0x000FEFF0
		// (set) Token: 0x060032FD RID: 13053 RVA: 0x00011BA5 File Offset: 0x0000FDA5
		public unsafe MessageEnum messageEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_messageEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_messageEnum)) = value;
			}
		}

		// Token: 0x04002A29 RID: 10793
		private static readonly IntPtr NativeFieldInfoPtr_methodName;

		// Token: 0x04002A2A RID: 10794
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04002A2B RID: 10795
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04002A2C RID: 10796
		private static readonly IntPtr NativeFieldInfoPtr_callContext;

		// Token: 0x04002A2D RID: 10797
		private static readonly IntPtr NativeFieldInfoPtr_argTypes;

		// Token: 0x04002A2E RID: 10798
		private static readonly IntPtr NativeFieldInfoPtr_bArgsPrimitive;

		// Token: 0x04002A2F RID: 10799
		private static readonly IntPtr NativeFieldInfoPtr_messageEnum;

		// Token: 0x04002A30 RID: 10800
		private static readonly IntPtr NativeMethodInfoPtr_Write_Internal_Void___BinaryWriter_0;

		// Token: 0x04002A31 RID: 10801
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Internal_Void_0;

		// Token: 0x04002A32 RID: 10802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
