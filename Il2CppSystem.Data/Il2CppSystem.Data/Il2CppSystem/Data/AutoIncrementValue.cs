using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000009 RID: 9
	public class AutoIncrementValue : Object
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x0000B718 File Offset: 0x00009918
		// Note: this type is marked as 'beforefieldinit'.
		static AutoIncrementValue()
		{
			Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "AutoIncrementValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr);
			AutoIncrementValue.NativeFieldInfoPtr__Auto_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, "<Auto>k__BackingField");
			AutoIncrementValue.NativeMethodInfoPtr_get_Auto_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663420);
			AutoIncrementValue.NativeMethodInfoPtr_set_Auto_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663421);
			AutoIncrementValue.NativeMethodInfoPtr_get_Current_Internal_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663422);
			AutoIncrementValue.NativeMethodInfoPtr_set_Current_Internal_Abstract_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663423);
			AutoIncrementValue.NativeMethodInfoPtr_get_Seed_Internal_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663424);
			AutoIncrementValue.NativeMethodInfoPtr_set_Seed_Internal_Abstract_Virtual_New_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663425);
			AutoIncrementValue.NativeMethodInfoPtr_get_Step_Internal_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663426);
			AutoIncrementValue.NativeMethodInfoPtr_set_Step_Internal_Abstract_Virtual_New_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663427);
			AutoIncrementValue.NativeMethodInfoPtr_get_DataType_Internal_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663428);
			AutoIncrementValue.NativeMethodInfoPtr_SetCurrent_Internal_Abstract_Virtual_New_Void_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663429);
			AutoIncrementValue.NativeMethodInfoPtr_SetCurrentAndIncrement_Internal_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663430);
			AutoIncrementValue.NativeMethodInfoPtr_MoveAfter_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663431);
			AutoIncrementValue.NativeMethodInfoPtr_Clone_Internal_AutoIncrementValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663432);
			AutoIncrementValue.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr, 100663433);
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000B874 File Offset: 0x00009A74
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		public unsafe bool Auto
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementValue.NativeMethodInfoPtr_get_Auto_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementValue.NativeMethodInfoPtr_set_Auto_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000B8F0 File Offset: 0x00009AF0
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000B93C File Offset: 0x00009B3C
		public unsafe virtual Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoIncrementValue.NativeMethodInfoPtr_get_Current_Internal_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoIncrementValue.NativeMethodInfoPtr_set_Current_Internal_Abstract_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000B98C File Offset: 0x00009B8C
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		public unsafe virtual long Seed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoIncrementValue.NativeMethodInfoPtr_get_Seed_Internal_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoIncrementValue.NativeMethodInfoPtr_set_Seed_Internal_Abstract_Virtual_New_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000BA20 File Offset: 0x00009C20
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000BA68 File Offset: 0x00009C68
		public unsafe virtual long Step
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoIncrementValue.NativeMethodInfoPtr_get_Step_Internal_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoIncrementValue.NativeMethodInfoPtr_set_Step_Internal_Abstract_Virtual_New_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000BAB4 File Offset: 0x00009CB4
		public unsafe virtual Type DataType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoIncrementValue.NativeMethodInfoPtr_get_DataType_Internal_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000BB00 File Offset: 0x00009D00
		[CallerCount(0)]
		public unsafe virtual void SetCurrent(Object value, IFormatProvider formatProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoIncrementValue.NativeMethodInfoPtr_SetCurrent_Internal_Abstract_Virtual_New_Void_Object_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000BB60 File Offset: 0x00009D60
		[CallerCount(0)]
		public unsafe virtual void SetCurrentAndIncrement(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoIncrementValue.NativeMethodInfoPtr_SetCurrentAndIncrement_Internal_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[CallerCount(0)]
		public unsafe virtual void MoveAfter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoIncrementValue.NativeMethodInfoPtr_MoveAfter_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000BBEC File Offset: 0x00009DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888406, XrefRangeEnd = 888415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoIncrementValue Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementValue.NativeMethodInfoPtr_Clone_Internal_AutoIncrementValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AutoIncrementValue>(intPtr3) : null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000BC2C File Offset: 0x00009E2C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoIncrementValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoIncrementValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementValue.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002526 File Offset: 0x00000726
		public AutoIncrementValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000BC68 File Offset: 0x00009E68
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000252F File Offset: 0x0000072F
		public unsafe bool _Auto_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementValue.NativeFieldInfoPtr__Auto_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementValue.NativeFieldInfoPtr__Auto_k__BackingField)) = value;
			}
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr__Auto_k__BackingField;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_get_Auto_Internal_get_Boolean_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_set_Auto_Internal_set_Void_Boolean_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_set_Current_Internal_Abstract_Virtual_New_set_Void_Object_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_get_Seed_Internal_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_set_Seed_Internal_Abstract_Virtual_New_set_Void_Int64_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_Step_Internal_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_set_Step_Internal_Abstract_Virtual_New_set_Void_Int64_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Internal_Abstract_Virtual_New_get_Type_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrent_Internal_Abstract_Virtual_New_Void_Object_IFormatProvider_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentAndIncrement_Internal_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_MoveAfter_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_AutoIncrementValue_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
