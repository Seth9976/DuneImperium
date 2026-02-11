using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000354 RID: 852
	public sealed class BinaryMethodReturn : Object
	{
		// Token: 0x060032FE RID: 13054 RVA: 0x00100E18 File Offset: 0x000FF018
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryMethodReturn()
		{
			Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryMethodReturn");
			BinaryMethodReturn.NativeFieldInfoPtr_returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "returnValue");
			BinaryMethodReturn.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "args");
			BinaryMethodReturn.NativeFieldInfoPtr_callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "callContext");
			BinaryMethodReturn.NativeFieldInfoPtr_argTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "argTypes");
			BinaryMethodReturn.NativeFieldInfoPtr_bArgsPrimitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "bArgsPrimitive");
			BinaryMethodReturn.NativeFieldInfoPtr_messageEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "messageEnum");
			BinaryMethodReturn.NativeFieldInfoPtr_returnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "returnType");
			BinaryMethodReturn.NativeFieldInfoPtr_instanceOfVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "instanceOfVoid");
			BinaryMethodReturn.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, 100671252);
			BinaryMethodReturn.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, 100671253);
			BinaryMethodReturn.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, 100671254);
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x00100F1C File Offset: 0x000FF11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387240, XrefRangeEnd = 1387241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryMethodReturn()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodReturn.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x00100F58 File Offset: 0x000FF158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387267, RefRangeEnd = 1387268, XrefRangeStart = 1387241, XrefRangeEnd = 1387267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodReturn.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x00100F9C File Offset: 0x000FF19C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodReturn.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x00011BC0 File Offset: 0x0000FDC0
		public BinaryMethodReturn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06003303 RID: 13059 RVA: 0x00100FD0 File Offset: 0x000FF1D0
		// (set) Token: 0x06003304 RID: 13060 RVA: 0x00011BC9 File Offset: 0x0000FDC9
		public unsafe Object returnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x00101000 File Offset: 0x000FF200
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x00011BE8 File Offset: 0x0000FDE8
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x00101030 File Offset: 0x000FF230
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x00011C07 File Offset: 0x0000FE07
		public unsafe Object callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x00101060 File Offset: 0x000FF260
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x00011C26 File Offset: 0x0000FE26
		public unsafe Il2CppReferenceArray<Type> argTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_argTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_argTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x0600330B RID: 13067 RVA: 0x00101090 File Offset: 0x000FF290
		// (set) Token: 0x0600330C RID: 13068 RVA: 0x00011C45 File Offset: 0x0000FE45
		public unsafe bool bArgsPrimitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_bArgsPrimitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_bArgsPrimitive)) = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x0600330D RID: 13069 RVA: 0x001010B8 File Offset: 0x000FF2B8
		// (set) Token: 0x0600330E RID: 13070 RVA: 0x00011C60 File Offset: 0x0000FE60
		public unsafe MessageEnum messageEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_messageEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_messageEnum)) = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600330F RID: 13071 RVA: 0x001010E0 File Offset: 0x000FF2E0
		// (set) Token: 0x06003310 RID: 13072 RVA: 0x00011C7B File Offset: 0x0000FE7B
		public unsafe Type returnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x00101110 File Offset: 0x000FF310
		// (set) Token: 0x06003312 RID: 13074 RVA: 0x00011C9A File Offset: 0x0000FE9A
		public unsafe static Object instanceOfVoid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryMethodReturn.NativeFieldInfoPtr_instanceOfVoid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryMethodReturn.NativeFieldInfoPtr_instanceOfVoid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A33 RID: 10803
		private static readonly IntPtr NativeFieldInfoPtr_returnValue;

		// Token: 0x04002A34 RID: 10804
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04002A35 RID: 10805
		private static readonly IntPtr NativeFieldInfoPtr_callContext;

		// Token: 0x04002A36 RID: 10806
		private static readonly IntPtr NativeFieldInfoPtr_argTypes;

		// Token: 0x04002A37 RID: 10807
		private static readonly IntPtr NativeFieldInfoPtr_bArgsPrimitive;

		// Token: 0x04002A38 RID: 10808
		private static readonly IntPtr NativeFieldInfoPtr_messageEnum;

		// Token: 0x04002A39 RID: 10809
		private static readonly IntPtr NativeFieldInfoPtr_returnType;

		// Token: 0x04002A3A RID: 10810
		private static readonly IntPtr NativeFieldInfoPtr_instanceOfVoid;

		// Token: 0x04002A3B RID: 10811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A3C RID: 10812
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002A3D RID: 10813
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
