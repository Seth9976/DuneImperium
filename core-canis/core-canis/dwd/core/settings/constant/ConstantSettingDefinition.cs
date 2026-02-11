using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.constant
{
	// Token: 0x020000EB RID: 235
	public class ConstantSettingDefinition<T> : Object
	{
		// Token: 0x06000E02 RID: 3586 RVA: 0x0004AD98 File Offset: 0x00048F98
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantSettingDefinition()
		{
			Il2CppClassPointerStore<ConstantSettingDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.constant", "ConstantSettingDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantSettingDefinition<T>>.NativeClassPtr);
			ConstantSettingDefinition<T>.NativeFieldInfoPtr_setting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantSettingDefinition<T>>.NativeClassPtr, "setting");
			ConstantSettingDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantSettingDefinition<T>>.NativeClassPtr, 100665323);
			ConstantSettingDefinition<T>.NativeMethodInfoPtr_Get_Public_ConstantSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantSettingDefinition<T>>.NativeClassPtr, 100665324);
			ConstantSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantSettingDefinition<T>>.NativeClassPtr, 100665325);
			ConstantSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantSettingDefinition<T>>.NativeClassPtr, 100665326);
			ConstantSettingDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_ConstantSettingDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantSettingDefinition<T>>.NativeClassPtr, 100665327);
			ConstantSettingDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_ConstantSetting_1_T_ConstantSettingDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantSettingDefinition<T>>.NativeClassPtr, 100665328);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0004AE90 File Offset: 0x00049090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866903, XrefRangeEnd = 866914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantSettingDefinition(T value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantSettingDefinition<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstantSettingDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0004AF14 File Offset: 0x00049114
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantSetting<T> Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantSettingDefinition<T>.NativeMethodInfoPtr_Get_Public_ConstantSetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstantSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0004AF54 File Offset: 0x00049154
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISetting<T> dwd_core_settings_ISettingDefinition_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0004AF94 File Offset: 0x00049194
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISetting dwd_core_settings_ISettingDefinition_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting>(intPtr3) : null;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0004AFD4 File Offset: 0x000491D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866914, XrefRangeEnd = 866916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator T(ConstantSettingDefinition<T> definition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantSettingDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_ConstantSettingDefinition_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0004B014 File Offset: 0x00049214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866916, XrefRangeEnd = 866917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ConstantSetting<T>(ConstantSettingDefinition<T> definition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantSettingDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_ConstantSetting_1_T_ConstantSettingDefinition_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstantSetting<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00006C67 File Offset: 0x00004E67
		public ConstantSettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x0004B058 File Offset: 0x00049258
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x00006C70 File Offset: 0x00004E70
		public unsafe ConstantSetting<T> setting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantSettingDefinition<T>.NativeFieldInfoPtr_setting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantSetting<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantSettingDefinition<T>.NativeFieldInfoPtr_setting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr_setting;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_ConstantSetting_1_T_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_T_ConstantSettingDefinition_1_T_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ConstantSetting_1_T_ConstantSettingDefinition_1_T_0;
	}
}
